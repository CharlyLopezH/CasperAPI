using AutoMapper;
using CasperAPI.DTOs;
using CasperAPI.Entidades;
using CasperAPI.Repositorios;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;

namespace CasperAPI.Endpoints
{
    public static class AdscripcionesEndpoints
    {
        public static RouteGroupBuilder MapAdscripciones(this RouteGroupBuilder group)
        {
            group.MapPost("/", Crear);
            group.MapGet("/", ObtenerAdscripciones).CacheOutput(c => c.Expire(TimeSpan.FromSeconds(30)).Tag("adscripciones-get"));
            return group;
        }

        static async Task<Ok<List<AdscripcionDTO>>> ObtenerAdscripciones(IRepositorioAdscripciones repositorio, IMapper mapper)
        {
            var adscripciones = await repositorio.ObtenerTodas();
            var adscripcionesDTO = mapper.Map<List<AdscripcionDTO>>(adscripciones);
            return TypedResults.Ok(adscripcionesDTO);
        }

        static async Task<Created<AdscripcionDTO>> Crear(CrearAdscripcionDTO crearAdscripcionDTO,
            IRepositorioAdscripciones repositorio, IOutputCacheStore outputCacheStore, IMapper mapper)
        {
            var adscripcion = mapper.Map<Adscripcion>(crearAdscripcionDTO);
            var id = await repositorio.Crear(adscripcion);
            await outputCacheStore.EvictByTagAsync("adscripciones-get", default);
            var adscripcionDTO = mapper.Map<AdscripcionDTO>(adscripcion);
            return TypedResults.Created($"/adscripciones/{id}", adscripcionDTO);
        }

    }
}

using AutoMapper;
using CasperAPI.DTOs;
using CasperAPI.Entidades;

namespace CasperAPI.Utilidades
{
    public class AutomapperProfiles: Profile
    {
        public AutomapperProfiles()
        {
            //            CreateMap<CrearEmpleadoDTO, Empleado>().ForMember(x=>x.Foto,opciones=>opciones.Ignore());
            CreateMap<CrearAdscripcionDTO,Adscripcion>();
            CreateMap<CrearEmpleadoDTO, Empleado>();
            CreateMap<Empleado,EmpleadoDTO>();
            CreateMap<Adscripcion,  AdscripcionDTO>();
        }
    }
}

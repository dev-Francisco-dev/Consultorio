using AutoMapper;
using Consultorio.Models.Dtos;
using Consultorio.Models.Entities;

namespace Consultorio.Helpers
{
    public class ConsultorioProfile : Profile
    {
        public ConsultorioProfile() 
        {
            CreateMap<Paciente, PacienteDetailsDto>();
            CreateMap<Consulta, ConsultaDto>()
                .ForMember(dest => dest.Especialidade, opt => opt.MapFrom(src =>  src.Especialidade.Nome))
                .ForMember(dest => dest.Profissional, opt => opt.MapFrom(src => src.Profissional.Nome));

            CreateMap<PacienteAdicionarDto, Paciente>();
            CreateMap<PacienteAtualizarDto, Paciente>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<Profissional, ProfissionalDtoDetails>()
                .ForMember(dest => dest.NumeroConsultas, opt => opt.MapFrom(src => src.Consultas.Count()))
                .ForMember(dest => dest.Especialidades, opt => opt.MapFrom(src => src.Especialidades.Select(x => x.Nome ).ToList()));

            CreateMap<Profissional, ProfissionalAllDto > ()
                .ForMember(des => des.TipoEspecialidades, opt => opt.MapFrom(x => x.Especialidades.Select(x => x.Nome) ))
                .ForMember(des => des.NumeroConsultas, opt => opt.MapFrom(x => x.Consultas.Count() ));

            CreateMap<ProfissionalAdicionarDto, Profissional>();
            CreateMap<ProfissionalAtualizarDto, Profissional>()
                 .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null)); 


        }
    }
}

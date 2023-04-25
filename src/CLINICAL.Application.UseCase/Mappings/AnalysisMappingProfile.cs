using AutoMapper;
using CLINICAL.Application.Dtos.Analysis.Response;
using CLINICAL.Domain.Entitites;

namespace CLINICAL.Application.UseCase.Mappings
{
    public class AnalysisMappingProfile : Profile
    {
        public AnalysisMappingProfile()
        {
            CreateMap<Analysis, GetAllAnalysisResponseDto>()
                .ForMember(x => x.StateAnalysis, x => x.MapFrom(x => x.State == 1 ? "Activo" : "Inactivo"));
        }
    }
}

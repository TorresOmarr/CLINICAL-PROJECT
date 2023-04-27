using AutoMapper;
using CLINICAL.Application.Interface;
using CLINICAL.Domain.Commons.Bases;
using MediatR;
using Entity = CLINICAL.Domain.Entitites;
namespace CLINICAL.Application.UseCase.UseCases.Analysis.Commands.CreateCommand
{
    public class CreateAnalysisHandler : IRequestHandler<CreateAnalysisCommand, BaseResponse<bool>>
    {
        private readonly IAnalysisRepository _analysisRepository;
        private readonly IMapper _mapper;

        public CreateAnalysisHandler(IAnalysisRepository analysisRepository, IMapper mapper)
        {
            _analysisRepository = analysisRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<bool>> Handle(CreateAnalysisCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<bool>();
            try
            {

                var analysis = _mapper.Map<Entity.Analysis>(request);
                response.Data = await _analysisRepository.AnalysisRegister(analysis);
                if (response.Data)
                {
                    response.IsSucces =true;
                    response.Message = "Se registro correctamente";
                    return response;
                }
                response.IsSucces = false;
                return response;

            }catch (Exception ex)
            {
                response.IsSucces = false;
                response.Message = ex.Message;
                return response;
            }
        }
    }
}

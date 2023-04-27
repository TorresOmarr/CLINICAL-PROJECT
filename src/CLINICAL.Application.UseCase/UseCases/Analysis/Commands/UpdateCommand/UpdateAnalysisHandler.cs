using AutoMapper;
using CLINICAL.Application.Interface;
using CLINICAL.Domain.Commons.Bases;
using MediatR;
using Entity = CLINICAL.Domain.Entitites;

namespace CLINICAL.Application.UseCase.UseCases.Analysis.Commands.UpdateCommand
{
    public class UpdateAnalysisHandler : IRequestHandler<UpdateAnalysisCommand, BaseResponse<bool>>
    {
        private readonly IAnalysisRepository _analysisRepository;
        private readonly IMapper _mapper;

        public UpdateAnalysisHandler(IAnalysisRepository analysisRepository, IMapper mapper)
        {
            _analysisRepository = analysisRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<bool>> Handle(UpdateAnalysisCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<bool>();
            try
            {
                var analysis = _mapper.Map<Entity.Analysis>(request);
                response.Data = await _analysisRepository.AnalysisEdit(analysis);
                if (response.Data)
                {
                    response.IsSucces = true;
                    response.Message = "Actualizacion Exitosa!!";
                }
            }
            catch (Exception ex)
            {
                response.IsSucces = false;
                response.Message = ex.Message; 
            }

            return response;
        }
    }
}

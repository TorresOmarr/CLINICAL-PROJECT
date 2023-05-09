namespace CLINICAL.Domain.Commons.Bases
{
    public class BaseResponse<T>
    {
        public bool IsSucces { get; set; }
        public T? Data { get; set; }
        public string? Message { get; set; }
<<<<<<< Updated upstream:src/CLINICAL.Application.UseCase/Commons/Bases/BaseResponse.cs
        public IEnumerable<BaseError>? Errors { get; set; }
=======
        public IEnumerable<BaseError>? Errors { get; set; } 
>>>>>>> Stashed changes:src/CLINICAL.Domain/Commons/Bases/BaseResponse.cs
    }
}

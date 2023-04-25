namespace CLINICAL.Domain.Commons.Bases
{
    public class BaseResponse<T>
    {
        public bool isSucces { get; set; }
        public T? Data { get; set; }
        public string? Message { get; set; }
        public IEnumerable<BaseError> Errors { get; set; }
    }
}

namespace CQRSExample.Models
{
    public class ApiResultPattern<T>
    {
        public bool IsSuccess { get { return string.IsNullOrWhiteSpace(Error); } }
        public T Data { get; set; }
        public string Error { get; set; }

        protected ApiResultPattern() { }

        protected ApiResultPattern(T data) { Data = data; }
        protected ApiResultPattern(string error) { Error = error; } 

        public static ApiResultPattern<T> Success(T data) => new ApiResultPattern<T>(data);
        public static ApiResultPattern<T> Fail(string error) => new ApiResultPattern<T>(error);
    }
}

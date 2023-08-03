using System.Net;

namespace AspNetIdentity.Core.Common
{
    public class ServiceResponse<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Error { get; set; }
        public string Message { get; set; }
        public string Content { get; set; }

        public bool Success { get; set; } = false;
        public T Result { get; set; }
    }
}

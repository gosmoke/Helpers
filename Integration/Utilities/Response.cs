using System.Collections.Generic;
using System.Net;

namespace Integration
{
    public class Response<T> : IResponse<T>
    {
        public T Content { get; set; }
        public IEnumerable<ServiceMessage> Messages { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}

using System.Collections.Generic;
using System.Net;

namespace Integration
{
    public interface IResponse<T>
    {
        T Content { get; set; }
        IEnumerable<ServiceMessage> Messages { get; set; }
        HttpStatusCode StatusCode { get; set; }
    }
}

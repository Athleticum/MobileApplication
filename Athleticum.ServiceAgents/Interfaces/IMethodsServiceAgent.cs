using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Athleticum.ServiceAgents.Interfaces
{
    public interface IMethodsServiceAgent<T>
    {
        Task<T> GetMethodAsync(string action, Dictionary<string, object> parameters);

        Task<T> PostMethodAsync(string action, object body);

        Task<T> PutMethodAsync(string action, object body);

        Task DeleteMethodAsync(string action, int id);
    }
}

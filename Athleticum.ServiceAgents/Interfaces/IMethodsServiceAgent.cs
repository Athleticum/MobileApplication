using Athleticum.ServiceAgents.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Athleticum.ServiceAgents.Interfaces
{
    public interface IMethodsServiceAgent<T>
    {
        Task<T> GetMethodAsync(Request request);

        Task<T> PostMethodAsync(Request body);

        Task<T> PutMethodAsync(Request body);

        Task<T> DeleteMethodAsync(Request request);
    }
}

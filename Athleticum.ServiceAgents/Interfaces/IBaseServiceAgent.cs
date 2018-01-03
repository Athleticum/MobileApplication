using Athleticum.DataTransferObjects;
using Athleticum.ServiceAgents.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Athleticum.ServiceAgents.Interfaces
{
    public interface IBaseServiceAgent
    {
        Task<object> AddAsync(Request objectToAdd);

        Task<object> UpdateAsync(Request objectToUpdate);

        Task DeleteAsync(Request objectToDelete);

        Task<object> GetByPropertiesAsync(Request objectToGet);

        Task<object> GetAllAsync(Request objectsToGet);
    }
}

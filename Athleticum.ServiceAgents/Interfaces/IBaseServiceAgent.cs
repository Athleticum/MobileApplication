using Athleticum.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Athleticum.ServiceAgents.Interfaces
{
    public interface IBaseServiceAgent
    {
        Task<ObjectDTO> AddAsync(ObjectDTO objectToAdd);

        Task<ObjectDTO> UpdateAsync(ObjectDTO objectToAdd);

        Task DeleteAsync(ObjectDTO objectToAdd);

        Task<ObjectDTO> GetByIdAsync(ObjectDTO objectToAdd);

        Task<IList<ObjectDTO>> GetAllAsync(ObjectDTO objectToAdd);
    }
}

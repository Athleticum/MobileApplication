using Athleticum.ServiceAgents.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Athleticum.DataTransferObjects;
using System.Threading.Tasks;

namespace Athleticum.ServiceAgents.Classes
{
    class BaseServiceAgent : IBaseServiceAgent
    {
        public Task<ObjectDTO> AddAsync(ObjectDTO objectToAdd)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ObjectDTO objectToAdd)
        {
            throw new NotImplementedException();
        }

        public Task<IList<ObjectDTO>> GetAllAsync(ObjectDTO objectToAdd)
        {
            throw new NotImplementedException();
        }

        public Task<ObjectDTO> GetByIdAsync(ObjectDTO objectToAdd)
        {
            throw new NotImplementedException();
        }

        public Task<ObjectDTO> UpdateAsync(ObjectDTO objectToAdd)
        {
            throw new NotImplementedException();
        }
    }
}

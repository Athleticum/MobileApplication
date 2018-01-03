using Athleticum.ServiceAgents.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Athleticum.DataTransferObjects;
using System.Threading.Tasks;

namespace Athleticum.Common.Operations.Classes
{
    public static class ObjectOperations
    {
        private static IDictionary<Type, IBaseServiceAgent> TypeToServiceDictionary = new Dictionary<Type, IBaseServiceAgent>{};

        public static async Task<object> AddAsync(ObjectDTO objectToAdd)
        {
            return await TypeToServiceDictionary[objectToAdd.GetType()].AddAsync(objectToAdd);
        }

        public static async Task DeleteAsync(ObjectDTO objectToDelete)
        {
            await TypeToServiceDictionary[objectToDelete.GetType()].DeleteAsync(objectToDelete.Id);
        }

        public static async Task<object> GetAllAsync(Type objectType)
        {
            return await TypeToServiceDictionary[objectType].GetAllAsync();
        }

        public static async Task<object> GetByPropertiesAsync(Type objectType, IDictionary<string, object> properties)
        {
            return await TypeToServiceDictionary[objectType].GetByPropertiesAsync(properties);
        }

        public static async Task<object> UpdateAsync(ObjectDTO objectToUpdate)
        {
            return await TypeToServiceDictionary[objectToUpdate.GetType()].UpdateAsync(objectToUpdate);
        }
    }
}

using Athleticum.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Athleticum.ServiceAgents.Classes
{
    public class Request
    {
        public ObjectDTO objectDTO { get; set; }

        public IList<ObjectDTO> objectDTOs { get; set; }
    }
}

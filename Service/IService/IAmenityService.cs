using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Client.Service.IService
{
    public interface IAmenityService
    {
        public Task<IEnumerable<AmenityDTO>> GetAllAmentiy();
        

        
    }
}

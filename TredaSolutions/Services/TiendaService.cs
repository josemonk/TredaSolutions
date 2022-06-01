using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TredaSolutions.Domains.IRepositories;
using TredaSolutions.Domains.IServices;
using TredaSolutions.Domains.Models;

namespace TredaSolutions.Services
{
    public class TiendaService : ITiendaService
    {
        public readonly ITiendaRepository _tiendaRepository;
        public TiendaService(ITiendaRepository tiendaRepository )
        {
            _tiendaRepository = tiendaRepository;
        }

        public async Task SaveTienda(Tienda tienda)
        {
           await  _tiendaRepository.SaveTienda(tienda);
        }
        public async Task<bool> ValidateName(Tienda tienda)
        {
          var validateExistence= await  _tiendaRepository.ValidateName(tienda);
            return validateExistence;
        }
    }
}

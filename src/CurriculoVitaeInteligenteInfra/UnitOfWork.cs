using CurriculoVitaeInteligenteInfra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteInfra
{
   public class UnitOfWork
    {
        private readonly CVIContext _context;
        public UnitOfWork(CVIContext context)
        {
            _context = context;
        }

        public async Task Save()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

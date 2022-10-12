using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;


namespace CurriculoVitaeInteligenteInfra
{
   public class UnitOfWork : IUnitOfWork
    {
        private readonly CVIContext _context;
        public UnitOfWork(CVIContext context) =>
                  _context = context;
            
        public async Task<bool> Commit()
        {
            var success = (await _context.SaveChangesAsync()) > 0;

            return success;
        }

        public Task Rollback()
        {
            return Task.CompletedTask;
        }
    }
}

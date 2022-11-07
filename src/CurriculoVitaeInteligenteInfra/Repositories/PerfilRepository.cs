using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class PerfilRepository : BaseRepository<Perfil>, IPerfilRepository
    {
        public PerfilRepository(CVIContext context) : base(context)
        {
        }
        public override async Task<Perfil?> Get(string id)
        {
            try
            {
                if (id == null)
                {
                    throw new Exception("ID INVALIDO");
                }
                Perfil? TEntity = await _context.Set<Perfil>()
                .Include(p => p.Nacionalidade!)
                .Include(p => p.Segmento!)
                .Include(p => p.Endereco!)
                .ThenInclude(p => p.Cidade!)
                .Include(p => p.Endereco!)
                .ThenInclude(p => p.Estado!)
                .ThenInclude(p => p.Pais!)
                .Include(p => p.Escolaridade!)
                .Include(p => p.Contato!)
                .Include(p => p.Objetivo!)
                .Include(p => p.Idioma!)
                .Include(p => p.HistoricoProfissional!)
                .ThenInclude(p => p.Cargo!)
                .Include(p => p.HistoricoProfissional!)
                .ThenInclude(p => p.Segmento!)
                .Include(p => p.HistoricoProfissional!)
                .ThenInclude(p => p.Contato!)
                .Include(p => p.HistoricoProfissional!)
                .ThenInclude(p => p.Cidade!)
                .Include(p => p.CursoFormacaoAcademica!)
                .ThenInclude(p => p.Curso)!
                .FirstOrDefaultAsync((Perfil m) => m.Id == Guid.Parse(id));
                if (TEntity == null)
                {
                    throw new Exception("erro ao consultar Id" + id);
                }
                return TEntity;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

       
    }
}

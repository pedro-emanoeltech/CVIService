using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;
using Microsoft.EntityFrameworkCore;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class CandidaturaRepository : BaseRepository<Candidatura> , ICandidaturaRepository
    {
        public CandidaturaRepository(CVIContext context) : base(context)
        {
        }
        public override async Task<Candidatura?> Get(string id)
        {
            try
            {
                if (id == null)
                {
                    throw new Exception("ID INVALIDO");
                }
                Candidatura? TEntity = await _context.Set<Candidatura>()
                .Include(p => p.Perfil)
                    .ThenInclude(p => p.Nacionalidade)
                .Include(p => p.Perfil)
                    .ThenInclude(p => p.Segmento!)
                .Include(p => p.Perfil)
                    .ThenInclude(p => p.Endereco!)
                .Include(p => p.Perfil)
                    .ThenInclude(p => p.Endereco!)
                        .ThenInclude(p => p.Cidade!)
                .Include(p => p.Perfil)
                    .ThenInclude(p => p.Endereco!)
                     .ThenInclude(p => p.Estado!)
                .Include(p => p.Perfil)
                  .ThenInclude(p => p.Escolaridade!)
                .Include(p => p.Perfil)
                  .ThenInclude(p => p.Contato!)
                .Include(p => p.Perfil)
                  .ThenInclude(p => p.Objetivo!)
                .Include(p => p.Perfil)
                .ThenInclude(p => p.Idioma!)
                .Include(p => p.Perfil)
                  .ThenInclude(p => p.HistoricoProfissional!)
                   .ThenInclude(p => p.Cargo!)
                .Include(p => p.Perfil)
                    .ThenInclude(p => p.HistoricoProfissional!)
                        .ThenInclude(p => p.Segmento!)
                 .Include(p => p.Perfil)
                    .ThenInclude(p => p.HistoricoProfissional!)
                    .ThenInclude(p => p.Contato!)
                 .Include(p => p.Perfil)
                    .ThenInclude(p => p.HistoricoProfissional!)
                        .ThenInclude(p => p.Cidade!)
                 .Include(p => p.Perfil)
                     .ThenInclude(p => p.CursoFormacaoAcademica!)
                        .ThenInclude(p => p.Curso)
                 .Include(p => p.Perfil)
                    .ThenInclude(p => p.CursoFormacaoAcademica!)
                        .ThenInclude(p => p.Cidade)
                  .Include(p => p.Vaga)
                        .ThenInclude(p => p.Contato!)
                     .Include(p => p.Vaga)
                        .ThenInclude(p => p.Cidade)
                        .Include(p => p.Vaga)
                        .ThenInclude(p => p.Estado)
                .FirstOrDefaultAsync(p => p.Id == Guid.Parse(id));

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

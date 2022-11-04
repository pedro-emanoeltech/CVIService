using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;

namespace CurriculoVitaeInteligenteApp.Services
{
    public class SegmentoServiceApp : BaseServiceApp<Segmento>, ISegmentoServiceApp
    {
        public SegmentoServiceApp(ISegmentoService service,IUnitOfWork unitOfWork, IMapper mapper) : base(service, mapper, unitOfWork)
        {
        }
       
    }
}

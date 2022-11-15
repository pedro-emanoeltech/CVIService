using CVIServiceLibShared.Constants.Enums;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Contato : BaseEntityComData
    {
        public Guid? PerfilId { get; set; }
        public TipoContato TipoContato { get; set; }
        public string? Texto { get; set; }

    }
}

using CVIServiceLibShared.Constants.Enums;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class TokenAuth : BaseEntityConta
    {
        public string? Email { get; set; }
        public string? Token { get; set; }
        public TipoConta? Role { get; set; }
        public DateTime? DataExpiracao { get; set; }
        public int? ExpiryTimeStamp { get; set; }
    }
}

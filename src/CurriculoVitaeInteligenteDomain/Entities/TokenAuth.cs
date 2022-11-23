namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class TokenAuth : BaseEntityConta
    {
        public string? Email { get; set; }
        public string? Token { get; set; }
        public string? Role { get; set; }
        public DateTime? DataExpiracao { get; set; }
        public int? ExpiryTimeStamp { get; set; }
    }
}

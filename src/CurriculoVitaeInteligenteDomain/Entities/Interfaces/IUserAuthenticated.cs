using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities.Interfaces
{
    public interface IUserAuthenticated
    {
        public Guid? ContaId { get; set; }
        public string? Role { get; set; }
    }
}

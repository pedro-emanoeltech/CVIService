using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteApp.DTOs.Response
{
    public abstract class BaseResponse
    {
        public Guid? Id { get; set; }

        public DateTime? DateCreate { get; set; }

        public DateTime? DateUpdate { get; set; }
    }
}

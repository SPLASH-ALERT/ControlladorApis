using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace api_Proyecto.Models
{
    public partial class Causa
    {
        public int IdCausa { get; set; }
        public string? Causa1 { get; set; }
        public DateTime? FechaCausa { get; set; }
        public int? IdUsuario { get; set; }

        [JsonIgnore]
        public virtual Usuario? IdUsuarioNavigation { get; set; }
    }
}

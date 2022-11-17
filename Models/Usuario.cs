using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace api_Proyecto.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Causas = new HashSet<Causa>();
        }

        public int IdUsuario { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? NombreUsuario { get; set; }
        public string? Contrasena { get; set; }
        public string? Correo { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Estado { get; set; }
        public int? IdRol { get; set; }
        public string? Tokken { get; set; }
        public DateTime? FechaCreacion { get; set; }

        [JsonIgnore]
        public virtual Role? IdRolNavigation { get; set; }
        [JsonIgnore]
        public virtual ICollection<Causa> Causas { get; set; }
    }
}

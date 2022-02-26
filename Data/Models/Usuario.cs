using ProyectWaterUi.Data.Models.Base;
using ProyectWaterUi.Data.Models;

namespace ProyectWaterUi.Data.Models
{
    public class Usuario: Modelo_usuarios
    {
        
        public string? Nombre { get; set; }
        public string? domicilio { get; set; }
        public DateTime Nacimiento{ get; set; }
        public int? Id_Medidor { get; set; }
        public string? Correo { get; set; }
        public virtual Medidor? Medidor { get; set; } = default!;
        public virtual IList<Blogs>? Blogs { get; set; } = default!;

        


    }
}
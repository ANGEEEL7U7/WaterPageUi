using ProyectWaterUi.Data.Models.Base;

namespace ProyectWaterUi.Data.Models
{
    public class Blogs: Modelo_Blogs
    {
        public string? UrlFoto { get; set; }
        public double? Uso_Agua { get; set; }
        public string? Ubicacion { get; set; }
        public string? Opinion { get; set; }
        public int? Id_usuario { get; set; }
        public int? Id_Medidor_fk { get; set; }
        public virtual Medidor? Medidor { get; set; }
        public virtual Usuario? Usuarios { get; set; }
    }
}
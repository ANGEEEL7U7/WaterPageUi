
using ProyectWaterUi.Data.Models.Base;

namespace ProyectWaterUi.Data.Models
{
    public class BlogEmpresa: Modelo_BlogEmpresa
    {
        public string? UrlFoto_E { get; set; }
        public double Uso_Agua_E { get; set; }
        public string? Ubicacion_E { get; set; }
        public string? Opinion_E { get; set; }
        public int Id_empresa { get; set; }
        public int Id_Medidor_fk_E { get; set; }
     
         public virtual Medidor? Medidor { get; set; }
        public virtual Empresas? Empresas { get; set; }

    }
}
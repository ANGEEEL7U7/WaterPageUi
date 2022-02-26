using ProyectWaterUi.Data.Models.Base;

namespace ProyectWaterUi.Data.Models
{
    public class Empresas : Modelo_Empresa
    {
        
        public int Rfc { get; set; }
        public string? Nombre_E { get; set; }
        public string? Contasenia_E { get; set; }
        public string? Ubicacion_E { get; set; }
        public DateTime Fecha_Regristro { get; set; }
        public int Id_Medidor_E { get; set; }
        public string? Correo_E { get; set; }
        public virtual Medidor? Medidor { get; set; }
        public virtual List<BlogEmpresa>? BlogEmpresas { get; set; }

    }
}
using ProyectWaterUi.Data.Models.Base;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ProyectWaterUi.Data.Models
{
    public class Medidor 
    {
        
        public int Id_Medidor { get; set; } = 0;
        public string? Marca { get; set; }
        public string? Proveedor { get; set; }
    }
}
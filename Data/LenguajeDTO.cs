using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace RealidadVirtualServer.Data
{
    public class LenguajeCreate
    {
        public string? Imagen { get; set; }
        
        public string Descripcion { get; set; } = null!;
        
        public string Titulo { get; set; } = null!;

        public List<AnexoCreate> Anexos { get; set; } = new List<AnexoCreate>();
    }

    public class LenguajeConsultar
    {
        [JsonProperty("lenguajeid")]
        public int Lenguajeid { get; set; }
        [JsonProperty("imagen")]
        public string? Imagen { get; set; }
        [JsonProperty("descripcion")]
        public string Descripcion { get; set; } = null!;
        [JsonProperty("titulo")]
        public string Titulo { get; set; } = null!;
        [JsonProperty("anexos")]
        public List<AnexoConsultar> Anexos { get; set; } = new List<AnexoConsultar>();
    }
}

using Newtonsoft.Json;

namespace RealidadVirtualServer.Data
{
    public class AnexoCreate
    {        
        public string Descripcion { get; set; } = null!;
        
        public string? Url { get; set; }
    }

    public class AnexoConsultar
    {
        [JsonProperty("anexoid")]
        public int Anexoid { get; set; }
        [JsonProperty("descripcion")]
        public string Descripcion { get; set; } = null!;
        [JsonProperty("url")]
        public string? Url { get; set; }
    }
}
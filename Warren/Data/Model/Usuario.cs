using System.Text.Json.Serialization;

namespace Data.Model
{
    public class Usuario : BaseModel
    {
        public string Email { get; set; } = String.Empty;
        [JsonIgnore]
        public string Senha { get; set; } = String.Empty;
        public string Nome { get; set; } = String.Empty;
    }
}

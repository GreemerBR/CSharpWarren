using System.Text.Json.Serialization;

namespace Data.Model
{
    public class Usuario : BaseModel
    {
        public string Email { get; set; }
        [JsonIgnore]
        public string Senha { get; set; }
        public string Nome { get; set; }
    }
}

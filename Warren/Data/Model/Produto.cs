using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Data.Model
{
    public class Produto : BaseModel
    {
        public string Nome { get; set; } = String.Empty;
        public decimal Preco { get; set; }
        public int CategoriaId { get; set; }

        [JsonIgnore]
        [ForeignKey("CategoriaId")]
        public Categoria? Categoria { get; set; }
    }
}

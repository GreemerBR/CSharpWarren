namespace Data.Model
{
    public class Categoria : BaseModel
    {
        public string Nome { get; set; } = String.Empty;
        public string Descricao { get; set; } = String.Empty;

        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}

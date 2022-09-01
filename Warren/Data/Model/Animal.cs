namespace Data.Model
{
    public class Animal : BaseModel
    {
        public string Especie { get; set; } = String.Empty;
        public string Nome { get; set; } = String.Empty;
        public float Peso { get; set; }
    }
}

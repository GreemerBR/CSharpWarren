namespace Data.Model
{
    public class Usuario : BaseModel
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
    }
}

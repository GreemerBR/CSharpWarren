namespace Console._1___TipoReferencia.Animais
{
    internal class Animal : BaseModel
    {

        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }

        public Animal(string nome, string especie, string raca)
        {
            Nome = nome;
            Especie = especie;
            Raca = raca;
        }

        public virtual string Comer()
        {
            return $"O animal: {this.Nome}, está comendo";
        } 
    }
}

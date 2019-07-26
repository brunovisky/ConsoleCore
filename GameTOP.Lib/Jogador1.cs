using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : IJogador
    {
        public string Nome { get; set; }

        public Jogador1(string nome)
        {
            this.Nome = nome;
        }
        public string Chutar ()
        {
            return $"{this.Nome} esta chutando.";
        }

        public string Correr ()
        {
            return $"{this.Nome} esta correndo.";
        }

        public string Passar ()
        {
            return $"{this.Nome} esta passando.";
        }
    }
}
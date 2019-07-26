using System;
using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly IJogador Jogador1;
        private readonly IJogador Jogador2;

        public JogoFODA(IJogador jogador1, IJogador jogador2)
        {
            this.Jogador1 = jogador1;
            this.Jogador2 = jogador2;
        }
        public void IniciarJogo(){
            Console.WriteLine(this.Jogador1.Correr());
            Console.WriteLine(this.Jogador1.Passar());
            Console.WriteLine(this.Jogador1.Chutar());

            Console.WriteLine(this.Jogador2.Correr());
            Console.WriteLine(this.Jogador2.Passar());
            Console.WriteLine(this.Jogador2.Chutar());
        }
    }
}
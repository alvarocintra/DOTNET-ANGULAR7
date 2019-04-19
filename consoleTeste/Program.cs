using System;
using consoleTeste.Lib;

namespace consoleTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda(
                new Jogador3(), 
                new Jogador1("Ronaldo")
            );
            jogo.IniciarJogo();
        }
    }
    
}

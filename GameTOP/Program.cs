﻿using GameTOP.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo=new JogoFODA(new Jogador1("Filipe"),new Jogador2());
            jogo.IniciarJogo();
        }
    }
}

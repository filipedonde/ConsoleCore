using System;
using GameTOP.Interface;

namespace GameTOP.Lib
{

    public class Jogador1 : IJogador
    {
        public string Nome { get; }
        public Jogador1(string nome)
        {
            this.Nome = nome;
        }

        public string Chutar()
        {
            return $"O jogador {Nome} está chutando";
        }

        public string Correr()
        {
            return $"O jogador {Nome} está correndo";
        }

        public string Passe()
        {
            return $"O jogador {Nome} está dando um passe";
        }
    }
}

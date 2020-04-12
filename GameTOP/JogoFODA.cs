using System;
using GameTOP.Interface;
namespace GameTOP
{
    class JogoFODA
    {
        private readonly IJogador _jogadorA;
        private readonly IJogador _jogadorB;

        public JogoFODA(IJogador jogadorA,IJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
            Console.WriteLine(_jogadorA.Chutar());
            Console.WriteLine(_jogadorA.Correr());
            Console.WriteLine(_jogadorA.Passe());

            Console.Write("\n PRÓXIMO JOGADOR \n \n");

            Console.WriteLine(_jogadorB.Chutar());
            Console.WriteLine(_jogadorB.Correr());
            Console.WriteLine(_jogadorB.Passe());
        }
    }
}

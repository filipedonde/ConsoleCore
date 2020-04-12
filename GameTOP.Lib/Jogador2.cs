using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : IJogador
    {
        public string Nome => "Maradona";

        public string Chutar()
        {
            return $"O jogador {Nome} estas pateando.";
        }

        public string Correr()
        {
            return $"O jogador {Nome} estas corriendo.";
        }

        public string Passe()
        {
            return $"O jogador {Nome} estas passando.";
        }
    }
}
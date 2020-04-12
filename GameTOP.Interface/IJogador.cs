namespace GameTOP.Interface
{
    public interface IJogador
    {
        string Nome { get; }

        string Chutar();
        string Correr();
        string Passe();
    }
}

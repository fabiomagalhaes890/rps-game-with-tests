namespace RpsLib.Models
{
    public class Jogador
    {
        public string Nome { get; set; }

        public ElementoJogada Jogada { get; set; }
        
        public Jogador() { }

        public Jogador(string nomeJogador, ElementoJogada jogada)
        {
            Nome = nomeJogador;
            Jogada = jogada;
        }
    }
}

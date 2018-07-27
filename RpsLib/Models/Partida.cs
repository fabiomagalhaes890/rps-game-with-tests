using System.Collections.Generic;

namespace RpsLib.Models
{
    public class Partida
    {
        public Jogador Vencedor { get; set; }

        public List<Jogador> Jogadores { get; set; }

        public Partida()
        {
            Jogadores = new List<Jogador>();
        }

        public void AdicionarJogador(Jogador jogador)
        {
            Jogadores.Add(jogador);
        }

        public List<Jogador> CarregarJogadoresIncluidos()
        {
            return Jogadores;
        }
    }
}

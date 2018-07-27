using System.Collections.Generic;

namespace RpsLib.Models
{
    public class Torneio
    {
        public Jogador Vencedor { get; set; }

        public List<Partida> Partidas { get; set; }

        public Torneio()
        {
            Partidas = new List<Partida>();
        }

        public void AdicionarPartidas(Partida partida)
        {
            Partidas.Add(partida);
        }

        public List<Partida> CarregarPartidasIncluidas()
        {
            return Partidas;
        }
    }
}

using System.Collections.Generic;

namespace RpsLib.Models
{
    public class Torneio
    {
        public Jogador Vencedor { get; set; }

        public List<Partida> Partidas { get; set; }
    }
}

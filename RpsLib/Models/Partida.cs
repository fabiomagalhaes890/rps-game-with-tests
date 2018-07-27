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
    }
}

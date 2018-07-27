using RpsLib.Exceptions;
using RpsLib.Models;
using System.Collections.Generic;

namespace RpsLib.BusinessRule
{
    public class Jogo
    {
        public Torneio RealizarDisputasTorneio(List<Partida> partidas)
        {
            var torneio = new Torneio();

            torneio.Vencedor = Recursao(partidas, partidas.Count, null);

            return torneio;
        }

        private Jogador Recursao(List<Partida> partidas, int total, Jogador vencedor)
        {
            if (total == 0)
                return vencedor;

            var p1 = partidas[0];
            var v1 = RealizarDisputaPartida(p1).Vencedor;

            partidas.Remove(p1);

            var ganhou = Recursao(partidas, partidas.Count, v1);
            return IdentificarMaiorElemento(vencedor, ganhou);
        }

        public Partida RealizarDisputaPartida(Partida partida)
        {
            var jogadores = partida.CarregarJogadoresIncluidos();
            foreach (var jogador in jogadores)
                if (jogador.Jogada != (ElementoJogada)'R' && jogador.Jogada != (ElementoJogada)'S' && jogador.Jogada != (ElementoJogada)'P')
                    throw new NoSuchStrategyError();
            
            if (jogadores.Count > 2 || jogadores.Count == 0)
                throw new WrongNumberOfPlayersError();

            partida.Vencedor = RealizarDisputaEmDupla(jogadores[0], jogadores[1]);
            return partida;
        }

        public Jogador RealizarDisputaEmDupla(Jogador primeiroJogador, Jogador segundoJogador)
        {
            if (string.IsNullOrEmpty(primeiroJogador.Nome) || string.IsNullOrEmpty(segundoJogador.Nome))
                throw new NotInformedNameError();

            if (primeiroJogador.Jogada == 0 || segundoJogador.Jogada == 0)
                throw new ElementWasNotSelectedError();

            return IdentificarMaiorElemento(primeiroJogador, segundoJogador);
        }

        private Jogador IdentificarMaiorElemento(Jogador primeiroElemento, Jogador segundoElemento)
        {
            if (primeiroElemento == null)
                return segundoElemento;

            if (segundoElemento== null)
                return primeiroElemento;

            if (primeiroElemento.Jogada == segundoElemento.Jogada)
                return primeiroElemento;
            else if (((ElementoJogada.PAPER == primeiroElemento.Jogada) && (ElementoJogada.ROCK == segundoElemento.Jogada))
                        || ((ElementoJogada.ROCK == primeiroElemento.Jogada) && (ElementoJogada.SCISSOR == segundoElemento.Jogada))
                        || ((ElementoJogada.SCISSOR == primeiroElemento.Jogada) && (ElementoJogada.PAPER == segundoElemento.Jogada)))
                return primeiroElemento;                        
            else if (((ElementoJogada.PAPER == segundoElemento.Jogada) && (ElementoJogada.ROCK == primeiroElemento.Jogada))
                        || ((ElementoJogada.ROCK == segundoElemento.Jogada) && (ElementoJogada.SCISSOR == primeiroElemento.Jogada))
                        || ((ElementoJogada.SCISSOR == segundoElemento.Jogada) && (ElementoJogada.PAPER == primeiroElemento.Jogada)))
                return segundoElemento;            
            else
                return new Jogador();
        }
    }
}

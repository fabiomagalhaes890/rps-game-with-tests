using RpsLib.Exceptions;
using RpsLib.Models;
using System;
using System.Collections.Generic;

namespace RpsLib.BusinessRule
{
    public class Jogo
    {
        public Torneio RealizarDisputasTorneio(List<Partida> partidas)
        {
            var torneio = new Torneio();



            return torneio;
        }

        public Partida RealizarDisputaPartida(List<Jogador> jogadores)
        {
            var partida = new Partida();
            partida.Jogadores = jogadores;

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
            if (string.IsNullOrEmpty(primeiroJogador.Nome))
                throw new Exception("Nome do primeiro jogador não informado.");

            if (string.IsNullOrEmpty(segundoJogador.Nome))
                throw new Exception("Nome do segundo jogador não informado.");

            if (primeiroJogador.Jogada == 0)
                throw new Exception("Primeiro jogador não selecionou um elemento.");

            if (segundoJogador.Jogada == 0)
                throw new Exception("Segundo jogador não selecionou um elemento.");

            if ((primeiroJogador.Jogada == ElementoJogada.PAPER && segundoJogador.Jogada == ElementoJogada.PAPER)
                || (primeiroJogador.Jogada == ElementoJogada.ROCK && segundoJogador.Jogada == ElementoJogada.ROCK)
                || (primeiroJogador.Jogada == ElementoJogada.SCISSOR && segundoJogador.Jogada == ElementoJogada.SCISSOR))
                return primeiroJogador;

            else if ((primeiroJogador.Jogada == ElementoJogada.PAPER && segundoJogador.Jogada == ElementoJogada.ROCK)
                || (primeiroJogador.Jogada == ElementoJogada.ROCK && segundoJogador.Jogada == ElementoJogada.SCISSOR)
                || (primeiroJogador.Jogada == ElementoJogada.SCISSOR && segundoJogador.Jogada == ElementoJogada.PAPER))
                return primeiroJogador;

            else if ((segundoJogador.Jogada == ElementoJogada.PAPER && primeiroJogador.Jogada == ElementoJogada.ROCK)
                || (segundoJogador.Jogada == ElementoJogada.ROCK && primeiroJogador.Jogada == ElementoJogada.SCISSOR)
                || (segundoJogador.Jogada == ElementoJogada.SCISSOR && primeiroJogador.Jogada == ElementoJogada.PAPER))
                return segundoJogador;

            else
                return new Jogador();
        }
    }
}

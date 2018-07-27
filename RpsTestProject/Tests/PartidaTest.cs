using Microsoft.VisualStudio.TestTools.UnitTesting;
using RpsLib.BusinessRule;
using RpsLib.Exceptions;
using RpsLib.Models;
using System.Collections.Generic;

namespace RpsTestProject.Tests
{
    [TestClass]
    public class PartidaTest
    {
        [TestMethod]
        public void DadaUmaPartidaOndeDoisJogadoresUtilizaremPedraPartidaDeveConterDoisJogadoresVencedorSeraPrimeiroAJogarPedra()
        {
            var listaJogadores = new List<Jogador>();
            var vencedorEsperado = new Jogador("Joao", (ElementoJogada)'R');

            listaJogadores.Add(vencedorEsperado);
            listaJogadores.Add(new Jogador("Jamilton", (ElementoJogada)'R'));

            var resultadoPartida = new Jogo().RealizarDisputaPartida(listaJogadores);

            Assert.AreEqual(2, resultadoPartida.Jogadores.Count);
            Assert.AreEqual(vencedorEsperado, resultadoPartida.Vencedor);
        }

        [TestMethod]
        public void DadaUmaPartidaOndeDoisJogadoresUtilizaremTesouraPartidaDeveConterDoisJogadoresVencedorSeraPrimeiroAJogarTesoura()
        {
            var listaJogadores = new List<Jogador>();
            var vencedorEsperado = new Jogador("Joao", (ElementoJogada)'S');

            listaJogadores.Add(vencedorEsperado);
            listaJogadores.Add(new Jogador("Jamilton", (ElementoJogada)'S'));

            var resultadoPartida = new Jogo().RealizarDisputaPartida(listaJogadores);

            Assert.AreEqual(2, resultadoPartida.Jogadores.Count);
            Assert.AreEqual(vencedorEsperado, resultadoPartida.Vencedor);
        }

        [TestMethod]
        public void DadaUmaPartidaOndeDoisJogadoresUtilizaremPapelPartidaDeveConterDoisJogadoresVencedorSeraPrimeiroAJogarPapel()
        {
            var listaJogadores = new List<Jogador>();
            var vencedorEsperado = new Jogador("Joao", (ElementoJogada)'P');

            listaJogadores.Add(vencedorEsperado);
            listaJogadores.Add(new Jogador("Jamilton", (ElementoJogada)'P'));

            var resultadoPartida = new Jogo().RealizarDisputaPartida(listaJogadores);

            Assert.AreEqual(2, resultadoPartida.Jogadores.Count);
            Assert.AreEqual(vencedorEsperado, resultadoPartida.Vencedor);
        }

        [TestMethod]
        public void DadaUmaPartidaOndePrimeiroJogadorUsaElementoPedraSegundoUtilizaElementoPapelPartidaDeveConterDoisJogadoresVencedorSeraSegundoJogador()
        {
            var listaJogadores = new List<Jogador>();
            var vencedorEsperado = new Jogador("Jamilton", (ElementoJogada)'P');

            listaJogadores.Add(new Jogador("Joao", (ElementoJogada)'R'));
            listaJogadores.Add(vencedorEsperado);

            var resultadoPartida = new Jogo().RealizarDisputaPartida(listaJogadores);

            Assert.AreEqual(2, resultadoPartida.Jogadores.Count);
            Assert.AreEqual(vencedorEsperado, resultadoPartida.Vencedor);
        }

        [TestMethod]
        public void DadaUmaPartidaOndePrimeiroJogadorUsaElementoPedraSegundoUtilizaElementoTesouraPartidaDeveConterDoisJogadoresVencedorSeraPrimeiroJogador()
        {
            var listaJogadores = new List<Jogador>();
            var vencedorEsperado = new Jogador("Joao", (ElementoJogada)'R');

            listaJogadores.Add(new Jogador("Jamilton", (ElementoJogada)'S'));
            listaJogadores.Add(vencedorEsperado);

            var resultadoPartida = new Jogo().RealizarDisputaPartida(listaJogadores);

            Assert.AreEqual(2, resultadoPartida.Jogadores.Count);
            Assert.AreEqual(vencedorEsperado, resultadoPartida.Vencedor);
        }

        [TestMethod]
        public void DadaUmaPartidaOndePrimeiroJogadorUsaElementoPapelSegundoUtilizaElementoPedraPartidaDeveConterDoisJogadoresVencedorSeraPrimeiroJogador()
        {
            var listaJogadores = new List<Jogador>();
            var vencedorEsperado = new Jogador("Joao", (ElementoJogada)'P');

            listaJogadores.Add(new Jogador("Jamilton", (ElementoJogada)'R'));
            listaJogadores.Add(vencedorEsperado);

            var resultadoPartida = new Jogo().RealizarDisputaPartida(listaJogadores);

            Assert.AreEqual(2, resultadoPartida.Jogadores.Count);
            Assert.AreEqual(vencedorEsperado, resultadoPartida.Vencedor);
        }

        [TestMethod]
        public void DadaUmaPartidaOndePrimeiroJogadorUsaElementoPapelSegundoUtilizaElementoTesouraPartidaDeveConterDoisJogadoresVencedorSeraSegundoJogador()
        {
            var listaJogadores = new List<Jogador>();
            var vencedorEsperado = new Jogador("Jamilton", (ElementoJogada)'S');

            listaJogadores.Add(new Jogador("Joao", (ElementoJogada)'P'));
            listaJogadores.Add(vencedorEsperado);

            var resultadoPartida = new Jogo().RealizarDisputaPartida(listaJogadores);

            Assert.AreEqual(2, resultadoPartida.Jogadores.Count);
            Assert.AreEqual(vencedorEsperado, resultadoPartida.Vencedor);
        }

        [TestMethod]
        public void DadaUmaPartidaOndePrimeiroJogadorUsaElementoTesouraSegundoUtilizaElementoPapelPartidaDeveConterDoisJogadoresVencedorSeraPrimeiroJogador()
        {
            var listaJogadores = new List<Jogador>();
            var vencedorEsperado = new Jogador("Joao", (ElementoJogada)'S');

            listaJogadores.Add(new Jogador("Jamilton", (ElementoJogada)'P'));
            listaJogadores.Add(vencedorEsperado);

            var resultadoPartida = new Jogo().RealizarDisputaPartida(listaJogadores);

            Assert.AreEqual(2, resultadoPartida.Jogadores.Count);
            Assert.AreEqual(vencedorEsperado, resultadoPartida.Vencedor);
        }

        [TestMethod]
        public void DadaUmaPartidaOndePrimeiroJogadorUsaElementoTesouraSegundoUtilizaElementoPedraPartidaDeveConterDoisJogadoresVencedorSeraSegundoJogador()
        {
            var listaJogadores = new List<Jogador>();
            var vencedorEsperado = new Jogador("Jamilton", (ElementoJogada)'R');

            listaJogadores.Add(new Jogador("Joao", (ElementoJogada)'S'));
            listaJogadores.Add(vencedorEsperado);

            var resultadoPartida = new Jogo().RealizarDisputaPartida(listaJogadores);

            Assert.AreEqual(2, resultadoPartida.Jogadores.Count);
            Assert.AreEqual(vencedorEsperado, resultadoPartida.Vencedor);
        }

        [TestMethod]
        [ExpectedException(typeof(WrongNumberOfPlayersError), "Wrong number of players error.")]
        public void DadaUmaPartidaOndeInformarMaisDeDoisJogadoresDeveraRetornarWrongNumberOfPlayersError()
        {
            var listaJogadores = new List<Jogador>();

            listaJogadores.Add(new Jogador("Joao", (ElementoJogada)'S'));
            listaJogadores.Add(new Jogador("Jamilton", (ElementoJogada)'R'));
            listaJogadores.Add(new Jogador("Josue", (ElementoJogada)'R'));

            new Jogo().RealizarDisputaPartida(listaJogadores);
        }

        [TestMethod]
        [ExpectedException(typeof(WrongNumberOfPlayersError), "Wrong number of players error.")]
        public void DadaUmaPartidaOndeNaoInformarJogadoresDeveraRetornarWrongNumberOfPlayersError()
        {
            var listaJogadores = new List<Jogador>();

            new Jogo().RealizarDisputaPartida(listaJogadores);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchStrategyError), "No such strategy error.")]
        public void DadaUmaPartidaOndeAlgumJogadorInformarElementoNaoExistenteDeveraRetornarNoSuchStrategyError()
        {
            var listaJogadores = new List<Jogador>();

            listaJogadores.Add(new Jogador("Joao", (ElementoJogada)'x'));
            listaJogadores.Add(new Jogador("Jamilton", (ElementoJogada)'R'));

            new Jogo().RealizarDisputaPartida(listaJogadores);
        }
    }
}

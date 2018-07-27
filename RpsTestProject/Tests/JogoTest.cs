using Microsoft.VisualStudio.TestTools.UnitTesting;
using RpsLib.BusinessRule;
using RpsLib.Exceptions;
using RpsLib.Models;
using System;

namespace RpsTestProject.Tests
{
    [TestClass]
    public class JogoTest
    {
        [TestMethod]
        public void DadaUmaJogadaOndeDoisJogadoresUtilizaremPedraOPrimeiroJogadorDeveraSerOVencedor()
        {
            var jogador1 = new Jogador("Joao", ElementoJogada.ROCK);
            var jogador2 = new Jogador("Jamilton", ElementoJogada.ROCK);

            var vencedor = new Jogo().RealizarDisputaEmDupla(jogador1, jogador2);

            Assert.AreEqual(jogador1, vencedor);
        }

        [TestMethod]
        public void DadaUmaJogadaOndeDoisJogadoresUtilizaremPapelOPrimeiroJogadorDeveraSerOVencedor()
        {
            var jogador1 = new Jogador("Joao", ElementoJogada.PAPER);
            var jogador2 = new Jogador("Jamilton", ElementoJogada.PAPER);

            var vencedor = new Jogo().RealizarDisputaEmDupla(jogador1, jogador2);

            Assert.AreEqual(jogador1, vencedor);
        }

        [TestMethod]
        public void DadaUmaJogadaOndeDoisJogadoresUtilizaremTesouraOPrimeiroJogadorDeveraSerOVencedor()
        {
            var jogador1 = new Jogador("Joao", ElementoJogada.SCISSOR);
            var jogador2 = new Jogador("Jamilton", ElementoJogada.SCISSOR);

            var vencedor = new Jogo().RealizarDisputaEmDupla(jogador1, jogador2);

            Assert.AreEqual(jogador1, vencedor);
        }

        [TestMethod]
        public void DadaUmaJogadaOndePrimeiroJogadorInformaPapelEOutroInformaTesouraEntaoQuemJogouTesouraDeveraSerOVencedor()
        {
            var jogador1 = new Jogador("Joao", ElementoJogada.PAPER);
            var jogador2 = new Jogador("Jamilton", ElementoJogada.SCISSOR);

            var vencedor = new Jogo().RealizarDisputaEmDupla(jogador1, jogador2);

            Assert.AreEqual(jogador2, vencedor);
        }

        [TestMethod]
        public void DadaUmaJogadaOndePrimeiroJogadorInformaPapelEOutroInformaPedraEntaoQuemJogouPapelDeveraSerOVencedor()
        {
            var jogador1 = new Jogador("Joao", ElementoJogada.PAPER);
            var jogador2 = new Jogador("Jamilton", ElementoJogada.ROCK);

            var vencedor = new Jogo().RealizarDisputaEmDupla(jogador1, jogador2);

            Assert.AreEqual(jogador1, vencedor);
        }

        [TestMethod]
        public void DadaUmaJogadaOndePrimeiroJogadorInformaPedraEOutroInformaTesouraEntaoQuemJogouPapelDeveraSerOVencedor()
        {
            var jogador1 = new Jogador("Joao", ElementoJogada.ROCK);
            var jogador2 = new Jogador("Jamilton", ElementoJogada.SCISSOR);

            var vencedor = new Jogo().RealizarDisputaEmDupla(jogador1, jogador2);

            Assert.AreEqual(jogador1, vencedor);
        }

        [TestMethod]
        public void DadaUmaJogadaOndePrimeiroJogadorInformaPedraEOutroInformaPapelEntaoQuemJogouPapelDeveraSerOVencedor()
        {
            var jogador1 = new Jogador("Joao", ElementoJogada.ROCK);
            var jogador2 = new Jogador("Jamilton", ElementoJogada.PAPER);

            var vencedor = new Jogo().RealizarDisputaEmDupla(jogador1, jogador2);

            Assert.AreEqual(jogador2, vencedor);
        }

        [TestMethod]
        public void DadaUmaJogadaOndePrimeiroJogadorInformaTesouraEOutroInformaPapelEntaoQuemJogouPapelDeveraSerOVencedor()
        {
            var jogador1 = new Jogador("Joao", ElementoJogada.SCISSOR);
            var jogador2 = new Jogador("Jamilton", ElementoJogada.PAPER);

            var vencedor = new Jogo().RealizarDisputaEmDupla(jogador1, jogador2);

            Assert.AreEqual(jogador1, vencedor);
        }

        [TestMethod]
        public void DadaUmaJogadaOndePrimeiroJogadorInformaTesouraEOutroInformaPedraEntaoQuemJogouPapelDeveraSerOVencedor()
        {
            var jogador1 = new Jogador("Joao", ElementoJogada.SCISSOR);
            var jogador2 = new Jogador("Jamilton", ElementoJogada.ROCK);

            var vencedor = new Jogo().RealizarDisputaEmDupla(jogador1, jogador2);

            Assert.AreEqual(jogador2, vencedor);
        }

        [TestMethod]
        [ExpectedException(typeof(NotInformedNameError), "Not informed name error.")]
        public void DadaUmaJogadaOndePrimeiroJogadorNaoTiverNomeInformadoDeveraRetornarMensagemErroNotInformedNameError()
        {
            var jogador1 = new Jogador(string.Empty, ElementoJogada.SCISSOR);
            var jogador2 = new Jogador("Jamilton", ElementoJogada.ROCK);

            new Jogo().RealizarDisputaEmDupla(jogador1, jogador2);
        }

        [TestMethod]
        [ExpectedException(typeof(NotInformedNameError), "Not informed name error.")]
        public void DadaUmaJogadaOndeSegundoJogadorNaoTiverNomeInformadoDeveraRetornarMensagemErroNotInformedNameError()
        {
            var jogador1 = new Jogador("Joao", ElementoJogada.SCISSOR);
            var jogador2 = new Jogador(string.Empty, ElementoJogada.ROCK);

            new Jogo().RealizarDisputaEmDupla(jogador1, jogador2);
        }

        [TestMethod]
        [ExpectedException(typeof(ElementWasNotSelectedError), "Element was not selected error.")]
        public void DadaUmaJogadaOndePrimeiroJogadorNaoTiverElementoInformadoDeveraRetornarMensagemErroElementWasNotSelectedError()
        {
            var jogador1 = new Jogador("Joao", 0);
            var jogador2 = new Jogador("Jamilton", ElementoJogada.ROCK);

            new Jogo().RealizarDisputaEmDupla(jogador1, jogador2);
        }

        [TestMethod]
        [ExpectedException(typeof(ElementWasNotSelectedError), "Element was not selected error.")]
        public void DadaUmaJogadaOndeSegundoJogadorNaoTiverElementoInformadoDeveraRetornarMensagemErroElementWasNotSelectedError()
        {
            var jogador1 = new Jogador("Joao", ElementoJogada.SCISSOR);
            var jogador2 = new Jogador("Jamilton", 0);

            new Jogo().RealizarDisputaEmDupla(jogador1, jogador2);
        }
    }
}

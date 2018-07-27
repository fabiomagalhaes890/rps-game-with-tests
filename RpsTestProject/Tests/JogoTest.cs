using Microsoft.VisualStudio.TestTools.UnitTesting;
using RpsLib.BusinessRule;
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
        [ExpectedException(typeof(Exception), "Nome do primeiro jogador não informado.")]
        public void DadaUmaJogadaOndePrimeiroJogadorNaoTiverNomeInformadoDeveraRetornarMensagemErroNomePrimeiroJogadorNaoInformado()
        {
            var jogador1 = new Jogador("", ElementoJogada.SCISSOR);
            var jogador2 = new Jogador("Jamilton", ElementoJogada.ROCK);

            new Jogo().RealizarDisputaEmDupla(jogador1, jogador2);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Nome do segundo jogador não informado.")]
        public void DadaUmaJogadaOndeSegundoJogadorNaoTiverNomeInformadoDeveraRetornarMensagemErroNomeSegundoJogadorNaoInformado()
        {
            var jogador1 = new Jogador("Joao", ElementoJogada.SCISSOR);
            var jogador2 = new Jogador("", ElementoJogada.ROCK);

            new Jogo().RealizarDisputaEmDupla(jogador1, jogador2);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Primeiro jogador não selecionou um elemento.")]
        public void DadaUmaJogadaOndePrimeiroJogadorNaoTiverElementoInformadoDeveraRetornarMensagemErroPrimeiroJogadorNaoInformouElemento()
        {
            var jogador1 = new Jogador("Joao", 0);
            var jogador2 = new Jogador("Jamilton", ElementoJogada.ROCK);

            new Jogo().RealizarDisputaEmDupla(jogador1, jogador2);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Segundo jogador não selecionou um elemento.")]
        public void DadaUmaJogadaOndeSegundoJogadorNaoTiverElementoInformadoDeveraRetornarMensagemErroSegundoJogadorNaoInformouElemento()
        {
            var jogador1 = new Jogador("Joao", ElementoJogada.SCISSOR);
            var jogador2 = new Jogador("Jamilton", 0);

            new Jogo().RealizarDisputaEmDupla(jogador1, jogador2);
        }
    }
}

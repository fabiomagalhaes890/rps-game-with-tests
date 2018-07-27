using Microsoft.VisualStudio.TestTools.UnitTesting;
using RpsLib.BusinessRule;
using RpsLib.Exceptions;
using RpsLib.Models;

namespace RpsTestProject.Tests
{
    [TestClass]
    public class PartidaTest
    {
        [TestMethod]
        public void DadaUmaPartidaOndeDoisJogadoresUtilizaremPedraPartidaDeveConterDoisJogadoresVencedorSeraPrimeiroAJogarPedra()
        {
            var vencedorEsperado = new Jogador("Joao", (ElementoJogada)'R');

            var partida = new Partida();
            partida.AdicionarJogador(vencedorEsperado);
            partida.AdicionarJogador(new Jogador("Jamilton", (ElementoJogada)'R'));

            partida = new Jogo().RealizarDisputaPartida(partida);

            Assert.AreEqual(2, partida.Jogadores.Count);
            Assert.AreEqual(vencedorEsperado, partida.Vencedor);
        }

        [TestMethod]
        public void DadaUmaPartidaOndeDoisJogadoresUtilizaremTesouraPartidaDeveConterDoisJogadoresVencedorSeraPrimeiroAJogarTesoura()
        {
            var vencedorEsperado = new Jogador("Joao", (ElementoJogada)'S');

            var partida = new Partida();
            partida.AdicionarJogador(vencedorEsperado);
            partida.AdicionarJogador(new Jogador("Jamilton", (ElementoJogada)'S'));

            partida = new Jogo().RealizarDisputaPartida(partida);

            Assert.AreEqual(2, partida.Jogadores.Count);
            Assert.AreEqual(vencedorEsperado, partida.Vencedor);
        }

        [TestMethod]
        public void DadaUmaPartidaOndeDoisJogadoresUtilizaremPapelPartidaDeveConterDoisJogadoresVencedorSeraPrimeiroAJogarPapel()
        {
            var vencedorEsperado = new Jogador("Joao", (ElementoJogada)'P');

            var partida = new Partida();
            partida.AdicionarJogador(vencedorEsperado);
            partida.AdicionarJogador(new Jogador("Jamilton", (ElementoJogada)'P'));

            partida = new Jogo().RealizarDisputaPartida(partida);

            Assert.AreEqual(2, partida.Jogadores.Count);
            Assert.AreEqual(vencedorEsperado, partida.Vencedor);
        }

        [TestMethod]
        public void DadaUmaPartidaOndePrimeiroJogadorUsaElementoPedraSegundoUtilizaElementoPapelPartidaDeveConterDoisJogadoresVencedorSeraSegundoJogador()
        {
            var vencedorEsperado = new Jogador("Jamilton", (ElementoJogada)'P');

            var partida = new Partida();
            partida.AdicionarJogador(new Jogador("Joao", (ElementoJogada)'R'));
            partida.AdicionarJogador(vencedorEsperado);

            partida = new Jogo().RealizarDisputaPartida(partida);

            Assert.AreEqual(2, partida.Jogadores.Count);
            Assert.AreEqual(vencedorEsperado, partida.Vencedor);
        }

        [TestMethod]
        public void DadaUmaPartidaOndePrimeiroJogadorUsaElementoPedraSegundoUtilizaElementoTesouraPartidaDeveConterDoisJogadoresVencedorSeraPrimeiroJogador()
        {
            var vencedorEsperado = new Jogador("Joao", (ElementoJogada)'R');

            var partida = new Partida();
            partida.AdicionarJogador(new Jogador("Jamilton", (ElementoJogada)'S'));
            partida.AdicionarJogador(vencedorEsperado);

            partida = new Jogo().RealizarDisputaPartida(partida);

            Assert.AreEqual(2, partida.Jogadores.Count);
            Assert.AreEqual(vencedorEsperado, partida.Vencedor);
        }

        [TestMethod]
        public void DadaUmaPartidaOndePrimeiroJogadorUsaElementoPapelSegundoUtilizaElementoPedraPartidaDeveConterDoisJogadoresVencedorSeraPrimeiroJogador()
        {
            var vencedorEsperado = new Jogador("Joao", (ElementoJogada)'P');

            var partida = new Partida();
            partida.AdicionarJogador(new Jogador("Jamilton", (ElementoJogada)'R'));
            partida.AdicionarJogador(vencedorEsperado);

            partida = new Jogo().RealizarDisputaPartida(partida);

            Assert.AreEqual(2, partida.Jogadores.Count);
            Assert.AreEqual(vencedorEsperado, partida.Vencedor);
        }

        [TestMethod]
        public void DadaUmaPartidaOndePrimeiroJogadorUsaElementoPapelSegundoUtilizaElementoTesouraPartidaDeveConterDoisJogadoresVencedorSeraSegundoJogador()
        {
            var vencedorEsperado = new Jogador("Jamilton", (ElementoJogada)'S');

            var partida = new Partida();
            partida.AdicionarJogador(new Jogador("Joao", (ElementoJogada)'P'));
            partida.AdicionarJogador(vencedorEsperado);

            partida = new Jogo().RealizarDisputaPartida(partida);

            Assert.AreEqual(2, partida.Jogadores.Count);
            Assert.AreEqual(vencedorEsperado, partida.Vencedor);
        }

        [TestMethod]
        public void DadaUmaPartidaOndePrimeiroJogadorUsaElementoTesouraSegundoUtilizaElementoPapelPartidaDeveConterDoisJogadoresVencedorSeraPrimeiroJogador()
        {
            var vencedorEsperado = new Jogador("Joao", (ElementoJogada)'S');

            var partida = new Partida();
            partida.AdicionarJogador(new Jogador("Jamilton", (ElementoJogada)'P'));
            partida.AdicionarJogador(vencedorEsperado);

            partida = new Jogo().RealizarDisputaPartida(partida);

            Assert.AreEqual(2, partida.Jogadores.Count);
            Assert.AreEqual(vencedorEsperado, partida.Vencedor);
        }

        [TestMethod]
        public void DadaUmaPartidaOndePrimeiroJogadorUsaElementoTesouraSegundoUtilizaElementoPedraPartidaDeveConterDoisJogadoresVencedorSeraSegundoJogador()
        {
            var vencedorEsperado = new Jogador("Jamilton", (ElementoJogada)'R');

            var partida = new Partida();
            partida.AdicionarJogador(new Jogador("Joao", (ElementoJogada)'S'));
            partida.AdicionarJogador(vencedorEsperado);

            partida = new Jogo().RealizarDisputaPartida(partida);

            Assert.AreEqual(2, partida.Jogadores.Count);
            Assert.AreEqual(vencedorEsperado, partida.Vencedor);
        }

        [TestMethod]
        [ExpectedException(typeof(WrongNumberOfPlayersError), "Wrong number of players error.")]
        public void DadaUmaPartidaOndeInformarMaisDeDoisJogadoresDeveraRetornarWrongNumberOfPlayersError()
        {
            var partida = new Partida();
            partida.AdicionarJogador(new Jogador("Joao", (ElementoJogada)'S'));
            partida.AdicionarJogador(new Jogador("Jamilton", (ElementoJogada)'R'));
            partida.AdicionarJogador(new Jogador("Josue", (ElementoJogada)'R'));

            new Jogo().RealizarDisputaPartida(partida);
        }

        [TestMethod]
        [ExpectedException(typeof(WrongNumberOfPlayersError), "Wrong number of players error.")]
        public void DadaUmaPartidaOndeNaoInformarJogadoresDeveraRetornarWrongNumberOfPlayersError()
        {
            var partida = new Partida();
            new Jogo().RealizarDisputaPartida(partida);
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchStrategyError), "No such strategy error.")]
        public void DadaUmaPartidaOndeAlgumJogadorInformarElementoNaoExistenteDeveraRetornarNoSuchStrategyError()
        {
            var partida = new Partida();
            partida.AdicionarJogador(new Jogador("Joao", (ElementoJogada)'x'));
            partida.AdicionarJogador(new Jogador("Jamilton", (ElementoJogada)'R'));

            new Jogo().RealizarDisputaPartida(partida);
        }
    }
}

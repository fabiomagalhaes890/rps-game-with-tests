using Microsoft.VisualStudio.TestTools.UnitTesting;
using RpsLib.BusinessRule;
using RpsLib.Models;

namespace RpsTestProject.Tests
{
    [TestClass]
    public class TorneioTest
    {
        [TestMethod]
        public void DadoUmTorneioComQuatroJogadoresEDuasPartidasIniciaisOVencedorDeveraSerRichard()
        {
            var armando = new Jogador("Armando", (ElementoJogada)'P');
            var dave = new Jogador("Dave", (ElementoJogada)'S');
            var richard = new Jogador("Richard", (ElementoJogada)'R');
            var michael = new Jogador("Michael", (ElementoJogada)'S');
            
            var partida1 = new Partida();
            partida1.AdicionarJogador(armando);
            partida1.AdicionarJogador(dave);

            var partida2 = new Partida();
            partida2.AdicionarJogador(richard);
            partida2.AdicionarJogador(michael);

            var torneio = new Torneio();
            torneio.AdicionarPartidas(partida1);
            torneio.AdicionarPartidas(partida2);

            torneio = new Jogo().RealizarDisputasTorneio(torneio.CarregarPartidasIncluidas());

            Assert.AreEqual(richard, torneio.Vencedor);
        }

        [TestMethod]
        public void DadoUmTorneioComQuatroJogadoresEDuasPartidasIniciaisOVencedorDeveraSerAllen()
        {

            var allen = new Jogador("Allen", (ElementoJogada)'S');
            var omer = new Jogador("Omer", (ElementoJogada)'P');
            var davidE = new Jogador("David E.", (ElementoJogada)'R');
            var richardX = new Jogador("Richard X.", (ElementoJogada)'P');

            
            var partida3 = new Partida();
            partida3.AdicionarJogador(allen);
            partida3.AdicionarJogador(omer);

            var partida4 = new Partida();
            partida4.AdicionarJogador(davidE);
            partida4.AdicionarJogador(richardX);

            var torneio = new Torneio();
            torneio.AdicionarPartidas(partida3);
            torneio.AdicionarPartidas(partida4);

            torneio = new Jogo().RealizarDisputasTorneio(torneio.CarregarPartidasIncluidas());

            Assert.AreEqual(allen, torneio.Vencedor);
        }

        [TestMethod]
        public void DadoUmTorneioComOitoJogadoresEQuatroPartidasIniciaisOVencedorDeveraSerRichard()
        {
            var armando = new Jogador("Armando", (ElementoJogada)'P');
            var dave = new Jogador("Dave", (ElementoJogada)'S');
            var richard = new Jogador("Richard", (ElementoJogada)'R');
            var michael = new Jogador("Michael", (ElementoJogada)'S');

            var allen = new Jogador("Allen", (ElementoJogada)'S');
            var omer = new Jogador("Omer", (ElementoJogada)'P');
            var davidE = new Jogador("David E.", (ElementoJogada)'R');
            var richardX = new Jogador("Richard X.", (ElementoJogada)'P');

            var partida1 = new Partida();
            partida1.AdicionarJogador(armando);
            partida1.AdicionarJogador(dave);

            var partida2 = new Partida();
            partida2.AdicionarJogador(richard);
            partida2.AdicionarJogador(michael);

            var partida3 = new Partida();
            partida3.AdicionarJogador(allen);
            partida3.AdicionarJogador(omer);

            var partida4 = new Partida();
            partida4.AdicionarJogador(davidE);
            partida4.AdicionarJogador(richardX);

            var torneio = new Torneio();
            torneio.AdicionarPartidas(partida1);
            torneio.AdicionarPartidas(partida2);
            torneio.AdicionarPartidas(partida3);
            torneio.AdicionarPartidas(partida4);

            torneio = new Jogo().RealizarDisputasTorneio(torneio.CarregarPartidasIncluidas());

            Assert.AreEqual(richard, torneio.Vencedor);
        }
    }
}

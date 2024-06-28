using NUnit.Framework;
using RockPaperScissors.Actions;
using RockPaperScissors.Tests.TestImplementations;

namespace RockPaperScissors.Tests
{
    public class GameManagerTests
    {
        [Test]
        public void RockBeatsScissors()
        {
            var gm = new GameManager(new AlwaysPicksRock(), new AlwaysPicksScissors());

            var result = gm.PlayRound();

            Assert.AreEqual(RoundResult.PlayerWins, result);
            Assert.AreEqual(1, gm.Wins);
            Assert.AreEqual(0, gm.Losses);
            Assert.AreEqual(0, gm.Ties);
        }

        [Test]
        public void PaperBeatsRock()
        {
            var gm = new GameManager(new AlwaysPicksRock(), new AlwaysPicksPaper());

            var result = gm.PlayRound();
            
            Assert.AreEqual(RoundResult.ComputerWins, result);
            Assert.AreEqual(0, gm.Wins);
            Assert.AreEqual(1, gm.Losses);
            Assert.AreEqual(0, gm.Ties);
        }

        [Test]
        public void ScissorsBeatsPaper()
        {
            var gm = new GameManager(new AlwaysPicksScissors(), new AlwaysPicksPaper());

            var result = gm.PlayRound();

            Assert.AreEqual(RoundResult.PlayerWins, result);
            Assert.AreEqual(1, gm.Wins);
            Assert.AreEqual(0, gm.Losses);
            Assert.AreEqual(0, gm.Ties);
        }

        [Test]
        public void CanTieRound()
        {
            var gm = new GameManager(new AlwaysPicksRock(), new AlwaysPicksRock());

            var result = gm.PlayRound();

            Assert.AreEqual(RoundResult.Tie, result);
            Assert.AreEqual(0, gm.Wins);
            Assert.AreEqual(0, gm.Losses);
            Assert.AreEqual(1, gm.Ties);
        }
    }
}

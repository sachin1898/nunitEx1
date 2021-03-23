using NUnit.Framework;
using System.Collections.Generic;


namespace ConsoleAppTestExample
{
    [TestFixture]
    public class PlayerTest
    {
        List<Player> pList = new List<Player>() { 
        new Player(){PlayerId=1,PlayerName="virat kohli",PlayerTeam="india"},
        new Player(){PlayerId=2,PlayerName="joe root",PlayerTeam="england"},
        new Player(){PlayerId=3,PlayerName="david warner",PlayerTeam="australia"}
        };
        [Test]
        public void CheckNull()
        {
            foreach(var p in pList)
            {
                Assert.NotZero(p.PlayerId);
                Assert.NotNull(p.PlayerName);
                Assert.NotNull(p.PlayerTeam);
            }
        }

    }
}

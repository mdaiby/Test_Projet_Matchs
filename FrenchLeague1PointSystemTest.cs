using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointSystemLib;
using FrenchLeague1PointSystemLib;
using Matchs_Lib;
namespace Matchs_LibTest
{
    [TestClass]
    public class FrenchLeague1PointSystemTest
    {
        
        [TestMethod]
        public void TestInstance()
        {
            FrenchLeague1PointSystem Pleague = new FrenchLeague1PointSystem();
            PointSystem PS = FrenchLeague1PointSystem.Instance;
            Assert.AreEqual(PS, FrenchLeague1PointSystem.Instance);
           
        }
        [TestMethod]
        public void TestInitialPoint()
        {
            FrenchLeague1PointSystem FL = new FrenchLeague1PointSystem();
            PointSystem.ITotal IT = FL.InitialPoint;
            Assert.AreEqual(0, FL.InitialPoint.CompareTo(IT));
        }

        [TestMethod]
        public void TestGetPointFromMatch()
        {
            PointSystem ip = FrenchLeague1PointSystem.Instance;
            PointSystem.ITotal IT = ip.GetPointFromMatch(new Matchs_Lib.Matchs(new Clubs("lille"),new Clubs( "Bordeaux"), 2, 1), true);
            
            Assert.AreEqual(1, ip.GetPointFromMatch(new Matchs_Lib.Matchs(new Clubs("lille"), new Clubs("Bordeaux"), 1, 1), true).CompareTo(IT));
        }

       }
}

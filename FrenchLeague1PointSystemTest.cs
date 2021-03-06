﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointSystemLib;
using FrenchLeague1PointSystemLib;
using Matchs_Lib;
namespace Matchs_LibTest
{
    [TestClass]
    public class FrenchLeague1PointSystemTest
    {
        public static FrenchLeague1PointSystem FLPS = (FrenchLeague1PointSystem)FrenchLeague1PointSystem.Instance;
        [TestMethod]
        public void TestInstance()
        {
            Assert.AreEqual(FLPS, FrenchLeague1PointSystem.Instance);          
        }
        [TestMethod]
        public void TestInitialPoint()
        {
            PointSystem.ITotal IT = FLPS.InitialPoint;
            Assert.AreEqual(0, FLPS.InitialPoint.CompareTo(IT));
        }

        [TestMethod]
        public void TestGetPointFromMatch()
        {            
            PointSystem.ITotal IT = FLPS.GetPointFromMatch(new Matchs_Lib.Matchs(new Clubs("lille"),new Clubs( "Bordeaux"), 3, 0), true);            
            Assert.AreEqual(3, FLPS.GetPointFromMatch(new Matchs_Lib.Matchs(), true).CompareTo(IT));
        }

       }
}

1  +﻿using System;
2	+using Microsoft.VisualStudio.TestTools.UnitTesting;
3	+using Matchs_Lib;
4	+using System.Collections.Generic;
5	+
6	+namespace Matchs_LibTest
7	+{
8	+    [TestClass]
9	+    public class ClubsTest
10	+    {
11	+       
12	+        [TestMethod]
13	+        public void TestToString()
14	+        {
15	+            String nom = "Bordeaux";
16	+            Clubs C1 = new Clubs(nom);
17	+            Assert.AreEqual(nom, C1.ToString());
18	+
19	+        }
20	+    }
21	+}

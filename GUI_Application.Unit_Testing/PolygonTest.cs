using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUI_Application;

namespace GUI_Application.Unit_Testing
{
    [TestClass]
    public class PolygonTest
    {
        int texturestyle = 0;
        Color paintcolor = Color.Black;
        Brush bb;
        [TestMethod]
        public void TestMethod1()
        {
            var polygon = new Polygon();
            int size1=200, size2=200, size3=200, size4=200, size5=200, size6=200, size7=200, size8=200, size9=200, size10=200;
            polygon.set(texturestyle, bb, paintcolor, size1, size2, size3, size4, size5, size6, size7, size8, size9, size10);
            Assert.AreEqual(200, polygon.size1);
        }
    }
}

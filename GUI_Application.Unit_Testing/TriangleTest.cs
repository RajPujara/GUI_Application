using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUI_Application;

namespace GUI_Application.Unit_Testing
{
    [TestClass]
    public class TriangleTest
    {
        int texturestyle = 0;
        Color paintcolor = Color.Black;
        Brush bb;
        [TestMethod]
        public void TestMethod1()
        {
            var Triangle = new Triangle();
            int xi1=200, yi1=200, xi2=200, yi2=200, xii1=200, yii1=200, xii2=200, yii2=200, xiii1=200, yiii1=200, xiii2=200, yiii2 = 200;
            Triangle.set(texturestyle, bb, paintcolor, xi1, yi1, xi2, yi2, xii1, yii1, xii2, yii2, xiii1, yiii1, xiii2, yiii2);
            Assert.AreEqual(200, Triangle.xi1);
        }
    }
}

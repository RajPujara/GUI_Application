using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUI_Application;
using System.Drawing;

namespace GUI_Application.Unit_Testing
{
    [TestClass]
    public class RectangleTest
    {
        int texturestyle = 0;
        Color paintcolor = Color.Black;
        Brush bb;

        [TestMethod]
        public void TestMethod1()
        {
            var Rectangle = new Rectangle();
            int x = 200, y = 200, size = 200, size1 = 200;
            Rectangle.set(texturestyle, bb, paintcolor, x, y, size, size1);
            Assert.AreEqual(200, Rectangle.x);
        }
    }
}

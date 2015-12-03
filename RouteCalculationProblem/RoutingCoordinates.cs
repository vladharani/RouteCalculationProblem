using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace RoutingPointProblem
{
    [TestClass]
    public class RoutingCoordinates
    {
        [TestMethod]
        public void TestRoutingCoordinates()
        {
            int endX;
            int endY;
            string[] commands = new string[] { "up" };
            Assert.AreEqual(0, FindLastPoint(0,0,["up"],out endX, out endY));
            Assert.AreEqual(0, endY);
        }
        void FindLastPoint(int startX, int startY, string[] commands, out int endX, out int endY)
        {
            
            endX = 0;
            endY = 0;
            for (int index = 0; index < commands.Length; index++)
            {
                if (commands[index] == "up") { endY = startY + 1; }
                else if (commands[index] == "down") { endY = startY - 1; }
                else if (commands[index] == "right") { endX = startX + 1; }
                else if (commands[index] == "left") { endX = startX + 1; }
            }
        }
    }
}
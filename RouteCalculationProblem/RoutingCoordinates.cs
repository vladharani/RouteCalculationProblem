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
            string[] commands = new string[] { "up", "right","up","right" };
            FindLastPoint(0,0, commands, out endX, out endY);
            Assert.AreEqual(2, endX);
            Assert.AreEqual(2, endY);
        }
        void FindLastPoint(int startX, int startY, string[] commands, out int endX, out int endY)
        {
            
            endX = 0;
            endY = 0;
            for (int index = 0; index < commands.Length; index++)
            {
                if (commands[index] == "up") { endY = startY + 1; startY = endY; }
                else if (commands[index] == "down") { endY = startY - 1; startY = endY; }
                else if (commands[index] == "right") { endX = startX + 1; startX = endX; }
                else if (commands[index] == "left") { endX = startX + 1; startX = endX; }
            }
        }
    }
}
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
            
            Assert.AreEqual(0, endX);
            Assert.AreEqual(0, endY);
            FindLastPoint(out endX, out endY);
        }
        void FindLastPoint(int startX, int startY, string[] commands, out int endX, out int endY)
        {
            commands =new string[] { "up" };
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
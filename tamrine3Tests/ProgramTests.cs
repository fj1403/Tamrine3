using Microsoft.VisualStudio.TestTools.UnitTesting;
using tamrine3;

namespace tamrine3.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void calculateProbabilityTest()
        {

            int[] testArr = { 1, 1, 1, 1, 2, 2, 3, 3 };
            if (Program.calculateProbability(testArr, 1) != 0.5)
            {
                Assert.Fail();
            }
            else if (Program.calculateProbability(testArr, 2) != 0.25)
            {
                Assert.Fail();
            }
            else if (Program.calculateProbability(testArr, 3) != 0.25)
            {
                Assert.Fail();
            }
        }
    }
}
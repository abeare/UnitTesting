using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;
namespace UnitTestingTesting
{
    [TestClass]
    public class AdderTest
    {
        [TestMethod]
        public void AddTest()
        {
            //arenge
            int x = 1;
            int y = 1;
            int z = 1;
            Adder adder = new Adder();
            // act
           int result= adder.Add(x, y);

            //asset

            Assert.AreEqual(z, result);
        }
    }
}

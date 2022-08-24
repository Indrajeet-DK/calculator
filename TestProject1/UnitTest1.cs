using SimpleConsoleApp2;

namespace TestCalculator
{
    [TestClass]
    public class Testcalculator
    {
        [TestMethod]
        public static void Testadd()
        {
            calculator c = new calculator();
            int result = c.add(10, 20);
            Assert.AreEqual(30, result);
        }
    }
}
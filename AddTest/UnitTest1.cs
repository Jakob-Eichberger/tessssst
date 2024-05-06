namespace AddTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OnePlusOneShouldBeTwo()
        {
            Assert.AreEqual(Add.Add.AddTwoNumbers(1, 1), 2);
        }

        [Test]
        public void OnePlusTwoShouldBeThree()
        {
            Assert.AreEqual(Add.Add.AddTwoNumbers(1, 2), 3);
        }
    }
}
namespace BasicMath.Test
{
    public class Tests
    {
        private BasicMath basicMath;

        [SetUp]
        public void Setup()
        {
            this.basicMath = new BasicMath();
        }

        [Test]
        public void TestAddingTwoNumbers()
        {
            double expected = 9;
            double actual = this.basicMath.Add(6, 3);

            Assert.AreEqual(expected, actual);

            double notExpected = 10;

            Assert.AreNotEqual(notExpected, actual);
        }

                [Test]
        public void TestSubtractingTwoNumbers()
        {
            double expected = 3;
            double actual = this.basicMath.Subtract(6, 3);

            Assert.AreEqual(expected, actual);

            double notExpected = 0;

            Assert.AreNotEqual(notExpected, actual);
        }

        [Test]
        public void TestDividingTwoNumbers()
        {
            double expected = 2;
            double actual = this.basicMath.Divide(6, 3);

            Assert.AreEqual(expected, actual);

            double notExpected = 18;

            Assert.AreNotEqual(notExpected, actual);
        }

        [Test]
        public void TestMultiplyingTwoNumbers()
        {
            double expected = 18;
            double actual = this.basicMath.Multiply(6, 3);

            Assert.AreEqual(expected, actual);

            double notExpected = 9;

            Assert.AreNotEqual(notExpected, actual);
        }

        [TearDown]
        public void TearDown()
        {
            this.basicMath = null;
        }
    }
}
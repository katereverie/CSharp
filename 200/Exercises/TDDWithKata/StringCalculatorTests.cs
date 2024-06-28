using NUnit.Framework;

namespace TDDWithKata
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [Test]
        public void EmptyStringReturnsZero()
        {
            var c = new StringCalculator();

            int val = c.Add("");

            Assert.AreEqual(0, val);
        }

        [Test]
        public void SingleNumberReturnsItself()
        {
            var c = new StringCalculator();

            int val = c.Add("5");

            Assert.AreEqual(5, val);
        }

        [TestCase("1, 2", 3)]
        [TestCase("3, 4", 7)]
        public void TwoNumbersReturnsSum(string numbers, int expected)
        {
            var c = new StringCalculator();
            int val = c.Add(numbers);

            Assert.AreEqual(expected, val);
        }

        [TestCase("1,2,3,4,5,6", 21)]
        [TestCase("1,2,3,4", 10)]
        [TestCase("1", 1)]
        public void UnknownAmountOfNumbersReturnsSum(string numbers, int expected)
        {
            var c = new StringCalculator();
            int val = c.Add(numbers);

            Assert.AreEqual(expected, val);
        }

        [TestCase("1\n2,3", 6)]
        [TestCase("1,2\n3\n4,5", 15)]
        public void HandleNewlinesBetweenNumbers(string numbers, int expected)
        {
            var c = new StringCalculator();
            int val = c.Add(numbers);

            Assert.AreEqual(expected, val);
        }

        [TestCase("//;\n1;2", 3)]
        [TestCase(";1;\n2;\n\n3\n;4", 10)]
        public void HandleDifferentDelimiters(string numbers, int expected)
        {
            var c = new StringCalculator();
            int val = c.Add(numbers);

            Assert.AreEqual(expected, val);
        }

        [TestCase("1,-2,3,;4, 5", "negatives not allowed: -2")]
        [TestCase("-1,-2,;3,4,5", "negatives not allowed: -1, -2")]
        public void HandleNegativeNumbers(string numbers, string expected)
        {
            var c = new StringCalculator();
            
            var ex = Assert.Throws<ArgumentException>(() => c.Add(numbers));

            Assert.AreEqual(expected, ex.Message);
        }

        [TestCase("1, 10, 100, 1000, 1001", 1111)]
        [TestCase("10001, 1, 2, 3, 4", 10)]
        public void IgnoreNumbersGreaterThanThousand(string numbers, int expected)
        {
            var c = new StringCalculator();

            int val = c.Add(numbers);

            Assert.AreEqual(expected, val);
        }

        [TestCase("//[]\n1***2***3", 6)]
        public void HandleDelimitersOfAnyLength(string numbers, int expected)
        {
            var c = new StringCalculator();

            int val = c.Add(numbers);

            Assert.AreEqual(expected, val);
        }

        [TestCase("//[][%]\n1***2***3", 6)]
        public void HandleMultipleDelimiters(string numbers, int expected)
        {
            var c = new StringCalculator();

            int val = c.Add(numbers);

            Assert.AreEqual(expected, val);
        }

        [TestCase("//[][][]%%%\n1******2\n!!3", 6)]
        public void HandleMultipleDelimitersOfAnyLength(string numbers, int expected)
        {
            var c = new StringCalculator();

            int val = c.Add(numbers);

            Assert.AreEqual(expected, val);
        }
    }
}

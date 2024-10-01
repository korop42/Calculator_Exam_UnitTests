using NUnit.Framework;
using CalcClassBr;

namespace CalcClassBr.Tests
{
    [TestFixture]
    public class CalcClassTests
    {
        [Test]
        public void ABS_ValidInput_ReturnsSameValue()
        {
            long input = 10;
            int result = CalcClass.ABS(input);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void ABS_NegativeInput_ReturnsSameValue()
        {
            long input = -15;
            int result = CalcClass.ABS(input);
            Assert.AreEqual(-15, result);
        }

        [Test]
        public void ABS_Zero_ReturnsZero()
        {
            long input = 0;
            int result = CalcClass.ABS(input);
            Assert.AreEqual(0, result);
        }

        //[Test]
        //[ExpectedException(typeof(OverflowException))]
        //public void ABS_MinValue_ReturnsPositiveValue()
        //{
        //    long input = int.MinValue;
        //    int expected = Math.Abs(int.MinValue);

        //    int result = CalcClass.ABS(input);
        //    Assert.AreEqual(expected, result);
        //}

        [Test]
        public void ABS_MaxValue_ReturnsSameValue()
        {
            long input = int.MaxValue;
            int result = CalcClass.ABS(input);
            Assert.AreEqual(int.MaxValue, result);
        }

        [Test]
        public void ABS_InputBelowIntMin_ThrowsArgumentOutOfRangeException()
        {
            long input = (long)int.MinValue - 1;
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => CalcClass.ABS(input));
            Assert.That(CalcClass.lastError, Does.Contain("Error 06"));
        }

        [Test]
        public void ABS_InputOutOfRange_ThrowsArgumentOutOfRangeException()
        {
            long input = (long)int.MaxValue + 1;
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => CalcClass.ABS(input));
            Assert.That(CalcClass.lastError, Does.Contain("Error 06"));
        }



    }
}

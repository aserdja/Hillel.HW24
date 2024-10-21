using HW24.BL;

namespace HW24
{
	public class CalculatorTest
	{
		[Fact]
		public void Sum_expects_a_plus_b()
		{
			var calculator = new Calculator();
			double a = 10;
			double b = 15;
			double expectedResult = 25;

			double actualResult = calculator.Sum(a, b);

			Assert.Equal(expectedResult, actualResult);
		}

		[Fact]
		public void Substract_expects_a_minus_b()
		{
			var calculator = new Calculator();
			double a = 10;
			double b = 5;
			double expectedResult = 5;

			double actualResult = calculator.Substract(a, b);

			Assert.Equal(expectedResult, actualResult);
		}

		[Fact]
		public void Multiply_expects_a_multiply_b()
		{
			var calculator = new Calculator();
			double a = 10;
			double b = 5;
			double expectedResult = 50;

			double actualResult = calculator.Multiply(a, b);

			Assert.Equal(expectedResult, actualResult);
		}

		[Fact]
		public void Divide_expects_a_divide_by_b()
		{
			var calculator = new Calculator();
			double a = 10;
			double b = 5;
			double expectedResult = 2;

			double actualResult = calculator.Divide(a, b);

			Assert.Equal(expectedResult, actualResult);
		}

		[Fact]
		public void Divide_expects_DivideByZeroException()
		{
			var calculator = new Calculator();
			double a = 10;
			double b = 0;

			Assert.Throws<DivideByZeroException>(() => calculator.Divide(a, b));
		}
	}
}

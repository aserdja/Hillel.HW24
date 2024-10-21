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

		[Fact]
		public void Average_expects_collection_average()
		{
			var calculator = new Calculator();
			var arrayOfNumbers = new[] { 1, 2, 5, 10, 0, 20, 23.5 };
			double expectedResult = 8.79;

			double actualResult = calculator.Average(arrayOfNumbers);

			Assert.Equal(expectedResult, actualResult);
		}

		[Fact]
		public void Average_excepts_empty_collection_exception()
		{
			var calculator = new Calculator();
			double[] arrayOfNumbers = Array.Empty<double>();

			Assert.Throws<Exception>(() => calculator.Average(arrayOfNumbers));
		}

		[Fact]
		public void Average_expects_negative_numbers_collection_average()
		{
			var calculator = new Calculator();
			var arrayOfNumbers = new[] { -2.5, -5, -10, -20 };
			double expectedResult = -9.38;

			double actionResult = calculator.Average(arrayOfNumbers);

			Assert.Equal(expectedResult, actionResult);
		}

		[Fact]
		public void Greatest_expects_collection_greatest_number()
		{
			var calculator = new Calculator();
			var arrayOfNumbers = new[] { 0, 5, 10, -1, 11.2, 11 };
			double expectedResult = 11.2;

			double actualResult = calculator.Greatest(arrayOfNumbers);

			Assert.Equal(expectedResult, actualResult);
		}

		[Fact]
		public void Greatest_expects_identical_numbers_collection_greatest()
		{
			var calculator = new Calculator();
			var arrayOfNumbers = new[] { 11.0, 11, 11, 11, 11, 11 };
			double expectedResult = 11;

			double actualResult = calculator.Greatest(arrayOfNumbers);

			Assert.Equal(expectedResult, actualResult);
		}

		[Fact]
		public void Greatest_expects_negative_numbers_collection_greatest()
		{
			var calculator = new Calculator();
			var arrayOfNumbers = new[] { -1, -10, -100, -2.5 };
			double expectedResult = -1;

			double actualResult = calculator.Greatest(arrayOfNumbers);

			Assert.Equal(expectedResult, actualResult);
		}

		[Fact]
		public void Sort_expects_sorted_collection()
		{
			var calculator = new Calculator();
			var arrayOfNumbers = new[] { 1, 0, 5, 30, 10.0, 20 };
			var expectedResult = new[] { 0, 1, 5, 10.0, 20, 30 };

			var actualResult = calculator.Sort(arrayOfNumbers);

			Assert.Equal(expectedResult, actualResult);
		}

		[Fact]
		public void Sort_expects_empty_collection_exception()
		{
			var calculator = new Calculator();
			var arrayOfNumbers = Array.Empty<double>();

			Assert.Throws<Exception>(() => calculator.Sort(arrayOfNumbers));
		}

		[Fact]
		public void Sort_expects_sorted_collection_from_sorted_collection()
		{
			var calculator = new Calculator();
			var arrayOfNumbers = new[] { 0, 1, 5, 10.0, 20, 30 };
			var expectedResult = new[] { 0, 1, 5, 10.0, 20, 30 };

			var actualResult = calculator.Sort(arrayOfNumbers);

			Assert.Equal(expectedResult, actualResult);
		}
	}
}

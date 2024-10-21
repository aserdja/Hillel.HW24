namespace HW24.BL
{
	public class Calculator
	{
		public double Sum(double a, double b)
		{
			return a + b;
		}

		public double Substract(double a, double b)
		{
			return a - b;
		}

		public double Multiply(double a, double b)
		{
			return a * b;
		}

		public double Divide(double a, double b)
		{
			if (b != 0)
			{
				return a / b;
			}
			throw new DivideByZeroException();
		}

		public double Average(IEnumerable<double> arrayOfNumbers)
		{
			if (arrayOfNumbers.Count() == 0)
			{
				throw new Exception("Collection is empty");
			}

			return Math.Round((arrayOfNumbers.Average()),2);
		}

		public double Greatest(IEnumerable<double> arrayOfNumbers)
		{
			if (arrayOfNumbers.Count() == 0)
			{
				throw new Exception("Collection is empty");
			}

			return arrayOfNumbers.OrderByDescending(x => x).First();
		}

		public IEnumerable<double> Sort(IEnumerable<double> arrayOfNumbers)
		{
			if (arrayOfNumbers.Count() == 0)
			{
				throw new Exception("Collection is empty");
			}

			return arrayOfNumbers.Order();
		}
	}
}

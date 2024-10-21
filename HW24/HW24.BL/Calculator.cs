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
			throw new Exception("Division by 0 is not possible");
		}
	}
}

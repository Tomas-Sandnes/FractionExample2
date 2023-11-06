namespace ConsoleApp
{
	internal class Program
	{
		static void Main()
		{
			Fraction oneHalf = new(1,2);
			Fraction oneThird = new(1,3);

			Fraction sumNonstaticMethod = oneHalf.Add(oneThird);
			Console.WriteLine(sumNonstaticMethod.ToText());

			Fraction sumStaticMethod = Fraction.Add(oneHalf, oneThird);
			Console.WriteLine(sumStaticMethod.ToText());
		}
	}
}
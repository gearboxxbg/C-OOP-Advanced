using System;

class Program
{
	static void Main(string[] args)
	{
		int countOfAppenders = int.Parse(Console.ReadLine());
		Controller controller = new Controller();
		controller.Act(countOfAppenders);
	}
}

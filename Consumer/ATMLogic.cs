using System;
using RabbitMQ.Consumer;

namespace Consumer
{
	public class ATMLogic
	{
		public ATMLogic()
		{
		}

		public static bool checkATM()
		{
			if (SecondScenario.checkSecondScenario())
            {
				Console.WriteLine("Turning ATM off... Physical Attack!");
				return true;
            } else if (FirstScenario.checkFirstScenario())
            {
				Console.WriteLine("Turning ATM off... Jackpotting!");
				return true;
			} else
            {
				Console.WriteLine("Nothing happened...");
				return false;
            }
		}
	}
}


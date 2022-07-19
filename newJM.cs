using System;

// namespace declaration
namespace HelloWorldApp {
	
	// Class declaration
	class Program {
		
		// Main Method
		static void Main(string[] args) {

			Console.WriteLine("****Basic IO ****");
			GetUserData();
			Console.ReadLine();

			static void GetUserData()
			{
				Console.Write("Enter your name: ");
				string userName = Console.Readline();
				Console.Write("Enter your age: ");
				string userAge = Console.ReadLine();

				//Echo to the console
				Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);
			}

		}

	}

}
	
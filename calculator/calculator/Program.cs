//Coded by ysufkibar and cybreex > Follow Instagram :)

using System;
   class Program
   {
       public static void Main(string[] args)
	   {
           Console.WriteLine("1-)Collection");
		   Console.WriteLine("2-)Extraction");
		   Console.WriteLine("3-)Multiplication");
		   Console.WriteLine("4-)Divison");
		   Console.WriteLine("5-)Exit");

		   Console.WriteLine(">> Selection: ");
		   string select = Console.ReadLine();

		   if (select == "1")
		   {
			   Console.WriteLine(">> Calculator - Collection");
			   Console.WriteLine(">> Number 1: ");
			   string number1 = Console.ReadLine();
			   Console.WriteLine(">> Number 2: ");
			   string number2 = Console.ReadLine();
			   int output = Convert.ToInt32(number1) + Convert.ToInt32(number2);
			   Console.WriteLine(">> " + output);
			   Console.ReadLine();
		   }

		   if (select == "2")
		   {
		       Console.WriteLine(">> Calculator - Extraction");
			   Console.WriteLine(">> Number 1: ");
			   string number1 = Console.ReadLine();
			   Console.WriteLine(">> Number 2: ");
			   string number2 = Console.ReadLine();
			   int output = Convert.ToInt32(number1) - Convert.ToInt32(number2);
			   Console.WriteLine(">> " + output);
			   Console.ReadLine();
		   }

		   if (select == "3")
		   {
			   Console.WriteLine(">> Calculator - Multiplication");
			   Console.WriteLine(">> Number 1: ");
			   string number1 = Console.ReadLine();
			   Console.WriteLine(">> Number 2: ");
			   string number2 = Console.ReadLine();
			   int output = Convert.ToInt32(number1) * Convert.ToInt32(number2);
			   Console.WriteLine(">> " + output);
			   Console.ReadLine();
		   }

		   if (select == "4")
		   {
			   Console.WriteLine(">> Calculator - Division");
			   Console.WriteLine(">> Number 1: ");
			   string number1 = Console.ReadLine();
			   Console.WriteLine(">> Number 2: ");
			   string number2 = Console.ReadLine();
			   int output = Convert.ToInt32(number1) / Convert.ToInt32(number2);
			   Console.WriteLine(">> " + output);
			   Console.ReadLine();
		   }

		   if (select == "5")
		   {
			   Console.WriteLine(">> Good Bye :)");
			   Console.ReadLine();
		   }

		   else
		   {
			   Console.WriteLine(">> Please enter a valid option!");
			   Console.ReadLine();
		   }
	   }

   }
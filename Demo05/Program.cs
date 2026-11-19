using Demo05.EnumExample;

namespace Demo05
{
	internal class Program
	{
		#region Passing by out
		static bool TryGetPrice(string title, out decimal price)
		{
			if (title == "C#")
			{
				price = 25;
				return true;
			}
			else
			{
				price = 0;
				return false;
			}

			
		}

		static void Calculate(int x, int y, out int sum, out int product)
		{
			sum = x + y;
			product = x * y;
		}
		#endregion

		#region Passing optional parameters 
		static void Greet(string name = "Mariam")
		{
			Console.WriteLine($"Hello : {name}");
		}

		static void StudentInfo(string name, int age)
		{
			Console.WriteLine($"Name : {name} , age : {age}");
		}

		static void Register(string name, int age = 18, string city = "Cairo")
		{
			Console.WriteLine($"Name : {name} , age : {age} , city : {city}");
		}
		#endregion

		#region Params
		static void PrintAllNames(int x, string title = "Student",params string[] names)
		{
			foreach (string name in names)
				Console.WriteLine(name);
		}

		static void PrintSum(int size, params int[] numbers)
		{
			int sum = 0;
			foreach (int number in numbers)
				sum += number;

			Console.WriteLine($"Sum = {sum}");
		}
		#endregion

		static void Main(string[] args)
		{
			#region Passing by out

			//bool result = int.TryParse("20", out int number);

			//string title = "C#";
			//decimal price;

			//bool result = TryGetPrice(title, out  price);
			//Console.WriteLine(result);
			//Console.WriteLine(price);

			//int sum, product;
			//Calculate(5,4,out sum,out product);
			//Console.WriteLine($"Sum = {sum}");
			//Console.WriteLine($"Product = {product}");

			//Rules  : 
			//1] Return data back to the caller
			//2] No intial value is required
			//3] Must be assigned inside the method 
			//4] Used TryMethods [TryParse  , TryGetValue ... ]
			//5] Support returning mutiple values

			#endregion

			#region Opitional parameters and named parameters

			//Greet();
			//Greet("Mohamed");

			//StudentInfo("Mariam", 20);
			//StudentInfo(age: 20, name: "Mariam"); //reversed order
			//StudentInfo(name: "Mariam", age: 20); //same order

			//Register("MARIAM");
			//Register("MARIAM", 20);
			//Register("MARIAM", 20 , "GIZA");
			//Register("MARIAM", city: "GIZA");
			//Register(city: "GIZA", name: "MARIAM", age: 14);

			#endregion

			#region Params

			//PrintAllNames("Omar", "Amir", "Abdallah", "Karam", "Samir");

			// string[] names = { "Omar", "Amir", "Abdallah", "Karam", "Samir" };
			// PrintAllNames(names);

			// PrintSum(10, 20, 30, 40, 50);

			// //Rules
			// //1] Only one params parameter
			// //2] Params must be last parameter

			//string.Format($"name {0}, age : {1}");

			#endregion

			#region Class Library 

			//int x = 10;
			//bool IsEvenNumber = NumberHelper.IsEven(x);
			//bool IsOddNumber = NumberHelper.IsOdd(x);
			//Console.WriteLine($"Is {x} An Even Number : {IsEvenNumber}"); // True
			//Console.WriteLine($"Is {x} A Odd Number : {IsOddNumber}"); // False

			#endregion

			#region Access Modifiers

			//TypeA typeA = new TypeA();
			////typeA.X = 1;// Invalid  // X is private [assessable within its Scope Only ]
			////typeA.Y = 1; // Invalid // Y is Internal [assessable within its Scope and in Same Project Only] 
			//typeA.Z = 1; // Valid // Z is Public [assessable within its Scope , in Same Project and outside project]


			#endregion

			#region Enum

			#region Example 01

			//Grades Grd01 = Grades.A;

			//if (Grd01 == Grades.A)
			//    Console.WriteLine("Bravo");
			//else
			//    Console.WriteLine(":(");


			//Grd01 = (Grades)4;
			//Console.WriteLine(Grd01); // E

			// Without validation
			//Grade grade = (Grade)10;
			//Console.WriteLine(grade); // 10

			//// With validation
			//bool isGrade = Enum.IsDefined(typeof(Grade), 10);
			//if (isGrade)
			//{
			//    Grade grade02 = (Grade)10;
			//    Console.WriteLine(grade02);
			//}
			//else
			//{
			//    Console.WriteLine("Invalid Grade Value");
			//}

			//Gender Gen01 = new Gender(); // set gen01 With default value 0
			//Console.WriteLine(Gen01); // Male 
			#endregion

			#region Example 02

			//         Student student = new Student()
			//         {
			//             Id = 1,
			//             Name = "Eman",
			//             Gender = Gender.Female, // 1
			//             Grade = Grade.B // 1
			//         };

			//Console.WriteLine(student.Id);
			//Console.WriteLine(student.Name);
			//Console.WriteLine(student.Gender);
			//Console.WriteLine(student.Grade);

			#endregion

			#region Example 03

			///// Take Data Of Student From User 
			///// Then Print Message 

			//Student student = new Student();
			//bool isParsed;
			//Console.WriteLine("Please Enter Student Data :");

			//int id;
			//do
			//{
			//	Console.Write("ID : ");
			//	isParsed = int.TryParse(Console.ReadLine(), out id);
			//} while (!isParsed || id <= 0);
			//student.Id = id;

			//string name;
			//do
			//{
			//	Console.Write("Name : ");
			//	name = Console.ReadLine();
			//} while (name == null);
			//student.Name = name;

			////student.Gender = Console.ReadLine(); // Invalid 
			////Gender stdGender;
			////object stdGender;
			////do
			////{
			////	Console.Write("Gender : ");
			////	isParsed = Enum.TryParse/*<Gender>*/(typeof(Gender),Console.ReadLine(),true, out stdGender);
			////} while (!isParsed || !Enum.IsDefined(typeof(Gender), stdGender));
			////student.Gender = (Gender)stdGender;

			//Gender stdGender;
			//do
			//{
			//	Console.Write("Gender : ");
			//	isParsed = Enum.TryParse<Gender>(Console.ReadLine(), true, out stdGender);
			//} while (!isParsed || !Enum.IsDefined<Gender>(stdGender));
			//student.Gender = stdGender;

			//Grade stdGrade;
			//do
			//{
			//	Console.Write("Grade : ");
			//	isParsed = Enum.TryParse<Grade>(Console.ReadLine(), out stdGrade);
			//} while (!isParsed || !Enum.IsDefined<Grade>(stdGrade));
			//student.Grade = stdGrade;

			//Console.Clear();

			//Console.WriteLine($"Hello {student.Name} Welcome To Route\n Your Grade is {student.Grade}");

			#endregion

			#endregion
		}
	}
}

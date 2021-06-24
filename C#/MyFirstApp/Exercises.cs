using System;
using System.Collections.Generic;

namespace MyFirstApp
{
    class Excercises
    {
        static void Main(string[] args)
        {

        }
        
        //============== Conditional statements exercises ==============
        static void oneToTen()
        {
            System.Console.Write("Please enter a value: ");
            var read = Console.ReadLine();
            int value = Convert.ToInt32(read);

            if (value > 0 && value < 11)
            {
                System.Console.WriteLine("Valid");
            }
            else
            {
                System.Console.WriteLine("Invalid");
            }
        }
        static int max(int a, int b)
        {
            if (a > b)
                return a;
            return b;
        }
        static void picture(int width, int height)
        {
            if (width > height)
                System.Console.WriteLine("It's a landscape");
            else
                System.Console.WriteLine("it's a portrait");
        }
        static void speedCamera(int speedLimit, int carSpeed)
        {
            if (carSpeed <= speedLimit)
                System.Console.WriteLine("Ok.");
            else
            {
                int demeritPoints = (carSpeed - speedLimit) / 5;
                System.Console.WriteLine("You have " + demeritPoints + " demerit points.");
                if (demeritPoints > 11)
                    System.Console.WriteLine("License Suspended.");
            }
        }
        //============== Iteration statements exercises ==============
        static void NumbersBy3()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            System.Console.WriteLine(count);
        }
        static void NumbersSum()
        {
            var sum = 0;
            while (true)
            {
                var input = Console.ReadLine();
                if (input.ToLower().Equals("ok"))
                    break;
                sum += Convert.ToInt32(input);
            }
            System.Console.WriteLine("Result :" + sum);
        }
        static int Factorial(int number)
        {
            var result = 0;

            if (number == 0)
                return 0;

            if (number == 1)
                return 1;

            result = number * Factorial(number - 1);
            return result;
        }
        static void FactorialPrint()
        {
            System.Console.Write("Please enter a number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var result = 1;

            for (var i = input; i > 1; i--)
            {
                result *= i;
            }
            System.Console.WriteLine("{0}! = {1}", input, result);
        }
        static void GuessTheNumber()
        {
            var random = new Random();
            var secretNumber = random.Next(1, 11);

            System.Console.WriteLine(secretNumber);

            for (var i = 0; i < 4; i++)
            {
                System.Console.Write("Enter a number:");
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == secretNumber)
                {
                    System.Console.WriteLine("You won!");
                    return;
                }
            }
            System.Console.WriteLine("You lost!");
        }
        static void Maximum()
        {
            System.Console.WriteLine("Enter your numbers separated by a coma:");
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }
            System.Console.WriteLine("The greather numbers is: " + max);
        }
        // ============== List exercises ==============
        static void Likes()
        {
            var names = new List<string>();
            var name = "";
            while (true)
            {
                System.Console.Write("Enter a name: ");
                name = Console.ReadLine();
                if (String.IsNullOrEmpty(name))
                    break;
                names.Add(name);
            }
            if (names.Count == 0)
                return;
            else if (names.Count == 1)
                System.Console.WriteLine(names[0] + " likes your post.");
            else if (names.Count == 2)
                System.Console.WriteLine(names[0] + " and " + names[1] + " like your post.");
            else
                System.Console.WriteLine(names[0] + ", " + names[1] + " and " + (names.Count - 2) + " others like your post.");

        }
        static void ReverseName()
        {
            System.Console.Write("Enter a name: ");
            string input = Console.ReadLine();
            System.Console.WriteLine(" ");

            var characters = new char[input.Length];
            for (var i = input.Length; i > 0; i--)
            {
                characters[input.Length - i] = input[i - 1];
            }
            var reversed = new String(characters);
            System.Console.WriteLine(reversed);
        }
        static void UniqueNumbers()
        {
            var numbers = new List<int>();
            var aux = 0;

            while (numbers.Count < 5)
            {
                System.Console.Write("Please, enter a number: ");
                aux = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(aux))
                    System.Console.WriteLine("\nError, the number is duplicated.");
                else
                    numbers.Add(aux);
            }
            numbers.Sort();

            System.Console.WriteLine(" ");
            foreach (var number in numbers)
            {
                System.Console.Write(number + " ");
            }
        }
        static void UniqueNumbersList()
        {
            var input = "";
            var numbers = new List<int>();

            while (true)
            {
                System.Console.Write("Enter a number: ");
                input = Console.ReadLine();

                if (input.ToLower().Equals("quit"))
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            var uniqueNumbers = new List<int>();
            uniqueNumbers.Add(numbers[0]);
            for (var i = 1; i < numbers.Count; i++)
            {
                if (!uniqueNumbers.Contains(numbers[i]))
                    uniqueNumbers.Add(numbers[i]);
            }

            Console.WriteLine("Unique numbers:");
            foreach (var number in uniqueNumbers)
            {
                System.Console.Write(number + " ");
            }
        }
        static void CommaList()
        {
            var input = "";
            string[] numbers;
            while (true)
            {
                System.Console.Write("Enter a list of numbers: ");
                input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input))
                {
                    numbers = input.Split(",");
                    if (numbers.Length >= 5)
                        break;
                }

                System.Console.WriteLine("\nInvalid List.\n");
            }

            var numbersList = new List<int>();
            foreach (var number in numbers)
            {
                numbersList.Add(Convert.ToInt32(number));
            }

            var smallest = new List<int>();
            var min = 0;
            while (smallest.Count < 3)
            {
                min = numbersList[0];
                foreach (var number in numbersList)
                {
                    if (min > number)
                        min = number;
                }
                smallest.Add(min);
                numbersList.Remove(min);
            }

            System.Console.WriteLine("\nThe 3 smallest numbers in the list: ");
            foreach (var item in smallest)
                System.Console.WriteLine(item);

            //-- Using Array.Sort() -- 
            // numbersList.Sort();
            // System.Console.WriteLine("\nThe 3 smallest numbers in the list: ");
            // for (var i = 0; i < 3; i++)
            // {
            //     System.Console.WriteLine(numbersList[i]);
            // }
        }
        //============== String exercises ==============
        static public void Consecutive()
        {
            System.Console.WriteLine("Please enter some numbers separated by a hypen (-):");
            var input = Console.ReadLine();
            var numbers = new List<int>();

            foreach (var character in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(character));
            }

            if (numbers[0] == numbers[1] + 1) //Increment
            {
                for (var i = 0; i < numbers.Count - 1; i++)
                {
                    if (!(numbers[i] == numbers[i + 1] + 1))
                    {
                        System.Console.WriteLine("Not Consecutive");
                        return;
                    }
                }
                System.Console.WriteLine("Consecutive");
            }
            else if (numbers[0] == numbers[1] - 1) //Decrement
            {
                for (var i = 0; i < numbers.Count - 1; i++)
                {
                    if (!(numbers[i] == numbers[i + 1] - 1))
                    {
                        System.Console.WriteLine("Not Consecutive");
                        return;
                    }
                }
                System.Console.WriteLine("Consecutive");
            }
            else
                System.Console.WriteLine("Not Consecutive");
        }
        static void DuplicatedHyphen()
        {
            System.Console.WriteLine("Enter a few numbers separated by a hyphen:");
            var input = Console.ReadLine();

            if (!String.IsNullOrEmpty(input))
            {
                var numbers = new List<int>();
                foreach (var character in input.Split("-"))
                {
                    numbers.Add(Convert.ToInt32(character));
                }
                foreach (var number in numbers)
                {
                    if (numbers.IndexOf(number) != numbers.LastIndexOf(number))
                    {
                        System.Console.WriteLine("Duplicate");
                        break;
                    }
                }
            }
        }
        static void ValidTime()
        {
            System.Console.WriteLine("Enter a time value (00:00 to 23:59):");
            var input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
                return;

            try
            {
                var hours = Convert.ToInt32(input.Split(':')[0]);
                var minutes = Convert.ToInt32(input.Split(':')[1]);

                if (hours >= 0 && hours <= 23)
                {
                    if (minutes >= 0 && minutes <= 59)
                        System.Console.WriteLine("Ok");
                }
                else
                    System.Console.WriteLine("Invalid Time");
            }
            catch (System.Exception)
            {

                System.Console.WriteLine("Invalid Time");
            }
        }
        static void PascalCase()
        {
            System.Console.WriteLine("Enter a few words (separated by a space):");
            var input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
            {
                System.Console.WriteLine("Invalid input.");
                return;
            }

            // var words = input.Split(' ');
            // var output = "";
            // var aux = "";
            // foreach (var word in words)
            // {
            //     aux = word.ToLower();
            //     output += ("" + aux[0]).ToUpper();
            //     for (var i = 1; i < aux.Length; i++)
            //     {
            //         output += "" + aux[i];
            //     }
            // }
            // System.Console.WriteLine(output);

            var output = "";
            foreach (var word in input.Split(' '))
            {
                output += Char.ToUpper(word[0]) + word.Substring(1).ToLower();
            }
            System.Console.WriteLine(output);
        }

        static void NumberOfVowels()
        {
            System.Console.Write("Enter an English word: ");
            var output = Console.ReadLine();
            output = output.ToLower();
            var count = 0;

            foreach (var letter in output)
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' 
                || letter == 'o' || letter == 'u')
                {
                    count++;
                }
            }

            Console.WriteLine("\nNumber of vowels: " + count);
        }
        //============== Method Parameters ==============
        static void OutExample()
        {
            int number;
            var result = int.TryParse("abc", out number);

            var message = result ? ""+number : "Conversion failed.";

            System.Console.WriteLine(message);
        }
        static void ParamsExample()
        {
            var calculator = new Calculator();
            
            System.Console.WriteLine(calculator.Add(new int[] {1, 2, 3, 4}));
            System.Console.WriteLine(calculator.Add(1, 2 , 3, 4, 5));
        }
        //============== Object Initializers ==============
        static void ObjectInitializersExample()
        {
            var person1 = new Person("Jhon", new DateTime(1990, 1, 2));
            var person2 = new Person("Lucy", new DateTime(1990, 3, 2))
            {
                Weight = 70
            };
            System.Console.WriteLine(person1.Weight);
            System.Console.WriteLine(person2.Weight);
        }
        //============== Properties ==============
        static void PropertiesExample()
        {
            var person = new Person("Giorgo", new DateTime(1998, 11, 8));
            System.Console.WriteLine("Birthdate: " + person.Birthdate);
            System.Console.WriteLine("Age: " + person.Age);
        }
        //============== Indexers ==============
        static void IndexersExample()
        {
            var cookie = new HttpCookie();
            cookie["Juan"] = "Perez";
            System.Console.WriteLine(cookie["Juan"]);
        }
        //============== Composition ==============
        static void CompositionExample()
        {
            var installer = new Installer(new Logger());
            var logger = new Logger();
            var dbmigrator = new DbMigrator(logger);

            installer.Install();
            dbmigrator.Migrate();
        }
    }
}
/*using CSharpFundamentals.Math;
using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var Aneeqah = new Person();
            Aneeqah.FirstName = "Aneeqah";
            Aneeqah.LastName = "Jones";
            Aneeqah.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(5, 2);
            Console.WriteLine(result);
        }
    }
}*/

/*using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "Steve", "Natasha", "Tony" };
            names[0] = names[0];

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);

        }
    }
} */

/*using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Natasha";
            var lastName = "Romanov";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "Natasha", "Wanda", "Carol" };
            var formattedNames = string.Join(",", names);

            var text = @"Hi Nat
                         Look into the following paths
                         c:\folder1\folder2
                         c:\folder3\folder4";


            Console.WriteLine(fullName);
            Console.WriteLine(myFullName);
            Console.WriteLine(formattedNames);
            Console.WriteLine(text);


        }
    }
}*/

/*using System;

namespace CSharpFundamentals
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

        }
    }
  
}*/

/*using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
        }
    }
}*/

/*using System;

namespace CSharpFundamentals
{
    public class Person
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() { Age = 26 };
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}*/

using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration of Sting variable 
            string myString = "Hello Im Daniel";

            // .Length used to find the character count of a string 
            // Note: Spaces count 
            Console.WriteLine("myString has " + myString.Length + " characters.");

            // .ToUpper() and .ToLower() used to 
            //  change string to all lower or upper case.

            string txt = "Hello World";

            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"

            Console.WriteLine(txt.ToLower());   // Outputs "hello world"

            // Strings can be concatenated / combined using "+" 
            // or string.Concat(x, y);
            // Both output "DanielHercules" 

            string firstname = "Daniel";

            string lastname = "Hercules";

            string name = firstname + lastname;

            Console.WriteLine(name);


            string nameTwo = string.Concat(firstname, lastname);

            Console.WriteLine(nameTwo);

            // Interpolation: Substituting values of 
            // variables into placeholders in a string

            String nameThree = $"My name is {firstname} {lastname}";
            Console.WriteLine(nameThree);

            // You can also access specific chaarcters in a
            // string using its index position.
            // This line will print out "H"
            Console.WriteLine(txt[0]);

            // You can also see what the index of a specific 
            // chaarcter is in a string using .IndexOf  
            // if there is more than one instance of the character,
            // the console will return the index of the first instance
            Console.WriteLine(txt.IndexOf("e"));

            //Make newline with "\n"



        }
    }
}

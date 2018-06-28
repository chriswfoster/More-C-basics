using System;


// a name space is a way to organize your code, it's a collection of classes, deligates, other namespaces, etc.
// not using a namespace here.

    class Program
    { 
        static void Main2()
        {
         string username = Console.ReadLine();
   
        // Console.WriteLine("Your name is " + username); // this is concatenation
        //  Console.WriteLine("Your name is {0}", username); // this is placeholder syntax, basically references a paramter passed in after the string.
        // Console.WriteLine($"Your name is {username}"); // I think this is string interpolation
        Main3(ref username); // Here I'm passuing in username, ref (referencing) the username variable.
        }

        static void Main3(ref string username) // I told C# to reference the string username that I'm passing in from Main2
    {
        Console.WriteLine("Now type your last name:");
        string lastname = Console.ReadLine();
        Console.WriteLine("Hello, {0} {1}!", username, lastname);
    }


        static void Main() // this is a function/method.
        {
        Console.WriteLine("Please type your first name:"); // full name is actually System.Console, it gets it's functionality. If you hover over console, you can see the System class.
        Main2(); // this will call the previous function.
        }
    }

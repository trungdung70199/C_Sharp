// In C# there are diffferent types of variables
// int, double, char, string, bool

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(String[] args)
        {
            string name = "D";
            Console.WriteLine(name);
        }
    }
}

// Create a variable call myNum of type int
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 15;
            // or :
            // int myNum;
            // myNum = 15;
            Console.WriteLine(myNum);
        }
    }
}

// Change the Value of myNum
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 10;
            myNum = 109;
            Console.WriteLine(myNum);
        }
    }
}

// Other Types
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 2;
            double mydouble = 1.23D;
            char myLetter = 'A';
            bool myBool = true;
            string myText = "Hello";
            Console.WriterLine(myNum, mydouble, myLetter, myBool, myText);
        }
    }
}

// Constants
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            const int myNum = 15;
            // error
            // myNum = 2;
            Console.WriteLine(myNum);
        }
    }
}

// Display Variables
// To combine both and a varible use the + character
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "D";
            Console.WriteLine("Hello" + name);
        }
    }
}

// Can also use the + character to add a variable to another variable
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string fistName = "Dung ";
            string MidName = "Hoang Trung "
            string lastname = "Nguyen";
            string fullName = fistName + MidName + lastname;
            Console.WriteLine(fullName);
        }
    }
}

// The same with number
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            Console.WriteLine(x + y);
        }
    }
}

// Multiple Variables
// Declare Many Variable
using System

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 2, z = 3;
            Console.WriteLine(x + y + z);
        }
    }
}

// Identifiers
// The general rules for naming variables are:

// Names can contain letters, digits and the underscore character (_)
// Names must begin with a letter
// Names should start with a lowercase letter and it cannot contain whitespace
// Names are case sensitive ("myVar" and "myvar" are different variables)
// Reserved words (like C# keywords, such as int or double) cannot be used as names
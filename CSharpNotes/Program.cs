//      INTRO TO C#

//using points to a library of code and points to it for the code, currently pointing to System library (System.TQL.Bootcamp.Class1.Console.WriteLine...)
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
//using namespace HelloWorld;
using HelloWorld;
using Microsoft.EntityFrameworkCore;
using PoWebApi.Models;

//using namespace HelloWorld
//namespace gives a unique name to everything inside of it as a prefix (TQL.Bootcamp.Class1.Console.WriteLine...)
namespace CSharpNotes
{
    //class is a type that defines a block of code in c#, smallest unit in programming. You only put properties and methods into classes
    class Program
    {

        //static void is a property type that declares a method, Main is the name of the method, must have () if it's a method
        //Main method is required in a class to run program, calls to multiple methods within it, once they're all done they go back to main method and program shuts down
        static void Main(string[] args)
        {
            //declaring variable sarah, setting = to a new instance from the Student Class (from namespace HelloWorld)
            var sarah = new Student();
            //sarah.____ goes to Student class and pulls that property to insert this value
            sarah.FirstName = "Sarah";
            sarah.LastName = "George";
            //calls to SetHireDate method from Student class, gives it (value,value,value) for sarah variable
            sarah.SetHireDate(2017, 6, 26);

            var charlie = new Student();
            charlie.FirstName = "Charlie";
            charlie.LastName = "Traylor";

            var mattea = new Student();
            mattea.FirstName = "Mattea";
            mattea.LastName = "Swain";
            //From variable sarah, call Print method (from Student class)
            sarah.Print();
            charlie.Print();
            mattea.Print();

            //var declares a local variable, Variable type named company, value = "string"
            var company = "TQL";
            var student = "Zha'Quon";
            //var in this case automatically declares a local variable, Integer type named yearsWorking because we initialized value = int
            var yearsWorking = 3;
            //Types can only be null by adding an ? on the end
            int? i = null;
            //Console is a class (in System library) being executed, executing method WriteLine($(calls var)"string {VariableName}")
            Console.WriteLine($"{student} PITY THE FOOL from {company}!");
            Console.WriteLine($"My name is {student} and I've been with {company} for {yearsWorking} years!");
        }
    }
}
//new namespace named HelloWorld
namespace HelloWorld
{//Declaring class Student 
    class Student
    {//These are the properties defining the class Student
        //public(who can access this? public means any other class), string type, named FirstName, statement used to get data
        public string FirstName { get; set; }
        //"prop" tab + tab is shortcut for these lines
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public bool Active { get; set; }
        //Private means only this class (Student) can edit this property
        private DateTime HireDate { get; set; }

        //These are the methods defining the class Student
        //public, void, named SetHireDate(DataType Name, DataType Name, DataType Name)
        public void SetHireDate(int year, int month, int day)
        {//if(boolean is true, run this)  (year is < 1950 OR year > 2200)
            if (year < 1950 || year > 2200)
            {
                Console.WriteLine($"Put a real year dude... 1950 - 2200");
                //return means don't continue 
                return;
            }
            if (month < 1 || month > 12)
            {
                Console.WriteLine($"There's only 12 months bro... 1<= x <= 12");
                return;
            }
            if (day < 1 || day > 31)
            {
                Console.WriteLine($"There's no month with that many days!");
                return;
            }
            //if none of the above ifs are true, set HireDate = to new DataType (values)
            HireDate = new DateTime(year, month, day);
        }
        //public(any class can access this), void (won't return anything), naming method Print, () must have these with value that we're passing through (in this case nothing)
        public void Print()
        {//This is what happens when we call to method Print
            //in console, writeline method($"(value) (value) Hired: {calls to HireDate, formats as string("month/day/year")}")
            Console.WriteLine($"{FirstName} {LastName} Hired: { HireDate.ToString("MM/dd/yyyy")}");
        }
    }
}

//      CLASSES/METHODS/CREATING INSTANCES

namespace ClassTutorial
{
    class Major
    {
        //creating a private property, if any instance changes this value it changes for all instances(static), integer DataType, named NextId, set = 1 to initialize it
        private static int NextId { get; set; } = 1;
        //creates public property, integer DataType, named Id {can be read by other classes; cannot be modified by other classes}
        public int Id { get; private set; }
        public string Description { get; set; }
        public int MinSAT { get; set; }
        //what a default constructor is behind the scenes (we have to recreate so we can make more constructors)
        public Major() { }
        //creates constructor(user inputs a string and goes into variable description)
        public Major(string description)
        {//set property Id = property NextId
            this.Id = NextId;
            //initialize NextId
            NextId++;
            //sets property Description = what passes into constructor Major
            this.Description = description;
        }
    }
}
namespace ClassTutorial
{
    class TqlMath
    {
        //this creates a Constructor, has to be the class name, can't have 2 constructors with same (parameters), have to pass 2 pieces of data in the paramters
        public TqlMath(int a, int B, string Fred)
        {//Sets the property A = the parameter a
            A = a;
            //Sets the property B = the paramter B, specifying property first with this. (this. only applies to properties, only used when parameter and property same name)
            this.B = B;
            this.C = Fred;
        }
        public int A { get; set; }
        public int B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        //Creates property Pi, which will only have 1 value (static) = the value
        static double Pi { get; set; } = 3.14159265359;
        //creating methods(actions to call)
        public int Sum()
        {
            return A + B;
        }
        public int Diff()
        {
            return A - B;
        }
        public int Multiply()
        {
            return A * B;
        }
        public int Division()
        {
            return A / B;
        }
        public int Avg()
        {
            return (A + B) / 2;
        }
        public int Larger()
        {
            if (A > B)
            {
                return A;
            }
            else return B;
        }
        public int Smaller()
        {
            if (A < B)
            {
                return A;
            }
            else return B;
        }
    }
}
namespace ClassTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable named m1, setting = new instance from Major constructor("passing this into string")
            var m1 = new Major("Math");
            var m2 = new Major("Engineering");
            var m3 = new Major("Education");
            //creates variable tqlmath, setting = to constructor calling TqlMath(value1, value2, value3)
            var tqlmath = new TqlMath(21, 30, "string");
            //if no constructor has been created, we can call it here with default constructor name ();, then we initialize the values
            var tqlmath = new TqlMath();
            //This sets the value of variable tqlmath(pointing to A from class TqlMath) = 33
            tqlmath.A = 33;
            tqlmath.B = 30;
            
            //creating variables, setting = to instance.Methods();
            var sum = tqlmath.Sum();
            var avg = tqlmath.Avg();
            var diff = tqlmath.Diff();
            var multiply = tqlmath.Multiply();
            var larger = tqlmath.Larger();
            var smaller = tqlmath.Smaller();
            Console.WriteLine($"Sum of {tqlmath.A} and {tqlmath.B} is {sum}");
            Console.WriteLine($"Difference of {tqlmath.A} and {tqlmath.B} is {diff}");
            Console.WriteLine($"The larger integer between {tqlmath.A} and {tqlmath.B} is {larger}");
            Console.WriteLine($"The smaller integer between {tqlmath.A} and {tqlmath.B} is {smaller}");
            Console.WriteLine($"{tqlmath.A} * {tqlmath.B} = {multiply}");
            Console.WriteLine($"The average of {tqlmath.A} and {tqlmath.B} = {avg}");
        }

    }
}

//      WHILE LOOPS, IF/ELSE

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            var runAgain = true;
            //While (boolean is true, run this)  (runAgain is equal to true)
            while (runAgain == true)
            {
                //Write instead of WriteLine so that the cursor starts directly after the text
                Console.Write("Enter an interger: ");
                //creates a variable answerStr, sets = to value entered by user
                var answerStr = Console.ReadLine();
                //Creates a variable answerInt, sets = DataType(integer).Parse(converts value into DataType)(Value(answerStr))
                var answerInt = int.Parse(answerStr);
                //Creates variable evenNumber, sets = to value(answerInt) % (divide by #, get remainder) == (and check if it is equal to) 0
                //This will set evenNumber to true if answerInt divides by 2 with 0 remainder, false if any other remainder
                var evenNumber = answerInt % 2 == 0;
                //If evenNumber is equal to true, run this
                if (evenNumber == true)
                {
                    Console.WriteLine($"{answerStr} is an even integer");
                }
                //If not, run this
                else
                {
                    Console.WriteLine($"{answerStr} is an odd integer");
                }
                Console.Write("Would you like to run it again? (Y if yes): ");
                //Sets variable answerStr to new user input
                answerStr = Console.ReadLine();
                //If variable answerStr is equal to y OR variable answerStr is equal to Y, run this
                if (answerStr == "y" || answerStr == "Y")
                {//Sets variable runAgain to true
                    runAgain = true;
                }//If not, run this
                else
                {//Sets variable runAgain to false
                    runAgain = false;
                }//since while is surrounding this, it'll go back and check while(boolean)

                //Ternary statement, checks a boolean and sets a value to 1 or the other
                //var = condition ? ref consequent : ref alternative
                //var checks a condition, ? if it is true it'll set = to true : if not, set = to false;
                runAgain = answerStr == "y" || answerStr == "Y" ? true : false;

                //we can set a variable to contain these values, so that we can go through them each
                var status = "|Y| |y|";
                //this checks to see if answerStr has a value that's the same as one in our status vari
                //if status doesn't contain ($"|value in answerStr|")
                if (!status.Contains($"|{answerStr}|"))
                {
                    return BadRequest();
                }
            }
        }
    }
}

//      FOREACH LOOPS/ARRAYS

namespace ForEachCalcAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            var count = 0;
            var highest = 0;
            var lowest = 1000;
            //declaring variable nbrs as an int in a [collection of values] = {value1, value2...}
            int[] nbrs =
            {
               754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
               187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
               460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
               690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
               435, 643, 809, 874, 906, 620, 328, 369, 426, 561
            };
            //For loop, saying for each (newVariable named nbr, setting nbr = each value in nbrs collection)
            foreach (var nbr in nbrs)
            {//if the current nbr > variable highest
                if (nbr > highest)
                {//set highest = that nbr
                    highest = nbr;
                }//if the current nbr < variable lowest
                if (nbr < lowest)
                {//set lowest = that nbr
                    lowest = nbr;
                }//Set variable sum = current sum + nbr
                sum = sum + nbr;
                //add 1 to count
                count++;
                //at the end, goes to the next value in nbrs and sets nbr = that value
            }
            var avg = sum / count;
            Console.WriteLine($"There are {count} numbers. The average is {avg}");
            Console.WriteLine($"Highest is {highest}, lowest is {lowest}");
        }
    }
}

//      FOR LOOP

namespace AddToFifty
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var sum = 0;
                //for (new variable variableName; boolean; initialize variable)
                //for (variable i set = to 1; if i <= 50; add 1 to i)
                for (var i = 1; i <= 50; i++)
                {//check if i is divisible by 5 OR by 7
                    if (i % 5 == 0 || i % 7 == 0)
                    {//if it is, add it to the sum
                        sum = sum + i;
                    }
                }
                Console.WriteLine($"Answer is {sum}");
            }
        }
    }
}

//      SWITCH CASE

namespace Banking
{
    class CertificateOfDeposit
    {
        public decimal InterestRate { get; private set; }
        public int Months { get; private set; }

        private void SetDurationAndRate(int months)
        {
            //switch cases can be used instead of if/else in situations
            //switch(variable being passed in) - AKA if(months == case)
            switch (months)
            {
                //checks if value(12) was entered, if so do this
                case 12:
                    InterestRate = 0.01m;
                    Months = months;
                    //must include break; acts as a return
                    break;
                //checks if value (24) was entered, if so do this
                case 24:
                    InterestRate = 0.02m;
                    Months = months;
                    break;
                case 36:
                    InterestRate = 0.03m;
                    Months = months;
                    break;
                case 48:
                    InterestRate = 0.04m;
                    Months = months;
                    break;
                case 60:
                    InterestRate = 0.05m;
                    Months = months;
                    break;
                //must have a default to be called if none of the cases are true
                default:
                    Console.WriteLine($"You've entered an invalid length of time, must be 12 months, 24 months, 36 months, 48 months, or 60 months.");
                    break;
            }
        }
    }
}

//      INHERITANCE AND COMPOSITION OBJECT ORIENTED PROGRAMMING (OOP)

namespace GeometricShapes
{
    class Quad
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }
        public int SideD { get; set; }

        public int Perimeter()
        {
            return SideA + SideB + SideC + SideD;
        }
        //listing as virtual lets the system know this is what we want to override in subsequent classes
        public virtual string WhatAmI()
        {
            return "Quad";
        }
        public Quad(int s1, int s2, int s3, int s4)
        {
            SideA = s1;
            SideB = s2;
            SideC = s3;
            SideD = s4;
        }
        public Quad() { }
    }
}
namespace GeometricShapes
{
    class Rect
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public int Perimeter()
        {
            return Length + Length + Width + Width;
        }
        public int Area()
        {
            return Length * Width;
        }
        public Rect(int s1, int s2)
        {
            Length = s1;
            Width = s2;
        }
    }
}
namespace GeometricShapes
{
    class Sqr
    {
        public int Side { get; set; }

        public int Perimeter()
        {
            return Side * 4;
        }
        public int Area()
        {
            return Side * Side;
        }
        public Sqr(int s1)
        {
            Side = s1;
        }
    }
}
namespace GeometricShapes
{
    //utilizing composition
    class Rect2
    {
        //creates a property with Quad DataType named quad
        public Quad quad { get; set; }

        //creating method Perimeter
        public int Perimeter()
        {
            //Goes to Quad's Perimeter method and runs it, then returns into this Perimeter method
            return quad.Perimeter();
        }
        //new method for Area
        public int Area()
        {
            return quad.SideA * quad.SideB;
        }
        //Constructor taking 2 integers
        public Rect2(int s1, int s2)
        {
            //sets the Quad's sides to these values (rectangle sides are = to their opposite side)
            quad = new Quad(s1, s2, s1, s2);
        }
    }
}
namespace GeometricShapes
{
    //utilizing composition
    class Sqr2
    {
        //creating property with Rect DataType named rect
        public Rect2 rect { get; set; }
        public int Perimeter()
        {
            //returns Perimeter method from Rect2
            return rect.Perimeter();
        }
        public int Area()
        {
            //returns Area method from Rect2
            return rect.Area();
        }
        public Sqr2(int s1)
        {
            //all sides of a square are the same, so sets the 2 values for Rect2 to side1
            rect = new Rect2(s1, s1);
        }
    }
}
namespace GeometricShapes
{
    //utilizing inheritance
    //you can only inherit from one other class
    //grabs every method, so we didn't have to recreate Perimet and call to it
    //class ThisClassName : ClassInheritingFrom
    class Rect3 : Quad
    {
        public Rect3() { }
        //creating method Rect3(requiring 2 integers) : base(where these 2 integers fill in to the InheritedFromClass)
        public Rect3(int s1, int s2) : base(s1, s2, s1, s2) { }
        public int Area()
        {
            return SideA * SideB;
        }
        //creating a method that will override what the InheritedFromClass does
        public override string WhatAmI()
        {
            return "Rectangle";
        }


    }
}
namespace GeometricShapes
{
    class Sqr3 : Rect3
    {
        public Sqr3(int s) : base(s, s) { }
        public Sqr3() { }
        //creating a method that will override what the InheritedFromClass does
        public override string WhatAmI()
        {
            return "Square";
        }
    }
}
namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqr31 = new Sqr3(5);
            var sqr32 = new Sqr3(7);
            var rect31 = new Rect3(4, 7);
            var rect32 = new Rect3(3, 5);
            var rect33 = new Rect3(9, 11);
            var quad31 = new Quad(1, 2, 3, 4);
            //creating new instance shapes from the Quad type, [array] {values}
            //since they all inherit from Quad, we can use DataType Quad as the similarity to group them in
            var shapes = new Quad[] { sqr31, sqr32, rect31, rect32, rect33, quad31 };
            //goes through each piece of data in the instance shapes
            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.WhatAmI()} perimeter is {shape.Perimeter()}");
            }
            var sqr1 = new Sqr(9);
            var rect1 = new Rect(7, 2);
            var quad1 = new Quad(4, 6, 1, 3);
            Console.WriteLine($"The perimeter of the square is {sqr1.Perimeter()} and the area is {sqr1.Area()}");
            Console.WriteLine($"The perimeter of the rectangle is {rect1.Perimeter()} and the area is {rect1.Area()}");
            Console.WriteLine($"The perimeter of the quadrilater is {quad1.Perimeter()}");
            var sqr2 = new Sqr2(5);
            var rect2 = new Rect2(6, 3);
        }
    }
}

//      INTERFACE

//Interfaces are not classes, different file type
namespace InterfaceLesson
{
    //established as an interface not a class, name (usually starts with I, followed by method they have in common)
    interface IPrint
    {
        // what you're returning(void), the method that is present in each class (Print();)
        void Print();
    }
}
namespace InterfaceLesson
{
    //connects IPrint interface to ShibaInu class
    class ShibaInu : IPrint
    {
        public string Characteristic { get; set; } = "Stand offish";
        public string Type { get; set; } = "ShibaInu";
        //the method that is common
        public void Print()
        {
            Console.WriteLine($"This dog is a {Type} and it is {Characteristic}");
        }
    }
}
namespace InterfaceLesson
{
    class Chihuahua : IPrint
    {
        public string Characteristic { get; set; } = "Shakey";
        public string Type { get; set; } = "Chihuahua";
        //the method that is common
        public void Print()
        {
            Console.WriteLine($"This dog is a {Type} and it is {Characteristic}");
        }
    }
}
namespace InterfaceLesson
{
    class PitBull : IPrint
    {
        public string HeadSize { get; set; }
        public string Type { get; set; } = "PitBull";
        //the method that is common       
        public void Print()
        {
            Console.WriteLine($"This dog is a {Type}");
        }
    }
}
namespace InterfaceLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var pb = new PitBull();
            var ch = new Chihuahua();
            var sh = new ShibaInu();
            //creating an array named dogs, setting = to interface IPrint[] {values to put into the array};
            var dogs = new IPrint[] { pb, ch, sh };

            foreach (var dog in dogs)
            {
                //calls the common Print method from each dog class since they're in the IPrint type array
                dog.Print();
            }
        }
    }
}

//      EXCEPTIONS

namespace ExceptionLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exceptions are errors that will stop the program where it occurs
            //By using a try/catch, it will store the exception so you can handle it while continuing the working parts of the program
            //try this method
            try
            {
                Level1();
            }
            //catch (ExceptionName newVariableName)
            catch (DivideByZeroException ex)
            {
                //writes out the Message for that exception if it is caught
                Console.WriteLine($"Exception handled in Main: {ex.Message}");
            }
        }
        //creates method Level1() that just calls to method Level2()
        static void Level1()
        {
            Level2();
        }
        //creates method Level2() that just calls to method Level3()
        static void Level2()
        {
            Level3();
        }
        //creates method Level3()
        //doesn't matter how deep the exception occurs, it will catch it where the try/catch is
        static void Level3()
        {
            var n = 1;
            var d = 0;
            //you can't divide by 0 so this will cause an exception
            var e = n / d;
        }
    }
}

//      GENERIC COLLECTIONS

//must include using System.Collections.Generic; 
namespace GenericCollectionLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates variable ints, initializing as a new List<DataType>();
            var ints = new List<int>();
            //Adds (DataType) to collection ints
            ints.Add(4);
            ints.Add(7);
            ints.Add(15);
            //.Count counts how many objects are in a collection
            Console.WriteLine($"The ints have {ints.Count} items");
            //Removes the object 7 from the collection ints
            ints.Remove(7);
            Console.WriteLine($"The ints have {ints.Count} items");

            //creates a random integer and sets it to var rnd
            Random rnd = new Random();
            var totalScore = 0;
            var frames = new List<int>();
            var attempts = 0;
            //for loop, 10 times
            for (int i = 0; i < 10; i++)
            {
                //creates var score, set to rnd(Random integer between 0-31)
                var score = rnd.Next(0, 31);
                //Adds the score to the frames collection
                frames.Add(score);
            }
            foreach (var frame in frames)
            {
                totalScore += frame;
            }
            //While loop to see how many attempts it takes to get a score > 295
            while (totalScore < 295)
            {
                //Removes all objects in frames < 31 (which is all)
                frames.RemoveAll(x => x < 31);
                totalScore = 0;
                for (int i = 0; i < 10; i++)
                {
                    var score = rnd.Next(0, 31);
                    frames.Add(score);
                }
                foreach (var frame in frames)
                {
                    totalScore += frame;
                }
                attempts++;
            }
            Console.WriteLine($"You scored {totalScore} this game, only took you {attempts} attempts.");
        }
    }
}

//      STACK COLLECTION

// Imagine the plates at a buffet, you take one off the top (pop) and the one under it pops up to replace it
// You place one back on top (push) and it becomes the new top
namespace RpnCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();

            foreach (var arg in args)
            {
                switch (arg.Substring(0, 1))
                {
                    //process the operator
                    case "+":
                        //takes the top object from the stack
                        var op1 = stack.Pop();
                        //will take the next top object from the stack
                        var op2 = stack.Pop();
                        //creates variable ans to get the answer of op1 + op2
                        var ans = op1 + op2;
                        //Puts ans back on top of the stack
                        stack.Push(ans);
                        break;
                    case "-":
                        op1 = stack.Pop();
                        op2 = stack.Pop();
                        ans = op1 - op2;
                        stack.Push(ans);
                        break;
                    case "*":
                        op1 = stack.Pop();
                        op2 = stack.Pop();
                        ans = op1 * op2;
                        stack.Push(ans);
                        break;
                    case "/":
                        op1 = stack.Pop();
                        op2 = stack.Pop();
                        ans = op1 / op2;
                        stack.Push(ans);
                        break;
                    //convert to integer
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        int i;
                        //Try Parse(converting string) to int using (string arg, out i) putting the new value into i
                        //converted will be true or false depending on if the parse worked
                        var converted = int.TryParse(arg, out i);
                        //if converted is false, skip this arguement and go to the next
                        if (!converted) continue;
                        //if it was converted, push it onto our stack list
                        stack.Push(i);
                        //End of arguement
                        break;
                    //throw it away
                    default:
                        break;
                }

            }
            Console.WriteLine($"{stack.Pop()}");
        }
    }
}

//      DICTIONARY

namespace DictionaryLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates array ints holding these (1000) values
            int[] ints = { 8,1,2,5,9,6,1,2,9,8,2,4,7,0,1,3,7,9,4,9,6,8,7,1,9,5,8,4,6,1,8,9,6,6,0,2,7,6,0,6,
                            0,4,7,2,0,1,9,9,1,0,0,8,7,7,4,6,0,1,4,7,5,4,6,8,0,8,6,7,2,0,3,3,8,4,6,2,3,2,8,4,
                            4,8,9,5,1,0,3,4,6,6,6,5,3,4,7,5,5,8,5,8,0,9,4,6,2,8,8,0,0,3,9,2,5,7,8,9,5,8,2,5,
                            0,2,2,7,6,9,9,2,4,2,6,6,6,4,9,2,0,2,5,6,2,4,6,6,0,5,6,0,3,2,5,0,7,7,2,5,1,6,5,5,
                            3,1,5,3,6,4,0,7,9,2,4,3,8,0,5,0,7,3,3,0,8,9,4,5,4,6,1,9,4,5,9,6,3,0,9,8,1,8,8,7,
                            6,7,7,4,3,9,4,9,3,0,2,5,3,7,6,2,5,6,2,2,3,4,7,3,6,3,7,0,7,1,7,5,7,3,3,9,0,5,3,8,
                            9,9,4,8,5,1,7,0,7,1,5,2,9,5,8,2,9,9,1,5,1,4,6,6,1,9,8,7,3,7,5,6,2,0,6,3,5,4,7,3,
                            1,5,7,0,2,2,3,3,5,1,4,1,3,7,4,5,7,5,5,2,4,1,7,0,6,0,5,3,7,4,3,4,4,7,3,6,2,3,2,7,
                            7,7,6,6,9,4,3,3,4,3,9,7,1,9,4,4,0,4,4,9,6,2,3,2,2,4,3,4,0,4,3,5,0,7,6,4,2,3,3,1,
                            9,7,8,2,7,4,9,7,7,0,8,0,4,6,0,4,6,1,4,2,8,2,5,2,7,1,1,1,6,8,5,3,2,8,2,2,5,2,9,7,
                            0,5,8,1,0,5,3,9,1,1,4,1,9,3,2,0,7,8,4,1,6,7,8,6,5,4,0,7,0,0,5,9,9,7,2,7,1,8,6,0,
                            9,2,1,4,6,7,9,8,5,8,6,6,8,9,3,5,5,6,4,9,8,5,7,7,0,9,4,1,7,0,8,1,5,1,0,8,7,7,7,1,
                            9,7,7,7,5,5,4,4,7,0,7,1,5,6,5,2,0,8,8,1,7,8,3,3,8,2,0,5,8,2,0,0,0,4,3,8,4,8,7,9,
                            2,8,5,6,9,4,2,9,5,2,2,7,1,9,0,0,2,1,2,5,1,9,7,7,6,9,7,6,5,8,0,5,6,3,4,5,2,8,5,1,
                            4,5,2,9,0,7,3,8,1,1,4,7,4,5,1,9,1,9,7,9,7,5,4,4,5,6,9,2,2,4,2,2,3,8,3,5,6,8,9,1,
                            0,9,6,6,4,3,5,4,5,6,3,0,2,9,3,9,4,2,0,6,1,6,2,4,1,8,1,9,3,5,3,9,7,4,5,8,3,6,6,9,
                            6,6,1,4,4,3,3,8,5,1,0,5,1,9,0,9,2,8,4,6,9,0,2,6,3,3,7,6,5,1,9,3,2,7,6,0,4,8,2,8,
                            5,4,2,3,8,9,1,3,3,8,1,7,6,9,9,9,2,5,3,6,3,9,1,4,1,7,3,3,6,1,3,4,9,4,8,9,3,3,8,3,
                            6,8,7,8,6,0,2,0,3,1,6,7,5,4,8,9,8,4,5,4,4,6,4,0,5,8,8,8,3,6,1,8,3,4,6,7,7,0,3,4,
                            2,8,4,3,6,4,0,3,1,2,3,7,5,1,6,2,1,6,4,1,5,7,4,4,1,1,5,6,8,0,6,8,4,6,2,7,3,4,8,7,
                            4,5,7,3,7,4,8,6,0,0,1,0,6,5,6,2,4,5,3,8,3,1,2,2,4,1,0,6,7,3,5,1,6,1,8,0,5,2,4,2,
                            6,2,4,4,7,1,4,0,3,3,4,9,6,7,6,3,2,1,9,1,6,1,4,7,1,7,8,0,5,3,5,0,2,4,0,0,6,2,8,3,
                            6,6,6,7,3,2,3,3,2,1,6,4,1,5,3,3,0,5,9,4,8,9,0,8,1,3,9,3,5,8,0,3,1,6,2,6,1,1,1,2,
                            9,7,4,3,0,7,9,7,5,4,3,2,1,4,7,3,8,9,3,5,6,5,7,7,1,2,1,9,4,1,8,6,6,9,4,2,2,4,7,1,
                            5,3,1,3,7,7,5,0,0,4,6,2,6,3,1,3,8,9,7,2,9,4,3,3,3,8,9,9,3,1,4,0,8,2,9,1,6,0,3,6 };

            //creating variable dictionary, initializing as a Dictionary(TKey(DataType), TValue(DataType))
            //TKey = The key in the dictionary that the value is assigned too, 
            //TValue = what to keep track of with that TKey
            var dictionary = new Dictionary<int, int>();


            //Creating a dictionary with keys 1-9, values all 0
            for (int i = 0; i < 10; i++)
            {
                //using Dictionary dictionary, Add (TKey(i's value), TValue(0)
                dictionary.Add(i, 0);
            }

            //Going through each # in the ints array and counting how many instances of that number appear
            foreach (var i in ints)
            {
                //Add 1 to value on that key
                dictionary[i] += 1;
                //dictionary[1] = dictionary[1, 1] first time it sees a 1
                //dictionary[1] = dictionary[1, 2] second time
            }

            //Foreach loop going through the Keys in the Dictionary dictionary
            foreach (var key in dictionary.Keys)
            {
                //dictionary[key] returns the value for that key
                Console.WriteLine($"{key} occurs {dictionary[key]} times.");
            }

            var sum = 0;
            //Calculating the sum of the values in dictionary
            foreach (var key in dictionary.Keys)
            {
                //sum = sum + value of dictionary[key]
                sum += dictionary[key];
            }
            //avg = sum / # of objects in dictionary
            var avg = sum / dictionary.Count;
            Console.WriteLine($"The average is {avg}");
        }
    }
}

//      LIBRARY

//Namespace is different from Main class (TestLibrary)
//must include using.LibraryLesson; or LibraryLesson.(MethodName) to call
namespace LibraryLesson
{
    public class MathLib
    {
        //creating a bunch of methods 
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        public static int Modulo(int a, int b)
        {
            //Modulo is calculated by a-((a*b)/b))
            return Subtract(a, (Multiply(Divide(a, b), b)));
        }
    }
}
//There's usually a Main class with a Library to test it
//Make sure this program has the library as a dependency
namespace TestLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating variable OnePlusTwo to test the library method Add
            var OnePlusTwo = LibraryLesson.MathLib.Add(1, 2);
            var mod = LibraryLesson.MathLib.Modulo(5, 3);
        }
    }
}

//      EXTENSIONS

namespace ExtensionMethodsLesson
{
    //extensions must be static, and so must their methods
    static class MyExtensionMethods
    {
        //methods have parameter (this, (DataType being called) (name))
        public static void ToConsole(this string str)
        {
            //will write the string value of the variable calling toConsole
            Console.WriteLine($"The string is {str}");
        }
        public static string ToUpperCase(this string str)
        {
            //takes the value entered, returns it in UpperCase
            return str.ToUpper();
        }
    }
}
namespace ExtensionMethodsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var abc = "abc";
            //calls our extension method ToConsole from MyExtensionMethods
            //like saying Console.WriteLine($"The string is {abc}");
            abc.ToConsole();

            //passes value of abc to ToUpperCase, then passes through ToConsole
            abc.ToUpperCase().ToConsole();
        }
    }
}

//      LANGUAGE INTEGRATED QUERY (LINQ)

//must use using.System.Linq;
namespace LINQ
{
    class LINQY
    {
        static int[] ints = {
            505,916,549,881,918,385,350,228,489,719,
            866,252,130,706,581,313,767,691,678,187,
            115,660,653,564,805,720,729,392,598,791,
            620,345,292,318,726,501,236,573,890,357,
            854,212,670,782,267,455,579,849,229,661,
            611,588,703,607,824,730,239,118,684,149,
            206,952,531,809,134,929,593,385,520,214,
            643,191,998,555,656,738,829,454,195,419,
            326,996,666,242,189,464,553,579,188,884,
            197,369,435,476,181,192,439,615,746,277
        };

        static void Main(string[] args)
        {
            //      (LINQ) Method Syntax
            //creating variable avg, setting = array ints.Where(using variable(x) to represent each int in ints => boolean to check).GetTheAverage();
            var avg = ints.Where(x => x % 3 == 0 || x % 5 == 0).Average();

            //      (LINQ) Query Syntax
            //Similar to SQL syntax, but the select is the last clause and from is the first
            //everything in () is the actual query syntax
            var avg0 = (from i in ints
                        where i % 3 == 0 || i % 5 == 0
                        select i).Average();

            //Does everything this does
            var sum = 0;
            var count = 0;

            foreach (var num in ints)
            {
                if (num % 3 == 0 || num % 5 == 0)
                {
                    sum += num;
                    count++;
                }
            }
            var avg1 = sum / count;

            //Using Query Syntax creating a collection of just the names from customers collection
            var names = (from c in customers
                            //JOIN another table to this query
                        join o in orders
                        //ON (PK equals FK)
                        on c.Id equals o.CustId
                        //WHERE clause comes before select, takes booleans like while/for clauses
                        where c.Sales > 1000 || c.Sales == 500
                        //ORDERBY ____ descending (ascending is by default)
                        orderby c.Sales descending
                        //Select is what will actually be put into our new list, so it'll select the customers name (c.Name) and everything in orders (o)
                        select new { c.Name, o })
                        //We'd wrap the entire query in () so that we can utilize a method on the select, such as .Take()
                        .Take(5);

            //USING GROUP BY
            var result = from c in customers
                             //GROUP BY 
                         group c by c.State into st
                         select new { State = st.Key };
        }
    }
}

//      DBCONTEXT

//must include using Microsoft.EntityFrameworkCore;
//to get this package, using package manager, enter the following
//install-package Microsoft.EntityFrameworkCore.Tools
//install-package Microsoft.EntityFrameworkCore.SqlServer

//if you already have a database and want to link it to this program/autopopulate, do this
//scaffold-dbcontext 'server={servername};database={dbname};trusted_connection=true;' Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

//add-migration "description" to compare what new properties/data is in the models and adds what changes you've made that aren't there
//update-database takes the migration and merges into the actual database

namespace Bootcamp.Models
{
    //Inherits from the DbContext class which is in the SqlServer package we installed
    public class BootcampContext : DbContext
    {
        //creating a DbSet<Class> for each class(table) in the database
        //must make a DbSet<Class> After creating a new class before adding a migration, this is what creates the columns in our Database
        public DbSet<Student> Students { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<AssessmentScore> AssessmentScores { get; set; }

        //connector for the database
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                var connStr = "server=localhost\\sqlexpress01;database=CSBootcampDb;trusted_connection=true;";
                builder.UseSqlServer(connStr);
            }
        }
        //OnModelCreating is just for when we have a field that isn't a PK that needs to be unique
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //when created, using Employee
            builder.Entity<Student>(e =>
            {
                //Makes sure the Firstname is unique
                e.HasIndex(p => p.Firstname).IsUnique();
            });
        }
    }
}
namespace Bootcamp.Models
{
    public class AssessmentScore
    {
        //EntityFramework automatically sees Id as Primary Key
        public int Id { get; set; }

        public int ActualScore { get; set; }

        //EF automatically sees StudentId as a foreign key to Student table because Id at the end 
        public int StudentId { get; set; }
        //Virtual makes it so that it doesn't create a column in our database, but can tie back this instance of data
        public virtual Student Student { get; set; }

        public int AssessmentId { get; set; }
        public virtual Assessment Assessment { get; set; }

        public AssessmentScore()
        {

        }
    }
}
namespace Bootcamp.Models
{
    public class Student
    {
        public int Id { get; set; }
        //These are attributes that will define restrictions in Sql
        //Required tells Sql Not null
        [Required]
        //Stringlength = varchar(50) for sql
        [StringLength(50)]
        public string Firstname { get; set; }
        [Required, StringLength(50)]
        public string Lastname { get; set; }
        //Sets the  decimal to what Sql needs, (11 characters, 2 after the decimal)
        [Column(TypeName = "decimal(11,2)")]
        public decimal TargetSalary { get; set; }
        public bool? InBootcamp { get; set; }

        public virtual List<AssessmentScore> AssessmentScores { get; set; }

        public Student() { }
    }
}
namespace Bootcamp.Models
{
    public class Assessment
    {
        public int Id { get; set; }
        [Required, StringLength(30)]
        public string Topic { get; set; }
        public int NumberOfQuestions { get; set; }
        public int MaxPoints { get; set; }

        public virtual List<AssessmentScore> AssessmentScores { get; set; }

        public Assessment()
        {

        }
    }
}
namespace Bootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a variable to hold the instance of our context
            var context = new Models.BootcampContext();

            //create yourself as a student
            var z = new Bootcamp.Models.Student()
            {
                Firstname = "ZhaQuon",
                Lastname = "Poindexter",
                TargetSalary = 1000000,
                InBootcamp = true
            };
            context.Students.Add(z);

            //create all 5 assessments
            var git = new Bootcamp.Models.Assessment()
            {
                Topic = "Git",
                MaxPoints = 100,
                NumberOfQuestions = 6,
            };

            var sql = new Bootcamp.Models.Assessment()
            {
                Topic = "SQL",
                MaxPoints = 100,
                NumberOfQuestions = 12,
            };

            var html = new Bootcamp.Models.Assessment()
            {
                Topic = "HTML",
                MaxPoints = 100,
                NumberOfQuestions = 12,
            };

            var java = new Bootcamp.Models.Assessment()
            {
                Topic = "JavaScript",
                MaxPoints = 100,
                NumberOfQuestions = 12,
            };

            var angular = new Bootcamp.Models.Assessment()
            {
                Topic = "Angular/Typescript",
                MaxPoints = 100,
                NumberOfQuestions = 12,
            };

            context.Assessments.AddRange(git, sql, html, java, angular);

            //insert the 2 you already took
            var zgit = new Bootcamp.Models.AssessmentScore()
            {
                ActualScore = 110,
                Assessment = git,
                StudentId = z.Id
            };


            var zsql = new Bootcamp.Models.AssessmentScore()
            {
                ActualScore = 100,
                Assessment = sql,
                StudentId = z.Id
            };
            context.AssessmentScores.AddRange(zsql, zgit);

            //must save changes in order to update the database
            var rowsAffected = context.SaveChanges();
            //checks rowsAffected to confirm it worked
            var success = (rowsAffected == 8);
            //Getting the average of Assessment Scores
            var avg = context.AssessmentScores.Average(asc => asc.ActualScore);
            //Getting the average of ASsessment Scores by a student firstname
            var avg1 = context.AssessmentScores.Where(x => x.Student.Firstname == "ZhaQuon").ToArray().Average(c => c.ActualScore);
            //Using Query syntax to join all of the tables and get the fields
            var scores = from asc in context.AssessmentScores
                        join s in context.Students
                        on asc.StudentId equals s.Id
                        join a in context.Assessments
                        on asc.AssessmentId equals a.Id
                        select new { s, a, asc };

            foreach (var score in scores)
            {
                //score is the instance of the scores in the list, the s is the s alias (Students created above), then pointing to lastname in student
                Console.WriteLine($"{score.s.Lastname} got a {score.asc.ActualScore}");
            }
        }
    }
}

//      API (Web Applications)

//Our DbContext for our website
namespace PoWebApi.Data
{
    public class PoContext : DbContext
    {
        public PoContext(DbContextOptions<PoContext> options)
            : base(options)
        {
        }

        public DbSet<PoWebApi.Models.Employee> Employee { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<PurchaseOrderLine> PurchaseOrderLines { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //when created, using Employee
            builder.Entity<Employee>(e => {
                //Makes sure the Login is unique
                e.HasIndex(p => p.Login).IsUnique();
            });
        }
    }
}
namespace PoWebApi.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Login { get; set; }

        [Required, StringLength(30)]
        public string Password { get; set; }

        [Required, StringLength(30)]
        public string Firstname { get; set; }

        [Required, StringLength(30)]
        public string Lastname { get; set; }
        public bool IsManager { get; set; }

        public Employee() { }
    }
}
namespace PoWebApi.Models
{
    public class PurchaseOrder
    {
        public static string StatusNew { get; set; } = "New";
        public static string StatusEdit { get; set; } = "Edit";
        public static string StatusReview { get; set; } = "Review";
        public static string StatusApproved { get; set; } = "Approved";
        public static string StatusRejected { get; set; } = "Rejected";

        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Description { get; set; }

        [Required, StringLength(20)]
        public string Status { get; set; } = PurchaseOrder.StatusNew;

        [Column(TypeName = "decimal(9,2)")]
        public decimal Total { get; set; } = 0;

        public bool Active { get; set; } = true;

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public PurchaseOrder() { }
    }
}
namespace PoWebApi.Models
{
    public class PurchaseOrderLine
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public int PurchaseOrderId { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }

        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
    }
}
namespace PoWebApi.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Name { get; set; }

        [Required, Column(TypeName = "decimal(7,2)")]
        public decimal Price { get; set; }

        public bool Active { get; set; } = true;
    }
}

//Our controllers (which are automatically generated)
namespace PoWebApi.Controllers
{
    //Route points to the site we'd use to access this controller
    //The 7149 is your port number
    //http://localhost:7149/api/Employees
    [Route("api/[controller]")]
    //ApiController attribute takes the class name of our controller and strips off the word Controller (leaving us with Employees)
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        //creates our context variable - readonly means we can only change it in a constructor, and afterwards it'll only be readable
        private readonly PoContext _context;
        //The constructor for context, takes whatever context we pass in and sets it to _context to be used in this class (dependency injection)
        public EmployeesController(PoContext context)
        {
            _context = context;
        }

        // GET: api/Employees
        // GET = SELECT
        [HttpGet]
        //async -> anything that calls this, must call it asynchronously (without preventing the user from doing anything else)
        //Task is a class in .NET that is required for Async data
        //returns ActionResult -> class that has lots of derived classes (Bad Request, Not Found, etc..) that you can use to return diff things to use in your methods/primarily for returning error messages
        //if ActionResult catches no errors, returns IEnumerable -> interface for a collection of <Employee>, which is the generic collection class (so we can return an array or a list)
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployee()
        {
            //must use await before the context to do things asynchronously, allows us to do async calls as if they were synchronous
            return await _context.Employee.ToListAsync();
        }

        // GET: api/Employees/5
        //("{id}") is a route parameter in the HttpGet, requiring us to add /? to our url where ? is the data that gets loaded into id
        //If we wanted another method just requiring id, we'd have to change the url to something such as
        //[HttpGet("textHere/{id}/orTextHere")]
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            var employee = await _context.Employee
                                        //if there was a FK, we'd show the instance it was pointing to with the following
                                        //.Include( e => e.InstanceName)
                                        .FindAsync(id);

            //If we didn't find an employee, we can do this instead of returning null
            if (employee == null)
            {
                //this return is acceptable because it is an ActionResult type
                return NotFound();
            }
            //returns the Ok ActionResult type, as well as the data for (employee)
            return Ok(employee);
        }

        //GET: api/Employees/gpdoud/password
        [HttpGet("{login}/{password}")]
        public async Task<ActionResult<Employee>> Login(string login, string password)
        {
            var employee = await _context.Employee
                .SingleOrDefaultAsync(e => e.Login == login && e.Password == password);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        // PUT: api/Employees/5
        // PUT = UPDATE
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, Employee employee)
        {
            if (id != employee.Id)
            {
                return BadRequest();
            }

            _context.Entry(employee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Employees
        //POST = INSERT
        [HttpPost]
        //A post method is expecting us to pass the entire instance of the data (employee) into the body of the request, not the url
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        {
            //only time you don't need await before context is adding because it is just loading the data into a cache
            _context.Employee.Add(employee);

            //still need it for save changes
            await _context.SaveChangesAsync();
            //Returns CreatedAtAction ActionResult type, with data ("GetEmployee"(method to show us the employee that was added), with the new employee instance)
            return CreatedAtAction("GetEmployee", new { id = employee.Id }, employee);
        }

        // DELETE: api/Employees/5
        // DELETE = DELETE
        [HttpDelete("{id}")]
        public async Task<ActionResult<Employee>> DeleteEmployee(int id)
        {
            var employee = await _context.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();

            return Ok(employee);
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.Id == id);
        }
    }
}
namespace PoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrdersController : ControllerBase
    {
        private readonly PoContext _context;

        public PurchaseOrdersController(PoContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseOrders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchaseOrder>>> GetPurchaseOrders()
        {
            return await _context.PurchaseOrders
                                    //When a class has a virtual instance of another class, you must Include it for the full instance to show
                                    .Include(e => e.Employee)
                                    .ToListAsync();
        }
        // GET: api/PurchaseOrders/underReview
        [HttpGet("underReview")]
        public async Task<ActionResult<IEnumerable<PurchaseOrder>>> GetPurchaseOrdersUnderReview()
        {
            return await _context.PurchaseOrders
                                    .Where(x => x.Status == PurchaseOrder.StatusReview)
                                    .Include(e => e.Employee)
                                    .ToListAsync();
        }
        // GET: api/PurchaseOrders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseOrder>> GetPurchaseOrder(int id)
        {
            var purchaseOrder = await _context.PurchaseOrders
                                                .SingleOrDefaultAsync(e => e.Id == id);

            if (purchaseOrder == null)
            {
                return NotFound();
            }

            return purchaseOrder;
        }

        // GET: api/PurchaseOrders/5/getEmp
        [HttpGet("{id}/getEmp")]
        public async Task<ActionResult<PurchaseOrder>> GetPurchaseOrderWithEmp(int id)
        {
            var purchaseOrder = await _context.PurchaseOrders
                                                .Include(e => e.Employee)
                                                .SingleOrDefaultAsync(e => e.Id == id);

            if (purchaseOrder == null)
            {
                return NotFound();
            }
            return purchaseOrder;
        }

        // PUT: api/PurchaseOrders/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseOrder(int id, PurchaseOrder purchaseOrder)
        {
            if (id != purchaseOrder.Id)
            {
                return BadRequest();
            }

            _context.Entry(purchaseOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseOrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        // PUT: api/PurchaseOrders/5/edit
        [HttpPut("{id}/edit")]
        public async Task<IActionResult> PutPurchaseOrderToEdit(int id)
        {
            var purchaseOrder = await _context.PurchaseOrders.FindAsync(id);
            if (purchaseOrder == null)
            {
                return NotFound();
            }

            purchaseOrder.Status = "Edit";

            return await PutPurchaseOrder(id, purchaseOrder);
        }
        // PUT: api/PurchaseOrders/5/review
        [HttpPut("{id}/review")]
        public async Task<IActionResult> PutPurchaseOrderToReview(int id)
        {
            var purchaseOrder = await _context.PurchaseOrders.FindAsync(id);
            var total = purchaseOrder.Total;

            if (purchaseOrder == null)
            {
                return NotFound();
            }

            purchaseOrder.Status = (purchaseOrder.Total <= 100 && purchaseOrder.Total > 0) ? "Approved" : "Review";

            return await PutPurchaseOrder(id, purchaseOrder);

        }
        // PUT: api/PurchaseOrders/5/approve
        [HttpPut("{id}/approved")]
        public async Task<IActionResult> PutPurchaseOrderToApprove(int id)
        {
            var purchaseOrder = await _context.PurchaseOrders.FindAsync(id);
            if (purchaseOrder == null)
            {
                return NotFound();
            }
            purchaseOrder.Status = "Approved";

            return await PutPurchaseOrder(id, purchaseOrder);
        }
        // PUT: api/PurchaseOrders/5/reject
        [HttpPut("{id}/rejected")]
        public async Task<IActionResult> PutPurchaseOrderToReject(int id)
        {
            var purchaseOrder = await _context.PurchaseOrders.FindAsync(id);
            if (purchaseOrder == null)
            {
                return NotFound();
            }
            purchaseOrder.Status = "Rejected";

            return await PutPurchaseOrder(id, purchaseOrder);
        }
        //PUT: api/PurchaseOrders/manual/5/status
        [HttpPut("manual/{id}/{status}")]
        public async Task<IActionResult> PutPurchaseOrderToStatus(int id, string status)
        {
            var statuses = "|edit| |review| |approved| |rejected|";
            var purchaseOrder = await _context.PurchaseOrders.FindAsync(id);
            if (purchaseOrder == null)
            {
                return NotFound();
            }
            if (!statuses.Contains($"|{status.ToLower()}|"))
            {
                return BadRequest();
            }
            purchaseOrder.Status = char.ToUpper(status[0]) + status.Substring(1).ToLower();

            if (status.ToLower() == "review")
            {
                purchaseOrder.Status = (purchaseOrder.Total <= 100 && purchaseOrder.Total > 0) ? "Approved" : "Review";
            }
            return await PutPurchaseOrder(id, purchaseOrder);
        }

        // POST: api/PurchaseOrders
        [HttpPost]
        public async Task<ActionResult<PurchaseOrder>> PostPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            _context.PurchaseOrders.Add(purchaseOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPurchaseOrder", new { id = purchaseOrder.Id }, purchaseOrder);
        }

        // DELETE: api/PurchaseOrders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PurchaseOrder>> DeletePurchaseOrder(int id)
        {
            var purchaseOrder = await _context.PurchaseOrders.FindAsync(id);
            if (purchaseOrder == null)
            {
                return NotFound();
            }

            _context.PurchaseOrders.Remove(purchaseOrder);
            await _context.SaveChangesAsync();

            return purchaseOrder;
        }

        private bool PurchaseOrderExists(int id)
        {
            return _context.PurchaseOrders.Any(e => e.Id == id);
        }
    }
}
namespace PoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderLinesController : ControllerBase
    {
        private readonly PoContext _context;

        public PurchaseOrderLinesController(PoContext context)
        {
            _context = context;
        }

        private async Task RecalculatePoTotal(int poid)
        {
            var po = await _context.PurchaseOrders.FindAsync(poid);
            if (po == null) throw new Exception("FATAL: Po is not found to recalc!");
            po.Total = (from l in _context.PurchaseOrderLines
                        join i in _context.Items
                        on l.ItemId equals i.Id
                        where l.PurchaseOrderId == poid
                        select new { LineTotal = l.Quantity * i.Price }).Sum(x => x.LineTotal);
            await _context.SaveChangesAsync();
        }

        // GET: api/PurchaseOrderLines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchaseOrderLine>>> GetPurchaseOrderLines()
        {
            return await _context.PurchaseOrderLines.ToListAsync();
        }

        // GET: api/PurchaseOrderLines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseOrderLine>> GetPurchaseOrderLine(int id)
        {
            var purchaseOrderLine = await _context.PurchaseOrderLines.FindAsync(id);

            if (purchaseOrderLine == null)
            {
                return NotFound();
            }
            return purchaseOrderLine;
        }
        // PUT: api/PurchaseOrderLines/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseOrderLine(int id, PurchaseOrderLine purchaseOrderLine)
        {
            if (id != purchaseOrderLine.Id)
            {
                return BadRequest();
            }

            _context.Entry(purchaseOrderLine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                await RecalculatePoTotal(purchaseOrderLine.PurchaseOrderId);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseOrderLineExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        // POST: api/PurchaseOrderLines
        [HttpPost]
        public async Task<ActionResult<PurchaseOrderLine>> PostPurchaseOrderLine(PurchaseOrderLine purchaseOrderLine)
        {
            _context.PurchaseOrderLines.Add(purchaseOrderLine);
            await _context.SaveChangesAsync();
            await RecalculatePoTotal(purchaseOrderLine.PurchaseOrderId);

            return CreatedAtAction("GetPurchaseOrderLine", new { id = purchaseOrderLine.Id }, purchaseOrderLine);
        }

        // DELETE: api/PurchaseOrderLines/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PurchaseOrderLine>> DeletePurchaseOrderLine(int id)
        {
            var purchaseOrderLine = await _context.PurchaseOrderLines.FindAsync(id);
            if (purchaseOrderLine == null)
            {
                return NotFound();
            }

            _context.PurchaseOrderLines.Remove(purchaseOrderLine);
            await _context.SaveChangesAsync();
            await RecalculatePoTotal(purchaseOrderLine.PurchaseOrderId);

            return purchaseOrderLine;
        }

        private bool PurchaseOrderLineExists(int id)
        {
            return _context.PurchaseOrderLines.Any(e => e.Id == id);
        }
    }
}
//This is our appsettings
{
    "Logging": {
        "LogLevel": {
            "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
        }
    },
  "AllowedHosts": "*",
  "ConnectionStrings": {
        //This is our connection string
        "PoDb": "server=localhost\\sqlexpress01;database=PoDb;trusted_connection=true;"
  }
}
//Our Startup class that utilizes our connection and sets configurations
namespace PoWebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //Must point to our connection string to link the database to use
            services.AddDbContext<PoContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("PoDb")));

            //CrossOriginScripting, piece of server code that allows you to limit what can talk to your server
            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //Must include this to allow any origin (any machine) to talk to our server, and allow any header, and allow any method to be used
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

//      C# TO WEBAPI      

//Could be used instead of PostMan to call HttpMethods on a WebApi
namespace CSharp2WebApi
{
    class Program
    {
        async Task Run()
        {
            //this is the class that gives us the ability in c# to call any api (any website)
            var http = new HttpClient();
            //This is a class to allow 
            var jsonSerializerOptions = new JsonSerializerOptions()
            {
                //This property allows us to ignore differences in case types (john = John = JOHN)
                PropertyNameCaseInsensitive = true,
                //This controls how it pulls text (converts it to CamelCase, which is  thisExampleHere (first word lower, following words upper)
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            //this variable points to the url we are using
            var url = "http://localhost:7149/api/employees";

            //this is to call an HttpClient method (http).GET(using url);
            //This instance calls to the http server and will get all employees, storing it into our var
            var httpMessageResponse = await http.GetAsync(url);
            //creates variable httpContent to take the .Content of our get (httpMessageResponse) and read it as a string
            var httpContent = await httpMessageResponse.Content.ReadAsStringAsync();
            //JsonSerializer is a class in C# specifically to turn JSon -> C# (deserialize) or C# -> JSon (serialize)
            //creates variable employees to capture the C# version of (DataType <Employee[Array]>(what httpContent returned,using our jsonSerializerOptions)
            var employees = JsonSerializer.Deserialize<Employee[]>(httpContent, jsonSerializerOptions);

            //creating a new employee that we will push using HttpPut method
            var newEmpl = new Employee()
            {
                Id = 0,
                Firstname = "Noah",
                Lastname = "Phence",
                Login = "nphence",
                Password = "password",
                IsManager = true
            };
            //creates var json to hold the newEmpl employee, serialize (convert to JSon text)
            var json = JsonSerializer.Serialize<Employee>(newEmpl, jsonSerializerOptions);
            //this uses the json variable to encode it into json format
            var httpContent2 = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            //calls our http Post Method to insert this new customer to (url, contentToBePassedUp)
            var httpMessageResponse2 = await http.PostAsync(url, httpContent2);

            foreach (var e in employees)
            {
                Console.WriteLine($"{e.Id} {e.Lastname} {e.IsManager}");
            }

        }

        async static Task Main(string[] args)
        {
            var pgm = new Program();
            await pgm.Run();
        }
    }
}
namespace CSharp2WebApi
{
    class Employee
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public bool IsManager { get; set; }

        public Employee() { }
    }
}

//      XUNIT AUTOMATED TESTING

//You typically want to test multiple cases to make sure everything works
//The testing class must be under xUnit Test Project
//Needs dependency to the Library holding the methods we want to test
namespace TestMathLib
{
    public class TestMathLibrary
    {
        //Theory allows us to test multiple input data, which will give us multiple outputs
        //[Fact] would be used if there was 1 definitive answer (ex. Pi = 3.1714...)
        [Theory]
        //InlineData(Data we want to pass into our test)
        [InlineData(1, 2, 3)]
        [InlineData(-1, -2, -3)]
        [InlineData(6, 2, 8)]
        [InlineData(-2, 5, 3)]
        [InlineData(int.MaxValue, int.MinValue, -1)]
        [InlineData(-88, 18, -70)]
        [InlineData(10, 0, 10)]
        [InlineData(10, -10, 0)]
        //Creating the test method holding variables for InlineData
        public void TestAdd(int i, int j, int ans)
        {
            var mathLib = new MathLib();
            //Equal checks if the two values inside() are equal to each other
            //The answer you're expecting always goes first, the method to get the answer goes last
            Assert.Equal(ans, mathLib.Add(i, j));
        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(0, 20, -20)]
        [InlineData(int.MinValue, int.MaxValue, 1)]
        [InlineData(-10, -20, 10)]
        public void TestSubtract(int i, int j, int ans)
        {
            var mathLib = new MathLib();
            Assert.Equal(ans, mathLib.Subtract(i, j));
        }

        [Theory]
        [InlineData(10, 0, 0)]
        [InlineData(int.MaxValue, 1, int.MaxValue)]
        [InlineData(int.MinValue, 1, int.MinValue)]
        [InlineData(5, 5, 25)]
        [InlineData(-10, -10, 100)]
        [InlineData(-50, 3, -150)]
        public void TestMultiply(int i, int j, int ans)
        {
            var mathLib = new MathLib();
            Assert.Equal(ans, mathLib.Multiply(i, j));
        }

        [Theory]
        [InlineData(100, 5, 20)]
        [InlineData(-50, 10, -5)]
        [InlineData(-20, -2, 10)]
        [InlineData(1, 0, 0)]
        public void TestDivide(int i, int j, int ans)
        {
            var mathLib = new MathLib();
            if (j == 0)
            {
                //This is to catch an exception (DivideByZero) () calls the function, => where function is ___ (mathLib.Divide)
                Assert.ThrowsAny<DivideByZeroException>(() => mathLib.Divide(i, j));
                return;
            }
            Assert.Equal(ans, mathLib.Divide(i, j));
        }

        [Theory]
        [InlineData(2, 3, 8)]
        [InlineData(-5, 2, 25)]
        [InlineData(0, 50, 0)]
        public void TestPower(int i, int j, int ans)
        {
            var mathLib = new MathLib();
            Assert.Equal(ans, mathLib.Power(i, j));
        }

        [Theory]
        [InlineData(2, 4)]
        [InlineData(0, 0)]
        [InlineData(-5, 25)]
        public void TestSquare(int i, int ans)
        {
            var mathLib = new MathLib();
            Assert.Equal(ans, mathLib.Square(i));
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(4, 24)]
        [InlineData(-4, 24)]
        public void TestFactorial(int i, int ans)
        {
            var mathLib = new MathLib();
            Assert.Equal(ans, mathLib.Factorial(i));
        }

        [Theory]
        [InlineData(10, 2, 0)]
        [InlineData(0, 4, 0)]
        [InlineData(50, 16, 2)]
        [InlineData(-10, -101, -10)]
        public void TestModulo(int i, int j, int ans)
        {
            var mathLib = new MathLib();
            Assert.Equal(ans, mathLib.Modulo(i, j));
        }
    }
}
//The Interface
namespace TestingMathLibrary
{
    public interface IMathLibrary
    {

        int Add(int i, int j);
        int Subtract(int i, int j);
        int Multiply(int i, int j);
        int Divide(int i, int j);
        int Power(int i, int j);
        int Square(int i);
        int Factorial(int i);
        int Modulo(int i, int j);

    }
}
//The Library for our methods
namespace TestingMathLibrary
{
    //connecting to our interface
    public class MathLib : IMathLibrary
    {
        public int Add(int i, int j)
        {
            return i + j;
        }

        public int Subtract(int i, int j)
        {
            return i - j;
        }

        public int Multiply(int i, int j)
        {
            return i * j;
        }

        public int Divide(int i, int j)
        {
            return i / j;
        }

        public int Power(int i, int j)
        {
            var answer = Math.Pow(i, j).ToString();
            return Int32.Parse(answer);
        }

        public int Square(int i)
        {
            return i * i;
        }

        public int Factorial(int i)
        {

            int solution = 1;
            if (i == 0)
            {
                solution = 0;
            }
            for (var c = i; c > 0; c--)
            {
                solution *= c;
            }
            if (i < 0)
            {
                for (var c = i; c < 0; c++)
                {
                    solution *= c;
                }
            }
            return solution;
        }

        public int Modulo(int i, int j)
        {
            return Subtract(i, (Multiply(Divide(i, j), j)));
        }

    }
}

//		BIT MASKING

namespace CensusProblem
{

    class Program
    {
        //Finding a subset of this array that added up will = 100,000,000
        int[] populations = { 18897109, 12828837, 9461105, 6371773, 5965343,
                                5946800, 5582170, 5564635, 5268860, 4552402,
                                4335391, 4296250, 4224851, 4192887, 3439809,
                                3279833, 3095313, 2812896, 2783243, 2710489,
                                2543482, 2356285, 2226009, 2149127, 2142508, 2134411 };
        /*Binary is all 1s and 0s, incrementing up as follows
		0000, 0001, 0010, 0011, 0100, 0101, 0110, 0111, 1000, 1001, 1010, 1011, 1100, 1101, 1110, 1111, 10000, 10001...
		 0,    1,    2,    3,    4,    5,    6,    7...
		Since it only contains 2 numbers, we can use 2^(numbers) and it'll get us the binary with (numbers) of 0s after a 1
		2^10 = 0b100_0000_0000 = 1024
		*/
        void run()
        {
            var start = DateTime.Now;
            var end = DateTime.Now;
            // 0b is needed for binary
            //This is the equivalent to 2^25 (25 0s is how we know)
            //This is because we have 26 entries in our array, and we want a spot for each entry
            int i = 0b10_0000_0000_0000_0000_0000_0000;
            int tot = 0;
            var goal = 100000000;
            while (tot != goal || i < Math.Pow(2, 26))
            {
                //(i & 0b1) looks at the 1's on i and checks if there is a value
                //first iteration is no, because i = 0b10_0000_0000_0000_0000_0000_000>0<
                //When you add 1 to i, it'll = 0b10_0000_0000_0000_0000_0000_0000_000>1< and this will be true
                if ((i & 0b1) > 0) { tot += populations[0]; }
                if ((i & 0b10) > 0) { tot += populations[1]; }
                if ((i & 0b100) > 0) { tot += populations[2]; }
                if ((i & 0b1000) > 0) { tot += populations[3]; }
                if ((i & 0b1_0000) > 0) { tot += populations[4]; }
                if ((i & 0b10_0000) > 0) { tot += populations[5]; }
                if ((i & 0b100_0000) > 0) { tot += populations[6]; }
                if ((i & 0b1000_0000) > 0) { tot += populations[7]; }
                if ((i & 0b1_0000_0000) > 0) { tot += populations[8]; }
                if ((i & 0b10_0000_0000) > 0) { tot += populations[9]; }
                if ((i & 0b100_0000_0000) > 0) { tot += populations[10]; }
                if ((i & 0b1000_0000_0000) > 0) { tot += populations[11]; }
                if ((i & 0b1_0000_0000_0000) > 0) { tot += populations[12]; }
                if ((i & 0b10_0000_0000_0000) > 0) { tot += populations[13]; }
                if ((i & 0b100_0000_0000_0000) > 0) { tot += populations[14]; }
                if ((i & 0b1000_0000_0000_0000) > 0) { tot += populations[15]; }
                if ((i & 0b1_0000_0000_0000_0000) > 0) { tot += populations[16]; }
                if ((i & 0b10_0000_0000_0000_0000) > 0) { tot += populations[17]; }
                if ((i & 0b100_0000_0000_0000_0000) > 0) { tot += populations[18]; }
                if ((i & 0b1000_0000_0000_0000_0000) > 0) { tot += populations[19]; }
                if ((i & 0b1_0000_0000_0000_0000_0000) > 0) { tot += populations[20]; }
                if ((i & 0b10_0000_0000_0000_0000_0000) > 0) { tot += populations[21]; }
                if ((i & 0b100_0000_0000_0000_0000_0000) > 0) { tot += populations[22]; }
                if ((i & 0b1000_0000_0000_0000_0000_0000) > 0) { tot += populations[23]; }
                if ((i & 0b1_0000_0000_0000_0000_0000_0000) > 0) { tot += populations[24]; }
                //there is a 1 in this spot because i = 0b>1<0_0000_0000_0000_0000_0000_0000
                if ((i & 0b10_0000_0000_0000_0000_0000_0000) > 0) { tot += populations[25]; }
                if (tot == goal)
                {
                    end = DateTime.Now;
                    TimeSpan ts = end - start;
                    print(i, ts);
                    break;
                }
                else
                {
                    tot = 0;
                    i++;
                }
            }
        }

        void print(int i, TimeSpan ts)
        {
            List<int> solution = new List<int>();
            if ((i & 0b1) > 0) { solution.Add(populations[0]); }
            if ((i & 0b10) > 0) { solution.Add(populations[1]); }
            if ((i & 0b100) > 0) { solution.Add(populations[2]); }
            if ((i & 0b1000) > 0) { solution.Add(populations[3]); }
            if ((i & 0b1_0000) > 0) { solution.Add(populations[4]); }
            if ((i & 0b10_0000) > 0) { solution.Add(populations[5]); }
            if ((i & 0b100_0000) > 0) { solution.Add(populations[6]); }
            if ((i & 0b1000_0000) > 0) { solution.Add(populations[7]); }
            if ((i & 0b1_0000_0000) > 0) { solution.Add(populations[8]); }
            if ((i & 0b10_0000_0000) > 0) { solution.Add(populations[9]); }
            if ((i & 0b100_0000_0000) > 0) { solution.Add(populations[10]); }
            if ((i & 0b1000_0000_0000) > 0) { solution.Add(populations[11]); }
            if ((i & 0b1_0000_0000_0000) > 0) { solution.Add(populations[12]); }
            if ((i & 0b10_0000_0000_0000) > 0) { solution.Add(populations[13]); }
            if ((i & 0b100_0000_0000_0000) > 0) { solution.Add(populations[14]); }
            if ((i & 0b1000_0000_0000_0000) > 0) { solution.Add(populations[15]); }
            if ((i & 0b1_0000_0000_0000_0000) > 0) { solution.Add(populations[16]); }
            if ((i & 0b10_0000_0000_0000_0000) > 0) { solution.Add(populations[17]); }
            if ((i & 0b100_0000_0000_0000_0000) > 0) { solution.Add(populations[18]); }
            if ((i & 0b1000_0000_0000_0000_0000) > 0) { solution.Add(populations[19]); }
            if ((i & 0b1_0000_0000_0000_0000_0000) > 0) { solution.Add(populations[20]); }
            if ((i & 0b10_0000_0000_0000_0000_0000) > 0) { solution.Add(populations[21]); }
            if ((i & 0b100_0000_0000_0000_0000_0000) > 0) { solution.Add(populations[22]); }
            if ((i & 0b1000_0000_0000_0000_0000_0000) > 0) { solution.Add(populations[23]); }
            if ((i & 0b1_0000_0000_0000_0000_0000_0000) > 0) { solution.Add(populations[24]); }
            if ((i & 0b10_0000_0000_0000_0000_0000_0000) > 0) { solution.Add(populations[25]); }
            var str = string.Join(", ", solution);
            Console.WriteLine($"In {ts}, the solution is :\n {str}");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            (new Program()).run();
        }
    }
}

//      Creating Stack (Behind the Scenes of Stack)

namespace DataStructureLibrary
{
    //<T> to hold a generic data type (everything in this property will be this type)
    public class Item<T>
    {
        //Creating a property to hold the datatype (generic T)
        public T t { get; set; }
        //Next and Prev our default to -1 for when they aren't pointing to anything
        //Next will move the pointer forward in our array to the NEXT top of stack if there is a pull
        public int Next { get; set; } = -1;
        //Prev will move the pointer backwards in our array to the PREV top of stack if there is a pull
        public int Prev { get; set; } = -1;

        //this method sets our t class to the type entered into Item constructor
        //if we do Item(int 5), our t propery is set to the datatype of 5 (int)
        public Item(T t)
        {
            this.t = t;
        }
    }
}
namespace DataStructureLibrary
{
    public class Stack<T>
    {
        //InitialSize is just our holder for the default # of objects in our array
        private const int InitialSize = 8;
        //Creating an instance of our Item class named item
        public Item<T> item { get; set; }
        //Defining the fixed array of the Items of type T
        private Item<T>[] stack;
        //This will point to the index of the array at the top of the stack, default to -1 saying nothing in the stack
        private int Top = -1;
        //This will keep track of the objects in our array
        public int Count { get; private set; } = 0;
        //This will keep track of if our stack is "full" so we can do something to it when it gets full
        private bool Full => Count == stack.Length;
        //This will just say if the stack is empty or not
        public bool Empty => Count == 0;

        //The method to Push items on top of the stack
        public void Push(T t)
        {
            //If the array is full, call method DoubleCapacity (which will create a new array with double the capacity (first time 16)
            if (Full) DoubleCapacity();
            //If it's not full, we crate a new instance of our item using the data they give us
            var item = new Item<T>(t);
            //We increment Top (since our array is getting 1 more item) and adds that item to our stack
            stack[++Top] = item;
            //Increments our count (first time means there will be 1 item in our stack)
            Count++;
        }

        //This will take an array of params T to push each one into our stack
        public void Push(params T[] ts)
        {
            foreach (var t in ts)
            {
                Push(t);
            }
        }

        //The method to Pop items from the top of the stack
        public T Pop()
        {
            //If the stack is empty, throw this exception
            if (Empty) throw new Exception("Stack is empty!");
            //Create Item<T> type item that = our current stack's Top
            Item<T> item = stack[Top];
            //This will set the Top just Popped to null, then move the Top pointer down one
            stack[Top--] = null;
            //Decrement Count since we've lost an item
            Count--;
            //Returns the item that was Popped from the top
            return item.t;
        }

        //This method will just wipe our stack clean
        public void Reset()
        {
            Top = -1;
            Count = 0;
            stack = new Item<T>[InitialSize];
        }

        //This method will be called when our stack is full to create a new array, double the capacity, then copy the items from old small stack to new stack
        private void DoubleCapacity()
        {
            //New capacity takes our current stack's length and doubles it
            int newCapacity = stack.Length * 2;
            //Creates a new stack with a size of our new capacity
            Item<T>[] newStack = new Item<T>[newCapacity];

            //This loop will go through our smaller array and copies the items into our bigger array
            for (var idx = 0; idx < stack.Length; idx++)
            {
                newStack[idx] = stack[idx];
            }
            stack = newStack;
        }

        //Creating our constructor to set stack as a new array Item<DataType>[OurDefaultSize]
        public Stack()
        {
            stack = new Item<T>[InitialSize];
        }
    }
}
namespace DataStructureLibraryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            for (var idx = 0; idx < 100; idx++)
            {
                stack.Push(idx);
            }
            while (!stack.Empty)
            {
                Console.WriteLine($"{stack.Pop()},");
            }

        }
    }
}

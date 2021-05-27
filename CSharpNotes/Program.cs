//      INTRO TO C#

//using points to a library of code and points to it for the code, currently pointing to System library (System.TQL.Bootcamp.Class1.Console.WriteLine...)
using System;
using System.Collections.Generic;
//using namespace HelloWorld;
using HelloWorld;

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

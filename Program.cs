using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using ClassLibrary1;
using Microsoft.VisualBasic.FileIO;
namespace ConsoleApp1
{
    internal class Program
    {


        #region related to demo 
        //    public static void Dosomecode()
        //{
        //   try
        //    {
        //        int x, y, z;
        //        x = int.Parse(Console.ReadLine()); /*FormatException because we we entered string*/
        //        y = int.Parse(Console.ReadLine());  /*Divided by zero Exception because we entered 0 and we cant divided by zero*/
        //        z = x / y;

        //        Console.WriteLine(z);
        //        int[] numbers = { 1, 2, 3 };
        //        numbers[10] = 100; /*indexout of range Exception \\ because we entered non valid index in our array */
        //    } 
        //    catch (Exception e)  // => handle all exceptions possible 
        //    // well catch the formatexception or any one  and print the message 
        //    // clr create object from Exception 
        //    {
        //        Console.WriteLine(e.Message);
        //        // log in 
        //        // Store DB
        //    }
        //}
        //    public static void DosomecodeProtective()
        // {
        //    int x, y, z;
        //    bool flag;
        //    do
        //    {
        //        Console.WriteLine("Enter first number");
        //        flag = int.TryParse(Console.ReadLine(), out x);
        //    } while (!flag);

        //    do
        //    {
        //        Console.WriteLine("Enter seconde number");
        //        flag = int.TryParse(Console.ReadLine(), out y);
        //    } while (!flag || y == 0);

        //    z = x / y;

        //    Console.WriteLine(z);


        //    int[] numbers = { 1, 2, 3 };
        //    if (numbers.Length > 10)
        //    {
        //        numbers[10] = 100; 
        //    }
        //    numbers[10] = 100; /*indexout of range Exception \\ because we entered non valid index in our array */

        //int[]? numbers = null;
        //if (numbers?.Length > 10)
        //{
        //    numbers[10] = 100;
        //}
        //numbers[10] = 100;


        /*******************************************/
        //enum Gender
        //{
        //    Male = 0, female = 1
        //}

        //enum Days
        //{
        //    saturday,
        //    sunday,
        //    monday,
        //    tuesday,
        //    wednesday,
        //    thursday,
        //    friday
        //}
        //enum Grades
        //{
        //    A, B, C, D, E, F
        //}

        //enum branches : byte // 0:255
        //{
        //    Nasr_city, maadii, alex, dokki
        //}

        //enum Roles
        //{
        //    Admin = 10, viewer, Editor = 11
        //}
        //[Flags]
        //enum permisions : byte
        //{
        //    Delete = 1, Execute = 2, Read = 4, Write = 8
        //}

        //class Employee
        //{
        //    public string name;
        //    public int age;
        //    public decimal salary;
        //    public Grades Gender; // male - female
        //                          // admin , viewer , editor 

        //    public permisions permisions;
        //}
        #endregion

        #region Q1 Q2 Q3 Q4 Q5
        enum Weekdays
        {
            monday, tuesday, wednesday, thursday, friday, saturday
        }

        enum Season
        {
            Spring, Summer, Autumn, Winter
        }

        [Flags]
        enum Permisions
        {
            nopermission = 0, read = 1, write = 2, delete = 4, execute = 8
        }

        enum colors
        {
            red, green, blue
        }
        struct Point
        {
            public float X { get; set; }
            public float Y { get; set; }

            public Point(float x, float y)
            {
                X = x;
                Y = y;
            }


        }

        #endregion

        static void Main(string[] args)
        {
            #region Demo oop
            #region Exception handling 

            // Exceptions : 
            // 1.System Exception 
            //      1.1 Format Exception 
            //      1.2 index out of Range Exception 
            //      1.3 Null References Exception
            //      1.4 invalid operation Exception 
            //      1.5 Arithmateic Exception
            //          1.5.1 Divided_By_Zero Exception
            //          1.5.2 Overflow Exception 
            // 2.Application Exception 
            //try
            //{
            //    DosomecodeProtective();
            //    throw new Exception();

            //}
            //catch (Exception Ex)
            //{
            //    Console.WriteLine(Ex.Message);
            //}
            //Console.WriteLine("After try catch ");

            //try
            //{
            //    DosomecodeProtective();
            //    throw new Exception();

            //}
            //catch (Exception Ex)
            //{
            //    Console.WriteLine(Ex.Message);
            //}
            //finally
            //{
            //    // close - free - delete - dealocate Unmanged Recources 
            //    // Open File 
            //    // Open Connection Database 
            //    Console.WriteLine("Finally");
            //}
            //Console.WriteLine("After try catch ");

            #endregion

            #region Access Modifier 

            //typeA typeA = new typeA();

            //typeA.x = 10; /* cant access unless its main scope */
            //typeA.y = 10;  /* cant access because its not in same project */ 
            //typeA.z = 10; /*it can access because its public*/




            #endregion

            #region Enums
            #region ex01
            // string day = "hamada" /*not true */
            //Days day = Days.friday; /* bahkmoh */

            //Grades grade = Grades.B ;
            //if (grade == Grades.A )
            //{
            //    Console.WriteLine("^_^");
            //}
            //else
            //{
            //    Console.WriteLine("0-0");
            //}


            #endregion
            #region ex02
            //Grades grade = (Grades)2; /*Explicit casting*/
            //Console.WriteLine(grade);

            // Grades grade = (Grades)10; /*Explicit casting*/
            //Console.WriteLine(grade); /*will print 10 because its not enum as 10 */

            #endregion
            #region ex03
            //Grades grade = (Grades)Enum.Parse(typeof(Grades), Console.ReadLine());
            //Enum.TryParse(typeof(Grades), Console.ReadLine(), out object Result);
            //Grades grade = (Grades)Result;
            //Console.WriteLine(Result);


            #endregion
            #region ex04
            //string gender = "male";
            //Enum.TryParse(typeof(Gender), gender , out object Result);
            //Console.WriteLine(Result);

            //Enum.TryParse<Gender>(gender, true, out Gender Result);




            #endregion
            #endregion

            #region Permissions 
            //     Employee employee = new Employee();
            //     employee.name="ali";
            //     employee.age = 20;
            //     employee.permisions = (permisions)7;


            // Console.WriteLine(employee.permisions);

            // // xor :
            //employee.permisions = employee.permisions ^ permisions.Read;
            // Console.WriteLine(employee.permisions); // delete , execute , read
            // employee.permisions = employee.permisions ^ permisions.Read; // he will remove it if we did it again 

            // // & [And] : 
            // if ((employee.permisions & permisions.Read)== permisions.Read)
            // {
            //     Console.WriteLine("read is exist");

            // }
            // else
            // {
            //     employee.permisions = employee.permisions ^ permisions.Read; 
            // }



            #endregion

            #region Struct
            //Point p01;
            ////p01.x = 10;
            ////p01.y = 20;
            ////Console.WriteLine(p01.x);//invalid you must assign avalue before
            ////Console.WriteLine(p01.y);//invalid you must assign avalue before
            ////use construcor to assign the values
            //p01 = new Point(2,7);
            ////Console.WriteLine(p01.x);
            ////Console.WriteLine(p01.y);
            //Console.WriteLine(p01.ToString());//Assignment6.Point,bestway
            //Console.WriteLine(p01);//boking and un boking
            //Point p02= new();
            #endregion

            #endregion

            #region Q1 
            //Weekdays weekdays = new Weekdays();

            //Console.WriteLine(weekdays);

            //foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Q2


            //Console.WriteLine("Enter your season ");

            //string input = Console.ReadLine();

            //if (Enum.TryParse<Season>( input , true , out Season result ))
            //{
            //    switch (result)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Unknown season.");
            //            break;
            //    }      
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered. Please enter one of: Spring, Summer, Autumn, Winter.");   
            //}



            #endregion

            #region Q3
            Permisions user_per = Permisions.nopermission;

            //user_per = Permisions.read;

            //Console.WriteLine(user_per);

            //user_per = user_per ^ Permisions.read;

            //Console.WriteLine(user_per);

            //if ((user_per & Permisions.read) == Permisions.read)
            //{
            //    Console.WriteLine("read is exist");

            //}
            //else
            //{
            //   user_per = user_per ^ Permisions.read;
            //    Console.WriteLine(user_per);
            //}



            #endregion

            #region Q4
            //  Console.WriteLine("Enter your color that you want to know about it if it is primary or not ! ");
            // string input = Console.ReadLine();



            //if (Enum.TryParse<colors>(input , true , out colors result))
            //{
            //    switch (result)
            //    {
            //        case colors.red:
            //            Console.WriteLine("red is primary");
            //            break;
            //        case colors.green:
            //            Console.WriteLine("green is primary");
            //            break;
            //        case colors.blue:
            //            Console.WriteLine("blue is primary ");
            //            break;

            //    }

            //}
            //else
            //{
            //    Console.WriteLine("not primary");
            //}

            #endregion

            #region Q5


            //try
            //{

            //    Console.WriteLine("Enter the coordinates of the first point (X1 Y1): ");
            //    string[] firstPointInput = Console.ReadLine().Split(' ');

            //    if (firstPointInput.Length != 2)
            //    {
            //        throw new FormatException("Invalid input for the first point. Please provide exactly two numbers.");
            //    }

            //    float x1 = float.Parse(firstPointInput[0]);
            //    float y1 = float.Parse(firstPointInput[1]);


            //    Console.WriteLine("Enter the coordinates of the second point (X2 Y2): ");
            //    string[] secondPointInput = Console.ReadLine().Split(' ');

            //    if (secondPointInput.Length != 2)
            //    {
            //        throw new FormatException("Invalid input for the second point. Please provide exactly two numbers.");
            //    }

            //    float x2 = float.Parse(secondPointInput[0]);
            //    float y2 = float.Parse(secondPointInput[1]);


            //    Point point1 = new Point(x1, y1);
            //    Point point2 = new Point(x2, y2);


            //    float distance = (float)Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            //    Console.WriteLine($"The distance between the points is: {distance}");
            //}
            //catch (Exception Ex)
            //{
            //    Console.WriteLine(Ex.Message);
            //}









            #endregion

        }



    }
}

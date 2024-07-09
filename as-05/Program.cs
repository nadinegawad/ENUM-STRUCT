using static as_05.Program;

namespace as_05
{
   
    internal class Program
    {
        #region Q01
        //Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            sunday
        }
        #endregion

        #region Q02
        //Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members

        public enum Season
        {
            Spring=1,
            Summer,
            Autumn,
            Winter
        }
        #endregion

        #region Q03
        // Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
        [Flags]        
        public enum Permissions
        {
            Read = 1,
            Write =2,
            Delete=4,
            Execute=8

        }

        public class Employees
        {
           public string name;
           public Permissions permissions;
        }
        #endregion

        #region Q04
        // Create an enum called "Colors" with the basic colors(Red, Green, Blue) as its members
        public enum Colors
        {
            Red=1,
            Blue,
            Green
        }
        #endregion

        #region Q05
        //Create a struct called "Point" to represent a 2D point with properties "X" and "Y"
        public struct Point
        {
            public int x;
            public int y;
            public Point()
            {
                x = 0;
                y = 0;
            }
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
                

            }
            public int Distance()
            {
                int z = this.x - this.y;
                return z;
            }

           
        }
        #endregion

        static void Main(string[] args)
        {

            //Q01
            //for(int i =0;i < 7; i++)
            //{
            //    WeekDays WD = (WeekDays)i;
            //    Console.WriteLine( WD );

            //}

            //==================================================

            //Q02
            //Console.WriteLine("ENTER THE SEASON NAME :");
            //bool flag = Enum.TryParse<Season>(Console.ReadLine(), true, out Season result);

            // switch ((int)result)
            // {
            //     case 1:
            //         Console.WriteLine("the corresponding month range : march to may");
            //         break;
            //     case 2:
            //         Console.WriteLine("the corresponding month range : june to august ");
            //         break;
            //     case 3:
            //         Console.WriteLine("the corresponding month range : September to November");
            //         break;
            //     case 4:
            //         Console.WriteLine("the corresponding month range : December to February");
            //         break;

            //     default:
            //         Console.WriteLine("wrong name");
            //         break;



            //}
            //Point P1 = new Point(10,3);
            //Console.WriteLine(P1);


            //==================================================

            //Q03
            //Employees e = new Employees();
            //e.permissions = (Permissions)7;
            //Console.WriteLine(e.permissions);
            //e.permissions = e.permissions ^ Permissions.Read;
            //Console.WriteLine(e.permissions);

            //==================================================

            //Q04
            //Console.WriteLine("ENTER THE COLOR NAME :");
            //bool flag = Enum.TryParse<Colors>(Console.ReadLine(), true, out Colors result);
            // switch ((int)result)
            // {
            //     case 1:
            //     case 2:
            //     case 3:
            //      Console.WriteLine("color is a primary color");
            //      break;
            //     default:
            //     Console.WriteLine("color is not a primary color");
            //      break;
            // }
            //==================================================
            //Q05
            //Console.WriteLine("ENTER FIRST NUMBER : ");
            //int.TryParse(Console.ReadLine(), out int num1);
            //Console.WriteLine("ENTER SECOND NUMBER : ");
            //int.TryParse(Console.ReadLine(), out int num2);
            //Point p1 = new Point(num1, num2);
            //Console.WriteLine( p1.Distance());

        }

    }
    }


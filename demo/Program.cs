namespace demo
{
    internal class Program
    {

        #region expetion handling
        static void DoSomeProtectiveCode()
        {
            int x, y, z;
            bool flag;
            do
            {
                Console.WriteLine("ENTER FIRST NUMBER : ");
                flag = int.TryParse(Console.ReadLine(), out x);
            } while (!flag);
            do
            {
                Console.WriteLine("ENTER SECOND NUMBER : ");
                flag = int.TryParse(Console.ReadLine(), out y);
            } while (!flag || y == 0);

            z = x / y;

            int[] number = { 1, 2, 3, };
            if (number.Length > 10)
            {
                number[10] = 100;
            }
        }
        #endregion



        public enum Days
        {
            Monday,
            Tuesday,    
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public enum Grades :int
        {
            A,B,C,D,E
        }

        public enum Gender : int
        {
            Male , female
        }

        public enum Roles
        {
            Admin = 10,
            Editor = 20,
            Viewer = 30
        }

        public enum Permissions
        {
            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8

        }

        public struct test
        {

            public int x;
            public int y;
            public test()
            {
                x = 0;
                y = 0;
            }

            public test(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public override string ToString()
            {
                return $"{x}  , {y}";
            }
        }
        static void Main(string[] args)
        {
       
       
        
            //try
            //{
            //    DoSomeProtectiveCode();

            //}
            //catch(Exception ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("finally");
            //}


            //Grades x = Grades.A;
            //Console.WriteLine(x);

            //bool result = Enum.TryParse(typeof(Grades), Console.ReadLine(), out object y);
            //Console.WriteLine(y);


            //bool flag = Enum.TryParse<Gender>(Console.ReadLine(),true , out Gender gender);
            //Console.WriteLine(gender);

            //Employees e = new Employees();
            //e.permissions = (Permissions)7;
            //Console.WriteLine(e.permissions);
            //e.permissions = e.permissions ^ Permissions.Read;
            //Console.WriteLine(e.permissions);

            //test test = new test(5,3);
            //Console.WriteLine(test.ToString());
            //Console.WriteLine(test);
        }
    }
}

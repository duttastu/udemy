namespace _2darray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare 2d array

            string[,] matrix;

            //3d array

            int[,,] array;

            //initializing 2d array

            int[,] array2d = new int[,]
            {
                { 1, 2, 3 },   //row 0
                { 4, 5, 6 },   //row 1

                { 7, 8, 9 }   //row 2
            };
            Console.WriteLine("central value is {0}", array2d[1, 1]);
            Console.WriteLine("central value is {0}", array2d[2, 0]);


            ///3d Initialization

            string[,,] array3d = new string[,,]
            {
                {
                    {"000","001" },
                    {"100","1101"}
                },
                {
                    {"110","111" },
                    { "220","221"}
                }
            };

            string[,] array2dString = new string[3, 2]
            {
                { "one","two"},
                {"three","four"},
                {"five","six"}
            };

            array2dString[1, 1] = "chicken";
            int dimension = array2dString.Rank;
            Console.WriteLine("the dimension is {0}" ,dimension);
            Console.WriteLine("the value is {0}", array2dString[1, 1]);
            /*  Console.WriteLine("The value is {0}", array3d[1, 1,0]);
              Console.WriteLine("the value is {0}", array3d[0,0, 0]);
  */
            Console.ReadKey();

        }
    }
}

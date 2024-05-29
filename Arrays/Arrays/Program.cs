namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare and initialize array grades
             

            int[] grades=new int[4];

            grades[0] = 12;
            grades[1] = 10; 
            grades[2] = 2; 
            grades[3] = 1;

            Console.WriteLine("grades at index 0 : {0} ", grades[0]);

            string input= Console.ReadLine();
            //assign values to array grades at index 0
            grades[0]=int.Parse(input);
            Console.WriteLine("grades at index 0 : {0} ", grades[0]);
            Console.ReadKey();

            //2nd way of declaring arrays

            int[] gradesOfStudentsA = {23,45,11,34,24};

            //third way og declaring array

            int[] gradesOfStudentsB = new int[] {23,55,67,24,66,88};

            Console.WriteLine("length of gradesOfStudentsA: {0}", gradesOfStudentsA.Length);
            Console.ReadKey();

        }
    }
}

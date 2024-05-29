namespace arrayforeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
            }
            *//*for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Element{0} = {1}", j, nums[j]);
            }*//*
            int counter = 0;
            foreach(int k in nums)
            {
                Console.WriteLine("Element {0} = {1}", counter++ , k);
            }
            Console.ReadKey();*/



            ///create an array with 5 of your best friends
            /// create a foreach loop which greets all of them


            string[] myFriends = { "abc", "def", "ghi", "jkl", "mno" };
            foreach (string s in myFriends)
            {
                Console.WriteLine("Hi there {0}, my friend ", s);
            }
             
            Console.ReadKey();



        }
    }
}

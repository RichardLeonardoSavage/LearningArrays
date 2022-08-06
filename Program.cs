namespace LearningArrays
{
    class Program
    {
        static void Main(string[] args)
        {


            //this array size is undefined but values have been assigned to the array - remember, arrays can hold many items and acts as a library of variables. 

            //Rememeber, c# counts starting from ZERO
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };


            //arrays can have size assigned to them, and values added to the internal Id's of the array
            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "Mike";
            friends[2] = "Richard";
            friends[3] = "Simon";
            friends[4] = "John";

            Console.WriteLine(luckyNumbers[1]);

            Console.ReadLine();

        }
    }
}
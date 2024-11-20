namespace Assignment_3_2_5
{
    internal class Program
    {
        static void Main(string[] args)

        //Ask the user to input their array
        //Then convert that string of data into an array of strings using the String.Split method.
        //The space between words is used as criteria.
        //Then create an array of integers from the string array using the ConvertAll method. 

        {
            Console.WriteLine("Enter the elements of your array separated by a space");
            string userInputElements = Console.ReadLine();
            string[] inputStringArray = userInputElements.Split(" "); //Using Split String Method
            int[] userIntArray = Array.ConvertAll(inputStringArray, int.Parse); //Using Array Convert All Method to go from an array of strings to an array of integers

            Console.WriteLine("\nWhat element do you want to index?");
            int numberToIndex = int.Parse(Console.ReadLine());

            int index = FindIndex(userIntArray, numberToIndex); //Declare "index" as a variable and use the FindIndex method. 

            if (index != -1)
            {
                Console.WriteLine($"\nThe number is at index: {index}");
            }

            else
            {
                Console.WriteLine($"\nThe number {numberToIndex} does not exist in your array.");
            }
        }

        static int FindIndex(int[] array, int item) //FindIndex Method
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item)
                {
                    return i;
                }

            }
            return -1;

        }
    }
}

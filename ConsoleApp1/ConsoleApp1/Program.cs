namespace ConsoleApp1
{

    public class ArrayHelper
    {
        public static void Add(ref string[] arr, string input)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = input;
        }

        public static void Remove(ref string[] arr, string input)
        {
            int removingIndex = Array.IndexOf(arr, input);
            if (removingIndex >= 0)
            {
                for (int i = removingIndex; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                Array.Resize(ref arr, arr.Length - 1);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayHelper = new string[0];
            string input1 = "This";
            string input2 = "is";
            string input3 = "new";
            string input4 = "input";

            ArrayHelper.Add(ref arrayHelper, input1);
            ArrayHelper.Add(ref arrayHelper, input2);
            ArrayHelper.Add(ref arrayHelper, input3);
            ArrayHelper.Add(ref arrayHelper, input4);

            foreach (string input in arrayHelper)
            {
                Console.WriteLine(input);
            }


            ArrayHelper.Remove(ref arrayHelper, input1);

            foreach (string input in arrayHelper)
            {
                Console.WriteLine(input);
            }

        }
    }
}
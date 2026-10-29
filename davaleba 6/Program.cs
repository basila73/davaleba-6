namespace davaleba_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[] numbers = { 2, 4, 6, 8 };

            //int Sum(int[] arr)
            //{
            //    int sum = 0;

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        sum = sum + arr[i];
            //    }

            //    return sum;
            //}

            //Console.WriteLine(Sum(numbers));



            //{
            //    void JoinText(string text1, string text2, string text3)
            //    {
            //        Console.WriteLine(text1 + " " + text2 + " " + text3);
            //    }

            //    JoinText("Hello", "My", "Friend");
            //}


            string[] words = { "Hello", "My", "Friend" };

            Console.WriteLine(Text(words));
        }

        static string Text(string[] arr)
        {
            string text = "";

            for (int i = 0; i < arr.Length; i++)
            {
                text = text + arr[i] + " ";
            }

            return text;
        }

    }
}


            
          

        

  
   


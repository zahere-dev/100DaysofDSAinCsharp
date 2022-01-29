namespace _100DaysofDSAinCsharp.src.Day15
{
    public class RecursionBasics
    {

        public static void GetSquaresIterative(int n)
        {
            while (n > 0)
            {
                System.Console.WriteLine(n * n);
                n--;
            }

        }

        public static void GetSquaresRecursive(int n)
        {
            if (n > 0)
            {
                System.Console.WriteLine(n * n);
                n--;

                GetSquaresRecursive(n);
            }
        }


    }
}

namespace _100DaysofDSAinCsharp.src.Day19
{
    public class NthFibonacci
    {
        public static int Run(int n)
        {
            if (n == 2) return 1;
            else if (n == 1) return 0;
            else return Run(n - 1) + Run(n - 2);
        }
    }
}

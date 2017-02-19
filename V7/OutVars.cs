namespace CsharpFeatures.V7
{
    public class OutVars
    {
        public void GetCoords(out int x, out int y)
        {
            x = 1;
            y = 1;
        }
        public void Usage()
        {
            if (int.TryParse("1337", out int n))
            {
                System.Console.WriteLine(n);
            }

            n = 0;

            // Note: It is still uncertain whether wildcards make it into C# 7.0.
            // GetCoords(out int x, out *);
        }
    }
}
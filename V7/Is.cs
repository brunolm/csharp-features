namespace CsharpFeatures.V7
{
    public class IsTest
    {
        public void Usage()
        {
            object o = 1;

            if (o is int i)
            {
                System.Console.WriteLine($"Object is int, value: {i}");
            }
        }
    }
}
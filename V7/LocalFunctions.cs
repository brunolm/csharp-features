// https://github.com/dotnet/roslyn/blob/master/docs/features/local-functions.md
namespace CsharpFeatures.V7
{
    public class LocalFunctionsTest
    {
        public void Usage()
        {
            int fib()
            {
                return 1;
            }

            int x = fib();
        }
    }
}

// https://github.com/dotnet/roslyn/issues/215
namespace CsharpFeatures.V7
{
    public class BinaryLiterals
    {
        public void Usage()
        {
            var bin = 0b1010;
            System.Console.WriteLine(bin);
        }
    }
}

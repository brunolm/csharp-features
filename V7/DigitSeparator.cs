// https://github.com/dotnet/roslyn/issues/216
namespace CsharpFeatures.V7
{
    public class DigitSeparator
    {
        public void Usage()
        {
            var bin = 0b00001010_10010011;
            var num = 8_000_000_000;
            var hex = 0xAB_CD_EF;

            System.Console.WriteLine(bin);
            System.Console.WriteLine(num);
            System.Console.WriteLine(hex);
        }
    }
}

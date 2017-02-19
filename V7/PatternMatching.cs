// https://github.com/dotnet/roslyn/blob/master/docs/features/patterns.md
namespace CsharpFeatures.V7
{
    interface IShape
    {
        int Length { get; }
    }
    class Circle : IShape
    {
        public int Length => 1;
    }
    class Square : IShape
    {
        public int Length => 1;
    }

    public class PatternMatching
    {
        public void Is()
        {
            object o = 1;

            if (o is int i)
            {
                System.Console.WriteLine($"Object is int, value: {i}");
            }
        }

        public void Switch()
        {
            IShape shape = new Square();

            switch (shape)
            {
                case Circle c when (c.Length == 5):
                    break;
                case Circle c:
                    break;
                case Square s:
                    break;
                default:
                    break;
                case null: // special case, does not fall in default
                    break;
            }
        }
    }
}

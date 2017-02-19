using System;

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

    public class SwitchTest
    {
        public void Usage()
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
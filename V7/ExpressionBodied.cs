// https://github.com/dotnet/roslyn/issues/7881
namespace CsharpFeatures.V7
{
    using System.Collections.Generic;

    class Person
    {
        private IList<string> names = new List<string>();

        public Person(string name) => names.Add(name);
        ~Person() => names.Clear();

        public int Total
        {
            get => names.Count;
        }
    }
}

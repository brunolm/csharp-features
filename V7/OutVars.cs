namespace CsharpFeatures.V7
{
    public class OutVars
    {
        public void GetCoords(out int x, out int y, out int z)
        {
            x = 1;
            y = 1;
            z = 1;
        }
        public void Usage()
        {
            if (int.TryParse("1337", out int n))
            {
                System.Console.WriteLine(n);
            }

            n = 0;

            // https://github.com/dotnet/roslyn/blob/master/docs/features/outvar.md
            int.TryParse("1337", out var declareHere);

            // https://github.com/dotnet/roslyn/blob/master/docs/features/discards.md
            // https://github.com/dotnet/roslyn/blob/master/docs/features/wildcards.work.md
            GetCoords(out int x, out _, out _);
        }
    }
}

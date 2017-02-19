namespace CsharpFeatures.V7
{
    // Core:  dotnet add package System.ValueTuple
    // Nuget: Install-Package "System.ValueTuple" -IncludePrerelease

    public class TupleTest
    {
        public (int, int) GetCoords()
        {
            return (1, 2);
        }

        public (int x, int y) GetCoordsNamed()
        {
            return (1, 2);
        }

        public void Usage()
        {
            var (x, y) = GetCoords();

            (var w, var z) = GetCoords();

            var all = GetCoords();
            var r1 = all.Item1 + all.Item2;

            var obj = GetCoordsNamed();
            var r2 = obj.x + obj.y;
        }
    }
}
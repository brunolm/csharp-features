namespace CsharpFeatures.V7
{
    using System;

    public class Exceptions
    {
        public void CatchWhen()
        {
            try
            {
                throw new Exception("Catch Me!");
            }
            catch (Exception ex) when (ex.Message.EndsWith("!"))
            {
            }
        }

        public void ThrowInline()
        {
            // https://github.com/dotnet/roslyn/blob/master/docs/features/throwexpr.md
            var x = true ? throw new ArgumentNullException() : false;
        }
    }
}

namespace CsharpFeatures.V7
{
    using System;

    public class ExceptionsTest
    {
        public void Usage()
        {
            try
            {
                throw new Exception("Catch Me!");
            }
            catch (Exception ex) when (ex.Message.EndsWith("!"))
            {
            }
        }
    }
}

namespace CsharpFeatures.V7
{
    public class RefTest
    {
        public void Usage()
        {
            int[] arr = { 5, 4, 3, 2, 1 };

            ref int Find(int n)
            {
                for (int i = 0; i < arr.Length; ++i)
                {
                    if (arr[i] == n)
                    {
                        return ref arr[i];
                    }
                }

                throw new System.Exception();
            }

            ref int pos = ref Find(5);
            pos = 100;

            System.Console.WriteLine(arr); // { 100, 4, 3, 2, 1 };
        }
    }
}
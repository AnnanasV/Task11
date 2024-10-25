using Attributes;

namespace Task11
{
    internal class SampleClass
    {
        [Documentation("Anna", Version = 1)]
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }

        [Documentation("Anna", "Second version of this method", Version = 2)]
        public void Method2()
        {
            Console.WriteLine("Method 2");
        }

        public void Method3()
        {
            Console.WriteLine("Method 3");
        }
    }
}

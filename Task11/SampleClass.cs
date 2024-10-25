using Attributes;

namespace Task11
{
    internal class SampleClass
    {
        [Documentation("Anna", Version = 1)]
        public void Method1() { }

        [Documentation("Pavel", "Second version of this method", Version = 2)]
        public void Method2() { }

        [Documentation("Liza", Version = 1)]
        public void Method3() { }
    }
}

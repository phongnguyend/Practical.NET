/// <summary>
/// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#using-declarations
/// </summary>

using System;

namespace UsingDeclarations
{
    class A : IDisposable
    {

        public B GetB()
        {
            return new B();
        }

        public void Dispose()
        {

        }
    }

    class B : IDisposable
    {
        public C GetC()
        {
            return new C();
        }

        public void Dispose()
        {

        }
    }

    class C : IDisposable
    {
        public void DoWork()
        { }

        public void Dispose()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CSharp7();
            CSharp8();
        }

        static void CSharp7()
        {
            using (var a = new A())
            {
                using (var b = a.GetB())
                {
                    using (var c = b.GetC())
                    {
                        c.DoWork();
                    }
                }
            }
        }

        static void CSharp8()
        {
            using var a = new A();
            using var b = a.GetB();
            using var c = b.GetC();
            c.DoWork();
        }
    }
}

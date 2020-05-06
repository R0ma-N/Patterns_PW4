using System;

namespace Singleton
{
    class ThreadSafeSingleton
    {
        private ThreadSafeSingleton()
        {
            Console.WriteLine("Create ThreadSafeSingleton");
        }

        public static ThreadSafeSingleton Instance
        {
            get => Nested.instance;
        }

        private class Nested
        {
            static Nested() { }

            internal static readonly ThreadSafeSingleton instance = new ThreadSafeSingleton();
        }
    }
}

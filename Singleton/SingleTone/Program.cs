using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Thread(() =>
            {
                SingletonClass instanceOne = SingletonClass.Instance;
            })).Start();
            SingletonClass instanceTwo = SingletonClass.Instance;

            (new Thread(() =>
            {
                ThreadSafeSingleton instanceSafeOne = ThreadSafeSingleton.Instance;
            })).Start();
            ThreadSafeSingleton instanceSafeTwo = ThreadSafeSingleton.Instance;

            (new Thread(() =>
            {
                ThreadSafeLazySingleton instanceSafeLazyOne = ThreadSafeLazySingleton.Instance;
            })).Start();
            ThreadSafeLazySingleton instanceSafeLazyTwo = ThreadSafeLazySingleton.Instance;

            (new Thread(() =>
            {
                ThreadSafeLockSingleton instanceSafeLockOne = ThreadSafeLockSingleton.Instance;
            })).Start();
            ThreadSafeLockSingleton instanceSafeLockTwo = ThreadSafeLockSingleton.Instance;
            Console.ReadKey();
        }
    }
}
using System;
using System.Threading;

namespace Singleton
{
    class ThreadSafeLazySingleton
    {
        private static readonly Lazy<ThreadSafeLazySingleton> _instance = new Lazy<ThreadSafeLazySingleton>(() => new ThreadSafeLazySingleton(), 
            LazyThreadSafetyMode.ExecutionAndPublication);

        private ThreadSafeLazySingleton()
        {
            Console.WriteLine("Create ThreadSafeLazySingleton");
        }

        public static ThreadSafeLazySingleton Instance
        {
            get => _instance.Value;
        }
    }
}

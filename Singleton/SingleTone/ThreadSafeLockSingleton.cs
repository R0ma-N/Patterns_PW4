using System;

namespace Singleton
{
    class ThreadSafeLockSingleton
    {
        private static ThreadSafeLockSingleton _instance;
        private static object syncObject = new Object();

        private ThreadSafeLockSingleton()
        {
            Console.WriteLine("Create ThreadSafeLockSingleton");
        }

        public static ThreadSafeLockSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncObject)
                    {
                        if (_instance == null)
                            _instance = new ThreadSafeLockSingleton();
                    }
                }
                return _instance;
            }
        }
    }
}

using System;

namespace Singleton
{
    class SingletonClass
    {
        private static SingletonClass _instance;

        private SingletonClass()
        {
            Console.WriteLine("Create Singleton");
        }

        public static SingletonClass Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SingletonClass();
                }
                return _instance;
            }
        }
    }
}

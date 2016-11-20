using System;

namespace SingletonTutorial
{
    public class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        private Singleton()
        {
            //Stuff that must happen only once
            Console.WriteLine("In Singleton Constructor");
        }

        public static Singleton Instance { get { return instance; } }

        public static void SayHi()
        {
            // This must be thread-safe
            Console.WriteLine("Hi there!");
        }

        public void DoSomething()
        {
            // This must be thread-safe
        }
    }
}

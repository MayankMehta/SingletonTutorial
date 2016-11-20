using NUnit.Framework;
using NUnit.Framework.Internal;
using System;

namespace SingletonTutorial
{
    [TestFixture]
    public class SingletonClient
    {
        [Test]
        public void UseSingleton()
        {
            Singleton.SayHi();
            Console.WriteLine("Start of test");
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;
            Assert.AreSame(s1, s2);
        }
    }
}

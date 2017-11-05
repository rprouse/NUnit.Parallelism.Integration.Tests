using System;
using System.Threading;

namespace Parallel.Children
{
    public class Animal
    {
        public Animal()
        {
            Console.Write("Init. Thread #" + Thread.CurrentThread.ManagedThreadId + " ");
            Thread.Sleep(1000);
        }

        public void Do()
        {
            Console.WriteLine("Done. Thread #" + Thread.CurrentThread.ManagedThreadId + " for " + ToString());
        }
    }

    public class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine("I'm a cat");
        }

        public override string ToString()
        {
            return "cat";
        }
    }

    public class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("I'm a dog");
        }

        public override string ToString()
        {
            return "dog";
        }
    }

    public class Base
    {
        public static readonly ThreadLocal<Animal> ThreadLocalContext = new ThreadLocal<Animal>();
    }
}

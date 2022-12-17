using System;

namespace FirstClass_20221217
{
    public class Dog
    {
        public virtual void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }

    public class Pudle : Dog
    {
        public override void Bark()
        {
            Console.WriteLine("왈왈");
        }
    }

    internal static class Program
    {
        static void Main()
        {
            Pudle pd = new Pudle();
            pd.Bark();

            Dog dog = new Dog();
            dog.Bark();

            dog = new Pudle();
            dog.Bark();
        }
    }
}
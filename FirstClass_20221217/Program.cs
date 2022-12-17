namespace FirstClass_20221217 // project name 
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog a = new Dog();
        }
    }

    partial class Dog
    {
        public Dog()
        {
            eyes = 0;
            nose = 0;
            mouth = 0;
            ears = 0;
        }

        private int eyes, nose, mouth, ears;
    }

    partial class Dog
    {
        public void Bark()
        {
        }
    }
}
using System;

namespace FirstClass_20221217
{
    public class Zerg
    {
        public void Overload(int zerggling)
        {
            Console.WriteLine($"저글링 {zerggling}마리");
        }

        public void Overload(int zerggling, int hydra)
        {
            Console.WriteLine($"저글링 {zerggling}마리 + 히드라 {hydra}마리");
        }

        public void Overload(int zerggling, int hydra, int lurker)
        {
            Console.WriteLine($"저글링 {zerggling}마리 + 히드라 {hydra}마리 + 럴커 {lurker}마리");
        }

        public void Overload(char zerggling)
        {
            Console.WriteLine($"Zerggling {zerggling} 등급");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Zerg zerg = new Zerg();
            zerg.Overload(10);
            zerg.Overload(10, 20);
            zerg.Overload(10, 20, 30);
            zerg.Overload('A');
        }
    }
}
using System;

namespace SealedClass_20221219
{
    class FolderPhone
    {
        public virtual void Network()
        {
            Console.WriteLine("위피");
        }
    }

    class ThreeGPhone : FolderPhone
    {
        public sealed override void Network()
        {
            Console.WriteLine("와이브로");
        }
    }

    class SmartPhone : ThreeGPhone
    {
        public new void Network() // override로는 오류발생. 부모메서드가 sealed이므로.
        {
            Console.WriteLine("와이파이");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FolderPhone fp = new FolderPhone();
            ThreeGPhone tp = new ThreeGPhone();
            SmartPhone sp = new SmartPhone();
            fp.Network();
            tp.Network();
            sp.Network();
        }
    }
}
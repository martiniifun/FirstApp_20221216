// abstract class & method와 Interface의 차이?
// interface는 클래스가 아니다. 명세일 뿐.
// 대신 자식 클래스 누군가가 인터페이스를 상속받는다.
//
// 그럼, 추상클래스와 인터페이스의 차이가 있나?
//
// 공통점은?
// 1. 본체가 없고 이름만 있다?
// 2. 둘 다 객체를 생성할 수 없다. 상속에 의해서 클래스가 만들어진 후 인스턴스 생성.
//
// 차이점은?
// 1. 추상 클래스는 일부 추상메서드를 가질 수 있고, 일반 메서드도 가질 수 있다.
//    인터페이스는 전부 추상메서드만 갖는다. 인터페이스는 내부의 명세 전부를 구현해야 한다.
// 2. C#의 클래스는 다중 상속이 되지 않는다. 인터페이스는 다른 인터페이스를 다중상속할 수 있다.
//
// 정리하면, 목적의 차이가 뚜렷하다.
//
// 추상클래스는 추상적이지만 공통적인 기능을 만드는 목적이며, 기본개념의 확장을 위해 사용된다.
// 그래서 추상클래스를 상속한 클래스는 메서드를 조금 더 구체화한다.
//
// 그런데 인터페이스는,
// 추가나 수정이 아니라, 새롭게 구현한다.
// 기능 명세를 구현하도록 하는 목적이다. 
//
// 추상 클래스는 구체적으로 어떤 경우에 사용할까?
// 기본적인 부모자식간 상속관계에서 부모의 기능을 물려받아서 기능을 추가하거나 수정할 때 사용한다.
// 예를 들면 스마트폰 클래스에서
// 전화, 문자 및 와이파이 기능은 구현되어 있다.
// 단지, 멀티미디어와 블루투스 기능은 추상 메서드로만 선언해 놓는다.
// 그러면 자식 클래스는 멀티미디어 및 블루투스 기능을 반드시 구현해야만 한다. 자신들 방식으로.
//
// 인터페이스는 "공통적인 기능의 명세"라고 하였다.
// 통화, 문자, 와이파이, 멀티미디어, 블루투스 기능을 그냥 이름만 나열해놓는다.
// 자식 클래스는 이를 상속해서
// 명세에 나열된 기능들을 모두 구현해야 한다.


using System;

namespace Interface_20221219
{
    public interface IUnit
    {
        void Attack();
        void Move();
    }

    public class Zergling : IUnit
    {
        public void Attack()
        {
            Console.WriteLine("저글링 : 공격한다.");
        }

        public void Move()
        {
            Console.WriteLine("저글링 : 이동한다.");
        }
    }

    public class Dragoon : IUnit
    {
        public void Attack()
        {
            Console.WriteLine("드라군 : 공격한다.");
        }

        public void Move()
        {
            Console.WriteLine("드라군 : 이동한다.");
        }
    }

    class Program
    {
        static void Main()
        {
            Dragoon d = new Dragoon();
            d.Attack();
            d.Move();

            Zergling z = new Zergling();
            z.Attack();
            z.Move();
        }
        
    }
}
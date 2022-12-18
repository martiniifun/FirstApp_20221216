using System;

namespace AbstractClass_20221219 // SmartPhone이라는 이름의 추상 클래스를 선언.
{
    abstract class SmartPhone
    {
        public abstract void Camera(); // 추상 메서드 선언.
        public abstract void CallPhone();
        public abstract void Network();
    }

    class ACompany : SmartPhone
    {
        public override void Camera()
        {
            Console.WriteLine("A회사 카메라 기능");
        }

        public override void CallPhone()
        {
            Console.WriteLine("A회사 전화 걸기 기능");
        }

        public override void Network()
        {
            Console.WriteLine("A회사 네트워크 연결 기능");
        }
    }

    class BCompany : SmartPhone
    {
        public override void Camera()
        {
            Console.WriteLine("B회사 카메라 기능");
        }

        public override void CallPhone()
        {
            Console.WriteLine("B회사 전화 걸기 기능");
        }

        public override void Network()
        {
            Console.WriteLine("B회사 네트워크 연결 기능");
        }
    }

    internal static class Program
    {
        static void Main(string[] args)
        {
            SmartPhone com = new ACompany();
            com.Camera();
            com.CallPhone();
            com.Network();

            com = new BCompany(); // com 인스턴스 재정의(클래스 지정할 필요 없음)
            com.Camera();
            com.CallPhone();
            com.Network();
            
        }
    }
}
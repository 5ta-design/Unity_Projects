namespace _0512_CSharp
{
    internal class Program
    {
        class configuration
        {
            private readonly int min;
            private readonly int max;
            public configuration(int min, int max)
            {
                this.min = min;
                this.max = max;
            }
            public void changeMax(int newMax)
            {
               // max = newMax; 
            }

            internal class Program
            {
                static void Main(string[] args) 
                {
                    configuration c=new cofiguration(1.10)
                }
        }

        //읽기 전용 필드 : readonly 클래스나 구조체의 멤버로만 존재할수 있다. 생성자안에서 한번 값을 지정하면 그 이후로 값을 변경할수 없다
        //const double PI=301415d;  컴파일러가 컴파일 할떄 상수가 된다.
        static void Main(string[] args)
        {
            const int MAX = 100;
            
    }
}

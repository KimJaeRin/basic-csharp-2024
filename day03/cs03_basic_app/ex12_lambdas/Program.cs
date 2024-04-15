namespace ex12_lambdas
{
    delegate int Calculate(int a, int b); // 대리자의 정수값 두개 받아서 정수값을 리턴해주는 함수들은 내가 대신 실행시켜줄게, 람다식 == "=>"을 사용
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("익명 메서드");

            Calculate calc;
            calc = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine($"계산결과 = {calc(10, 4)}");

            // 람다식을 쓰면 훨씬 짧게 코딩가능
            Calculate calc2 = (int a, int b) =>{ return a + b; };
            Calculate calc3 = (int a, int b) => a + b;
            Calculate calc4 = (a, b) => a + b;

            Console.WriteLine($"계산결과 = {calc2(10, 4)}");
            Console.WriteLine($"계산결과 = {calc3(10, 4)}");
            Console.WriteLine($"계산결과 = {calc4(10, 4)}");

            Calculate calc5 = (a, b) =>
            {
                Console.WriteLine("이런식으로 뺄셈이 됩니다.");
                var minus = a - b;
                return minus;
            };
            Console.WriteLine($"계산결과 = {calc5(10, 4)}");

            // Func, Action 빌트인 대리자 사용
            // Func는 리턴값이 있기 때문에 <int>는 리턴값이 int란 뜻
            // <int, int>는 매개변수 하나 리턴 하나
            Func<int> func1 = () => 10;
            Console.WriteLine($"Func1 = {func1()}");
            Func<int, int> func2 = (x) => x * 2;
            Console.WriteLine($"Func2 = {func2(1)}");
            Func<int, int, double> func3 = (x, y) =>(double) x / y;



        }
    }
}

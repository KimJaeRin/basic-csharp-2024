﻿// 파이썬용 라이브러리 사용등록
using IronPython.Hosting;

namespace ex15_pythons
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("파이썬 실행예제");

            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();
            var paths = engine.GetSearchPaths();

            // Python 경로설정 @== 리소스 키워드로 추가한다는 뜻
 
            paths.Add(@"C:\DEV\Langs\Python311"); // 기본 파이썬 경로
            paths.Add(@"C:\DEV\Langs\Python311\DLLS");
            paths.Add(@"C:\DEV\Langs\Python311\DLLS\Lib");
            paths.Add(@"C:\DEV\Langs\Python311\Lib\site-packages");
            paths.Add(@"C:\Users\user\AppData\Roaming\Python\Python311\site-packages");
            paths.Add(@"C:\Users\user\AppData\Roaming\Python\Python311\site-packages\win32");
            paths.Add(@"C:\Users\user\AppData\Roaming\Python\Python311\site-packages\win32\lib");

            // 실행시킬 Python 파일경로 설정

            var source = engine.CreateScriptSourceFromFile(@"C:\Sources\basic-csharp-2024\day03\cs03_basic_app\ex15_pythons\test.py");

            // Python 실행
            source.Execute(scope);

            var PythonFunc = scope.GetVariable<Func<int, int, int>>("sum");
            var result = PythonFunc(10, 7);
            Console.WriteLine($"Python 함수실행 = {result}");

            var PythonGreeting = scope.GetVariable<Func<string>>("sayGreeting");
            var greeting = PythonGreeting();
            Console.WriteLine($"결과 = {greeting}");

        }
    }
}
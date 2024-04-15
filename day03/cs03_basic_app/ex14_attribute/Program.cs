using System.Reflection;

namespace ex14_attribute
{
    class MyClass
    {
        [Obsolete("이 메서드는 다음버전에서 폐기됩니다. NewMethod()를 사용하세요")] // , true을 적으면 OldMethod 아예 사용불가
        ///<summary>
        /// 올드메서드. 이렇게 쓰세요
        /// </summary>
        
        public void OldMethod() // 최초제작 메서드
        {
            Console.WriteLine("Old Method");
        }

        ///<summary>
        /// 뉴메서드. 이거 쓰세요
        /// </summary>

        public void NewMethod() // 개선된 메서드
        {
            Console.WriteLine("New Method");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("리플렉션");

            int a = int.MaxValue;
            Type type = a.GetType();
            Console.WriteLine(type.FullName); // System.Int32

            float f = float.MaxValue;
            Console.WriteLine(f.GetType()); // System.Single

            double d = double.MaxValue;
            Console.WriteLine(d.GetType()); // System.Double

            // Advanced 개발시에 필요한 내용.

            FieldInfo[] fields = type.GetFields(); // 타입 객체에서 어떤 필드가 있는지 모두확인
            foreach (var item in fields)
            {
                Console.WriteLine($"Type : {item.FieldType}, Name : {item.Name}");
            }
            MethodInfo[] methods = type.GetMethods(); // 타입 객체에서 어떤 메서드가 있는지 모두확인
            foreach (var item in methods)
            {
                Console.WriteLine($"Type : {item.Type}, Name : {item.Name}");
            }

            // 에트리뷰트
            Console.WriteLine("에트리뷰트");

            MyClass myclass = new MyClass();
            myclass.OldMethod();
            myclass.NewMethod();

        }
    }
}

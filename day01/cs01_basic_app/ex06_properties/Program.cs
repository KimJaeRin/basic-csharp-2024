namespace ex06_properties
{
    class Kiturami
    {
        private int temperature; // 온도

        private int year; // 제작년도
        public int Year
        {
            get { return year; }
            set { year = value; }
        }// 일반 프로퍼티
     
        public string Name { get; set; }  // 자동 프로퍼티 GET/SET에서 특별한 로직이 없으면 생략가능

        // Rosalyn VS 개발서포터

        public int Temperature 
        { 
            get
            {                //값을 리턴하니깐 특별한 기능이 없음
                return temperature;    
            } 
            set        //잘못된 값이 들어오면 안되기 때문에 여러 제약을 걸어줌
            {  
                if (value < 10)
                {
                    temperature = 20; // 10도 이하는 허용안함
                }
                else if (value > 70)
                {
                    temperature = 50; // 70도 초과는 허용안함
                }
                else
                temperature = value; 
            } 
        }

        public Kiturami(int year, string name, int temperature)
        {
            Year = year;
            Name = name;
            Temperature = temperature;
        }

        public void SetTemperature(int temp)
        {
            if (temp > 70)
            {
                Console.WriteLine("온도가 너무 높습니다. 50도로 조정합니다/");
                this.temperature = 50;
            }
            else if (temp < 10)
            {
                Console.WriteLine("온도가 너무 낮습니다. 20도로 조정합니다/");
                this.temperature = 20;
            }
            else
            {
                this.temperature = temp;
            }
        }
            

        public int GetTemperature() 
        { 
            return temperature; 
        }
       
        public void ON()
        {
            Console.WriteLine("보일러 ON");
        }

        public void off()
        {
            Console.WriteLine("보일러 OFF");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("보일러 시작!");
            Kiturami boiler = new Kiturami();
            //boiler.SetTemperature = 400;
            // Console.WriteLine($"보일러 온도는 {boiler.GetTemperature()}도");
            boiler.Temperature = 400;
            Console.WriteLine($"보일러 온도는 {boiler.Temperature}도");
            boiler.ON();

            boiler.Name = "귀뚜라미";
            Console.WriteLine($"보일러 이름은 {boiler.Name}");

            Kiturami kiturami = new Kiturami(name: "귀뚜", temperature: 25, year: 2024);
            Console.WriteLine(kiturami.Name);
            Console.WriteLine($"제작년도 : {kiturami.Year}");
            kiturami.Temperature = 180;
            Console.WriteLine($"{kiturami.Name}, 현재온도는 {kiturami.Temperature}") ;
        }
    }
}

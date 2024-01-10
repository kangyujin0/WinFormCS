using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSconApp01
{
    internal class Program // 주진입점 호출. 주가 되는 class 생성
    {        
        static void Main(string[] args)          // 객체화 되기전에도 호출할 수 있는 상태 static
        {
            Test test = new Test();             // new 키워드로 객체화
            test.main();            
        }
    }
    class Test
    {
        void func1()
        {
            Console.WriteLine("long type의 크기 " + sizeof(long) + "(byte) 범위" + long.MinValue + "," + long.MaxValue);
            Console.WriteLine("float type의 크기 " + sizeof(float) + "(byte) 범위" + float.MinValue + "," + float.MaxValue);
            Console.WriteLine("double type의 크기 " + sizeof(double) + "(byte) 범위" + double.MinValue + "," + double.MaxValue);
        }
        void func2()
        {
            char a = 'A';
            Console.WriteLine("char a = " + a);
            Console.WriteLine("char a+1 = " + (a + 1));
            Console.WriteLine("char a+2 = " + (a + 2));
            Console.ReadKey();
        }
        void func3()
        { 
            var a = 20; // var 초기화 시점에 타입을 기반으로 추론(일회성)
            Console.WriteLine($"ASCII code '1' = \x31 \u0031 \r\n");    // 16진수표기, 유니코드표기
            a = 10;
            Console.WriteLine($"var a = {a}");
            Object o = a; // Object 모든 type의 원형
            Console.WriteLine($"object o = {o}");
            o = "문자열도 되나요?"; 
            Console.WriteLine($"object o = {o}");
            string s = (string)o; // data->obj 가능 obj->data 불가능->string 캐스팅(하나의 타입을 다른 데이터 타입으로 변환)
            Console.WriteLine($"string s = {s}");
        }
        void func4()    // C#에서 data type, 배열 모두 객체이다.
        {
            char[] carr = { '헬', '로', '우'};  //new int[100];
            char a1 = carr[0];
         
            for(int i = 0; i < carr.Length; i++)
            {
                Console.Write(carr[i]);
            }
            Console.WriteLine("");
            string s = new string(carr);    // string class의 생성자 = string
            Console.WriteLine(s);
            s = new string(carr,1,2);
            Console.WriteLine(s);
        }
       public void main()
        {
            //Console.WriteLine("int type의 크기 " + sizeof(int) + "(byte) 범위" + int.MinValue + "," + int.MaxValue);
            //Console.WriteLine("(표준)int type의 범위 {1},{2}크기 {0}(byte).", sizeof(int), int.MinValue, int.MaxValue);
            //Console.WriteLine($"(보간)int type의 범위 {int.MinValue},{int.MaxValue} 크기 {sizeof(int)}(byte)."); // $
            //func1();
            //func2();
            func3();
            //func4();
            Console.ReadKey();
        }
    }
}

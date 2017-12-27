using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetPreKey
{
    class Program
    {
        static void Main(string[] args)
        {
            int PreKey;
            int InputValue;
            Stopwatch MyStopwatch = new Stopwatch();
            TimeSpan ts = MyStopwatch.Elapsed;

            string ElapseTime;

            MyStopwatch.Reset();

            InputValue = Input();

            if(InputValue> -1)
            {
                MyStopwatch.Start();

                PreKey = GetPreKey(InputValue);

                MyStopwatch.Stop();
                ElapseTime = MyStopwatch.Elapsed.ToString();

                Console.WriteLine("{0}의 이전 키는 {1}입니다. 검색하는 데 걸린 시간은 {2}ms입니다.", InputValue, PreKey, ElapseTime);
            }
            else
            {
                Console.WriteLine("양의 정수를 입력하세요.");
            }
        }

        // 입력 함수
        private static int Input()
        {
            Console.WriteLine("숫자를 입력하세요.");
            int InputValue = -1;
            string InputText = "";

            InputText = Console.ReadLine();
            
            if (InputText != "" && InputText != " ")
            {
                InputValue = int.Parse(InputText);
            }
            else
            {
                Console.WriteLine("숫자를 입력하세요.");
            }

            return InputValue;
        }

        // 입력한 값의 이전 키를 구하는 함수
        private static int GetPreKey(int InputValue)
        {
            // 값 들 : 정수 값이 들어 있는 배열
            int[] Values = /*{ 1, 4, 10, 20, 31, 47, 59, 67, 73, 89 }*/ { }; 
            // 이전 키 : 입력한 값의 이전 키
            int PreKey = 0;

            if(InputValue > -1)
            {
                for(int i = 0; i < Values.Length; i++)
                {
                    if(InputValue > Values[i])
                    {
                       PreKey = i;
                    }
                    else
                    {
                        if(InputValue == Values[i])
                        {
                            if(i > 0)
                            {
                                PreKey = i - 1;
                            }
                            else
                            {
                                PreKey = 0;
                            }
                        }
                    }
                }
            }

            return PreKey;
        }
    }
}

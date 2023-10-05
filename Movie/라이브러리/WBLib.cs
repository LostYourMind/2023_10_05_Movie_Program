//WBLib.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CppToCs
{
    internal static class WBLib //정적 클래스
    {
        #region 입력기능
        //정적 맴버만 사용 가능
        public static int InputInteger(string msg)
        {
            Console.Write(msg + " >> ");//전달된 msg를 단일 라인으로 화면에 출력
            return int.Parse(Console.ReadLine());//ReadLine으로 읽어온 데이터를 Parse해서 바로 리턴
        }

        public static float InputFloat(string msg)
        {
            Console.Write(msg + " >> ");//전달된 msg를 단일 라인으로 화면에 출력
            return float.Parse(Console.ReadLine());//ReadLine으로 읽어온 데이터를 Parse해서 바로 리턴
        }

        public static char InputChar(string msg)
        {
            Console.Write(msg + " >> ");//전달된 msg를 단일 라인으로 화면에 출력
            return char.Parse(Console.ReadLine());//ReadLine으로 읽어온 데이터를 Parse해서 바로 리턴
        }

        public static string InputString(string msg)
        {
            Console.Write(msg + " >> ");//전달된 msg를 단일 라인으로 화면에 출력
            return Console.ReadLine();//ReadLine으로 읽어온 데이터를 Parse해서 바로 리턴
        }

        public static ConsoleKey InputKey()
        {
            return Console.ReadKey().Key;//특정 키를 받으면 해당 키 리턴
        }
        #endregion

        #region 콘솔화면 제어

        public static void Clear()
        {
            Console.Clear();//화면을 지워주는 코드
        }//화면 초기화 기능

        public static void Pause()
        {
            Console.WriteLine("\n\nENTER키를 누르세요..........");
            Console.ReadLine();
        }//화면 정지 기능
        #endregion
    }
}

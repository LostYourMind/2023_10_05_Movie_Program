using CppToCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.라이브러리
{
    internal class Movie_main : IDisposable
    {
        private MControl con = new MControl();//1.주소를 담을 수 있는 객체가 만들어진것

        #region 생성자 & 소멸자
        public Movie_main()
        {
            Logo();
        }

        ~Movie_main()
        {
            Dispose();
        }

        public void Dispose()
        {
            Ending();
            GC.SuppressFinalize(this);//가비지 컬렉터 호출
        }//Dispose() 재정의
        #endregion


        public void Run()
        {
            while (true)
            {
                WBLib.Clear();
                con.Printall();//현재 저장되어 있는 모든 계좌번호, 이름, 금액을 출력함 con.Printall() -> acc.print() -> print 메서드
                MenuPrint();   //하단 MenuPrint 개체 호출         
                switch (WBLib.InputKey()) //WBLib에서 리턴한 ReadKey.Key 값을 받음
                {
                    //case 문 중 해당하는 키가 있으면 그 해당 함수 호출
                    case ConsoleKey.Escape: return;                 //함수 종료!
                    case ConsoleKey.F1: con.Insert(); break;        //AccControl -> public void Insert()      // 영화 저장
                    case ConsoleKey.F2: con.Delete(); break;        //AccControl -> public void Delete()      // 영화 삭제
                    case ConsoleKey.F3: con.UpdateInput(); break;   //AccControl -> public void UpdateInput() // 평점 점수로 전환
                    case ConsoleKey.F4: con.Select(); break;        //AccControl -> public void Select()      // 영화 선택 O 
                    default: Console.WriteLine("없는 메뉴 입니다"); break;
                }
                WBLib.Pause(); //일시 정지
            }
        }

        private void Logo()
        {
            WBLib.Clear();
            Console.WriteLine("******************************************************\n");
            Console.WriteLine(" 비트 38기 고급과정\n");
            Console.WriteLine(" C# 배열 이용한 영화관??? 프로그램\n");
            Console.WriteLine(" 박하사\n");
            Console.WriteLine(" 2023-10-05\n");
            Console.WriteLine("******************************************************\n");
            WBLib.Pause();
        }

        private void MenuPrint()
        {
            Console.WriteLine("******************************************************\n");
            Console.WriteLine(" [ESC] 프로그램 종료\n");
            Console.WriteLine(" [F1 ] 영화 저장(insert)\n");
            Console.WriteLine(" [F2 ] 영화 삭제(delete)\n");
            Console.WriteLine(" [F3 ] 평점 저장(update)\n");
            Console.WriteLine(" [F4 ] 영화 검색(select)\n");
            Console.WriteLine("******************************************************\n");
        }

        private void Ending()
        {
            WBLib.Clear();
            Console.WriteLine("******************************************************\n");
            Console.WriteLine("프로그램을 종료합니다.\n");
            Console.WriteLine("******************************************************\n");
            WBLib.Pause();
        }

    }
}

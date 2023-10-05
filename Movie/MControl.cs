using CppToCs;
using Movie.데이터;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Movie
{
    internal class MControl
    {
        private WBArry accounts; //계좌 리스트 저장소
        private WBArry accinfos; //계좌 내역 저장소

        #region 생성자와 sample 초기화 처리
        public MControl()
        {
            int max = 100;
            accounts = new WBArry(max);
            accinfos = new WBArry(max);

            Temp_InitData();
        }

        private void Temp_InitData()//임시 데이터
        {
            accounts.PushBack(new Movie_Data("2023.09.27", "1947 보스톤", "액션"));
            accinfos.PushBack(new Movie_Info("1947 보스톤", "드라마"));

            accounts.PushBack(new Movie_Data("2023.09.27", "더 넌2", "액션"));
            accinfos.PushBack(new Movie_Info("더 넌2", "공포"));

            accounts.PushBack(new Movie_Data("2023.09.28", "극장판 엉덩이 탐정: 미스터리 가면 ~최강의 대결", "액션"));
            accinfos.PushBack(new Movie_Info("극장판 엉덩이 탐정: 미스터리 가면 ~최강의 대결", "애니메이션"));
        }

        #endregion

        #region 메서드
        public void Printall()
        {
            //현재 저장된 계좌 모두 출력
            Console.WriteLine("저장 개수 : {0}개\n", accounts.Size);

            for (int i = 0; i < accounts.Size; i++)
            {
                Movie_Data acc = (Movie_Data)accounts[i];//object가 부모라서 다운 텍스팅
                Console.Write("{0,2}", i);
                acc.Print();//출력
            }
        }

        public void Insert()
        {
            Console.WriteLine("[영화 저장]\n");

            try
            {
                string day = WBLib.InputString("개봉 날짜 입력 ");
                string name = WBLib.InputString("영화 제목");
                string type = WBLib.InputString("영화 장르");

                //계좌 정보 저장 
                Movie_Data acc = new Movie_Data(day, name, type);
                accounts.PushBack(acc);                         //accounts 저장소에 acc(id, name, balance) 저장

                //평점 등록 내역 저장 
                //Movie_Info info = new Movie_Info(day, name, type, score);
                //accinfos.PushBack(info);                        //accinfos 저장소에 info(id, balance, 0, balance) 저장

                Console.WriteLine("영화 저장 성공");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        } //계좌 생성 기능
        
        public void Delete()
        {
            Console.WriteLine("[영화 삭제]\n");

            try
            {
                string test = WBLib.InputString("영화 제목 입력 ");
                int idx = ValueToIdx(test);
                accounts.Erase(idx);

                Console.WriteLine("삭제 성공!");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }//영화 삭제 기능

        public void UpdateInput()
        {
            Console.WriteLine("평점 저장");

            
            string test = WBLib.InputString("영화 제목 입력 ");
            int idx = ValueToIdx(test);

            int sc = WBLib.InputInteger("평점입력 ");

            Movie_Data acc = (Movie_Data)accounts[idx];
            acc.AddScore(sc);

        }


        public void Select()
        {
            Console.WriteLine("영화 검색\n");

            //검색해온 계좌의 기본 정보 출력
            string test  = WBLib.InputString("영화 제목 입력 ");
            int idx = ValueToIdx(test);

            Movie_Data acc = (Movie_Data)accounts[idx];
            acc.Println();

            for (int i = 0; i < accinfos.Size; i++)
            {
                Movie_Info info = (Movie_Info)accinfos[i];
                if (info.Name == test)
                {
                    info.Print();
                }
                Console.WriteLine("-----------------------------------------");
            }
        }//계좌 선택 기능
        
        private int ValueToIdx(string name)
        {
            for (int i = 0; i < accounts.Size; i++)
            {
                Movie_Data acc = (Movie_Data)accounts[i];
                if (acc.Name.Contains(name))
                    return i;  //찾은 인덱스
            }
            throw new Exception("존제하지 않는 영화");
        }//계좌번호로 저장 인덱스찾기

        #endregion
    }
}

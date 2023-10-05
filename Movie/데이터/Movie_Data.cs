//Account.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CppToCs
{
    class Movie_Data
    {
        //맴버 필드
        private string day;     //개봉 날짜
        private string name;//이름
        private string type;//잔액정보
        private int score;
        private int people;
        private int total;

        #region 프로퍼티
        public string Day
        {
            get { return day; }
            private set { day = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public string Type
        {
            get { return type; }
            private set { type = value; }
        }
        public int Score
        {
            get { return score; }
            private set { score = value; }
        }

        public int People
        {
            get { return people; }
            private set { people = value; }
        }

        public int Total
        {
            get { return total; }
            private set { total = value; }
        }


        #endregion

        #region 생성자 & 소멸자
        public Movie_Data(string _day, string _name, string _type)
        {

            Day = _day;
            Name = _name;
            Type = _type;

        }

        public Movie_Data(string _day, string _name)
        {
            Day = _day;
            Name = _name;
        }

        ~Movie_Data()//[소멸자] - 필요 없으면 만들지 말자
        {

        }
        #endregion

        #region 메서드

        public void Print()//출력 요청 메서드
        {
            Console.Write("." + Day + ", ");
            Console.Write(Name + ", ");
            Console.Write(Type + ", ");
            Console.Write(Total);
            Console.WriteLine();
        }

        public void Println()
        {
            Console.WriteLine("[개봉날짜 : " + Day + " ]");
            Console.WriteLine("[이름 :" + Name + " ]");
            Console.WriteLine("[장르 : " + Type + " ]");
            Console.WriteLine("[평점 : " + Total + " ]");
        }

        public void AddScore(int sc)//입금 요청 처리 메서드
        {
            if (sc <= 0 || sc > 10)
                throw new Exception("잘못된 입력");

            Score =  Score + sc;
            People++;
            Total = Score / People;
        }

        #endregion
    };
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.데이터
{
    internal class Movie_Score
    {
    
        private string name;//이름
        private string score;

        #region 프로퍼티


        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public string Score
        {
            get { return score; }
            private set { score = value; }
        }
        #endregion


        #region 생성자 + 소멸자
        public Movie_Score(string _name, string _score)
        {
            Name = _name;
            Score = _score;

        }

        ~Movie_Score()//[소멸자] - 필요 없으면 만들지 말자
        {

        }
        #endregion

        #region 메서드
        public void AddCriti(string name ,string score)
        {
            if (name == null)
                throw new Exception("영화 제목을 입력해주세요");

        }//입금 요청 처리 메서드 -> 영화 평점 입력

        public void Print()//출력 요청 메서드
        {
            Console.Write(Name + ", ");
            Console.Write(Score);
            Console.WriteLine();
        }

        public void Println()
        {
            Console.WriteLine("[이름]" + Name);
            Console.WriteLine("[잔액]" + Score);
        }
        #endregion
    }
}

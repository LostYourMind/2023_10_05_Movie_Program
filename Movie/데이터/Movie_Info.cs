using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.데이터
{
    internal class Movie_Info
    {
        private string name;
        private string type;
        private string score;

        #region 프로퍼티

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
        public string Score
        {
            get { return score; }
            private set { score = value; }
        }
        #endregion

        #region 생성자 & 소멸자
        public Movie_Info(string name, string type)
        {
            Name = name;
            Type = type;

        }

        ~Movie_Info()
        {

        }
        #endregion

        #region 메서드

        public void Print()
        {
            Console.WriteLine("영화 제목 : " + Name);
            Console.WriteLine("영화 장르 : " + Type);
            Console.WriteLine("영화 평점 : " + Score);

        }

        #endregion
    }
}

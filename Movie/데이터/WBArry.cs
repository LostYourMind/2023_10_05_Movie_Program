using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Movie.데이터
{
    internal class WBArry
    {
        //맴버 필드 & 프로퍼티
        public int Max { get; private set; }         //최대 저장공간
        public int Size { get; private set; }         //저장 개수, 저장 위치
        object[] arr;                                 //배열 저장소(object를 사용하면 모든 타입을 저장이 가능)

        #region 생성자
        public WBArry()
        {
            Max = 10;
            Size = 0;

            arr = new object[Max];
        }

        public WBArry(int _max)
        {
            Max = _max;
            Size = 0;

            arr = new object[Max];
        }
        #endregion

        #region 배열에 저장된 특정 인덱스의 값읠 반환
        //2.인덱스 사용
        //1.메서드 사용
        public object getData(int idx)
        {
            if (idx >= 0 && idx < Size)  //유효한 인덱스
                return arr[idx];
            else
                //return null; <- null도 가능함
                throw new Exception("인덱스 범위 벗어남....");
        }

        public object this[int idx]
        {
            get
            {
                if (idx >= 0 && idx < Size)  //유효한 인덱스
                    return arr[idx];
                else
                    //return null; <- null도 가능함
                    throw new Exception("인덱스 범위 벗어남....");
            }
        }

        public void PushBack(object value)
        {
            if (Max <= Size)   //Overflow 라면 return false;
                throw new Exception("OverFlow....");

            arr[Size] = value;
            Size++;
        }

        public void Erase(int idx)
        {
            if (idx > 0 && idx >= Size)  //유효한 인덱스인가?
                throw new Exception("잘못된 인덱스");
            for (int i = idx; i < Size - 1; i++)  //이동!
            {
                arr[i] = arr[i + 1];
            }
            Size--;
        }

        #endregion
    }
}

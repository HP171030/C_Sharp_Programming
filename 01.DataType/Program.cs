﻿namespace _01.DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            // <자료형 종류>
            // 자료형 이름      자료형 형태          메모리 크기     표현 범위
            //
            // - 논리형 -
            // bool             논리 자료형          1byte           true, false
            //
            // - 정수형 -
            // byte             부호없는 정수형      1byte              0 ~ 255
            // sbyte            부호있는 정수형      1byte           -128 ~ 127
            //
            // short            부호있는 정수형      2byte           -2^15 ~ 2^15 - 1     =>  -32,768 ~ 32,767 
            // int              부호있는 정수형      4byte           -2^31 ~ 2^31 - 1     =>  -2,147,483,648 ~ 2,147,483,647
            // long             부호있는 정수형      8byte           -2^63 ~ 2^63 - 1     =>  -9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807
            //                                                                                
            // ushort           부호없는 정수형      2byte           0 ~ 2^16 - 1         =>   0 ~ 65,535
            // uint             부호없는 정수형      4byte           0 ~ 2^32 - 1         =>   0 ~ 4,294,967,295
            // ulong            부호없는 정수형      8byte           0 ~ 2^64 - 1         =>   0 ~ 18,446,744,073,709,551,615
            //                                                                                
            // - 실수형 -                                                                     
            // float            부동소수점 실수      4byte           3.4e-38  ~ 3.4e+38   =>  약 소수점 7자리
            // double           부동소수점 실수      8byte           1.7e-308 ~ 1.7e+308  =>  약 소수점 15자리
            //
            // - 문자형 - 
            // char             유니코드 문자형      2byte           'a', 'b', '한', ...
            // string           유니코드 문자열        X             "abcde", "안녕", ...



            /************************************************************************
             * 변수 (variable)
             * 
             * 데이터를 저장하기 위해 프로그램에 의해 이름을 할당받은 메모리 공간
             * 데이터를 저장할 수 있는 메모리 공간을 의미하며, 저장된 값은 변경 가능
             ************************************************************************/

            // <변수 선언 및 초기화>
            // 자료형의 선언하고 빈칸 뒤에 변수이름을 작성하여 변수 선언
            // 선언한 변수에 값을 처음 할당하는 과정을 초기화라고 함
            // 변수 선언과 초기화 과정을 동시에 진행할 수 있음
            int iValue = 10;                    // int 자료형의 이름이 intValue인 변수에 10의 데이터를 초기화
            float fValue;                       // float 자료형의 이름이 floatValue인 변수를 선언하지만 값을 초기화하지 않음
            // int intValue;                    // error : 같은 이름의 변수는 사용 불가
            // Console.WriteLine(floatValue);   // error : 선언한 변수에 값을 초기화하기 전까지 사용 불가


            // <변수에 데이터 저장>
            // =(대입연산자) 좌측에 변수를 배치
            iValue = 5;                         // iValue 변수에 5의 데이터 저장
            fValue = 1.2f;                      // fValue 변수에 1.2f 데이터를 초기화


            // <변수의 데이터 불러오기>
            // 데이터가 필요한 곳에 변수명을 배치
            int rValue = 20;
            int lValue = rValue;
            Console.WriteLine($"rValue 변수에 보관된 데이터는 {rValue} 입니다.");
            Console.WriteLine($"lValue 변수에 보관된 데이터는 {lValue} 입니다.");



            /*****************************************************************
             * 상수 (Constant)
             *
             * 프로그램이 실행되는 동안 변경할 수 없는 데이터
             * 프로그램에서 값이 변경되기를 원하지 않는 데이터가 있을 경우 사용
             * 저장된 값은 프로그램 종료시까지 변경 불가능
             ******************************************************************/

            // <상수 선언 및 초기화>
            // 변수 선언 앞에 const 키워드를 추가하여 상수 선언
            const int MAX = 200;        // MAX 상수 변수를 선언하고 초기화
            Console.WriteLine($"MAX 상수에 보관된 데이터는 {MAX} 입니다.");
            // const int MIN;           // error : 상수는 초기화 없이 사용불가
            // MAX = 20                 // error : 상수의 데이터 변경 불가



            /*****************************************************************
             * 형변환 (Casting)
             *
             * 데이터를 선언한 자료형에 맞는 형태로 변환하는 작업
             * 다른 자료형의 데이터를 저장하기 위해선 형변환 과정을 거쳐야하며,
             * 이 과정에서 보관할 수 없는 데이터는 버려짐
             ******************************************************************/

            // <명시적 형변환>
            // 변환할 데이터의 앞에 변환할 자료형을 괄호안에 넣어 형변환 진행
            int intValue = (int)1.2;            // 1.2를 int로 변환하는 과정 중 보관할 수 없는 소수점이 버려짐
            // int intValue = 1.2;              // error : 명시적 형변환 없이 변환 불가
            Console.WriteLine($"int 변수에 1.2를 형변환하여 집어넣은 데이터는 {intValue} 입니다.");


            // <묵시적 형변환>
            // 변수에 데이터를 넣는 과정에서 자료형이 더 큰범위를 표현하는 경우 자동으로 형변환을 진행
            float floatValue = 3;               // 부동소수점형 변수에 정수형 데이터를 넣을 경우 자동형변환 가능
            double doubleValue = 1.2f;          // double은 float를 포함하는 큰 범위이니 자동형변환 가능
            doubleValue = (double)floatValue;   // 일반적으로 변수의 형변환 같은 경우 자동형변환이 가능하다 하더라도 형변환을 적어줌


            // <문자 형변환과 아스키코드 & 유니코드>
            // 아스키코드 : 이진법을 사용하는 컴퓨터에서 문자를 표현하기 위해 정해둔 문자와 숫자의 매칭표
            // 유니코드 : 영어만 표현이 가능했던 아스키코드에서 전세계의 모든 문자를 다루도록 설계한 매칭표
            Console.WriteLine($"유니코드 65는 {(char)65} 로 표현합니다.");
            Console.WriteLine($"문자 'a'는 {(int)'a'} 로 처리합니다.");


            // <문자열 형변환>
            // 문자열은 단순형변환이 불가
            // 각 자료형의 Parse, TryParse를 이용하여 문자열에서 자료형으로 변환
            // 각 자료형에서 ToString을 이용하여 자료형에서 문자열로 변환

            int value = int.Parse("142");               // int.Parse를 통해 string 자료형을 int로 변환
            // int value = (int)"142";                  // error : 문자열 자료를 정수형 자료형으로 단순형변환은 불가능
            // int value = int.Parse("abc");            // error : 변환할 수 없는 문자열 자료를 정수형으로 변환하려 시도하는 경우 예외 발생

            bool fail = int.TryParse("abc", out value);         // 변환이 불가한 문자열이므로, fail은 false, value는 0이 결과로 나옴
            bool successs = int.TryParse("123", out value);     // 변환이 가능한 문자열이므로, success는 true, value는 변환 결과가 나옴

            string text = 3.2.ToString();               // ToString을 이용하여 모든 자료형을 string으로 변환
        }
    }
}

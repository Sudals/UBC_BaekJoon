using System;
using System.Text;
using static System.Console;

namespace baekioon
{
    class MainApp
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine()); // 테스트 케이스 개수
            StringBuilder r = new StringBuilder(); // 출력
            for (int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split(); // 테스트 케이스 입력
                int n = int.Parse(s[0]), m = 0; // n은 학생 총 수
                int[] u = new int[n]; // 각 학생 성적
                for (int j = 1; j <= n; j++) { u[j - 1] = int.Parse(s[j]); m += u[j - 1]; } // 학생 성적 입력, 성적 총합
                double v = (double)m / n; m = 0; // 성적 총합에 학생수 나눠 평균 v, m은 0으로 초기화
                for (int k = 0; k < n; k++) if (u[k] > v) m++; // 평균 넘는 학생수 카운트
                                                               // r.AppendLine(((double)m / n).ToString("P3")); // 틀림
                r.AppendLine((m * 100d / n).ToString("0.000") + "%"); // 맞음
            }
            Console.WriteLine(r.ToString()); // 출력
        
        }
    }
}
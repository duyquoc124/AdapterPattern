using AdapterPattern.Adapter;
using System;

namespace AdapterPattern
{
    class Program
    {        
        static void Main(string[] args)
        {
            var studentName = "Jose";
            ICaculatorStudentScore _caculatorStudentScore = new CaculatorStudentScore();
            var score = _caculatorStudentScore.GetScoreByStudentName(studentName);
            Console.WriteLine($"Score of student {studentName} before apply apdapter pattern: {score}");

            _caculatorStudentScore = new CaculatorStudentScoreAdapter();
             score = _caculatorStudentScore.GetScoreByStudentName(studentName);
            Console.WriteLine($"Score of student {studentName} after apply apdapter pattern: {score}");

            Console.ReadLine();
        }
    }
}

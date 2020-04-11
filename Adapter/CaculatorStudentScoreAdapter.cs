
using AdapterPattern.Adaptee;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Adapter
{
    public class CaculatorStudentScoreAdapter : ICaculatorStudentScore
    {
        /// <summary>
        /// use this interface for caculating the student core
        /// </summary>
        private readonly IBounusBaseOnStudentScore _bounusBaseOnStudentScore;

        /// <summary>
        /// we want to use the GetScoreByStudentName, then apply BounusBaseOnStudentScore for the student core
        /// </summary>
        private readonly ICaculatorStudentScore _caculatorStudentScore;

        public CaculatorStudentScoreAdapter()
        {
            _bounusBaseOnStudentScore = new BounusBaseOnStudentScore();
            // we have applied adapter pattern to solve the problem for adding bonus for student 
            _caculatorStudentScore = new CaculatorStudentScore();
        }

        /// <summary>
        /// new method to caculate the student score
        /// </summary>
        /// <param name="studentName"></param>
        /// <returns></returns>
        public int GetScoreByStudentName(string studentName)
        {
            var score = _caculatorStudentScore.GetScoreByStudentName(studentName);
            return _bounusBaseOnStudentScore.BounusBaseOnStudentScore(score);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Adaptee
{
    public class BounusBaseOnStudentScore : IBounusBaseOnStudentScore
    {
        int IBounusBaseOnStudentScore.BounusBaseOnStudentScore(int score)
        {
            return score * 20 / 100 + score;
        }

        
    }
}

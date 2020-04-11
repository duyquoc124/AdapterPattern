using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Adaptee
{
    /// <summary>
    /// we want to apply IBounusBaseOnStudentScore for ICaculatorStudentScore but don't change anything in this class
    /// </summary>
    public interface IBounusBaseOnStudentScore
    {
        int BounusBaseOnStudentScore(int score);
    }

   
}

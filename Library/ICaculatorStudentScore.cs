using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern.Adapter
{
    /// <summary>
    /// the application with use this interface
    /// </summary>
    public interface ICaculatorStudentScore
    {
        /// <summary>
        /// get score by student name
        /// </summary>
        /// <param name="studentName">student name</param>
        /// <returns>score</returns>
        int GetScoreByStudentName(string studentName);


    }

}

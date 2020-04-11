using AdapterPattern.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern.Adapter
{
    /// <summary>
    /// can not modified this class, because some aplication are using it
    /// </summary>
    public class CaculatorStudentScore : ICaculatorStudentScore
    {
        private List<Student> _listStudent { get; set; }

        /// <summary>
        /// get score by student name
        /// </summary>
        /// <param name="studentName">student name</param>
        /// <returns>score</returns>
        public int GetScoreByStudentName(string studentName)
        {
            if (_listStudent == null)
            {
                var dataProvider = new DataProvider();
                _listStudent = dataProvider.GetData();
            }
            var student = _listStudent.FirstOrDefault(x => x.FullName == studentName);            
            return student?.Score ?? 0;
        }
    }
    


}

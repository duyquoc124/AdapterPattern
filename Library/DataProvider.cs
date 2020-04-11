using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Library
{

    /// <summary>
    /// get data for student
    /// </summary>
    public class DataProvider
    {
        /// <summary>
        /// get fake list of student
        /// </summary>
        /// <returns></returns>
        public List<Student> GetData()
        {
            var result = new List<Student>()
            {
                new Student()
                {
                    FullName="Jose",
                    Score= 70
                },
                new Student()
                {
                    FullName="Tom",
                    Score= 89
                },
                new Student()
                {
                    FullName="Kate",
                    Score= 67
                }
            };
            return result;
        }
    }
}

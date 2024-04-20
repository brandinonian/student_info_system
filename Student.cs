using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_info_sys_3077
{
    public class Student
    {
        public int id {  get; set; }

        public int grade_level { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public List<int> courses { get; set; }

        public string full_name
        {
            get
            {
                return first_name + " " + last_name;
            }
        }

        public Student(int id, int grade_level, string first_name, string last_name, List<int> courses)
        {
            this.id = id;
            this.grade_level = grade_level;
            this.first_name = first_name;
            this.last_name = last_name;
            this.courses = courses;
        }
    }
}

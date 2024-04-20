using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_info_sys_3077
{
    public class Course
    {
        public int id { get; set; }

        public string name { get; set; }

        public Course(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}

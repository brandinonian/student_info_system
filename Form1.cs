namespace student_info_sys_3077
{
    public partial class Form1 : Form
    {
        public List<Student> students = new List<Student>();

        public List<Course> courses = new List<Course>();

        public Form1()
        {
            InitializeComponent();

            // a real backend would be cool...
            students.Add(new Student(111, 2, "Brandon", "Phillips", [1234, 4567]));
            students.Add(new Student(222, 4, "John", "Doe", [1234, 2345, 3456]));
            students.Add(new Student(333, 2, "Jane", "Doe", [1234, 3456, 4567]));

            courses.Add(new Course(1234, "SQL 1010"));
            courses.Add(new Course(2345, "JavaScript 1010"));
            courses.Add(new Course(3456, "Java 1010"));
            courses.Add(new Course(4567, "Go 1010"));

            // might be a better way to do this
            CourseDropdown.DataSource = courses;
        }

        private void GetInfoById(object sender, EventArgs e)
        {
            string input = StudentIdSearchBox.Text;
            int id;

            try
            {
                id = int.Parse(input);
            }
            catch
            {
                // not sure I even need to do this but I know Parse likes to throw errors
                // just don't use -666 as an id and it's fine
                id = -666;
            }

            // I kind of hate this, but it mostly works
            foreach (var student in students)
            {
                if (student.full_name.Contains(input) || student.id == id)
                {
                    string result = "";
                    result += "Name: " + student.full_name + "\n";
                    result += "ID: " + student.id + "\n";
                    result += "Grade: " + student.grade_level + "\n\n";
                    result += "Courses:\n";

                    foreach (var course in student.courses)
                    {
                        // this is where an inner join would be nice
                        // instead we just get course id's
                        result += course.ToString() + "\n";
                    }

                    SearchResults.Text = result;
                }
            }
        }

        private void OnCourseSelected(object sender, EventArgs e)
        {
            // might break but it shuts up the compiler
            Course selected = (Course)CourseDropdown.SelectedItem;

            string result = "";
            result += "Course ID: " + selected.id + "\n";
            result += "Course Name: " + selected.name + "\n";
            result += "\n" + "Roster:\n";

            foreach (var student in students)
            {
                if (student.courses.Contains(selected.id))
                {
                    result += student.id + " " + student.full_name + "\n";
                }
            }

            CourseResults.Text = result;
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            // no validation, this will break if you don't use the right input
            // oh well
            int id = int.Parse(IDInput.Text);
            int grade = int.Parse(GradeInput.Text);
            string fname = FirstNameInput.Text;
            string lname = LastNameInput.Text;
            List<int> courses = new List<int>();

            students.Add(new Student(id, grade, fname, lname, courses));
            AddStudentNotif.Text = "Student Added!";
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            // also doesn't have validation
            int id = int.Parse(CourseIDInput.Text);
            string name = CourseNameInput.Text;

            courses.Add(new Course(id, name));
            AddCourseNotif.Text = "Course Added!";

            // TODO doesn't update the dropdown
        }
    }
}

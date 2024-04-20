namespace student_info_sys_3077
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            student_page = new TabPage();
            SearchResults = new Label();
            StudentIdSearchBox = new TextBox();
            student_search_by_id = new Button();
            course_page = new TabPage();
            CourseResults = new Label();
            CourseDropdown = new ComboBox();
            courseBindingSource = new BindingSource(components);
            add_student = new TabPage();
            AddStudentNotif = new Label();
            AddStudentBtn = new Button();
            LastNameInput = new TextBox();
            LastNameLabel = new Label();
            FirstNameInput = new TextBox();
            FirstNameLabel = new Label();
            GradeInput = new TextBox();
            GradeLabel = new Label();
            IDInput = new TextBox();
            AddIDLabel = new Label();
            add_course = new TabPage();
            AddCourseButton = new Button();
            CourseNameInput = new TextBox();
            CourseNameLabel = new Label();
            CourseIDInput = new TextBox();
            CourseIdLabel = new Label();
            AddCourseNotif = new Label();
            tabControl1.SuspendLayout();
            student_page.SuspendLayout();
            course_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)courseBindingSource).BeginInit();
            add_student.SuspendLayout();
            add_course.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(student_page);
            tabControl1.Controls.Add(course_page);
            tabControl1.Controls.Add(add_student);
            tabControl1.Controls.Add(add_course);
            tabControl1.Location = new Point(18, 19);
            tabControl1.Margin = new Padding(5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(2482, 1641);
            tabControl1.TabIndex = 1;
            // 
            // student_page
            // 
            student_page.Controls.Add(SearchResults);
            student_page.Controls.Add(StudentIdSearchBox);
            student_page.Controls.Add(student_search_by_id);
            student_page.Location = new Point(8, 64);
            student_page.Margin = new Padding(5);
            student_page.Name = "student_page";
            student_page.Padding = new Padding(5);
            student_page.Size = new Size(2466, 1569);
            student_page.TabIndex = 0;
            student_page.Text = "Students";
            student_page.UseVisualStyleBackColor = true;
            // 
            // SearchResults
            // 
            SearchResults.AutoSize = true;
            SearchResults.Location = new Point(40, 304);
            SearchResults.Name = "SearchResults";
            SearchResults.Size = new Size(0, 51);
            SearchResults.TabIndex = 2;
            // 
            // StudentIdSearchBox
            // 
            StudentIdSearchBox.Location = new Point(40, 188);
            StudentIdSearchBox.Margin = new Padding(5);
            StudentIdSearchBox.Name = "StudentIdSearchBox";
            StudentIdSearchBox.Size = new Size(587, 57);
            StudentIdSearchBox.TabIndex = 1;
            // 
            // student_search_by_id
            // 
            student_search_by_id.Location = new Point(638, 181);
            student_search_by_id.Margin = new Padding(5);
            student_search_by_id.Name = "student_search_by_id";
            student_search_by_id.Size = new Size(231, 72);
            student_search_by_id.TabIndex = 0;
            student_search_by_id.Text = "Search";
            student_search_by_id.UseVisualStyleBackColor = true;
            student_search_by_id.Click += GetInfoById;
            // 
            // course_page
            // 
            course_page.Controls.Add(CourseResults);
            course_page.Controls.Add(CourseDropdown);
            course_page.Location = new Point(8, 46);
            course_page.Margin = new Padding(5);
            course_page.Name = "course_page";
            course_page.Padding = new Padding(5);
            course_page.Size = new Size(2466, 1587);
            course_page.TabIndex = 1;
            course_page.Text = "Courses";
            course_page.UseVisualStyleBackColor = true;
            // 
            // CourseResults
            // 
            CourseResults.AutoSize = true;
            CourseResults.Location = new Point(59, 205);
            CourseResults.Name = "CourseResults";
            CourseResults.Size = new Size(0, 51);
            CourseResults.TabIndex = 1;
            // 
            // CourseDropdown
            // 
            CourseDropdown.DataBindings.Add(new Binding("Text", courseBindingSource, "name", true));
            CourseDropdown.DataBindings.Add(new Binding("SelectedValue", courseBindingSource, "id", true));
            CourseDropdown.DataSource = courseBindingSource;
            CourseDropdown.DisplayMember = "name";
            CourseDropdown.FormattingEnabled = true;
            CourseDropdown.Location = new Point(25, 70);
            CourseDropdown.Name = "CourseDropdown";
            CourseDropdown.Size = new Size(574, 58);
            CourseDropdown.TabIndex = 0;
            CourseDropdown.SelectedIndexChanged += OnCourseSelected;
            // 
            // courseBindingSource
            // 
            courseBindingSource.DataSource = typeof(Course);
            // 
            // add_student
            // 
            add_student.Controls.Add(AddStudentNotif);
            add_student.Controls.Add(AddStudentBtn);
            add_student.Controls.Add(LastNameInput);
            add_student.Controls.Add(LastNameLabel);
            add_student.Controls.Add(FirstNameInput);
            add_student.Controls.Add(FirstNameLabel);
            add_student.Controls.Add(GradeInput);
            add_student.Controls.Add(GradeLabel);
            add_student.Controls.Add(IDInput);
            add_student.Controls.Add(AddIDLabel);
            add_student.Location = new Point(8, 46);
            add_student.Name = "add_student";
            add_student.Size = new Size(2466, 1587);
            add_student.TabIndex = 2;
            add_student.Text = "Add Student";
            add_student.UseVisualStyleBackColor = true;
            // 
            // AddStudentNotif
            // 
            AddStudentNotif.AutoSize = true;
            AddStudentNotif.Location = new Point(308, 736);
            AddStudentNotif.Name = "AddStudentNotif";
            AddStudentNotif.Size = new Size(0, 51);
            AddStudentNotif.TabIndex = 10;
            // 
            // AddStudentBtn
            // 
            AddStudentBtn.Location = new Point(138, 819);
            AddStudentBtn.Name = "AddStudentBtn";
            AddStudentBtn.Size = new Size(474, 105);
            AddStudentBtn.TabIndex = 9;
            AddStudentBtn.Text = "Add Student";
            AddStudentBtn.UseVisualStyleBackColor = true;
            AddStudentBtn.Click += AddStudentBtn_Click;
            // 
            // LastNameInput
            // 
            LastNameInput.Location = new Point(35, 595);
            LastNameInput.Name = "LastNameInput";
            LastNameInput.Size = new Size(668, 57);
            LastNameInput.TabIndex = 8;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(35, 541);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(198, 51);
            LastNameLabel.TabIndex = 7;
            LastNameLabel.Text = "Last Name";
            // 
            // FirstNameInput
            // 
            FirstNameInput.Location = new Point(35, 411);
            FirstNameInput.Name = "FirstNameInput";
            FirstNameInput.Size = new Size(668, 57);
            FirstNameInput.TabIndex = 6;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(35, 357);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(202, 51);
            FirstNameLabel.TabIndex = 5;
            FirstNameLabel.Text = "First Name";
            // 
            // GradeInput
            // 
            GradeInput.Location = new Point(35, 241);
            GradeInput.Name = "GradeInput";
            GradeInput.Size = new Size(668, 57);
            GradeInput.TabIndex = 4;
            // 
            // GradeLabel
            // 
            GradeLabel.AutoSize = true;
            GradeLabel.Location = new Point(35, 187);
            GradeLabel.Name = "GradeLabel";
            GradeLabel.Size = new Size(217, 51);
            GradeLabel.TabIndex = 3;
            GradeLabel.Text = "Grade Level";
            // 
            // IDInput
            // 
            IDInput.Location = new Point(35, 85);
            IDInput.Name = "IDInput";
            IDInput.Size = new Size(668, 57);
            IDInput.TabIndex = 2;
            // 
            // AddIDLabel
            // 
            AddIDLabel.AutoSize = true;
            AddIDLabel.Location = new Point(35, 31);
            AddIDLabel.Name = "AddIDLabel";
            AddIDLabel.Size = new Size(59, 51);
            AddIDLabel.TabIndex = 0;
            AddIDLabel.Text = "ID";
            // 
            // add_course
            // 
            add_course.Controls.Add(AddCourseNotif);
            add_course.Controls.Add(AddCourseButton);
            add_course.Controls.Add(CourseNameInput);
            add_course.Controls.Add(CourseNameLabel);
            add_course.Controls.Add(CourseIDInput);
            add_course.Controls.Add(CourseIdLabel);
            add_course.Location = new Point(8, 64);
            add_course.Name = "add_course";
            add_course.Size = new Size(2466, 1569);
            add_course.TabIndex = 3;
            add_course.Text = "Add Course";
            add_course.UseVisualStyleBackColor = true;
            // 
            // AddCourseButton
            // 
            AddCourseButton.Location = new Point(120, 496);
            AddCourseButton.Name = "AddCourseButton";
            AddCourseButton.Size = new Size(474, 105);
            AddCourseButton.TabIndex = 14;
            AddCourseButton.Text = "Add Course";
            AddCourseButton.UseVisualStyleBackColor = true;
            AddCourseButton.Click += AddCourseButton_Click;
            // 
            // CourseNameInput
            // 
            CourseNameInput.Location = new Point(33, 272);
            CourseNameInput.Name = "CourseNameInput";
            CourseNameInput.Size = new Size(668, 57);
            CourseNameInput.TabIndex = 13;
            // 
            // CourseNameLabel
            // 
            CourseNameLabel.AutoSize = true;
            CourseNameLabel.Location = new Point(33, 218);
            CourseNameLabel.Name = "CourseNameLabel";
            CourseNameLabel.Size = new Size(249, 51);
            CourseNameLabel.TabIndex = 12;
            CourseNameLabel.Text = "Course Name";
            // 
            // CourseIDInput
            // 
            CourseIDInput.Location = new Point(33, 88);
            CourseIDInput.Name = "CourseIDInput";
            CourseIDInput.Size = new Size(668, 57);
            CourseIDInput.TabIndex = 11;
            // 
            // CourseIdLabel
            // 
            CourseIdLabel.AutoSize = true;
            CourseIdLabel.Location = new Point(33, 34);
            CourseIdLabel.Name = "CourseIdLabel";
            CourseIdLabel.Size = new Size(54, 51);
            CourseIdLabel.TabIndex = 10;
            CourseIdLabel.Text = "Id";
            // 
            // AddCourseNotif
            // 
            AddCourseNotif.AutoSize = true;
            AddCourseNotif.Location = new Point(120, 392);
            AddCourseNotif.Name = "AddCourseNotif";
            AddCourseNotif.Size = new Size(0, 51);
            AddCourseNotif.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 1093);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            student_page.ResumeLayout(false);
            student_page.PerformLayout();
            course_page.ResumeLayout(false);
            course_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)courseBindingSource).EndInit();
            add_student.ResumeLayout(false);
            add_student.PerformLayout();
            add_course.ResumeLayout(false);
            add_course.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage student_page;
        private Button student_search_by_id;
        private TabPage course_page;
        private TextBox StudentIdSearchBox;
        private Label SearchResults;
        private ComboBox CourseDropdown;
        private BindingSource courseBindingSource;
        private Label CourseResults;
        private TabPage add_student;
        private Label AddIDLabel;
        private TabPage add_course;
        private TextBox IDInput;
        private TextBox LastNameInput;
        private Label LastNameLabel;
        private TextBox FirstNameInput;
        private Label FirstNameLabel;
        private TextBox GradeInput;
        private Label GradeLabel;
        private Button AddStudentBtn;
        private Button AddCourseButton;
        private TextBox CourseNameInput;
        private Label CourseNameLabel;
        private TextBox CourseIDInput;
        private Label CourseIdLabel;
        private Label AddStudentNotif;
        private Label AddCourseNotif;
    }
}

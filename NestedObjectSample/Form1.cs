using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestedObjectSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Instructor> instructors(PopulateIntructorsTestData(instructor));

            lstInstructor.DataSource = instructors;
            lstInstructor.DisplayMember = nameof(Instructor.FullName);
        }

        private void PopulateInstructorTestData(List<Instructor>)
        {
            Instructor ken = new Instructor()
            {
                Email = "Ken@ctpc.edu",
                FullName = "Dr. Kenneth Meerdink"
            };

            List<Course> kenCourses = new List<Courses>()
            {
                new Course()
                {
                    Title = "Data Structures",
                    CourseNumber = "CPW 245" ,
                    Roster = new List<Student>()
                    {
                        new Student("Jim Halpert"),
                        new Student("Pam Halpert")
                    }
                },
                new Course()
                {
                    Title = "Java II",
                    CourseNumber = "CPW 143"
                }
            };

            InstructorKen.CourseLoad = kenCourses;

        }

        
    }
}

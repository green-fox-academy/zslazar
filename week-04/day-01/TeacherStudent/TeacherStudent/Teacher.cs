using System;
using System.Collections.Generic;
using System.Text;

// Teacher
// teach(student) -> calls the students learn method
// answer()

namespace TeacherStudent
{
    class Teacher
    {
        public void Answer()
        {
        }
        
        public void Teach(Student s)
        {
            s.Learn();
        }
    }
}

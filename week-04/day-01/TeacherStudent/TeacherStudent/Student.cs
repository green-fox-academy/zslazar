using System;
using System.Collections.Generic;
using System.Text;

// Student
// learn()
// question(teacher) -> calls the teachers answer method

namespace TeacherStudent
{
    class Student
    {
        public void Learn()
        {
        }

        public void Question(Teacher t)
        {
            t.Answer();
        }
    }
}

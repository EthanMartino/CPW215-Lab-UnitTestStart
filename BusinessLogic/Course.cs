using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        public Course(string courseName)
        {
            CourseName = courseName;
            InstructorName = "STAFF";
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName { get; set; }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName
        {
            get => CourseName;

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
            }
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits 
        {
            get => NumberOfCredits;
            set
            {
                if (value >= 30 || value <= 0)
                {
                    throw new ArgumentException();
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261021_w05
{
    class Lecturer
    {
        private string lecturerFirstName;
        private string lecturerLastName;
        private string lecturerPosition;
        
        public string LecturerFirstName
        {
            get { return this.lecturerFirstName; }
            set { this.lecturerFirstName = value; }
        }
        public string LecturerLastName
        {
            get { return this.lecturerLastName; }
            set { this.lecturerLastName = value; }
        }
        public string LecturerPosition
        {
            get { return this.lecturerPosition; }
            set { this.lecturerPosition = value; }
        }
        
        public Lecturer() { }
        public Lecturer(string lfn, string lln, string lp)
        {
            this.LecturerFirstName = lfn;
            this.LecturerLastName = lln;
            this.LecturerPosition = lp;
         
        }
        public override string ToString()
        {
            return this.LecturerFirstName + " ";

        }
    }
}

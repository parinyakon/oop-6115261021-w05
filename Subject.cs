using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261021_w05
{
    class Subject
    {
        private string subjectCode;
        private string subjectName;
        private string subjectCredit;
        private string subjectDescribe;
        private string subjectPractice;
        
        public string SubjectCode
        {
            get { return this.subjectCode; }
            set { this.subjectCode = value; }
        }
        public string SubjectName
        {
            get { return this.subjectName; }
            set { this.subjectName = value; }
        }
        public string SubjectCredit
        {
            get { return this.subjectCredit; }
            set { this.subjectCredit = value; }
        }
        public string SubjectDescribe
        {
            get { return this.subjectDescribe; }
            set { this.subjectDescribe = value; }
        }
        public string SubjectPractice
        {
            get { return this.subjectPractice; }
            set { this.subjectPractice = value; }
        }     

        public Subject() { }
        public Subject(string sjc, string sjn, string sjcd, string sjd, string sjp)
        {
            this.SubjectCode = sjc;
            this.SubjectName = sjn;
            this.SubjectCredit = sjcd;
            this.SubjectDescribe = sjd;
            this.SubjectPractice = sjp;
           
        }
        public override string ToString()
        {
            return this.SubjectName + " ";
                

        }
    }
}

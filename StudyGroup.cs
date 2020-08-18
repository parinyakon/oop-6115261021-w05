using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261021_w05
{
    class StudyGroup
    {
        private string studyGroupName;
        private string studyGroupDegree;

        public string StudyGroupName
        {
            get { return this.studyGroupName; }
            set { this.studyGroupName = value; }
        }
        public string StudyGroupDegree
        {
            get { return this.studyGroupDegree; }
            set { this.studyGroupDegree = value; }
        }

        public StudyGroup() { }
        public StudyGroup(string sgn, string sgd)
        {
            this.StudyGroupName = sgn;
            this.StudyGroupDegree = sgd;

        }
        public override string ToString()
        {
            return this.StudyGroupName + " ";

        }
    }
}

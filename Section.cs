using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261021_w05
{
    class Section
    {
                           
        private string sectionDay;
        private string sectionStartTime;
        private string sectionEndTime;
        private Room sectionRoom;
        private Subject sectionSubject;
        private Lecturer sectionLecturer;
        

        public string SectionDay
        {
            get { return this.sectionDay; }
            set { this.sectionDay = value; }
        }
        public string SectionStartTime
        {
            get { return this.sectionStartTime; }
            set { this.sectionStartTime = value; }
        }
        public string SectionEndTime
        {
            get { return this.sectionEndTime; }
            set { this.sectionEndTime = value; }
        }
        public void a()
        {
            sectionRoom.RoomName.ToString();
        }
        public void b()
        {
            sectionRoom.RoomBuilding.BuildingName.ToString();
        }
        public void c()
        {
            sectionSubject.SubjectName.ToString();
        }
        public void d()
        {
            sectionLecturer.LecturerFirstName.ToString();
        }


        public Section() { }
        public Section(string sd, string sst, string set, Room str, Subject sts, Lecturer stl)
        {
            
            this.SectionDay = sd;
            this.SectionStartTime = sst;
            this.SectionEndTime = set;
            this.sectionRoom = str;
            this.sectionSubject = sts;
            this.sectionLecturer = stl;
        }
        public override string ToString()
        {
            return this.sectionRoom + " " + "Subject" +
                this.sectionSubject + " " + "Lecturer" +
                this.sectionLecturer + " " +
                this.sectionDay + " " + "time" +
                this.sectionStartTime + " " +
                this.sectionEndTime + " ";

        }
    }
}

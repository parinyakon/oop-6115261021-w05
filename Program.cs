using System;

namespace oop_6115261021_w05
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Building b4 = new Building("4", "Building 4", "11111", "22222");
            Room r433 = new Room("433", "Room 433", "4", "4", "Computer", b4);            
            Subject sj1 = new Subject("9022081", "oop", "3", "5", "10");
            Lecturer l1 = new Lecturer("Nitat", "Ninchawee", "Teacher");
            Section s1 = new Section("Monday", "8.00", "12.00", r433, sj1, l1);
            
            Console.WriteLine(s1);
                       
        }
    }
}

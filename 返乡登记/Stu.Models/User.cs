using System;

namespace Stu.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Destination { get; set; }
        public string Departure_date { get; set; }
        public string Return_date { get; set; }

        public Student() { }//两种构造方法
        public Student(int ID,string name,string destination,string departure_date,string return_date)
        {
            this.ID = ID;
            this.Name= name;
            this.Destination = destination;
            this.Departure_date = destination;
            this.Return_date = return_date;
        }
       }
}

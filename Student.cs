using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDatabase

{
    class Student
    {
        public string Name { get; set; }
        public string HomeTown { get; set; }
        public string FavoriteFood { get; set; }
        public Student(string Name, string HomeTown, string FavoriteFood)
        {

            this.Name = Name;
            this.HomeTown = HomeTown;
            this.FavoriteFood = FavoriteFood;

        }
    }
   }














   
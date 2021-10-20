 using System;
 using System.Collections.Generic;
 
 namespace StudentDatabase
    {
        class program
        {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();

            studentList.Add(new Student("Ramone", "Fort Lauderdale,Fl", "Chicken Soup"));
            studentList.Add(new Student("Marjorie", "Detroit,Mi", "Korean BBQ"));
            studentList.Add(new Student("Huy", "Lansing,Mi", "Chicken Soup"));
            studentList.Add(new Student("Marjorie", "Detroit,Mi", "Korean BBQ"));
            studentList.Add(new Student("Anurag", "Rochester", "Lasagna"));
            studentList.Add(new Student("Calyn", "Portage,Mi", "Tacos"));
            studentList.Add(new Student("Rick", "Gilbert,Az", "Mac and Cheese"));
            studentList.Add(new Student("Codero", "Berkley,Mi", " Hamburger"));
            studentList.Add(new Student("Cullin", "Fowlerville,Mi", "Pad Thai"));
            studentList.Add(new Student("Erin", "Troy,Mi", "Tacos"));
            studentList.Add(new Student("Cortez", "Detroit,Mi", "chicken fettuccine alfredo"));
            
            Console.WriteLine(studentList.Count);


            bool again = true;
            while (again)
            {


                Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (Enter a number 1-10");

                for (int i = 0; i < studentList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {studentList[i].Name}");
                }
                int studentResponse = int.Parse(Console.ReadLine()) - 1;
                bool invalidStudent = true;
                while (invalidStudent)
                {


                    if (studentResponse >= 0 && studentResponse <= studentList.Count - 1)
                        invalidStudent = false;
                    else
                    {
                        Console.WriteLine("That student does not exist. Please try again (enter a number 1-10)");
                        studentResponse = int.Parse(Console.ReadLine()) - 1;
                        invalidStudent = true;
                    }
                }
                bool more = true;
                while (more)
                {

                    string knowMore = "no";
                    Console.WriteLine($"Student {studentResponse + 1} is {studentList[studentResponse].Name}. What would you like to know about {studentList[studentResponse].Name} (enter \"hometown\" or \"favorite food\")");
                    string infoResponse = Console.ReadLine().ToLower();

                    bool askAgain = true;
                    while (askAgain)
                    {


                        if (infoResponse == "hometown")
                        {
                            Console.WriteLine($"{studentList[studentResponse].Name} is from {studentList[studentResponse].HomeTown}. Would you like to know more? (enter \"yes\" or \"no\")");
                            knowMore = Console.ReadLine().ToLower();
                            askAgain = false;
                        }
                        else if (infoResponse == "favorite food")
                        {
                            Console.WriteLine($"{studentList[studentResponse].FavoriteFood} is the favorite food of {studentList[studentResponse].Name}. Would you like to know more? (enter \"yes\" or \"no\")");
                            knowMore = Console.ReadLine().ToLower();
                            askAgain = false;
                        }
                        else
                        {

                            Console.WriteLine("That data does not exist. Please try again. (enter \"hometown\" or \"favorite food\")");
                            infoResponse = Console.ReadLine().ToLower();
                            askAgain = true;
                        }
                    }
                    if (knowMore == "no")
                    {
                        more = false;
                        Console.WriteLine("Thanks!");

                    }
                    else if (knowMore == "yes")
                    {
                        more = true;
                    }
                }
                Console.WriteLine("Would you like to learn about any other class members? (enter \"yes\" or \"no\")");
                string otherMembers = Console.ReadLine().ToLower();
                if (otherMembers == "no")
                {
                    Console.WriteLine("Goodbye");
                    again = false;
                }
                else if (otherMembers == "yes")
                {
                    again = true;
                }
            }


        }
    }
}

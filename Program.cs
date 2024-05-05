using System;
namespace Task_3
{
    public class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");
           User user1 = new User();
            Console.WriteLine("Input gender  - Male, Female, Unknown: ");
            string gender = Console.ReadLine();
            // Gender gender;
            if(Enum.TryParse(gender, out Gender gender1))
            {
                user1.Gender = gender1;
            }
            else
            {
                Console.WriteLine("Invalid input");
                user1.Gender = Gender.Unknown;
            }

            Console.WriteLine("Input 1st  name: ");
            user1.FirstName = Console.ReadLine();

            Console.WriteLine("Input lastname: ");
            user1.LastName = Console.ReadLine();
            

            Console.WriteLine("User info: ");
            Console.WriteLine(user1);

        }
    }
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        private int age;
        public int Age { 
            get { return age; }
            private set
        {
                if (value < 0)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }
    
        public User() 
        { 
           Age = 0;
        }
        public User(int age)
        {
            Age = age;
        }
        public override string ToString()
        {
            if (age > 10)
            {
                return $"Hello, my name is {FirstName}, my surname is {LastName}. I am {age} years old. I am {Gender}";
            }
            else
            {
                return $"My name is {FirstName}, surname {LastName}, gender {Gender} I am baby";
            }

        }

    }
}

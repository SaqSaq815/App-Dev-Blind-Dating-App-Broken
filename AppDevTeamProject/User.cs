using System;

namespace AppDevTeamProject
{
    class User
    {

        // Unique user Identifier
        public int ID { set; get; }

        // User Info to fill in
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int Age { set; get; }
        public int Location { set; get; }
        public string Bio { set; get; }
        public string[] Attributes { set; get; }

        // User logins
        public string Username { set; get; }
        public int Password { set; get; }


        // User preferences
        public string[] Interest { set; get; }


        // Constructor
        public User(int iD, string firstName, string lastName, int age, int location, string bio, string[] attributes, string username, int password, string[] interest)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Location = location;
            Bio = bio;
            Attributes = attributes;
            Username = username;
            Password = password;
            Interest = interest;

        }

    }
}

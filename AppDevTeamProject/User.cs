using System;

namespace AppDevTeamProject
{
    class User
    {

        // Unique user Identifier
        private int ID { set; get; }

        // User Info to fill in
        private string FirstName { set; get; }
        private string LastName { set; get; }
        private int Age { set; get; }
        private int Location { set; get; }
        private string Bio { set; get; }
        private string[] Attributes { set; get; }

        // User logins
        private string Username { set; get; }
        private int Password { set; get; }


        // User preferences
        private string[] Interest { set; get; }


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

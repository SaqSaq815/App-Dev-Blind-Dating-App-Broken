using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevTeamProject
{
    public class Data
    {
        public  User[] data { get; set; }
    }



    public class Database
    {

        public ArrayList members = new ArrayList();

        // Load the initial data
        public void LoadDb()
        {
            var user1 = createNewMember(1, "Jeffrey", "Grospe", 29, "Montreal", "Life is too short", "jgrospe", 1234);
            user1.Traits = new string[] { "Lovely", "Handsome" };
            user1.Likes = new string[] { "Wild", "Sweet" };
            members.Add(user1);

            User user2 = createNewMember(2, "Md Saqliayn", "Islam", 20, "Montreal", "Im a good boy", "mdSaqliyan", 2222);
            user1.Traits = new string[] { "Rich","Hot" };
            user1.Likes = new string[] { "Wild", "Sweet","Erotic" };
            members.Add(user2);

            User user3= createNewMember(2, "Kayla","Rose", 20, "Toronto", "Im hot af", "kRose", 3333);
            user1.Traits = new string[] { "Rich", "Friendly", "Hot" };
            user1.Likes = new string[] {  "Sweet", "Tall" };
            members.Add(user3);

            User user4 = createNewMember(2, "Jas", "Means", 20, "Edmonton", "Im your spicy girl", "JMeans", 4444);
            user1.Traits = new string[] { "Rich", "Friendly", "Hot" };
            user1.Likes = new string[] { "Sweet", "Short" };
            members.Add(user4);
        }

        // Creates and return new usr
        public User createNewMember(int iD, string firstName, string lastName, int age, string location, string bio, string username, int password)
        {
            User user = new User(iD, firstName, lastName, age,location,bio,username,password);
            return user;
        }

        // Add user to the members
        public void insertTomember(User user)
        {
            members.Add(user);
        }

    }

 


    public class UserCharacters
    {
        private string[] interest = { "Lovely", "Friendly", "Rich", "Sweet", "Adventurous", "Wild", "Hot", "Smart", "Super Hot", "Tall", "Short", "Erotic"};

        public string[] getInterest()
        {
            return interest;
        }

        
  
    }
}

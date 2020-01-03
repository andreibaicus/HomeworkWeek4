using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    public class Board 
    {
        private List<Post> posts;
        private List<User> users;

        public Board()
        {
            this.posts = new List<Post>();
            this.users = new List<User>();
        }

        public void addPost(string text, string email, DateTime postDate)
        {
            User user;
            user= GetUser(email);
            if (user == null)
            {
                Console.WriteLine("user doesn't exist");                
            }
            else
            {
                posts.Add(new Post(text, user, postDate));
                Console.WriteLine("{0} -> {1} {2} was added.", text, user.FirstName, user.LastName);                
            }            
        }


        public void getPosts()
        {
            if (posts.Count == 0)
            {
                Console.WriteLine("No posts.");
            }
            else
            {
                sort();
                foreach (Post post in posts)
                {
                    Console.WriteLine("{0} - {1} Author: {2} {3}", post.PostText, post.PostDate, post.User.FirstName, post.User.LastName);
                }
            }
            
        }

        public void sort()
        {
            posts.Sort((x, y) => x.PostDate.CompareTo(y.PostDate));
        }

        public void addUser(string email, string firstName, string lastName, DateTime birthDate)
        {
            User user = new User(email, firstName, lastName, birthDate);
            users.Add(user);
            Console.WriteLine("User-ul a fost adaugat.");
        }

        public void getUsers()
        {
            if (users.Count == 0)
            {
                Console.WriteLine("No users.");
            }
            else
            {
                foreach (User user in users)
                {
                    Console.WriteLine("{0} {1} - {2}, {3}", user.FirstName, user.LastName, user.Email, user.BirthDate);
                }
            }
        }

        public User GetUser(string email)
        {
            foreach (User user in users)
            {
                if (user.Email.Equals(email))
                {
                    return user;
                }
            }
            return null;
        }

    }
}

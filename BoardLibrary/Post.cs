using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    public class Post
    {
        public string PostText { get; private set; }
        public DateTime PostDate { get; private set; }
        public User User { get; private set; }

        public Post(string postText, User user, DateTime postDate)
        {
            this.PostText = postText;
            this.User = new User(user.Email, user.FirstName, user.LastName, user.BirthDate);
            this.PostDate = postDate;
        }

        //public int CompareTo(object obj)
        //{
        //    Post postToCompare = obj as Post;
        //    if (postToCompare.PostDate < PostDate)
        //    {
        //        return 1;
        //    }
        //    if (postToCompare.PostDate > PostDate)
        //    {
        //        return -1;
        //    }

        //    return 0;            
        //}
    }
}

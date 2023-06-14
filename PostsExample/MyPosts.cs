using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostsExample
{
    /// <summary>
    /// מחלקה המחזיקה אוסף של פוסטים של היוזר.
    /// </summary>
    public class MyPosts
    {
        private const int MAX_POSTS = 100;//כמה מקסימום פוסטים מותר למשתמש
        private User user;//היוזר הראשי
        private int totalPosts;//כמות הפוסטים שפורסמו עד כה
        //פוסטים של היוזר
        Post[] posts;

        
        public MyPosts(User user)
        {
            this.user = user;
            //האם למשתמש יש פוסטים כאשר הרשומה נוצרת?

            //כמה פוסטים יש כאשר הרשומה נוצרת?
            totalPosts =0 ;
            posts= new Post[MAX_POSTS];
        }

        public void AddPost(Post post)
        {

            //אם אין לי מונה של פוסטים
            if(totalPosts<posts.Length&&post.GetUser().GetUserName()==user.GetUserName())
            {
                posts[totalPosts] = new Post(post.GetUser(),post.GetMessage());
                totalPosts++;
            }
            //אם יש לי מונה של פוסטים
        }

        //getters....
        public Post[] GetPosts() { Post[] result = new Post[posts.Length];
            for (int i = 0; i < totalPosts; i++)
            {
                result[i]= new Post(posts[i].GetUser(), posts[i].GetMessage());
            }
            return result;
        }

        //setters?

    }
}

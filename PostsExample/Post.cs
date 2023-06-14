using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostsExample
{
    public  class Post
    {
        private User user;
        private string message;

        public Post(User user, string message)
        {
            //לא שומר על עקרון ההכמסה
         //   this.user=user;

            //שומר על עקרון ההכמסה- שומר העתק של היוזר.
            this.user = new User(user.GetUserName(),user.GetPassWord());
            //אופציה נוספת - כתיבת פעולה בונה מעתיקה במחלקת יוזר
           // this.user = new User(user);

            this.message = message; 
        }

        public string GetMessage() { return message; }  
        public void SetMessage(string message) 
        {
            this.message = message;
        }
        public User GetUser() { return user; }
        //User is ReadOnly no Setters...
         public void SetUser(User u) { this.user = u; }    
        public override string ToString()
        {
            return $"user:{user.GetUserName()}:{message}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostsExample
{
    public class User
    {
       private string userName;
       private  string password;

        //פעולה בונה המקבלת שני פרמטרים
        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
        //פעולה בונה מעתיקה המקבלת משתמש אחר ומעתיקה ליוזר הנוכחי את פרטיו
        public User(User user)
        {
            this.userName=user.userName; 
            this.password=user.password;
        }

        public string GetUserName()
        {
            return userName;    
        }

        public string GetPassWord() { return password; }    

        public bool ChangePassWord(string passWord)
        {
            if(password.Length < 4) 
            { return false; }
            
            this.password=passWord; return true;    
        }
    }
}

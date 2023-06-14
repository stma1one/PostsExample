namespace PostsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User u = new User("talsi", "123456");

            Console.WriteLine($"Hello {u.GetUserName()} Please change Password:");
            
            string newPass = Console.ReadLine();
            while (!u.ChangePassWord(newPass))
            {
                Console.WriteLine("Wrong Password");
                newPass = Console.ReadLine();
            }

            Post post = new Post(u, "When do we Go HOME???");
            Console.WriteLine(post);

            newPass = "55544";

            u.ChangePassWord(newPass);
            Console.WriteLine(post.GetUser().GetPassWord());
            MyPosts beutifullposts = new MyPosts(u);
            beutifullposts.AddPost(post);
            Post p = new Post(u, "WHEN DO WE START GITHUB?");
            beutifullposts.AddPost(p);
            p.SetUser(new User("Ofek", "456787"));

            Post[] pst = beutifullposts.GetPosts();
            pst[0] = null;



        }
    }
}
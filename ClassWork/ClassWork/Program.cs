using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {
                User user1 = new User {Name = "ivan" , Age = 32 };
                //commit serg

                db.Users.Add(user1);
                db.SaveChanges();

                var users = db.Users;
                foreach(User n in users)
                {
                    Console.WriteLine("{0} {1} {2}", n.Id, n.Name, n.Age);
                }
            }
            Console.ReadLine();
        }
    }
}

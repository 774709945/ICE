using ICE.DAL;
using ICE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE.App
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlHelper helper = new SqlHelper();

            var user2 = helper.FindById<User>(2);
            var user3 = helper.FindById<User>(3);
            var user4 = helper.FindById<User>(4);


            Console.ReadKey();
        }
    }
}

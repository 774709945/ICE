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
            UserDal dal = new UserDal();

            var user2 = dal.FindById(2);
            var user3 = dal.FindById(3);
            var user4 = dal.FindById(4);


            Console.ReadKey();
        }
    }
}

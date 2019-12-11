using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Model
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string UserPwd { get; set; }

        public DateTime CreateTime { get; set; }

        public int IsDel { get; set; }

        public DateTime? DelTime { get; set; }
    }
}

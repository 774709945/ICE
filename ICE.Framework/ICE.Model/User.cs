using ICE.Framework.DBMapping;
using System;

namespace ICE.Model
{
    [DBTable("Nxp_User")]
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

using ICE.Framework.DB;
using ICE.Model;

namespace ICE.DAL
{
    public class UserDal
    {
        /// <summary>
        /// 根据ID获取人员信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User FindById(int id)
        {
            SqlHelper helper = new SqlHelper();
            var user = helper.FindById<User>(id);
            return user;
        }
    }
}

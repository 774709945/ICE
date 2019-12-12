using System;
using System.Data.SqlClient;

namespace ICE.DAL
{
    /// <summary>
    /// SqlServer数据库访问操作类
    /// </summary>
    public class SqlHelper : BaseSql
    {
        /// <summary>
        /// 根据int32类型的ID获取实体数据信息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public T FindById<T>(int id) where T : new()
        {
            Type tp = typeof(T);

            string sql = $"select * from [{tp.Name}] where Id={id}";

            using (SqlConnection conn = new SqlConnection(base.GetConnectionStr()))
            {
                SqlCommand command = new SqlCommand(sql, conn);

                conn.Open();

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    var props = tp.GetProperties();

                    var resObj = new T();

                    foreach (var prop in props)
                    {
                        prop.SetValue(resObj, reader[prop.Name] is DBNull ? null : reader[prop.Name]);
                    }

                    return resObj;
                }
                else
                {
                    return default(T);
                }
            }
        }
    }
}

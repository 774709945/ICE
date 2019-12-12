using ICE.Framework.DBMapping;
using System;
using System.Data.SqlClient;

namespace ICE.Framework.DB
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

            //缓存优化，提高获取sql语句效率
            string sql = SqlBuilder<T>.GetFindSql() + id;

            using (SqlConnection conn = new SqlConnection(GetConnectionStr()))
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
                        string propName = prop.GetMappingName();//查询时as一下，可以省下一轮

                        prop.SetValue(resObj, reader[propName] is DBNull ? null : reader[propName]);
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

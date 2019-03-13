using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
    public class SelectDAL
    {
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectUI() {
            string sql = string.Format("select * from Product");
            DataTable dt = DBHelper.Select(sql);
            return dt;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static bool UpdataUI(int ID) {
            string sql = string.Format("DELETE FROM Product WHERE Prold ='{0}'",ID);
            return  DBHelper.Update (sql);
            
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sm"></param>
        /// <returns></returns>
        public static bool InsertUI(SelectModel sm) {
            string sql = string.Format("insert into Product values('{0}','{1}','{2}','{3}','{4}')", sm.ProName, sm.ProPic, sm.Price, sm.ProInfo, sm.TypeId );
            return DBHelper.Update(sql);
        }



    }
}

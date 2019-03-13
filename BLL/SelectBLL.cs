using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace BLL
{
    public class SelectBLL
    {
         /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectUI() {
            return SelectDAL.SelectUI();
        }
           /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static bool UpdataUI(int ID) {
            return SelectDAL.UpdataUI(ID);
        }

         /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sm"></param>
        /// <returns></returns>
        public static bool InsertUI(SelectModel sm) {
            return SelectDAL.InsertUI(sm);
        }





    }
}

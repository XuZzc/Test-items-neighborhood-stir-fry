using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
   public  class TypeClassBLL
    {
         /// <summary>
       /// 下拉列表显示
       /// </summary>
       /// <returns></returns>
        public static DataTable TypeClassUI() {
            return TypeClassDAL.TypeClassUI();
        }
    }
}

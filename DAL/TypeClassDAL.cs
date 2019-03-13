using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public  class TypeClassDAL
    {
       /// <summary>
       /// 下拉列表显示
       /// </summary>
       /// <returns></returns>
       public static DataTable TypeClassUI(){
           string sql = string.Format("select * from ProType,Product where ProType.Typeld=Product.Typeld");
           return DBHelper.Select (sql);
       }

    }
}

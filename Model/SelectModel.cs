using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SelectModel
    {
        /// <summary>
        /// 菜品编号
        /// </summary>
        public int Prold { get; set; }
        /// <summary>
        /// 菜品名称
        /// </summary>
        public string ProName { get; set; }
        /// <summary>
        /// 菜品图片
        /// </summary>
        public string ProPic { get; set; }
        /// <summary>
        /// 菜品价格
        /// </summary>
        public double  Price { get; set; }
        /// <summary>
        /// 菜品详情
        /// </summary>
        public string ProInfo { get; set; }
        /// <summary>
        /// 菜品类型
        /// </summary>
        public int TypeId { get; set; }
      

    }
}

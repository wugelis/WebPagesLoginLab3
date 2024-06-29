using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebPagesLoginLab3.Models
{
    /// <summary>
    /// 產品
    /// </summary>
    public class Product
    {
        /// <summary>
        /// 商品編號
        /// </summary>
        public int Number { get; set; }
        [Description("商品名稱：")]
        public string Name { get; set; }
        /// <summary>
        /// 商品說明
        /// </summary>
        public string Description { get; set; }
    }
}

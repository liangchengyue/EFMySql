using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Unit.Dto
{
    public class ListDto<T>
    {
        /// <summary>
        /// 数据集合
        /// </summary>
        public List<T> rows { get; set; }
        /// <summary>
        /// 记录总数
        /// </summary>
        public int results { get; set; }
        /// <summary>
        /// 是否存在错误
        /// </summary>
        public bool hasError { get; set; } = false;
        public string error { get; set; }
    }
}

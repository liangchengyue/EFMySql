﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
   public class Student
    {
        /// <summary>
        /// 学号
        /// </summary>
        public virtual string No { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public virtual string Gender { get; set; }
        /// <summary>
        /// 电话号码    
        /// </summary>
        public virtual string Phone { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public virtual string Address { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public virtual DateTime Birthday { get; set; }
        public virtual ICollection<SC> SCs { get; set; } = new List<SC>();
    }
}

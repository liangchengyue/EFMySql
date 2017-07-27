using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
   public class Course
    {
        /// <summary>
        /// 课程号
        /// </summary>
        public virtual string No { get; set; }
        /// <summary>
        /// 课程名
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// 学分
        /// </summary>
        public virtual float Credit { get; set; }
        /// <summary>
        /// 先行课
        /// </summary>
        public virtual string ParentNo { get; set; }
        
        public virtual Course Parent { get; set; }
        public virtual ICollection<Course> Children { get; set; } = new List<Course>();
        public virtual ICollection<SC> SCs { get; set; } = new List<SC>();
    }
}

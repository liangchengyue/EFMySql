using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
   public class SC
    {
        public virtual string Id { get; set; }
        /// <summary>
        /// 学号
        /// </summary>
        public virtual string StudentNo { get; set; }
        /// <summary>
        /// 课程号
        /// </summary>
        public virtual string CourseNo { get; set; }
        /// <summary>
        /// 成绩
        /// </summary>
        public virtual int Grade { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}

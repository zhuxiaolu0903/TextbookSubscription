namespace TextbookSubscription.ViewModels
{
    using System;

    [Serializable]
    public class NewStudentDeclarationView : BaseViewModel
    {
        /// <summary>
        /// 数据标识
        /// </summary>
        public char DataSign { get; set; }
        
        /// <summary>
        /// 学院名称
        /// </summary>
        public string SchoolName { set; get; }
        
        /// <summary>
        /// 学院ID
        /// </summary>
        public string SchoolID { set; get; }
        
        /// <summary>
        /// 教研室名称
        /// </summary>
        public string DepartmentName { get; set; }
        
        /// <summary>
        /// 班级名称
        /// </summary>
        public string ClassName { get; set; }
        
        /// <summary>
        /// 教研室ID
        /// </summary>
        public string DepartmentID { get; set; }
        
        /// <summary>
        /// 课程ID
        /// </summary>
        public string CourseID { get; set; }
        
        /// <summary>
        /// 课程名称
        /// </summary>
        public string CourseName { get; set; }
        
        /// <summary>
        /// 书名
        /// </summary>
        public string TextbookName { get; set; }
        
        /// <summary>
        /// ISBN
        /// </summary>
        public string Isbn { get; set; }
        
        /// <summary>
        /// 申报数量
        /// </summary>
        public int Count { get; set; }
        
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }
        
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }
        
        /// <summary>
        /// 教材ID
        /// </summary>
        public string TextbookID { get; set; }
        
        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }
        
        /// <summary>
        /// 出版社
        /// </summary>
        public string Press { get; set; }
        
        /// <summary>
        /// 版本
        /// </summary>
        public string Edition { get; set; }
        
        /// <summary>
        /// 版次
        /// </summary>
        public string PrintCount { get; set; }
        
        /// <summary>
        /// 价格
        /// </summary>
        public double Price { get; set; }
        
        /// <summary>
        /// 优选状态
        /// </summary>
        public string Priority { get; set; }

    }
}

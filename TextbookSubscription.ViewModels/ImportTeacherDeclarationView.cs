namespace TextbookSubscription.ViewModels
{
    using System;

    [Serializable]
    public class ImportTeacherDeclarationView : BaseViewModel
    {
        /// <summary>
        /// 申报ID
        /// </summary>
        public string DeclarationID { get; set; }

        /// <summary>
        /// 教材ID
        /// </summary>
        public string TextbookID { get; set; }

        /// <summary>
        /// 数据标识
        /// </summary>
        public char DataSign { get; set; }

        /// <summary>
        /// 学院名称
        /// </summary>
        public string SchoolName { set; get; }

        /// <summary>
        /// 教研室名称
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        public string CourseName { get; set; }

        /// <summary>
        /// 教材名称
        /// </summary>
        public string TextbookName { get; set; }

        /// <summary>
        /// 出版社
        /// </summary>
        public string Press { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// 申报数量
        /// </summary>
        public int DeclarationCount { get; set; }

        /// <summary>
        /// 移动电话
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 导入时间
        /// </summary>
        public DateTime ImportDate { get; set; }

        /// <summary>
        /// 优选状态
        /// </summary>
        public string Priority { get; set; }

        /// <summary>
        /// 需要教材
        /// </summary>
        public char NeedTextbook { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }
    }
}

namespace TextbookSubscription.ViewModels
{
    using System;

    [Serializable]
    class DepartmentView : BaseViewModel
    {
        /// <summary>
        /// 学院ID 
        /// </summary>
        public string SchoolID { get; set; }
        
        /// <summary>
        /// 教研室ID
        /// </summary>
        public string DepartmentID { get; set; }

        /// <summary>
        /// 教研室名称
        /// </summary>
        public string DepartmentName { get; set; }

    }
}

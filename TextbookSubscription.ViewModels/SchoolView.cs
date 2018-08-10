namespace TextbookSubscription.ViewModels
{
    using System;

    [Serializable]
    public class SchoolView : BaseViewModel
    {
        /// <summary>
        /// 学院ID
        /// </summary>
        public string SchoolID { get; set; }
        
        /// <summary>
        /// 学院名称
        /// </summary>
        public string SchoolName { get; set; }
        
    }
}

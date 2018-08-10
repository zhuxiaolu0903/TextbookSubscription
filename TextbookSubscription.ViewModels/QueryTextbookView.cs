namespace TextbookSubscription.ViewModels
{
    using System;

    [Serializable]
    public class QueryTextbookView : BaseViewModel
    {
        /// <summary>
        /// 教材ID
        /// </summary>
        public string TextbookID { get; set; }
        
        /// <summary>
        /// ISBN
        /// </summary>
        public string Isbn { get; set; }
       
        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }
        
        /// <summary>
        /// 版本
        /// </summary>
        public string Edition { get; set;}
        
        /// <summary>
        /// 版次
        /// </summary>
        public string PrintingCount { get; set; }
        
        /// <summary>
        /// 是否是自编
        /// </summary>
        public string IsSelfCompile { get; set; }
       
        /// <summary>
        /// 教材类型
        /// </summary>
        public string TextbookType { get; set; }
    }
}

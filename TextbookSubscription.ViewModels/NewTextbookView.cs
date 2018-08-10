namespace TextbookSubscription.ViewModels
{
    using System;

    [Serializable]
    public class NewTextbookView : BaseViewModel
    {
        /// <summary>
        /// 书名
        /// </summary>
        public string TextbookName { get; set; }
        
        /// <summary>
        /// ISBN
        /// </summary>
        public string Isbn { get; set; }
        
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
        public string PrintingCount { get; set; }
        
        /// <summary>
        /// 价格
        /// </summary>
        public double Price { get; set; }
        
        /// <summary>
        /// 是否是自编
        /// </summary>
        public string IsSelfCompile { get; set; }
        
        /// <summary>
        /// 教材类型
        /// </summary>
        public string TextbookType { get; set; }
        
        /// <summary>
        /// 译者
        /// </summary>
        public string Translator { get; set; }
        
        /// <summary>
        /// 内容简介
        /// </summary>
        public string Summary { get; set; }
        
        /// <summary>
        /// 页数
        /// </summary>
        public int Page { get; set; }
        
        /// <summary>
        /// 目录
        /// </summary>
        public string Catalog { get; set; }
        
        /// <summary>
        /// 出版日期
        /// </summary>
        public string PublicationDate { get; set; }
    }
}

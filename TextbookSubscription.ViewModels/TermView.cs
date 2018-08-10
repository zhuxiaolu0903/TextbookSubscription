namespace TextbookSubscription.ViewModels
{
    using System;

    [Serializable]
    public class TermView : BaseViewModel
    {
        /// <summary>
        /// 学期ID
        /// </summary>
        public int TermID { get; set; }
        
        /// <summary>
        /// 学期名称
        /// </summary>
        public string Term { get; set; }
        
    }
}

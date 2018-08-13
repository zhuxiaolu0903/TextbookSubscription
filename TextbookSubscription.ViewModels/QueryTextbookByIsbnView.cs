namespace TextbookSubscription.ViewModels
{
    using System;

    [Serializable]
    public class QueryTextbookByIsbnView : BaseViewModel
    {
        /// <summary>
        /// 教材ID
        /// </summary>
        public string TextbookID { get; set; }

        /// <summary>
        /// 教材名称
        /// </summary>
        public string TextbookName { get; set; }

        /// <summary>
        /// ISBN
        /// </summary>
        public string Isbn { get; set; }
    }
}

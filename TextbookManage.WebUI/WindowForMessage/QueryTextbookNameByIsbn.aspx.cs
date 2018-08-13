using System;
using System.Collections;
using System.Collections.Generic;
using TextbookSubscription.ViewModels;

namespace TextbookManage.WebUI.WindowForMessage
{
    public partial class QueryTextbookName : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DoBind();
        }

        public void DoBind()
        {
            IList<QueryTextbookByIsbnView> list = new List<QueryTextbookByIsbnView>();
            list.Add(new QueryTextbookByIsbnView()
            {
                TextbookID = "0",
                TextbookName = "数据库原理与技术",
                Isbn = "1111111111",
            });
            list.Add(new QueryTextbookByIsbnView()
            {
                TextbookID = "1",
                TextbookName = "数据库原理与技术",
                Isbn = "1111111111",
            });
            list.Add(new QueryTextbookByIsbnView()
            {
                TextbookID = "2",
                TextbookName = "数据库原理与技术",
                Isbn = "1111111111",
            });
            list.Add(new QueryTextbookByIsbnView()
            {
                TextbookID = "3",
                TextbookName = "数据库原理与技术",
                Isbn = "1111111111",
            });

            GdQueryTextbook.DataSource = list;
        }
    }
}
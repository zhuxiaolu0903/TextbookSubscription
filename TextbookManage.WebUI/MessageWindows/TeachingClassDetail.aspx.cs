using System;
using TextbookSubscription.Infrastructure;
using TextbookSubscription.IApplication;


namespace TextbookManage.WebUI.MessageWindows
{
    public partial class TeachingClassDetail : CPMis.Web.WebControls.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!string.IsNullOrWhiteSpace(Request.QueryString["TeachingClassNum"]))
            //{
            //    cgrdProfessionalClasses.DoDataBind();
            //}

        }


        //protected void cgrdProfessionalClasses_BeforeDataBind(object sender, EventArgs e)
        //{
        //    string num = Request.QueryString["TeachingClassNum"];

        //    //cgrdProfessionalClasses.DataSource = _impl.GetProfessionalClassByTeachingTaskNum(num);

        //}
    }
}
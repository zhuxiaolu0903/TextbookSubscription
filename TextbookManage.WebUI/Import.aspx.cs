using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace TextbookManage.WebUI.Tb_Maintain.Tb_Maintain_1
{
    public partial class Import : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void BtnUpload_Click(object sender, EventArgs e)
        {
            String savePath = Server.MapPath("~/ExcelName/");
            if (FileUpload1.HasFile)
            {
                String fileName = FileUpload1.FileName;
                savePath += fileName;
                FileUpload1.SaveAs(savePath);
                LabMessage1.Text = fileName + "文件上传成功";
            }
            else
            {
                LabMessage1.Text = "文件上传失败";
            }
        }
    }
 }


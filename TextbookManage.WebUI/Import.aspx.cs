using System;
using System.IO;

namespace TextbookManage.WebUI
{
    public partial class Import : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnUploadBtnClicked(object sender, EventArgs e)
        {
            String savePath = Server.MapPath("~/Upload/");
            using (var fileStream = File.Create(savePath+"申报计划.xlsx"))
            {
                if (rAsyncFileUpload.AutoAddFileInputs)
                {
                    var uploadedFileStream = rAsyncFileUpload.UploadedFiles[0].InputStream;
                    uploadedFileStream.Seek(0, SeekOrigin.Begin);
                    uploadedFileStream.CopyTo(fileStream);
                    UploadMassage.Text = "文件上传成功";
                }
                else
                {
                    UploadMassage.Text = "文件上传失败";
                }
            }
        }

    }
 }


using System;
using System.Collections.Generic;
using CPMis.Web.WebControls;
using Telerik.Web.UI;
using TextbookSubscription.ViewModels;
using TextbookSubscription.IApplication;
using TextbookSubscription.Infrastructure.ServiceLocators;
using System.Web.UI.WebControls;
using System.Data;

namespace TextbookManage.WebUI
{
    public partial class ImportDeclaration : System.Web.UI.Page
    {
        private ITermAppl _appl = ServiceLocator.Current.GetInstance<ITermAppl>();


        /// <summary>
        /// 页面加载方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GdStudentDeclare.DoDataBind();
                //学年学期视图
                ComBoxTerm_Student();
                ComBoxTerm_Teacher();
                GdTeacherDeclare.DoDataBind();

            }
        }

        /// <summary>
        /// 获取学生界面学年学期的下拉框数据
        /// </summary>
        protected void ComBoxTerm_Student()
        {
            var list = _appl.GetAll();
            cmb_STerm.DataSource = list;
            cmb_STerm.DataBind();
        }

        /// <summary>
        /// 获取教师界面学年学期的下拉框数据
        /// </summary>
        protected void ComBoxTerm_Teacher()
        {

            var list = _appl.GetAll();
            cmb_TTerm.DataSource = list;
            cmb_TTerm.DataBind();
        }

        /// <summary>
        /// 处理AJAX请求
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void RadAjaxManager1_OnAjaxRequest(object sender, AjaxRequestEventArgs e)
        {
            var argument = e.Argument;
            switch (argument)
            {
                case "Delete":
                    //DeleteTextbook();
                    break;
                case "Help":
                    //OpenHelpFile("/Help/SystemManage/系统管理.htm");
                    break;
                default:
                    GdStudentDeclare.DoDataBind();
                    break;
            }
        }

        /// <summary>
        /// 保留CheckBox的状态
        /// </summary>
        private void SaveCheckedState()
        {
            //GdStudentDeclare.PersistCheckState<TextbookView>();
        }

        /// <summary>
        /// 打开新窗口方法一，有参数
        /// </summary>
        /// <param name="url"></param>
        /// <param name="textbookId"></param>
        private void OpenNewWindow(string url, string textbookId)
        {
            var path = $"{url}?TextbookId={textbookId}";
            CPMis.Web.WebClient.ScriptManager.OpenRadWindow(path, "RadWindow1");
        }

        /// <summary>
        /// 打开新窗口方法二，没有参数
        /// </summary>
        /// <param name="url"></param>
        private void OpenNewWindow(string url)
        {
            CPMis.Web.WebClient.ScriptManager.OpenRadWindow(url, "ImportRadWindow");
        }

        /// <summary>
        /// 点击查询按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnQuery_OnClick(object sender, EventArgs e)
        {

            var Sdata = cmb_STerm.DataSource;
            var Tdata = cmb_TTerm.DataSource;
            //GdStudentDeclare.DoDataBind();
        }


        /// <summary>
        /// Grid数据绑定之前的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GdStudentDeclare_OnBeforeDataBind(object sender, EventArgs e)
        {
            IList<ImportStudentDeclarationView> list = new List<ImportStudentDeclarationView>();
            list.Add(new ImportStudentDeclarationView()
            {
                DeclarationID = "1",
                TextbookID = "1",
                DataSign = "本部",
                SchoolName = "计算机学院",
                DepartmentName = "软件工程",
                ClassName = "04班",
                CourseName = "数据库原理与技术",
                TextbookName = "SQL Server",
                Press = "清华大学出版社",
                Price = 12.3,
                DeclarationCount = 100,
                Mobile = "1586752553",
                ImportDate = DateTime.Now,
                ApprovalStatus = "未审核",
                Priority = "优选",
                NeedTextbook = "是",
                Remarks = ""
            });
            GdStudentDeclare.DataSource = list;
        }

        /// <summary>
        /// 单元格链接事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GdStudentDeclare_OnItemCommand(object sender, GridCommandEventArgs e)
        {
            var key = e.CommandName;
            if (!(e.Item is GridDataItem)) return;
            var dataItem = (GridDataItem)e.Item;
            var id = dataItem["TextbookId"].Text;
            var isNotNull = !string.IsNullOrWhiteSpace(id);
            var isNotEmpty = !string.Equals(id, Guid.Empty.ToString());
            if (key.Equals("ShowTextbook") && isNotNull && isNotEmpty)//显示教材详情
            {
                OpenNewWindow("MessageWindows/TextbookDetailMessage.aspx", id);
            }
            if (key.Equals("ShowClass"))
            {
                CPMis.Web.WebClient.ScriptManager.OpenRadWindow("MessageWindows/TeachingClassDetail.aspx", "ImportRadWindow");
            }
        }

        /// <summary>
        /// 页面索引改变之前的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GdStudentDeclare_OnBeforePageIndexChanged(object sender, EventArgs e)
        {
            SaveCheckedState();
        }

        /// <summary>
        /// CheckBox状态改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ChkAll_OnCheckedChanged(object sender, EventArgs e)
        {
            var control = sender as CPMisCheckBox;
            var isChecked = control.Checked;
            GdStudentDeclare.SetAllCheckControlState(isChecked);
        }


        protected void GdTeacherDeclare_OnBeforeDataBind(object sender, EventArgs e)
        {
            IList<ImportStudentDeclarationView> list = new List<ImportStudentDeclarationView>();
            GdTeacherDeclare.DataSource = list;
            DataTable dt = new DataTable();



            dt.Columns.Add("DeclarationID");

            dt.Columns.Add("TextbookId");

            dt.Columns.Add("SchoolName");

            dt.Columns.Add("DepartmentName");

            dt.Columns.Add("CourseName");

            dt.Columns.Add("TextbookName");

            dt.Columns.Add("Press");

            dt.Columns.Add("Price");

            dt.Columns.Add("Mobile");

            dt.Columns.Add("ImportDate");

            dt.Columns.Add("ApprovalStatus");

            dt.Columns.Add("Priority");

            dt.Columns.Add("DataSign");

            dt.Columns.Add("NeedTextbook");

            dt.Columns.Add("Remarks");



            if (dt.Rows.Count == 0)

            {

                dt.Rows.Add(dt.NewRow());

            }



            GdTeacherDeclare.DataSource = dt;

            GdTeacherDeclare.DataBind();
            int columnCount = dt.Columns.Count;
        }

    }
}
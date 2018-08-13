using CPMis.Collections;
using System;
using System.Collections;
using System.Web;

//添加引用



namespace TextbookManage.WebUI.Tb_Maintain.Tb_Maintain_1
{
    public partial class TextbookAdd : CPMis.Web.WebControls.Page
    {
       
        private readonly string _loginName = "46010";
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    //取教材ID
            //    TextbookId = Request.QueryString["Id"];
            //    TextbookId = Server.UrlDecode(TextbookId);
            //    //绑定数据
            //    //BindTextbookData();
            //}
            ResetForm();
        }

        #region 私有方法

        /// <summary>
        /// 教材ID
        /// </summary>
        //private string DeclarationId
        //{
        //    get => ViewState["DeclarationId"].ToString(); //ViewSate将数据存储在ViewState，不占用服务器资源
        //    set => ViewState["DeclarationId"] = value;
        //}

        ///// <summary>
        ///// 是否为编辑
        ///// </summary>
        //private bool IsModify => !string.IsNullOrWhiteSpace(TextbookId);
        ///// <summary>
        ///// 教材ID是否为空
        ///// </summary>
        //private bool IsNotNull => !string.IsNullOrWhiteSpace(TextbookId);
        ///// <summary>
        ///// 教材ID是否等于空GUID
        ///// </summary>
        //private bool IsNotEmpty => !string.Equals(TextbookId, Guid.Empty.ToString());

        /// <summary>
        /// 清空表单的信息
        /// </summary>
        private void ResetForm()
        {
            //DeclarationId = Guid.Empty.ToString();

            ctxtTextbookName.Text = string.Empty;       //教材名称
            ctxtISBN.Text = string.Empty;              //isbn
            ctxtPrice.Text = "1.00";        //零售
            ArrayList list2 = new ArrayList();
            list2.Add("优选");
            list2.Add("备选");
            cmbPreferredState.DataSource = list2;
            cmbPreferredState.DataBind();
            ArrayList list = new ArrayList();
            list.Add("未审核");
            list.Add("书商已审核");
            cmbAuditStatus.DataSource = list;
            cmbAuditStatus.DataBind();
            ArrayList list3 = new ArrayList();
            list3.Add("是");
            list3.Add("否");
            cmbNeedTextbook.DataSource = list3;
            cmbNeedTextbook.DataBind();
        }

        //private void SetForm(TextbookView book)
        //{
        //    if (object.Equals(book, null)) return;

        //    TextbookId = book.TextbookId;

        //    ctxtTextbookName.Text = book.Name;       //教材名称
        //    ctxtISBN.Text = book.Isbn;              //isbn
        //    ctxtRetailPrice.Text = book.Price;        //零售价
        //    ctxtAuthor.Text = book.Author;    //作者
        //    ctxtPress.Text = book.Press;     //出版社
        //    ctxtPressAddress.Text = "北京";//出版社地址
        //    ctxtEdition.Text = book.Edition;     //版本
        //    ctxtPrintingCount.Text = book.PrintCount;    //版次
        //    ctxtPage.Text = "1";   //页数
        //    ctxtType.Text = book.TextbookType;   //教材类型
        //    chkIsSelfCompile.Checked = book.IsSelfCompile; //是否自编教材
        //    ctxtPublishDate.SelectedDate = DateTime.Now; //出版日期
        //}

        /// <summary>
        /// 提取表单信息
        /// </summary>
        /// <returns></returns>
        //private TextbookView GetForm()
        //{

        //    return new TextbookView
        //    {
        //        TextbookId = TextbookId,
        //        Name = ctxtTextbookName.Text.Trim(),       //教材名称
        //        Isbn = ctxtISBN.Text.Trim(),              //isbn
        //        Price = ctxtRetailPrice.Text.Trim(),        //零售价
        //        Author = ctxtAuthor.Text.Trim(),    //作者
        //        //PressId = ccmbPress.SelectedValue,
        //        Press = ctxtPress.Text.Trim(),     //出版社
        //        //PressAddress = ctxtPressAddress.Text.Trim(),//出版社地址
        //        Edition = ctxtEdition.Text.Trim(),   //版本
        //        PrintCount = ctxtPrintingCount.Text.Trim(),    //版次
        //        PageCount = ctxtPage.Text.Trim(),   //页数
        //        TextbookType = ctxtType.Text.Trim(),   //教材类型
        //        IsSelfCompile = chkIsSelfCompile.Checked,//自编
        //        PublishDate = ctxtPublishDate.SelectedDate.ToString()  //出版日期
        //    };
        //}

        //private void BindTextbookData()
        //{
        //    //检查id
 
        //    //存在，加载数据
        //    if (IsModify && IsNotEmpty && IsNotNull)
        //    {
        //        var data = _impl.GetById(TextbookId);
        //        SetForm(data);
        //    }
        //    else  //不存在，重置表单
        //    {
        //        ResetForm();
        //    }
        //}
        #endregion


        #region 按钮点击

        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void cbtnCancle_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        /// <summary>
        /// 提交按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //protected void cbtnSubmit_Click(object sender, EventArgs e)
        //{
        //    //输入数据验证状态
        //    if (!IsValid) return;
        //    //取输入
        //    var view = GetForm();
        //    //依据是否编辑，完成编辑或新增
        //    ResponseView result;

        //    if (IsModify && IsNotNull && IsNotEmpty)
        //    {
        //        result = _impl.Modify(view);
        //    }
        //    else 
        //    {
        //        result = _impl.Add(view);
        //    }
        //    //显示结果信息
        //    CPMis.Web.WebClient.ScriptManager.AlertAndClose(result.Message);
        //}


        ///// <summary>
        ///// 点击后事件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //protected void cbtnSubmit_AfterClick(object sender, EventArgs e)
        //{
        //    CPMis.Web.WebClient.ScriptManager.ExecuteJs("Sys.Application.add_load(CloseAndRebind);");
        //}

        /// <summary>
        /// 查询按钮点击事件
        /// </summary>
        protected void cbtnQueryTextbookByIsbn(object sender, EventArgs e)
        {
            String TextbookIsbn = ctxtISBN.Text;
            CPMis.Web.WebClient.ScriptManager.OpenRadWindow("WindowForMessage/QueryTextbookNameByIsbn.aspx", "RadWindow1");

        }
        #endregion




    }
}
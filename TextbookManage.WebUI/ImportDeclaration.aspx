<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImportDeclaration.aspx.cs" Inherits="TextbookManage.WebUI.ImportDeclaration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <telerik:RadStyleSheetManager runat="server" ID="RadStyleSheetManager1">
        </telerik:RadStyleSheetManager>
        <telerik:RadScriptManager ID="RadScriptManager" runat="server">
        </telerik:RadScriptManager>
        <telerik:RadSkinManager ID="RadSkinManager" runat="server">
        </telerik:RadSkinManager>
        <telerik:RadToolTipManager ID="RadToolTipManager" runat="server" AutoTooltipify="true">
        </telerik:RadToolTipManager>
        <telerik:RadFormDecorator ID="RadFormDecorator" runat="server" DecoratedControls="All"></telerik:RadFormDecorator>

        <%--脚本块，放置JS代码--%>
        <telerik:RadCodeBlock ID="RadCodeBlock" runat="server">

            <script type="text/javascript">
                //如果点击的是导出按钮则将AJAX禁用
                function onRequestStart(sender, args) {
                    if (args.get_eventTarget().indexOf("ExportToExcelButton") >= 0 ||
                        args.get_eventTarget().indexOf("ExportToWordButton") >= 0 ||
                        args.get_eventTarget().indexOf("ExportToPdfButton") >= 0 ||
                        args.get_eventTarget().indexOf("ExportToCsvButton") >= 0) {

                        args.set_enableAjax(false);
                    }
                }
                //工具栏
                function OnToolBarButtonClicked(sender, args) {
                    var button = args.get_item();
                    var command = button.get_commandName();
                    var a = true;
                    if (command == "Add") {
                        var oWnd = $find("<%=RadWindow1.ClientID%>");
                        //oWnd.setUrl(encodeURI("AddDeclaration.aspx?Id=" + "")); 
                        oWnd.setUrl(encodeURI("MessageWindows/AddDeclaration.aspx"));
                        oWnd.show();
                        args.set_cancel(true);
                    }
                    else if (command == "Import") {
                        var oWnd = $find("<%=ImportRadWindow.ClientID%>");
                        oWnd.setUrl(encodeURI("Import.aspx"));
                        oWnd.show();
                        args.set_cancel(true);
                    }
                    else if (command == "Help") {
                        refreshGrid("Help");
                        args.set_cancel(true);
                    }
                }
                //异步回调,刷新Grid
                function refreshGrid(arg) {
                    $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest(arg);
                }
            </script>
        </telerik:RadCodeBlock>

        <%--AJAX放置处--%>
        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server" DefaultLoadingPanelID="RadAjaxLoadingPanel1" UpdatePanelsRenderMode="Inline"
            OnAjaxRequest="RadAjaxManager1_OnAjaxRequest">
            <ClientEvents OnRequestStart="onRequestStart" />
            <AjaxSettings>
                <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="GdStudentDeclare" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="GdStudentDeclare">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="GdStudentDeclare" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
            </AjaxSettings>
        </telerik:RadAjaxManager>
        <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server">
        </telerik:RadAjaxLoadingPanel>




        <div>
            <%--顶部工具栏--%>
            <cp:CPMisToolBar ID="ToolBar1" OnClientButtonClicking="OnToolBarButtonClicked" runat="server" SkinID="ToolBarSkin">
                <Items>
                    <telerik:RadToolBarButton Text="新建" CommandName="Add" ToolTip="新建申报" ImageUrl="../../Img/tlb_Add.png">
                    </telerik:RadToolBarButton>
                    <telerik:RadToolBarButton Text="导入" CommandName="Import" ToolTip="点击导入Excel" ImageUrl="../../Img/tlb_import.png">
                    </telerik:RadToolBarButton>
                    <telerik:RadToolBarButton Text="帮助" CommandName="Help" ToolTip="点击获取帮助" ImageUrl="../../Img/tlb_Help.png">
                    </telerik:RadToolBarButton>
                </Items>
            </cp:CPMisToolBar>

            <%--页面标签的标题--%>
            <cp:CPMisTabStrip ID="TabStrip" runat="server" MultiPageID="MpTextbookManage">
                <Tabs>
                    <cp:CPMisTab Text="学生申报(S)" AccessKey="S" PageViewID="GdStudentImport">
                    </cp:CPMisTab>
                    <cp:CPMisTab Text="教师申报(T)" AccessKey="T" PageViewID="GdTeacherImport">
                    </cp:CPMisTab>
                </Tabs>
            </cp:CPMisTabStrip>

            <%--页面标签对应的页面集合--%>
            <cp:CPMisMultiPage ID="MpTextbookManage" runat="server" SkinID="Auto">

                <%--页面标签对应的某一个页面--%>

                <cp:CPMisPageView ID="GdStudentImport" runat="server">
                    <%--查询--%>
                    <div id="div3" runat="server" style="padding-left: 5px; padding-top: 2px; text-align: left; background-color: #E1EBF7;">
                        <cp:CPMisLabel ID="CPMisLabel4" runat="server" Text="学年学期：" SkinID="AutoSize"></cp:CPMisLabel>&nbsp;&nbsp;
                        <cp:CPMisComboBox runat="server" ID="cmb_STerm" AutoPostBack="True"
                            DataTextField="Term" DataValueField="TermID" DefaultIndex="0" IsCancelDataBind="False"
                            IsMaintainSelectedValue="true" SelectedText="" SkinID="btnLogin">
                        </cp:CPMisComboBox>
                        
                        <cp:CPMisButton runat="server" ID="cbtnQuery" Text="查询" OnClick="BtnQuery_OnClick"></cp:CPMisButton>
                    </div>
                    <%--学生申报查询结果"--%>
                    <cp:CPMisGrid ID="GdStudentDeclare" runat="server" SkinID="AutoPages"
                        OnBeforeDataBind="GdStudentDeclare_OnBeforeDataBind" OnItemCommand="GdStudentDeclare_OnItemCommand"
                        OnBeforePageIndexChanged="GdStudentDeclare_OnBeforePageIndexChanged">
                        <MasterTableView>
                            <Columns>
                                <%--序号--%>
                                <telerik:GridTemplateColumn HeaderText="序号" HeaderStyle-Width="40px">
                                    <ItemTemplate><%#Container .DataSetIndex +1 %></ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <%--数据列--%>
                                <telerik:GridBoundColumn DataField="DeclarationID" UniqueName="DeclarationID" Visible="false"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="SchoolID" UniqueName="SchoolId" Visible="false"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="学院名称" DataField="SchoolName" HeaderStyle-Width="80px"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="教研室名称" DataField="DepartmentName"  HeaderStyle-Width="80px"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="课程名称" DataField="CourseName" HeaderStyle-Width="80px"></telerik:GridBoundColumn>
                                <telerik:GridTemplateColumn HeaderText="班级" >
                                    <ItemTemplate>
                                        <cp:CPMisLinkButton ID="LnkShowClass" Text='<% #Eval("ClassName") %>'  CommandName="ShowClass" runat="server"></cp:CPMisLinkButton>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn HeaderText="书名" HeaderStyle-Width="120px">
                                    <ItemTemplate>
                                        <cp:CPMisLinkButton ID="LnkShowTextbook" Text='<% #Eval("TextbookName") %>'  CommandName="ShowTextbook" runat="server"></cp:CPMisLinkButton>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridBoundColumn HeaderText="出版社" DataField="Press" HeaderStyle-Width="80px"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="价格" DataField="Price"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="电话" DataField="Mobile" HeaderStyle-Width="80px"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="导入时间" DataField="ImportDate" HeaderStyle-Width="120px"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="审核状态" DataField="ApprovalStatus"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="优选状态" DataField="Priority"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="数据标识" DataField="DataSign"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="需要教材" DataField="NeedTextbook"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="备注" DataField="Remarks"></telerik:GridBoundColumn>
                            </Columns>
                        </MasterTableView>
                    </cp:CPMisGrid>
                 </cp:CPMisPageView>





                <%--  <%--教师申报查询结果 --%>
                <cp:CPMisPageView ID="GdTeacherImport" runat="server">

                    <%--查询部分--%>
                    <div id="div1" runat="server" style="padding-left: 5px; padding-top: 2px; text-align: left; background-color: #E1EBF7;">
                        <cp:CPMisLabel ID="CPMisLabel1" runat="server" Text="学年学期：" SkinID="AutoSize"></cp:CPMisLabel>&nbsp;&nbsp;
                        <cp:CPMisComboBox runat="server" ID="cmb_TTerm" AutoPostBack="True"
                            DataTextField="Term" DataValueField="TermID" DefaultIndex="0" IsCancelDataBind="False"
                            IsMaintainSelectedValue="False" SelectedText="" SkinID="btnLogin">
                        </cp:CPMisComboBox>
                        <cp:CPMisButton runat="server" ID="CPMisButton1" Text="查询" OnClick="BtnQuery_OnClick"></cp:CPMisButton>
                    </div>
                    <%--教师申报查询结果"--%>
                    <cp:CPMisGrid ID="GdTeacherDeclare" runat="server" SkinID="AutoPages" GridLines="None" AllowSorting="True" AllowPaging="True"
                        OnBeforeDataBind="GdTeacherDeclare_OnBeforeDataBind" OnItemCommand="GdStudentDeclare_OnItemCommand"
                        OnBeforePageIndexChanged="GdStudentDeclare_OnBeforePageIndexChanged">
                        <MasterTableView>
                            <Columns>
                                <%--序号--%>
                                <telerik:GridTemplateColumn HeaderText="序号" HeaderStyle-Width="40px">
                                    <ItemTemplate><%#Container .DataSetIndex +1 %></ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <%--数据列--%>
                                <telerik:GridBoundColumn DataField="DeclarationID" UniqueName="DeclarationID" Visible="false"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="TextbookID" UniqueName="TextbookId" Visible="false"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="学院名称" DataField="SchoolName" HeaderStyle-Width="80px"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="教研室名称" DataField="DepartmentName" HeaderStyle-Width="80px"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="课程名称" DataField="CourseName" HeaderStyle-Width="80px"></telerik:GridBoundColumn>
                                <telerik:GridTemplateColumn HeaderText="书名" HeaderStyle-Width="120px">
                                    <ItemTemplate>
                                        <cp:CPMisLinkButton ID="LnkShowTextbook" Text='<% #Eval("TextbookName") %>' CommandName="ShowTextbook" runat="server"></cp:CPMisLinkButton>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridBoundColumn HeaderText="出版社" DataField="Press" HeaderStyle-Width="80px"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="价格" DataField="Price"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="电话" DataField="Mobile" HeaderStyle-Width="80px"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="导入时间" DataField="ImportDate" HeaderStyle-Width="120px"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="审核状态" DataField="ApprovalStatus"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="优选状态" DataField="Priority"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="数据标识" DataField="DataSign"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="需要教材" DataField="NeedTextbook"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="备注" DataField="Remarks"></telerik:GridBoundColumn>
                            </Columns>
                        </MasterTableView>
                    </cp:CPMisGrid>

                </cp:CPMisPageView>
            </cp:CPMisMultiPage>

            <%--弹窗管理器--%>
            <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                <Windows>
                    <telerik:RadWindow ID="RadWindow1" runat="server" Top="150" Left="400" Width="800" Height="380">
                    </telerik:RadWindow>
                    <telerik:RadWindow ID="ImportRadWindow" runat="server" Top="150" Left="400" Width="300" Height="180">
                    </telerik:RadWindow>
                </Windows>
            </telerik:RadWindowManager>

        </div>
    </form>
</body>
</html>

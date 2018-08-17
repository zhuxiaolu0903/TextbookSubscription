<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryTextbookNameByIsbn.aspx.cs" Inherits="TextbookManage.WebUI.MessageWindows.QueryTextbookName" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <telerik:RadStyleSheetManager runat="server" ID="RadStyleSheetManager1">
        </telerik:RadStyleSheetManager>
        <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        </telerik:RadScriptManager>
        <telerik:RadSkinManager ID="RadSkinManager1" runat="server">
        </telerik:RadSkinManager>
        <telerik:RadFormDecorator ID="RadFormDecorator1" runat="server" DecoratedControls="All">
        </telerik:RadFormDecorator>
        <div>
             <cp:CPMisGrid ID="GdQueryTextbook" runat="server" SkinID="AutoPages">
                        <MasterTableView>
                              <Columns>
                                <%--序号--%>
                                <telerik:GridTemplateColumn HeaderText="序号" HeaderStyle-Width="40px">
                                    <ItemTemplate><%#Container .DataSetIndex +1 %></ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <%--数据列--%>
                                <telerik:GridBoundColumn DataField="TextbookID" UniqueName="TextbookID" Visible="false"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="教材名称" UniqueName="TextbookName" Visible="false"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn HeaderText="ISBN" DataField="ISBN" HeaderStyle-Width="80px"></telerik:GridBoundColumn>
                            </Columns>
                        </MasterTableView>
              </cp:CPMisGrid>
        </div>
    </form>
</body>
</html>

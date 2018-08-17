<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeachingClassDetail.aspx.cs" Inherits="TextbookManage.WebUI.MessageWindows.TeachingClassDetail" %>
<%@ OutputCache Duration="60" VaryByParam="TeachingClassNum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link href="../App_Themes/CPMisTheme/CPMisTable.css" type="text/css" rel="Stylesheet" />
    <link href="../App_Themes/CPMisTheme/style.css" type="text/css" rel="Stylesheet" />
    <title>教学班详细信息</title>
    <style>
        .box{
            border:1px solid #ffffff;
            width:400px;
            height:400px;
            padding-top:20px;
        }
        table{
            width:380px;
            font-size:14px;
            border:1px solid #ffffff;
        }
        table tr td.key{
            width:30%;
            text-align:center;
            border:1px solid #ffffff;
        }
         table tr td.value{
            width:70%;
            text-align:center;
              border:1px solid #ffffff;
        }

    </style>
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
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <telerik:RadSkinManager ID="RadSkinManager1" runat="server">
        </telerik:RadSkinManager>
        <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        </telerik:RadScriptManager>
        <div class="box">
            <table  border="1"  cellpadding:"0" cellspacing:"0">
                <tr>
                    <td class="key">
                        <cp:CPMisLabel runat="server">班级编号：</cp:CPMisLabel>
                    </td>
                    <td class="value">
                        <cp:CPMisLabel runat="server">123456</cp:CPMisLabel>
                    </td>
                </tr>
                <tr>
                    <td class="key">
                        <cp:CPMisLabel runat="server">班级名称：</cp:CPMisLabel>
                    </td>
                    <td class="value">
                         <cp:CPMisLabel runat="server">04班</cp:CPMisLabel>
                    </td>
                </tr>
                <tr>
                    <td class="key">
                        <cp:CPMisLabel runat="server">申报人数：</cp:CPMisLabel>
                    </td>
                    <td class="value">
                        <cp:CPMisLabel runat="server">12345</cp:CPMisLabel>
                    </td>
                </tr>
            </table>
            <%--<cp:CPMisGrid runat="server" ID="cgrdProfessionalClasses" SkinID="NoExport" 
                Height="220px" Width="350px">
                <MasterTableView>
                    <Columns>
                        <telerik:GridTemplateColumn HeaderText="序号" HeaderStyle-Width="40px">
                            <ItemTemplate>
                                <%#Container .DataSetIndex +1 %>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>
                        <telerik:GridBoundColumn HeaderText="班级编号" DataField="Num" >
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn HeaderText="班级名称" DataField="Name" >
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn HeaderText="班级人数" DataField="StudentCount" >
                        </telerik:GridBoundColumn>
                    </Columns>
                </MasterTableView>
            </cp:CPMisGrid>--%>
        </div>
    </form>
</body>
</html>

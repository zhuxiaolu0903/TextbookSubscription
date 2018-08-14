<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddDeclaration.aspx.cs" Inherits="TextbookManage.WebUI.Tb_Maintain.Tb_Maintain_1.TextbookAdd" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>教材</title>
</head>
<body>
    <form id="form1" runat="server">
        <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server">
        </telerik:RadStyleSheetManager>
        <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        </telerik:RadScriptManager>
        <telerik:RadSkinManager ID="RadSkinManager1" runat="server">
        </telerik:RadSkinManager>
        <telerik:RadToolTipManager ID="RadToolTipManager1" runat="server" AutoTooltipify="true">
        </telerik:RadToolTipManager>
        <telerik:RadFormDecorator ID="RadFormDecorator1" runat="server" DecoratedControls="All"></telerik:RadFormDecorator>
        <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
            <script type="text/javascript">
                //刷新父窗体，关闭自己
                function CloseAndRebind() {
                    GetRadWindow().BrowserWindow.refreshGrid();
                    GetRadWindow().close();
                    return false;
                }
                //获取父窗体RadWindow控制器
                function GetRadWindow() {
                    var oWindow = null;
                    if (window.radWindow)
                        oWindow = window.radWindow; //Will work in Moz in all cases, including clasic dialog
                    else if (window.frameElement.radWindow)
                        oWindow = window.frameElement.radWindow; //IE (and Moz as well)
                    return oWindow;
                }

            </script>
            <style type="text/css">
                .style1 {
                    color: red;
                }

                .border {
                    border: 0;
                    margin: 0;
                    padding: 0;
                }
                .box{
                    padding-top:20px;
                }
            </style>
        </telerik:RadCodeBlock>
        <asp:ValidationSummary ID="vds_OverseasAdd" ValidationGroup="BaseInfoGroup" ShowSummary="false"
            ShowMessageBox="true" HeaderText="验证信息出错!" runat="server" />

        <div class="box">

            <table class="border">
                <tr>
                    <td class="border">
                        <cp:CPMisLabel ID="clblSchoolName" runat="server" Text="学院名称">
                        </cp:CPMisLabel>
                    </td>
                    <td class="border">
                        <span class="style1">* </span>
                    </td>
                    <td class="border" colspan="5">
                        <cp:CPMisTextBox ID="ctxtSchoolName" runat="server" SkinID="Changeable" Width="500">
                        </cp:CPMisTextBox>
                    </td>
                    <td class="border" align="left" style="color: Gray;">
                        <asp:Label ID="CPMisLabel1" runat="server" Text="如：计算机学院">
                        </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="border">
                        <cp:CPMisLabel ID="clblDepartmentName" runat="server" Text="教研室名称">
                        </cp:CPMisLabel>
                    </td>
                    <td class="border">
                        <span class="style1">*</span>
                    </td>
                    <td class="border" colspan="5">
                        <cp:CPMisTextBox ID="ctxtDepartmentName" runat="server" SkinID="Changeable" Width="500">
                        </cp:CPMisTextBox>
                    </td>
                    <td class="border" style="color: Gray;" align="left">
                        <asp:Label ID="CPMisLabel3" runat="server" Text="如：软件工程 ">
                        </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="border">
                        <cp:CPMisLabel ID="clblCourseName" runat="server" Text="课程名称">
                        </cp:CPMisLabel>
                    </td>
                    <td class="border"><span class="style1">*</span> </td>
                    <td class="border">
                        <cp:CPMisTextBox ID="ctxtCourseName" runat="server">
                        </cp:CPMisTextBox>
                    </td>
                    <td align="left" class="border" style="color: Gray;">
                        <asp:Label ID="lal1" runat="server" Text="如：数据库原理与应用">
                        </asp:Label>
                    </td>
                    <td class="border">
                        <cp:CPMisLabel ID="clblClassName" runat="server" Text="班级名称">
                        </cp:CPMisLabel>
                    </td>
                    <td class="border"><span class="style1">*</span> </td>
                    <td class="border">
                        <cp:CPMisTextBox ID="ctxtClassName" runat="server">
                        </cp:CPMisTextBox>
                    </td>
                    <td align="left" class="border" style="color: Gray;">
                        <asp:Label ID="Label4" runat="server" Text="如：04班">
                        </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="border">
                        <cp:CPMisLabel ID="clblISBN" runat="server" Text="ISBN">
                        </cp:CPMisLabel>
                    </td>
                    <td class="border"><span class="style1">*</span> </td>
                    <td class="border">
                        <cp:CPMisTextBox ID="ctxtISBN" runat="server">
                        </cp:CPMisTextBox>
                    </td>
                    <td align="left" class="border" style="color: Gray;">
                        <cp:CPMisButton ID="CPMisButton1" runat="server" 
                          OnBeforeClick="cbtnQueryTextbookByIsbn" SkinID="bt60" Text="查询"  />
                    </td>
                    <td class="border">
                        <cp:CPMisLabel ID="clblTextbookName" runat="server" Text="教材名称">
                        </cp:CPMisLabel>
                    </td>
                    <td class="border"><span class="style1">*</span></td>
                    <td class="border">
                        <cp:CPMisTextBox ID="ctxtTextbookName" runat="server">
                        </cp:CPMisTextBox>
                    </td>
                    <td align="left" class="border" style="color: Gray;">
                        <asp:Label ID="CPMisLabel5" style="text-align:left;" runat="server" Text="如：12356789" Width="110">
                        </asp:Label>
                    </td>
                   
                </tr>
                <tr>
                     <td class="border">
                        <cp:CPMisLabel ID="clblDeclarationNum" runat="server" Text="申报数量">
                        </cp:CPMisLabel>
                    </td>
                    <td class="border"><span class="style1">*</span> </td>
                    <td class="border">
                        <cp:CPMisTextBox ID="ctxtDeclarationNum" runat="server">
                        </cp:CPMisTextBox>
                    </td>
                    <td align="left" class="border" style="color: Gray;">如：23</td>
                    <td class="border">
                        <cp:CPMisLabel ID="clblPrice" runat="server" Text="价格">
                        </cp:CPMisLabel>
                    </td>
                    <td class="border">
                        <span class="style1">*</span>
                    </td>
                    <td class="border">
                        <cp:CPMisTextBox ID="ctxtPrice" runat="server">
                        </cp:CPMisTextBox>
                    </td>
                    <td class="border" align="left" style="color: Gray;">
                        <asp:Label ID="CPMisLabel6" runat="server" Text="如：23">
                        </asp:Label>
                    </td>
                    
                </tr>
                <tr>
                    <td class="border">
                        <cp:CPMisLabel ID="clblPhone" runat="server" Text="电话">
                        </cp:CPMisLabel>
                    </td>
                    <td class="border">
                        <span class="style1">*</span>
                    </td>
                    <td class="border">
                        <cp:CPMisTextBox ID="ctxtPhone" runat="server">
                        </cp:CPMisTextBox>
                    </td>
                    <td class="border" align="left" style="color: Gray;">
                        <asp:Label ID="Label5" runat="server" Text="如：1586752553">
                        </asp:Label>
                    </td>
                    <td class="border">
                        <cp:CPMisLabel ID="clblAuditStatus" runat="server" Text="审核状态">
                        </cp:CPMisLabel>
                    </td>
                    <td class="border">
                        <span class="style1">*</span>
                    </td>
                    <td class="border">
                        <cp:CPMisComboBox ID="cmbAuditStatus" runat="server"  MaxLength="10"
                             DefaultIndex="0" IsCancelDataBind="false"
                             IsMaintainSelectedValue="true"   SkinID="btnLogin">
                        </cp:CPMisComboBox> 
                    </td>
                    <td class="border" style="color: Gray;" align="left">
                        <asp:Label ID="Label6" runat="server" Text="如:未审核">
                        </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="border">
                        <cp:CPMisLabel ID="clblPreferredState" runat="server" Text="优选状态">
                        </cp:CPMisLabel>
                    </td>
                    <td class="border">
                        <span class="style1">*</span>
                    </td>
                    <td class="border">
                        <cp:CPMisComboBox ID="cmbPreferredState" runat="server"  MaxLength="10"
                             DefaultIndex="0" IsCancelDataBind="false"
                             IsMaintainSelectedValue="true"   SkinID="btnLogin">
                        </cp:CPMisComboBox> 
                    </td>
                    <td class="border" style="color: Gray;" align="left">
                        <asp:Label ID="Label7" runat="server" Text="如：优选">
                        </asp:Label>
                    </td>
                    <td class="border">
                        <cp:CPMisLabel ID="clblIdentification" runat="server" Text="数据标识">
                        </cp:CPMisLabel>
                    </td>
                    <td class="border">
                        <span class="style1">*</span>
                    </td>
                    <td class="border">
                        <cp:CPMisTextBox ID="ctxtIdentification" runat="server">
                        </cp:CPMisTextBox>
                    </td>
                    <td class="border" style="color: Gray;" align="left">
                        <asp:Label ID="CPMisLabel7" runat="server" Text="如：本部">
                        </asp:Label>
                    </td>
                 </tr>
                 <tr>
                    <td class="border">
                        <cp:CPMisLabel ID="clblNeedTextbook" runat="server" Text="需要教材">
                        </cp:CPMisLabel>
                    </td>
                    <td class="border"><span class="style1">*</span></td>
                    <td class="border">
                        <cp:CPMisComboBox ID="cmbNeedTextbook" runat="server"  MaxLength="10"
                             DefaultIndex="0" IsCancelDataBind="false"
                             IsMaintainSelectedValue="true"   SkinID="btnLogin">
                        </cp:CPMisComboBox> 

                    </td>
                    <td class="border" style="color: Gray;" align="left">
                        <asp:Label ID="Label1" runat="server" Text="如：是">
                        </asp:Label>
                    </td>
                    <td class="border">
                        <cp:CPMisLabel ID="clblRemarks" runat="server" Text="备注">
                        </cp:CPMisLabel>
                    </td>
                    <td class="border"><span class="style1">*</span></td>
                     <td class="border">
                        <cp:CPMisTextBox ID="ctxtRemarks" runat="server">
                        </cp:CPMisTextBox>
                    </td>
                    <td class="border" style="color: Gray;" align="left">
                        <asp:Label ID="Label3" runat="server" Text="如：xxx">
                        </asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <table class="border" width="600px">
                <tr>
                    <td class="border" align="right" width="90">
                        <cp:CPMisButton SkinID="bt60" ID="cbtnSubmit" runat="server" Text="确定"></cp:CPMisButton>
                    </td>
                    <td align="center" class="border" width="90">
                        <cp:CPMisButton ID="cbtnCancle" runat="server"  SkinID="bt60" Text="取消"  />
                    </td>
                </tr>
            </table>
            
            <%--弹窗管理器--%>
            <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                <Windows>
                    <telerik:RadWindow ID="RadWindow1" runat="server" Top="150" Left="300" Width="500" Height="380">
                    </telerik:RadWindow>
                </Windows>
            </telerik:RadWindowManager>
            <br />
        </div>
    </form>
</body>
</html>

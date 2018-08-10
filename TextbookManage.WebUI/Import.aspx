<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Import.aspx.cs" Inherits="TextbookManage.WebUI.Tb_Maintain.Tb_Maintain_1.Import" %>

<!DOCTYPE html>

<html >
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
    
    .upload{

        width:100%;
        height:100px;
        margin:20px 0 40px 40px;
        border:1px solid red;
    }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <telerik:RadStyleSheetManager runat="server" ID="RadStyleSheetManager1">
        </telerik:RadStyleSheetManager>
        <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        </telerik:RadScriptManager>
        <telerik:RadSkinManager ID="RadSkinManager1" runat="server">
        </telerik:RadSkinManager>
        <telerik:RadToolTipManager ID="RadToolTipManager1" runat="server" AutoTooltipify="true">
        </telerik:RadToolTipManager>
        <telerik:RadFormDecorator ID="RadFormDecorator1" runat="server" DecoratedControls="All">
        </telerik:RadFormDecorator>
        <div>
                <br />
<%--                <asp:FileUpload CssClass="file" ID="FileUpload2"  runat="server" />
                <cp:CPMisButton  ID="BtnUpload" runat="server" Text="上传" OnClick="BtnUpload_Click"  SkinID="Auto"/>
                <hr />
                <cp:CPMisLabel ID="LabMessage1" runat="server" ForeColor="red" SkinID="AutoSize" /><br />
                <cp:CPMisLabel ID="LabMessage2" runat="server" SkinID="AutoSize" />--%>
            <div class="upload">
                <asp:FileUpload ID="FileUpload1" style="background-color:transparent"  runat="server" />
                <cp:CPMisButton ID="CPMisButton1" runat="server" Text="上传" OnClick="BtnUpload_Click"  SkinID="Auto"/>
                <cp:CPMisLabel ID="LabMessage1" runat="server" ForeColor="red" SkinID="AutoSize" /><br />
                <cp:CPMisLabel ID="LabMessage2" runat="server" SkinID="AutoSize" />
            </div>
               


        </div>
    </form>
</body>
</html>
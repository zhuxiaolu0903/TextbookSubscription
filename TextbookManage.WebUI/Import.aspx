<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Import.aspx.cs" Inherits="TextbookManage.WebUI.Import" %>

<!DOCTYPE html>

<html >
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
    
    .upload{
        width:350px;
        height:100px;
        margin:20px 0 40px 40px;
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
            <div class="upload">
                <telerik:RadAsyncUpload ID="rAsyncFileUpload" runat="server"
                    RenderMode="Lightweight" HideFileInput="true" 
                    AllowedFileExtensions=".xls,.xlsx" MaxFileInputsCount="1"
                    />

                <cp:CPMisButton ID="cUploadBtn" runat="server" Text="上传" 
                    OnClick="OnUploadBtnClicked"  SkinID="Auto"/>
            </div>
        </div>
    </form>
</body>
</html>
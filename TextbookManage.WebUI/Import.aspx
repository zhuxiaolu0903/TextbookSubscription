<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Import.aspx.cs" Inherits="TextbookManage.WebUI.Import" %>

<!DOCTYPE html>

<html >
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
.demo-container {
    width: 454px;
    padding-left: 70px !important;
    padding-right: 70px !important;
    padding-bottom: 100px !important;
}
 
.header-container {
    height: 40px;
    width: 400px;
}
 
.attachment-container {
    display: inline-block;
    filter: progid:DXImageTransform.Microsoft.gradient(GradientType=0,startColorstr='#993aaefb', endColorstr='#993aaefb');
    width: 410px;
    padding: 25px 22px 22px;
}
 
.allowed-attachments {
    display: block;
    margin-top: 12px;
    font-size: 13px;
    text-align:left;
    color:#5d8cc9;
}
 
.allowed-attachments-list {
    font-style: italic;
    font-size: 12px;
}
 
.ruInputs .ruFileWrap .ruButton {
    min-width: 80px;
}
 
.text-boxes-container {
    background: rgba(255, 255, 255, 0.9);
    filter: progid:DXImageTransform.Microsoft.gradient(GradientType=0,startColorstr='#eeffffff', endColorstr='#eeffffff');
    border-top: 1px solid rgb(185, 185, 185);
}
 
.text-box {
    margin: 0;
    padding: 6px 10px;
    font-size: 12px;
}
 
.writing-box {
    margin: 0;
    padding: 10px 10px;
    font-size: 13.5px;
    line-height: 0.9em;
}
 
.text-boxes-container .text-box,
.text-boxes-container .writing-box {
    border-bottom: 1px solid rgb(185, 185, 185);
    border-left: 1px solid rgb(185, 185, 185);
    border-right: 1px solid rgb(185, 185, 185);
}
 
.background-silk .demo-container {
    color: #444;
}
 
.background-blackmetrotouch .demo-container .text-boxes-container,
.background-glow .demo-container .text-boxes-container {
    background: none;
    filter: progid:DXImageTransform.Microsoft.gradient(GradientType=0,startColorstr='#33ffffff', endColorstr='#33ffffff');
    border-top: 1px solid rgb(100, 100, 100);
}
 
.background-blackmetrotouch .demo-container .text-boxes-container .text-box,
.background-glow .demo-container .text-boxes-container .text-box,
.background-blackmetrotouch .demo-container .text-boxes-container .writing-box,
.background-glow .demo-container .text-boxes-container .writing-box {
    border-bottom: 1px solid rgb(100, 100, 100);
    border-left: 1px solid rgb(100, 100, 100);
    border-right: 1px solid rgb(100, 100, 100);
}
 
.background-black .demo-container .text-boxes-container {
    background: rgba(255, 255, 255, 0.2);
    border-top: 1px solid rgb(50, 50, 50);
}
 
.background-black .demo-container .text-boxes-container .text-box,
.background-black .demo-container .text-boxes-container .writing-box {
    border-bottom: 1px solid rgb(50, 50, 50);
    border-left: 1px solid rgb(50, 50, 50);
    border-right: 1px solid rgb(50, 50, 50);
}

    </style>
    <script>
        var btnList = document.getElementsByClassName("ruButton ruBrowse");
        var btn = null;
        for (var i = 0; i < btnList.length; i++) {
            btn = btnList[i];
             btn.onClick = function () {
               alert("Click");
            }
        }
       
    </script>
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
        <div class="attachment-container">
             <telerik:RadAsyncUpload ID="rAsyncFileUpload" runat="server"
                    RenderMode="Lightweight" HideFileInput="true" 
                    AllowedFileExtensions=".xls,.xlsx" MaxFileInputsCount="1"/>
            <span class="allowed-attachments">允许上传文件的格式 <span class="allowed-attachments-list">(<%= String.Join( ",", rAsyncFileUpload.AllowedFileExtensions ) %>)</span>
            </span><br/>
            <cp:CPMisButton runat="server" Skin="Auto" 
                OnClick="OnUploadBtnClicked" Text="上传" ></cp:CPMisButton>
            <cp:CPMisLabel runat="server"  ID="UploadMassage" SkinID="Message"></cp:CPMisLabel>
        </div>
    </form>








</body>
</html>
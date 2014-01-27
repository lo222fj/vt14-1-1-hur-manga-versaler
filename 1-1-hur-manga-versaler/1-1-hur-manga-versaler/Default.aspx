<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_1_1_hur_manga_versaler.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Räkna versaler</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
        <asp:Label ID="Header" runat="server" Text="Hur många versaler?"></asp:Label>
       </h1>
        <asp:TextBox ID="WriteHere" runat="server" TextMode="MultiLine"></asp:TextBox>
        <br />
        <p><asp:Label ID="Result" runat="server" Text=""></asp:Label></p>
        <asp:Button ID="CountUppercase" runat="server" Text="Räkna versaler" OnClick="CountUppercase_Click" />
    </div>
    </form>
</body>
</html>

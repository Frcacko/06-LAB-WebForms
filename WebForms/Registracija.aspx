
<asp:Label Text="Username:" runat="server" />
<asp:TextBox ID="tbUsername" runat="server" /><br />

<asp:Label Text="Password:" runat="server" />
<asp:TextBox ID="tbPassword" runat="server" TextMode="Password" /><br />

<asp:Label Text="Full name:" runat="server" />
<asp:TextBox ID="tbFullName" runat="server" /><br /><br />

<asp:Button ID="btnRegister" runat="server"
    Text="Register"
    OnClick="btnRegister_Click" />

<br /><br />

<asp:Label ID="lblMessage" runat="server" ForeColor="Red" />

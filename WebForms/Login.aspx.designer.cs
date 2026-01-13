< asp:TextBox ID = "txtUsername" runat="server" Placeholder="Username" />
<br />

<asp:TextBox ID = "txtPassword" runat="server" TextMode="Password" Placeholder="Password" />
<br />

<asp:Button ID = "btnLogin" runat="server" Text="Login"
    OnClick="btnLogin_Click" />

<asp:Label ID = "lblMsg" runat="server" ForeColor="Red" />
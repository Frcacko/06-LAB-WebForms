<asp:Label Text="Naziv proizvoda:" runat="server" />
<asp:TextBox ID="tbName" runat="server" /><br />

<asp:Label Text="Opis proizvoda:" runat="server" />
<asp:TextBox ID="tbDescription" runat="server" /><br /><br />

<asp:Button ID="btnSave" runat="server"
    Text="Spremi"
    OnClick="btnSave_Click" />

<br /><br />

<asp:GridView ID="gvProducts" runat="server"></asp:GridView>
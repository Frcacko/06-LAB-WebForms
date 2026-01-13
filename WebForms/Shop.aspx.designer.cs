< asp:TextBox ID = "txtName" runat="server" Placeholder="Naziv proizvoda" />
<br />

<asp:TextBox ID = "txtDesc" runat="server" Placeholder="Opis proizvoda" />
<br />

<asp:Button ID = "btnSave" runat="server" Text="Spremi"
    OnClick="btnSave_Click" />

<hr />

<asp:GridView ID = "gvProducts" runat="server" AutoGenerateColumns="true" />

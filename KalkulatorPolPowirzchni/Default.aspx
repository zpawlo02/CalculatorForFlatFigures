<%@ Page Language="C#" Inherits="KalkulatorPolPowirzchni.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="UTF-8">
	<title>Default</title>
</head>
<body>
	<form id="form1" runat="server">
		<asp:DropDownList  id="figuresNames" runat="server">
            <asp:ListItem value="Kwadrat">Kwadrat</asp:ListItem>
            <asp:ListItem value="Prostokąt">Prostokąt</asp:ListItem>
            <asp:ListItem value="Trójkąt">Trójkąt</asp:ListItem>
            <asp:ListItem value="Trójkąt równoramienny">Trójkąt równoramienny</asp:ListItem>
            <asp:ListItem value="Trójkąt prostokątny">Trójkąt prostokątny</asp:ListItem> 
            <asp:ListItem value="Trapez">Trapez</asp:ListItem>
            <asp:ListItem value="Okrąg">Okrąg</asp:ListItem>
        </asp:DropDownList>
            <asp:Button id="btn_accept" OnClick="selectChanged" runat="server"></asp:Button>
	</form>
       <asp:label>Podaj wartości w formacie: </asp:label>
       <asp:label id="funcLabel" runat="server"> </asp:label>
      
        
</body>
</html>

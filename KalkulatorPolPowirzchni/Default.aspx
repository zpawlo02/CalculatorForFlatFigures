<%@ Page Language="C#" Inherits="KalkulatorPolPowirzchni.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="UTF-8">
	<title>Kalkulator pól powierzchni</title>
</head>
<body>
	<form id="form1" runat="server">
		<asp:DropDownList  id="figuresNames" AutoPostBack="True" runat="server" OnSelectedIndexChanged="selectChanged">
            <asp:ListItem value="Kwadrat">Kwadrat</asp:ListItem>
            <asp:ListItem value="Prostokąt">Prostokąt</asp:ListItem>
            <asp:ListItem value="Trójkąt">Trójkąt</asp:ListItem>
            <asp:ListItem value="Trójkąt równoramienny">Trójkąt równoramienny</asp:ListItem>
            <asp:ListItem value="Trójkąt prostokątny">Trójkąt prostokątny</asp:ListItem> 
            <asp:ListItem value="Trapez">Trapez</asp:ListItem>
            <asp:ListItem value="Okrąg">Okrąg</asp:ListItem>
        </asp:DropDownList>
         
        <br>
        <asp:label>Podaj wartości w formacie: </asp:label>
        <br>
        <asp:label id="funcLabel" runat="server"> a (bok)</asp:label>
        <br>
        <asp:TextBox id="txtBoxValues" runat="server"></asp:TextBox>
          
        
        <asp:Button id="btnCalculate" runat="server" OnClick="calculate" Text="Oblicz"></asp:Button>
	    <br>
        <asp:label id="countedLabel" runat="server"> </asp:label>
        </form>
      
     
        
</body>
</html>

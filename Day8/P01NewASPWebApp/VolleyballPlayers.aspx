<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VolleyballPlayers.aspx.cs" Inherits="P01NewASPWebApp.VolleyballPlayers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        

            <p>some text</p>
            <p><%Response.Write(SampleString); %></p>
            <p><%= SampleString %></p>

            <table>
                <tr>
                    <td>cell1</td>
                    <td>cell2</td>
                </tr>
                <tr>
                    <td>cell3</td>
                    <td>cell4</td>
                </tr>
            </table>
            
        <table>
            <%
                foreach(var p in PlayerList)
            {
                if (p.Country.ToLower() == "pol")
                {%>
            <tr style=""background-color:red"
              <%  }
                else

                    %>

                <tr style="background-color:red">
                    <td><%=PlayerList[i].Id %></td>
                    <td><%=PlayerList[i].FirstName %></td>
                    <td><%=PlayerList[i].LastName %></td>
                </tr>

            <%
            }   
                %>
        </table>


        
    </form>
</body>
</html>

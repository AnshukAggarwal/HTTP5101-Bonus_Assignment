<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bonus_assigment_q1.aspx.cs" Inherits="bonus_assignment_n01399681_Anshuk_Aggarwal.bonus_assigment_q1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <h1>Cartesian Plane</h1>
        </section>
        <section>
            <h2>Please enter the coordinate for x-axis</h2>
            <asp:TextBox runat="server" ID="x_coordinate" type="number"></asp:TextBox>
            <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" ErrorMessage="Please enter a coordinate for x-asis" ControlToValidate="x_coordinate"></asp:RequiredFieldValidator>
        </section>
        <section>
            <h2>Please enter the coordinate for y-axis</h2>
            <asp:TextBox runat="server" ID="y_coordinate" type="number"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="Please enter a coordinate for y-axis" ControlToValidate="y_coordinate"></asp:RequiredFieldValidator>
        </section>
        <section>
            <asp:ValidationSummary runat="server" ShowSummary="true" />
        </section>
        <section id="confirmbox" runat="server">

        </section>
        <section>
            <input type="submit" value="submit" />
        </section>
    </form>
</body>
</html>

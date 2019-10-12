<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bonus_assignment_q2.aspx.cs" Inherits="bonus_assignment_n01399681_Anshuk_Aggarwal.bonus_assignment_q2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
    <section>
            <h1>Weekly Calendar</h1>
        </section>
        <section>
            <h2>Please select the days you work</h2>
            <asp:CheckBoxList runat="server" ID="user_schedule">
                <asp:ListItem Value="Monday" Text="Monday"></asp:ListItem>
                <asp:ListItem Value="Tuesday" Text="Tuesday"></asp:ListItem>
                <asp:ListItem Value="Wednesday" Text="Wednesday"></asp:ListItem>
                <asp:ListItem Value="Thursday" Text="Thursday"></asp:ListItem>
                <asp:ListItem Value="Friday" Text="Friday"></asp:ListItem>
                <asp:ListItem Value="Saturday" Text="Saturday"></asp:ListItem>
                <asp:ListItem Value="Sunday" Text="Sunday"></asp:ListItem>
            </asp:CheckBoxList>
            <%/* <asp:CustomValidator runat="server" ControlToValidate="user_schedule" ErrorMessage="Please select your work days" OnServerValidate="UserSchedule_Validate"></asp:CustomValidator>*/%>
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

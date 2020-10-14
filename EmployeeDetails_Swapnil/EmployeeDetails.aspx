<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="EmployeeDetails_Swapnil.EmployeeDetails" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <style runat="server">
    body  
   {
    background-color:Silver;
   }

 h3
 {
  color: white;
  text-align: center;
  }
</style>
</head>


<body>
    <form id="form1" runat="server">
    <br />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ShowMessageBox="True" ValidationGroup="G1" />

    <br />
    <asp:Label ID="Label2" runat="server" Text="Search"></asp:Label>
    <asp:DropDownList ID="drpSearch" runat="server" Width="110px" 
        AutoPostBack="True" onselectedindexchanged="drpSearch_SelectedIndexChanged">
    </asp:DropDownList>
    <br />
    <br />
    <br />
    <br />

    <div>
    <table width="100%">
    <tr>
    <th width="15%"> First Name </th>
    <td width="35%">
    <asp:TextBox ID="txtFirstName" runat="server" Width="100px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage=" *First Name Required" ControlToValidate="txtFirstName" 
            ValidationGroup="G1"></asp:RequiredFieldValidator>
    </td>
    
    <th width="15%"> Last Name </th>
    <td><asp:TextBox ID="txtLastName" runat="server" Width="100px"></asp:TextBox> 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage=" * LastName Required" ControlToValidate="txtLastName" 
            ValidationGroup="G1"></asp:RequiredFieldValidator>
    </td>
    </tr>

    <tr>
    <th width="15%"> DOB </th>
    <td width="35%">
    <asp:TextBox ID="txtDOB" runat="server" Width="100px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ErrorMessage="*" ControlToValidate="txtDOB" ValidationGroup="G1"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ErrorMessage="Please Enter Valid Format" ControlToValidate="txtDOB" 
            ValidationExpression="^(?=\d)(?:(?:31(?!.(?:0?[2469]|11))|(?:30|29)(?!.0?2)|29(?=.0?2.(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00)))(?:\x20|$))|(?:2[0-8]|1\d|0?[1-9]))([-./])(?:1[012]|0?[1-9])\1(?:1[6-9]|[2-9]\d)?\d\d(?:(?=\x20\d)\x20|$))?(((0?[1-9]|1[012])(:[0-5]\d){0,2}(\x20[AP]M))|([01]\d|2[0-3])(:[0-5]\d){1,2})?$" 
            ValidationGroup="G1"></asp:RegularExpressionValidator>
    </td>
    
    <th width="15%"> Gender </th>
    <td>
        <asp:DropDownList ID="drpGender" runat="server" Width="110px">
            <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:DropDownList>
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ErrorMessage="Plase Select Gender" ControlToValidate="drpGender" 
            Operator="NotEqual" ValidationGroup="G1" ValueToCompare="Select"></asp:CompareValidator>
        </td>
    </tr>

    <tr>
    <th width="15%"> Marital Status </th>
    <td width="35%">
   <asp:DropDownList ID="drpMaritalStatus" runat="server" Width="110px">
       <asp:ListItem>Select</asp:ListItem>
       <asp:ListItem>Single</asp:ListItem>
       <asp:ListItem>Married</asp:ListItem>
       <asp:ListItem>Widowed</asp:ListItem>
       <asp:ListItem>Divorced</asp:ListItem>
       <asp:ListItem>Seperated</asp:ListItem>
        </asp:DropDownList>
        <asp:CompareValidator ID="CompareValidator2" runat="server" 
            ErrorMessage="Please Select Marital Status" 
            ControlToValidate="drpMaritalStatus" Operator="NotEqual" ValidationGroup="G1" 
            ValueToCompare="Select"></asp:CompareValidator>
        </td>
    
    <th width="15%"> Country </th>
     <td><asp:DropDownList ID="drpCountry" runat="server" Width="110px">
         <asp:ListItem>India</asp:ListItem>
        </asp:DropDownList></td>
    </tr>

    <tr>
    <th width="15%"> State </th>
    <td width="35%">
    <asp:DropDownList ID="drpState" runat="server" Width="110px">
        <asp:ListItem>Select</asp:ListItem>
        <asp:ListItem>Maharashtra</asp:ListItem>
        <asp:ListItem>Karnataka</asp:ListItem>
        <asp:ListItem>Tamilnadu</asp:ListItem>
        <asp:ListItem>AndraPradesh</asp:ListItem>
        <asp:ListItem>Gujrat</asp:ListItem>
        <asp:ListItem>Delhi</asp:ListItem>
        <asp:ListItem>UttarPradesh</asp:ListItem>
        <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        
        <asp:CompareValidator ID="CompareValidator3" runat="server" 
            ErrorMessage="Please Select State" ControlToValidate="drpState" 
            Operator="NotEqual" ValidationGroup="G1" ValueToCompare="Select"></asp:CompareValidator></td>
    
    <th width="15%"> Address </th>
    <td><asp:TextBox ID="txtAddress" runat="server" Width="100px" Height="50px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ErrorMessage=" *" ControlToValidate="txtAddress" ValidationGroup="G1"></asp:RequiredFieldValidator>
     </td>
    </tr>

    <tr>
    <th width="15%"> Hobbies </th>
    <td width="35%">
    <asp:TextBox ID="txtHobbies" runat="server" Width="100px" Height="50px"></asp:TextBox></td>
    </tr>
    </table>
    </div>


    <br />
    <br />
    <div align="center">
        <asp:Button ID="btnSubmit" runat="server" Text="Sumbit" ValidationGroup="G1" 
            onclick="btnSubmit_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" 
            onclick="btnUpdate_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" 
            onclick="btnDelete_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" 
            onclick="btnCancel_Click" />


    </div>
    
    </form>
    </body>
</html>

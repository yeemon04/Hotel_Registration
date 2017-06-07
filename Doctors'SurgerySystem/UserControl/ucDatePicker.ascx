<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucDatePicker.ascx.vb" Inherits="UserControl_ucDatePicker" %>
<asp:TextBox ID="txtDateValue" runat="server" MaxLength="50" Text="" Width="150px"></asp:TextBox>
<asp:RequiredFieldValidator ID="rfvDateValue" runat="server" 
ErrorMessage="" ControlToValidate="txtDateValue" Display="dynamic"
ValidationGroup="" Text="*"></asp:RequiredFieldValidator>
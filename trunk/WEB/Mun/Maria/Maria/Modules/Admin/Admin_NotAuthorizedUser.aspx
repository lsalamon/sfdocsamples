﻿<%@ Page Title="" Language="C#" MasterPageFile="~/mariaDiv.Master" AutoEventWireup="true" CodeBehind="Admin_NotAuthorizedUser.aspx.cs" Inherits="Maria.Modules.Admin.Admin_NotAuthorizedUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentLeft" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentCenter" runat="server">

<div id="msg" style="font-size: xx-large; width: 666px; height: 248px;">
<asp:Image ID="Image1" runat="server" ImageUrl="~/Images/warning.png" 
        EnableTheming="False" EnableViewState="False" Height="54px" Width="44px" />
    <span style="color: #666666">&nbsp;&nbsp; No es un usuario autorizado para realizar esta acción. 
    <br />
    </span>
    <br style="color: #666666" />
    <span style="color: #666666">Por favor inicie sesion.- </span>
</div>
<div style="width: 100%; height: 182px; float: left">
  <div id="divStatus">
      <asp:Login ID="Login1" runat="server" Width= "100%" 
          FailureText="Su intento de inicio de sesión no se realizó correctamente. Por favor, inténtelo de nuevo." 
          LoginButtonText="Iniciar" 
          PasswordRequiredErrorMessage="La password es requerida." 
          RememberMeText="Recordar mis datos la próxima vez" 
          UserNameLabelText="Nombre de usuario:" 
          UserNameRequiredErrorMessage="El nombre ed usuario es requerido.">
          
      </asp:Login>
  </div>
 
    c


</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentRight" runat="server">
</asp:Content>

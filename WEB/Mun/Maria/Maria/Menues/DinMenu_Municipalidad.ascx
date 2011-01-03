﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DinMenu_Municipalidad.ascx.cs" Inherits="Maria.Menues.DinMenu_Municipalidad" %>
 
  <link href="../Styles/Menu.css" rel="stylesheet" type="text/css" />
<div id="d1" style="width: 100%">

         <asp:Menu ID="NavigationMenu" StaticDisplayLevels="3" StaticSubMenuIndent="10" Orientation="Vertical"
        runat="server" MaximumDynamicDisplayLevels="2" Height="32%"
        Width="100%" ForeColor="#003300" Font-Names="Verdana" Font-Size="X-Small" 
                EnableViewState="False">
        <LevelMenuItemStyles>
            <asp:MenuItemStyle BackColor="Black" ForeColor="#CCCCCC" />
            <asp:MenuItemStyle BackColor="White" Font-Bold="True" BorderStyle="Outset" VerticalPadding="10" />
            <asp:MenuItemStyle BackColor="White" />
        </LevelMenuItemStyles>
        <LevelSelectedStyles>
            <asp:MenuItemStyle BackColor="#336699" ForeColor="#FFFFCC" />
            <asp:MenuItemStyle BackColor="#336699" ForeColor="#FFFFCC" />
            <asp:MenuItemStyle BackColor="#336699" ForeColor="#FFFFCC" />
        </LevelSelectedStyles>
        <Items>
            <asp:MenuItem NavigateUrl="" Text="Municipalidad" ToolTip="Municipalidad">
                <asp:MenuItem Text="Institucional" ToolTip="Institucional">
                    <asp:MenuItem NavigateUrl="/modules/Municipalidad/Muni_Inst_Cultura.aspx" Text="Cultura"
                        ToolTip="Cultura" />
                    <asp:MenuItem NavigateUrl="/modules/Municipalidad/Muni_Inst_MedioAmbiente.aspx" Text="Medio Ambiente"
                        ToolTip="Medio Ambiente" />
                    <asp:MenuItem NavigateUrl="/modules/Municipalidad/Muni_Inst_Promocion_Social.aspx"
                        Text="Promoción Social" ToolTip="Promoción Social" />
                </asp:MenuItem>
                <asp:MenuItem NavigateUrl="" Text="Obras de Gobierno" ToolTip="Obras de Gobierno">
                    <asp:MenuItem NavigateUrl="/modules/Municipalidad/Muni_Inst_ObrasConstrucción.aspx"
                        Text="Obras en Construcción" ToolTip="Obras en Construcción" />
                    <asp:MenuItem NavigateUrl="/modules/Municipalidad/Muni_Inst_ObrasPlanificadas.aspx"
                        Text="Obras Planificadas" ToolTip="Obras Planificadas" />
                </asp:MenuItem>
            </asp:MenuItem>
        </Items>
    </asp:Menu>

    
</div>

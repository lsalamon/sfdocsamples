﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewsBase.ascx.cs" Inherits="Maria.NewsBase" %>
    

<link href="/Styles/News.css" rel="stylesheet" type="text/css" />

<div id="NewsContainer">
    <div id="NewsHeaderNumeratorTitle">
        <span id="NewsHeaderNumerator"><asp:Label ID="lblNewsOrder" runat="server" Text="333"></asp:Label></span>
        <span id="NewsHeaderTitle">Pregunta</span>
    </div>
    <div id="NewsHeaderBody">
        <span id="NewsHeaderText">
            <asp:Label ID="txtNewsText" runat="server"></asp:Label>
        </span>
    </div>
</div>
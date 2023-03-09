<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MainSite._Default" ValidateRequest="false"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Trine Oppgaver</h1>
    </div>

    <div class="row">
      <%--  height: auto; er en workaround for at jeg kan ikke skifte på bootstrap col-md-4 sin høyde.--%>
        <div class="col-md-4" style ="height: auto;">
            <h2>Rolf Jacobsen Aldri Før Analyse</h2>
            <p>
             <asp:Label ID="LabelRolf" runat="server" Text="Label"></asp:Label>
            </p>

            <asp:TextBox ID="TextBoxEditOnPage" Visible="false" runat="server" TextMode="MultiLine"></asp:TextBox>

            <p>
                <asp:Button ID="RolfEdit" CssClass="btn btn-default" Visible="false" runat="server" Text="Edit" OnClick="RolfEdit_Click" />
            </p>

             <EditItemTemplate>  
                    <asp:Button Visible="false" class="btn btn-default" ID="btn_Update" runat="server" Text="Update" CommandName="Update" OnClick="btn_Update_Click"/>  
                    <asp:Button Visible="false" class="btn btn-default" ID="btn_Cancel" runat="server" Text="Cancel" CommandName="Cancel" OnClick="btn_Cancel_Click"/>  
             </EditItemTemplate>  
        </div>
        <div class="col-md-4" style ="height: auto;">
            <h2>Lorem Ipsum</h2>
            <p>
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam euismod, diam at gravida laoreet, 
                ante odio lacinia purus, in mollis urna nulla ut diam. Curabitur et dolor ut turpis lobortis fermentum. 
                In non dolor iaculis, ultricies purus at, semper quam. Nullam commodo cursus leo commodo dictum. 
                Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. 
                Ut ullamcorper ac erat eu facilisis. Sed dictum volutpat nisi quis interdum. Aliquam felis dolor, 
                laoreet eu libero id, venenatis blandit urna. Vestibulum pretium, libero fermentum auctor pharetra, 
                orci nibh consequat ex, ut consequat sapien ex sit amet erat.
            </p>
            <p>
                <a class="btn btn-default" Visible="false">Edit &raquo;</a>
            </p>
        </div>
        <div class="col-md-4" style ="height: auto;">
            <h2>Lorem Ipsum</h2>
            <p>
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam euismod, diam at gravida laoreet, 
                ante odio lacinia purus, in mollis urna nulla ut diam. Curabitur et dolor ut turpis lobortis fermentum. 
                In non dolor iaculis, ultricies purus at, semper quam. Nullam commodo cursus leo commodo dictum. 
                Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. 
                Ut ullamcorper ac erat eu facilisis. Sed dictum volutpat nisi quis interdum. Aliquam felis dolor, 
                laoreet eu libero id, venenatis blandit urna. Vestibulum pretium, libero fermentum auctor pharetra, 
                orci nibh consequat ex, ut consequat sapien ex sit amet erat.
            </p>
            <p>
                <a class="btn btn-default" Visible="false">Edit &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>

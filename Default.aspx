<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master"  AutoEventWireup="true"  CodeBehind="Default.aspx.cs" Inherits="Shoppingmaschinen._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div    style="background-color: #99CCFF; border-style: solid; border-color: #808080; border-radius: 25px; width: auto; height: 100px; text-align: center;" aria-multiline="True">
        <h1><%# message %></h1>

    </div>

    <div class="row">
        <div class="col-md-4">
           
            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand" >
                <HeaderTemplate>
                    <h2>
                        Список товаров
                    </h2>
                </HeaderTemplate>
                <AlternatingItemTemplate>
                    <div style="background-color:aquamarine">
                     <%# Eval("name") %><br />
                    
                   Цена: <%# Eval("price") %>&nbsp<asp:Button class="btn pull-right btn-primary btn-lg" Text="КУПИТЬ" runat="server" margin-right="10px" /><br />
                   Остаток: <%# Eval("rest") %> 

                    </div>
                </AlternatingItemTemplate>

                <SeparatorTemplate>
                    <hr >
                </SeparatorTemplate>
                <ItemTemplate>
                    <div>
                        <%# Eval("name") %><br />
                    
                        Цена: <%# Eval("price") %>&nbsp<asp:Button class="btn pull-right btn-primary btn-lg" Text="КУПИТЬ" runat="server" style="margin-right:5px" /><br />
                        Остаток: <%# Eval("rest") %> 
                    </div>
                   
                  
                </ItemTemplate>
                
            </asp:Repeater>
           
        </div>
        <div class="col-md-4" style="left: 0px; top: 20px; height: 208px">
            <h2>Внесенная сумма</h2>
            <div aria-orientation="vertical">

                <div style="font-size: x-large; text-align: center; background-color: #CCFF99; border-style: double; border-radius: 10px; ">
                    <h1 style="width: 227px; height: 54px; margin-top: 9px">остаток:&nbsp <%# deposit %></h1> 
                </div>
                <div style="height: 92px">
                    <asp:button id="rest_button" class="btn pull-right btn-primary btn-lg" style="width: 151px; height: 52px" onclick="rest_button_Click" text="Сдача" runat="server" />

                </div>
            </div>
        </div>
        <div class="col-md-4">
            <h2>Кошелек</h2>

            <div>
                <div class="row">
                    10 p. &nbsp <asp:button id="Button_10" class="btn btn-primary btn-lg" onclick="Button_10_Click" text="внести 10 p." runat="server"/>

                </div>
                <hr />
                <div>
                     5 p. &nbsp <asp:button id="Button_5" class="btn btn-primary btn-lg" onclick="Button_5_Click" text="внести 5 p." runat="server" />
                    
                </div>
                <hr />
                 <div>
                      2 p. &nbsp <asp:button id="Button_2" class="btn btn-primary btn-lg" onclick="Button_2_Click" text="внести 2 p." runat="server"/>
                 </div>
                <hr />
                 <div>
                      1 p. &nbsp <asp:button id="Button_1" class="btn btn-primary btn-lg" onclick="Button_1_Click" text="внести 1 p." runat="server"/>
                 </div>
                <hr />
            </div>
        </div>
    </div>

</asp:Content>

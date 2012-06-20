<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PicasaWebIntegration._Default"
    Theme="Main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Picasa Web Integration</title>
    <script type="text/javascript">
        function openGallery(url) {
            window.showModalDialog(url, '', 'dialogWidth=800px;dialogHeight=532px;resizable=no;help=no;unadorned=yes;scroll=no');
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DataList ID="DataList1" runat="Server" DataSourceID="AlbumsDataSource" RepeatColumns="4"
            RepeatDirection="Horizontal" BorderWidth="0" CellPadding="3" CellSpacing="0"
            EnableViewState="False">
            <ItemStyle HorizontalAlign="center" />
            <ItemTemplate>
                <table border="0" cellpadding="0" cellspacing="0" class="album-frame">
                    <tr>
                        <td class="topx----">
                            <asp:Image runat="Server" ID="b01" SkinID="b01" />
                        </td>
                        <td class="top-x---">
                            <asp:Image runat="Server" ID="b02" SkinID="b02" />
                        </td>
                        <td class="top--x--">
                        </td>
                        <td class="top---x-">
                            <asp:Image runat="Server" ID="b03" SkinID="b03" />
                        </td>
                        <td class="top----x">
                            <asp:Image runat="Server" ID="b04" SkinID="b04" />
                        </td>
                    </tr>
                    <tr>
                        <td class="mtpx----">
                            <asp:Image runat="Server" ID="b05" SkinID="b05" />
                        </td>
                        <td colspan="3" rowspan="3" style="cursor: pointer">
                            <!--<a target="_blank" onclick="openGallery(Slideshow.aspx?albumID=<%# Eval("FeedUri") %>);" title="View slideshow"> -->
                                <img src="<%# Eval("ThumbnailUrl") %>" onclick="openGallery('Slideshow.aspx?albumID=<%# Eval("FeedUri") %>');" 
                                    alt="" style="border: 4px solid white;" /><!-- </a> -->
                        </td>
                        <td class="mtp----x">
                            <asp:Image runat="Server" ID="b06" SkinID="b06" />
                        </td>
                    </tr>
                    <tr>
                        <td class="midx----">
                        </td>
                        <td class="mid----x">
                        </td>
                    </tr>
                    <tr>
                        <td class="mbtx----">
                            <asp:Image runat="Server" ID="b07" SkinID="b07" />
                        </td>
                        <td class="mbt----x">
                            <asp:Image runat="Server" ID="b08" SkinID="b08" />
                        </td>
                    </tr>
                    <tr>
                        <td class="botx----">
                            <asp:Image runat="Server" ID="b09" SkinID="b09" />
                        </td>
                        <td class="bot-x---">
                            <asp:Image runat="Server" ID="b10" SkinID="b10" />
                        </td>
                        <td class="bot--x--">
                        </td>
                        <td class="bot---x-">
                            <asp:Image runat="Server" ID="b11" SkinID="b11" />
                        </td>
                        <td class="bot----x">
                            <asp:Image runat="Server" ID="b12" SkinID="b12" />
                        </td>
                    </tr>
                </table>
                <a target="_blank" href="Slideshow.aspx?albumID=<%# Eval("FeedUri") %>" title="View slideshow">
                    <font class="albumTitle">
                        <%# Server.HtmlEncode(Eval("Title").ToString()) %></a></font><br />
                <%# Eval("Summary") %><br />
                <font style="font-size: 7pt">
                    <%# Eval("NumberOfPhotos") %>
                    Photo(s)</font>
            </ItemTemplate>
        </asp:DataList>
        <asp:ObjectDataSource ID="AlbumsDataSource" runat="server" TypeName="PicasaWebIntegration.PhotoManager"
            SelectMethod="GetAlbums"></asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>

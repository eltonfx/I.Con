<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SlideShow.aspx.cs" Inherits="PicasaWebIntegration.SlideShow" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#336699">
    <form id="form1" runat="server">
        <center>
            <embed type="application/x-shockwave-flash" src="http://picasaweb.google.com/s/c/bin/slideshow.swf"
                width="800" height="533" flashvars="host=picasaweb.google.com&RGB=0x000000&feed=<%=Server.HtmlEncode(GetAlbumFeedUri()) %>%3Fkind%3Dphoto%26alt%3Drss"
                pluginspage="http://www.macromedia.com/go/getflashplayer"></embed>
        </center>
    </form>
</body>
</html>

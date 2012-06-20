using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace System.Web.Mvc.Html
{
    public static class CustomHelpers
    {
        // Extension method for Menu action
        public static MvcHtmlString ActionMenu(this HtmlHelper html, sbyte current)
        {
            //var url = new UrlHelper(html.ViewContext.RequestContext);
            List<TagBuilder> tags = new List<TagBuilder>();
            tags.Add(new TagBuilder("li") { InnerHtml = html.ActionLink("Home", "Index", "Home", null, new { @class = (current == 0 ? "current" : string.Empty) }).ToString() });
            tags.Add(new TagBuilder("li") { InnerHtml = html.ActionLink("Secretaria", "Index", "Secretaria", null, new { @class = (current == 1 ? "current" : string.Empty) }).ToString() });
            tags.Add(new TagBuilder("li") { InnerHtml = html.ActionLink("Agenda", "Index", "Agenda", null, new { @class = (current == 2 ? "current" : string.Empty) }).ToString() });
            tags.Add(new TagBuilder("li") { InnerHtml = html.ActionLink("Pastorais", "Index", "Pastorais", null, new { @class = (current == 3 ? "current" : string.Empty) }).ToString() });
            tags.Add(new TagBuilder("li") { InnerHtml = html.ActionLink("Fotos", "Index", "Fotos", null, new { @class = (current == 4 ? "current" : string.Empty) }).ToString() });
            tags.Add(new TagBuilder("li") { InnerHtml = html.ActionLink("Contato", "Index", "Contato", null, new { @class = (current == 5 ? "current" : string.Empty) }).ToString() });

            // build the <ul> tag
            var ulBuilder = new TagBuilder("ul");
            foreach (var item in tags)
            {
                ulBuilder.InnerHtml = string.Concat(ulBuilder.InnerHtml, item.ToString(TagRenderMode.Normal), Environment.NewLine);
            }

            return MvcHtmlString.Create(ulBuilder.ToString(TagRenderMode.Normal));
        }

        // Extension method for Return Day Color (cor da liturgia)
        public static string ReturnDayColor()
        {
            string colorName = "Default";
            int dia = DateTime.Now.Day;
            switch (DateTime.Now.Month)
            {
                case 1:
                    {
                        if (IsBetween(dia, 1, 15))
                            colorName = "Azul";
                        break;
                    }
                case 2:
                    {
                        if (IsBetween(dia, 7, 12))
                            colorName = "Amarelo";
                        break;
                    }
                case 3:
                    {
                        if (IsBetween(dia, 4, 7))
                            colorName = "AmareloClaro";
                        break;
                    }
                case 5:
                    {
                        if (IsBetween(dia, 25, 31))
                            colorName = "Roxo";
                        if (IsBetween(dia, 30, 32))
                            colorName = "Verde";
                        break;
                    }
                case 6:
                    {
                        if (IsBetween(dia, 3, 30))
                            colorName = "Vermelho";
                        break;
                    }
                case 8:
                    {
                        if (IsBetween(dia, 13, 15))
                            colorName = "Preto";
                        break;
                    }
                case 11:
                    {
                        if (IsBetween(dia, 4, 7))
                            colorName = "Rosa";
                        break;
                    }
                case 12:
                    {
                        if (IsBetween(dia, 18, 20))
                            colorName = "Roxo";
                        break;
                    }
                default:
                    break;
            }

            return colorName;
        }

        private static bool IsBetween(int valor, int menor, int maior)
        {
            return valor > menor && valor < maior;
        }

    }
}
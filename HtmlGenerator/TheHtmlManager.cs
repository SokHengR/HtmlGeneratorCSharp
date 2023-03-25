using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlGenerator
{
    internal class TheHtmlManager
    {
        public static string makeHtmlFile(string pageName)
        {
            string headOfHtml = htmlDoc(htmlHead(pageName, htmlHyperLink("Home", "index.html") + " | " + htmlHyperLink("Contact", "contact.html") + " | " + htmlHyperLink("Shop", "shop.html") + "<br>"));
            string bodyOfHtml = htmlBody(htmlLabel($"<br>this is {pageName}", 50, true) + "<br>" + htmlLabel($"welcome to {pageName}. this is subtitle of the page", 20, false));
            string finalHtmlString = htmlDoc(headOfHtml + bodyOfHtml);
            return finalHtmlString;
        }
        static string htmlDoc(string htmlElements)
        {
            string htmlDocString = "<!DOCTYPE html>\n<html>\n";
            return $"{htmlDocString}{htmlElements}\n</html>";
        }
        static string htmlHead(string headTitle, string headElements)
        {
            return $"<head>\n<title>{headTitle}</title>\n{headElements}\n</head>";
        }
        static string htmlBody(string bodyElements)
        {
            return $"<body>\n{bodyElements}\n</body>";
        }
        static string htmlHyperLink(string linkTitle, string linkAddress)
        {
            return $"<a href=\"{linkAddress}\">{linkAddress}</a>";
        }
        static string htmlLabel(string labelText, int fontSize, bool isBold)
        {
            string isBoolString = isBold ? "; font-weight: bold" : "";
            return $"<label style=\"font-size: {fontSize}px{isBoolString}\">{labelText}</label>";
        }
    }
}

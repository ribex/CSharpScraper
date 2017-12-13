using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Html.Forms;
using ScrapySharp.Network;

namespace ScrapyZero
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "https://seekingalpha.com";
            var web = new HtmlWeb();
            if (web.Load(url) is HtmlDocument document)
            {
                var nodes = document.DocumentNode.CssSelect("#hp_top_articles");
                Console.WriteLine(nodes);

                foreach (var node in nodes)
                {
                    Console.WriteLine(node);
                }

//                var nodes = document.DocumentNode.CssSelect("div");
//                Console.WriteLine(nodes);
            }
            Console.WriteLine("Finished?");
            Console.ReadLine();


//            ScrapingBrowser browser = new ScrapingBrowser();
//            WebPage homePage = browser.NavigateToPage(new Uri("https://seekingalpha.com"));
//
//            PageWebForm form = homePage.FindFormById("sa-search");
//            form["q"] = "amzn";
//            form.Method = HttpVerb.Get;
//            WebPage resultsPage = form.Submit();
//
//            HtmlNode[] resultsLinks = resultsPage.Html.CssSelect("div").ToArray();
//
//            foreach (var link in resultsLinks)
//            {
//                Console.WriteLine(link);
//            }
        }
    }
}

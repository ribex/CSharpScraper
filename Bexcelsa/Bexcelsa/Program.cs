using System.Linq;

namespace Bexcelsa
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var portfolio = new Portfolio {Name = "DaydreamsCanComeTrue"};

            var chrDr = new Driver(@"C:\Users\Rebecca\source\repos\CSharpScraper\Bexcelsa");

            // go to Yahoo Finance
            chrDr.Navigate("https://finance.yahoo.com/");

            Credentials.Login("ribexy@gmail.com", "ChromeDriver2018", chrDr);

            // go to portfolio
            chrDr.Navigate("https://finance.yahoo.com/portfolio/p_1/view/v1");

            var table = DataManipulator.GetTable(chrDr);

            DataManipulator.ParseTable(table, chrDr);




            //using (var db = new PortfolioContext())
            //{
            //    db.Portfolios.Add(portfolio);
            //    db.SaveChanges();

            //    var query = from b in db.Portfolios
            //        orderby b.Name
            //        select b;

            //    Console.WriteLine("All portfolios in the database: ");
            //    foreach (var item in query)
            //    {
            //        Console.WriteLine(item.Name);
            //    }

            //}

            // work on learning entity framework
        }
    }
}

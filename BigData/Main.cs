using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Data.Odbc;

namespace BigData
{
    public partial class Main : Form
    {
        List<News> news = new List<News>();
        List<Moto> motos = new List<Moto>();
        Database db = new Database();

        public Main()
        {
            InitializeComponent();
            db.ConnectDB();
        }

        private async Task CrawlVNExpressasync()
        {
            await db.DeleteAllNews();

            var url = "https://vnexpress.net/giai-tri";
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);

            var listNews =
                    htmlDocument.DocumentNode.Descendants("article").ToList();

            foreach (var div in listNews)
            {
                News newObj = new News
                {
                    Title = div.Descendants("a").FirstOrDefault().ChildAttributes("title").FirstOrDefault().Value,
                    Link = div.Descendants("a").FirstOrDefault().ChildAttributes("href").FirstOrDefault().Value,
                    ImageUrl = div.Descendants("img").FirstOrDefault().ChildAttributes("data-original").FirstOrDefault().Value,
                    Desc = div.Descendants("p").FirstOrDefault().InnerText
                };

                news.Add(newObj);
            }

            await db.InsertNews(news);
        }

        private async Task CrawlMotoasync()
        {
            await db.DeleteAllMotos();

            var url = "https://xemayhoanghiep.com.vn/danh-muc/piaggio/";
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);

            var listMoto =
                    htmlDocument.DocumentNode.Descendants("li")
                    .Where(node => node.GetAttributeValue("class", "").Contains("product type-product")).ToList();

            foreach (var div in listMoto)
            {
                Moto newObj = new Moto
                {
                    Title = div.Descendants("h3").FirstOrDefault().InnerText,
                    Link = div.Descendants("a").FirstOrDefault().ChildAttributes("href").FirstOrDefault().Value,
                    ImageUrl = div.Descendants("img").FirstOrDefault().ChildAttributes("src").FirstOrDefault().Value,
                    Price = Convert.ToDouble(div.Descendants("span").FirstOrDefault().InnerText.Split('&')[0])
                };

                motos.Add(newObj);
            }

            await db.InsertMoto(motos);
        }

        private async void Btn_VnExpress_Click(object sender, EventArgs e)
        {
            await CrawlVNExpressasync();

            var listNewsForm = new VNExpressForm(db.GetNews(null));
            listNewsForm.Show();
        }

        private async void Btn_Moto_Click(object sender, EventArgs e)
        {
            await CrawlMotoasync();

            var listMotoForm = new MotoForm(db.GetMotos(null));
            listMotoForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}

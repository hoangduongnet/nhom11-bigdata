using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigData
{
    public partial class VNExpressForm : Form
    {
        List<News> news = new List<News>();
        Database db = new Database();

        public VNExpressForm()
        {
            InitializeComponent();
            db.ConnectDB();
        }

        public VNExpressForm(List<News> listNew)
        {
            news = listNew;
            InitializeComponent();
            db.ConnectDB();
        }

        private void ListNews_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DrListNews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Diagnostics.Process.Start(drListNews.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        public System.Drawing.Bitmap Base64StringToBitmap(string base64String)
        {
            Bitmap bmpReturn = null;

            byte[] byteBuffer = Convert.FromBase64String(base64String);
            MemoryStream memoryStream = new MemoryStream(byteBuffer);

            memoryStream.Position = 0;

            bmpReturn = (Bitmap)Bitmap.FromStream(memoryStream);

            memoryStream.Close();
            memoryStream = null;
            byteBuffer = null;

            return bmpReturn;
        }

        public void LoadData()
        {
            drListNews.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            drListNews.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            drListNews.Rows.Clear();

            foreach (News n in news)
            {
                try
                {
                    System.Net.WebRequest request = System.Net.WebRequest.Create(n.ImageUrl);
                    System.Net.WebResponse response = request.GetResponse();
                    System.IO.Stream responseStream =
                        response.GetResponseStream();

                    drListNews.Rows.Add(n.Title, n.Link, n.Desc, new Bitmap(responseStream));
                }
                catch
                {
                    drListNews.Rows.Add(n.Title, n.Link, n.Desc, new Bitmap(Base64StringToBitmap(n.ImageUrl)));
                }
            }
        }

        private void BtnSearchNews_Click(object sender, EventArgs e)
        {
            news = db.GetNews(txbSearchNews.Text);
            LoadData();
        }

        private void BtnSortNewsASC_Click(object sender, EventArgs e)
        {
            news = db.SortNews(null);
            LoadData();
        }

        private void BtnSortNewsDESC_Click(object sender, EventArgs e)
        {
            news = db.SortNews("DESC");
            LoadData();
        }
    }
}

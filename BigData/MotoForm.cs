using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigData
{
    public partial class MotoForm : Form
    {
        List<Moto> listMoto = new List<Moto>();
        Database db = new Database();

        public MotoForm()
        {
            InitializeComponent();
            db.ConnectDB();
        }

        public MotoForm(List<Moto> motos)
        {
            listMoto = motos;
            InitializeComponent();
            db.ConnectDB();
        }

        private void MotoForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Dr_Moto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Diagnostics.Process.Start(dr_Moto.Rows[e.RowIndex].Cells[2].Value.ToString());
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
            dr_Moto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dr_Moto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dr_Moto.Rows.Clear();

            foreach (Moto n in listMoto)
            {
                try
                {
                    System.Net.WebRequest request = System.Net.WebRequest.Create(n.ImageUrl);
                    System.Net.WebResponse response = request.GetResponse();
                    System.IO.Stream responseStream =
                        response.GetResponseStream();

                    dr_Moto.Rows.Add(n.Title, n.Price.ToString("N0"), n.Link, new Bitmap(responseStream));
                }
                catch
                {
                    dr_Moto.Rows.Add(n.Title, n.Price.ToString("N0"), n.Link, new Bitmap(Base64StringToBitmap(n.ImageUrl)));
                }
            }
        }

        private void BtnSearchMoto_Click(object sender, EventArgs e)
        {
            listMoto = db.GetMotos(txbSearchMoto.Text);
            LoadData();
        }

        private void BtnSortMotoASC_Click(object sender, EventArgs e)
        {
            listMoto = db.SortPriceMotos(null);
            LoadData();
        }

        private void BtnSortMotoDESC_Click(object sender, EventArgs e)
        {
            listMoto = db.SortPriceMotos("DESC");
            LoadData();
        }
    }
}

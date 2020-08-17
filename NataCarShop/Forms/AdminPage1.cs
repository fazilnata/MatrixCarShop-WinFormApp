using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Grid;
using NataCarShop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NataCarShop.Forms
{
    public partial class AdminPage1 : Form
    {
        public AdminPage1()
        {
            InitializeComponent();
        }
        SqlUtils sqlUtils = SqlUtils.getInstance();
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainPage Mp = new MainPage();
            this.Hide();
            Mp.ShowDialog();
            this.Close();
        }
        public void CarsDataRefresh()
        {
            SqlConnection connect = new SqlConnection(sqlUtils.conString);

            connect.Open();
            SqlDataAdapter ad = new SqlDataAdapter("Select * from All_Ads", connect);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            carsdatagridview.DataSource = dt;
            connect.Close();

        }
        private void deletebtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlUtils.conString);
            string query1 = "Delete from Img_Ads where ADS_ID=" + Convert.ToInt32(carsdatagridview.Rows[carsdatagridview.CurrentRow.Index].Cells[0].Value);
            string query2 = "Delete from All_Ads where ID=" + Convert.ToInt32(carsdatagridview.Rows[carsdatagridview.CurrentRow.Index].Cells[0].Value);
            SqlCommand sqlCommand1 = new SqlCommand(query1, sqlConnection);
            SqlCommand sqlCommand2 = new SqlCommand(query2, sqlConnection);
            sqlConnection.Open();
            sqlCommand1.ExecuteNonQuery();
            sqlCommand2.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Uğurlu silindi.");
            CarsDataRefresh();

        }
        private void SearchById()
        {
           
            string query = $@"Select * from All_Ads where ID={idDatatxt.Text}";
            carsdatagridview.DataSource = sqlUtils.GetDataWithAdapter(query);
           
        }
        private void AdminPage1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carShopDataSet1.All_Ads' table. You can move, or remove it, as needed.
            this.all_AdsTableAdapter.Fill(this.carShopDataSet1.All_Ads);



        }
       

        private void searchbtn_Click(object sender, EventArgs e)
        {
            SearchById(); 
        }

        private void carsdatagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idDatatxt.Text = carsdatagridview.CurrentRow.Cells[0].Value.ToString();

        }
    }
}

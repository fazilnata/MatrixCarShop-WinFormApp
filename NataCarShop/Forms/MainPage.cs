using DevExpress.XtraEditors;
using NataCarShop.Classes;
using NataCarShop.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NataCarShop
{
    public partial class MainPage : Form
    {
        GetData getdata = new GetData();
        SqlUtils sqlutils = SqlUtils.getInstance();
       
        public MainPage()
        {
            InitializeComponent();
          
        }

        private void Adminlbl_Click(object sender, EventArgs e)
        {
            AdminLogIn admin = new AdminLogIn();
            this.Hide();
            admin.ShowDialog();
            this.Close();
        }

        private void AddNewAdsBtn_Click(object sender, EventArgs e)
        {
            AddNewCar NewCar = new AddNewCar(this);
         
            NewCar.ShowDialog();
        
        }

        private void BrandData()
        {
            markalkup.Properties.DataSource = getdata.GetBrands();
            markalkup.Properties.DisplayMember = "Brand_Name";
            markalkup.Properties.ValueMember = "ID";
        }
        private void GeneralInfo(LookUpEdit lkUpEdit, string typeID)
        {
            lkUpEdit.Properties.DataSource = getdata.GetGeneralInfo(typeID);
            lkUpEdit.Properties.DisplayMember = "Name";
            lkUpEdit.Properties.ValueMember = "ID";
        }

        private void AboutCompanylbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Niyə ilk addımı bizimlə atmalısınız? Matrix - İT sektorunda təcrübəli mütəxəssislər yetişdirən tədris mərkəzidir.Bugünədək yüzlərlə gəncə təhsil vermiş və onların uğurlarının bir parçası olmağı bacarmışıq.Məqsədimiz Matrix adının da ifadə etdiyi məna kimi tələbələrimizin İnkişaf edən mühit də addımlayaraq, İT sektoru üçün savadlı kadr kimi formalaşmasını təmin etmək və bu istiqamətdə təcrübəli mütəxəssislər yetişdirməkdir.Matrix Təlim Mərkəzində təhsilini uğurla başa vuran hər bir tələbə sertifikatla təmin edilir.");

        }

        private void Connectlbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ünvan : S.Vurğun 43, World Business Centre 20-ci mərtəbə Email: office@matrix.co.az Mobil: +99450 725 20 26 Whatsapp: +99450 725 20 26");

        }

        private void markalkup_EditValueChanged(object sender, EventArgs e)
        {
            modellkup.Properties.DataSource = getdata.GetModels(markalkup.EditValue.ToString());
            modellkup.Properties.DisplayMember = "Model_Name";
            modellkup.Properties.ValueMember = "ID";
        }
        private void DataCardView()
        {
            SqlConnection connect = new SqlConnection(sqlutils.conString);
            connect.Open();

            string query = $@"SELECT ADS.[ID]
	  ,BR.Brand_Name
	  ,ML.Model_Name
       ,[Price]
,Walk
,FounderYear
	  ,GI2.Name as Currency
	  ,(Select Top(1) img.Image from Img_Ads img where img.ADS_ID=ADS.ID) as CarImage
	
  FROM  [dbo].[All_Ads] ADS
  join Models ML on ML.ID=ADS.Model_ID
  join Brands BR on BR.ID=ML.Brand_ID
  join General_Info GI2 on GI2.ID=ADS.Currency_ID";
            SqlCommand command = new SqlCommand(query, connect);
            CarDataCtrl.DataSource = sqlutils.GetDataWithAdapter(query);
            command.ExecuteNonQuery();
            connect.Close();
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            BrandData();
            GeneralInfo(currencylkup, "3");
            GeneralInfo(citylkup, "7");
            CountRow();
            DataCardView();
        }
        public void CountRow()
        {
            SqlConnection connect = new SqlConnection(sqlutils.conString);
            connect.Open();
            string query = "SELECT COUNT(*) FROM All_Ads";
            SqlCommand command = new SqlCommand(query, connect);

            object count = command.ExecuteScalar(); connect.Close();
            if (count != null) { counttxt.Text = count.ToString(); }
            


        }
        private void searchbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(sqlutils.conString);
            connect.Open();
            string query = $@"SELECT ADS.[ID]
	  ,BR.Brand_Name
	  ,ML.Model_Name
      ,Walk
	  ,Price
	  ,GI1.Name as Currency
	  ,Credit
	  ,Barter
	  ,FounderYear
	  ,GI2.Name as City
	  ,GI3.Name as Engine_Volume
	  ,(Select Top(1) img.Image from Img_Ads img where img.ADS_ID=ADS.ID) as CarImage
  FROM [dbo].[All_Ads] ADS
  join Models ML on ML.ID=ADS.Model_ID
  join Brands BR on BR.ID=ML.Brand_ID
  join General_Info GI1 on GI1.ID=ADS.Currency_ID
  join General_Info GI2 on GI2.ID=ADS.City_ID
  join General_Info GI3 on GI3.ID=ADS.Engine_Volume_ID where GI1.Name = '{currencylkup.Text}'";

            if (markalkup.Text != "Bütün markalar") query += $" and Brand_Name='{markalkup.Text}'";
            if (markalkup.Text == "Bütün markalar") query += $" and GI1.Name = '{currencylkup.Text}'";
            if (modellkup.Text != "Bütün modellər") query += $"and Model_Name='{modellkup.Text}'";
            if (modellkup.Text == "Bütün modellər") query += $"and GI1.Name = '{currencylkup.Text}'";
            if (citylkup.Text != "Bütün şəhərlər") query += $"and GI2.Name=N'{citylkup.Text}'";
            if (minpricetxt.Text != "") query += $"and Price>'{minpricetxt.Text}'";
            if (maxpricetxt.Text != "") query += $"and Price<'{maxpricetxt.Text}'";
            if (minyeartxt.Text != "") query += $"and FounderYear>'{minyeartxt.Text}'";
            if (maxyeartxt.Text != "") query += $"and FounderYear<'{maxyeartxt.Text}'";
            if (Creditchk.Checked) query += $"and Credit='{Creditchk.Checked}'";
            if (barterchk.Checked) query += $"and Barter='{barterchk.Checked}'";


            SqlCommand command = new SqlCommand(query, connect);
            CarDataCtrl.DataSource = sqlutils.GetDataWithAdapter(query);
            command.ExecuteNonQuery();
            connect.Close();
        }

        private void CarCardView_Click(object sender, EventArgs e)
        {
            int id = (int)CarCardView.GetFocusedRowCellValue("ID");
            AboutCars CarsInfo = new AboutCars(id);
          
            CarsInfo.ShowDialog();
         
          
        }

       

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Təşəkkür edirik");
        }
    }
}

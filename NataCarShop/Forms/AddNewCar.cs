using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Card;
using NataCarShop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NataCarShop.Forms
{
    public partial class AddNewCar : Form
    {
        MainPage MP;
        public AddNewCar(MainPage MP)
        {
            InitializeComponent();
            this.MP = MP;
           
        }
        GetData getdata = new GetData();
        SqlUtils sqlutils = SqlUtils.getInstance();

        private void BrandData()
        {
            brandslkup.Properties.DataSource = getdata.GetBrands();
            brandslkup.Properties.DisplayMember = "Brand_Name";
            brandslkup.Properties.ValueMember = "ID";
        }
        private void GeneralInfo(LookUpEdit lkUpEdit, string typeID)
        {
            lkUpEdit.Properties.DataSource = getdata.GetGeneralInfo(typeID);
            lkUpEdit.Properties.DisplayMember = "Name";
            lkUpEdit.Properties.ValueMember = "ID";
        }
        private void YearsCount()
        {
            List<int> Years = new List<int>();
            int currentYear = DateTime.Now.Year;
            for (int i = 1980; i <= currentYear; i++)
            {
                Years.Add(i);
            }
            founderyearlkup.Properties.DataSource = Years;
        }
        private void AddNewCar_Load(object sender, EventArgs e)
        {
            BrandData();
            YearsCount();
            GeneralInfo(bodytypelkup, "1");
            GeneralInfo(colorlkup, "2");
            GeneralInfo(fueltypelkup, "4");
            GeneralInfo(transmissionlkup, "5");
            GeneralInfo(gearboxlkup, "6");
            GeneralInfo(citylkup, "7");
            GeneralInfo(enginevolumelkup, "8");
            imggridctrl.DataSource = getdata.GetImages("-1");
        }
        private bool ControlEmpty()
        {
            bool control = true;
            if (brandslkup.EditValue == null) { brandslkup.ErrorText = "Markanı seçin"; control = false; }
            if (modellkup.EditValue == null) { modellkup.ErrorText = "Modeli seçin"; control = false; }
            if (bodytypelkup.EditValue == null) { bodytypelkup.ErrorText = "Ban növünü seçin"; control = false; }
            if (fueltypelkup.EditValue == null) { fueltypelkup.ErrorText = "Yanacağın növünü seçin"; control = false; }
            if (colorlkup.EditValue == null) { colorlkup.ErrorText = "Rəngi seçin"; control = false; }
            if (founderyearlkup.EditValue == null) { founderyearlkup.ErrorText = "Buraxılış ilini seçin"; control = false; }
            if (gearboxlkup.EditValue == null) { gearboxlkup.ErrorText = "Sürət qutusunu seçin"; control = false; }
            if (transmissionlkup.EditValue == null) { transmissionlkup.ErrorText = "Ötürücünü seçin"; control = false; }
            if (enginevolumelkup.EditValue == null) { enginevolumelkup.ErrorText = "Mühərrikin həcmini seçin"; control = false; }
            if (engineHplbl.Text == "") { MessageBox.Show("Mühərrikin gücünü daxil edin"); control = false; }
            if (MemoİnfoCar.Text == "") { MemoİnfoCar.ErrorText = "Əlavə məlumat daxil edin."; control = false; }
            if (imgcardview.DataRowCount < 3) { MessageBox.Show("Ən azı 3 çəkil daxil edilməlidir!"); control = false; }
            if (price_nm.Value == 0) { MessageBox.Show("Qiymət daxil edin."); control = false; }
            if (nametxt.Text == "") { nametxt.ErrorText = "Adınızı daxil edin"; control = false; }
            if (citylkup.Text == "") { citylkup.ErrorText = "Şəhəri daxil edin"; control = false; }
            if (connectiontxt.Text == "") { connectiontxt.ErrorText = "Əlaqə nömrənizi daxil edin"; control = false; }
            return control;
        }
       
        public int InsertNewCar()
        {
            SqlConnection sqlConnection = new SqlConnection(SqlUtils.getInstance().conString);
            sqlConnection.Open();
            string query = $@"INSERT INTO [dbo].[All_Ads]
           ([Model_ID]
           ,[Body_Type_ID]
           ,[Walk]
           ,[Color_ID]
           ,[Price]
           ,[Currency_ID]
           ,[Credit]
           ,[Barter]
           ,[Fuel_Type_ID]
           ,[Transmission_ID]
           ,[Gearbox_ID]
           ,[FounderYear]
           ,[Engine_Volume_ID]
           ,[HP]
           ,[Note]
           ,[Alloy_Wheels]
           ,[Central_Closure]
           ,[Leather_Salon]
           ,[Seat_Ventilation]
           ,[USA]
           ,[Parking_Radar]
           ,[Xenon]
           ,[Luke]
           ,[Conditioner]
           ,[Rear_Camera]
           ,[Rain_Sensor]
           ,[Seat_Heating]
           ,[Side_Curtains]
           ,[Name]
           ,[City_ID]
           ,[Contact])
     VALUES
           (@Model_ID
           ,@Body_Type_ID
           ,@Walk
           ,@Color_ID
           ,@Price
           ,@Currency_ID
           ,@Credit
           ,@Barter
           ,@Fuel_Type_ID
           ,@Transmission_ID
           ,@Gearbox_ID
           ,@FounderYear
           ,@Engine_Volume_ID
           ,@HP
           ,@Note
           ,@Alloy_Wheels
           ,@Central_Closure
           ,@Leather_Salon
           ,@Seat_Ventilation
           ,@USA
           ,@Parking_Radar
           ,@Xenon
           ,@Luke
           ,@Conditioner
           ,@Rear_Camera
           ,@Rain_Sensor
           ,@Seat_Heating
           ,@Side_Curtains
           ,@Name
           ,@City_ID
           ,@Contact); Select SCOPE_IDENTITY();";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("Brand_ID", SqlDbType.Int).Value = brandslkup.EditValue;
            sqlCommand.Parameters.Add("Model_ID", SqlDbType.Int).Value = modellkup.EditValue;
            sqlCommand.Parameters.Add("Body_Type_ID", SqlDbType.Int).Value = bodytypelkup.EditValue;
            sqlCommand.Parameters.Add("Walk", SqlDbType.Int).Value = walk_nm.Value;
            sqlCommand.Parameters.Add("Color_ID", SqlDbType.Int).Value = colorlkup.EditValue;
            sqlCommand.Parameters.Add("Price", SqlDbType.Int).Value = price_nm.Value;
            sqlCommand.Parameters.Add("Currency_ID", SqlDbType.Int).Value = CurrencyRadioBtn.EditValue;
            sqlCommand.Parameters.Add("Credit", SqlDbType.Bit).Value = creditck.Checked;
            sqlCommand.Parameters.Add("Barter", SqlDbType.Bit).Value = barterchk.Checked;
            sqlCommand.Parameters.Add("Note", SqlDbType.NVarChar).Value = MemoİnfoCar.EditValue;
            sqlCommand.Parameters.Add("Fuel_Type_ID", SqlDbType.Int).Value = fueltypelkup.EditValue;
            sqlCommand.Parameters.Add("Transmission_ID", SqlDbType.Int).Value = transmissionlkup.EditValue;
            sqlCommand.Parameters.Add("Gearbox_ID", SqlDbType.Int).Value = gearboxlkup.EditValue;
            sqlCommand.Parameters.Add("FounderYear", SqlDbType.Int).Value = founderyearlkup.EditValue;
            sqlCommand.Parameters.Add("Engine_Volume_ID", SqlDbType.Int).Value = enginevolumelkup.EditValue;
            sqlCommand.Parameters.Add("HP", SqlDbType.Int).Value = enginepower_nm.Value;
            sqlCommand.Parameters.Add("Alloy_Wheels", SqlDbType.Bit).Value = chb_Alloy_wheels.Checked;
            sqlCommand.Parameters.Add("Central_Closure", SqlDbType.Bit).Value = chb_Central_closure.Checked;
            sqlCommand.Parameters.Add("Leather_Salon", SqlDbType.Bit).Value = chb_Leather_salon.Checked;
            sqlCommand.Parameters.Add("Seat_Ventilation", SqlDbType.Bit).Value = chb_Seat_ventilation.Checked;
            sqlCommand.Parameters.Add("USA", SqlDbType.Bit).Value = chb_USA.Checked;
            sqlCommand.Parameters.Add("Parking_Radar", SqlDbType.Bit).Value = chb_Parking_radar.Checked;
            sqlCommand.Parameters.Add("Xenon", SqlDbType.Bit).Value = chb_Xenon.Checked;
            sqlCommand.Parameters.Add("Luke", SqlDbType.Bit).Value = chb_Luke.Checked;
            sqlCommand.Parameters.Add("Conditioner", SqlDbType.Bit).Value = chb_Conditioner.Checked;
            sqlCommand.Parameters.Add("Rear_Camera", SqlDbType.Bit).Value = chb_Rear_view_camera.Checked;
            sqlCommand.Parameters.Add("Rain_Sensor", SqlDbType.Bit).Value = chb_Rain_sensor.Checked;
            sqlCommand.Parameters.Add("Seat_Heating", SqlDbType.Bit).Value = chb_Seat_heating.Checked;
            sqlCommand.Parameters.Add("Side_Curtains", SqlDbType.Bit).Value = chb_Side_curtains.Checked;
            sqlCommand.Parameters.Add("Name", SqlDbType.NVarChar).Value = nametxt.EditValue;
            sqlCommand.Parameters.Add("City_ID", SqlDbType.Int).Value = citylkup.EditValue;
            sqlCommand.Parameters.Add("Contact", SqlDbType.NVarChar).Value = connectiontxt.EditValue;
            int id= Convert.ToInt32( sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;


        }
        public void Cars()
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
            MP.CarDataCtrl.DataSource = sqlutils.GetDataWithAdapter(query);
            MP.CountRow();
            command.ExecuteNonQuery();
            connect.Close();

        }
        private void InsertAll()
        {
            DialogResult dialog = MessageBox.Show("Elanın əlavə olunmasina əminsiniz?", "Sual", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {

                 SqlConnection sqlConnection = new SqlConnection(SqlUtils.getInstance().conString);
            sqlConnection.Open();
            InsertAdsImage();
           
            sqlConnection.Close();
             Cars();

            MessageBox.Show("Məlumat uğurla yadda saxlanıldı.", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            this.Close();
        }
            }
           

        DataRow selected_img;
        private void imgcardview_Click(object sender, EventArgs e)
        {
            selected_img = imgcardview.GetDataRow(imgcardview.GetRowHandle(0));
        }


        private void grpCntrlPictures_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button == grpCntrlPictures.CustomHeaderButtons[0])
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
                DataTable dtTableImage = (DataTable)imggridctrl.DataSource;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        dtTableImage.Rows.Add(0, GetImage(fileName));
                        GetImage(fileName);
                    }
                }
            }
                if (e.Button == grpCntrlPictures.CustomHeaderButtons[1])
                {
                   imggridctrl.DataSource = getdata.GetImages("-1");
                }
            
           
        }

        

        private byte[] GetImage(string ImgAds)
        {
            byte[] img = null;
            FileStream fileStream = new FileStream(ImgAds, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            img = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();
            return img;
        }

        private void InsertAdsImage()
        {
            {
                int ADS_ID = InsertNewCar();
                SqlConnection connect = new SqlConnection(SqlUtils.getInstance().conString);
               
                DataTable dtTableImages = (DataTable)imggridctrl.DataSource;
                for (int i = 0; i < dtTableImages.Rows.Count; i++)
                {    connect.Open();
                    DataRow dtRowImage = dtTableImages.Rows[i];
                    string query = $@"INSERT INTO [dbo].[Img_Ads]
           ([Image]
           ,[ADS_ID])
     VALUES
           (@Image
           ,@ADS_ID)";
                    SqlCommand sqlCommand = new SqlCommand(query, connect);               
                    sqlCommand.Parameters.Add("Image", SqlDbType.VarBinary).Value = dtRowImage["Image"];
                
                    sqlCommand.Parameters.Add("ADS_ID", SqlDbType.Int).Value = ADS_ID;
                    sqlCommand.ExecuteNonQuery();
                    connect.Close();
                }

            }
        }

        private void AddNewCarBtn_Click(object sender, EventArgs e)
        {
            if (ControlEmpty())
            { InsertAll(); }
        }

        private void brandslkup_EditValueChanged(object sender, EventArgs e)
        {
            modellkup.Properties.DataSource = getdata.GetModels(brandslkup.EditValue.ToString());
            modellkup.Properties.DisplayMember = "Model_Name";
            modellkup.Properties.ValueMember = "ID";
        }

        
    }
} 
    

using DevExpress.ClipboardSource.SpreadsheetML;
using NataCarShop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.Utils.Helpers;
using DevExpress.Utils.DirectXPaint;

namespace NataCarShop.Forms
{
    public partial class AboutCars : Form
    {
        SqlUtils sqlutils = SqlUtils.getInstance();
        int id;
        public AboutCars(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        public void GetİmgFromData()
        { SqlConnection connect=new SqlConnection(sqlutils.conString);
            connect.Open();
            string query = $@"SELECT[ID]
      ,[Image]
      ,[ADS_ID]
  FROM[dbo].[Img_Ads] where ADS_ID="+id;
            SqlCommand command = new SqlCommand(query, connect);
            AboutCarGridCtrl.DataSource = sqlutils.GetDataWithAdapter(query);
            command.ExecuteNonQuery();
            connect.Close();
        }
        public void GetInfoCars()
        {
            string query = $@"SELECT ADS.[ID]
	  ,BR.Brand_Name
	  ,ML.Model_Name
	  ,GI3.Name as Body_Type
	  ,GI4.Name as Color
	  ,[Price]
	  ,GI2.Name as Currency
	  ,FounderYear
	  ,Walk
	  ,GI5.Name as Gearbox
	  ,GI6.Name as Engine_Volume
	  ,HP
      ,Note
	  ,GI7.Name as Fuel_Type
	  ,GI8.Name as Transmission
	  ,GI9.Name City
	  ,Alloy_Wheels
	  ,USA
	  ,Luke
	  ,Rain_Sensor
	  ,Central_Closure
	  ,Parking_Radar
	  ,Conditioner
	  ,Seat_Heating
	  ,Leather_Salon
	  ,Xenon
	  ,Rear_Camera
	  ,Side_Curtains
	  ,Seat_Ventilation
      ,Credit
      ,Barter
,ADS.Name
,City_ID
,Contact
  FROM [dbo].[All_Ads] ADS
  join Models ML on ML.ID=ADS.Model_ID
  join Brands BR on BR.ID=ML.Brand_ID
  join General_Info GI1 on GI1.ID=ADS.City_ID
  join General_Info GI2 on GI2.ID=ADS.Currency_ID
  join General_Info GI3 on GI3.ID=ADS.Body_Type_ID
  join General_Info GI4 on GI4.ID=ADS.Color_ID
  join General_Info GI5 on GI5.ID=ADS.Gearbox_ID
  join General_Info GI6 on GI6.ID=ADS.Engine_Volume_ID
  join General_Info GI7 on GI7.ID=ADS.Fuel_Type_ID
  join General_Info GI8 on GI8.ID=ADS.Transmission_ID
  join General_Info GI9 on GI9.ID=ADS.City_ID where ADS.[ID]="+id ;
            DataTable dt = sqlutils.GetDataWithAdapter(query);
            idNumber.Text="#"+ dt.Rows[0]["ID"].ToString();
           
            fuelbl.Text = dt.Rows[0]["Fuel_Type"].ToString();
            translbl.Text = dt.Rows[0]["Transmission"].ToString();
            cityylbl.Text = dt.Rows[0]["City"].ToString();
            markalbl.Text = dt.Rows[0]["Brand_Name"].ToString();
            modellbl.Text = dt.Rows[0]["Model_Name"].ToString();
            founderyear.Text = dt.Rows[0]["FounderYear"].ToString();
            bodylbl.Text = dt.Rows[0]["Body_Type"].ToString();
            colourlbl.Text = dt.Rows[0]["Color"].ToString();
            volumlbl.Text = dt.Rows[0]["Engine_Volume"].ToString();
            powerlbl.Text = dt.Rows[0]["HP"].ToString();
            walkinglbl.Text = dt.Rows[0]["Walk"].ToString();
            gearlbl.Text = dt.Rows[0]["Gearbox"].ToString();
            pricelbl.Text = dt.Rows[0]["Price"].ToString();
            memolbl.Text= dt.Rows[0]["Note"].ToString();
         nameslbl.Text = pricelbl.Text = dt.Rows[0]["Name"].ToString();
            conlbl.Text = pricelbl.Text = dt.Rows[0]["Contact"].ToString();
            if (dt.Rows[0]["Currency"].ToString() == "AZN")
                currencylbl.Text= "AZN";
            else if (dt.Rows[0]["Currency"].ToString() == "USD")
                currencylbl.Text="USD";
            else
                currencylbl.Text = "EURO";
            Alloy_wheels.Checked = (bool)dt.Rows[0]["Alloy_Wheels"];
            ABS.Checked = (bool)dt.Rows[0]["USA"];

            Luke.Checked = (bool)dt.Rows[0]["Luke"];

            Rain_sensor.Checked = (bool)dt.Rows[0]["Rain_Sensor"];

         Central_closure.Checked = (bool)dt.Rows[0]["Central_Closure"];

            Parking_radar.Checked = (bool)dt.Rows[0]["Parking_Radar"];

          Conditioner.Checked = (bool)dt.Rows[0]["Conditioner"];

            Seat_heating.Checked = (bool)dt.Rows[0]["Seat_Heating"];

           Leather_salon.Checked = (bool)dt.Rows[0]["Leather_Salon"];

           Xenon.Checked = (bool)dt.Rows[0]["Xenon"];

            Rear_view_camera.Checked = (bool)dt.Rows[0]["Rear_Camera"];

           Side_curtains.Checked = (bool)dt.Rows[0]["Side_Curtains"];

            Seat_ventilation.Checked = (bool)dt.Rows[0]["Seat_Ventilation"];
            creditck.Checked = (bool)dt.Rows[0]["Credit"];
          barterchk.Checked = (bool)dt.Rows[0]["Barter"];


        }
        private void AboutCars_Load(object sender, EventArgs e)
        {
            timer1.Start();
            GetİmgFromData();
            GetInfoCars();
            labeltime.Text = DateTime.Now.ToLongTimeString();

        }

        private void GrpAboutCar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labeltime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NataCarShop.Classes
{
    class GetData
    {
        SqlUtils sqlUtils = SqlUtils.getInstance();
        public DataTable GetBrands()
        {
            string _query = @"Select ID, Brand_Name
            from Brands
            Union
            Select - 1, N'Bütün markalar'";
            return sqlUtils.GetDataWithAdapter(_query);
        }
        public DataTable GetModels(string brandId)
        {
            string _query = $"SELECT [ID],[Model_Name] FROM[dbo].[Models] where Brand_ID={brandId} union Select - 1, N'Bütün modellər' ";
            return sqlUtils.GetDataWithAdapter(_query);
        }
        public DataTable GetGeneralInfo(string typeID)
        {
            string _query = $"Select ID, Name from General_Info where Type_ID={typeID}";
            return sqlUtils.GetDataWithAdapter(_query);
        }
        public DataTable GetImages(string ADS_ID)
        {
            string query = $"SELECT [ID],[Image] ,[ADS_ID] FROM[dbo].[Img_Ads] where ADS_ID={ADS_ID}";
            return SqlUtils.getInstance().GetDataWithAdapter(query);
        }
    }
}

using AKAR_STC;
using System;
using System.Data;
using System.Data.SqlClient;

namespace AKAR_DAL
{
    public class DALProduct
    {

        #region Decare Some Verable

        private bool pFlag;
        public bool vFlag
        {
            get { return pFlag; }
            
        }



        private string pExceptionMessage;
        public string vExceptionMessage
        {
            get { return pExceptionMessage; }

        }

        #endregion




        public DataTable RPR_SR_PRODUCT_INFO()
        {

            try
            {
                SqlConnection connection = new SqlConnection(Connection.ConnectionStringSqlServer);
                connection.Open();
                SqlCommand komut = new SqlCommand("select c.CategoryName , Count( p.ProductName ) as URUN_MIKTARI ,sum(p.UnitPrice) TOPLAM_NE_KADAR_EDIYOR  from Products p inner join Categories c on c.CategoryID = p.CategoryID group by CategoryName", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                pFlag = false;
                pExceptionMessage = ex.Message;
                return null;

            }

        }
    }
}

using System.Data;

namespace AKAR_BL.DataAdapter
{
    public class BLProduct
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
            AKAR_DAL.DALProduct dal = new AKAR_DAL.DALProduct();
            var model = dal.RPR_SR_PRODUCT_INFO();
            this.pFlag = dal.vFlag;
            this.pExceptionMessage = dal.vExceptionMessage;
            return model;
        }




    }


}

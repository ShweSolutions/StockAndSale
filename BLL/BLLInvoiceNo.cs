using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockAndSale
{
    class BLLInvoiceNo
    {
        public Boolean LoadInvoiceNoRow(DEInvoiceNo invoiceNo)
        {
            DALInvoiceNo obj_DALInvoiceNo = new DALInvoiceNo();

            Boolean has_Row = obj_DALInvoiceNo.LoadInvoiceNoRow(invoiceNo);

            obj_DALInvoiceNo = null;

            return has_Row;
        }
    }
}

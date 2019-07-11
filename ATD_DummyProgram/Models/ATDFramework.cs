using ATD_DummyProgram.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATD_DummyProgram.Models
{
    class ATDFramework : IATDProductCreator
    {
        readonly private int _partNumber;
        readonly private ProductFamily _productFamily;
        readonly private string _productName;
        readonly private int _cureTimeInMinutes;

        public ATDFramework(
            int partNumber,
            ProductFamily productFamily,
            string productName,
            int cureTimeInMinutes)
        {
            partNumber = _partNumber;
            productFamily = _productFamily;
            productName = _productName;
            cureTimeInMinutes = _cureTimeInMinutes;
        }

        public void CreateNewProduct(
            int partNumber,
            ProductFamily productFamily,
            string productName,
            int cureTimeInMinutes)
        {
            ATDFramework atd = new ATDFramework(
                partNumber,
                productFamily,
                productName,
                cureTimeInMinutes);
        }

    }
}

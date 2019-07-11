using ATD_DummyProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATD_DummyProgram.Interfaces
{
    interface IATDProductCreator
    {

        void CreateNewProduct(
            int partNumber,
            ProductFamily productFamily,
            string productName,
            int cureTimeInMinutes);

    }
}

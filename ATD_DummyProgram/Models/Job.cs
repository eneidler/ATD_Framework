using ATD_DummyProgram.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATD_DummyProgram.Models
{
    class Job
    {
        private readonly int _jobNumber;
        private readonly int _minutesToCompletion;
        private readonly IATDProductCreator _jobATD;
        private readonly Press _jobPress;


        public Job()
        {

        }

    }
}

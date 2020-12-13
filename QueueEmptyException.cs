using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectRustan
{
    /***************************************************************
    * Name        : QueueEmptyException
    * Author      : Alicia Rustan
    * Created     : 12/08/2020
    ***************************************************************/
    class QueueEmptyException : Exception
    {
        public override string Message
        {
            get
            {
                return "Queue is Empty";
            }
        }
    }
}

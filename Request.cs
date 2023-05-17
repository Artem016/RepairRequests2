using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RepairRequests2
{
    internal class Request
    {
        internal string fio;
        internal string typeEquipmen;
        internal string brandEquimen;
        internal string modelEquimen;
        internal string discriptionProblem;
        internal bool isDone;
        DateTime dateRequest;

        internal Request(string fio, string typeEquipmen, string brandEquimen, string modelEquimen, string discriptionProblem, bool isDone, DateTime dateRequest)
        {
            this.fio = fio;
            this.typeEquipmen = typeEquipmen;
            this.brandEquimen = brandEquimen;
            this.modelEquimen = modelEquimen;
            this.discriptionProblem = discriptionProblem;
            this.isDone = isDone;
            this.dateRequest = dateRequest;
        }
    }
}

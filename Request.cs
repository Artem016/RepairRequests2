﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RepairRequests2
{

    public class Request
    {
        public string fio;
        public string typeEquipmen;
        public string brandEquimen;
        public string modelEquimen;
        public string discriptionProblem;
        public bool isDone;
        DateTime dateRequest;

        public Request(string fio, string typeEquipmen, string brandEquimen, string modelEquimen, string discriptionProblem, bool isDone, DateTime dateRequest)
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

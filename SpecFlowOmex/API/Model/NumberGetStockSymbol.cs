using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowOmex.API.Model
{
    public class NumberGetStockSymbol
    {
        public class Data
        {
            public string lVal18AFC { get; set; }
            public string lVal30 { get; set; }
            public string cGrValCot { get; set; }
            public double qPasCotFxeVal { get; set; }
            public int qQtTranMarVal { get; set; }
            public int qTitMinSaiOmProd { get; set; }
            public int qTitMaxSaiOmProd { get; set; }
            public int baseVol { get; set; }
            public string insCode { get; set; }
            public long zTitad { get; set; }
            public bool ipo { get; set; }
            public int yVal { get; set; }
            public int yDeComp { get; set; }
            public string cSecVal { get; set; }
            public string cSoSecVal { get; set; }
            public string cComVal { get; set; }
            public Flow flow { get; set; }
            public Status status { get; set; }
            public string marketType { get; set; }
        }

        public class Flow
        {
            public string value { get; set; }
            public string translate { get; set; }
        }

        public class Response
        {
            public bool successful { get; set; }
            public object count { get; set; }
            public Data data { get; set; }
            public object errors { get; set; }
        }

        public class RootNumber
        {
            public Response response { get; set; }
        }

        public class Status
        {
            public int id { get; set; }
            public object instrumentId { get; set; }
            public string status { get; set; }
        }



    }
}

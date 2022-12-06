using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowOmex.API.Model
{
    public class PirceGetStockSymbol
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Data
        {

            public long ptId { get; set; }
            public int psGelStaMin { get; set; }
            public int psGelStaMax { get; set; }
            public long id { get; set; }
            public string instrumentId { get; set; }
            public string dEven { get; set; }
            public string hEven { get; set; }
            public int zTotTran { get; set; }
            public int qTotTran5J { get; set; }
            public int qTotCap { get; set; }
            public int pClosing { get; set; }
            public int pDrCotVal { get; set; }
            public object priceMin { get; set; }
            public object priceMax { get; set; }
            public object todayFirstPrice { get; set; }
            public int yesterdayPrice { get; set; }
        }

        public class Response
        {
            public Data result { get; set; }

            public bool successful { get; set; }
            public object count { get; set; }
            public Data data { get; set; }
            public object errors { get; set; }
        }

        public class RootPirce
        {
            public Response response { get; set; }
        }


    }
}

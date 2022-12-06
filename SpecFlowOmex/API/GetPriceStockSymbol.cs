using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using RestSharp.Serialization.Json;
using SpecFlowOmex.API.Model;
using System;
using System.Text.Json;
using static SpecFlowOmex.API.Model.NumberGetStockSymbol;
using static SpecFlowOmex.API.Model.PirceGetStockSymbol;

namespace SpecFlowOmex.API
{


    public class GetPriceStockSymbol
    {
        public string code12stocksymbol = "IRO1SIPA0001";

        [Test]
        public void GetPriceMaxAndMin(int pirceMinplus, int numberMinplus, int code12stocksymbol)
        {
            RestClient client = new RestClient("https://beta-red.tsetab.com/api/");
            RestRequest request = new RestRequest("PublicMessages/InstTrade?instrumentId=" + code12stocksymbol, Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            var res1 = System.Text.Json.JsonSerializer.Deserialize<RootPirce>(response.Content);
            Console.WriteLine(res1.response.data.psGelStaMin);
            Console.WriteLine(pirceMinplus);
            int PirceMinPlus = res1.response.data.psGelStaMin + pirceMinplus;
            Console.WriteLine(PirceMinPlus);
            RestClient clientnumber = new RestClient("https://beta-red.tsetab.com/api/");
            RestRequest requestnumber = new RestRequest("PublicMessages/Instrument?instrumentId==" + code12stocksymbol, Method.GET);
            IRestResponse responsenumber = clientnumber.Execute(requestnumber);
            var res2 = System.Text.Json.JsonSerializer.Deserialize<RootNumber>(responsenumber.Content);
            int NumberMinPlus = res2.response.data.qTitMinSaiOmProd + numberMinplus;
            Console.WriteLine(numberMinplus);
            Console.WriteLine(res1.response.data.psGelStaMin);
        }
        [Test]
        public void auto()
        {
            var client2 = new RestClient("https://dev-white.tsetab.com/api/Accounts/LoginWithoutCaptcha");
            client2.Timeout = -1;
            var request2 = new RestRequest(Method.POST);
            request2.AddHeader("Content-Type", "application/json");
            request2.AddHeader("Cookie", "_sk=JTyKS1iLhO%23H4; _sk_ba_1=fSRXk3pFGPB4fB; _sk_dp_1=6dkudgQwu9lW; _sk_dp_115597=SikMBUY1hBQS; _sk_dp_125116=rj9OYLWgcoZf; _sk_dp_178706=DjexNiORS7tsux; _sk_dp_178871=Gdjen4Pvi2TE; _sk_dp_4=xuLUVounM9Gp9m");
            var body = @"{" + "\n" +
            @"    ""USERNAME"": ""0153540664""," + "\n" +
            @"    ""PASSWORD"": ""TseTab.ir123""" + "\n" +
            @"}" + "\n" +
            @"" + "\n" +
            @"// {" + "\n" +
            @"//     ""USERNAME"": ""10101680726""," + "\n" +
            @"//     ""PASSWORD"": ""P@10+1020""" + "\n" +
            @"// }" + "\n" +
            @"" + "\n" +
            @"// {" + "\n" +
            @"//     ""USERNAME"": ""2580083731""," + "\n" +
            @"//     ""PASSWORD"": ""47fFKJxOo9""" + "\n" +
            @"// }" + "\n" +
            @"" + "\n" +
            @"";
            request2.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response2 = client2.Execute(request2);
            Console.WriteLine(response2.Content);
        }
        [Test]
        public void PostSellAndPrice()
        {
            RestClient client1 = new RestClient("https://dev-red.tsetab.com/api/");
            RestRequest request1 = new RestRequest("Orders/OrderEntry", Method.POST);
            request1.AddHeader("Content-Type", "application/json");
            request1.AddHeader("Cookie", "_sk=JTyKS1iLhO%23H4; _sk_ba_1=fSRXk3pFGPB4fB; _sk_dp_1=6dkudgQwu9lW; _sk_dp_115597=SikMBUY1hBQS; _sk_dp_125116=rj9OYLWgcoZf; _sk_dp_178706=DjexNiORS7tsux; _sk_dp_178871=Gdjen4Pvi2TE; _sk_dp_4=kfm5bVJnzFv6v");
     //       request1.AddHeader("Authorization", "eyJhbGciOiJBMjU2R0NNS1ciLCJlbmMiOiJBMjU2Q0JDLUhTNTEyIiwiaXYiOiJEdXFyZUp0UmpURmlfd2lJIiwidGFnIjoidmg4VjR5dkt2bm9mTDFHWThqM0ttZyJ9.0m7nrG0QIKedELvRGMZkCDZxssPuUYIHa-YNAfYCVu0Kd1qh5LWMMKUeCyM8IHFHZ4g38JK9oGgqvNkq2yn4zA.dcU4_y9hU5xhwW5gn9votw.71N2FTyjf5CoIDfcoakg0gFhfV2oCxDfLvz28xfcrmOLA7oKVc8c_vjW7woUBzLS5tvEaQXHNFTewsZTBcUBWGkijSjBqZ2oOq9uB0Y_Zmy8jvs1IbpKwwZFDtGrBXafiH_tXGYuaQbnHpbpPoQmNoSkRlZht6M6e0T2U3fgDgaJrv_t4vWq0kcQ7nFQu8kSw_DV0CKVcO53bVWFVv_KuEnXCUXwEGk2QPVPDurkwRB0jU71Pik1FDxYsxhPCzKxpdXXqgogknO0czcSfLVlBmvVh3w5DPi5WOEAGnMFon2U0GK_CrLjHLdYJpVe7Z6ssTgWFi3hLU3T-hwwzJApbX7HpkGy_Uf2a2tfJ9jl9OQfDGOs9Q9GD7_R_ZMach_YN06W1fp2-kaoGZzTIscYu7AEXB7HocIU3oTsmrB5DXamVewZumVCORzVx87I_zhfOTTFOL0vxD_vexbhwgjjtg8l12vICH-MJi4kLAIJwG-eeDcKM1pJzu0EjdpreN8n.LyNghM_hHHpsSMuGrj0VmVEwxcFfHhyRecwFavvrvWA");
      //      request1.AddHeader("Authorization", "Bearer " + res2.result.accessToken);

            IRestResponse response1 = client1.Execute(request1);
            var body = @"{
                        " + "\n" +
                        @"    ""DValiOM"": null,
                        " + "\n" +
                        @"    ""ExecutionType"": ""Instant"",
                        " + "\n" +
                        @"    ""ISensOM"": ""Buy"", //Sell //Buy
                        " + "\n" +
                        @"    ""InstrumentId"": ""IROFBMLT5521"",
                        " + "\n" +
                        @"    ""PLimSaiOM"": 1,
                        " + "\n" +
                        @"    ""PrincipalId"":125116, //125116,// 122288,
                        " + "\n" +
                        @"    ""QTitDvlOM"": 0,
                        " + "\n" +
                        @"    ""QTitTotOM"": 100,
                        " + "\n" +
                        @"    ""YValiOmNSC"": ""Day"",
                        " + "\n" +
                        @"    ""extraInfo"": ""{\""ark\"":\""ed31856b-9295-4470-8e32-29d0aad77d42\""}""
                        " + "\n" +
                        @"}";
            request1.AddParameter("application/json", body, ParameterType.RequestBody);

            Console.WriteLine(response1.Content);
            Console.WriteLine(response1.StatusCode);

        }
    }
}

//IRO1SIPA0001

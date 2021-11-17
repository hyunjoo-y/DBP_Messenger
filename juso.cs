// C# 샘플 코드
using System;
using System.Net;
using System.Net.Http;
using System.IO;

namespace on_off_proj
{
    static class juso
    {
        static HttpClient client = new HttpClient();
        
        static void api()
        {
            string url = "http://openapi.epost.go.kr/postal/retrieveNewAdressAreaCdService/retrieveNewAdressAreaCdService/getNewAddressListAreaCd"; // URL
            url += "?ServiceKey=" + "oLhfYPiKJvAXK7D%2FqmZ3xrTM%2B9Vbv3OXIJ2577XgqiCofU2B4iI%2Fi%2FWZHQKLJ6k14rZFne8INX6FworEZW943w%3D%3D"; // Service Key
            url += "&searchSe=dong";
            url += "&srchwrd=주월동 408-1";
            url += "&countPerPage=10";
            url += "currentPage=1";

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            string results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
            }

            Console.WriteLine(results);
        }
    }
}
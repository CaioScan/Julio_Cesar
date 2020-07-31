using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace verificaCNPJ
{
    class Program
    {
        static void Main(string[] args)
        {
            Atualizar.PegaInformacoes();

            Program.Enviar();
        }
       

        static void Enviar()
        {

            var client = new RestClient("https://api.codenation.dev/v1/challenge/dev-ps/submit-solution?token=2c7f4adfe2e51bd54772a8fd0aa0e124867206fe");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Content-Length", "558");
            request.AddHeader("Accept-Encoding", "gzip, deflate, br");
            request.AddHeader("Content-Type", "multipart/form-data; boundary=--------------------------582379253842472780113562");
            request.AddHeader("Host", "api.codenation.dev");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.22.0");
            request.AddHeader("content-type", "multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW");
            request.AddParameter("multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW", "------WebKitFormBoundary7MA4YWxkTrZu0gW\r\nContent-Disposition: form-data; name=\"answer\"; filename=\"answer.json\"\r\nContent-Type: application/json\r\n\r\n\r\n------WebKitFormBoundary7MA4YWxkTrZu0gW--", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);



        }
    }
}


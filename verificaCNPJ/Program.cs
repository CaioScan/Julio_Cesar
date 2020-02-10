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
            try
            {


                //string requestURL = "https://api.codenation.dev/v1/challenge/dev-ps/submit-solution?token=2c7f4adfe2e51bd54772a8fd0aa0e124867206fe";
                //string fileName = "D:\\Desenvolvimento\\answer.json";
                //WebClient wc = new WebClient();
                //byte[] bytes = wc.DownloadData(fileName); // You need to do this download if your file is on any other server otherwise you can convert that file directly to bytes  
                //Dictionary<string, object> postParameters = new Dictionary<string, object>();
                //// Add your parameters here  
                //postParameters.Add("file", new Post.FileParameter(bytes, Path.GetFileName(fileName), "text/json"));
                //string userAgent = "Manatee 4db";
                //HttpWebResponse webResponse = Post.MultipartFormPost(requestURL, userAgent, postParameters);
                //// Process response  
                //StreamReader responseReader = new StreamReader(webResponse.GetResponseStream());
                ////returnResponseText = responseReader.ReadToEnd();
                //webResponse.Close();


                //string requestURL = "https://api.codenation.dev/v1/challenge/dev-ps/submit-solution?token=2c7f4adfe2e51bd54772a8fd0aa0e124867206fe";
                //string fileName = "D:\\Desenvolvimento\\answer.json";
                //WebClient wc = new WebClient();
                //byte[] bytes = wc.DownloadData(fileName); // You need to do this download if your file is on any other server otherwise you can convert that file directly to bytes  
                //Dictionary<string, object> postParameters = new Dictionary<string, object>();
                //// Add your parameters here  
                //postParameters.Add("fileToUpload", new Post.FileParameter(bytes, Path.GetFileName(fileName), "multipart/form-data"));
                //string userAgent = "Manatee 4db";
                //string headerkey = "file";
                //string headervalue = "answer";
                //HttpWebResponse webResponse = Post.MultipartFormPost(requestURL, userAgent, postParameters, headerkey, headervalue);
                //// Process response  
                //StreamReader responseReader = new StreamReader(webResponse.GetResponseStream());
                ////returnResponseText = responseReader.ReadToEnd();
                //webResponse.Close();

                //string contentType = "multipart/form-data;";

                //var webClient = new WebClient();
                //string boundary = "------------------------" + DateTime.Now.Ticks.ToString("x");
                //webClient.Headers.Add("Content-Type", "multipart/form-data; boundary=" + boundary);
                //var fileData = webClient.Encoding.GetString(fileName);
                //var package = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"file\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n{3}\r\n--{0}--\r\n", boundary, fileName, contentType, fileData);

                //var nfile = webClient.Encoding.GetBytes(package);

                //byte[] resp = webClient.UploadData(requestURL, "POST", nfile);

                //HttpClient httpClient = new HttpClient();
                //MultipartFormDataContent form = new MultipartFormDataContent();

                //byte[] byteArray = File.ReadAllBytes(@"D:\Desenvolvimento\answer.json");


                //form.Add(new StringContent(file), "Answer");

                //form.Add(new ByteArrayContent(file_bytes, 0, file_bytes.Length), "profile_pic", "hello1.jpg");
                //HttpResponseMessage response = await httpClient.PostAsync("https://api.codenation.dev/v1/challenge/dev-ps/submit-solution?token=2c7f4adfe2e51bd54772a8fd0aa0e124867206fe", form);

                //response.EnsureSuccessStatusCode();
                //httpClient.Dispose();
                //string sd = response.Content.ReadAsStringAsync().Result;

                //HttpClient httpClient = new HttpClient();
                //MultipartFormDataContent form = new MultipartFormDataContent();

                //form.Add(new StringContent(username), "username");
                //form.Add(new StringContent(useremail), "email");
                //form.Add(new StringContent(password), "password");
                //form.Add(new ByteArrayContent(file_bytes, 0, file_bytes.Length), "profile_pic", "hello1.jpg");
                //HttpResponseMessage response = await httpClient.PostAsync("PostUrl", form);

                //response.EnsureSuccessStatusCode();
                //httpClient.Dispose();
                //string sd = response.Content.ReadAsStringAsync().Result;


            }
            catch (Exception exp)
            {

            }




        }
        //static void Enviar()
        //{

        //    WebRequest request = WebRequest.Create("https://api.codenation.dev/v1/challenge/dev-ps/submit-solution?token=2c7f4adfe2e51bd54772a8fd0aa0e124867206fe");
        //    request.Method = "POST";
        //    byte[] byteArray = File.ReadAllBytes(@"D:\Desenvolvimento\answer.json");
        //    request.ContentType = "multipart/form-data";
        //    request.ContentLength = byteArray.Length;

        //    Stream dataStream = request.GetRequestStream();
        //    dataStream.Write(byteArray, 0, byteArray.Length);
        //    dataStream.Close();
        //    WebResponse response = request.GetResponse();
        //    Console.WriteLine(((HttpWebResponse)response).StatusDescription);
        //    //reader.Close();
        //    dataStream.Close();
        //    response.Close();
        //}

        static void Enviar()
        {
            //string fileName = (@"D:\Desenvolvimento\answer.json");

            ////using (HttpClient client = new HttpClient())
            //using (MultipartFormDataContent content = new MultipartFormDataContent())
            //using (FileStream fileStream = System.IO.File.OpenRead(fileName))
            //using (StreamContent fileContent = new StreamContent(fileStream))
            //{

            //    //    fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            //    //    fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            //    //    {
            //    //        FileName = "answer.json",
            //    //    };
            //    //    fileContent.Headers.Add("file", "answer");
            //    content.Add(fileContent);
            //    //    var result = client.PostAsync("https://api.codenation.dev/v1/challenge/dev-ps/submit-solution?token=2c7f4adfe2e51bd54772a8fd0aa0e124867206fe", content).Result;
            //    //    result.EnsureSuccessStatusCode();


            //    string teste = fileContent.ReadAsStringAsync().Result;

            //    var clientw = new RestClient("https://api.codenation.dev/v1/challenge/dev-ps/submit-solution?token=2c7f4adfe2e51bd54772a8fd0aa0e124867206fe");
            //    clientw.Timeout = -1;
            //    var request = new RestRequest(Method.POST);
            //    request.AddFile("answer", teste);
            //    IRestResponse response = clientw.Execute(request);
            //    Console.WriteLine(response.Content);




            //HttpClient httpClient = new HttpClient();
            //MultipartFormDataContent form = new MultipartFormDataContent();
            byte[] file_bytes = File.ReadAllBytes(@"D:\Desenvolvimento\answer.json");

            //form.Add(new ByteArrayContent(file_bytes, 0, file_bytes.Length), "answer", "answer.json");
            ////form.Headers.Add("Content-Type", "multipart/form-data");
            //HttpResponseMessage response = httpClient.PostAsync("https://api.codenation.dev/v1/challenge/dev-ps/submit-solution?token=2c7f4adfe2e51bd54772a8fd0aa0e124867206fe", form).Result;

            //response.EnsureSuccessStatusCode();
            //httpClient.Dispose();
            //string sd = response.Content.ReadAsStringAsync().Result;



            var client = new RestClient("https://api.codenation.dev/v1/challenge/dev-ps/submit-solution?token=2c7f4adfe2e51bd54772a8fd0aa0e124867206fe");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Content-Length", "560");
            request.AddHeader("Accept-Encoding", "gzip, deflate, br");
            request.AddHeader("Content-Type", "multipart/form-data; boundary=--------------------------919699468839675295239120");
            request.AddHeader("Host", "api.codenation.dev");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("content-type", "multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW");
            request.AddParameter("multipart/form-data; Content-Disposition: form-data; name=\"answer\"; filename=\"answer\"\r\nContent-Type: application/json\r\n\r\n\r\n--", ParameterType.RequestBody);
            request.AddFile("answer", @"D:\Desenvolvimento\answer.json");
            request.AddFileBytes("answer", file_bytes, "answer", "application/json");
            request.AlwaysMultipartFormData = true;
            IRestResponse response = client.Execute(request);



        }
    }
}


﻿using CuaHangBanThucAn.BLL;
using CuaHangBanThucAn.DTO;
using CuaHangBanThucAn.LIB.Error;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanThucAn.Controller
{
    public class MyHttpServer
    {
        private HttpListener listener;

        public MyHttpServer(params string[] prefixes)
        {
            if (!HttpListener.IsSupported)
                throw new Exception("Máy không hỗ trợ HttpListener.");

            if (prefixes == null || prefixes.Length == 0)
                throw new ArgumentException("prefixes");

            // Khởi tạo HttpListener
            listener = new HttpListener();
            foreach (string prefix in prefixes)
                listener.Prefixes.Add(prefix);

        }
        public async Task StartAsync()
        {
            // Bắt đầu lắng nghe kết nối HTTP
            listener.Start();
            do
            {

                try
                {
                    Console.WriteLine($"{DateTime.Now.ToLongTimeString()} : waiting a client connect");

                    // Một client kết nối đến
                    HttpListenerContext context = await listener.GetContextAsync();
                    await ProcessRequest(context);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("...");

            }
            while (listener.IsListening);
        }

        // Xử lý trả về nội dung tùy thuộc vào URL truy cập
        //      /               hiện thị dòng Hello World
        //      /stop           dừng máy chủ
        //      /json           trả về một nội dung json
        //      /anh2.png       trả về một file ảnh 
        //      /requestinfo    thông tin truy vấn
        async Task ProcessRequest(HttpListenerContext context)
        {
            HttpListenerRequest request = context.Request;
            HttpListenerResponse response = context.Response;
            Console.WriteLine($"{request.HttpMethod} {request.RawUrl} {request.Url.AbsolutePath}");

            // Lấy stream / gửi dữ liệu về cho client
            var outputstream = response.OutputStream;
            switch (request.Url.AbsolutePath)
            {
                case "/":
                    {
                        byte[] buffer = System.Text.Encoding.UTF8.GetBytes("Hello world!");
                        response.ContentLength64 = buffer.Length;
                        await outputstream.WriteAsync(buffer, 0, buffer.Length);
                    }
                    break;
                case "/products":
                    {
                        ProductBLL productBLL = new ProductBLL();
                        switch (request.HttpMethod.ToString())
                        {
                            case "GET":
                                String value = "";
                                value = request.QueryString["search"];
                                List<Product> products = productBLL.Search(value);
                                response.Headers.Add("Content-Type", "application/json");
                                string jsonstring = JsonConvert.SerializeObject(products);
                                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(jsonstring);
                                response.ContentLength64 = buffer.Length;
                                await outputstream.WriteAsync(buffer, 0, buffer.Length);
                                break;
                            case "POST":
                                try
                                {
                                    String value3 = "";
                                    using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                                    {
                                        value3 = reader.ReadToEnd();
                                    }
                                    var Product = (Product)JsonConvert.DeserializeObject<Product>(value3);

                                    Product = productBLL.Create(Product);
                                    response.Headers.Add("Content-Type", "application/json");
                                    string jsonstring2 = JsonConvert.SerializeObject(Product);
                                    byte[] buffer2 = System.Text.Encoding.UTF8.GetBytes(jsonstring2);
                                    response.ContentLength64 = buffer2.Length;
                                    await outputstream.WriteAsync(buffer2, 0, buffer2.Length);
                                }
                                catch (AppException ex)
                                {
                                    response.StatusCode = 200;
                                    byte[] buffererror = System.Text.Encoding.UTF8.GetBytes(ex.message);
                                    response.ContentLength64 = buffererror.Length;
                                    await outputstream.WriteAsync(buffererror, 0, buffererror.Length);
                                }
                                break;
                            case "DELETE":
                                try
                                {
                                    String value2 = "";
                                    value2 = request.QueryString["dID"];
                                    if (int.TryParse(value2, out int value3))
                                    {
                                        Product product = new Product();
                                        product.id = value3;
                                        productBLL.Delete(product.id);
                                        byte[] buffer2 = System.Text.Encoding.UTF8.GetBytes("Xoá thành công");
                                        response.ContentLength64 = buffer2.Length;
                                        await outputstream.WriteAsync(buffer2, 0, buffer2.Length);
                                    }else
                                    {
                                        throw new AppException(1, "Không tìm thấy sản phẩm");
                                    }    
                                }
                                catch (AppException ex)
                                {
                                    response.StatusCode = ex.errorCode;
                                    byte[] buffererror = System.Text.Encoding.UTF8.GetBytes(ex.message);
                                    response.ContentLength64 = buffererror.Length;
                                    await outputstream.WriteAsync(buffererror, 0, buffererror.Length);
                                }
                                break;
                            case "PUT":
                                try
                                {
                                    String value3 = "";
                                    using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                                    {
                                        value3 = reader.ReadToEnd();
                                    }
                                    var Product = (Product)JsonConvert.DeserializeObject<Product>(value3);

                                    productBLL.Update(Product);
                                    Product = productBLL.Read(Product.id);
                                    response.Headers.Add("Content-Type", "application/json");
                                    string jsonstring2 = JsonConvert.SerializeObject(Product);
                                    byte[] buffer2 = System.Text.Encoding.UTF8.GetBytes(jsonstring2);
                                    response.ContentLength64 = buffer2.Length;
                                    await outputstream.WriteAsync(buffer2, 0, buffer2.Length);
                                }
                                catch (AppException ex)
                                {
                                    response.StatusCode = 200;
                                    byte[] buffererror = System.Text.Encoding.UTF8.GetBytes(ex.message);
                                    response.ContentLength64 = buffererror.Length;
                                    await outputstream.WriteAsync(buffererror, 0, buffererror.Length);
                                }
                                break;


                        }




                        /*  var product = new
                          {
                              Name = "Macbook Pro",
                              Price = 2000,
                              Manufacturer = "Apple"
                          };*/
                        /*response.Headers.Add("Content-Type", "application/json");
                        string jsonstring = JsonConvert.SerializeObject(product);
                        byte[] buffer = System.Text.Encoding.UTF8.GetBytes(jsonstring);
                        response.ContentLength64 = buffer.Length;
                        await outputstream.WriteAsync(buffer, 0, buffer.Length);*/
                    }
                    break;
                /* case "/requestinfo":
                     {
                         // Gửi thông tin về cho Client
                         context.Response.Headers.Add("content-type", "text/html");
                         context.Response.StatusCode = (int)HttpStatusCode.OK;

                         string responseString = this.GenerateHTML(request);
                         byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                         response.ContentLength64 = buffer.Length;
                         await outputstream.WriteAsync(buffer, 0, buffer.Length);
                     }
                     break;


                 case "/stop":
                     {
                         listener.Stop();
                         Console.WriteLine("stop http");
                     }
                     break;
                case "/":
                    {
                        byte[] buffer = System.Text.Encoding.UTF8.GetBytes("Hello world!");
                        response.ContentLength64 = buffer.Length;
                        await outputstream.WriteAsync(buffer, 0, buffer.Length);
                    }
                    break;
                 case "/json":
                     {
                         response.Headers.Add("Content-Type", "application/json");
                         var product = new
                         {
                             Name = "Macbook Pro",
                             Price = 2000,
                             Manufacturer = "Apple"
                         };
                         string jsonstring = JsonConvert.SerializeObject(product);
                         byte[] buffer = System.Text.Encoding.UTF8.GetBytes(jsonstring);
                         response.ContentLength64 = buffer.Length;
                         await outputstream.WriteAsync(buffer, 0, buffer.Length);

                     }
                     break;
                 case "/anh2.png":
                     {
                         response.Headers.Add("Content-Type", "image/png");
                         byte[] buffer = await File.ReadAllBytesAsync("anh2.png");
                         response.ContentLength64 = buffer.Length;
                         await outputstream.WriteAsync(buffer, 0, buffer.Length);

                     }
                     break;
                 */
                default:
                    {
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        byte[] buffer = System.Text.Encoding.UTF8.GetBytes("NOT FOUND!");
                        response.ContentLength64 = buffer.Length;
                        await outputstream.WriteAsync(buffer, 0, buffer.Length);
                    }
                    break;
            }

            // switch (request.Url.AbsolutePath)


            // Đóng stream để hoàn thành gửi về client
            outputstream.Close();
        }

        // Tạo nội dung HTML trả về cho Client (HTML chứa thông tin về Request)
        /*   public string GenerateHTML(HttpListenerRequest request)
           {
               string format = @"<!DOCTYPE html>
                               <html lang=""en""> 
                                   <head>
                                       <meta charset=""UTF-8"">
                                       {0}
                                    </head> 
                                   <body>
                                       {1}
                                   </body> 
                               </html>";
               string head = "<title>Test WebServer</title>";
               var body = new StringBuilder();
               body.Append("<h1>Request Info</h1>");
               body.Append("<h2>Request Header:</h2>");

               // Header infomation
               var headers = from key in request.Headers.AllKeys
                             select $"<div>{key} : {string.Join(",", request.Headers.GetValues(key))}</div>";
               body.Append(string.Join("", headers));

               //Extract request properties
               body.Append("<h2>Request properties:</h2>");
               var properties = request.GetType().GetProperties();
               foreach (var property in properties)
               {
                   var name_pro = property.Name;
                   string value_pro;
                   try
                   {
                       value_pro = property.GetValue(request).ToString();
                   }
                   catch (Exception e)
                   {
                       value_pro = e.Message;
                   }
                   body.Append($"<div>{name_pro} : {value_pro}</div>");

               };
               string html = string.Format(format, head, body.ToString());
               return html;
           }


       }*/
    }
}

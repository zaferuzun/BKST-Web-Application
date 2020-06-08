using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using WebApplication2.DataModel;

namespace WebApplication2.WebApi
{
    public class Service
    {
        /// <summary>
        /// Üretim/satış/alış vb. Bildirimlerin yapılması
        /// </summary>
        /// <returns></returns>
        public static JsonTypeResult sendNotificationAndDetail(string Gln, string Key, string HeaderText, string DetailText)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.Authorization] = "Bearer " + ServiceAuthorization.Token;
                wc.Encoding = System.Text.Encoding.UTF8;
                //wc.Headers["Content-Type"] = "application/x-www-form-urlencoded";

                byte[] resByte;
                string resString;
                byte[] reqString;

                wc.Headers["Content-Type"] = "application/json";
                wc.Headers["Accept"] = "*/*";


                Dictionary<string, object> dictData = new Dictionary<string, object>();
                dictData.Add("Gln", Gln);
                dictData.Add("Key", Key);
                dictData.Add("DocumentHeader", HeaderText);
                dictData.Add("DocumentDetail", DetailText);

                reqString = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(dictData, Formatting.Indented));
                resByte = wc.UploadData(ServiceAuthorization.URL + @"api/main/setTransactionAndDetail", "PUT", reqString);
                resString = Encoding.UTF8.GetString(resByte);

                return JsonConvert.DeserializeObject<JsonTypeResult>(resString);
            }

        }
        /// <summary>
        /// Belirli tarih aralığında yapılan bildirimlerin listesi
        /// </summary>
        /// <returns></returns>
        public static JsonTypeResult getTransactionList(string Gln, string Key, string DocumentNumber, DateTime StartDate, DateTime EndDate, string NotificationType)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.Authorization] = "Bearer " + ServiceAuthorization.Token;
                wc.Encoding = System.Text.Encoding.UTF8;
                var json = "";

                json = wc.DownloadString(ServiceAuthorization.URL + @"api/main/getTransactionList?Key=" + Key + "&Gln=" + Gln + "&DocumentNumber=" + DocumentNumber + "&StartDate=" + StartDate.ToString("MM/dd/yyyy") + "&EndDate=" + EndDate.ToString("MM/dd/yyyy") + "&NotificationType=" + NotificationType);

                return JsonConvert.DeserializeObject<JsonTypeResult>(json);
            }

        }
        /// <summary>
        /// BKST üzerindeki kayıtlı tüm ülkeleri getirir.
        /// </summary>
        /// <returns></returns>
        public static CountyResult GetCountry()
        {
            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.Authorization] = "Bearer " + ServiceAuthorization.Token;
                wc.Encoding = System.Text.Encoding.UTF8;
                var json = "";

                json = wc.DownloadString(ServiceAuthorization.URL + @"api/main/getCountryList");


                return JsonConvert.DeserializeObject<CountyResult>(json);
            }

        }
    }
}
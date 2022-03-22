using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.OutServices.MyContentHelper
{
    public class ContentHelper : IContentHelper
    {
        string url = "https://www.wired.com/most-recent/";
        public List<Article> GetArticles()
        {


            throw new NotImplementedException();
        }

        public void GetTitle()
        {
            WebRequest webRequest = HttpWebRequest.Create(url);
            WebResponse webResponse = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(webResponse.GetResponseStream());

            string pageSource = streamReader.ReadToEnd();


            int indexOfTitle = pageSource.IndexOf("archive-item-component__title") +31;
            int endOfTitle = pageSource.Substring(indexOfTitle).IndexOf("</h2>");
            string sonuc = pageSource.Substring(indexOfTitle, endOfTitle);
            Console.WriteLine(sonuc);
           
        }
    }
}

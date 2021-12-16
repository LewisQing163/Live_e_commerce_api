using HtmlAgilityPack;
using Live_e_commerce.Common;
using Live_e_commerce.IReptile;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Live_e_commerce.Reptile
{
    public class ReptileServcie : ApplicationService, IReptileService
    {
        [HttpPost, Route("HtmlRequest")]
        /// <summary>
        /// 获取html页面
        /// </summary>
        /// <param name="requestUrl">url地址</param>
        /// <returns></returns>
        public async Task<ReturnResult<int>> HtmlRequest(string requestUrl)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Method", "Get");
            httpClient.DefaultRequestHeaders.Add("KeepAlive", "false");   // HTTP KeepAlive设为false，防止HTTP连接保持
            httpClient.DefaultRequestHeaders.Add("UserAgent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.11 (KHTML, like Gecko) Chrome/23.0.1271.95 Safari/537.11");
            var response = await httpClient.GetStringAsync(requestUrl);
            var date = GetExampleData(response);
            return new ReturnResult<int> { Msg = "爬取完毕", Date = Convert.ToString(date) };
        }

        #region 解析提取字段
        /// <summary>
        /// 解析提取字段
        /// </summary>
        /// <param name = "htmlStr" ></ param >
        /// < returns ></ returns >
        public static List<ExampleModel> GetExampleData(string htmlStr)
        {
            //var  a=  HtmlRequest("https://www.haolizi.net").Result;
            #region 字段
            string rootUrl = @"https://www.haolizi.net";
            string name = string.Empty;
            string detailUrl = string.Empty;
            string category = string.Empty;
            string categoryUrl = string.Empty;
            int hotNum = -1;
            int downloadCount = -1;
            int needScore = 0;
            string devLanguage = string.Empty;
            string downloadSize = string.Empty;
            string pubdate = string.Empty;
            string pubPersion = string.Empty;
            string downloadUrl = string.Empty;
            #endregion

            List<ExampleModel> examModels = new List<ExampleModel>();
            HtmlDocument htmlDoc = new HtmlDocument();

            htmlDoc.LoadHtml(htmlStr);
            var liNodes = htmlDoc.DocumentNode.SelectNodes("//*[@id='read-hot']/div[2]/ul/li");

            foreach (HtmlNode node in liNodes)
            {
                List<string> tags = new List<string>();

                #region 提取元素
                HtmlNode aNode = node.SelectSingleNode("//img");
                //name = aNode.InnerText;
                detailUrl = aNode.Attributes["src"].Value;

                HtmlNode categoryNode = node.SelectSingleNode("//a");
                //category = categoryNode.InnerText;
                categoryUrl = categoryNode.Attributes["href"].Value;

                //HtmlNode hotNumNode = node.SelectSingleNode("./div[@class='baseinfo']/div[@class='xj']/span[@class='rq']/em");
                //hotNum = Convert.ToInt32(hotNumNode.InnerText);

                //HtmlNode downloadCountNode = node.SelectSingleNode("./div[@class='baseinfo']/div[@class='xj']/span[2]");
                //downloadCount = Convert.ToInt32(downloadCountNode.InnerText);

                //HtmlNode needScoreNode = node.SelectSingleNode("./div[@class='baseinfo']/div[@class='xj']/span[3]");
                //needScore = Convert.ToInt32(needScoreNode.InnerText);

                //HtmlNode devLanguageNode = node.SelectSingleNode("./div[@class='sinfo']/div/p[@class='fun']/span[1]");
                //devLanguage = devLanguageNode.NextSibling.InnerText.Replace("&nbsp;", "").Replace("|", "");

                //HtmlNode downloadSizeNode = node.SelectSingleNode("./div[@class='sinfo']/div/p[@class='fun']/span[2]");
                //downloadSize = downloadSizeNode.InnerText;

                //HtmlNode pubdateNode = node.SelectSingleNode("./div[@class='sinfo']/div/p[@class='fun']/span[3]");
                //pubdate = pubdateNode.InnerText;

                //HtmlNode pubPersionNode = node.SelectSingleNode("./div[@class='sinfo']/div/p[@class='fun']/span[4]/a");
                //pubPersion = pubPersionNode.InnerText;
                var tagNodes = node.SelectNodes("//*[@id='read-hot']/div[2]/ul/li");
                if (tagNodes != null)
                {
                    foreach (var tnode in tagNodes)
                    {
                        tags.Add(tnode.SelectSingleNode("./a").InnerText);
                        Console.WriteLine(name + " tag:" + tnode.SelectSingleNode("./a").InnerText);
                    }
                }
                #endregion

              

                ExampleModel examModel = new ExampleModel()
                {
                    Name = name,
                    DetailUrl = detailUrl,
                    Category = category,
                    CategoryUrl = categoryUrl,
                    DevLanguage = devLanguage,
                    DownloadCount = downloadCount,
                    DownloadSize = downloadSize.Replace("大小：", "").Trim(),
                    DownloadUrl = downloadUrl,
                    HotNum = hotNum,
                    NeedScore = needScore,
                    Pubdate = Convert.ToDateTime(pubdate.Replace("发布时间：", "").Trim()),
                    PubPersion = pubPersion,
                    Tags = tags
                };
                examModels.Add(examModel);
            };
            return examModels;
        }
        #endregion

    }
}

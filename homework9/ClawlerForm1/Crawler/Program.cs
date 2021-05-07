using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Crawler
{
    public class SimpleCrawler
    {
        public List<string> urls { get; set; } = new List<string>();
        public List<string> completedUrls { get; set; } = new List<string>();
        public List<string> DownloadingUrls { get; set; } = new List<string>();
        public int Maxpage { get; set; } = 3;
        private string hostname { get; set; }
        public string startUrl { get; set; }
        public int count = 0;

        static void Main(string[] args)
        {
            SimpleCrawler crawler = new SimpleCrawler();
            crawler.StartCrawl();
            Console.ReadKey();
        }

        public void StartCrawl()
        {
            completedUrls.Clear();
            urls.Clear();
            //string startUrl = "http://www.cnblogs.com/dstang2000/";
            if (startUrl == null) { return; }
            if (!startUrl.StartsWith("https://") && !startUrl.StartsWith("http://") && !startUrl.StartsWith("ftp://"))
            {
                startUrl = "http://" + startUrl;
            }
            urls.Add(startUrl);
            MatchCollection match = new Regex(@"(http|https)://(www.)?(?<hostname>\w+.)*?(com)").Matches(startUrl);
            foreach (Match match1 in match)
            {
                GroupCollection group = match1.Groups;
                this.hostname = group["hostname"].Value;
            }
            //if (args.Length >= 1) startUrl = args[0];
            //urls.Add(startUrl, false);//加入初始页面
            this.Crawl();
        }

        public void Crawl()
        {
            Console.WriteLine("开始爬取了.... ");
            while (true)
            {
                string current = null;
                for(int i =0;i<urls.Count();i++)
                {
                    if (completedUrls.Contains(urls[i])) continue;
                    else current = urls[i];
                
                    if (current == null || count > Maxpage) return;
                    Console.WriteLine("爬取" + current + "页面!");
                    string html = DownLoad(current);                    // 下载
                    completedUrls.Add(current);
                    count++;
                    if (!html.StartsWith("<!DOCTYPE html>")) { continue; }
                    Parse(html, current);                                //解析,并加入新的链接
                    Console.WriteLine("爬取结束");
                }
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html, string current)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (!strRef.StartsWith("http://") && !strRef.StartsWith("https://"))
                {
                    if (strRef.StartsWith("./"))
                    {
                        if (current.EndsWith("/"))
                        {
                            strRef = current + "." + strRef;
                        }
                        else
                        {
                            strRef = current + "/." + strRef;
                        }

                    }
                    else if (strRef.StartsWith("../"))
                    {
                        if (current.EndsWith("/"))
                        {
                            strRef = current + strRef;
                        }
                        else
                        {
                            strRef = current + "/" + strRef;
                        }
                    }
                    else if (Regex.IsMatch(strRef, @"^/\w"))
                    {
                        if (current.EndsWith("/"))
                        {
                            strRef = current + strRef.Substring(1);
                        }
                        else
                        {
                            strRef = current + strRef;
                        }
                    }
                    else if (strRef.StartsWith("//"))
                    {
                        strRef = "http:" + strRef;
                    }
                    else
                    {
                        if (current.EndsWith("/"))
                        {
                            strRef = current + strRef;
                        }
                        else
                        {
                            strRef = current + "/" + strRef;
                        }
                    }
                }
                else { if (!strRef.Contains(hostname)) continue; }
                //if (!strRef.Contains(@"(html|htm|jsp|aspx")) continue;
                if (strRef.Length == 0) continue;
                if (!completedUrls.Contains(strRef)) urls.Add(strRef);
            }
        }
    }
}

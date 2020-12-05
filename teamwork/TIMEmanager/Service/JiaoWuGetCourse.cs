using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using HtmlAgilityPack;
using System.Data.Entity;
using System.Text.RegularExpressions;
using TIMEmanger.Entity;
using TIMEmanger;
using TIMEmanger.BO;

namespace TIMEmanager
{

    public class JiaoWuGetCourse
    {
        public string course_result;
        public ScheduleService ss = new ScheduleService();
        public User user;
        public TaskBO taskBO = new TaskBO();
        public List<Tasks> GetCourse(JiaoWuLogin jwxt)
        {
            //stuid = jwxt.StuID;
            var client = new RestClient(jwxt.urls.course_url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Host", "bkjw.whu.edu.cn");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Upgrade-Insecure-Requests", "1");
            request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.138 Safari/537.36");
            request.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            request.AddHeader("Accept-Language", "zh-CN,zh;q=0.9");
            request.AddHeader("Referer", "http://bkjw.whu.edu.cn/stu/stu_course_parent.jsp");
            request.AddCookie(jwxt.urls.Cookie.Name, jwxt.urls.Cookie.Value);
            var response = client.Execute(request);
            var course_result_byte = response.RawBytes;
            course_result = Encoding.GetEncoding("GB2312").GetString(course_result_byte);
            //Console.WriteLine(course_result);
            return ProcessCourse();
        }

        public List<Tasks> ProcessCourse()
        {
            foreach (Tasks t in taskBO.SearchAllCourse())
            {
                taskBO.deleteTaskByName(t.Name);
            }


            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(course_result);
            HtmlNode table = htmlDoc.DocumentNode.SelectSingleNode("//table[@class='table listTable']");
            HtmlNodeCollection tableNodes = table.ChildNodes;
            HtmlNodeCollection trNodes = new HtmlNodeCollection(table);
            foreach (var n in tableNodes)
            {
                if (n.Name == "tr")
                    trNodes.Add(n);
            }
            trNodes.RemoveAt(0);    //第一个tr节点非课程项，故去除

            var itemlist = new List<String>();
            var courseList = new List<Tasks>();
            int iu = 10;
            foreach (var n in trNodes)
            {
                HtmlNodeCollection tdNodes = n.ChildNodes;
                itemlist.Clear();
                foreach (var td in tdNodes)     //每个tdNodes中含27个td
                {
                    var a = td.InnerText.Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace(" ", "");
                    itemlist.Add(a);
                }

                string timeRegex = @"周;(?<time>[^""]+)节";
                Match timeMatch = Regex.Match(itemlist[19], timeRegex);
                string time = timeMatch.Groups["time"].Value;
                Console.WriteLine(time);
                int i = Convert.ToInt32(time[0]) - 48;
                int j = Convert.ToInt32(time[2]) - 48;

                int k = ss.ParseWeekLoopDay(itemlist[19].Substring(0,3));


                string placeRegex = @"节,(?<place>[^""]+)";
                Match placeMatch = Regex.Match(itemlist[19], placeRegex);
                string place = placeMatch.Groups["place"].Value;

                long id = ParseTool.ParseTaskId(user.Id, DateTime.Now);
                id *= 10;
                id += iu;
                iu++;
                Tasks task = new Tasks
                {
                    UserId = user.Id,
                    Id = id,
                    Name = itemlist[3],
                    TeacherName = itemlist[11],
                    DairyStartTime = i,
                    DairyFinishTime = j,
                    Place = place,
                    StartTime = 202001010000,
                    ExpectTime = 202012312359,
                    isCourse = true,
                    WeekLoopDay=k
                };
                courseList.Add(task);
            }

            return courseList;
        }
    }
}

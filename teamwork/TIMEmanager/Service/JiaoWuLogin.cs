using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using HtmlAgilityPack;
using System.Globalization;
using System.IO;
using System.Net;
using TIMEmanger.Entity;

namespace TIMEmanager
{
    public class JiaoWuLogin
    {

        public string StuID { get; set; }
        public string Password { get; set; }
        public string csrftoken { get; set; }
        public User user;

        RestRequest request;
        RestClient client;

        public JwUrl urls = new JwUrl();

        /// <summary>
        /// jw_login类的构造函数，对基本信息进行设置
        /// </summary>

        /// <param name="id">学号</param>
        /// <param name="pw">教务系统密码</param>
        public JiaoWuLogin(string id, string pw)
        {

            StuID = id;
            Password = pw;
            TryLogin();
        }

        public bool TryLogin()
        {
            try
            {
                LoginSys();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LoginSys()
        {
            urls.GetURLs();
            client = new RestClient(urls.login_url);
            request = new RestRequest(Method.POST);
            request.AddHeader("Host", "bkjw.whu.edu.cn");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Origin", "http://bkjw.whu.edu.cn/");
            request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.138 Safari/537.36");
            request.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            request.AddHeader("Accept-Language", "zh-CN,zh;q=0.9");
            request.AddHeader("Referer", "http://bkjw.whu.edu.cn/");

            request.AddParameter("timestamp", GetTimeStamp(false));
            request.AddParameter("jwb", "%E6%AD%A6%E5%A4%A7%E6%9C%AC%E7%A7%91%E6%95%99%E5%8A%A1%E7%B3%BB%E7%BB%9F");
            request.AddParameter("id", StuID);
            request.AddParameter("pwd", MD5Encrypt32(Password));
            var img = GetCaptchaImg();

        }

        public void LoginSys2(string ma)
        {

            request.AddParameter("xdvfb", ma);
            request.AddCookie(urls.Cookie.Name, urls.Cookie.Value);

            var response = client.Execute(request);

            var ResponseContent = Encoding.GetEncoding("GB2312").GetString(response.RawBytes);

            if (response.ResponseUri.ToString() == "http://bkjw.whu.edu.cn/stu/stu_index.jsp")   //url成功重定向，登录成功
            {
                Console.WriteLine("登录成功。");

                Setcsrftoken(ResponseContent);
                SetCourseUrl();

            }
            else if (ResponseContent.Contains("验证码错误"))
            {
                throw new CaptchaErrorException("验证码错误");
            }
            else if (ResponseContent.Contains("密码错误"))
            {
                throw new PasswordErrorException("用户名/密码错误");
            }
            else
            {
                throw new Exception("未知错误");
            }

        }
        public void Setcsrftoken(string res)
        {
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(res);
            string onclick = htmlDoc.DocumentNode.SelectSingleNode("//div[@id='system']").Attributes["onclick"].Value;
            csrftoken = textOp.GetMiddleText(onclick, "csrftoken=", "','");

            Console.WriteLine("成功获取了csrftoken");
        }

        public void SetCourseUrl()
        {
            var client = new RestClient(JwUrl.course_parent_url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Host", "bkjw.whu.edu.cn");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Upgrade-Insecure-Requests", "1");
            request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.138 Safari/537.36");
            request.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            request.AddHeader("Accept-Language", "zh-CN,zh;q=0.9");
            request.AddHeader("Referer", "http://bkjw.whu.edu.cn/stu/stu_index.jsp");
            request.AddCookie(urls.Cookie.Name, urls.Cookie.Value);
            var response = client.Execute(request);
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(response.Content);
            string src = htmlDoc.DocumentNode.SelectSingleNode("//iframe[@id='iframe0']").Attributes["src"].Value;
            urls.course_url = JwUrl.home_url + src;
            //Console.WriteLine(urls.course_url);
        }


        public byte[] GetCaptchaImg()
        {
            var client = new RestClient(urls.captcha_url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Host", "bkjw.whu.edu.cn");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.138 Safari/537.36");
            request.AddHeader("Accept", "image/webp,image/apng,image/*,*/*;q=0.8");
            request.AddHeader("Accept-Language", "zh-CN,zh;q=0.9");
            request.AddCookie(urls.Cookie.Name, urls.Cookie.Value);
            var response = client.Execute(request);
            urls.Cookie = response.Cookies[0];   //重设JSESSIONID字段
            //string str = System.Text.Encoding.Default.GetString(response.RawBytes);
            Stream stream = new MemoryStream(response.RawBytes);

            string path = "father.jpg";
            FileStream os = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            byte[] buff = new byte[512];
            int c = 0;
            while ((c = stream.Read(buff, 0, 512)) > 0)
            { os.Write(buff, 0, c); }
            os.Close(); stream.Close();
            return response.RawBytes;
        }


        private static string MD5Encrypt32(string str)
        {
            string cl = str;
            string pwd = "";
            MD5 md5 = MD5.Create();
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(cl));
            for (int i = 0; i < s.Length; i++)
            {
                pwd = pwd + s[i].ToString("x2");
            }
            return pwd;
        }


        private static string GetTimeStamp(bool bflag)
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            string ret = string.Empty;
            if (bflag)  //10位  
            {
                ret = Convert.ToInt64(ts.TotalSeconds).ToString();
            }
            else        //13位
            {
                ret = Convert.ToInt64(ts.TotalMilliseconds).ToString();
            }

            return ret;
        }


    }

    public class CaptchaErrorException : ApplicationException
    {
        public CaptchaErrorException(string message) : base(message)
        {
        }
    }
    public class PasswordErrorException : ApplicationException
    {
        public PasswordErrorException(string message) : base(message)
        {
        }
    }

    public static class textOp
    {
        public static string GetMiddleText(string t, string k, string j) //取出中间文本
        {
            try
            {
                var kn = t.IndexOf(k, StringComparison.Ordinal) + k.Length;
                var jn = t.IndexOf(j, kn, StringComparison.Ordinal);
                return t.Substring(kn, jn - kn);
            }
            catch
            {
                return "发现异常错误！";
            }
        }

    }
}

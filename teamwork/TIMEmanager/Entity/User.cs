using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMEmanger.Entity
{
    /// <summary>
    /// 模块名：User
    /// 作用：创建User表
    /// 作者：叶子扬
    /// </summary>
    public class User
    {

        public User() { }
        public User(int id,string name, string pwd)
        {
            Id = id;
            Pwd = pwd;
            Name = name;
        }
        /// <summary>
        /// 用户的账号
        /// </summary>
        public int Id { get; set; } 

        /// <summary>
        /// 用户的用户名
        /// </summary>
        public string Name { get; set; }
        public string Pwd { get; set; }


    }
}

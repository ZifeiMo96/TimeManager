using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIMEmanager;
using TIMEmanger.Entity;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TIMEmanger.BO
{
    public class UserBO
    {
        public SQLiteManager SQLiteForUser;

        public String filename = "TIMEmanager";

        public UserBO()
        {
            SQLiteForUser = new SQLiteManager();
        }

        /// <summary>
        /// 创建表
        /// </summary>
        /// <param name="filename"></param>
        /// 
        public void creatUserTable()
        {
            SQLiteForUser.OpenDB(filename);

            //建表
            string sql = "CREATE TABLE IF NOT EXISTS USER (" +

                "ID        INTEGER PRIMARY KEY NOT NULL," +
                "NAME      TEXT," +
                "pwd       TEXT" +
                ");";
            SQLiteForUser.CreateTable(sql);
            SQLiteForUser.CloseDB();

        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        public void addUser(User userT)
        {
            SQLiteForUser.OpenDB(filename);
            string user = ParseValueToString(userT);
            SQLiteForUser.InsertIntoTable("USER", user);
            SQLiteForUser.CloseDB();
        }


        /// <summary>
        /// 删除user
        /// </summary>
        /// <param name="id">ID</param>
        public void deleteUserByName(int id)
        {
            string cmd = "ID = " + id.ToString();
            SQLiteForUser.DeleteFromTable("USER", cmd);
        }

        /// <summary>
        /// 更新User
        /// </summary>
        /// <param name="id">ID</param>
        public void updateUser(int id, string[] colNames, string[] colValues)
        {
            string cmd = "ID = " + id.ToString();
            SQLiteForUser.UpdateTalbe("User", colNames, colValues, cmd);
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="oldpwd">旧密码</param>
        /// <param name="newpwd">新密码</param>
        /// <returns>
        /// 是否修改成功
        /// </returns>
        public bool updatePwd(int id, string oldpwd, string newpwd)
        {
            /*

            SQLiteForUser.OpenDB(filename);
            
            string cmd = "SELECT * " +
                "FROM USER " +
                "WHERE ID = " + id + ";";
            string test;
            string pwd;
            using (var reader = SQLiteForUser.ReadTable(cmd))
            {
                test = reader.GetInt32(0).ToString();
                test = reader.GetString(1);
                pwd = reader.GetString(2);
            }
            */
            string pwd;
            User usr = this.SearchForUserByID(id);

            pwd = usr.Pwd;
            SQLiteForUser.OpenDB(filename);
            if (pwd == oldpwd)
            {
                string[] colnames = new string[1];
                colnames[0] = "pwd";
                string[] colvalues = new string[1];
                colvalues[0] = newpwd;
                SQLiteForUser.UpdateTalbe("user", colnames, colvalues, "ID =" + id.ToString());
                SQLiteForUser.CloseDB();
                return true;
            }
            else
            {
                SQLiteForUser.CloseDB();
                return false;
            }
        }

        /// <summary>
        /// 根据ID查找用户
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public User SearchForUserByID(int id)
        {
            SQLiteForUser.OpenDB(filename);
            User usr = new User();
            string cmd = "SELECT * " +
                "FROM USER " +
                "WHERE ID = " + id.ToString() + ";";
            using (var reader = SQLiteForUser.ReadTable(cmd))
            {
                while (reader.Read())
                {
                    usr.Id = reader.GetInt32(0);
                    usr.Name = reader.GetString(1);
                    usr.Pwd = reader.GetString(2);
                    //usrList.Add(usr);
                }
            }
            SQLiteForUser.CloseDB();
            return usr;
        }

        public User SearchForUserByName(string name)
        {
            SQLiteForUser.OpenDB(filename);
            User usr = new User();
            string cmd = "SELECT * " +
                "FROM USER " +
                "WHERE NAME = '" + name.ToString() + "';";
            using (var reader = SQLiteForUser.ReadTable(cmd))
            {
                while (reader.Read())
                {
                    usr.Id = reader.GetInt32(0);
                    usr.Name = reader.GetString(1);
                    usr.Pwd = reader.GetString(2);
                    //usrList.Add(usr);
                }
            }
            SQLiteForUser.CloseDB();
            return usr;
        }

        /// <summary>
        /// 查询全部用户
        /// </summary>
        /// <returns>
        /// 全部用户列表
        /// </returns>
        public List<User> SearchAllUser()
        {
            List<User> usrList = new List<User>();
            User usr = new User();
            string cmd = "SELECT * " +
                "FROM USER ;";
            using (var reader = SQLiteForUser.ReadTable(cmd))
            {
                while (reader.Read())
                {
                    usr.Id = reader.GetInt32(0);
                    usr.Name = reader.GetString(1);
                    usr.Pwd = reader.GetString(2);
                    usrList.Add(usr);
                }
            }
            return usrList;
        }


        ///<summary>
        ///根据ID查找是否存在该用户
        ///作者：张贝琦
        /// </summary>
        ///<param name="id">用户的ID</param>
        ///<returns>该用户是否存在bool</returns>
        public bool SearchForUserExistsByID(int id)
        {
            SQLiteForUser.OpenDB(filename);
            string cmd = "SELECT * " +
                "FROM USER " +
                "WHERE ID = " + id + ";";

            using (var reader = SQLiteForUser.ReadTable(cmd))
            {
                if (reader.HasRows)
                {
                    SQLiteForUser.CloseDB();
                    return true;
                }
            }
            SQLiteForUser.CloseDB();
            return false;                              //否则该用户不存在，返回false
        }

        public bool SearchForUserExistsByName(string name)
        {
            SQLiteForUser.OpenDB(filename);
            string cmd = "SELECT * " +
                "FROM USER " +
                "WHERE NAME = '" + name + "';";

            using (var reader = SQLiteForUser.ReadTable(cmd))
            {
                if (reader.HasRows)
                {
                    SQLiteForUser.CloseDB();
                    return true;
                }
            }
            SQLiteForUser.CloseDB();
            return false;                              //否则该用户不存在，返回false
        }


        ///<summary>
        ///将User转为string
        ///作者：张贝琦
        /// </summary>
        /// <param name="u">User用户</param>
        /// <returns>string</returns>
        public string ParseValueToString(User u)
        {
            string value = "" +
                u.Id + "," +
                "'" + u.Name + "'" + "," +
                "'" + u.Pwd + "'";
            return value;
        }
    }
}

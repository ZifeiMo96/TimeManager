using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace TIMEmanager
{
    /// <summary>
    /// 模块名：SQLiteManager
    /// 作用：对SQLite进行简单封装
    /// 作者：张贝琦
    /// </summary>
    public class SQLiteManager
    {
        //数据库连接
        public SQLiteConnection connection;
        //SQL命令
        private SQLiteCommand cmd;
        //数据读取
        private SQLiteDataReader dataReader;
        //数据库连接字符串
        private SQLiteConnectionStringBuilder connectionStr;


        ///<summary>
        ///构造函数
        /// </summary>
        public SQLiteManager(string filename) { }

        ///<summary>
        ///不带参数的构造函数
        /// </summary>
        public SQLiteManager() { }

        ///<summary>
        ///说明：创建数据库
        ///作者：<叶子扬>
        /// </summary>
        /// <param name="fileName">文件名</param>
        public void createNewDatabase(string fileName)
        {
            //文件不存在则创建
            if (File.Exists(fileName)) 
            { 
                SQLiteConnection.CreateFile(fileName);
            }
        }


        ///<summary>
        ///打开数据库
        /// </summary>
        /// <param name="fileName">文件名</param>
        public void OpenDB(string fileName)
        {
            //设置连接字符串
            connectionStr = new SQLiteConnectionStringBuilder();
            connectionStr.DataSource = fileName;

            //设置连接
            connection = new SQLiteConnection();
            connection.ConnectionString = connectionStr.ToString();
            connection.Open();
        }


        ///<summary>
        ///关闭数据库
        /// </summary>
        public void CloseDB()
        {
            /*
            //销毁SQL命令
            if (cmd != null)
                cmd.Cancel();
            cmd = null;
            */
            if (connectionStr != null)
                connectionStr.Clear();
            connectionStr = null;

            //销毁数据读取
            if (dataReader != null)
                dataReader.Close();
            dataReader = null;

            //销毁数据库连接
            if (connection != null)
                connection.Close();
            connection = null;
        }


        ///<summary>
        ///执行SQL命令
        ///</summary>
        ///<param name="sql">SQL命令字符串</param>
        ///<returns>执行结果</returns>
        public SQLiteDataReader ExecuteQuery(string sql)
        {
            using (cmd = connection.CreateCommand())
            {
                //设置SQL语句
                cmd.CommandText = sql;
                dataReader = cmd.ExecuteReader();
            }
            //返回执行结果
            return dataReader;
        }


        ///<summary>
        ///创建表
        /// </summary>
        /// <param name="tabelName">表名</param>
        /// <param name="colNames">属性名</param>
        /// <param name="colTypes">属性域</param>
        ///<returns>表</returns>
        public SQLiteDataReader CreateTable(string tableName, string[] colNames, string[] colTypes)
        {
            //初始化SQL命令
            string sql = "CREATE TABLE IF NOT EXISTS" + tableName + "(" + colNames[0] + " " + colTypes[0];

            for (int i = 1; i < colNames.Length; i++)
            {
                sql += ", " + colNames[i] + " " + colTypes[i];
            }
            sql += ")";

            //返回结果
            return ExecuteQuery(sql);
        }

        ///<summary>
        ///说明：通过命令创建表
        ///作者：<叶子扬>
        /// </summary>
        /// <param name="command">指令</param>
        ///<returns>表</returns>
        public SQLiteDataReader CreateTable(string command)
        {
            //初始化SQL命令
            string sql = command;

            //返回结果
            return ExecuteQuery(sql);
        }


        ///<summary>
        ///向表中插入整行数据
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="values">插入的数值</param>
        /// 示例：INSERT INTO tableName VALUES (' value1', 'value2')
        public SQLiteDataReader InsertIntoTable(string tableName, string values)
        {
            //获取表中属性数
            int fieldCount = ReadFullTable(tableName).FieldCount;
            /*
            //当插入数据的属性数目不为表中属性数时抛出异常
            if (values.Length != fieldCount)
            {
                throw new SQLiteException($"Insert failed. Values' length is not equal to field's count in {tableName}.");
            }
            */
            //初始化SQL命令
            string sql = "INSERT INTO " + tableName + " VALUES (" +  values  ;
            sql += " )";
            
            //执行SQL命令
            return ExecuteQuery(sql);
        }


        ///<summary>
        ///删除表内数据
        ///</summary>
        ///<param name="tableName">表名</param>
        ///<param name="condition">条件</param>
        ///示例： DELETE FROM tableName WHERE condition
        public SQLiteDataReader DeleteFromTable(string tableName, string condition)
        {
            //初始化SQL命令
            string sql = "DELETE FROM " + tableName + " WHERE " + condition;

            //执行SQL命令
            return ExecuteQuery(sql);
        }


        ///<summary>
        ///更新表内某行数据
        ///作者：张贝琦
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="colNames">属性名</param>
        /// <param name="colValues">属性对应的数值</param>
        /// <param name="condition">条件</param>
        ///示例： UPDATE tableName SET colName = 'colValue' WHERE condition
        public SQLiteDataReader UpdateTalbe(string tableName, string[] colNames,string[] colValues,string condition)
        {
            //如果属性名和属性值的数目不相等，报错
            if (colValues.Length != colNames.Length)
            {
                throw new SQLiteException($"Update {tableName} failed. colValues' length is not equal to colNames' length.");
            }

            //初始化SQL命令
            string sql = "UPDATE " + tableName + " SET " + colNames[0] + "=" + "'" + colValues[0] + "'";
            //循环遍历更新的数值
            for(int i = 1; i < colValues.Length; i++)
            {
                sql += ", " + colNames[i] + "=" + "'" + colValues[i]+"'";
            }
            sql += " WHERE " + condition;

            //执行SQL命令
            return ExecuteQuery(sql);
        }



        ///<summary>
        ///更新表内某行数据
        /// </summary>
        /// /// <param name="tableName">表名</param>
        /// <param name="colName">属性名</param>
        /// <param name="colValue">属性对应的数值</param>
        /// <param name="condition">条件</param>
        ///示例： UPDATE tableName SET colName = 'colValue' WHERE condition
        public SQLiteDataReader UpdateTable(string tableName,string colName,string colValue,string condition)
        {
            string sql = "UPDATE " + tableName + " SET " + colName + " = " + "'" + colValue + "'";
            return ExecuteQuery(sql);
        }



        ///<summary>
        ///读取指定的整张表
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>整张表</returns>
        public SQLiteDataReader ReadFullTable(string tableName)
        {
            //初始化SQL命令
            string sql = "SELECT * FROM " + tableName;

            //返回读取结果
            return ExecuteQuery(sql);
        }


        ///<summary>
        ///读取指定表的指定项 
        /// </summary>
        ///<param name="tableName">表名</param>
        ///<param name="items">选取项</param>
        ///<param name="colNames">属性</param>
        ///<param name="colValues">属性值</param>
        ///<param name="conditions">条件</param>
        ///示例：SELECT item FROM tableName WHERE colName condition colValue
        ///<returns>表项</returns>
        public SQLiteDataReader ReadTable(string tableName,string[] items,string[] colNames,string[] conditions,string[] colValues)
        {
            //初始化SQL命令
            string sql = "SELECT " + items[0];

            //循环添加选取项
            for(int i = 1; i < items.Length; i++)
            {
                sql += ", " + items[i];
            }
            //循环添加选取条件
            for(int i = 0; i < colNames.Length; i++)
            {
                sql += " AND " + colNames[i] + " " + conditions[i] + " " + colValues[i] + " ";
            }

            //返回读取结果
            return ExecuteQuery(sql);
        }

        ///<summary>
        ///读取指定表的指定项 
        /// </summary>
        ///作者：<叶子扬>
        ///<param name="cmd">指令</param>
        ///示例：SELECT item FROM tableName WHERE colName condition colValue
        ///<returns>表项</returns>
        public SQLiteDataReader ReadTable(string cmd)
        {
            return ExecuteQuery(cmd);
        }

    }
}

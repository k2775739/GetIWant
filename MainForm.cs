/*
 * 由SharpDevelop创建。
 * 用户： Steven Kong
 * 日期: 2013/1/31
 * 时间: 18:14
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Text;
using System.IO;
namespace Logcq
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public  MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
		
		}
		string head = "";
        string str = System.IO.Directory.GetCurrentDirectory();
		
		void Button1Click(object sender, EventArgs e)
		{
			string htmlp = http.post(URL.Text,Post.Text,Cookie.Text,refer.Text,head);
			richTextBox1.AppendText(htmlp);
		
			write(htmlp);
			
	    }
		public  string Search_string(string s, string s1, string s2)  //获取搜索到的数目
        {
            int n1, n2;
            n1 = s.IndexOf(s1, 0) + s1.Length;   //开始位置
            n2 = s.IndexOf(s2, n1);               //结束位置
            return s.Substring(n1, n2 - n1);   //取搜索的条数，用结束的位置-开始的位置,并返回
        }
 
		
		void Button2Click(object sender, EventArgs e)
		{
			
			string htmll = http.Gethtml(URL.Text,Cookie.Text);
			richTextBox1.AppendText(htmll);
		
			write(htmll);
			
			
		}
		public void write(string word)
		{
			
			                         StreamWriter sr;
             if (File.Exists(str+"\\load.txt")) //如果文件存在,则创建File.AppendText对象
             {
                 sr = File.AppendText(str+"\\load.txt");
             }
             else   //如果文件不存在,则创建File.CreateText对象
             {
                 sr = File.CreateText(str+"\\load.txt");
             }
            // sr.WriteLine(str);
             sr.Close();
           //创建一个文件流，用以写入或者创建一个StreamWriter
            FileStream fs = new FileStream(str+"\\load.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter m_streamWriter = new StreamWriter(fs);
            m_streamWriter.Flush();
            // 使用StreamWriter来往文件中写入内容
            m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            m_streamWriter.Write(word+"\r\n\r\n\r\n");

            //关闭此文件
            m_streamWriter.Flush();
            m_streamWriter.Close();
            
		}


		
		void Button3Click(object sender, EventArgs e)
		{
           richTextBox1.Text="";			
		}
	}
}

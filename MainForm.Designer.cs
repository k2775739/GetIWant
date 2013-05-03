/*
 * 由SharpDevelop创建。
 * 用户： Steven Kong
 * 日期: 2013/1/31
 * 时间: 18:14
 */
namespace Logcq
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.URL = new System.Windows.Forms.TextBox();
			this.Post = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.Cookie = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.refer = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(167, 180);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(86, 40);
			this.button1.TabIndex = 0;
			this.button1.Text = "Post";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("宋体", 12F);
			this.label2.Location = new System.Drawing.Point(34, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "URL:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
		 
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("宋体", 12F);
			this.label3.Location = new System.Drawing.Point(26, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 21);
			this.label3.TabIndex = 3;
			this.label3.Text = "Post:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// URL
			// 
			this.URL.Location = new System.Drawing.Point(85, 17);
			this.URL.MaxLength = 9999;
			this.URL.Name = "URL";
			this.URL.Size = new System.Drawing.Size(236, 21);
			this.URL.TabIndex = 5;
			// 
			// Post
			// 
			this.Post.Location = new System.Drawing.Point(85, 52);
			this.Post.MaxLength = 9999;
			this.Post.Multiline = true;
			this.Post.Name = "Post";
			this.Post.Size = new System.Drawing.Size(236, 21);
			this.Post.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("宋体", 12F);
			this.label1.Location = new System.Drawing.Point(4, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 27);
			this.label1.TabIndex = 7;
			this.label1.Text = "Cookie:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(52, 178);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(78, 42);
			this.button2.TabIndex = 9;
			this.button2.Text = "GET";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(327, 17);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(207, 203);
			this.richTextBox1.TabIndex = 10;
			this.richTextBox1.Text = "";
			// 
			// Cookie
			// 
			this.Cookie.Location = new System.Drawing.Point(85, 92);
			this.Cookie.MaxLength = 9999;
			this.Cookie.Name = "Cookie";
			this.Cookie.Size = new System.Drawing.Size(236, 21);
			this.Cookie.TabIndex = 11;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(388, 226);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 12;
			this.button3.Text = "清空";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("宋体", 12F);
			this.label4.Location = new System.Drawing.Point(20, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 23);
			this.label4.TabIndex = 13;
			this.label4.Text = "Refer:";
			// 
			// refer
			// 
			this.refer.Location = new System.Drawing.Point(85, 128);
			this.refer.Name = "refer";
			this.refer.Size = new System.Drawing.Size(236, 21);
			this.refer.TabIndex = 14;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(553, 261);
			this.Controls.Add(this.refer);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.Cookie);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Post);
			this.Controls.Add(this.URL);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "GetIWant";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox refer;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox Cookie;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox Post;
		private System.Windows.Forms.TextBox URL;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}

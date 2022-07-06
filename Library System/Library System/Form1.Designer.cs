namespace Library_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_book = new System.Windows.Forms.Button();
            this.book_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_cat = new System.Windows.Forms.Button();
            this.search_cat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btn_auth = new System.Windows.Forms.Button();
            this.auth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "No of books:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(286, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Exclude Copies";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "No of Burrowed Books:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.btn_book);
            this.panel1.Controls.Add(this.book_name);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(85, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 242);
            this.panel1.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(29, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(46, 34);
            this.listBox1.TabIndex = 3;
            // 
            // btn_book
            // 
            this.btn_book.Location = new System.Drawing.Point(213, 50);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(94, 23);
            this.btn_book.TabIndex = 2;
            this.btn_book.Text = "Search Book";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // book_name
            // 
            this.book_name.Location = new System.Drawing.Point(29, 49);
            this.book_name.Name = "book_name";
            this.book_name.Size = new System.Drawing.Size(173, 23);
            this.book_name.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Available Copies";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.btn_cat);
            this.panel2.Controls.Add(this.search_cat);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(475, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 242);
            this.panel2.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(24, 88);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(284, 139);
            this.listBox2.TabIndex = 3;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // btn_cat
            // 
            this.btn_cat.Location = new System.Drawing.Point(223, 50);
            this.btn_cat.Name = "btn_cat";
            this.btn_cat.Size = new System.Drawing.Size(75, 23);
            this.btn_cat.TabIndex = 2;
            this.btn_cat.Text = "Search";
            this.btn_cat.UseVisualStyleBackColor = true;
            this.btn_cat.Click += new System.EventHandler(this.btn_cat_Click);
            // 
            // search_cat
            // 
            this.search_cat.Location = new System.Drawing.Point(24, 49);
            this.search_cat.Name = "search_cat";
            this.search_cat.Size = new System.Drawing.Size(174, 23);
            this.search_cat.TabIndex = 1;
            this.search_cat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Books By Category";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBox3);
            this.panel3.Controls.Add(this.btn_auth);
            this.panel3.Controls.Add(this.auth);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(856, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 242);
            this.panel3.TabIndex = 5;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(24, 88);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(280, 139);
            this.listBox3.TabIndex = 3;
            // 
            // btn_auth
            // 
            this.btn_auth.Location = new System.Drawing.Point(229, 50);
            this.btn_auth.Name = "btn_auth";
            this.btn_auth.Size = new System.Drawing.Size(75, 23);
            this.btn_auth.TabIndex = 2;
            this.btn_auth.Text = "Search";
            this.btn_auth.UseVisualStyleBackColor = true;
            this.btn_auth.Click += new System.EventHandler(this.btn_auth_Click);
            // 
            // auth
            // 
            this.auth.Location = new System.Drawing.Point(24, 51);
            this.auth.Name = "auth";
            this.auth.Size = new System.Drawing.Size(173, 23);
            this.auth.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Books By Author";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 15;
            this.listBox4.Location = new System.Drawing.Point(220, 76);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(52, 19);
            this.listBox4.TabIndex = 8;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 15;
            this.listBox6.Location = new System.Drawing.Point(220, 42);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(52, 19);
            this.listBox6.TabIndex = 9;
            this.listBox6.SelectedIndexChanged += new System.EventHandler(this.listBox6_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 646);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.TextBox book_name;
        private System.Windows.Forms.TextBox search_cat;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_cat;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btn_auth;
        private System.Windows.Forms.TextBox auth;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox6;
    }
}


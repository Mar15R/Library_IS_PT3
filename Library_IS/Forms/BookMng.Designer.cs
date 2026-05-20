namespace Library_IS.Forms
{
    partial class BookMng
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_BookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Isbn = new System.Windows.Forms.TextBox();
            this.txt_Year = new System.Windows.Forms.TextBox();
            this.cb_SelectAuthor = new System.Windows.Forms.ComboBox();
            this.bnt_AddBook = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name";
            // 
            // txt_BookName
            // 
            this.txt_BookName.Location = new System.Drawing.Point(127, 33);
            this.txt_BookName.Name = "txt_BookName";
            this.txt_BookName.Size = new System.Drawing.Size(288, 22);
            this.txt_BookName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Author ";
            // 
            // txt_Isbn
            // 
            this.txt_Isbn.Location = new System.Drawing.Point(127, 72);
            this.txt_Isbn.Name = "txt_Isbn";
            this.txt_Isbn.Size = new System.Drawing.Size(288, 22);
            this.txt_Isbn.TabIndex = 6;
            // 
            // txt_Year
            // 
            this.txt_Year.Location = new System.Drawing.Point(127, 115);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(288, 22);
            this.txt_Year.TabIndex = 7;
            // 
            // cb_SelectAuthor
            // 
            this.cb_SelectAuthor.FormattingEnabled = true;
            this.cb_SelectAuthor.Location = new System.Drawing.Point(127, 150);
            this.cb_SelectAuthor.Name = "cb_SelectAuthor";
            this.cb_SelectAuthor.Size = new System.Drawing.Size(288, 24);
            this.cb_SelectAuthor.TabIndex = 8;
            // 
            // bnt_AddBook
            // 
            this.bnt_AddBook.Location = new System.Drawing.Point(22, 227);
            this.bnt_AddBook.Name = "bnt_AddBook";
            this.bnt_AddBook.Size = new System.Drawing.Size(419, 32);
            this.bnt_AddBook.TabIndex = 9;
            this.bnt_AddBook.Text = "Add";
            this.bnt_AddBook.UseVisualStyleBackColor = true;
            this.bnt_AddBook.Click += new System.EventHandler(this.bnt_AddBook_Click);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Location = new System.Drawing.Point(215, 192);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(36, 16);
            this.lbl_Error.TabIndex = 10;
            this.lbl_Error.Text = "Error";
            // 
            // BookMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 277);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.bnt_AddBook);
            this.Controls.Add(this.cb_SelectAuthor);
            this.Controls.Add(this.txt_Year);
            this.Controls.Add(this.txt_Isbn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_BookName);
            this.Controls.Add(this.label1);
            this.Name = "BookMng";
            this.Text = "AddBook";
            this.Load += new System.EventHandler(this.BookMng_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_BookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Isbn;
        private System.Windows.Forms.TextBox txt_Year;
        private System.Windows.Forms.ComboBox cb_SelectAuthor;
        private System.Windows.Forms.Button bnt_AddBook;
        private System.Windows.Forms.Label lbl_Error;
    }
}
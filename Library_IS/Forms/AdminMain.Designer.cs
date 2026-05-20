namespace Library_IS.Forms
{
    partial class AdminMain
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
            this.gv_Books = new System.Windows.Forms.DataGridView();
            this.btn_AddBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Books)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Books
            // 
            this.gv_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Books.Location = new System.Drawing.Point(19, 15);
            this.gv_Books.Name = "gv_Books";
            this.gv_Books.RowHeadersWidth = 51;
            this.gv_Books.RowTemplate.Height = 24;
            this.gv_Books.Size = new System.Drawing.Size(1096, 288);
            this.gv_Books.TabIndex = 0;
            this.gv_Books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Books_CellContentClick);
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.Location = new System.Drawing.Point(21, 314);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(1093, 35);
            this.btn_AddBook.TabIndex = 1;
            this.btn_AddBook.Text = "Add Book";
            this.btn_AddBook.UseVisualStyleBackColor = true;
            this.btn_AddBook.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 571);
            this.Controls.Add(this.btn_AddBook);
            this.Controls.Add(this.gv_Books);
            this.Name = "AdminMain";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMain_FormClosing);
            this.Load += new System.EventHandler(this.AdminMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Books)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Books;
        private System.Windows.Forms.Button btn_AddBook;
    }
}
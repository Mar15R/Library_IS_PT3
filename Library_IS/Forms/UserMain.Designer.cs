namespace Library_IS.Forms
{
    partial class UserMain
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
            this.gv_AvailableBooks = new System.Windows.Forms.DataGridView();
            this.gv_TakenBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AvailableBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TakenBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_AvailableBooks
            // 
            this.gv_AvailableBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_AvailableBooks.Location = new System.Drawing.Point(15, 13);
            this.gv_AvailableBooks.Name = "gv_AvailableBooks";
            this.gv_AvailableBooks.RowHeadersWidth = 51;
            this.gv_AvailableBooks.RowTemplate.Height = 24;
            this.gv_AvailableBooks.Size = new System.Drawing.Size(1071, 272);
            this.gv_AvailableBooks.TabIndex = 0;
            this.gv_AvailableBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_AvailableBooks_CellContentClick);
            // 
            // gv_TakenBooks
            // 
            this.gv_TakenBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_TakenBooks.Location = new System.Drawing.Point(15, 323);
            this.gv_TakenBooks.Name = "gv_TakenBooks";
            this.gv_TakenBooks.RowHeadersWidth = 51;
            this.gv_TakenBooks.RowTemplate.Height = 24;
            this.gv_TakenBooks.Size = new System.Drawing.Size(1071, 234);
            this.gv_TakenBooks.TabIndex = 1;
            this.gv_TakenBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_TakenBooks_CellContentClick);
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 569);
            this.Controls.Add(this.gv_TakenBooks);
            this.Controls.Add(this.gv_AvailableBooks);
            this.Name = "UserMain";
            this.Text = "UserMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserMain_FormClosing);
            this.Load += new System.EventHandler(this.UserMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_AvailableBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TakenBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_AvailableBooks;
        private System.Windows.Forms.DataGridView gv_TakenBooks;
    }
}

namespace DB_lab_3__BookStock
{
    partial class BookStock
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
            this.cboStores = new System.Windows.Forms.ComboBox();
            this.storeView = new System.Windows.Forms.DataGridView();
            this.addBook = new System.Windows.Forms.Button();
            this.refresView = new System.Windows.Forms.Button();
            this.removeBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.storeView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select store:";
            // 
            // cboStores
            // 
            this.cboStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStores.FormattingEnabled = true;
            this.cboStores.Location = new System.Drawing.Point(88, 6);
            this.cboStores.MaxDropDownItems = 100;
            this.cboStores.Name = "cboStores";
            this.cboStores.Size = new System.Drawing.Size(183, 23);
            this.cboStores.Sorted = true;
            this.cboStores.TabIndex = 1;
            this.cboStores.SelectionChangeCommitted += new System.EventHandler(this.PopulateTable);
            // 
            // storeView
            // 
            this.storeView.AllowUserToAddRows = false;
            this.storeView.AllowUserToDeleteRows = false;
            this.storeView.AllowUserToOrderColumns = true;
            this.storeView.AllowUserToResizeColumns = false;
            this.storeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeView.Location = new System.Drawing.Point(88, 44);
            this.storeView.Name = "storeView";
            this.storeView.RowTemplate.Height = 25;
            this.storeView.Size = new System.Drawing.Size(681, 345);
            this.storeView.TabIndex = 2;
            // 
            // addBook
            // 
            this.addBook.Location = new System.Drawing.Point(694, 395);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(75, 23);
            this.addBook.TabIndex = 3;
            this.addBook.Text = "Add book";
            this.addBook.UseVisualStyleBackColor = true;
            this.addBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // refresView
            // 
            this.refresView.Location = new System.Drawing.Point(88, 395);
            this.refresView.Name = "refresView";
            this.refresView.Size = new System.Drawing.Size(102, 23);
            this.refresView.TabIndex = 4;
            this.refresView.Text = "Refresh view";
            this.refresView.UseVisualStyleBackColor = true;
            this.refresView.Click += new System.EventHandler(this.PopulateTable);
            // 
            // removeBook
            // 
            this.removeBook.Location = new System.Drawing.Point(599, 395);
            this.removeBook.Name = "removeBook";
            this.removeBook.Size = new System.Drawing.Size(89, 23);
            this.removeBook.TabIndex = 5;
            this.removeBook.Text = "Remove book";
            this.removeBook.UseVisualStyleBackColor = true;
            this.removeBook.Click += new System.EventHandler(this.RemoveBook_Click);
            // 
            // BookStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeBook);
            this.Controls.Add(this.refresView);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.storeView);
            this.Controls.Add(this.cboStores);
            this.Controls.Add(this.label1);
            this.Name = "BookStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory management";
            ((System.ComponentModel.ISupportInitialize)(this.storeView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStores;
        private System.Windows.Forms.DataGridView storeView;
        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.Button refresView;
        private System.Windows.Forms.Button removeBook;
    }
}


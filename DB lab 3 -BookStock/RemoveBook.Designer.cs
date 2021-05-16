
namespace DB_lab_3__BookStock
{
    partial class RemoveBook
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboStores = new System.Windows.Forms.ComboBox();
            this.cboBooks = new System.Windows.Forms.ComboBox();
            this.removeBook1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select store:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select book:";
            // 
            // cboStores
            // 
            this.cboStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStores.FormattingEnabled = true;
            this.cboStores.Location = new System.Drawing.Point(118, 19);
            this.cboStores.MaxDropDownItems = 100;
            this.cboStores.Name = "cboStores";
            this.cboStores.Size = new System.Drawing.Size(265, 23);
            this.cboStores.Sorted = true;
            this.cboStores.TabIndex = 2;
            this.cboStores.SelectionChangeCommitted += new System.EventHandler(this.CboStores_LoadBooks);
            // 
            // cboBooks
            // 
            this.cboBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBooks.FormattingEnabled = true;
            this.cboBooks.Location = new System.Drawing.Point(118, 47);
            this.cboBooks.MaxDropDownItems = 100;
            this.cboBooks.Name = "cboBooks";
            this.cboBooks.Size = new System.Drawing.Size(265, 23);
            this.cboBooks.TabIndex = 3;
            // 
            // removeBook1
            // 
            this.removeBook1.Location = new System.Drawing.Point(289, 87);
            this.removeBook1.Name = "removeBook1";
            this.removeBook1.Size = new System.Drawing.Size(94, 23);
            this.removeBook1.TabIndex = 4;
            this.removeBook1.Text = "Remove book";
            this.removeBook1.UseVisualStyleBackColor = true;
            this.removeBook1.Click += new System.EventHandler(this.RemoveBook1_Click);
            // 
            // RemoveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 122);
            this.Controls.Add(this.removeBook1);
            this.Controls.Add(this.cboBooks);
            this.Controls.Add(this.cboStores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RemoveBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remove book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboStores;
        private System.Windows.Forms.ComboBox cboBooks;
        private System.Windows.Forms.Button removeBook1;
    }
}
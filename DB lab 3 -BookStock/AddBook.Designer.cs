
namespace DB_lab_3__BookStock
{
    partial class AddBook
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
            this.cboStores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboBooks = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select store:";
            // 
            // cboStores
            // 
            this.cboStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStores.FormattingEnabled = true;
            this.cboStores.Location = new System.Drawing.Point(88, 16);
            this.cboStores.MaxDropDownItems = 100;
            this.cboStores.Name = "cboStores";
            this.cboStores.Size = new System.Drawing.Size(300, 23);
            this.cboStores.Sorted = true;
            this.cboStores.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select book:";
            // 
            // cboBooks
            // 
            this.cboBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBooks.FormattingEnabled = true;
            this.cboBooks.Location = new System.Drawing.Point(89, 45);
            this.cboBooks.MaxDropDownItems = 100;
            this.cboBooks.Name = "cboBooks";
            this.cboBooks.Size = new System.Drawing.Size(299, 23);
            this.cboBooks.Sorted = true;
            this.cboBooks.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 23);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Commit changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 136);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboBooks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboStores);
            this.Controls.Add(this.label1);
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBooks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}
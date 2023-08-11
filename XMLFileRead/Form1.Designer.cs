namespace XMLFileRead
{
    partial class Form1
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
            this.dgvXMLRead = new System.Windows.Forms.DataGridView();
            this.lblRowsCount = new System.Windows.Forms.Label();
            this.btnxmlRead = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXMLRead)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvXMLRead
            // 
            this.dgvXMLRead.AllowUserToAddRows = false;
            this.dgvXMLRead.AllowUserToDeleteRows = false;
            this.dgvXMLRead.AllowUserToResizeRows = false;
            this.dgvXMLRead.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvXMLRead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXMLRead.Location = new System.Drawing.Point(1, 53);
            this.dgvXMLRead.Margin = new System.Windows.Forms.Padding(4);
            this.dgvXMLRead.MultiSelect = false;
            this.dgvXMLRead.Name = "dgvXMLRead";
            this.dgvXMLRead.ReadOnly = true;
            this.dgvXMLRead.RowHeadersVisible = false;
            this.dgvXMLRead.RowHeadersWidth = 51;
            this.dgvXMLRead.Size = new System.Drawing.Size(1403, 535);
            this.dgvXMLRead.TabIndex = 9;
            // 
            // lblRowsCount
            // 
            this.lblRowsCount.AutoSize = true;
            this.lblRowsCount.Location = new System.Drawing.Point(1, 17);
            this.lblRowsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRowsCount.Name = "lblRowsCount";
            this.lblRowsCount.Size = new System.Drawing.Size(79, 16);
            this.lblRowsCount.TabIndex = 11;
            this.lblRowsCount.Text = "Rows count:";
            // 
            // btnxmlRead
            // 
            this.btnxmlRead.Location = new System.Drawing.Point(1286, 4);
            this.btnxmlRead.Margin = new System.Windows.Forms.Padding(4);
            this.btnxmlRead.Name = "btnxmlRead";
            this.btnxmlRead.Size = new System.Drawing.Size(119, 42);
            this.btnxmlRead.TabIndex = 12;
            this.btnxmlRead.Text = "XML Read";
            this.btnxmlRead.UseVisualStyleBackColor = true;
            this.btnxmlRead.Click += new System.EventHandler(this.btnxmlRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 589);
            this.Controls.Add(this.btnxmlRead);
            this.Controls.Add(this.lblRowsCount);
            this.Controls.Add(this.dgvXMLRead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXMLRead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXMLRead;
        private System.Windows.Forms.Label lblRowsCount;
        private System.Windows.Forms.Button btnxmlRead;
    }
}


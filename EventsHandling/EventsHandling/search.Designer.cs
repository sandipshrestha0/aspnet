
namespace EventsHandling
{
    partial class search
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dgvEventhandling = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventhandling)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Search Event Name";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(256, 25);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(264, 20);
            this.txtsearch.TabIndex = 52;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // dgvEventhandling
            // 
            this.dgvEventhandling.AllowUserToAddRows = false;
            this.dgvEventhandling.AllowUserToDeleteRows = false;
            this.dgvEventhandling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEventhandling.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEventhandling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventhandling.Location = new System.Drawing.Point(139, 59);
            this.dgvEventhandling.Name = "dgvEventhandling";
            this.dgvEventhandling.ReadOnly = true;
            this.dgvEventhandling.Size = new System.Drawing.Size(463, 261);
            this.dgvEventhandling.TabIndex = 51;
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dgvEventhandling);
            this.Name = "search";
            this.Text = "search";
            this.Load += new System.EventHandler(this.search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventhandling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridView dgvEventhandling;
    }
}
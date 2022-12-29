
namespace EventsHandling
{
    partial class show
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
            this.dgvEventhandling = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventhandling)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEventhandling
            // 
            this.dgvEventhandling.AllowUserToAddRows = false;
            this.dgvEventhandling.AllowUserToDeleteRows = false;
            this.dgvEventhandling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEventhandling.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEventhandling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventhandling.Location = new System.Drawing.Point(60, 32);
            this.dgvEventhandling.Name = "dgvEventhandling";
            this.dgvEventhandling.ReadOnly = true;
            this.dgvEventhandling.Size = new System.Drawing.Size(463, 261);
            this.dgvEventhandling.TabIndex = 47;
            // 
            // show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEventhandling);
            this.Name = "show";
            this.Text = "show";
            this.Load += new System.EventHandler(this.show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventhandling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEventhandling;
    }
}
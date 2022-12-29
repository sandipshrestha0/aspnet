
namespace EventsHandling
{
    partial class update
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
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtorg = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtevent = new System.Windows.Forms.TextBox();
            this.cost = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.txtno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.dgvEventhandling.Location = new System.Drawing.Point(12, 12);
            this.dgvEventhandling.Name = "dgvEventhandling";
            this.dgvEventhandling.ReadOnly = true;
            this.dgvEventhandling.Size = new System.Drawing.Size(463, 261);
            this.dgvEventhandling.TabIndex = 47;
            this.dgvEventhandling.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventhandling_CellClick);
            // 
            // btnexit
            // 
            this.btnexit.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnexit.Location = new System.Drawing.Point(571, 272);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 85;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.Location = new System.Drawing.Point(529, 233);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 84;
            this.btnclear.Text = "Reset";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(636, 30);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(517, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 82;
            this.label8.Text = "Id";
            // 
            // btnsave
            // 
            this.btnsave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.Location = new System.Drawing.Point(627, 233);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 81;
            this.btnsave.Text = "Update";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(636, 168);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 80;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(636, 194);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 79;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(636, 139);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 78;
            // 
            // txtorg
            // 
            this.txtorg.Location = new System.Drawing.Point(636, 85);
            this.txtorg.Name = "txtorg";
            this.txtorg.Size = new System.Drawing.Size(100, 20);
            this.txtorg.TabIndex = 77;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(636, 111);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 76;
            // 
            // txtevent
            // 
            this.txtevent.Location = new System.Drawing.Point(636, 56);
            this.txtevent.Name = "txtevent";
            this.txtevent.Size = new System.Drawing.Size(100, 20);
            this.txtevent.TabIndex = 75;
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(517, 201);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(35, 13);
            this.cost.TabIndex = 72;
            this.cost.Text = "Cost";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(517, 175);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(32, 13);
            this.email.TabIndex = 74;
            this.email.Text = "Email";
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(517, 146);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(64, 13);
            this.txtno.TabIndex = 73;
            this.txtno.Text = "Phone no";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(515, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Organaizaton/Organizer";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(517, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Event";
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtorg);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtevent);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.email);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvEventhandling);
            this.Name = "update";
            this.Text = "update";
            this.Load += new System.EventHandler(this.update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventhandling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEventhandling;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtorg;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtevent;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label txtno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
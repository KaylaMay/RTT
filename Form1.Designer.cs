namespace RTT
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
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblResAdd = new System.Windows.Forms.Label();
            this.lblWrkAdd = new System.Windows.Forms.Label();
            this.lblPostAdd = new System.Windows.Forms.Label();
            this.lblCellNr = new System.Windows.Forms.Label();
            this.lblWrkNr = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPostAdd = new System.Windows.Forms.TextBox();
            this.txtWrkAdd = new System.Windows.Forms.TextBox();
            this.txtResAdd = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtCellNr = new System.Windows.Forms.TextBox();
            this.txtWrlNr = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.grbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMinimize
            // 
            this.lblMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.White;
            this.lblMinimize.Location = new System.Drawing.Point(421, -1);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(22, 24);
            this.lblMinimize.TabIndex = 0;
            this.lblMinimize.Text = "-";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // lblExit
            // 
            this.lblExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(442, -1);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(22, 24);
            this.lblExit.TabIndex = 1;
            this.lblExit.Text = "x";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click_1);
            // 
            // lblRegister
            // 
            this.lblRegister.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("High Tower Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.Teal;
            this.lblRegister.Location = new System.Drawing.Point(95, 9);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(225, 32);
            this.lblRegister.TabIndex = 10;
            this.lblRegister.Text = "Client Registration";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(12, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 19);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.White;
            this.lblSurname.Location = new System.Drawing.Point(12, 107);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(66, 19);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Surname";
            // 
            // lblResAdd
            // 
            this.lblResAdd.AutoSize = true;
            this.lblResAdd.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResAdd.ForeColor = System.Drawing.Color.White;
            this.lblResAdd.Location = new System.Drawing.Point(12, 218);
            this.lblResAdd.Name = "lblResAdd";
            this.lblResAdd.Size = new System.Drawing.Size(136, 19);
            this.lblResAdd.TabIndex = 6;
            this.lblResAdd.Text = "Residential Address";
            // 
            // lblWrkAdd
            // 
            this.lblWrkAdd.AutoSize = true;
            this.lblWrkAdd.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrkAdd.ForeColor = System.Drawing.Color.White;
            this.lblWrkAdd.Location = new System.Drawing.Point(12, 282);
            this.lblWrkAdd.Name = "lblWrkAdd";
            this.lblWrkAdd.Size = new System.Drawing.Size(109, 19);
            this.lblWrkAdd.TabIndex = 7;
            this.lblWrkAdd.Text = "Work Address";
            // 
            // lblPostAdd
            // 
            this.lblPostAdd.AutoSize = true;
            this.lblPostAdd.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostAdd.ForeColor = System.Drawing.Color.White;
            this.lblPostAdd.Location = new System.Drawing.Point(12, 349);
            this.lblPostAdd.Name = "lblPostAdd";
            this.lblPostAdd.Size = new System.Drawing.Size(107, 19);
            this.lblPostAdd.TabIndex = 8;
            this.lblPostAdd.Text = "Postal Address";
            // 
            // lblCellNr
            // 
            this.lblCellNr.AutoSize = true;
            this.lblCellNr.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellNr.ForeColor = System.Drawing.Color.White;
            this.lblCellNr.Location = new System.Drawing.Point(12, 418);
            this.lblCellNr.Name = "lblCellNr";
            this.lblCellNr.Size = new System.Drawing.Size(94, 19);
            this.lblCellNr.TabIndex = 9;
            this.lblCellNr.Text = "Cell Number";
            // 
            // lblWrkNr
            // 
            this.lblWrkNr.AutoSize = true;
            this.lblWrkNr.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrkNr.ForeColor = System.Drawing.Color.White;
            this.lblWrkNr.Location = new System.Drawing.Point(12, 444);
            this.lblWrkNr.Name = "lblWrkNr";
            this.lblWrkNr.Size = new System.Drawing.Size(111, 19);
            this.lblWrkNr.TabIndex = 10;
            this.lblWrkNr.Text = "Wrok Number";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("High Tower Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(153, 80);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(290, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtPostAdd
            // 
            this.txtPostAdd.Location = new System.Drawing.Point(153, 349);
            this.txtPostAdd.Multiline = true;
            this.txtPostAdd.Name = "txtPostAdd";
            this.txtPostAdd.Size = new System.Drawing.Size(290, 58);
            this.txtPostAdd.TabIndex = 5;
            // 
            // txtWrkAdd
            // 
            this.txtWrkAdd.Location = new System.Drawing.Point(153, 282);
            this.txtWrkAdd.Multiline = true;
            this.txtWrkAdd.Name = "txtWrkAdd";
            this.txtWrkAdd.Size = new System.Drawing.Size(290, 61);
            this.txtWrkAdd.TabIndex = 4;
            // 
            // txtResAdd
            // 
            this.txtResAdd.Location = new System.Drawing.Point(153, 218);
            this.txtResAdd.Multiline = true;
            this.txtResAdd.Name = "txtResAdd";
            this.txtResAdd.Size = new System.Drawing.Size(290, 58);
            this.txtResAdd.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(153, 107);
            this.txtSurname.Multiline = true;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(290, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // txtCellNr
            // 
            this.txtCellNr.Location = new System.Drawing.Point(153, 418);
            this.txtCellNr.Multiline = true;
            this.txtCellNr.Name = "txtCellNr";
            this.txtCellNr.Size = new System.Drawing.Size(290, 20);
            this.txtCellNr.TabIndex = 6;
            // 
            // txtWrlNr
            // 
            this.txtWrlNr.Location = new System.Drawing.Point(153, 444);
            this.txtWrlNr.Multiline = true;
            this.txtWrlNr.Name = "txtWrlNr";
            this.txtWrlNr.Size = new System.Drawing.Size(290, 20);
            this.txtWrlNr.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Black;
            this.btnRegister.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(190, 495);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(221, 40);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(168, 19);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(86, 26);
            this.radFemale.TabIndex = 0;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(323, 19);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(72, 26);
            this.radMale.TabIndex = 0;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // grbGender
            // 
            this.grbGender.Controls.Add(this.radFemale);
            this.grbGender.Controls.Add(this.radMale);
            this.grbGender.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGender.ForeColor = System.Drawing.Color.White;
            this.grbGender.Location = new System.Drawing.Point(16, 142);
            this.grbGender.Name = "grbGender";
            this.grbGender.Size = new System.Drawing.Size(427, 53);
            this.grbGender.TabIndex = 2;
            this.grbGender.TabStop = false;
            this.grbGender.Text = "Gender";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(16, 584);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 33);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "update ";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Black;
            this.btnView.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(331, 584);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(112, 33);
            this.btnView.TabIndex = 12;
            this.btnView.Text = "View Clients";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(468, 629);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grbGender);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtWrlNr);
            this.Controls.Add(this.txtCellNr);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtResAdd);
            this.Controls.Add(this.txtWrkAdd);
            this.Controls.Add(this.txtPostAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblWrkNr);
            this.Controls.Add(this.lblCellNr);
            this.Controls.Add(this.lblPostAdd);
            this.Controls.Add(this.lblWrkAdd);
            this.Controls.Add(this.lblResAdd);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblMinimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.grbGender.ResumeLayout(false);
            this.grbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblResAdd;
        private System.Windows.Forms.Label lblWrkAdd;
        private System.Windows.Forms.Label lblPostAdd;
        private System.Windows.Forms.Label lblCellNr;
        private System.Windows.Forms.Label lblWrkNr;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPostAdd;
        private System.Windows.Forms.TextBox txtWrkAdd;
        private System.Windows.Forms.TextBox txtResAdd;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtCellNr;
        private System.Windows.Forms.TextBox txtWrlNr;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.GroupBox grbGender;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnView;
    }
}


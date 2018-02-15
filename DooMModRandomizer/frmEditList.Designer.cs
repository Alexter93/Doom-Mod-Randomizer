namespace WindowsFormsApplication1
{
    partial class frmEditList
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
            this.cboMods = new System.Windows.Forms.ComboBox();
            this.lblEditIntructions = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtIWad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExe = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBrowsePWAD = new System.Windows.Forms.Button();
            this.btnBrowseEXE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboMods
            // 
            this.cboMods.FormattingEnabled = true;
            this.cboMods.Location = new System.Drawing.Point(15, 29);
            this.cboMods.Name = "cboMods";
            this.cboMods.Size = new System.Drawing.Size(121, 24);
            this.cboMods.TabIndex = 0;
            this.cboMods.SelectedIndexChanged += new System.EventHandler(this.cboMods_SelectedIndexChanged);
            // 
            // lblEditIntructions
            // 
            this.lblEditIntructions.AutoSize = true;
            this.lblEditIntructions.Location = new System.Drawing.Point(12, 9);
            this.lblEditIntructions.Name = "lblEditIntructions";
            this.lblEditIntructions.Size = new System.Drawing.Size(134, 17);
            this.lblEditIntructions.TabIndex = 1;
            this.lblEditIntructions.Text = "Select a Mod to Edit";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(159, 192);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtIWad
            // 
            this.txtIWad.Location = new System.Drawing.Point(15, 85);
            this.txtIWad.Name = "txtIWad";
            this.txtIWad.Size = new System.Drawing.Size(302, 22);
            this.txtIWad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "IWAD (Core Game File):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Source Port:";
            // 
            // txtExe
            // 
            this.txtExe.Location = new System.Drawing.Point(15, 139);
            this.txtExe.Name = "txtExe";
            this.txtExe.Size = new System.Drawing.Size(302, 22);
            this.txtExe.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(114, 163);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(204, 163);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBrowsePWAD
            // 
            this.btnBrowsePWAD.Location = new System.Drawing.Point(323, 85);
            this.btnBrowsePWAD.Name = "btnBrowsePWAD";
            this.btnBrowsePWAD.Size = new System.Drawing.Size(75, 23);
            this.btnBrowsePWAD.TabIndex = 9;
            this.btnBrowsePWAD.Text = "Browse";
            this.btnBrowsePWAD.UseVisualStyleBackColor = true;
            this.btnBrowsePWAD.Click += new System.EventHandler(this.btnBrowsePWAD_Click);
            // 
            // btnBrowseEXE
            // 
            this.btnBrowseEXE.Location = new System.Drawing.Point(323, 139);
            this.btnBrowseEXE.Name = "btnBrowseEXE";
            this.btnBrowseEXE.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseEXE.TabIndex = 10;
            this.btnBrowseEXE.Text = "Browse";
            this.btnBrowseEXE.UseVisualStyleBackColor = true;
            this.btnBrowseEXE.Click += new System.EventHandler(this.btnBrowseEXE_Click);
            // 
            // frmEditList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 227);
            this.Controls.Add(this.btnBrowseEXE);
            this.Controls.Add(this.btnBrowsePWAD);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtExe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIWad);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblEditIntructions);
            this.Controls.Add(this.cboMods);
            this.Name = "frmEditList";
            this.Text = "frmEditList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMods;
        private System.Windows.Forms.Label lblEditIntructions;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtIWad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExe;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBrowsePWAD;
        private System.Windows.Forms.Button btnBrowseEXE;
    }
}
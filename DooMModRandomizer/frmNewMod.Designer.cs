namespace WindowsFormsApplication1
{
    partial class frmNewMod
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
            this.btnBrowsePWAD = new System.Windows.Forms.Button();
            this.btnBrowseIWAD = new System.Windows.Forms.Button();
            this.txtWad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIWad = new System.Windows.Forms.TextBox();
            this.btnBrowseEXE = new System.Windows.Forms.Button();
            this.txtExe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowsePWAD
            // 
            this.btnBrowsePWAD.Location = new System.Drawing.Point(323, 83);
            this.btnBrowsePWAD.Name = "btnBrowsePWAD";
            this.btnBrowsePWAD.Size = new System.Drawing.Size(75, 23);
            this.btnBrowsePWAD.TabIndex = 16;
            this.btnBrowsePWAD.Text = "Browse";
            this.btnBrowsePWAD.UseVisualStyleBackColor = true;
            this.btnBrowsePWAD.Click += new System.EventHandler(this.btnBrowsePWAD_Click);
            // 
            // btnBrowseIWAD
            // 
            this.btnBrowseIWAD.Location = new System.Drawing.Point(323, 29);
            this.btnBrowseIWAD.Name = "btnBrowseIWAD";
            this.btnBrowseIWAD.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseIWAD.TabIndex = 15;
            this.btnBrowseIWAD.Text = "Browse";
            this.btnBrowseIWAD.UseVisualStyleBackColor = true;
            this.btnBrowseIWAD.Click += new System.EventHandler(this.btnBrowseIWAD_Click);
            // 
            // txtWad
            // 
            this.txtWad.Location = new System.Drawing.Point(15, 83);
            this.txtWad.Name = "txtWad";
            this.txtWad.Size = new System.Drawing.Size(302, 22);
            this.txtWad.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "IWAD (Core Game File):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "IWAD (Mod File):";
            // 
            // txtIWad
            // 
            this.txtIWad.Location = new System.Drawing.Point(15, 29);
            this.txtIWad.Name = "txtIWad";
            this.txtIWad.Size = new System.Drawing.Size(302, 22);
            this.txtIWad.TabIndex = 11;
            // 
            // btnBrowseEXE
            // 
            this.btnBrowseEXE.Location = new System.Drawing.Point(323, 137);
            this.btnBrowseEXE.Name = "btnBrowseEXE";
            this.btnBrowseEXE.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseEXE.TabIndex = 19;
            this.btnBrowseEXE.Text = "Browse";
            this.btnBrowseEXE.UseVisualStyleBackColor = true;
            this.btnBrowseEXE.Click += new System.EventHandler(this.btnBrowseEXE_Click);
            // 
            // txtExe
            // 
            this.txtExe.Location = new System.Drawing.Point(15, 137);
            this.txtExe.Name = "txtExe";
            this.txtExe.Size = new System.Drawing.Size(302, 22);
            this.txtExe.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Source Port:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(212, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(122, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmNewMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 200);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBrowseEXE);
            this.Controls.Add(this.txtExe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowsePWAD);
            this.Controls.Add(this.btnBrowseIWAD);
            this.Controls.Add(this.txtWad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIWad);
            this.Name = "frmNewMod";
            this.Text = "frmNewMod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowsePWAD;
        private System.Windows.Forms.Button btnBrowseIWAD;
        private System.Windows.Forms.TextBox txtWad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIWad;
        private System.Windows.Forms.Button btnBrowseEXE;
        private System.Windows.Forms.TextBox txtExe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}
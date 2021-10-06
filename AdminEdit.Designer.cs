namespace GoetzGarage_Invoice
{
    partial class AdminEdit
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
            this.txtService = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.lblServNum = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblMins = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(115, 37);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(100, 20);
            this.txtService.TabIndex = 0;
            this.txtService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtService_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(72, 118);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(115, 81);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 2;
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(72, 118);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(100, 23);
            this.btnSave2.TabIndex = 3;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Visible = false;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // lblServNum
            // 
            this.lblServNum.AutoSize = true;
            this.lblServNum.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblServNum.Location = new System.Drawing.Point(13, 13);
            this.lblServNum.Name = "lblServNum";
            this.lblServNum.Size = new System.Drawing.Size(35, 13);
            this.lblServNum.TabIndex = 4;
            this.lblServNum.Text = "label1";
            this.lblServNum.Visible = false;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(20, 40);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(77, 13);
            this.lblService.TabIndex = 5;
            this.lblService.Text = "Service Name:";
            // 
            // lblMins
            // 
            this.lblMins.AutoSize = true;
            this.lblMins.Location = new System.Drawing.Point(20, 84);
            this.lblMins.Name = "lblMins";
            this.lblMins.Size = new System.Drawing.Size(84, 13);
            this.lblMins.TabIndex = 6;
            this.lblMins.Text = "Time ( minutes ):";
            // 
            // AdminEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 167);
            this.Controls.Add(this.lblMins);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblServNum);
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtService);
            this.Name = "AdminEdit";
            this.Text = "AdminEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Label lblServNum;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblMins;
    }
}
namespace DBMS_PROJECT.View
{
    partial class BloodDonate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloodDonate));
            this.panelBloodDonate = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerLastTimeDonate = new System.Windows.Forms.DateTimePicker();
            this.labelHeder = new System.Windows.Forms.Label();
            this.pictureBoxBlood = new System.Windows.Forms.PictureBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelLastDonateTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelBloodDonate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlood)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBloodDonate
            // 
            this.panelBloodDonate.AutoScroll = true;
            this.panelBloodDonate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelBloodDonate.Controls.Add(this.label1);
            this.panelBloodDonate.Controls.Add(this.dateTimePickerLastTimeDonate);
            this.panelBloodDonate.Controls.Add(this.labelHeder);
            this.panelBloodDonate.Controls.Add(this.pictureBoxBlood);
            this.panelBloodDonate.Controls.Add(this.buttonSubmit);
            this.panelBloodDonate.Controls.Add(this.labelLastDonateTime);
            this.panelBloodDonate.Location = new System.Drawing.Point(-4, 101);
            this.panelBloodDonate.Name = "panelBloodDonate";
            this.panelBloodDonate.Size = new System.Drawing.Size(815, 381);
            this.panelBloodDonate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(539, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 70;
            // 
            // dateTimePickerLastTimeDonate
            // 
            this.dateTimePickerLastTimeDonate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerLastTimeDonate.Enabled = false;
            this.dateTimePickerLastTimeDonate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerLastTimeDonate.Location = new System.Drawing.Point(539, 104);
            this.dateTimePickerLastTimeDonate.MaxDate = new System.DateTime(2030, 12, 4, 0, 0, 0, 0);
            this.dateTimePickerLastTimeDonate.Name = "dateTimePickerLastTimeDonate";
            this.dateTimePickerLastTimeDonate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerLastTimeDonate.TabIndex = 69;
            this.dateTimePickerLastTimeDonate.Value = new System.DateTime(2020, 9, 7, 0, 0, 0, 0);
            // 
            // labelHeder
            // 
            this.labelHeder.AutoSize = true;
            this.labelHeder.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeder.ForeColor = System.Drawing.Color.Maroon;
            this.labelHeder.Location = new System.Drawing.Point(316, 3);
            this.labelHeder.Name = "labelHeder";
            this.labelHeder.Size = new System.Drawing.Size(328, 55);
            this.labelHeder.TabIndex = 6;
            this.labelHeder.Text = "Donate Blood";
            // 
            // pictureBoxBlood
            // 
            this.pictureBoxBlood.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBlood.Image")));
            this.pictureBoxBlood.Location = new System.Drawing.Point(3, 39);
            this.pictureBoxBlood.Name = "pictureBoxBlood";
            this.pictureBoxBlood.Size = new System.Drawing.Size(237, 266);
            this.pictureBoxBlood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBlood.TabIndex = 2;
            this.pictureBoxBlood.TabStop = false;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.Maroon;
            this.buttonSubmit.Location = new System.Drawing.Point(530, 174);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(135, 42);
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Visible = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelLastDonateTime
            // 
            this.labelLastDonateTime.AutoSize = true;
            this.labelLastDonateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastDonateTime.ForeColor = System.Drawing.Color.Maroon;
            this.labelLastDonateTime.Location = new System.Drawing.Point(256, 101);
            this.labelLastDonateTime.Name = "labelLastDonateTime";
            this.labelLastDonateTime.Size = new System.Drawing.Size(277, 25);
            this.labelLastDonateTime.TabIndex = 0;
            this.labelLastDonateTime.Text = "Last Time Blood Donated";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Location = new System.Drawing.Point(-4, 479);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 81);
            this.panel2.TabIndex = 4;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.Red;
            this.labelLogo.Location = new System.Drawing.Point(98, 10);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(186, 42);
            this.labelLogo.TabIndex = 15;
            this.labelLogo.Text = "Life Saver";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Controls.Add(this.buttonBack);
            this.panel3.Controls.Add(this.pictureBoxLogo);
            this.panel3.Controls.Add(this.labelLogo);
            this.panel3.Location = new System.Drawing.Point(-4, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(815, 104);
            this.panel3.TabIndex = 5;
            // 
            // buttonBack
            // 
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.Location = new System.Drawing.Point(742, 18);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(40, 40);
            this.buttonBack.TabIndex = 18;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.BackClick);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(20, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(72, 65);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 16;
            this.pictureBoxLogo.TabStop = false;
            // 
            // BloodDonate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 559);
            this.Controls.Add(this.panelBloodDonate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.Name = "BloodDonate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BloodDonate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DonateClosing);
            this.Load += new System.EventHandler(this.BloodDonateLoading);
            this.panelBloodDonate.ResumeLayout(false);
            this.panelBloodDonate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlood)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBloodDonate;
        private System.Windows.Forms.Label labelHeder;
        private System.Windows.Forms.PictureBox pictureBoxBlood;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelLastDonateTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.DateTimePicker dateTimePickerLastTimeDonate;
        private System.Windows.Forms.Label label1;
    }
}
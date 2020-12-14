namespace DBMS_PROJECT.View
{
    partial class MemberHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberHistory));
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.buttonBalance = new System.Windows.Forms.Button();
            this.buttonDonor = new System.Windows.Forms.Button();
            this.buttonRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Location = new System.Drawing.Point(36, 197);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.Size = new System.Drawing.Size(748, 272);
            this.dataGridViewHistory.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(98, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 41);
            this.label6.TabIndex = 14;
            this.label6.Text = "Life Saver";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Location = new System.Drawing.Point(2, 484);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 72);
            this.panel2.TabIndex = 53;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 97);
            this.panel1.TabIndex = 52;
            // 
            // buttonBack
            // 
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.Location = new System.Drawing.Point(753, 11);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(40, 40);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.BackButton);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(20, 11);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(72, 65);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(314, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 59;
            this.label2.Text = "User History";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.ForeColor = System.Drawing.Color.Maroon;
            this.labelBalance.Location = new System.Drawing.Point(598, 153);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(0, 28);
            this.labelBalance.TabIndex = 58;
            // 
            // buttonBalance
            // 
            this.buttonBalance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonBalance.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBalance.ForeColor = System.Drawing.Color.Maroon;
            this.buttonBalance.Location = new System.Drawing.Point(437, 144);
            this.buttonBalance.Name = "buttonBalance";
            this.buttonBalance.Size = new System.Drawing.Size(155, 47);
            this.buttonBalance.TabIndex = 57;
            this.buttonBalance.Text = "Amount Paid";
            this.buttonBalance.UseVisualStyleBackColor = false;
            this.buttonBalance.Click += new System.EventHandler(this.BalanceClick);
            // 
            // buttonDonor
            // 
            this.buttonDonor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDonor.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDonor.ForeColor = System.Drawing.Color.Maroon;
            this.buttonDonor.Location = new System.Drawing.Point(237, 144);
            this.buttonDonor.Name = "buttonDonor";
            this.buttonDonor.Size = new System.Drawing.Size(181, 47);
            this.buttonDonor.TabIndex = 56;
            this.buttonDonor.Text = "Donate History";
            this.buttonDonor.UseVisualStyleBackColor = false;
            this.buttonDonor.Click += new System.EventHandler(this.DonorClick);
            // 
            // buttonRequest
            // 
            this.buttonRequest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonRequest.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRequest.ForeColor = System.Drawing.Color.Maroon;
            this.buttonRequest.Location = new System.Drawing.Point(36, 144);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(181, 47);
            this.buttonRequest.TabIndex = 55;
            this.buttonRequest.Text = "Request History";
            this.buttonRequest.UseVisualStyleBackColor = false;
            this.buttonRequest.Click += new System.EventHandler(this.ReqClick);
            // 
            // MemberHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 556);
            this.Controls.Add(this.dataGridViewHistory);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.buttonBalance);
            this.Controls.Add(this.buttonDonor);
            this.Controls.Add(this.buttonRequest);
            this.MinimizeBox = false;
            this.Name = "MemberHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberHistory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InfoFormClo);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Button buttonBalance;
        private System.Windows.Forms.Button buttonDonor;
        private System.Windows.Forms.Button buttonRequest;
    }
}
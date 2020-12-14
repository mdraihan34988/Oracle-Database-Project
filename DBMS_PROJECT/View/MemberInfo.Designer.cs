namespace DBMS_PROJECT.View
{
    partial class MemberInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberInfo));
            this.dataGridViewMember = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.buttonHome = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBloodStock = new System.Windows.Forms.Button();
            this.buttonTrigger = new System.Windows.Forms.Button();
            this.buttondisabletrigger = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMember
            // 
            this.dataGridViewMember.AllowUserToAddRows = false;
            this.dataGridViewMember.AllowUserToDeleteRows = false;
            this.dataGridViewMember.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMember.Location = new System.Drawing.Point(2, 268);
            this.dataGridViewMember.Name = "dataGridViewMember";
            this.dataGridViewMember.ReadOnly = true;
            this.dataGridViewMember.Size = new System.Drawing.Size(1051, 220);
            this.dataGridViewMember.TabIndex = 43;
            this.dataGridViewMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClickEvent);
            this.dataGridViewMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMember_CellContentClick);
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
            this.panel2.Location = new System.Drawing.Point(2, 485);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1113, 70);
            this.panel2.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 95);
            this.panel1.TabIndex = 41;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonBack
            // 
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.Location = new System.Drawing.Point(970, 19);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(40, 40);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
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
            // buttonHome
            // 
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(924, 19);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(40, 40);
            this.buttonHome.TabIndex = 19;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(441, 158);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(107, 23);
            this.labelUser.TabIndex = 44;
            this.labelUser.Text = "User Name";
            this.labelUser.Click += new System.EventHandler(this.labelUser_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(573, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 26);
            this.textBox1.TabIndex = 45;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(449, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 24);
            this.label2.TabIndex = 46;
            this.label2.Text = "Member Information";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonBloodStock
            // 
            this.buttonBloodStock.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonBloodStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBloodStock.ForeColor = System.Drawing.Color.Maroon;
            this.buttonBloodStock.Location = new System.Drawing.Point(573, 205);
            this.buttonBloodStock.Name = "buttonBloodStock";
            this.buttonBloodStock.Size = new System.Drawing.Size(124, 40);
            this.buttonBloodStock.TabIndex = 47;
            this.buttonBloodStock.Text = "Manage";
            this.buttonBloodStock.UseVisualStyleBackColor = false;
            this.buttonBloodStock.Click += new System.EventHandler(this.buttonBloodStock_Click);
            // 
            // buttonTrigger
            // 
            this.buttonTrigger.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrigger.ForeColor = System.Drawing.Color.Maroon;
            this.buttonTrigger.Location = new System.Drawing.Point(755, 158);
            this.buttonTrigger.Name = "buttonTrigger";
            this.buttonTrigger.Size = new System.Drawing.Size(161, 40);
            this.buttonTrigger.TabIndex = 48;
            this.buttonTrigger.Text = "Enable Trigger";
            this.buttonTrigger.UseVisualStyleBackColor = false;
            this.buttonTrigger.Click += new System.EventHandler(this.buttonTrigger_Click);
            // 
            // buttondisabletrigger
            // 
            this.buttondisabletrigger.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttondisabletrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondisabletrigger.ForeColor = System.Drawing.Color.Maroon;
            this.buttondisabletrigger.Location = new System.Drawing.Point(755, 204);
            this.buttondisabletrigger.Name = "buttondisabletrigger";
            this.buttondisabletrigger.Size = new System.Drawing.Size(161, 40);
            this.buttondisabletrigger.TabIndex = 49;
            this.buttondisabletrigger.Text = "Disable Trigger";
            this.buttondisabletrigger.UseVisualStyleBackColor = false;
            this.buttondisabletrigger.Click += new System.EventHandler(this.buttondisabletrigger_Click);
            // 
            // MemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 556);
            this.Controls.Add(this.buttondisabletrigger);
            this.Controls.Add(this.buttonTrigger);
            this.Controls.Add(this.buttonBloodStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.dataGridViewMember);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "MemberInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingEvent);
            this.Load += new System.EventHandler(this.MemberInfoLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMember;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBloodStock;
        private System.Windows.Forms.Button buttonTrigger;
        private System.Windows.Forms.Button buttondisabletrigger;
    }
}
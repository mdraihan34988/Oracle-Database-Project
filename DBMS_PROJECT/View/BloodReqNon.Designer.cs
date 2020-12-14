namespace DBMS_PROJECT.View
{
    partial class BloodReqNon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloodReqNon));
            this.buttonRequest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxBloodGroup = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.buttonHome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxMemberStatus = new System.Windows.Forms.TextBox();
            this.textBoxUsrname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRequest
            // 
            this.buttonRequest.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonRequest.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRequest.ForeColor = System.Drawing.Color.Maroon;
            this.buttonRequest.Location = new System.Drawing.Point(623, 311);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(135, 42);
            this.buttonRequest.TabIndex = 34;
            this.buttonRequest.Text = "Request";
            this.buttonRequest.UseVisualStyleBackColor = false;
            this.buttonRequest.Click += new System.EventHandler(this.ReqClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(319, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Select Blood Group";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Location = new System.Drawing.Point(-8, 487);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 70);
            this.panel2.TabIndex = 31;
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
            // comboBoxBloodGroup
            // 
            this.comboBoxBloodGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxBloodGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxBloodGroup.FormattingEnabled = true;
            this.comboBoxBloodGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.comboBoxBloodGroup.Location = new System.Drawing.Point(567, 209);
            this.comboBoxBloodGroup.Name = "comboBoxBloodGroup";
            this.comboBoxBloodGroup.Size = new System.Drawing.Size(191, 21);
            this.comboBoxBloodGroup.TabIndex = 33;
            this.comboBoxBloodGroup.Text = "Select Blood Group";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-8, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 95);
            this.panel1.TabIndex = 30;
            // 
            // buttonBack
            // 
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.Location = new System.Drawing.Point(753, 19);
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
            this.buttonHome.Location = new System.Drawing.Point(707, 19);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(40, 40);
            this.buttonHome.TabIndex = 19;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(454, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "Blood Request";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(567, 262);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(191, 20);
            this.textBoxQuantity.TabIndex = 39;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.ForeColor = System.Drawing.Color.Maroon;
            this.labelQuantity.Location = new System.Drawing.Point(453, 253);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(108, 29);
            this.labelQuantity.TabIndex = 38;
            this.labelQuantity.Text = "Quantity";
            // 
            // textBoxMemberStatus
            // 
            this.textBoxMemberStatus.Location = new System.Drawing.Point(567, 136);
            this.textBoxMemberStatus.Name = "textBoxMemberStatus";
            this.textBoxMemberStatus.Size = new System.Drawing.Size(191, 20);
            this.textBoxMemberStatus.TabIndex = 37;
            this.textBoxMemberStatus.Text = "Non Registered";
            this.textBoxMemberStatus.Visible = false;
            this.textBoxMemberStatus.TextChanged += new System.EventHandler(this.textBoxMemberStatus_TextChanged);
            // 
            // textBoxUsrname
            // 
            this.textBoxUsrname.Location = new System.Drawing.Point(567, 110);
            this.textBoxUsrname.Name = "textBoxUsrname";
            this.textBoxUsrname.Size = new System.Drawing.Size(191, 20);
            this.textBoxUsrname.TabIndex = 36;
            this.textBoxUsrname.Text = "-----------";
            this.textBoxUsrname.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // BloodReqNon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.buttonRequest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBoxBloodGroup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxMemberStatus);
            this.Controls.Add(this.textBoxUsrname);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BloodReqNon";
            this.Text = "BloodReqNon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NonReqFromClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxBloodGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxMemberStatus;
        private System.Windows.Forms.TextBox textBoxUsrname;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
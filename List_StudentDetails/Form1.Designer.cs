namespace List_StudentDetails
{
    partial class studentDetails
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtnameDisplay = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtphno = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblphno = new System.Windows.Forms.Label();
            this.txtAgeDisplay = new System.Windows.Forms.TextBox();
            this.txtPlaceDisplay = new System.Windows.Forms.TextBox();
            this.txtPhnoDisplay = new System.Windows.Forms.TextBox();
            this.cmboboxPlace = new System.Windows.Forms.ComboBox();
            this.lblheadline = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(22, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(145, 282);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtnameDisplay
            // 
            this.txtnameDisplay.Location = new System.Drawing.Point(249, 66);
            this.txtnameDisplay.Name = "txtnameDisplay";
            this.txtnameDisplay.Size = new System.Drawing.Size(100, 20);
            this.txtnameDisplay.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lblheadline);
            this.panel1.Controls.Add(this.cmboboxPlace);
            this.panel1.Controls.Add(this.txtPhnoDisplay);
            this.panel1.Controls.Add(this.txtPlaceDisplay);
            this.panel1.Controls.Add(this.txtAgeDisplay);
            this.panel1.Controls.Add(this.lblphno);
            this.panel1.Controls.Add(this.lblPlace);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtphno);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.txtnameDisplay);
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 323);
            this.panel1.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(22, 123);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 3;
            // 
            // txtphno
            // 
            this.txtphno.Location = new System.Drawing.Point(22, 238);
            this.txtphno.Name = "txtphno";
            this.txtphno.Size = new System.Drawing.Size(100, 20);
            this.txtphno.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Enter your name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(19, 107);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(76, 13);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Enter your age";
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(19, 166);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(89, 13);
            this.lblPlace.TabIndex = 8;
            this.lblPlace.Text = "Select your place";
            // 
            // lblphno
            // 
            this.lblphno.AutoSize = true;
            this.lblphno.Location = new System.Drawing.Point(19, 222);
            this.lblphno.Name = "lblphno";
            this.lblphno.Size = new System.Drawing.Size(82, 13);
            this.lblphno.TabIndex = 9;
            this.lblphno.Text = "Enter your phno";
            // 
            // txtAgeDisplay
            // 
            this.txtAgeDisplay.Location = new System.Drawing.Point(249, 123);
            this.txtAgeDisplay.Name = "txtAgeDisplay";
            this.txtAgeDisplay.Size = new System.Drawing.Size(100, 20);
            this.txtAgeDisplay.TabIndex = 10;
            // 
            // txtPlaceDisplay
            // 
            this.txtPlaceDisplay.Location = new System.Drawing.Point(249, 183);
            this.txtPlaceDisplay.Name = "txtPlaceDisplay";
            this.txtPlaceDisplay.Size = new System.Drawing.Size(100, 20);
            this.txtPlaceDisplay.TabIndex = 11;
            // 
            // txtPhnoDisplay
            // 
            this.txtPhnoDisplay.Location = new System.Drawing.Point(249, 238);
            this.txtPhnoDisplay.Name = "txtPhnoDisplay";
            this.txtPhnoDisplay.Size = new System.Drawing.Size(100, 20);
            this.txtPhnoDisplay.TabIndex = 12;
            // 
            // cmboboxPlace
            // 
            this.cmboboxPlace.FormattingEnabled = true;
            this.cmboboxPlace.Items.AddRange(new object[] {
            "TVM",
            "CLT",
            "EKM"});
            this.cmboboxPlace.Location = new System.Drawing.Point(22, 182);
            this.cmboboxPlace.Name = "cmboboxPlace";
            this.cmboboxPlace.Size = new System.Drawing.Size(100, 21);
            this.cmboboxPlace.TabIndex = 13;
            // 
            // lblheadline
            // 
            this.lblheadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheadline.ForeColor = System.Drawing.Color.Navy;
            this.lblheadline.Location = new System.Drawing.Point(90, 19);
            this.lblheadline.Name = "lblheadline";
            this.lblheadline.Size = new System.Drawing.Size(210, 23);
            this.lblheadline.TabIndex = 14;
            this.lblheadline.Text = "Enter Your Details";
            this.lblheadline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(419, 340);
            this.Controls.Add(this.panel1);
            this.Name = "studentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtnameDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblheadline;
        private System.Windows.Forms.ComboBox cmboboxPlace;
        private System.Windows.Forms.TextBox txtPhnoDisplay;
        private System.Windows.Forms.TextBox txtPlaceDisplay;
        private System.Windows.Forms.TextBox txtAgeDisplay;
        private System.Windows.Forms.Label lblphno;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtphno;
        private System.Windows.Forms.TextBox txtAge;
    }
}


namespace Gruppe15_Opgave_2_GUI
{
    partial class dataGUI
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
            this.btnBS = new System.Windows.Forms.Button();
            this.btnBT = new System.Windows.Forms.Button();
            this.btnBMI = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rBtn5Days = new System.Windows.Forms.RadioButton();
            this.rBtn10Day = new System.Windows.Forms.RadioButton();
            this.rBtn1Month = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpSlut = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxCPR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReadCPR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBS
            // 
            this.btnBS.Enabled = false;
            this.btnBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBS.Location = new System.Drawing.Point(320, 54);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(226, 226);
            this.btnBS.TabIndex = 0;
            this.btnBS.Text = "Vis mit blodsukker";
            this.btnBS.UseVisualStyleBackColor = true;
            this.btnBS.Click += new System.EventHandler(this.btnBS_Click);
            // 
            // btnBT
            // 
            this.btnBT.Enabled = false;
            this.btnBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBT.Location = new System.Drawing.Point(320, 286);
            this.btnBT.Name = "btnBT";
            this.btnBT.Size = new System.Drawing.Size(226, 226);
            this.btnBT.TabIndex = 1;
            this.btnBT.Text = "Vis mit blodtryk";
            this.btnBT.UseVisualStyleBackColor = true;
            this.btnBT.Click += new System.EventHandler(this.btnBT_Click);
            // 
            // btnBMI
            // 
            this.btnBMI.Enabled = false;
            this.btnBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBMI.Location = new System.Drawing.Point(320, 518);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(226, 226);
            this.btnBMI.TabIndex = 2;
            this.btnBMI.Text = "Vis min vægt og BMI";
            this.btnBMI.UseVisualStyleBackColor = true;
            this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.Enabled = false;
            this.btnDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctor.Location = new System.Drawing.Point(816, 286);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(226, 226);
            this.btnDoctor.TabIndex = 3;
            this.btnDoctor.Text = "Send mine oplysninger til lægen";
            this.btnDoctor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(810, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 77);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hvor lang tid er dine mine oplysninger tilgængelig for lægen:";
            // 
            // rBtn5Days
            // 
            this.rBtn5Days.AutoSize = true;
            this.rBtn5Days.Location = new System.Drawing.Point(816, 181);
            this.rBtn5Days.Name = "rBtn5Days";
            this.rBtn5Days.Size = new System.Drawing.Size(109, 29);
            this.rBtn5Days.TabIndex = 5;
            this.rBtn5Days.TabStop = true;
            this.rBtn5Days.Text = "5 dage";
            this.rBtn5Days.UseVisualStyleBackColor = true;
            // 
            // rBtn10Day
            // 
            this.rBtn10Day.AutoSize = true;
            this.rBtn10Day.Location = new System.Drawing.Point(816, 216);
            this.rBtn10Day.Name = "rBtn10Day";
            this.rBtn10Day.Size = new System.Drawing.Size(121, 29);
            this.rBtn10Day.TabIndex = 6;
            this.rBtn10Day.TabStop = true;
            this.rBtn10Day.Text = "10 dage";
            this.rBtn10Day.UseVisualStyleBackColor = true;
            // 
            // rBtn1Month
            // 
            this.rBtn1Month.AutoSize = true;
            this.rBtn1Month.Location = new System.Drawing.Point(816, 251);
            this.rBtn1Month.Name = "rBtn1Month";
            this.rBtn1Month.Size = new System.Drawing.Size(126, 29);
            this.rBtn1Month.TabIndex = 7;
            this.rBtn1Month.TabStop = true;
            this.rBtn1Month.Text = "1 måned";
            this.rBtn1Month.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vælg periode:";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(49, 259);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 31);
            this.dtpStart.TabIndex = 9;
            this.dtpStart.Value = new System.DateTime(2015, 1, 28, 0, 0, 0, 0);
            // 
            // dtpSlut
            // 
            this.dtpSlut.Location = new System.Drawing.Point(49, 362);
            this.dtpSlut.Name = "dtpSlut";
            this.dtpSlut.Size = new System.Drawing.Size(200, 31);
            this.dtpSlut.TabIndex = 10;
            this.dtpSlut.Value = new System.DateTime(2015, 2, 2, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "til";
            // 
            // txtBoxCPR
            // 
            this.txtBoxCPR.Location = new System.Drawing.Point(49, 91);
            this.txtBoxCPR.Name = "txtBoxCPR";
            this.txtBoxCPR.Size = new System.Drawing.Size(200, 31);
            this.txtBoxCPR.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "CPR";
            // 
            // btnReadCPR
            // 
            this.btnReadCPR.Location = new System.Drawing.Point(49, 129);
            this.btnReadCPR.Name = "btnReadCPR";
            this.btnReadCPR.Size = new System.Drawing.Size(200, 39);
            this.btnReadCPR.TabIndex = 15;
            this.btnReadCPR.Text = "Indlæs CPR";
            this.btnReadCPR.UseVisualStyleBackColor = true;
            this.btnReadCPR.Click += new System.EventHandler(this.btnReadCPR_Click);
            // 
            // dataGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 826);
            this.Controls.Add(this.btnReadCPR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxCPR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpSlut);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rBtn1Month);
            this.Controls.Add(this.rBtn10Day);
            this.Controls.Add(this.rBtn5Days);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.btnBMI);
            this.Controls.Add(this.btnBT);
            this.Controls.Add(this.btnBS);
            this.Name = "dataGUI";
            this.Text = "Sundhedssytem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBS;
        private System.Windows.Forms.Button btnBT;
        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtn5Days;
        private System.Windows.Forms.RadioButton rBtn10Day;
        private System.Windows.Forms.RadioButton rBtn1Month;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpSlut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxCPR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReadCPR;
    }
}


namespace HR
{
    partial class EmployeeForm
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
            this.label11 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textAttatchment = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.richTextDescription = new System.Windows.Forms.RichTextBox();
            this.radioButtonSick = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonLeave = new System.Windows.Forms.RadioButton();
            this.radioButtonExeptional = new System.Windows.Forms.RadioButton();
            this.radioButtonAnnual = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.IndianRed;
            this.label11.Location = new System.Drawing.Point(410, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(293, 42);
            this.label11.TabIndex = 46;
            this.label11.Text = "Vacation Request";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(272, 956);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(300, 67);
            this.btnSubmit.TabIndex = 45;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 32);
            this.label5.TabIndex = 40;
            this.label5.Text = "Start date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 32);
            this.label6.TabIndex = 39;
            this.label6.Text = "End date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "Attatchment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 668);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 32);
            this.label4.TabIndex = 35;
            this.label4.Text = "Description";
            // 
            // textAttatchment
            // 
            this.textAttatchment.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAttatchment.Location = new System.Drawing.Point(502, 578);
            this.textAttatchment.Name = "textAttatchment";
            this.textAttatchment.Size = new System.Drawing.Size(311, 41);
            this.textAttatchment.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(611, 956);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 67);
            this.button1.TabIndex = 47;
            this.button1.Text = "Draft";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CalendarFont = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStart.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStart.Location = new System.Drawing.Point(502, 435);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(311, 41);
            this.dateTimeStart.TabIndex = 48;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CalendarFont = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEnd.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEnd.Location = new System.Drawing.Point(502, 505);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(311, 41);
            this.dateTimeEnd.TabIndex = 49;
            // 
            // richTextDescription
            // 
            this.richTextDescription.Location = new System.Drawing.Point(502, 668);
            this.richTextDescription.Name = "richTextDescription";
            this.richTextDescription.Size = new System.Drawing.Size(311, 235);
            this.richTextDescription.TabIndex = 50;
            this.richTextDescription.Text = "";
            // 
            // radioButtonSick
            // 
            this.radioButtonSick.AutoSize = true;
            this.radioButtonSick.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSick.Location = new System.Drawing.Point(506, 295);
            this.radioButtonSick.Name = "radioButtonSick";
            this.radioButtonSick.Size = new System.Drawing.Size(96, 37);
            this.radioButtonSick.TabIndex = 51;
            this.radioButtonSick.TabStop = true;
            this.radioButtonSick.Text = "Sick";
            this.radioButtonSick.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 32);
            this.label2.TabIndex = 52;
            this.label2.Text = "Request Type";
            // 
            // radioButtonLeave
            // 
            this.radioButtonLeave.AutoSize = true;
            this.radioButtonLeave.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLeave.Location = new System.Drawing.Point(657, 297);
            this.radioButtonLeave.Name = "radioButtonLeave";
            this.radioButtonLeave.Size = new System.Drawing.Size(115, 37);
            this.radioButtonLeave.TabIndex = 53;
            this.radioButtonLeave.TabStop = true;
            this.radioButtonLeave.Text = "Leave";
            this.radioButtonLeave.UseVisualStyleBackColor = true;
            // 
            // radioButtonExeptional
            // 
            this.radioButtonExeptional.AutoSize = true;
            this.radioButtonExeptional.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonExeptional.Location = new System.Drawing.Point(657, 354);
            this.radioButtonExeptional.Name = "radioButtonExeptional";
            this.radioButtonExeptional.Size = new System.Drawing.Size(169, 37);
            this.radioButtonExeptional.TabIndex = 55;
            this.radioButtonExeptional.TabStop = true;
            this.radioButtonExeptional.Text = "Expetional";
            this.radioButtonExeptional.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnnual
            // 
            this.radioButtonAnnual.AutoSize = true;
            this.radioButtonAnnual.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnnual.Location = new System.Drawing.Point(506, 354);
            this.radioButtonAnnual.Name = "radioButtonAnnual";
            this.radioButtonAnnual.Size = new System.Drawing.Size(128, 37);
            this.radioButtonAnnual.TabIndex = 54;
            this.radioButtonAnnual.TabStop = true;
            this.radioButtonAnnual.Text = "Annual";
            this.radioButtonAnnual.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 32);
            this.label3.TabIndex = 57;
            this.label3.Text = "Employee ID";
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(502, 203);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(311, 41);
            this.textID.TabIndex = 56;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(417, 1056);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(386, 67);
            this.btnEdit.TabIndex = 58;
            this.btnEdit.Text = "Edit your your information";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1137, 1135);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.radioButtonExeptional);
            this.Controls.Add(this.radioButtonAnnual);
            this.Controls.Add(this.radioButtonLeave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonSick);
            this.Controls.Add(this.richTextDescription);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textAttatchment);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAttatchment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.RichTextBox richTextDescription;
        private System.Windows.Forms.RadioButton radioButtonSick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonLeave;
        private System.Windows.Forms.RadioButton radioButtonExeptional;
        private System.Windows.Forms.RadioButton radioButtonAnnual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button btnEdit;
    }
}
namespace WindowsFormsSQL
{
    partial class NewVisitForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.passportNumber = new System.Windows.Forms.TextBox();
            this.clientAdress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.livingSum = new System.Windows.Forms.TextBox();
            this.secondName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.roomNumber = new System.Windows.Forms.TextBox();
            this.endDate = new System.Windows.Forms.TextBox();
            this.startDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.passportNumber);
            this.panel1.Controls.Add(this.clientAdress);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.livingSum);
            this.panel1.Controls.Add(this.secondName);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.surname);
            this.panel1.Controls.Add(this.roomNumber);
            this.panel1.Controls.Add(this.endDate);
            this.panel1.Controls.Add(this.startDate);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 620);
            this.panel1.TabIndex = 0;
            // 
            // passportNumber
            // 
            this.passportNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passportNumber.Location = new System.Drawing.Point(313, 383);
            this.passportNumber.MaxLength = 10;
            this.passportNumber.Name = "passportNumber";
            this.passportNumber.Size = new System.Drawing.Size(534, 35);
            this.passportNumber.TabIndex = 20;
            // 
            // clientAdress
            // 
            this.clientAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientAdress.Location = new System.Drawing.Point(313, 331);
            this.clientAdress.MaxLength = 100;
            this.clientAdress.Name = "clientAdress";
            this.clientAdress.Size = new System.Drawing.Size(534, 35);
            this.clientAdress.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(30, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 32);
            this.label10.TabIndex = 18;
            this.label10.Text = "Отчество";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(30, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 32);
            this.label9.TabIndex = 17;
            this.label9.Text = "Имя";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(787, 513);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(300, 72);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // livingSum
            // 
            this.livingSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.livingSum.Location = new System.Drawing.Point(313, 444);
            this.livingSum.MaxLength = 6;
            this.livingSum.Name = "livingSum";
            this.livingSum.Size = new System.Drawing.Size(215, 35);
            this.livingSum.TabIndex = 14;
            // 
            // secondName
            // 
            this.secondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondName.Location = new System.Drawing.Point(313, 285);
            this.secondName.MaxLength = 30;
            this.secondName.Name = "secondName";
            this.secondName.Size = new System.Drawing.Size(534, 35);
            this.secondName.TabIndex = 13;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(313, 237);
            this.name.MaxLength = 25;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(534, 35);
            this.name.TabIndex = 12;
            // 
            // surname
            // 
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.Location = new System.Drawing.Point(313, 191);
            this.surname.MaxLength = 30;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(534, 35);
            this.surname.TabIndex = 11;
            // 
            // roomNumber
            // 
            this.roomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomNumber.Location = new System.Drawing.Point(313, 137);
            this.roomNumber.MaxLength = 2;
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(117, 35);
            this.roomNumber.TabIndex = 10;
            // 
            // endDate
            // 
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDate.Location = new System.Drawing.Point(313, 89);
            this.endDate.MaxLength = 10;
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(215, 35);
            this.endDate.TabIndex = 9;
            // 
            // startDate
            // 
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDate.Location = new System.Drawing.Point(313, 41);
            this.startDate.MaxLength = 10;
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(215, 35);
            this.startDate.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(30, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Стоимость жилья";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(30, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Номер паспорта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(30, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Адрес клиента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Номер комнаты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата отъезда";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата въезда";
            // 
            // NewVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 620);
            this.Controls.Add(this.panel1);
            this.Name = "NewVisitForm";
            this.Text = "Новый визит";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox livingSum;
        private System.Windows.Forms.TextBox secondName;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox roomNumber;
        private System.Windows.Forms.TextBox endDate;
        private System.Windows.Forms.TextBox startDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox passportNumber;
        private System.Windows.Forms.TextBox clientAdress;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
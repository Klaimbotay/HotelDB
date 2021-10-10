namespace WindowsFormsSQL
{
    partial class AddServiceForm
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
            this.save_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.service_comboBox = new System.Windows.Forms.ComboBox();
            this.amount_slider = new System.Windows.Forms.NumericUpDown();
            this.sum_value = new System.Windows.Forms.Label();
            this.price_value = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eDate_value = new System.Windows.Forms.Label();
            this.sDate_value = new System.Windows.Forms.Label();
            this.room_value = new System.Windows.Forms.Label();
            this.fio_value = new System.Windows.Forms.Label();
            this.eDate_label = new System.Windows.Forms.Label();
            this.sDate_label = new System.Windows.Forms.Label();
            this.room_label = new System.Windows.Forms.Label();
            this.fio_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amount_slider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.save_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.monthCalendar);
            this.panel1.Controls.Add(this.service_comboBox);
            this.panel1.Controls.Add(this.amount_slider);
            this.panel1.Controls.Add(this.sum_value);
            this.panel1.Controls.Add(this.price_value);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.eDate_value);
            this.panel1.Controls.Add(this.sDate_value);
            this.panel1.Controls.Add(this.room_value);
            this.panel1.Controls.Add(this.fio_value);
            this.panel1.Controls.Add(this.eDate_label);
            this.panel1.Controls.Add(this.sDate_label);
            this.panel1.Controls.Add(this.room_label);
            this.panel1.Controls.Add(this.fio_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 662);
            this.panel1.TabIndex = 0;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_btn.Location = new System.Drawing.Point(722, 561);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(360, 85);
            this.save_btn.TabIndex = 19;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 10);
            this.panel2.TabIndex = 18;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(269, 393);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 17;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // service_comboBox
            // 
            this.service_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.service_comboBox.FormattingEnabled = true;
            this.service_comboBox.Location = new System.Drawing.Point(420, 224);
            this.service_comboBox.Name = "service_comboBox";
            this.service_comboBox.Size = new System.Drawing.Size(375, 40);
            this.service_comboBox.TabIndex = 16;
            this.service_comboBox.SelectedValueChanged += new System.EventHandler(this.service_comboBox_SelectedValueChanged);
            // 
            // amount_slider
            // 
            this.amount_slider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amount_slider.Location = new System.Drawing.Point(228, 328);
            this.amount_slider.Name = "amount_slider";
            this.amount_slider.Size = new System.Drawing.Size(120, 39);
            this.amount_slider.TabIndex = 15;
            this.amount_slider.ValueChanged += new System.EventHandler(this.amount_slider_ValueChanged);
            // 
            // sum_value
            // 
            this.sum_value.AutoSize = true;
            this.sum_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum_value.Location = new System.Drawing.Point(835, 393);
            this.sum_value.Name = "sum_value";
            this.sum_value.Size = new System.Drawing.Size(131, 32);
            this.sum_value.TabIndex = 14;
            this.sum_value.Text = "<cумма>";
            // 
            // price_value
            // 
            this.price_value.AutoSize = true;
            this.price_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_value.ForeColor = System.Drawing.Color.Black;
            this.price_value.Location = new System.Drawing.Point(210, 280);
            this.price_value.Name = "price_value";
            this.price_value.Size = new System.Drawing.Size(184, 32);
            this.price_value.TabIndex = 13;
            this.price_value.Text = "<стоимость>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(716, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Сумма:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Дата оказания:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Количество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Стоимость:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Наименование услуги:";
            // 
            // eDate_value
            // 
            this.eDate_value.AutoSize = true;
            this.eDate_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eDate_value.Location = new System.Drawing.Point(694, 137);
            this.eDate_value.Name = "eDate_value";
            this.eDate_value.Size = new System.Drawing.Size(223, 32);
            this.eDate_value.TabIndex = 7;
            this.eDate_value.Text = "<дата отъезда>";
            // 
            // sDate_value
            // 
            this.sDate_value.AutoSize = true;
            this.sDate_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sDate_value.Location = new System.Drawing.Point(237, 137);
            this.sDate_value.Name = "sDate_value";
            this.sDate_value.Size = new System.Drawing.Size(225, 32);
            this.sDate_value.TabIndex = 6;
            this.sDate_value.Text = "<дата приезда>";
            // 
            // room_value
            // 
            this.room_value.AutoSize = true;
            this.room_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.room_value.Location = new System.Drawing.Point(263, 81);
            this.room_value.Name = "room_value";
            this.room_value.Size = new System.Drawing.Size(131, 32);
            this.room_value.TabIndex = 5;
            this.room_value.Text = "<номер>";
            // 
            // fio_value
            // 
            this.fio_value.AutoSize = true;
            this.fio_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_value.Location = new System.Drawing.Point(128, 28);
            this.fio_value.Name = "fio_value";
            this.fio_value.Size = new System.Drawing.Size(113, 32);
            this.fio_value.TabIndex = 4;
            this.fio_value.Text = "<ФИО>";
            // 
            // eDate_label
            // 
            this.eDate_label.AutoSize = true;
            this.eDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eDate_label.Location = new System.Drawing.Point(483, 137);
            this.eDate_label.Name = "eDate_label";
            this.eDate_label.Size = new System.Drawing.Size(205, 32);
            this.eDate_label.TabIndex = 3;
            this.eDate_label.Text = "Дата отъезда:";
            // 
            // sDate_label
            // 
            this.sDate_label.AutoSize = true;
            this.sDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sDate_label.Location = new System.Drawing.Point(24, 137);
            this.sDate_label.Name = "sDate_label";
            this.sDate_label.Size = new System.Drawing.Size(207, 32);
            this.sDate_label.TabIndex = 2;
            this.sDate_label.Text = "Дата приезда:";
            // 
            // room_label
            // 
            this.room_label.AutoSize = true;
            this.room_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.room_label.Location = new System.Drawing.Point(24, 81);
            this.room_label.Name = "room_label";
            this.room_label.Size = new System.Drawing.Size(233, 32);
            this.room_label.TabIndex = 1;
            this.room_label.Text = "Номер комнаты:";
            // 
            // fio_label
            // 
            this.fio_label.AutoSize = true;
            this.fio_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_label.Location = new System.Drawing.Point(24, 28);
            this.fio_label.Name = "fio_label";
            this.fio_label.Size = new System.Drawing.Size(89, 32);
            this.fio_label.TabIndex = 0;
            this.fio_label.Text = "ФИО:";
            // 
            // AddServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 662);
            this.Controls.Add(this.panel1);
            this.Name = "AddServiceForm";
            this.Text = "Добавить услугу";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amount_slider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label sum_value;
        private System.Windows.Forms.Label price_value;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label eDate_value;
        private System.Windows.Forms.Label sDate_value;
        private System.Windows.Forms.Label room_value;
        private System.Windows.Forms.Label fio_value;
        private System.Windows.Forms.Label eDate_label;
        private System.Windows.Forms.Label sDate_label;
        private System.Windows.Forms.Label room_label;
        private System.Windows.Forms.Label fio_label;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ComboBox service_comboBox;
        private System.Windows.Forms.NumericUpDown amount_slider;
    }
}
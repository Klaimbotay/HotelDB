namespace WindowsFormsSQL
{
    partial class MainForm
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
            this.visitors_btn = new System.Windows.Forms.Button();
            this.clientsReport_bnt = new System.Windows.Forms.Button();
            this.reportsGroup = new System.Windows.Forms.GroupBox();
            this.roomNumberSlider = new System.Windows.Forms.NumericUpDown();
            this.roomsReport_btn = new System.Windows.Forms.Button();
            this.servicesReport_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.reportsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomNumberSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.visitors_btn);
            this.panel1.Controls.Add(this.reportsGroup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 665);
            this.panel1.TabIndex = 0;
            // 
            // visitors_btn
            // 
            this.visitors_btn.AutoSize = true;
            this.visitors_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.visitors_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.visitors_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.visitors_btn.FlatAppearance.BorderSize = 3;
            this.visitors_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visitors_btn.Location = new System.Drawing.Point(374, 192);
            this.visitors_btn.Margin = new System.Windows.Forms.Padding(10);
            this.visitors_btn.Name = "visitors_btn";
            this.visitors_btn.Padding = new System.Windows.Forms.Padding(20);
            this.visitors_btn.Size = new System.Drawing.Size(302, 96);
            this.visitors_btn.TabIndex = 4;
            this.visitors_btn.Text = "Проживание";
            this.visitors_btn.UseVisualStyleBackColor = false;
            this.visitors_btn.Click += new System.EventHandler(this.visitors_btn_Click);
            // 
            // clientsReport_bnt
            // 
            this.clientsReport_bnt.AutoSize = true;
            this.clientsReport_bnt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clientsReport_bnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.clientsReport_bnt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clientsReport_bnt.FlatAppearance.BorderSize = 3;
            this.clientsReport_bnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientsReport_bnt.Location = new System.Drawing.Point(416, 59);
            this.clientsReport_bnt.Margin = new System.Windows.Forms.Padding(10);
            this.clientsReport_bnt.Name = "clientsReport_bnt";
            this.clientsReport_bnt.Padding = new System.Windows.Forms.Padding(20);
            this.clientsReport_bnt.Size = new System.Drawing.Size(230, 96);
            this.clientsReport_bnt.TabIndex = 0;
            this.clientsReport_bnt.Text = "Клиенты";
            this.clientsReport_bnt.UseVisualStyleBackColor = false;
            this.clientsReport_bnt.Click += new System.EventHandler(this.clientsReport_bnt_Click);
            // 
            // reportsGroup
            // 
            this.reportsGroup.AutoSize = true;
            this.reportsGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportsGroup.Controls.Add(this.roomNumberSlider);
            this.reportsGroup.Controls.Add(this.clientsReport_bnt);
            this.reportsGroup.Controls.Add(this.roomsReport_btn);
            this.reportsGroup.Controls.Add(this.servicesReport_btn);
            this.reportsGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportsGroup.Location = new System.Drawing.Point(0, 383);
            this.reportsGroup.Name = "reportsGroup";
            this.reportsGroup.Size = new System.Drawing.Size(1041, 282);
            this.reportsGroup.TabIndex = 3;
            this.reportsGroup.TabStop = false;
            this.reportsGroup.Text = "Отчёты";
            // 
            // roomNumberSlider
            // 
            this.roomNumberSlider.Location = new System.Drawing.Point(666, 177);
            this.roomNumberSlider.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.roomNumberSlider.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.roomNumberSlider.Name = "roomNumberSlider";
            this.roomNumberSlider.Size = new System.Drawing.Size(233, 53);
            this.roomNumberSlider.TabIndex = 3;
            this.roomNumberSlider.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // roomsReport_btn
            // 
            this.roomsReport_btn.AutoSize = true;
            this.roomsReport_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.roomsReport_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.roomsReport_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.roomsReport_btn.FlatAppearance.BorderSize = 3;
            this.roomsReport_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomsReport_btn.Location = new System.Drawing.Point(666, 59);
            this.roomsReport_btn.Margin = new System.Windows.Forms.Padding(10);
            this.roomsReport_btn.Name = "roomsReport_btn";
            this.roomsReport_btn.Padding = new System.Windows.Forms.Padding(20);
            this.roomsReport_btn.Size = new System.Drawing.Size(233, 96);
            this.roomsReport_btn.TabIndex = 2;
            this.roomsReport_btn.Text = "Комната";
            this.roomsReport_btn.UseVisualStyleBackColor = false;
            this.roomsReport_btn.Click += new System.EventHandler(this.roomsReport_bnt_Click);
            // 
            // servicesReport_btn
            // 
            this.servicesReport_btn.AutoSize = true;
            this.servicesReport_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.servicesReport_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.servicesReport_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.servicesReport_btn.FlatAppearance.BorderSize = 3;
            this.servicesReport_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.servicesReport_btn.Location = new System.Drawing.Point(195, 59);
            this.servicesReport_btn.Margin = new System.Windows.Forms.Padding(10);
            this.servicesReport_btn.Name = "servicesReport_btn";
            this.servicesReport_btn.Padding = new System.Windows.Forms.Padding(20);
            this.servicesReport_btn.Size = new System.Drawing.Size(201, 96);
            this.servicesReport_btn.TabIndex = 1;
            this.servicesReport_btn.Text = "Услуги";
            this.servicesReport_btn.UseVisualStyleBackColor = false;
            this.servicesReport_btn.Click += new System.EventHandler(this.servicesReport_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 665);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1063, 721);
            this.MinimumSize = new System.Drawing.Size(1063, 721);
            this.Name = "MainForm";
            this.Text = "Гостиница";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.reportsGroup.ResumeLayout(false);
            this.reportsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomNumberSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox reportsGroup;
        private System.Windows.Forms.Button clientsReport_bnt;
        private System.Windows.Forms.Button roomsReport_btn;
        private System.Windows.Forms.Button servicesReport_btn;
        private System.Windows.Forms.Button visitors_btn;
        private System.Windows.Forms.NumericUpDown roomNumberSlider;
    }
}
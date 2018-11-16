namespace MyGame15
{
    partial class StartForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.radioButton_standart = new System.Windows.Forms.RadioButton();
            this.radioButton_timer2 = new System.Windows.Forms.RadioButton();
            this.radioButton_table = new System.Windows.Forms.RadioButton();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(125, 25);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(273, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // radioButton_standart
            // 
            this.radioButton_standart.AutoSize = true;
            this.radioButton_standart.Location = new System.Drawing.Point(25, 68);
            this.radioButton_standart.Name = "radioButton_standart";
            this.radioButton_standart.Size = new System.Drawing.Size(116, 17);
            this.radioButton_standart.TabIndex = 2;
            this.radioButton_standart.TabStop = true;
            this.radioButton_standart.Text = "Стандартная игра";
            this.radioButton_standart.UseVisualStyleBackColor = true;
            this.radioButton_standart.CheckedChanged += new System.EventHandler(this.radioButton_standart_CheckedChanged);
            // 
            // radioButton_timer2
            // 
            this.radioButton_timer2.AutoSize = true;
            this.radioButton_timer2.Location = new System.Drawing.Point(25, 92);
            this.radioButton_timer2.Name = "radioButton_timer2";
            this.radioButton_timer2.Size = new System.Drawing.Size(100, 17);
            this.radioButton_timer2.TabIndex = 3;
            this.radioButton_timer2.TabStop = true;
            this.radioButton_timer2.Text = "Игра на время";
            this.radioButton_timer2.UseVisualStyleBackColor = true;
            this.radioButton_timer2.CheckedChanged += new System.EventHandler(this.radioButton_timer2_CheckedChanged);
            // 
            // radioButton_table
            // 
            this.radioButton_table.AutoSize = true;
            this.radioButton_table.Location = new System.Drawing.Point(25, 116);
            this.radioButton_table.Name = "radioButton_table";
            this.radioButton_table.Size = new System.Drawing.Size(119, 17);
            this.radioButton_table.TabIndex = 4;
            this.radioButton_table.TabStop = true;
            this.radioButton_table.Text = "Таблица рекордов";
            this.radioButton_table.UseVisualStyleBackColor = true;
            this.radioButton_table.CheckedChanged += new System.EventHandler(this.radioButton_table_CheckedChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(392, 122);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(300, 122);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(150, 88);
            this.trackBar1.Maximum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(73, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "1 мин";
            this.label2.Visible = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(479, 157);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.radioButton_table);
            this.Controls.Add(this.radioButton_timer2);
            this.Controls.Add(this.radioButton_standart);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RadioButton radioButton_table;
        private System.Windows.Forms.RadioButton radioButton_timer2;
        private System.Windows.Forms.RadioButton radioButton_standart;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
    }
}
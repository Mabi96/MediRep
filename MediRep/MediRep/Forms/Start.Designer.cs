
namespace MediRep
{
    partial class Start
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Pacjent_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PdfGeneratorButton = new System.Windows.Forms.Button();
            this.ListaŚrodkówButton = new System.Windows.Forms.Button();
            this.UsuńŚrodekButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Pakiet_comboBox = new System.Windows.Forms.ComboBox();
            this.WybierzPakietButton = new System.Windows.Forms.Button();
            this.NowyPakietButton = new System.Windows.Forms.Button();
            this.UsuńPakietButton = new System.Windows.Forms.Button();
            this.ModyfikujPakietButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveDataButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(984, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(294, 22);
            this.textBox2.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(541, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 22);
            this.textBox1.TabIndex = 31;
            // 
            // Pacjent_comboBox
            // 
            this.Pacjent_comboBox.FormattingEnabled = true;
            this.Pacjent_comboBox.Location = new System.Drawing.Point(101, 39);
            this.Pacjent_comboBox.Name = "Pacjent_comboBox";
            this.Pacjent_comboBox.Size = new System.Drawing.Size(312, 24);
            this.Pacjent_comboBox.TabIndex = 30;
            this.Pacjent_comboBox.SelectedIndexChanged += new System.EventHandler(this.Pacjent_comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(859, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Pielęgniarka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(464, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Lekarz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Pacjent";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(14, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1349, 338);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zużyte Środki";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1337, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 35;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Środek farmaceutyczny";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Postać";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Jednostka_miary";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Jednostka";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Dawka";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            dataGridViewCellStyle1.NullValue = "0";
            this.Column7.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column7.HeaderText = "Ilość_pobrana";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            dataGridViewCellStyle2.NullValue = "0.0";
            this.Column8.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column8.HeaderText = "Ilość_podana";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // PdfGeneratorButton
            // 
            this.PdfGeneratorButton.Location = new System.Drawing.Point(20, 517);
            this.PdfGeneratorButton.Name = "PdfGeneratorButton";
            this.PdfGeneratorButton.Size = new System.Drawing.Size(286, 52);
            this.PdfGeneratorButton.TabIndex = 35;
            this.PdfGeneratorButton.Text = "Wykonaj Raport PDF";
            this.PdfGeneratorButton.UseVisualStyleBackColor = true;
            this.PdfGeneratorButton.Click += new System.EventHandler(this.PdfGeneratorButton_Click);
            // 
            // ListaŚrodkówButton
            // 
            this.ListaŚrodkówButton.Location = new System.Drawing.Point(166, 459);
            this.ListaŚrodkówButton.Name = "ListaŚrodkówButton";
            this.ListaŚrodkówButton.Size = new System.Drawing.Size(140, 52);
            this.ListaŚrodkówButton.TabIndex = 34;
            this.ListaŚrodkówButton.Text = "Wybierz z listy";
            this.ListaŚrodkówButton.UseVisualStyleBackColor = true;
            this.ListaŚrodkówButton.Click += new System.EventHandler(this.ListaŚrodkówButton_Click);
            // 
            // UsuńŚrodekButton
            // 
            this.UsuńŚrodekButton.Location = new System.Drawing.Point(20, 459);
            this.UsuńŚrodekButton.Name = "UsuńŚrodekButton";
            this.UsuńŚrodekButton.Size = new System.Drawing.Size(140, 52);
            this.UsuńŚrodekButton.TabIndex = 33;
            this.UsuńŚrodekButton.Text = "Usuń Środek";
            this.UsuńŚrodekButton.UseVisualStyleBackColor = true;
            this.UsuńŚrodekButton.Click += new System.EventHandler(this.UsuńŚrodekButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Pakiet_comboBox);
            this.groupBox2.Controls.Add(this.WybierzPakietButton);
            this.groupBox2.Controls.Add(this.NowyPakietButton);
            this.groupBox2.Controls.Add(this.UsuńPakietButton);
            this.groupBox2.Controls.Add(this.ModyfikujPakietButton);
            this.groupBox2.Location = new System.Drawing.Point(1025, 470);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 178);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pakiety";
            // 
            // Pakiet_comboBox
            // 
            this.Pakiet_comboBox.FormattingEnabled = true;
            this.Pakiet_comboBox.Location = new System.Drawing.Point(20, 22);
            this.Pakiet_comboBox.Name = "Pakiet_comboBox";
            this.Pakiet_comboBox.Size = new System.Drawing.Size(300, 24);
            this.Pakiet_comboBox.TabIndex = 3;
            // 
            // WybierzPakietButton
            // 
            this.WybierzPakietButton.Location = new System.Drawing.Point(19, 56);
            this.WybierzPakietButton.Name = "WybierzPakietButton";
            this.WybierzPakietButton.Size = new System.Drawing.Size(98, 44);
            this.WybierzPakietButton.TabIndex = 0;
            this.WybierzPakietButton.Text = "Wybierz";
            this.WybierzPakietButton.UseVisualStyleBackColor = true;
            this.WybierzPakietButton.Click += new System.EventHandler(this.WybierzPakietButton_Click);
            // 
            // NowyPakietButton
            // 
            this.NowyPakietButton.Location = new System.Drawing.Point(19, 106);
            this.NowyPakietButton.Name = "NowyPakietButton";
            this.NowyPakietButton.Size = new System.Drawing.Size(306, 49);
            this.NowyPakietButton.TabIndex = 2;
            this.NowyPakietButton.Text = "Utwórz Nowy";
            this.NowyPakietButton.UseVisualStyleBackColor = true;
            this.NowyPakietButton.Click += new System.EventHandler(this.NowyPakietButton_Click);
            // 
            // UsuńPakietButton
            // 
            this.UsuńPakietButton.Location = new System.Drawing.Point(227, 56);
            this.UsuńPakietButton.Name = "UsuńPakietButton";
            this.UsuńPakietButton.Size = new System.Drawing.Size(98, 44);
            this.UsuńPakietButton.TabIndex = 1;
            this.UsuńPakietButton.Text = "Usuń";
            this.UsuńPakietButton.UseVisualStyleBackColor = true;
            this.UsuńPakietButton.Click += new System.EventHandler(this.UsuńPakietButton_Click);
            // 
            // ModyfikujPakietButton
            // 
            this.ModyfikujPakietButton.Location = new System.Drawing.Point(123, 56);
            this.ModyfikujPakietButton.Name = "ModyfikujPakietButton";
            this.ModyfikujPakietButton.Size = new System.Drawing.Size(98, 44);
            this.ModyfikujPakietButton.TabIndex = 2;
            this.ModyfikujPakietButton.Text = "Modyfikuj";
            this.ModyfikujPakietButton.UseVisualStyleBackColor = true;
            this.ModyfikujPakietButton.Click += new System.EventHandler(this.ModyfikujPakietButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 38;
            // 
            // SaveDataButton
            // 
            this.SaveDataButton.Location = new System.Drawing.Point(500, 449);
            this.SaveDataButton.Name = "SaveDataButton";
            this.SaveDataButton.Size = new System.Drawing.Size(237, 52);
            this.SaveDataButton.TabIndex = 39;
            this.SaveDataButton.Text = "Zapisz Zmiany";
            this.SaveDataButton.UseVisualStyleBackColor = true;
            this.SaveDataButton.Click += new System.EventHandler(this.SaveDataButton_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 660);
            this.Controls.Add(this.SaveDataButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.PdfGeneratorButton);
            this.Controls.Add(this.ListaŚrodkówButton);
            this.Controls.Add(this.UsuńŚrodekButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Pacjent_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Start";
            this.Text = "MediRep";
            this.Load += new System.EventHandler(this.Start_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox Pacjent_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PdfGeneratorButton;
        private System.Windows.Forms.Button ListaŚrodkówButton;
        private System.Windows.Forms.Button UsuńŚrodekButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox Pakiet_comboBox;
        private System.Windows.Forms.Button WybierzPakietButton;
        private System.Windows.Forms.Button NowyPakietButton;
        private System.Windows.Forms.Button UsuńPakietButton;
        private System.Windows.Forms.Button ModyfikujPakietButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveDataButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}


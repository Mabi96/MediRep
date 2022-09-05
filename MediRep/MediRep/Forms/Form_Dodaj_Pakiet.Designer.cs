
namespace MediRep.Forms
{
    partial class Form_Dodaj_Pakiet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ListaŚrodkówButton = new System.Windows.Forms.Button();
            this.UsuńŚrodekButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PakietName = new System.Windows.Forms.TextBox();
            this.OK_button = new System.Windows.Forms.Button();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.ListaŚrodkówButton);
            this.groupBox1.Controls.Add(this.UsuńŚrodekButton);
            this.groupBox1.Location = new System.Drawing.Point(11, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 463);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pakiet";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(839, 373);
            this.dataGridView1.TabIndex = 8;
            // 
            // ListaŚrodkówButton
            // 
            this.ListaŚrodkówButton.Location = new System.Drawing.Point(718, 400);
            this.ListaŚrodkówButton.Name = "ListaŚrodkówButton";
            this.ListaŚrodkówButton.Size = new System.Drawing.Size(127, 57);
            this.ListaŚrodkówButton.TabIndex = 7;
            this.ListaŚrodkówButton.Text = "Wybierz z listy";
            this.ListaŚrodkówButton.UseVisualStyleBackColor = true;
            this.ListaŚrodkówButton.Click += new System.EventHandler(this.ListaŚrodkówButton_Click);
            // 
            // UsuńŚrodekButton
            // 
            this.UsuńŚrodekButton.Location = new System.Drawing.Point(585, 400);
            this.UsuńŚrodekButton.Name = "UsuńŚrodekButton";
            this.UsuńŚrodekButton.Size = new System.Drawing.Size(127, 57);
            this.UsuńŚrodekButton.TabIndex = 6;
            this.UsuńŚrodekButton.Text = "Usuń Środek";
            this.UsuńŚrodekButton.UseVisualStyleBackColor = true;
            this.UsuńŚrodekButton.Click += new System.EventHandler(this.UsuńŚrodekButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nazwa Pakietu";
            // 
            // PakietName
            // 
            this.PakietName.Location = new System.Drawing.Point(188, 9);
            this.PakietName.Name = "PakietName";
            this.PakietName.Size = new System.Drawing.Size(285, 22);
            this.PakietName.TabIndex = 11;
            // 
            // OK_button
            // 
            this.OK_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OK_button.Location = new System.Drawing.Point(342, 526);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(221, 76);
            this.OK_button.TabIndex = 10;
            this.OK_button.Text = "Zatwierdź";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 35;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nazwa";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Postać";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Jednostka_miary";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Jednostka";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Form_Dodaj_Pakiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 614);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PakietName);
            this.Controls.Add(this.OK_button);
            this.Name = "Form_Dodaj_Pakiet";
            this.Text = "Form_Dodaj_Pakiet";
            this.Load += new System.EventHandler(this.Form_Dodaj_Pakiet_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ListaŚrodkówButton;
        private System.Windows.Forms.Button UsuńŚrodekButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PakietName;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
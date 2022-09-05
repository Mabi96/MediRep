
namespace MediRep.Forms
{
    partial class Form_DodajPakiet
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
            this.ListaŚrodkówButton = new System.Windows.Forms.Button();
            this.UsuńŚrodekButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OK_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.groupBox1.Size = new System.Drawing.Size(558, 463);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pakiet";
            // 
            // ListaŚrodkówButton
            // 
            this.ListaŚrodkówButton.Location = new System.Drawing.Point(423, 390);
            this.ListaŚrodkówButton.Name = "ListaŚrodkówButton";
            this.ListaŚrodkówButton.Size = new System.Drawing.Size(127, 57);
            this.ListaŚrodkówButton.TabIndex = 7;
            this.ListaŚrodkówButton.Text = "Wybierz z listy";
            this.ListaŚrodkówButton.UseVisualStyleBackColor = true;
            // 
            // UsuńŚrodekButton
            // 
            this.UsuńŚrodekButton.Location = new System.Drawing.Point(290, 390);
            this.UsuńŚrodekButton.Name = "UsuńŚrodekButton";
            this.UsuńŚrodekButton.Size = new System.Drawing.Size(127, 57);
            this.UsuńŚrodekButton.TabIndex = 6;
            this.UsuńŚrodekButton.Text = "Usuń Środek";
            this.UsuńŚrodekButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nazwa Pakietu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 22);
            this.textBox1.TabIndex = 7;
            // 
            // OK_button
            // 
            this.OK_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OK_button.Location = new System.Drawing.Point(177, 531);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(221, 76);
            this.OK_button.TabIndex = 6;
            this.OK_button.Text = "Zatwierdź";
            this.OK_button.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(546, 363);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form_DodajPakiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 619);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OK_button);
            this.Name = "Form_DodajPakiet";
            this.Text = "Form_DodajPakiet";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ListaŚrodkówButton;
        private System.Windows.Forms.Button UsuńŚrodekButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
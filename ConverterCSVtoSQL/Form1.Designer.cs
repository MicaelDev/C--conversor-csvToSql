
namespace ConverterCSVtoSQL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCSV = new System.Windows.Forms.TextBox();
            this.tbSQL = new System.Windows.Forms.TextBox();
            this.btnCSV = new System.Windows.Forms.Button();
            this.btnConverter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCSV
            // 
            this.tbCSV.Location = new System.Drawing.Point(166, 12);
            this.tbCSV.Name = "tbCSV";
            this.tbCSV.Size = new System.Drawing.Size(493, 23);
            this.tbCSV.TabIndex = 0;
            // 
            // tbSQL
            // 
            this.tbSQL.Location = new System.Drawing.Point(166, 43);
            this.tbSQL.Name = "tbSQL";
            this.tbSQL.Size = new System.Drawing.Size(493, 23);
            this.tbSQL.TabIndex = 1;
            // 
            // btnCSV
            // 
            this.btnCSV.Location = new System.Drawing.Point(665, 12);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(24, 23);
            this.btnCSV.TabIndex = 2;
            this.btnCSV.Text = "...";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverter.Location = new System.Drawing.Point(695, 12);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(85, 54);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.Text = "Converter Dados";
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Diretório entrada (.CSV)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Diretório saída (.SQL)";
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(665, 43);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(24, 23);
            this.btnSQL.TabIndex = 7;
            this.btnSQL.Text = "...";
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.btnSQL_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 80);
            this.Controls.Add(this.btnSQL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.tbSQL);
            this.Controls.Add(this.tbCSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor CSV to SQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCSV;
        private System.Windows.Forms.TextBox tbSQL;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSQL;
    }
}


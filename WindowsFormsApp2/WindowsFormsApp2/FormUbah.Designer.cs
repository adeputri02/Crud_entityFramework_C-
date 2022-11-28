
namespace WindowsFormsApp2
{
    partial class FormUbah
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.jumlah = new System.Windows.Forms.TextBox();
            this.kd_produksi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.shift = new System.Windows.Forms.TextBox();
            this.tgl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = " Shift";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = " Tanggal Produksi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = " Jumlah";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = " Kode Produksi";
            // 
            // jumlah
            // 
            this.jumlah.Location = new System.Drawing.Point(152, 125);
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(151, 20);
            this.jumlah.TabIndex = 15;
            // 
            // kd_produksi
            // 
            this.kd_produksi.Location = new System.Drawing.Point(152, 99);
            this.kd_produksi.Name = "kd_produksi";
            this.kd_produksi.Size = new System.Drawing.Size(151, 20);
            this.kd_produksi.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = " Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = " Batal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // shift
            // 
            this.shift.Location = new System.Drawing.Point(152, 70);
            this.shift.Name = "shift";
            this.shift.Size = new System.Drawing.Size(150, 20);
            this.shift.TabIndex = 25;
            this.shift.Text = " ";
            // 
            // tgl
            // 
            this.tgl.Location = new System.Drawing.Point(153, 41);
            this.tgl.Name = "tgl";
            this.tgl.Size = new System.Drawing.Size(150, 20);
            this.tgl.TabIndex = 24;
            this.tgl.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Id";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(151, 12);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(151, 20);
            this.id.TabIndex = 26;
            // 
            // FormUbah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 229);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.id);
            this.Controls.Add(this.shift);
            this.Controls.Add(this.tgl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jumlah);
            this.Controls.Add(this.kd_produksi);
            this.Name = "FormUbah";
            this.Text = "FormUbah";
            this.Load += new System.EventHandler(this.FormUbah_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox jumlah;
        private System.Windows.Forms.TextBox kd_produksi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox shift;
        private System.Windows.Forms.TextBox tgl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id;
    }
}
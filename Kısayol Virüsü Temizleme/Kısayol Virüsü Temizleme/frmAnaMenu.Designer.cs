namespace Kısayol_Virüsü_Temizleme
{
    partial class frmAnaMenu
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.txtSecilenSurucu = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.comboSurucuListele = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuYardim = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBox1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnBaslat);
            this.GroupBox1.Controls.Add(this.txtSecilenSurucu);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.comboSurucuListele);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 27);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(244, 98);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Sürücü...";
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(163, 69);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 23);
            this.btnBaslat.TabIndex = 6;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // txtSecilenSurucu
            // 
            this.txtSecilenSurucu.Location = new System.Drawing.Point(93, 46);
            this.txtSecilenSurucu.Name = "txtSecilenSurucu";
            this.txtSecilenSurucu.ReadOnly = true;
            this.txtSecilenSurucu.Size = new System.Drawing.Size(145, 20);
            this.txtSecilenSurucu.TabIndex = 5;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 49);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(88, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Seçilen Sürücü : ";
            // 
            // comboSurucuListele
            // 
            this.comboSurucuListele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSurucuListele.FormattingEnabled = true;
            this.comboSurucuListele.Location = new System.Drawing.Point(93, 18);
            this.comboSurucuListele.Name = "comboSurucuListele";
            this.comboSurucuListele.Size = new System.Drawing.Size(145, 21);
            this.comboSurucuListele.TabIndex = 3;
            this.comboSurucuListele.SelectedIndexChanged += new System.EventHandler(this.comboSurucuListele_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(81, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Sürücü Seçiniz:";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuYardim});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(268, 24);
            this.MenuStrip1.TabIndex = 5;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.listBox1);
            this.Panel1.Location = new System.Drawing.Point(12, 131);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(244, 100);
            this.Panel1.TabIndex = 6;
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(102, 240);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(44, 13);
            this.lblsonuc.TabIndex = 7;
            this.lblsonuc.Text = "Sonuç :";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(244, 100);
            this.listBox1.TabIndex = 7;
            // 
            // menuYardim
            // 
            this.menuYardim.Name = "menuYardim";
            this.menuYardim.Size = new System.Drawing.Size(56, 20);
            this.menuYardim.Text = "Yardım";
            this.menuYardim.Click += new System.EventHandler(this.menuYardim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 265);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kısayol Virüsü Silme Beta v1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnBaslat;
        internal System.Windows.Forms.TextBox txtSecilenSurucu;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox comboSurucuListele;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem menuYardim;
    }
}


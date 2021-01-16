namespace AtaliTicaret.DesktopUI
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
            this.bilgiPanel = new System.Windows.Forms.Panel();
            this.tabloDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.urunBtn = new System.Windows.Forms.Button();
            this.kategoriBtn = new System.Windows.Forms.Button();
            this.saticiBtn = new System.Windows.Forms.Button();
            this.bilgiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabloDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bilgiPanel
            // 
            this.bilgiPanel.Controls.Add(this.label1);
            this.bilgiPanel.Location = new System.Drawing.Point(0, 0);
            this.bilgiPanel.Name = "bilgiPanel";
            this.bilgiPanel.Size = new System.Drawing.Size(800, 212);
            this.bilgiPanel.TabIndex = 1;
            // 
            // tabloDgv
            // 
            this.tabloDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabloDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabloDgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabloDgv.Location = new System.Drawing.Point(0, 0);
            this.tabloDgv.Name = "tabloDgv";
            this.tabloDgv.Size = new System.Drawing.Size(800, 227);
            this.tabloDgv.TabIndex = 0;
            this.tabloDgv.Text = "dataGridView1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(699, 110);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kayıtlı Verileri Görüntülemek İçin Aşağıdaki Butonları Kullanınız.";
            // 
            // urunBtn
            // 
            this.urunBtn.Location = new System.Drawing.Point(208, 271);
            this.urunBtn.Name = "urunBtn";
            this.urunBtn.Size = new System.Drawing.Size(125, 69);
            this.urunBtn.TabIndex = 2;
            this.urunBtn.Text = "Ürünleri Görüntüle";
            this.urunBtn.UseVisualStyleBackColor = true;
            this.urunBtn.Click += new System.EventHandler(this.btnsClick);
            // 
            // kategoriBtn
            // 
            this.kategoriBtn.Location = new System.Drawing.Point(339, 271);
            this.kategoriBtn.Name = "kategoriBtn";
            this.kategoriBtn.Size = new System.Drawing.Size(125, 69);
            this.kategoriBtn.TabIndex = 2;
            this.kategoriBtn.Text = "Kategorileri Görüntüle";
            this.kategoriBtn.UseVisualStyleBackColor = true;
            this.kategoriBtn.Click += new System.EventHandler(this.btnsClick);
            // 
            // saticiBtn
            // 
            this.saticiBtn.Location = new System.Drawing.Point(470, 271);
            this.saticiBtn.Name = "saticiBtn";
            this.saticiBtn.Size = new System.Drawing.Size(125, 69);
            this.saticiBtn.TabIndex = 2;
            this.saticiBtn.Text = "Satıcıları Görüntüle";
            this.saticiBtn.UseVisualStyleBackColor = true;
            this.saticiBtn.Click += new System.EventHandler(this.btnsClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saticiBtn);
            this.Controls.Add(this.kategoriBtn);
            this.Controls.Add(this.urunBtn);
            this.Controls.Add(this.bilgiPanel);
            this.Controls.Add(this.tabloDgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.bilgiPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabloDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bilgiPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tabloDgv;
        private System.Windows.Forms.Button urunBtn;
        private System.Windows.Forms.Button kategoriBtn;
        private System.Windows.Forms.Button saticiBtn;
    }
}


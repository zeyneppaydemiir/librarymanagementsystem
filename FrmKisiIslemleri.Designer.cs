namespace KutuphaneOtomasyonu
{
    partial class FrmKisiIslemleri
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKisiIslemleri));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            BtnKAYDET = new Button();
            MskTEL = new MaskedTextBox();
            label4 = new Label();
            MskDT = new MaskedTextBox();
            label3 = new Label();
            MskID = new MaskedTextBox();
            label2 = new Label();
            MskAD = new MaskedTextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            groupBox2 = new GroupBox();
            BtnGUNCELLE = new Button();
            MskTELG = new MaskedTextBox();
            label5 = new Label();
            MskDTG = new MaskedTextBox();
            label6 = new Label();
            MskIDG = new MaskedTextBox();
            label7 = new Label();
            MskADG = new MaskedTextBox();
            label8 = new Label();
            tabPage3 = new TabPage();
            dataGridView3 = new DataGridView();
            groupBox3 = new GroupBox();
            BtnSIL = new Button();
            MskTELS = new MaskedTextBox();
            label9 = new Label();
            MskDTS = new MaskedTextBox();
            label10 = new Label();
            MskIDS = new MaskedTextBox();
            label11 = new Label();
            MskADS = new MaskedTextBox();
            label12 = new Label();
            ımageList1 = new ImageList(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.ImageList = ımageList1;
            tabControl1.Location = new Point(13, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1419, 733);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = Properties.Resources.istockphoto_1308634001_612x612;
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.ImageIndex = 3;
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1411, 702);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "KİŞİ EKLE";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(496, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(887, 612);
            dataGridView1.TabIndex = 2;
            // >>> SATIR TIKLAMA OLAYI <<<
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.istockphoto_1308634001_612x612;
            groupBox1.Controls.Add(BtnKAYDET);
            groupBox1.Controls.Add(MskTEL);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(MskDT);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(MskID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(MskAD);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(484, 623);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "KİŞİ BİLGİLERİ";
            // 
            // BtnKAYDET
            // 
            BtnKAYDET.Location = new Point(163, 255);
            BtnKAYDET.Name = "BtnKAYDET";
            BtnKAYDET.Size = new Size(178, 76);
            BtnKAYDET.TabIndex = 11;
            BtnKAYDET.Text = "KAYDET";
            BtnKAYDET.UseVisualStyleBackColor = true;
            // >>> KAYDET BUTONU OLAYI <<<
            BtnKAYDET.Click += BtnKAYDET_Click;
            // 
            // MskTEL
            // 
            MskTEL.Location = new Point(87, 170);
            MskTEL.Mask = "(999) 000-0000";
            MskTEL.Name = "MskTEL";
            MskTEL.Size = new Size(296, 26);
            MskTEL.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F);
            label4.Location = new Point(9, 175);
            label4.Name = "label4";
            label4.Size = new Size(64, 16);
            label4.TabIndex = 9;
            label4.Text = "TELEFON:";
            // 
            // MskDT
            // 
            MskDT.Location = new Point(114, 120);
            MskDT.Mask = "00/00/0000";
            MskDT.Name = "MskDT";
            MskDT.Size = new Size(296, 26);
            MskDT.TabIndex = 8;
            MskDT.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F);
            label3.Location = new Point(9, 125);
            label3.Name = "label3";
            label3.Size = new Size(99, 16);
            label3.TabIndex = 7;
            label3.Text = "DOĞUM TARİHİ:";
            // 
            // MskID
            // 
            MskID.Location = new Point(39, 69);
            MskID.Name = "MskID";
            MskID.Size = new Size(296, 26);
            MskID.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F);
            label2.Location = new Point(9, 74);
            label2.Name = "label2";
            label2.Size = new Size(24, 16);
            label2.TabIndex = 5;
            label2.Text = "ID:";
            // 
            // MskAD
            // 
            MskAD.Location = new Point(87, 23);
            MskAD.Name = "MskAD";
            MskAD.Size = new Size(296, 26);
            MskAD.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F);
            label1.Location = new Point(9, 28);
            label1.Name = "label1";
            label1.Size = new Size(72, 16);
            label1.TabIndex = 0;
            label1.Text = "AD SOYAD:";
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = Properties.Resources.istockphoto_1308634001_612x612;
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.ImageIndex = 4;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1411, 705);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "KİŞİ GÜNCELLE";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(496, 17);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(887, 612);
            dataGridView2.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources.istockphoto_1308634001_612x612;
            groupBox2.Controls.Add(BtnGUNCELLE);
            groupBox2.Controls.Add(MskTELG);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(MskDTG);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(MskIDG);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(MskADG);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(484, 623);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "KİŞİ BİLGİLERİ";
            // 
            // BtnGUNCELLE
            // 
            BtnGUNCELLE.Location = new Point(163, 255);
            BtnGUNCELLE.Name = "BtnGUNCELLE";
            BtnGUNCELLE.Size = new Size(178, 76);
            BtnGUNCELLE.TabIndex = 11;
            BtnGUNCELLE.Text = "GÜNCELLE";
            BtnGUNCELLE.UseVisualStyleBackColor = true;
            // >>> GÜNCELLE BUTONU OLAYI <<<
            BtnGUNCELLE.Click += BtnGUNCELLE_Click;
            // 
            // MskTELG
            // 
            MskTELG.Location = new Point(87, 170);
            MskTELG.Mask = "(999) 000-0000";
            MskTELG.Name = "MskTELG";
            MskTELG.Size = new Size(296, 26);
            MskTELG.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F);
            label5.Location = new Point(9, 175);
            label5.Name = "label5";
            label5.Size = new Size(64, 16);
            label5.TabIndex = 9;
            label5.Text = "TELEFON:";
            // 
            // MskDTG
            // 
            MskDTG.Location = new Point(114, 120);
            MskDTG.Mask = "00/00/0000";
            MskDTG.Name = "MskDTG";
            MskDTG.Size = new Size(296, 26);
            MskDTG.TabIndex = 8;
            MskDTG.ValidatingType = typeof(DateTime);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F);
            label6.Location = new Point(9, 125);
            label6.Name = "label6";
            label6.Size = new Size(99, 16);
            label6.TabIndex = 7;
            label6.Text = "DOĞUM TARİHİ:";
            // 
            // MskIDG
            // 
            MskIDG.Location = new Point(39, 69);
            MskIDG.Name = "MskIDG";
            MskIDG.Size = new Size(296, 26);
            MskIDG.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F);
            label7.Location = new Point(9, 74);
            label7.Name = "label7";
            label7.Size = new Size(24, 16);
            label7.TabIndex = 5;
            label7.Text = "ID:";
            // 
            // MskADG
            // 
            MskADG.Location = new Point(87, 23);
            MskADG.Name = "MskADG";
            MskADG.Size = new Size(296, 26);
            MskADG.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F);
            label8.Location = new Point(9, 28);
            label8.Name = "label8";
            label8.Size = new Size(72, 16);
            label8.TabIndex = 0;
            label8.Text = "AD SOYAD:";
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = Properties.Resources.istockphoto_1308634001_612x612;
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(groupBox3);
            tabPage3.ImageIndex = 6;
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1411, 705);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "KİŞİ SİL";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(496, 17);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(887, 612);
            dataGridView3.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImage = Properties.Resources.istockphoto_1308634001_612x612;
            groupBox3.Controls.Add(BtnSIL);
            groupBox3.Controls.Add(MskTELS);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(MskDTS);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(MskIDS);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(MskADS);
            groupBox3.Controls.Add(label12);
            groupBox3.Location = new Point(6, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(484, 623);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "KİŞİ BİLGİLERİ";
            // 
            // BtnSIL
            // 
            BtnSIL.Location = new Point(163, 255);
            BtnSIL.Name = "BtnSIL";
            BtnSIL.Size = new Size(178, 76);
            BtnSIL.TabIndex = 11;
            BtnSIL.Text = "SİL";
            BtnSIL.UseVisualStyleBackColor = true;
            // >>> SİL BUTONU OLAYI <<<
            BtnSIL.Click += BtnSIL_Click;
            // 
            // MskTELS
            // 
            MskTELS.Location = new Point(87, 170);
            MskTELS.Mask = "(999) 000-0000";
            MskTELS.Name = "MskTELS";
            MskTELS.Size = new Size(296, 26);
            MskTELS.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9.75F);
            label9.Location = new Point(9, 175);
            label9.Name = "label9";
            label9.Size = new Size(64, 16);
            label9.TabIndex = 9;
            label9.Text = "TELEFON:";
            // 
            // MskDTS
            // 
            MskDTS.Location = new Point(114, 120);
            MskDTS.Mask = "00/00/0000";
            MskDTS.Name = "MskDTS";
            MskDTS.Size = new Size(296, 26);
            MskDTS.TabIndex = 8;
            MskDTS.ValidatingType = typeof(DateTime);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 9.75F);
            label10.Location = new Point(9, 125);
            label10.Name = "label10";
            label10.Size = new Size(99, 16);
            label10.TabIndex = 7;
            label10.Text = "DOĞUM TARİHİ:";
            // 
            // MskIDS
            // 
            MskIDS.Location = new Point(39, 69);
            MskIDS.Name = "MskIDS";
            MskIDS.Size = new Size(296, 26);
            MskIDS.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 9.75F);
            label11.Location = new Point(9, 74);
            label11.Name = "label11";
            label11.Size = new Size(24, 16);
            label11.TabIndex = 5;
            label11.Text = "ID:";
            // 
            // MskADS
            // 
            MskADS.Location = new Point(87, 23);
            MskADS.Name = "MskADS";
            MskADS.Size = new Size(296, 26);
            MskADS.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 9.75F);
            label12.Location = new Point(9, 28);
            label12.Name = "label12";
            label12.Size = new Size(72, 16);
            label12.TabIndex = 0;
            label12.Text = "AD SOYAD:";
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "ana resim.png");
            ımageList1.Images.SetKeyName(1, "images.jpg");
            ımageList1.Images.SetKeyName(2, "218462180-the-enchanting-world-of-books-exploring-the-ar-3-2-library.jpg");
            ımageList1.Images.SetKeyName(3, "kişi ekleme.png");
            ımageList1.Images.SetKeyName(4, "KİŞİ GÜNCELLE.png");
            ımageList1.Images.SetKeyName(5, "kişi işlmeleri.png");
            ımageList1.Images.SetKeyName(6, "kişi silme.png");
            ımageList1.Images.SetKeyName(7, "kişi.png");
            ımageList1.Images.SetKeyName(8, "kişiler.png");
            ımageList1.Images.SetKeyName(9, "kitap ekleme.png");
            ımageList1.Images.SetKeyName(10, "kitap güncelleme.png");
            ımageList1.Images.SetKeyName(11, "kitap işlemleri.png");
            ımageList1.Images.SetKeyName(12, "kitap silme.png");
            ımageList1.Images.SetKeyName(13, "kitap verme.png");
            ımageList1.Images.SetKeyName(14, "kitaplar.jpg");
            ımageList1.Images.SetKeyName(15, "kitaplar.png");
            // 
            // FrmKisiIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._218462180_the_enchanting_world_of_books_exploring_the_ar_3_2_library;
            ClientSize = new Size(1376, 615);
            Controls.Add(tabControl1);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmKisiIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KİŞİ İŞLEMLERİ";
            Load += FrmKisiIslemleri_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ImageList ımageList1;
        private GroupBox groupBox1;
        private MaskedTextBox MskAD;
        private Label label1;
        private MaskedTextBox MskTEL;
        private Label label4;
        private MaskedTextBox MskDT;
        private Label label3;
        private MaskedTextBox MskID;
        private Label label2;
        private DataGridView dataGridView1;
        private Button BtnKAYDET;
        private DataGridView dataGridView2;
        private GroupBox groupBox2;
        private Button BtnGUNCELLE;
        private MaskedTextBox MskTELG;
        private Label label5;
        private MaskedTextBox MskDTG;
        private Label label6;
        private MaskedTextBox MskIDG;
        private Label label7;
        private MaskedTextBox MskADG;
        private Label label8;
        private DataGridView dataGridView3;
        private GroupBox groupBox3;
        private Button BtnSIL;
        private MaskedTextBox MskTELS;
        private Label label9;
        private MaskedTextBox MskDTS;
        private Label label10;
        private MaskedTextBox MskIDS;
        private Label label11;
        private MaskedTextBox MskADS;
        private Label label12;
    }
}

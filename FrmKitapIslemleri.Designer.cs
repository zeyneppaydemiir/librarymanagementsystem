namespace KutuphaneOtomasyonu
{
    partial class FrmKitapIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitapIslemleri));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            BtnEKLE = new Button();
            MskYAZARI = new MaskedTextBox();
            label4 = new Label();
            MskYAYINEVI = new MaskedTextBox();
            label3 = new Label();
            MskKONUSU = new MaskedTextBox();
            label2 = new Label();
            MskKitapAD = new MaskedTextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            groupBox2 = new GroupBox();
            BtnGUNCELLE = new Button();
            MskYAZARIG = new MaskedTextBox();
            label5 = new Label();
            MskYAYINEVIG = new MaskedTextBox();
            label6 = new Label();
            MskKONUSUG = new MaskedTextBox();
            label7 = new Label();
            MskKitapADG = new MaskedTextBox();
            label8 = new Label();
            tabPage3 = new TabPage();
            dataGridView3 = new DataGridView();
            groupBox3 = new GroupBox();
            BtnSIL = new Button();
            MskYAZARIS = new MaskedTextBox();
            label9 = new Label();
            MskYAYINEVIS = new MaskedTextBox();
            label10 = new Label();
            MskKONUSUS = new MaskedTextBox();
            label11 = new Label();
            MskKitapADS = new MaskedTextBox();
            label12 = new Label();
            ımageList2 = new ImageList(components);
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
            tabControl1.ImageList = ımageList2;
            tabControl1.Location = new Point(8, 8);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1511, 814);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = Properties.Resources.istockphoto_1308634001_612x612;
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.ImageIndex = 0;
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1503, 783);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kitap Ekle";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(532, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(915, 594);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.istockphoto_1308634001_612x612;
            groupBox1.Controls.Add(BtnEKLE);
            groupBox1.Controls.Add(MskYAZARI);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(MskYAYINEVI);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(MskKONUSU);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(MskKitapAD);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 605);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "KİTAP BİLGİLERİ";
            // 
            // BtnEKLE
            // 
            BtnEKLE.Location = new Point(144, 304);
            BtnEKLE.Name = "BtnEKLE";
            BtnEKLE.Size = new Size(200, 89);
            BtnEKLE.TabIndex = 8;
            BtnEKLE.Text = "EKLE";
            BtnEKLE.UseVisualStyleBackColor = true;
            BtnEKLE.Click += BtnEKLE_Click;
            // 
            // MskYAZARI
            // 
            MskYAZARI.Location = new Point(92, 189);
            MskYAZARI.Name = "MskYAZARI";
            MskYAZARI.Size = new Size(295, 26);
            MskYAZARI.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 192);
            label4.Name = "label4";
            label4.Size = new Size(64, 18);
            label4.TabIndex = 6;
            label4.Text = "YAZARI:";
            // 
            // MskYAYINEVI
            // 
            MskYAYINEVI.Location = new Point(110, 141);
            MskYAYINEVI.Name = "MskYAYINEVI";
            MskYAYINEVI.Size = new Size(277, 26);
            MskYAYINEVI.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 141);
            label3.Name = "label3";
            label3.Size = new Size(81, 18);
            label3.TabIndex = 4;
            label3.Text = "YAYINEVİ:";
            // 
            // MskKONUSU
            // 
            MskKONUSU.Location = new Point(130, 87);
            MskKONUSU.Name = "MskKONUSU";
            MskKONUSU.Size = new Size(257, 26);
            MskKONUSU.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 90);
            label2.Name = "label2";
            label2.Size = new Size(118, 18);
            label2.TabIndex = 2;
            label2.Text = "KİTAP KONUSU:";
            // 
            // MskKitapAD
            // 
            MskKitapAD.Location = new Point(110, 43);
            MskKitapAD.Name = "MskKitapAD";
            MskKitapAD.Size = new Size(277, 26);
            MskKitapAD.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(85, 18);
            label1.TabIndex = 0;
            label1.Text = "KİTAP ADI:";
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = Properties.Resources.istockphoto_1308634001_612x612;
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.ImageIndex = 1;
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1503, 783);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kitap Güncelle";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(532, 14);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(915, 594);
            dataGridView2.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources.istockphoto_1308634001_612x612;
            groupBox2.Controls.Add(BtnGUNCELLE);
            groupBox2.Controls.Add(MskYAZARIG);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(MskYAYINEVIG);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(MskKONUSUG);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(MskKitapADG);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(523, 605);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "KİTAP BİLGİLERİ";
            // 
            // BtnGUNCELLE
            // 
            BtnGUNCELLE.Location = new Point(144, 304);
            BtnGUNCELLE.Name = "BtnGUNCELLE";
            BtnGUNCELLE.Size = new Size(200, 89);
            BtnGUNCELLE.TabIndex = 8;
            BtnGUNCELLE.Text = "GÜNCELLE";
            BtnGUNCELLE.UseVisualStyleBackColor = true;
            BtnGUNCELLE.Click += BtnGUNCELLE_Click;
            // 
            // MskYAZARIG
            // 
            MskYAZARIG.Location = new Point(92, 189);
            MskYAZARIG.Name = "MskYAZARIG";
            MskYAZARIG.Size = new Size(295, 26);
            MskYAZARIG.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 192);
            label5.Name = "label5";
            label5.Size = new Size(64, 18);
            label5.TabIndex = 6;
            label5.Text = "YAZARI:";
            // 
            // MskYAYINEVIG
            // 
            MskYAYINEVIG.Location = new Point(110, 141);
            MskYAYINEVIG.Name = "MskYAYINEVIG";
            MskYAYINEVIG.Size = new Size(277, 26);
            MskYAYINEVIG.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 141);
            label6.Name = "label6";
            label6.Size = new Size(81, 18);
            label6.TabIndex = 4;
            label6.Text = "YAYINEVİ:";
            // 
            // MskKONUSUG
            // 
            MskKONUSUG.Location = new Point(130, 87);
            MskKONUSUG.Name = "MskKONUSUG";
            MskKONUSUG.Size = new Size(257, 26);
            MskKONUSUG.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 90);
            label7.Name = "label7";
            label7.Size = new Size(118, 18);
            label7.TabIndex = 2;
            label7.Text = "KİTAP KONUSU:";
            // 
            // MskKitapADG
            // 
            MskKitapADG.Location = new Point(110, 43);
            MskKitapADG.Name = "MskKitapADG";
            MskKitapADG.Size = new Size(277, 26);
            MskKitapADG.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 43);
            label8.Name = "label8";
            label8.Size = new Size(85, 18);
            label8.TabIndex = 0;
            label8.Text = "KİTAP ADI:";
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = Properties.Resources.istockphoto_1308634001_612x612;
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(groupBox3);
            tabPage3.ImageIndex = 3;
            tabPage3.Location = new Point(4, 27);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1503, 783);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Kitap Sil";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(532, 14);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(915, 594);
            dataGridView3.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImage = Properties.Resources.istockphoto_1308634001_612x612;
            groupBox3.Controls.Add(BtnSIL);
            groupBox3.Controls.Add(MskYAZARIS);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(MskYAYINEVIS);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(MskKONUSUS);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(MskKitapADS);
            groupBox3.Controls.Add(label12);
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(523, 605);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "KİTAP BİLGİLERİ";
            // 
            // BtnSIL
            // 
            BtnSIL.Location = new Point(144, 304);
            BtnSIL.Name = "BtnSIL";
            BtnSIL.Size = new Size(200, 89);
            BtnSIL.TabIndex = 8;
            BtnSIL.Text = "SİL";
            BtnSIL.UseVisualStyleBackColor = true;
            BtnSIL.Click += BtnSIL_Click;
            // 
            // MskYAZARIS
            // 
            MskYAZARIS.Location = new Point(92, 189);
            MskYAZARIS.Name = "MskYAZARIS";
            MskYAZARIS.Size = new Size(295, 26);
            MskYAZARIS.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 192);
            label9.Name = "label9";
            label9.Size = new Size(64, 18);
            label9.TabIndex = 6;
            label9.Text = "YAZARI:";
            // 
            // MskYAYINEVIS
            // 
            MskYAYINEVIS.Location = new Point(110, 141);
            MskYAYINEVIS.Name = "MskYAYINEVIS";
            MskYAYINEVIS.Size = new Size(277, 26);
            MskYAYINEVIS.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 141);
            label10.Name = "label10";
            label10.Size = new Size(81, 18);
            label10.TabIndex = 4;
            label10.Text = "YAYINEVİ:";
            // 
            // MskKONUSUS
            // 
            MskKONUSUS.Location = new Point(130, 87);
            MskKONUSUS.Name = "MskKONUSUS";
            MskKONUSUS.Size = new Size(257, 26);
            MskKONUSUS.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 90);
            label11.Name = "label11";
            label11.Size = new Size(118, 18);
            label11.TabIndex = 2;
            label11.Text = "KİTAP KONUSU:";
            // 
            // MskKitapADS
            // 
            MskKitapADS.Location = new Point(110, 43);
            MskKitapADS.Name = "MskKitapADS";
            MskKitapADS.Size = new Size(277, 26);
            MskKitapADS.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 43);
            label12.Name = "label12";
            label12.Size = new Size(85, 18);
            label12.TabIndex = 0;
            label12.Text = "KİTAP ADI:";
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth32Bit;
            ımageList2.ImageStream = (ImageListStreamer)resources.GetObject("ımageList2.ImageStream");
            ımageList2.TransparentColor = Color.Transparent;
            ımageList2.Images.SetKeyName(0, "kitap ekleme.png");
            ımageList2.Images.SetKeyName(1, "kitap güncelleme.png");
            ımageList2.Images.SetKeyName(2, "kitap işlemleri.png");
            ımageList2.Images.SetKeyName(3, "kitap silme.png");
            // 
            // FrmKitapIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._218462180_the_enchanting_world_of_books_exploring_the_ar_3_2_library;
            ClientSize = new Size(1666, 884);
            Controls.Add(tabControl1);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmKitapIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KİTAP İŞLEMLERİ";
            Load += FrmKitapIslemleri_Load;
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
        private ImageList ımageList2;
        private GroupBox groupBox1;
        private Button BtnEKLE;
        private MaskedTextBox MskYAZARI;
        private Label label4;
        private MaskedTextBox MskYAYINEVI;
        private Label label3;
        private MaskedTextBox MskKONUSU;
        private Label label2;
        private MaskedTextBox MskKitapAD;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private GroupBox groupBox2;
        private Button BtnGUNCELLE;
        private MaskedTextBox MskYAZARIG;
        private Label label5;
        private MaskedTextBox MskYAYINEVIG;
        private Label label6;
        private MaskedTextBox MskKONUSUG;
        private Label label7;
        private MaskedTextBox MskKitapADG;
        private Label label8;
        private DataGridView dataGridView3;
        private GroupBox groupBox3;
        private Button BtnSIL;
        private MaskedTextBox MskYAZARIS;
        private Label label9;
        private MaskedTextBox MskYAYINEVIS;
        private Label label10;
        private MaskedTextBox MskKONUSUS;
        private Label label11;
        private MaskedTextBox MskKitapADS;
        private Label label12;
    }
}
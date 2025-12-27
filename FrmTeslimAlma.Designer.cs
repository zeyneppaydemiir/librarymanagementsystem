namespace KutuphaneOtomasyonu
{
    partial class FrmTeslimAlma
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
            dataGridView1 = new DataGridView();
            txtKisiID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtKitapID = new TextBox();
            btnTeslimEt = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(334, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1087, 686);
            dataGridView1.TabIndex = 1;
            // 
            // txtKisiID
            // 
            txtKisiID.Location = new Point(126, 32);
            txtKisiID.Name = "txtKisiID";
            txtKisiID.Size = new Size(100, 26);
            txtKisiID.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 35);
            label1.Name = "label1";
            label1.Size = new Size(63, 18);
            label1.TabIndex = 3;
            label1.Text = "KİŞİ ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 99);
            label2.Name = "label2";
            label2.Size = new Size(76, 18);
            label2.TabIndex = 5;
            label2.Text = "KİTAP ID:";
            // 
            // txtKitapID
            // 
            txtKitapID.Location = new Point(126, 96);
            txtKitapID.Name = "txtKitapID";
            txtKitapID.Size = new Size(100, 26);
            txtKitapID.TabIndex = 4;
            // 
            // btnTeslimEt
            // 
            btnTeslimEt.Location = new Point(59, 186);
            btnTeslimEt.Name = "btnTeslimEt";
            btnTeslimEt.Size = new Size(157, 86);
            btnTeslimEt.TabIndex = 6;
            btnTeslimEt.Text = "TESLİM ET";
            btnTeslimEt.UseVisualStyleBackColor = true;
            btnTeslimEt.Click += btnTeslimEt_Click;
            // 
            // FrmTeslimAlma
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 870);
            Controls.Add(btnTeslimEt);
            Controls.Add(label2);
            Controls.Add(txtKitapID);
            Controls.Add(label1);
            Controls.Add(txtKisiID);
            Controls.Add(dataGridView1);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmTeslimAlma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TESLİM  ETME";
            Load += FrmTeslimAlma_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtKisiID;
        private Label label1;
        private Label label2;
        private TextBox txtKitapID;
        private Button btnTeslimEt;
    }
}
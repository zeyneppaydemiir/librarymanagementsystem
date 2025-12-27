namespace KutuphaneOtomasyonu
{
    partial class FrmTeslimEt
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
            dgvEmanetler = new DataGridView();
            label1 = new Label();
            txtEmanetID = new TextBox();
            btnTeslimAl = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmanetler).BeginInit();
            SuspendLayout();
            // 
            // dgvEmanetler
            // 
            dgvEmanetler.BackgroundColor = SystemColors.InactiveCaption;
            dgvEmanetler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmanetler.Location = new Point(255, 39);
            dgvEmanetler.Name = "dgvEmanetler";
            dgvEmanetler.Size = new Size(1087, 686);
            dgvEmanetler.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 56);
            label1.Name = "label1";
            label1.Size = new Size(91, 18);
            label1.TabIndex = 1;
            label1.Text = "EMANET ID:";
            // 
            // txtEmanetID
            // 
            txtEmanetID.Location = new Point(124, 53);
            txtEmanetID.Name = "txtEmanetID";
            txtEmanetID.Size = new Size(100, 26);
            txtEmanetID.TabIndex = 2;
            // 
            // btnTeslimAl
            // 
            btnTeslimAl.Location = new Point(31, 119);
            btnTeslimAl.Name = "btnTeslimAl";
            btnTeslimAl.Size = new Size(142, 121);
            btnTeslimAl.TabIndex = 3;
            btnTeslimAl.Text = "TESLİM AL";
            btnTeslimAl.UseVisualStyleBackColor = true;
            // 
            // FrmTeslimEt
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 870);
            Controls.Add(btnTeslimAl);
            Controls.Add(txtEmanetID);
            Controls.Add(label1);
            Controls.Add(dgvEmanetler);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmTeslimEt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TESLİM ALMA";
            Load += FrmTeslimEt_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmanetler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmanetler;
        private Label label1;
        private TextBox txtEmanetID;
        private Button btnTeslimAl;
    }
}
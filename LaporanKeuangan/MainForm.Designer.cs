namespace LaporanKeuangan
{
    partial class MainForm
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
            this.InputPanel = new System.Windows.Forms.Panel();
            this.TransaksiBaruGroup = new System.Windows.Forms.GroupBox();
            this.TambahButton = new System.Windows.Forms.Button();
            this.KeteranganTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.JumlahNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.KreditRadio = new System.Windows.Forms.RadioButton();
            this.DebetRadio = new System.Windows.Forms.RadioButton();
            this.KodeAkunCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TanggalPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.InputGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TransaksiComboBox = new System.Windows.Forms.ComboBox();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trialBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InputPanel.SuspendLayout();
            this.TransaksiBaruGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JumlahNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputGridView)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputPanel
            // 
            this.InputPanel.AutoSize = true;
            this.InputPanel.Controls.Add(this.TransaksiBaruGroup);
            this.InputPanel.Controls.Add(this.InputGridView);
            this.InputPanel.Controls.Add(this.label1);
            this.InputPanel.Controls.Add(this.TransaksiComboBox);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputPanel.Location = new System.Drawing.Point(0, 0);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(686, 559);
            this.InputPanel.TabIndex = 1;
            this.InputPanel.Visible = false;
            // 
            // TransaksiBaruGroup
            // 
            this.TransaksiBaruGroup.Controls.Add(this.TambahButton);
            this.TransaksiBaruGroup.Controls.Add(this.KeteranganTextBox);
            this.TransaksiBaruGroup.Controls.Add(this.label5);
            this.TransaksiBaruGroup.Controls.Add(this.JumlahNumeric);
            this.TransaksiBaruGroup.Controls.Add(this.label4);
            this.TransaksiBaruGroup.Controls.Add(this.KreditRadio);
            this.TransaksiBaruGroup.Controls.Add(this.DebetRadio);
            this.TransaksiBaruGroup.Controls.Add(this.KodeAkunCombo);
            this.TransaksiBaruGroup.Controls.Add(this.label3);
            this.TransaksiBaruGroup.Controls.Add(this.TanggalPicker);
            this.TransaksiBaruGroup.Controls.Add(this.label2);
            this.TransaksiBaruGroup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransaksiBaruGroup.Location = new System.Drawing.Point(16, 271);
            this.TransaksiBaruGroup.Name = "TransaksiBaruGroup";
            this.TransaksiBaruGroup.Size = new System.Drawing.Size(651, 281);
            this.TransaksiBaruGroup.TabIndex = 4;
            this.TransaksiBaruGroup.TabStop = false;
            this.TransaksiBaruGroup.Text = "Transaksi Baru";
            // 
            // TambahButton
            // 
            this.TambahButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TambahButton.Location = new System.Drawing.Point(3, 232);
            this.TambahButton.Name = "TambahButton";
            this.TambahButton.Size = new System.Drawing.Size(645, 46);
            this.TambahButton.TabIndex = 16;
            this.TambahButton.Text = "Tambah Transaksi";
            this.TambahButton.UseVisualStyleBackColor = true;
            // 
            // KeteranganTextBox
            // 
            this.KeteranganTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeteranganTextBox.Location = new System.Drawing.Point(117, 188);
            this.KeteranganTextBox.Name = "KeteranganTextBox";
            this.KeteranganTextBox.Size = new System.Drawing.Size(528, 26);
            this.KeteranganTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Keterangan";
            // 
            // JumlahNumeric
            // 
            this.JumlahNumeric.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JumlahNumeric.Location = new System.Drawing.Point(117, 142);
            this.JumlahNumeric.Name = "JumlahNumeric";
            this.JumlahNumeric.Size = new System.Drawing.Size(204, 26);
            this.JumlahNumeric.TabIndex = 13;
            this.JumlahNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.JumlahNumeric.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Jumlah";
            // 
            // KreditRadio
            // 
            this.KreditRadio.AutoSize = true;
            this.KreditRadio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KreditRadio.Location = new System.Drawing.Point(101, 111);
            this.KreditRadio.Name = "KreditRadio";
            this.KreditRadio.Size = new System.Drawing.Size(68, 22);
            this.KreditRadio.TabIndex = 10;
            this.KreditRadio.Text = "Kredit";
            this.KreditRadio.UseVisualStyleBackColor = true;
            // 
            // DebetRadio
            // 
            this.DebetRadio.AutoSize = true;
            this.DebetRadio.Checked = true;
            this.DebetRadio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebetRadio.Location = new System.Drawing.Point(9, 111);
            this.DebetRadio.Name = "DebetRadio";
            this.DebetRadio.Size = new System.Drawing.Size(69, 22);
            this.DebetRadio.TabIndex = 9;
            this.DebetRadio.TabStop = true;
            this.DebetRadio.Text = "Debet";
            this.DebetRadio.UseVisualStyleBackColor = true;
            // 
            // KodeAkunCombo
            // 
            this.KodeAkunCombo.FormattingEnabled = true;
            this.KodeAkunCombo.Location = new System.Drawing.Point(117, 74);
            this.KodeAkunCombo.Name = "KodeAkunCombo";
            this.KodeAkunCombo.Size = new System.Drawing.Size(271, 27);
            this.KodeAkunCombo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kode Akun";
            // 
            // TanggalPicker
            // 
            this.TanggalPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TanggalPicker.Location = new System.Drawing.Point(117, 35);
            this.TanggalPicker.Name = "TanggalPicker";
            this.TanggalPicker.Size = new System.Drawing.Size(157, 26);
            this.TanggalPicker.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tanggal";
            // 
            // InputGridView
            // 
            this.InputGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputGridView.Location = new System.Drawing.Point(15, 88);
            this.InputGridView.Name = "InputGridView";
            this.InputGridView.ReadOnly = true;
            this.InputGridView.Size = new System.Drawing.Size(652, 164);
            this.InputGridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transaksi";
            // 
            // TransaksiComboBox
            // 
            this.TransaksiComboBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransaksiComboBox.FormattingEnabled = true;
            this.TransaksiComboBox.Location = new System.Drawing.Point(103, 39);
            this.TransaksiComboBox.Name = "TransaksiComboBox";
            this.TransaksiComboBox.Size = new System.Drawing.Size(156, 30);
            this.TransaksiComboBox.TabIndex = 1;
            this.TransaksiComboBox.SelectedIndexChanged += new System.EventHandler(this.TransaksiComboBox_SelectedIndexChanged);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem,
            this.outputToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(686, 24);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "menuStrip1";
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputDataToolStripMenuItem});
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.inputToolStripMenuItem.Text = "Input";
            // 
            // inputDataToolStripMenuItem
            // 
            this.inputDataToolStripMenuItem.Name = "inputDataToolStripMenuItem";
            this.inputDataToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.inputDataToolStripMenuItem.Text = "Input Data";
            this.inputDataToolStripMenuItem.Click += new System.EventHandler(this.inputDataToolStripMenuItem_Click);
            // 
            // outputToolStripMenuItem
            // 
            this.outputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trialBalanceToolStripMenuItem});
            this.outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            this.outputToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.outputToolStripMenuItem.Text = "Output";
            // 
            // trialBalanceToolStripMenuItem
            // 
            this.trialBalanceToolStripMenuItem.Name = "trialBalanceToolStripMenuItem";
            this.trialBalanceToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.trialBalanceToolStripMenuItem.Text = "Trial Balance";
            this.trialBalanceToolStripMenuItem.Click += new System.EventHandler(this.trialBalanceToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 559);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.InputPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Keuangan";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.TransaksiBaruGroup.ResumeLayout(false);
            this.TransaksiBaruGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JumlahNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputGridView)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.GroupBox TransaksiBaruGroup;
        private System.Windows.Forms.Button TambahButton;
        private System.Windows.Forms.TextBox KeteranganTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown JumlahNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton KreditRadio;
        private System.Windows.Forms.RadioButton DebetRadio;
        private System.Windows.Forms.ComboBox KodeAkunCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker TanggalPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView InputGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TransaksiComboBox;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trialBalanceToolStripMenuItem;
    }
}


namespace WindowsFormsApp1
{
    partial class formica
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDKlijentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imePrezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankaDataSet = new WindowsFormsApp1.BankaDataSet();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klijentTableAdapter = new WindowsFormsApp1.BankaDataSetTableAdapters.KlijentTableAdapter();
            this.racunTableAdapter = new WindowsFormsApp1.BankaDataSetTableAdapters.RacunTableAdapter();
            this.grBoxKlijenti = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.boxStanjeVeceOD = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.klijentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grBoxObrada = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.obradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxBrojOtvorenihRacuna = new System.Windows.Forms.TextBox();
            this.boxNajviseSredstva = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grboxRacun = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.karticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klijentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            this.grBoxKlijenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource1)).BeginInit();
            this.grBoxObrada.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.grboxRacun.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKlijentDataGridViewTextBoxColumn,
            this.imePrezimeDataGridViewTextBoxColumn,
            this.stanjeDataGridViewTextBoxColumn,
            this.racunDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.klijentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(58, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(628, 288);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDKlijentDataGridViewTextBoxColumn
            // 
            this.iDKlijentDataGridViewTextBoxColumn.DataPropertyName = "IDKlijent";
            this.iDKlijentDataGridViewTextBoxColumn.HeaderText = "IDKlijent";
            this.iDKlijentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDKlijentDataGridViewTextBoxColumn.Name = "iDKlijentDataGridViewTextBoxColumn";
            this.iDKlijentDataGridViewTextBoxColumn.Width = 125;
            // 
            // imePrezimeDataGridViewTextBoxColumn
            // 
            this.imePrezimeDataGridViewTextBoxColumn.DataPropertyName = "ImePrezime";
            this.imePrezimeDataGridViewTextBoxColumn.HeaderText = "ImePrezime";
            this.imePrezimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imePrezimeDataGridViewTextBoxColumn.Name = "imePrezimeDataGridViewTextBoxColumn";
            this.imePrezimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // stanjeDataGridViewTextBoxColumn
            // 
            this.stanjeDataGridViewTextBoxColumn.DataPropertyName = "Stanje";
            this.stanjeDataGridViewTextBoxColumn.HeaderText = "Stanje";
            this.stanjeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stanjeDataGridViewTextBoxColumn.Name = "stanjeDataGridViewTextBoxColumn";
            this.stanjeDataGridViewTextBoxColumn.Width = 125;
            // 
            // racunDataGridViewTextBoxColumn
            // 
            this.racunDataGridViewTextBoxColumn.DataPropertyName = "Racun";
            this.racunDataGridViewTextBoxColumn.DataSource = this.racunBindingSource;
            this.racunDataGridViewTextBoxColumn.DisplayMember = "Tip";
            this.racunDataGridViewTextBoxColumn.HeaderText = "Racun";
            this.racunDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.racunDataGridViewTextBoxColumn.Name = "racunDataGridViewTextBoxColumn";
            this.racunDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.racunDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.racunDataGridViewTextBoxColumn.ValueMember = "IDRacun";
            this.racunDataGridViewTextBoxColumn.Width = 125;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "Racun";
            this.racunBindingSource.DataSource = this.bankaDataSet;
            // 
            // bankaDataSet
            // 
            this.bankaDataSet.DataSetName = "BankaDataSet";
            this.bankaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataMember = "Klijent";
            this.klijentBindingSource.DataSource = this.bankaDataSet;
            // 
            // klijentTableAdapter
            // 
            this.klijentTableAdapter.ClearBeforeFill = true;
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
            // 
            // grBoxKlijenti
            // 
            this.grBoxKlijenti.Controls.Add(this.label3);
            this.grBoxKlijenti.Controls.Add(this.label2);
            this.grBoxKlijenti.Controls.Add(this.label1);
            this.grBoxKlijenti.Controls.Add(this.button1);
            this.grBoxKlijenti.Controls.Add(this.boxStanjeVeceOD);
            this.grBoxKlijenti.Controls.Add(this.listBox1);
            this.grBoxKlijenti.Controls.Add(this.comboBox1);
            this.grBoxKlijenti.Enabled = false;
            this.grBoxKlijenti.Location = new System.Drawing.Point(86, 348);
            this.grBoxKlijenti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grBoxKlijenti.Name = "grBoxKlijenti";
            this.grBoxKlijenti.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grBoxKlijenti.Size = new System.Drawing.Size(599, 192);
            this.grBoxKlijenti.TabIndex = 1;
            this.grBoxKlijenti.TabStop = false;
            this.grBoxKlijenti.Text = "Klijenti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prikaz podataka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ime i prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = " Stanje na racunu vece od";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 124);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pretrazi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxStanjeVeceOD
            // 
            this.boxStanjeVeceOD.Location = new System.Drawing.Point(440, 79);
            this.boxStanjeVeceOD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxStanjeVeceOD.Name = "boxStanjeVeceOD";
            this.boxStanjeVeceOD.Size = new System.Drawing.Size(76, 20);
            this.boxStanjeVeceOD.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(171, 44);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(224, 108);
            this.listBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(46, 61);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // klijentBindingSource1
            // 
            this.klijentBindingSource1.DataMember = "Klijent";
            this.klijentBindingSource1.DataSource = this.bankaDataSet;
            // 
            // grBoxObrada
            // 
            this.grBoxObrada.ContextMenuStrip = this.contextMenuStrip1;
            this.grBoxObrada.Controls.Add(this.boxBrojOtvorenihRacuna);
            this.grBoxObrada.Controls.Add(this.boxNajviseSredstva);
            this.grBoxObrada.Controls.Add(this.label5);
            this.grBoxObrada.Controls.Add(this.label4);
            this.grBoxObrada.Controls.Add(this.grboxRacun);
            this.grBoxObrada.Location = new System.Drawing.Point(746, 168);
            this.grBoxObrada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grBoxObrada.Name = "grBoxObrada";
            this.grBoxObrada.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grBoxObrada.Size = new System.Drawing.Size(313, 331);
            this.grBoxObrada.TabIndex = 2;
            this.grBoxObrada.TabStop = false;
            this.grBoxObrada.Text = "Obrada";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obradaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 26);
            // 
            // obradaToolStripMenuItem
            // 
            this.obradaToolStripMenuItem.Name = "obradaToolStripMenuItem";
            this.obradaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.obradaToolStripMenuItem.Text = "Obrada";
            this.obradaToolStripMenuItem.Click += new System.EventHandler(this.obradaToolStripMenuItem_Click);
            // 
            // boxBrojOtvorenihRacuna
            // 
            this.boxBrojOtvorenihRacuna.Location = new System.Drawing.Point(179, 258);
            this.boxBrojOtvorenihRacuna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxBrojOtvorenihRacuna.Name = "boxBrojOtvorenihRacuna";
            this.boxBrojOtvorenihRacuna.Size = new System.Drawing.Size(76, 20);
            this.boxBrojOtvorenihRacuna.TabIndex = 9;
            // 
            // boxNajviseSredstva
            // 
            this.boxNajviseSredstva.Location = new System.Drawing.Point(172, 203);
            this.boxNajviseSredstva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxNajviseSredstva.Name = "boxNajviseSredstva";
            this.boxNajviseSredstva.Size = new System.Drawing.Size(76, 20);
            this.boxNajviseSredstva.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Broj otvorenih racuna";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Racun sa najvise sredstava";
            // 
            // grboxRacun
            // 
            this.grboxRacun.Controls.Add(this.radioButton4);
            this.grboxRacun.Controls.Add(this.radioButton3);
            this.grboxRacun.Controls.Add(this.radioButton2);
            this.grboxRacun.Controls.Add(this.radioButton1);
            this.grboxRacun.Enabled = false;
            this.grboxRacun.Location = new System.Drawing.Point(21, 34);
            this.grboxRacun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grboxRacun.Name = "grboxRacun";
            this.grboxRacun.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grboxRacun.Size = new System.Drawing.Size(264, 137);
            this.grboxRacun.TabIndex = 0;
            this.grboxRacun.TabStop = false;
            this.grboxRacun.Text = "Racun";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(129, 81);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(60, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Devizni";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(34, 81);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(63, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Dinarski";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(129, 37);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nenamenski";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(34, 37);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Namenski";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.karticaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1098, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // karticaToolStripMenuItem
            // 
            this.karticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klijentToolStripMenuItem});
            this.karticaToolStripMenuItem.Name = "karticaToolStripMenuItem";
            this.karticaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.karticaToolStripMenuItem.Text = "Kartica";
            // 
            // klijentToolStripMenuItem
            // 
            this.klijentToolStripMenuItem.Name = "klijentToolStripMenuItem";
            this.klijentToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.klijentToolStripMenuItem.Text = "Klijent";
            this.klijentToolStripMenuItem.Click += new System.EventHandler(this.klijentToolStripMenuItem_Click);
            // 
            // formica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 549);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grBoxObrada);
            this.Controls.Add(this.grBoxKlijenti);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formica";
            this.Text = "Banka";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            this.grBoxKlijenti.ResumeLayout(false);
            this.grBoxKlijenti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource1)).EndInit();
            this.grBoxObrada.ResumeLayout(false);
            this.grBoxObrada.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.grboxRacun.ResumeLayout(false);
            this.grboxRacun.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BankaDataSet bankaDataSet;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private BankaDataSetTableAdapters.KlijentTableAdapter klijentTableAdapter;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private BankaDataSetTableAdapters.RacunTableAdapter racunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKlijentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn racunDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox grBoxKlijenti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox boxStanjeVeceOD;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource klijentBindingSource1;
        private System.Windows.Forms.GroupBox grBoxObrada;
        private System.Windows.Forms.TextBox boxBrojOtvorenihRacuna;
        private System.Windows.Forms.TextBox boxNajviseSredstva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grboxRacun;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem obradaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem karticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klijentToolStripMenuItem;
    }
}


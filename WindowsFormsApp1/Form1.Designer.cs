namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayıtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personel_KayıtDataSet = new WindowsFormsApp1.Personel_KayıtDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_ad = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_soyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_maas = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_meslek = new Guna.UI2.WinForms.Guna2TextBox();
            this.radioevli = new Guna.UI2.WinForms.Guna2RadioButton();
            this.bekar = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txt_sehir = new System.Windows.Forms.ComboBox();
            this.kayıtTableAdapter = new WindowsFormsApp1.Personel_KayıtDataSetTableAdapters.kayıtTableAdapter();
            this.btn_sil = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_güncelle = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Temizle = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_istatistik = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Grafik = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_kaydet = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_ogrenciara = new Guna.UI2.WinForms.Guna2GradientButton();
            this.sayfa3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Grafik = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_KayıtDataSet)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.Grafik.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Controls.Add(this.dataGridView1);
            this.guna2GroupBox3.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Location = new System.Drawing.Point(0, 393);
            this.guna2GroupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(874, 248);
            this.guna2GroupBox3.TabIndex = 3;
            this.guna2GroupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIdDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewTextBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kayıtBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(874, 208);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // perIdDataGridViewTextBoxColumn
            // 
            this.perIdDataGridViewTextBoxColumn.DataPropertyName = "PerId";
            this.perIdDataGridViewTextBoxColumn.HeaderText = "PerId";
            this.perIdDataGridViewTextBoxColumn.Name = "perIdDataGridViewTextBoxColumn";
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            // 
            // perDurumDataGridViewTextBoxColumn
            // 
            this.perDurumDataGridViewTextBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewTextBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewTextBoxColumn.Name = "perDurumDataGridViewTextBoxColumn";
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            // 
            // kayıtBindingSource
            // 
            this.kayıtBindingSource.DataMember = "kayıt";
            this.kayıtBindingSource.DataSource = this.personel_KayıtDataSet;
            // 
            // personel_KayıtDataSet
            // 
            this.personel_KayıtDataSet.DataSetName = "Personel_KayıtDataSet";
            this.personel_KayıtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(96, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İd:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(90, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(70, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Medeni hal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(70, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Maas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(70, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Şehir";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(63, 279);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Meslek:";
            // 
            // txt_id
            // 
            this.txt_id.BorderColor = System.Drawing.Color.Black;
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.DefaultText = "";
            this.txt_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_id.ForeColor = System.Drawing.Color.Black;
            this.txt_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.Location = new System.Drawing.Point(142, 63);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_id.PlaceholderText = "";
            this.txt_id.SelectedText = "";
            this.txt_id.Size = new System.Drawing.Size(121, 23);
            this.txt_id.TabIndex = 7;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // txt_ad
            // 
            this.txt_ad.BorderColor = System.Drawing.Color.Black;
            this.txt_ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ad.DefaultText = "";
            this.txt_ad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ad.ForeColor = System.Drawing.Color.Black;
            this.txt_ad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ad.Location = new System.Drawing.Point(142, 99);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.PasswordChar = '\0';
            this.txt_ad.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_ad.PlaceholderText = "";
            this.txt_ad.SelectedText = "";
            this.txt_ad.Size = new System.Drawing.Size(120, 23);
            this.txt_ad.TabIndex = 8;
            // 
            // txt_soyad
            // 
            this.txt_soyad.BorderColor = System.Drawing.Color.Black;
            this.txt_soyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_soyad.DefaultText = "";
            this.txt_soyad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_soyad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_soyad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_soyad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_soyad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_soyad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_soyad.ForeColor = System.Drawing.Color.Black;
            this.txt_soyad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_soyad.Location = new System.Drawing.Point(141, 136);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.PasswordChar = '\0';
            this.txt_soyad.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_soyad.PlaceholderText = "";
            this.txt_soyad.SelectedText = "";
            this.txt_soyad.Size = new System.Drawing.Size(120, 23);
            this.txt_soyad.TabIndex = 9;
            // 
            // txt_maas
            // 
            this.txt_maas.BorderColor = System.Drawing.Color.Black;
            this.txt_maas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_maas.DefaultText = "";
            this.txt_maas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_maas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_maas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_maas.ForeColor = System.Drawing.Color.Black;
            this.txt_maas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maas.Location = new System.Drawing.Point(142, 204);
            this.txt_maas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_maas.Name = "txt_maas";
            this.txt_maas.PasswordChar = '\0';
            this.txt_maas.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_maas.PlaceholderText = "";
            this.txt_maas.SelectedText = "";
            this.txt_maas.Size = new System.Drawing.Size(120, 23);
            this.txt_maas.TabIndex = 10;
            // 
            // txt_meslek
            // 
            this.txt_meslek.BorderColor = System.Drawing.Color.Black;
            this.txt_meslek.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_meslek.DefaultText = "";
            this.txt_meslek.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_meslek.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_meslek.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_meslek.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_meslek.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_meslek.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_meslek.ForeColor = System.Drawing.Color.Black;
            this.txt_meslek.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_meslek.Location = new System.Drawing.Point(142, 279);
            this.txt_meslek.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_meslek.Name = "txt_meslek";
            this.txt_meslek.PasswordChar = '\0';
            this.txt_meslek.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_meslek.PlaceholderText = "";
            this.txt_meslek.SelectedText = "";
            this.txt_meslek.Size = new System.Drawing.Size(120, 23);
            this.txt_meslek.TabIndex = 12;
            // 
            // radioevli
            // 
            this.radioevli.AutoSize = true;
            this.radioevli.BackColor = System.Drawing.Color.Transparent;
            this.radioevli.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioevli.CheckedState.BorderThickness = 0;
            this.radioevli.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioevli.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioevli.CheckedState.InnerOffset = -4;
            this.radioevli.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.radioevli.ForeColor = System.Drawing.Color.Black;
            this.radioevli.Location = new System.Drawing.Point(142, 171);
            this.radioevli.Margin = new System.Windows.Forms.Padding(2);
            this.radioevli.Name = "radioevli";
            this.radioevli.Size = new System.Drawing.Size(51, 24);
            this.radioevli.TabIndex = 13;
            this.radioevli.Text = "Evli";
            this.radioevli.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioevli.UncheckedState.BorderThickness = 2;
            this.radioevli.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioevli.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioevli.UseVisualStyleBackColor = false;
            this.radioevli.CheckedChanged += new System.EventHandler(this.radioevli_CheckedChanged);
            // 
            // bekar
            // 
            this.bekar.AutoSize = true;
            this.bekar.BackColor = System.Drawing.Color.Transparent;
            this.bekar.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bekar.CheckedState.BorderThickness = 0;
            this.bekar.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bekar.CheckedState.InnerColor = System.Drawing.Color.White;
            this.bekar.CheckedState.InnerOffset = -4;
            this.bekar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.bekar.ForeColor = System.Drawing.Color.Black;
            this.bekar.Location = new System.Drawing.Point(196, 171);
            this.bekar.Margin = new System.Windows.Forms.Padding(2);
            this.bekar.Name = "bekar";
            this.bekar.Size = new System.Drawing.Size(67, 24);
            this.bekar.TabIndex = 14;
            this.bekar.Text = "Bekar";
            this.bekar.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bekar.UncheckedState.BorderThickness = 2;
            this.bekar.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.bekar.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.bekar.UseVisualStyleBackColor = false;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Controls.Add(this.txt_sehir);
            this.guna2GroupBox1.Controls.Add(this.bekar);
            this.guna2GroupBox1.Controls.Add(this.radioevli);
            this.guna2GroupBox1.Controls.Add(this.txt_meslek);
            this.guna2GroupBox1.Controls.Add(this.txt_maas);
            this.guna2GroupBox1.Controls.Add(this.txt_soyad);
            this.guna2GroupBox1.Controls.Add(this.txt_ad);
            this.guna2GroupBox1.Controls.Add(this.txt_id);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 2);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(476, 387);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Personel Kayıt";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // txt_sehir
            // 
            this.txt_sehir.FormattingEnabled = true;
            this.txt_sehir.Items.AddRange(new object[] {
            "istanbul",
            "bursa",
            "izmir",
            "kocaeli",
            "ankara",
            "adana",
            "antalya"});
            this.txt_sehir.Location = new System.Drawing.Point(141, 240);
            this.txt_sehir.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sehir.Name = "txt_sehir";
            this.txt_sehir.Size = new System.Drawing.Size(121, 31);
            this.txt_sehir.TabIndex = 16;
            // 
            // kayıtTableAdapter
            // 
            this.kayıtTableAdapter.ClearBeforeFill = true;
            // 
            // btn_sil
            // 
            this.btn_sil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sil.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sil.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_sil.FillColor2 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_sil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Location = new System.Drawing.Point(15, 183);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(119, 36);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "Sil";
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_güncelle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_güncelle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_güncelle.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_güncelle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_güncelle.FillColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_güncelle.FillColor2 = System.Drawing.SystemColors.InactiveCaption;
            this.btn_güncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_güncelle.ForeColor = System.Drawing.Color.White;
            this.btn_güncelle.Location = new System.Drawing.Point(106, 295);
            this.btn_güncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(123, 39);
            this.btn_güncelle.TabIndex = 3;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Temizle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Temizle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Temizle.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Temizle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Temizle.FillColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Temizle.FillColor2 = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Temizle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Temizle.ForeColor = System.Drawing.Color.White;
            this.btn_Temizle.Location = new System.Drawing.Point(197, 180);
            this.btn_Temizle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(119, 39);
            this.btn_Temizle.TabIndex = 4;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // btn_istatistik
            // 
            this.btn_istatistik.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_istatistik.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_istatistik.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_istatistik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_istatistik.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_istatistik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_istatistik.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_istatistik.FillColor2 = System.Drawing.SystemColors.MenuText;
            this.btn_istatistik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_istatistik.ForeColor = System.Drawing.Color.White;
            this.btn_istatistik.Location = new System.Drawing.Point(197, 77);
            this.btn_istatistik.Margin = new System.Windows.Forms.Padding(2);
            this.btn_istatistik.Name = "btn_istatistik";
            this.btn_istatistik.Size = new System.Drawing.Size(119, 39);
            this.btn_istatistik.TabIndex = 5;
            this.btn_istatistik.Text = "istatistik";
            // 
            // btn_Grafik
            // 
            this.btn_Grafik.BorderColor = System.Drawing.Color.White;
            this.btn_Grafik.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Grafik.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Grafik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Grafik.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Grafik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Grafik.FillColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Grafik.FillColor2 = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Grafik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Grafik.ForeColor = System.Drawing.Color.White;
            this.btn_Grafik.Location = new System.Drawing.Point(197, 128);
            this.btn_Grafik.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Grafik.Name = "btn_Grafik";
            this.btn_Grafik.Size = new System.Drawing.Size(119, 39);
            this.btn_Grafik.TabIndex = 7;
            this.btn_Grafik.Text = "Grafik";
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.guna2GradientButton2.FillColor2 = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.Location = new System.Drawing.Point(15, 80);
            this.guna2GradientButton2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(119, 36);
            this.guna2GradientButton2.TabIndex = 8;
            this.guna2GradientButton2.Text = "Listele";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_kaydet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_kaydet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_kaydet.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_kaydet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_kaydet.FillColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_kaydet.FillColor2 = System.Drawing.SystemColors.InactiveCaption;
            this.btn_kaydet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_kaydet.Location = new System.Drawing.Point(15, 128);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(119, 36);
            this.btn_kaydet.TabIndex = 9;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_ogrenciara
            // 
            this.btn_ogrenciara.BorderColor = System.Drawing.Color.White;
            this.btn_ogrenciara.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ogrenciara.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ogrenciara.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ogrenciara.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ogrenciara.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ogrenciara.FillColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_ogrenciara.FillColor2 = System.Drawing.SystemColors.InactiveCaption;
            this.btn_ogrenciara.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ogrenciara.ForeColor = System.Drawing.Color.White;
            this.btn_ogrenciara.Location = new System.Drawing.Point(15, 240);
            this.btn_ogrenciara.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ogrenciara.Name = "btn_ogrenciara";
            this.btn_ogrenciara.Size = new System.Drawing.Size(128, 39);
            this.btn_ogrenciara.TabIndex = 10;
            this.btn_ogrenciara.Text = "Ogrenci Ara";
            this.btn_ogrenciara.Click += new System.EventHandler(this.btn_ogrenciara_Click);
            // 
            // sayfa3
            // 
            this.sayfa3.BorderColor = System.Drawing.Color.White;
            this.sayfa3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sayfa3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sayfa3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sayfa3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sayfa3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sayfa3.FillColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.sayfa3.FillColor2 = System.Drawing.SystemColors.InactiveCaption;
            this.sayfa3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.sayfa3.ForeColor = System.Drawing.Color.White;
            this.sayfa3.Location = new System.Drawing.Point(197, 240);
            this.sayfa3.Margin = new System.Windows.Forms.Padding(2);
            this.sayfa3.Name = "sayfa3";
            this.sayfa3.Size = new System.Drawing.Size(119, 39);
            this.sayfa3.TabIndex = 11;
            this.sayfa3.Text = "sayfa3";
            this.sayfa3.Click += new System.EventHandler(this.sayfa3_Click);
            // 
            // Grafik
            // 
            this.Grafik.BackColor = System.Drawing.SystemColors.Control;
            this.Grafik.Controls.Add(this.sayfa3);
            this.Grafik.Controls.Add(this.btn_ogrenciara);
            this.Grafik.Controls.Add(this.btn_kaydet);
            this.Grafik.Controls.Add(this.guna2GradientButton2);
            this.Grafik.Controls.Add(this.btn_Grafik);
            this.Grafik.Controls.Add(this.btn_istatistik);
            this.Grafik.Controls.Add(this.btn_Temizle);
            this.Grafik.Controls.Add(this.btn_güncelle);
            this.Grafik.Controls.Add(this.btn_sil);
            this.Grafik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Grafik.ForeColor = System.Drawing.Color.Black;
            this.Grafik.Location = new System.Drawing.Point(489, 2);
            this.Grafik.Margin = new System.Windows.Forms.Padding(2);
            this.Grafik.Name = "Grafik";
            this.Grafik.Size = new System.Drawing.Size(381, 387);
            this.Grafik.TabIndex = 2;
            this.Grafik.Text = "İşlemler";
            this.Grafik.Click += new System.EventHandler(this.Grafik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 650);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.Grafik);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_KayıtDataSet)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.Grafik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Personel_KayıtDataSet personel_KayıtDataSet;
        private System.Windows.Forms.BindingSource kayıtBindingSource;
        private Personel_KayıtDataSetTableAdapters.kayıtTableAdapter kayıtTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perDurumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_id;
        private Guna.UI2.WinForms.Guna2TextBox txt_ad;
        private Guna.UI2.WinForms.Guna2TextBox txt_soyad;
        private Guna.UI2.WinForms.Guna2TextBox txt_maas;
        private Guna.UI2.WinForms.Guna2TextBox txt_meslek;
        private Guna.UI2.WinForms.Guna2RadioButton radioevli;
        private Guna.UI2.WinForms.Guna2RadioButton bekar;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.ComboBox txt_sehir;
        private Guna.UI2.WinForms.Guna2GradientButton btn_sil;
        private Guna.UI2.WinForms.Guna2GradientButton btn_güncelle;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Temizle;
        private Guna.UI2.WinForms.Guna2GradientButton btn_istatistik;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Grafik;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton btn_kaydet;
        private Guna.UI2.WinForms.Guna2GradientButton btn_ogrenciara;
        private Guna.UI2.WinForms.Guna2GradientButton sayfa3;
        private Guna.UI2.WinForms.Guna2GroupBox Grafik;
    }
}


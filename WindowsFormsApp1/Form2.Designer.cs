namespace WindowsFormsApp1
{
    partial class Form2
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
            this.ogrnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayıt2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kayıtlarDataSet = new WindowsFormsApp1.kayıtlarDataSet();
            this.btn_tümkayıtlar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btn_Ara = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_arama = new Guna.UI2.WinForms.Guna2TextBox();
            this.rdr_sınıfagore = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdr_soyisme = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdr_ismegore = new Guna.UI2.WinForms.Guna2RadioButton();
            this.kayıt2TableAdapter = new WindowsFormsApp1.kayıtlarDataSetTableAdapters.kayıt2TableAdapter();
            this.Button1 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayıt2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtlarDataSet)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrnoDataGridViewTextBoxColumn,
            this.ogradDataGridViewTextBoxColumn,
            this.ogrsoyadDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.dtarihDataGridViewTextBoxColumn,
            this.sinifDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kayıt2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 179);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(645, 180);
            this.dataGridView1.TabIndex = 9;
            // 
            // ogrnoDataGridViewTextBoxColumn
            // 
            this.ogrnoDataGridViewTextBoxColumn.DataPropertyName = "ogrno";
            this.ogrnoDataGridViewTextBoxColumn.HeaderText = "ogrno";
            this.ogrnoDataGridViewTextBoxColumn.Name = "ogrnoDataGridViewTextBoxColumn";
            // 
            // ogradDataGridViewTextBoxColumn
            // 
            this.ogradDataGridViewTextBoxColumn.DataPropertyName = "ograd";
            this.ogradDataGridViewTextBoxColumn.HeaderText = "ograd";
            this.ogradDataGridViewTextBoxColumn.Name = "ogradDataGridViewTextBoxColumn";
            // 
            // ogrsoyadDataGridViewTextBoxColumn
            // 
            this.ogrsoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.HeaderText = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.Name = "ogrsoyadDataGridViewTextBoxColumn";
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            // 
            // dtarihDataGridViewTextBoxColumn
            // 
            this.dtarihDataGridViewTextBoxColumn.DataPropertyName = "dtarih";
            this.dtarihDataGridViewTextBoxColumn.HeaderText = "dtarih";
            this.dtarihDataGridViewTextBoxColumn.Name = "dtarihDataGridViewTextBoxColumn";
            // 
            // sinifDataGridViewTextBoxColumn
            // 
            this.sinifDataGridViewTextBoxColumn.DataPropertyName = "sinif";
            this.sinifDataGridViewTextBoxColumn.HeaderText = "sinif";
            this.sinifDataGridViewTextBoxColumn.Name = "sinifDataGridViewTextBoxColumn";
            // 
            // kayıt2BindingSource
            // 
            this.kayıt2BindingSource.DataMember = "kayıt2";
            this.kayıt2BindingSource.DataSource = this.kayıtlarDataSet;
            // 
            // kayıtlarDataSet
            // 
            this.kayıtlarDataSet.DataSetName = "kayıtlarDataSet";
            this.kayıtlarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_tümkayıtlar
            // 
            this.btn_tümkayıtlar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tümkayıtlar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tümkayıtlar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tümkayıtlar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tümkayıtlar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tümkayıtlar.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_tümkayıtlar.FillColor2 = System.Drawing.SystemColors.Desktop;
            this.btn_tümkayıtlar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_tümkayıtlar.ForeColor = System.Drawing.Color.White;
            this.btn_tümkayıtlar.Location = new System.Drawing.Point(0, 130);
            this.btn_tümkayıtlar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tümkayıtlar.Name = "btn_tümkayıtlar";
            this.btn_tümkayıtlar.Size = new System.Drawing.Size(139, 45);
            this.btn_tümkayıtlar.TabIndex = 8;
            this.btn_tümkayıtlar.Text = "Tüm Kayıtları Getir";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.BorderThickness = 0;
            this.guna2GroupBox1.Controls.Add(this.btn_Ara);
            this.guna2GroupBox1.Controls.Add(this.txt_arama);
            this.guna2GroupBox1.Controls.Add(this.rdr_sınıfagore);
            this.guna2GroupBox1.Controls.Add(this.rdr_soyisme);
            this.guna2GroupBox1.Controls.Add(this.rdr_ismegore);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 2);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(383, 124);
            this.guna2GroupBox1.TabIndex = 7;
            this.guna2GroupBox1.Text = "Arama";
            // 
            // btn_Ara
            // 
            this.btn_Ara.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Ara.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Ara.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Ara.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Ara.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Ara.FillColor = System.Drawing.Color.Gray;
            this.btn_Ara.FillColor2 = System.Drawing.SystemColors.Desktop;
            this.btn_Ara.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Ara.ForeColor = System.Drawing.Color.White;
            this.btn_Ara.Location = new System.Drawing.Point(278, 61);
            this.btn_Ara.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(72, 36);
            this.btn_Ara.TabIndex = 4;
            this.btn_Ara.Text = "Ara";
            // 
            // txt_arama
            // 
            this.txt_arama.BorderColor = System.Drawing.Color.Black;
            this.txt_arama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_arama.DefaultText = "";
            this.txt_arama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_arama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_arama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_arama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_arama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_arama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_arama.ForeColor = System.Drawing.Color.Black;
            this.txt_arama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_arama.Location = new System.Drawing.Point(132, 65);
            this.txt_arama.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_arama.Name = "txt_arama";
            this.txt_arama.PasswordChar = '\0';
            this.txt_arama.PlaceholderText = "";
            this.txt_arama.SelectedText = "";
            this.txt_arama.Size = new System.Drawing.Size(142, 30);
            this.txt_arama.TabIndex = 1;
            // 
            // rdr_sınıfagore
            // 
            this.rdr_sınıfagore.AutoSize = true;
            this.rdr_sınıfagore.BackColor = System.Drawing.Color.Transparent;
            this.rdr_sınıfagore.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdr_sınıfagore.CheckedState.BorderThickness = 0;
            this.rdr_sınıfagore.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdr_sınıfagore.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdr_sınıfagore.CheckedState.InnerOffset = -4;
            this.rdr_sınıfagore.ForeColor = System.Drawing.Color.Black;
            this.rdr_sınıfagore.Location = new System.Drawing.Point(11, 93);
            this.rdr_sınıfagore.Margin = new System.Windows.Forms.Padding(2);
            this.rdr_sınıfagore.Name = "rdr_sınıfagore";
            this.rdr_sınıfagore.Size = new System.Drawing.Size(109, 19);
            this.rdr_sınıfagore.TabIndex = 3;
            this.rdr_sınıfagore.Text = "Sınıfa Göre Ara";
            this.rdr_sınıfagore.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdr_sınıfagore.UncheckedState.BorderThickness = 2;
            this.rdr_sınıfagore.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdr_sınıfagore.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdr_sınıfagore.UseVisualStyleBackColor = false;
            // 
            // rdr_soyisme
            // 
            this.rdr_soyisme.AutoSize = true;
            this.rdr_soyisme.BackColor = System.Drawing.Color.Transparent;
            this.rdr_soyisme.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdr_soyisme.CheckedState.BorderThickness = 0;
            this.rdr_soyisme.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdr_soyisme.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdr_soyisme.CheckedState.InnerOffset = -4;
            this.rdr_soyisme.ForeColor = System.Drawing.Color.Black;
            this.rdr_soyisme.Location = new System.Drawing.Point(11, 69);
            this.rdr_soyisme.Margin = new System.Windows.Forms.Padding(2);
            this.rdr_soyisme.Name = "rdr_soyisme";
            this.rdr_soyisme.Size = new System.Drawing.Size(124, 19);
            this.rdr_soyisme.TabIndex = 2;
            this.rdr_soyisme.Text = "Soyisme Göre Ara";
            this.rdr_soyisme.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdr_soyisme.UncheckedState.BorderThickness = 2;
            this.rdr_soyisme.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdr_soyisme.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdr_soyisme.UseVisualStyleBackColor = false;
            // 
            // rdr_ismegore
            // 
            this.rdr_ismegore.AutoSize = true;
            this.rdr_ismegore.BackColor = System.Drawing.Color.Transparent;
            this.rdr_ismegore.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdr_ismegore.CheckedState.BorderThickness = 0;
            this.rdr_ismegore.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdr_ismegore.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdr_ismegore.CheckedState.InnerOffset = -4;
            this.rdr_ismegore.ForeColor = System.Drawing.Color.Black;
            this.rdr_ismegore.Location = new System.Drawing.Point(11, 45);
            this.rdr_ismegore.Margin = new System.Windows.Forms.Padding(2);
            this.rdr_ismegore.Name = "rdr_ismegore";
            this.rdr_ismegore.Size = new System.Drawing.Size(105, 19);
            this.rdr_ismegore.TabIndex = 1;
            this.rdr_ismegore.Text = "İsme Göre Ara";
            this.rdr_ismegore.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdr_ismegore.UncheckedState.BorderThickness = 2;
            this.rdr_ismegore.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdr_ismegore.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdr_ismegore.UseVisualStyleBackColor = false;
            // 
            // kayıt2TableAdapter
            // 
            this.kayıt2TableAdapter.ClearBeforeFill = true;
            // 
            // Button1
            // 
            this.Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button1.FillColor = System.Drawing.Color.MediumPurple;
            this.Button1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_back_64;
            this.Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.Button1.Location = new System.Drawing.Point(584, 2);
            this.Button1.Margin = new System.Windows.Forms.Padding(2);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(61, 51);
            this.Button1.TabIndex = 10;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(645, 371);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_tümkayıtlar);
            this.Controls.Add(this.guna2GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayıt2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtlarDataSet)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_tümkayıtlar;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Ara;
        private Guna.UI2.WinForms.Guna2TextBox txt_arama;
        private Guna.UI2.WinForms.Guna2RadioButton rdr_sınıfagore;
        private Guna.UI2.WinForms.Guna2RadioButton rdr_soyisme;
        private Guna.UI2.WinForms.Guna2RadioButton rdr_ismegore;
        private kayıtlarDataSet kayıtlarDataSet;
        private System.Windows.Forms.BindingSource kayıt2BindingSource;
        private kayıtlarDataSetTableAdapters.kayıt2TableAdapter kayıt2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2GradientButton Button1;
    }
}
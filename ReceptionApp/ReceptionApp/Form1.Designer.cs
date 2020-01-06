namespace ReceptionApp
{
    partial class recepcion_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.llamadas_tab = new System.Windows.Forms.TabPage();
            this.Exportar_btn = new System.Windows.Forms.Button();
            this.guardarllamada_btn = new System.Windows.Forms.Button();
            this.notas_txtbox = new System.Windows.Forms.TextBox();
            this.categoria_combo = new System.Windows.Forms.ComboBox();
            this.combo_rubro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.llamadas_datagrid = new System.Windows.Forms.DataGridView();
            this.correspondencia_tab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NotasC = new System.Windows.Forms.TextBox();
            this.comboRubroC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveC_btn = new System.Windows.Forms.Button();
            this.audiencias_tab = new System.Windows.Forms.TabPage();
            this.Datagrid_audiencia = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_audienciaCon = new System.Windows.Forms.TextBox();
            this.txt_beneficiarioTel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_beneficiarioName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_notasA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.audiencia_combo = new System.Windows.Forms.ComboBox();
            this.txt_horaA = new System.Windows.Forms.TextBox();
            this.btn_saveAudiencia = new System.Windows.Forms.Button();
            this.DT_audiencias = new System.Windows.Forms.DateTimePicker();
            this.atencion_tab = new System.Windows.Forms.TabPage();
            this.llamadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fOPROLYD_recepDataSet = new ReceptionApp.FOPROLYD_recepDataSet();
            this.report_btn = new System.Windows.Forms.Button();
            this.salir_btn = new System.Windows.Forms.Button();
            this.llamadasTableAdapter = new ReceptionApp.FOPROLYD_recepDataSetTableAdapters.llamadasTableAdapter();
            this.Refrescar_btn = new System.Windows.Forms.Button();
            this.exportar_correspondencia = new System.Windows.Forms.Button();
            this.exportar_audiencias = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.llamadas_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.llamadas_datagrid)).BeginInit();
            this.correspondencia_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.audiencias_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_audiencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.llamadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOPROLYD_recepDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.llamadas_tab);
            this.tabControl1.Controls.Add(this.correspondencia_tab);
            this.tabControl1.Controls.Add(this.audiencias_tab);
            this.tabControl1.Controls.Add(this.atencion_tab);
            this.tabControl1.ItemSize = new System.Drawing.Size(57, 55);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(918, 476);
            this.tabControl1.TabIndex = 0;
            // 
            // llamadas_tab
            // 
            this.llamadas_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.llamadas_tab.Controls.Add(this.Exportar_btn);
            this.llamadas_tab.Controls.Add(this.guardarllamada_btn);
            this.llamadas_tab.Controls.Add(this.notas_txtbox);
            this.llamadas_tab.Controls.Add(this.categoria_combo);
            this.llamadas_tab.Controls.Add(this.combo_rubro);
            this.llamadas_tab.Controls.Add(this.label2);
            this.llamadas_tab.Controls.Add(this.label1);
            this.llamadas_tab.Controls.Add(this.llamadas_datagrid);
            this.llamadas_tab.Location = new System.Drawing.Point(4, 59);
            this.llamadas_tab.Margin = new System.Windows.Forms.Padding(0);
            this.llamadas_tab.Name = "llamadas_tab";
            this.llamadas_tab.Padding = new System.Windows.Forms.Padding(3);
            this.llamadas_tab.Size = new System.Drawing.Size(910, 413);
            this.llamadas_tab.TabIndex = 0;
            this.llamadas_tab.Text = "Llamadas";
            // 
            // Exportar_btn
            // 
            this.Exportar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exportar_btn.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exportar_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Exportar_btn.Location = new System.Drawing.Point(772, 66);
            this.Exportar_btn.Name = "Exportar_btn";
            this.Exportar_btn.Size = new System.Drawing.Size(132, 40);
            this.Exportar_btn.TabIndex = 13;
            this.Exportar_btn.Text = "Abrir en Excel";
            this.Exportar_btn.UseVisualStyleBackColor = true;
            this.Exportar_btn.Click += new System.EventHandler(this.Exportar_btn_Click);
            // 
            // guardarllamada_btn
            // 
            this.guardarllamada_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarllamada_btn.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarllamada_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guardarllamada_btn.Location = new System.Drawing.Point(772, 112);
            this.guardarllamada_btn.Name = "guardarllamada_btn";
            this.guardarllamada_btn.Size = new System.Drawing.Size(132, 80);
            this.guardarllamada_btn.TabIndex = 12;
            this.guardarllamada_btn.Text = "Guardar";
            this.guardarllamada_btn.UseVisualStyleBackColor = true;
            this.guardarllamada_btn.Click += new System.EventHandler(this.guardarllamada_btn_Click);
            // 
            // notas_txtbox
            // 
            this.notas_txtbox.Location = new System.Drawing.Point(24, 112);
            this.notas_txtbox.Multiline = true;
            this.notas_txtbox.Name = "notas_txtbox";
            this.notas_txtbox.Size = new System.Drawing.Size(732, 80);
            this.notas_txtbox.TabIndex = 9;
            this.notas_txtbox.TextChanged += new System.EventHandler(this.notas_txtbox_TextChanged);
            // 
            // categoria_combo
            // 
            this.categoria_combo.FormattingEnabled = true;
            this.categoria_combo.Items.AddRange(new object[] {
            "Beneficiarios",
            "Proveedores",
            "Agencias",
            "Insultos",
            "Personales",
            "I.Publicas"});
            this.categoria_combo.Location = new System.Drawing.Point(196, 66);
            this.categoria_combo.Name = "categoria_combo";
            this.categoria_combo.Size = new System.Drawing.Size(169, 21);
            this.categoria_combo.TabIndex = 7;
            this.categoria_combo.Text = "Seleccione---";
            // 
            // combo_rubro
            // 
            this.combo_rubro.FormattingEnabled = true;
            this.combo_rubro.Items.AddRange(new object[] {
            "PRES",
            "CTE",
            "DATH",
            "DAYOR",
            "DCONTA",
            "DCR",
            "DPYBE",
            "DPRES",
            "DSYCS",
            "DSG",
            "DTES",
            "GG",
            "LABPRO",
            "ORCHAL",
            "ORSAM",
            "UADI",
            "UAIP",
            "UACI",
            "UAI",
            "UG",
            "UGDAI",
            "UI",
            "UPYR",
            "URSYP",
            "UFI",
            "UJ"});
            this.combo_rubro.Location = new System.Drawing.Point(24, 66);
            this.combo_rubro.Name = "combo_rubro";
            this.combo_rubro.Size = new System.Drawing.Size(139, 21);
            this.combo_rubro.TabIndex = 6;
            this.combo_rubro.Text = "Seleccione---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(193, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoría";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rubro";
            // 
            // llamadas_datagrid
            // 
            this.llamadas_datagrid.AllowUserToAddRows = false;
            this.llamadas_datagrid.AllowUserToDeleteRows = false;
            this.llamadas_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.llamadas_datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.llamadas_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.llamadas_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.llamadas_datagrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.llamadas_datagrid.Location = new System.Drawing.Point(24, 208);
            this.llamadas_datagrid.Name = "llamadas_datagrid";
            this.llamadas_datagrid.ReadOnly = true;
            this.llamadas_datagrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.llamadas_datagrid.RowHeadersWidth = 60;
            this.llamadas_datagrid.Size = new System.Drawing.Size(880, 199);
            this.llamadas_datagrid.TabIndex = 0;
            // 
            // correspondencia_tab
            // 
            this.correspondencia_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.correspondencia_tab.Controls.Add(this.exportar_correspondencia);
            this.correspondencia_tab.Controls.Add(this.dataGridView1);
            this.correspondencia_tab.Controls.Add(this.NotasC);
            this.correspondencia_tab.Controls.Add(this.comboRubroC);
            this.correspondencia_tab.Controls.Add(this.label3);
            this.correspondencia_tab.Controls.Add(this.saveC_btn);
            this.correspondencia_tab.Location = new System.Drawing.Point(4, 59);
            this.correspondencia_tab.Name = "correspondencia_tab";
            this.correspondencia_tab.Padding = new System.Windows.Forms.Padding(3);
            this.correspondencia_tab.Size = new System.Drawing.Size(910, 413);
            this.correspondencia_tab.TabIndex = 1;
            this.correspondencia_tab.Text = "Correspondencias";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(882, 244);
            this.dataGridView1.TabIndex = 6;
            // 
            // NotasC
            // 
            this.NotasC.Location = new System.Drawing.Point(22, 71);
            this.NotasC.Multiline = true;
            this.NotasC.Name = "NotasC";
            this.NotasC.Size = new System.Drawing.Size(667, 72);
            this.NotasC.TabIndex = 5;
            this.NotasC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboRubroC
            // 
            this.comboRubroC.FormattingEnabled = true;
            this.comboRubroC.Items.AddRange(new object[] {
            "Cartas Beneficiarios",
            "Cartas Estatales",
            "Doc. ORSAM",
            "Doc. ORCHAL",
            "Cartas Empresa privada"});
            this.comboRubroC.Location = new System.Drawing.Point(22, 44);
            this.comboRubroC.Name = "comboRubroC";
            this.comboRubroC.Size = new System.Drawing.Size(121, 21);
            this.comboRubroC.TabIndex = 3;
            this.comboRubroC.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(17, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rubro";
            // 
            // saveC_btn
            // 
            this.saveC_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveC_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveC_btn.Location = new System.Drawing.Point(695, 69);
            this.saveC_btn.Name = "saveC_btn";
            this.saveC_btn.Size = new System.Drawing.Size(108, 74);
            this.saveC_btn.TabIndex = 0;
            this.saveC_btn.Text = "Guardar";
            this.saveC_btn.UseVisualStyleBackColor = true;
            this.saveC_btn.Click += new System.EventHandler(this.saveC_btn_Click);
            // 
            // audiencias_tab
            // 
            this.audiencias_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.audiencias_tab.Controls.Add(this.exportar_audiencias);
            this.audiencias_tab.Controls.Add(this.Datagrid_audiencia);
            this.audiencias_tab.Controls.Add(this.label10);
            this.audiencias_tab.Controls.Add(this.txt_audienciaCon);
            this.audiencias_tab.Controls.Add(this.txt_beneficiarioTel);
            this.audiencias_tab.Controls.Add(this.label9);
            this.audiencias_tab.Controls.Add(this.txt_beneficiarioName);
            this.audiencias_tab.Controls.Add(this.label8);
            this.audiencias_tab.Controls.Add(this.txt_notasA);
            this.audiencias_tab.Controls.Add(this.label7);
            this.audiencias_tab.Controls.Add(this.label6);
            this.audiencias_tab.Controls.Add(this.label5);
            this.audiencias_tab.Controls.Add(this.label4);
            this.audiencias_tab.Controls.Add(this.audiencia_combo);
            this.audiencias_tab.Controls.Add(this.txt_horaA);
            this.audiencias_tab.Controls.Add(this.btn_saveAudiencia);
            this.audiencias_tab.Controls.Add(this.DT_audiencias);
            this.audiencias_tab.Location = new System.Drawing.Point(4, 59);
            this.audiencias_tab.Name = "audiencias_tab";
            this.audiencias_tab.Padding = new System.Windows.Forms.Padding(3);
            this.audiencias_tab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.audiencias_tab.Size = new System.Drawing.Size(910, 413);
            this.audiencias_tab.TabIndex = 2;
            this.audiencias_tab.Text = "Audiencias";
            // 
            // Datagrid_audiencia
            // 
            this.Datagrid_audiencia.AllowUserToAddRows = false;
            this.Datagrid_audiencia.AllowUserToDeleteRows = false;
            this.Datagrid_audiencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagrid_audiencia.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.Datagrid_audiencia.Location = new System.Drawing.Point(22, 199);
            this.Datagrid_audiencia.Name = "Datagrid_audiencia";
            this.Datagrid_audiencia.ReadOnly = true;
            this.Datagrid_audiencia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Datagrid_audiencia.Size = new System.Drawing.Size(882, 214);
            this.Datagrid_audiencia.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(708, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 14);
            this.label10.TabIndex = 15;
            this.label10.Text = "Audiencia con:";
            // 
            // txt_audienciaCon
            // 
            this.txt_audienciaCon.Location = new System.Drawing.Point(711, 108);
            this.txt_audienciaCon.Name = "txt_audienciaCon";
            this.txt_audienciaCon.Size = new System.Drawing.Size(193, 20);
            this.txt_audienciaCon.TabIndex = 5;
            // 
            // txt_beneficiarioTel
            // 
            this.txt_beneficiarioTel.Location = new System.Drawing.Point(711, 52);
            this.txt_beneficiarioTel.Name = "txt_beneficiarioTel";
            this.txt_beneficiarioTel.Size = new System.Drawing.Size(100, 20);
            this.txt_beneficiarioTel.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(708, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 14);
            this.label9.TabIndex = 12;
            this.label9.Text = "Teléfono";
            // 
            // txt_beneficiarioName
            // 
            this.txt_beneficiarioName.Location = new System.Drawing.Point(493, 49);
            this.txt_beneficiarioName.Name = "txt_beneficiarioName";
            this.txt_beneficiarioName.Size = new System.Drawing.Size(173, 20);
            this.txt_beneficiarioName.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(490, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 14);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nombre del Beneficiario";
            // 
            // txt_notasA
            // 
            this.txt_notasA.Location = new System.Drawing.Point(22, 108);
            this.txt_notasA.Multiline = true;
            this.txt_notasA.Name = "txt_notasA";
            this.txt_notasA.Size = new System.Drawing.Size(672, 85);
            this.txt_notasA.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(22, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = "Observaciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(347, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hora de audiencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(177, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha de audiencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(22, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rubro";
            // 
            // audiencia_combo
            // 
            this.audiencia_combo.FormattingEnabled = true;
            this.audiencia_combo.Items.AddRange(new object[] {
            "Junta Directiva",
            "Presidencia",
            "Gerencia",
            "Subgerencia"});
            this.audiencia_combo.Location = new System.Drawing.Point(22, 49);
            this.audiencia_combo.Name = "audiencia_combo";
            this.audiencia_combo.Size = new System.Drawing.Size(134, 21);
            this.audiencia_combo.TabIndex = 0;
            // 
            // txt_horaA
            // 
            this.txt_horaA.Location = new System.Drawing.Point(350, 49);
            this.txt_horaA.Name = "txt_horaA";
            this.txt_horaA.Size = new System.Drawing.Size(91, 20);
            this.txt_horaA.TabIndex = 2;
            // 
            // btn_saveAudiencia
            // 
            this.btn_saveAudiencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveAudiencia.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveAudiencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_saveAudiencia.Location = new System.Drawing.Point(711, 134);
            this.btn_saveAudiencia.Name = "btn_saveAudiencia";
            this.btn_saveAudiencia.Size = new System.Drawing.Size(100, 59);
            this.btn_saveAudiencia.TabIndex = 7;
            this.btn_saveAudiencia.Text = "Guardar";
            this.btn_saveAudiencia.UseVisualStyleBackColor = true;
            this.btn_saveAudiencia.Click += new System.EventHandler(this.btn_fechaA_Click);
            // 
            // DT_audiencias
            // 
            this.DT_audiencias.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DT_audiencias.Location = new System.Drawing.Point(180, 49);
            this.DT_audiencias.MinDate = new System.DateTime(2019, 12, 25, 0, 0, 0, 0);
            this.DT_audiencias.Name = "DT_audiencias";
            this.DT_audiencias.Size = new System.Drawing.Size(134, 20);
            this.DT_audiencias.TabIndex = 1;
            this.DT_audiencias.ValueChanged += new System.EventHandler(this.DT_audiencias_ValueChanged);
            // 
            // atencion_tab
            // 
            this.atencion_tab.Location = new System.Drawing.Point(4, 59);
            this.atencion_tab.Name = "atencion_tab";
            this.atencion_tab.Padding = new System.Windows.Forms.Padding(3);
            this.atencion_tab.Size = new System.Drawing.Size(910, 413);
            this.atencion_tab.TabIndex = 3;
            this.atencion_tab.Text = "Atención al publico";
            this.atencion_tab.UseVisualStyleBackColor = true;
            // 
            // llamadasBindingSource
            // 
            this.llamadasBindingSource.DataMember = "llamadas";
            this.llamadasBindingSource.DataSource = this.fOPROLYD_recepDataSet;
            // 
            // fOPROLYD_recepDataSet
            // 
            this.fOPROLYD_recepDataSet.DataSetName = "FOPROLYD_recepDataSet";
            this.fOPROLYD_recepDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report_btn
            // 
            this.report_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_btn.Location = new System.Drawing.Point(609, 482);
            this.report_btn.Name = "report_btn";
            this.report_btn.Size = new System.Drawing.Size(152, 38);
            this.report_btn.TabIndex = 1;
            this.report_btn.Text = "Reportes";
            this.report_btn.UseVisualStyleBackColor = true;
            // 
            // salir_btn
            // 
            this.salir_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir_btn.Location = new System.Drawing.Point(767, 482);
            this.salir_btn.Name = "salir_btn";
            this.salir_btn.Size = new System.Drawing.Size(152, 38);
            this.salir_btn.TabIndex = 2;
            this.salir_btn.Text = " Salir";
            this.salir_btn.UseVisualStyleBackColor = true;
            this.salir_btn.Click += new System.EventHandler(this.salir_btn_Click);
            // 
            // llamadasTableAdapter
            // 
            this.llamadasTableAdapter.ClearBeforeFill = true;
            // 
            // Refrescar_btn
            // 
            this.Refrescar_btn.Location = new System.Drawing.Point(1, 486);
            this.Refrescar_btn.Name = "Refrescar_btn";
            this.Refrescar_btn.Size = new System.Drawing.Size(102, 34);
            this.Refrescar_btn.TabIndex = 3;
            this.Refrescar_btn.Text = "Refrescar";
            this.Refrescar_btn.UseVisualStyleBackColor = true;
            this.Refrescar_btn.Click += new System.EventHandler(this.Refrescar_btn_Click_1);
            // 
            // exportar_correspondencia
            // 
            this.exportar_correspondencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportar_correspondencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exportar_correspondencia.Location = new System.Drawing.Point(809, 69);
            this.exportar_correspondencia.Name = "exportar_correspondencia";
            this.exportar_correspondencia.Size = new System.Drawing.Size(95, 72);
            this.exportar_correspondencia.TabIndex = 7;
            this.exportar_correspondencia.Text = "Abrir en Excel";
            this.exportar_correspondencia.UseVisualStyleBackColor = true;
            this.exportar_correspondencia.Click += new System.EventHandler(this.exportar_correspondencia_Click);
            // 
            // exportar_audiencias
            // 
            this.exportar_audiencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportar_audiencias.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportar_audiencias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exportar_audiencias.Location = new System.Drawing.Point(818, 134);
            this.exportar_audiencias.Name = "exportar_audiencias";
            this.exportar_audiencias.Size = new System.Drawing.Size(86, 59);
            this.exportar_audiencias.TabIndex = 17;
            this.exportar_audiencias.Text = "Abrir en Excel";
            this.exportar_audiencias.UseVisualStyleBackColor = true;
            this.exportar_audiencias.Click += new System.EventHandler(this.exportar_audiencias_Click);
            // 
            // recepcion_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(922, 524);
            this.Controls.Add(this.Refrescar_btn);
            this.Controls.Add(this.salir_btn);
            this.Controls.Add(this.report_btn);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "recepcion_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Recepción FOPROLYD";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.recepcion_form_Load);
            this.tabControl1.ResumeLayout(false);
            this.llamadas_tab.ResumeLayout(false);
            this.llamadas_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.llamadas_datagrid)).EndInit();
            this.correspondencia_tab.ResumeLayout(false);
            this.correspondencia_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.audiencias_tab.ResumeLayout(false);
            this.audiencias_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_audiencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.llamadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOPROLYD_recepDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage llamadas_tab;
        private System.Windows.Forms.TabPage correspondencia_tab;
        private System.Windows.Forms.TabPage audiencias_tab;
        private System.Windows.Forms.TabPage atencion_tab;
        private System.Windows.Forms.Button report_btn;
        private System.Windows.Forms.Button salir_btn;
        private System.Windows.Forms.DataGridView llamadas_datagrid;
        private System.Windows.Forms.Button guardarllamada_btn;
        private System.Windows.Forms.TextBox notas_txtbox;
        private System.Windows.Forms.ComboBox categoria_combo;
        private System.Windows.Forms.ComboBox combo_rubro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FOPROLYD_recepDataSet fOPROLYD_recepDataSet;
        private System.Windows.Forms.BindingSource llamadasBindingSource;
        private FOPROLYD_recepDataSetTableAdapters.llamadasTableAdapter llamadasTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveC_btn;
        private System.Windows.Forms.TextBox NotasC;
        private System.Windows.Forms.ComboBox comboRubroC;
        private System.Windows.Forms.Button Refrescar_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker DT_audiencias;
        private System.Windows.Forms.TextBox txt_horaA;
        private System.Windows.Forms.Button btn_saveAudiencia;
        private System.Windows.Forms.DataGridView Datagrid_audiencia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_audienciaCon;
        private System.Windows.Forms.TextBox txt_beneficiarioTel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_beneficiarioName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_notasA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox audiencia_combo;
        private System.Windows.Forms.Button Exportar_btn;
        private System.Windows.Forms.Button exportar_correspondencia;
        private System.Windows.Forms.Button exportar_audiencias;
    }
}


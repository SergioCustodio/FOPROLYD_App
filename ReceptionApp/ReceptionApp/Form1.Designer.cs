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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.llamadas_tab = new System.Windows.Forms.TabPage();
            this.correspondencia_tab = new System.Windows.Forms.TabPage();
            this.audiencias_tab = new System.Windows.Forms.TabPage();
            this.atencion_tab = new System.Windows.Forms.TabPage();
            this.report_btn = new System.Windows.Forms.Button();
            this.salir_btn = new System.Windows.Forms.Button();
            this.llamadas_datagrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_rubro = new System.Windows.Forms.ComboBox();
            this.categoria_combo = new System.Windows.Forms.ComboBox();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.notas_txtbox = new System.Windows.Forms.TextBox();
            this.notas_check = new System.Windows.Forms.CheckBox();
            this.guardarllamada_btn = new System.Windows.Forms.Button();
            this.refrescar_btn = new System.Windows.Forms.Button();
            this.fOPROLYD_recepDataSet = new ReceptionApp.FOPROLYD_recepDataSet();
            this.llamadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.llamadasTableAdapter = new ReceptionApp.FOPROLYD_recepDataSetTableAdapters.llamadasTableAdapter();
            this.iDllamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubrollamadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechallamadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.llamadas_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.llamadas_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOPROLYD_recepDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.llamadasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.llamadas_tab);
            this.tabControl1.Controls.Add(this.correspondencia_tab);
            this.tabControl1.Controls.Add(this.audiencias_tab);
            this.tabControl1.Controls.Add(this.atencion_tab);
            this.tabControl1.ItemSize = new System.Drawing.Size(57, 45);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 396);
            this.tabControl1.TabIndex = 0;
            // 
            // llamadas_tab
            // 
            this.llamadas_tab.Controls.Add(this.guardarllamada_btn);
            this.llamadas_tab.Controls.Add(this.notas_txtbox);
            this.llamadas_tab.Controls.Add(this.notas_check);
            this.llamadas_tab.Controls.Add(this.date_picker);
            this.llamadas_tab.Controls.Add(this.categoria_combo);
            this.llamadas_tab.Controls.Add(this.combo_rubro);
            this.llamadas_tab.Controls.Add(this.label3);
            this.llamadas_tab.Controls.Add(this.label2);
            this.llamadas_tab.Controls.Add(this.label1);
            this.llamadas_tab.Controls.Add(this.llamadas_datagrid);
            this.llamadas_tab.Location = new System.Drawing.Point(4, 49);
            this.llamadas_tab.Name = "llamadas_tab";
            this.llamadas_tab.Padding = new System.Windows.Forms.Padding(3);
            this.llamadas_tab.Size = new System.Drawing.Size(792, 343);
            this.llamadas_tab.TabIndex = 0;
            this.llamadas_tab.Text = "Llamadas";
            this.llamadas_tab.UseVisualStyleBackColor = true;
            // 
            // correspondencia_tab
            // 
            this.correspondencia_tab.Location = new System.Drawing.Point(4, 49);
            this.correspondencia_tab.Name = "correspondencia_tab";
            this.correspondencia_tab.Padding = new System.Windows.Forms.Padding(3);
            this.correspondencia_tab.Size = new System.Drawing.Size(792, 343);
            this.correspondencia_tab.TabIndex = 1;
            this.correspondencia_tab.Text = "Correspondencias";
            this.correspondencia_tab.UseVisualStyleBackColor = true;
            // 
            // audiencias_tab
            // 
            this.audiencias_tab.Location = new System.Drawing.Point(4, 49);
            this.audiencias_tab.Name = "audiencias_tab";
            this.audiencias_tab.Padding = new System.Windows.Forms.Padding(3);
            this.audiencias_tab.Size = new System.Drawing.Size(792, 343);
            this.audiencias_tab.TabIndex = 2;
            this.audiencias_tab.Text = "Audiencias";
            this.audiencias_tab.UseVisualStyleBackColor = true;
            // 
            // atencion_tab
            // 
            this.atencion_tab.Location = new System.Drawing.Point(4, 49);
            this.atencion_tab.Name = "atencion_tab";
            this.atencion_tab.Padding = new System.Windows.Forms.Padding(3);
            this.atencion_tab.Size = new System.Drawing.Size(792, 343);
            this.atencion_tab.TabIndex = 3;
            this.atencion_tab.Text = "Atención al publico";
            this.atencion_tab.UseVisualStyleBackColor = true;
            // 
            // report_btn
            // 
            this.report_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_btn.Location = new System.Drawing.Point(487, 401);
            this.report_btn.Name = "report_btn";
            this.report_btn.Size = new System.Drawing.Size(152, 38);
            this.report_btn.TabIndex = 1;
            this.report_btn.Text = "Reportes";
            this.report_btn.UseVisualStyleBackColor = true;
            // 
            // salir_btn
            // 
            this.salir_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir_btn.Location = new System.Drawing.Point(645, 401);
            this.salir_btn.Name = "salir_btn";
            this.salir_btn.Size = new System.Drawing.Size(152, 38);
            this.salir_btn.TabIndex = 2;
            this.salir_btn.Text = "Salir";
            this.salir_btn.UseVisualStyleBackColor = true;
            this.salir_btn.Click += new System.EventHandler(this.salir_btn_Click);
            // 
            // llamadas_datagrid
            // 
            this.llamadas_datagrid.AllowUserToAddRows = false;
            this.llamadas_datagrid.AllowUserToDeleteRows = false;
            this.llamadas_datagrid.AutoGenerateColumns = false;
            this.llamadas_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.llamadas_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDllamaDataGridViewTextBoxColumn,
            this.rubrollamadaDataGridViewTextBoxColumn,
            this.fechallamadaDataGridViewTextBoxColumn,
            this.identificadorDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.notasDataGridViewTextBoxColumn});
            this.llamadas_datagrid.DataSource = this.llamadasBindingSource;
            this.llamadas_datagrid.Location = new System.Drawing.Point(7, 218);
            this.llamadas_datagrid.Name = "llamadas_datagrid";
            this.llamadas_datagrid.ReadOnly = true;
            this.llamadas_datagrid.Size = new System.Drawing.Size(779, 119);
            this.llamadas_datagrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rubro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha";
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
            this.combo_rubro.Location = new System.Drawing.Point(24, 52);
            this.combo_rubro.Name = "combo_rubro";
            this.combo_rubro.Size = new System.Drawing.Size(139, 21);
            this.combo_rubro.TabIndex = 6;
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
            "I. Publicas"});
            this.categoria_combo.Location = new System.Drawing.Point(225, 52);
            this.categoria_combo.Name = "categoria_combo";
            this.categoria_combo.Size = new System.Drawing.Size(169, 21);
            this.categoria_combo.TabIndex = 7;
            // 
            // date_picker
            // 
            this.date_picker.Location = new System.Drawing.Point(465, 53);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(200, 20);
            this.date_picker.TabIndex = 8;
            // 
            // notas_txtbox
            // 
            this.notas_txtbox.Location = new System.Drawing.Point(24, 112);
            this.notas_txtbox.Multiline = true;
            this.notas_txtbox.Name = "notas_txtbox";
            this.notas_txtbox.Size = new System.Drawing.Size(641, 80);
            this.notas_txtbox.TabIndex = 9;
            // 
            // notas_check
            // 
            this.notas_check.AutoSize = true;
            this.notas_check.Location = new System.Drawing.Point(24, 89);
            this.notas_check.Name = "notas_check";
            this.notas_check.Size = new System.Drawing.Size(88, 17);
            this.notas_check.TabIndex = 11;
            this.notas_check.Text = "notas_check";
            this.notas_check.UseVisualStyleBackColor = true;
            // 
            // guardarllamada_btn
            // 
            this.guardarllamada_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarllamada_btn.Location = new System.Drawing.Point(674, 112);
            this.guardarllamada_btn.Name = "guardarllamada_btn";
            this.guardarllamada_btn.Size = new System.Drawing.Size(112, 44);
            this.guardarllamada_btn.TabIndex = 12;
            this.guardarllamada_btn.Text = "Guardar";
            this.guardarllamada_btn.UseVisualStyleBackColor = true;
            // 
            // refrescar_btn
            // 
            this.refrescar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refrescar_btn.Location = new System.Drawing.Point(12, 401);
            this.refrescar_btn.Name = "refrescar_btn";
            this.refrescar_btn.Size = new System.Drawing.Size(112, 38);
            this.refrescar_btn.TabIndex = 13;
            this.refrescar_btn.Text = "Refrescar";
            this.refrescar_btn.UseVisualStyleBackColor = true;
            this.refrescar_btn.Click += new System.EventHandler(this.refrescar_btn_Click);
            // 
            // fOPROLYD_recepDataSet
            // 
            this.fOPROLYD_recepDataSet.DataSetName = "FOPROLYD_recepDataSet";
            this.fOPROLYD_recepDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // llamadasBindingSource
            // 
            this.llamadasBindingSource.DataMember = "llamadas";
            this.llamadasBindingSource.DataSource = this.fOPROLYD_recepDataSet;
            // 
            // llamadasTableAdapter
            // 
            this.llamadasTableAdapter.ClearBeforeFill = true;
            // 
            // iDllamaDataGridViewTextBoxColumn
            // 
            this.iDllamaDataGridViewTextBoxColumn.DataPropertyName = "ID_llama";
            this.iDllamaDataGridViewTextBoxColumn.HeaderText = "ID_llama";
            this.iDllamaDataGridViewTextBoxColumn.Name = "iDllamaDataGridViewTextBoxColumn";
            this.iDllamaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rubrollamadaDataGridViewTextBoxColumn
            // 
            this.rubrollamadaDataGridViewTextBoxColumn.DataPropertyName = "Rubro_llamada";
            this.rubrollamadaDataGridViewTextBoxColumn.HeaderText = "Rubro_llamada";
            this.rubrollamadaDataGridViewTextBoxColumn.Name = "rubrollamadaDataGridViewTextBoxColumn";
            this.rubrollamadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechallamadaDataGridViewTextBoxColumn
            // 
            this.fechallamadaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_llamada";
            this.fechallamadaDataGridViewTextBoxColumn.HeaderText = "Fecha_llamada";
            this.fechallamadaDataGridViewTextBoxColumn.Name = "fechallamadaDataGridViewTextBoxColumn";
            this.fechallamadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // identificadorDataGridViewTextBoxColumn
            // 
            this.identificadorDataGridViewTextBoxColumn.DataPropertyName = "Identificador";
            this.identificadorDataGridViewTextBoxColumn.HeaderText = "Identificador";
            this.identificadorDataGridViewTextBoxColumn.Name = "identificadorDataGridViewTextBoxColumn";
            this.identificadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notasDataGridViewTextBoxColumn
            // 
            this.notasDataGridViewTextBoxColumn.DataPropertyName = "Notas";
            this.notasDataGridViewTextBoxColumn.HeaderText = "Notas";
            this.notasDataGridViewTextBoxColumn.Name = "notasDataGridViewTextBoxColumn";
            this.notasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recepcion_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.refrescar_btn);
            this.Controls.Add(this.salir_btn);
            this.Controls.Add(this.report_btn);
            this.Controls.Add(this.tabControl1);
            this.Name = "recepcion_form";
            this.Text = "Recepción";
            this.Load += new System.EventHandler(this.recepcion_form_Load);
            this.tabControl1.ResumeLayout(false);
            this.llamadas_tab.ResumeLayout(false);
            this.llamadas_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.llamadas_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOPROLYD_recepDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.llamadasBindingSource)).EndInit();
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
        private System.Windows.Forms.CheckBox notas_check;
        private System.Windows.Forms.DateTimePicker date_picker;
        private System.Windows.Forms.ComboBox categoria_combo;
        private System.Windows.Forms.ComboBox combo_rubro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refrescar_btn;
        private FOPROLYD_recepDataSet fOPROLYD_recepDataSet;
        private System.Windows.Forms.BindingSource llamadasBindingSource;
        private FOPROLYD_recepDataSetTableAdapters.llamadasTableAdapter llamadasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDllamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubrollamadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechallamadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasDataGridViewTextBoxColumn;
    }
}


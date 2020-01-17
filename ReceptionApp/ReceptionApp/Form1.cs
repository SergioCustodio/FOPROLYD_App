using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace ReceptionApp
{
    public partial class recepcion_form : Form
    {
        public recepcion_form()
        {

            InitializeComponent();
            Refresh1();
            RefreshC();
            RefreshA();
            RefreshAtencion();


            DT_audiencias.MinDate = DateTime.Today;
        }

        public string DatabaseString = "Data Source=DESKTOP-T8S12DD;Initial Catalog=FOPROLYD_recep;Integrated Security=True";

        private void refrescar_btn_Click(object sender, EventArgs e)
        {

        }

        private void recepcion_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fOPROLYD_recepDataSet.llamadas' table. You can move, or remove it, as needed.
            this.llamadasTableAdapter.Fill(this.fOPROLYD_recepDataSet.llamadas);

        }

        private void salir_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guardarllamada_btn_Click(object sender, EventArgs e)
        {

            if (combo_rubro.SelectedIndex == -1 || categoria_combo.SelectedIndex == -1)
            {
                MessageBox.Show("Rellene los campos obligatorios..");


            } else {

                String Categoria = categoria_combo.Text;
                int Identificador = 0;

                DateTime FechaHora = DateTime.Now;
                dsFOPROLYDTableAdapters.llamadasTableAdapter TAsave =
                    new dsFOPROLYDTableAdapters.llamadasTableAdapter();

                if (Categoria == "Beneficiarios")
                {
                    Identificador = 6;
                } else if (Categoria == "Proveedores")
                {
                    Identificador = 5;
                } else if (Categoria == "Agencias")
                {
                    Identificador = 4;
                } else if (Categoria == "Insultos")
                {
                    Identificador = 3;
                }
                else if (Categoria == "Personales")
                {
                    Identificador = 2;
                }
                else if (Categoria == "I.Publicas")
                {
                    Identificador = 1;
                }


                TAsave.InsertQ(combo_rubro.Text, FechaHora, Identificador, categoria_combo.Text, notas_txtbox.Text);

                Refresh1();
                LimpiarLlamada();
            }

        }

        private void datetime_Click(object sender, EventArgs e)
        {


            DateTime now = DateTime.Now;
            Console.WriteLine("NOW: " + now);
            Console.WriteLine(categoria_combo.Text);
            Console.WriteLine(combo_rubro.Text);

        }

        private void Refresh1()
        {
            dsFOPROLYDTableAdapters.llamadasTableAdapter tableAddapt =
                new dsFOPROLYDTableAdapters.llamadasTableAdapter();
            dsFOPROLYD.llamadasDataTable TablasdeDatos = tableAddapt.GetData();

            llamadas_datagrid.DataSource = TablasdeDatos;
            llamadas_datagrid.AutoSizeColumnsMode =
    DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void RefreshC()
        {
            dsFOPROLYDTableAdapters.correspondenciasTableAdapter TAC =
                new dsFOPROLYDTableAdapters.correspondenciasTableAdapter();
            dsFOPROLYD.correspondenciasDataTable TDC = TAC.GetDataC();

            dataGridView1.DataSource = TDC;
            dataGridView1.AutoSizeColumnsMode =
    DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void RefreshA()
        {
            dsFOPROLYDTableAdapters.audienciasTableAdapter TAA =
                new dsFOPROLYDTableAdapters.audienciasTableAdapter();
            dsFOPROLYD.audienciasDataTable TDA = TAA.GetDataA();

            Datagrid_audiencia.DataSource = TDA;
            Datagrid_audiencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RefreshAtencion()
        {
            dsFOPROLYDTableAdapters.atencionTableAdapter TAATENCION =
                new dsFOPROLYDTableAdapters.atencionTableAdapter();
            dsFOPROLYD.atencionDataTable TDATENCION = TAATENCION.GetAtencion();

            atencion_datagrid.DataSource = TDATENCION;
            atencion_datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void LimpiarLlamada()
        {
            combo_rubro.SelectedIndex = -1;
            combo_rubro.Text = "Seleccione---";
            categoria_combo.SelectedIndex = -1;
            categoria_combo.Text = "Seleccione---";
            notas_txtbox.Clear();


        }
        private void LimpiarC()
        {
            comboRubroC.SelectedIndex = -1;
            comboRubroC.Text = "Seleccione---";
            NotasC.Clear();
        }
        private void LimpiarA() {
            audiencia_combo.SelectedIndex = -1;
            audiencia_combo.Text = "Seleccione---";
            txt_horaA.Clear();
            txt_beneficiarioName.Clear();
            txt_beneficiarioTel.Clear();
            txt_audienciaCon.Clear();
            txt_notasA.Clear();
            DT_audiencias.Refresh();
        }

        private void LimpiarAtencion()
        {
            c_beneficiario_atencion.SelectedIndex = -1;
            c_beneficiario_atencion.Text = "Seleccione---";
            txt_atencion.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void notas_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveC_btn_Click(object sender, EventArgs e)
        {
            if (comboRubroC.SelectedIndex == -1)
            {
                MessageBox.Show("Complete los campos obligatorios");
            }
            else
            {

                String CategoriaC = comboRubroC.Text;
                int IdentificadorC = 0;

                DateTime FechaHoraC = DateTime.Now;
                dsFOPROLYDTableAdapters.correspondenciasTableAdapter TAsaveC =
                    new dsFOPROLYDTableAdapters.correspondenciasTableAdapter();

                if (CategoriaC == " Cartas Beneficiarios")
                {
                    IdentificadorC = 5;
                }
                else if (CategoriaC == "Cartas Estatales")
                {
                    IdentificadorC = 4;
                }
                else if (CategoriaC == "Doc. ORSAM")
                {
                    IdentificadorC = 3;
                }
                else if (CategoriaC == "Doc. ORCHAL")
                {
                    IdentificadorC = 2;
                }
                else if (CategoriaC == "Cartas Empresa privada")
                {
                    IdentificadorC = 1;
                }

                TAsaveC.InsertQC(comboRubroC.Text, FechaHoraC, IdentificadorC, NotasC.Text);
                RefreshC();
                LimpiarC();
            }
        }

        private void guardarAtencion()
        {

            if ((rb_beneficiario.Checked == false && rb_proveedor.Checked == false) || c_beneficiario_atencion.SelectedIndex == -1)
            {
                MessageBox.Show("Complete los campos obligatorios");
            }
            else
            {
                DateTime fecha_atencion = DateTime.Now;
                dsFOPROLYDTableAdapters.atencionTableAdapter TAsaveAtencion =
                    new dsFOPROLYDTableAdapters.atencionTableAdapter();
                String Tipo_atencion = "";
                if (rb_beneficiario.Checked == true)
                {
                    Tipo_atencion = "Beneficiario";
                }
                else if (rb_proveedor.Checked == true)
                {
                    Tipo_atencion = "Proveedor";
                }
                String Rubro_atencion = c_beneficiario_atencion.Text;
                String obseracion_atencion = txt_atencion.Text;

                TAsaveAtencion.InsertAtencion(Rubro_atencion, Tipo_atencion, obseracion_atencion, fecha_atencion);
                RefreshAtencion();
                LimpiarAtencion();
            }

        }

        private void Refrescar_btn_Click_1(object sender, EventArgs e)
        {
            Refresh();
            RefreshC();
        }

        private void btn_fechaA_Click(object sender, EventArgs e)
        {
            if (audiencia_combo.SelectedIndex == -1 || txt_beneficiarioName.Equals(" ") || txt_horaA.Equals(""))
            {
                MessageBox.Show("Complete los campos obligatorios");


            }
            else
            {

                dsFOPROLYDTableAdapters.audienciasTableAdapter TAsaveA = new
                    dsFOPROLYDTableAdapters.audienciasTableAdapter();
                String IdentificadorA = audiencia_combo.Text;
                int IdentificadorAu = 0;

                //formato de fecha
                DT_audiencias.CustomFormat = "yyyy-MM-dd";
                String FechaDT, HoraA;
                DateTime horasistema = DateTime.Now;


                //fecha datetimepicker
                FechaDT = DT_audiencias.Text;
                HoraA = txt_horaA.Text;

                if (IdentificadorA == "Junta Directiva")
                {
                    IdentificadorAu = 4;
                }
                else if (IdentificadorA == "Presidencia")
                {
                    IdentificadorAu = 3;
                }
                else if (IdentificadorA == "Gerencia")
                {
                    IdentificadorAu = 2;
                }
                else if (IdentificadorA == "Subgerencia")
                {
                    IdentificadorAu = 1;
                }

                TAsaveA.InsertQA(IdentificadorA, horasistema, HoraA, txt_beneficiarioName.Text, txt_beneficiarioTel.Text,
                    txt_audienciaCon.Text, txt_notasA.Text, IdentificadorAu);

                RefreshA();
                LimpiarA();

            }


        }

        private void DT_audiencias_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Exportar_btn_Click(object sender, EventArgs e)
        {
            exportarLlamadas();

        }

        private void exportarLlamadas()
        {
            if (llamadas_datagrid.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application llamadasExport = new
                    Microsoft.Office.Interop.Excel.Application();

                llamadasExport.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < llamadas_datagrid.Columns.Count; i++)
                {
                    //llamadasExport.Cells[1, i] = llamadas_datagrid.Columns[i - 1].HeaderText;
                    llamadasExport.Cells[1, 1] = "ID Llamada";
                    llamadasExport.Cells[1, 2] = "Rubro Llamada";
                    llamadasExport.Cells[1, 3] = "Fecha Llamada";
                    llamadasExport.Cells[1, 4] = "Categoría";
                    llamadasExport.Cells[1, 5] = "Notas";

                }

                for (int j = 0; j < llamadas_datagrid.Rows.Count; j++)
                {
                    for (int k = 0; k < llamadas_datagrid.Columns.Count; k++)
                    {

                        llamadasExport.Cells[j + 2, k + 1] = llamadas_datagrid.Rows[j].Cells[k].Value.ToString();

                    }

                }

                llamadasExport.Columns.AutoFit();
                llamadasExport.Visible = true;

            }

        }

        private void exportarAtencion()
        {
            if (atencion_datagrid.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application  AtencionExport = new
                    Microsoft.Office.Interop.Excel.Application();

                AtencionExport.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < atencion_datagrid.Columns.Count; i++)
                {
                    //llamadasExport.Cells[1, i] = llamadas_datagrid.Columns[i - 1].HeaderText;
                    AtencionExport.Cells[1, 1] = "ID Atencion";
                    AtencionExport.Cells[1, 2] = "Rubro Atención";
                    AtencionExport.Cells[1, 3] = "Fecha Atención";
                    AtencionExport.Cells[1, 4] = "Tipo";
                    AtencionExport.Cells[1, 5] = "Observación";

                }

                for (int j = 0; j < atencion_datagrid.Rows.Count; j++)
                {
                    for (int k = 0; k < atencion_datagrid.Columns.Count; k++)
                    {

                        AtencionExport.Cells[j + 2, k + 1] = atencion_datagrid.Rows[j].Cells[k].Value.ToString();

                    }

                }

                AtencionExport.Columns.AutoFit();
                AtencionExport.Visible = true;

            }

        }

        private void exportarCorrespondencia()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application correspondenciaExport = new
                    Microsoft.Office.Interop.Excel.Application();

                correspondenciaExport.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridView1.Columns.Count; i++)
                {
                    //llamadasExport.Cells[1, i] = llamadas_datagrid.Columns[i - 1].HeaderText;
                    correspondenciaExport.Cells[1, 1] = "ID correspondencia";
                    correspondenciaExport.Cells[1, 2] = "Rubro correspondencia";
                    correspondenciaExport.Cells[1, 3] = "Fecha correspondencia";
                    correspondenciaExport.Cells[1, 4] = "Observaciones";
                    

                }

                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    for (int k = 0; k < dataGridView1.Columns.Count; k++)
                    {

                        correspondenciaExport.Cells[j + 2, k + 1] = dataGridView1.Rows[j].Cells[k].Value.ToString();

                    }

                }

                correspondenciaExport.Columns.AutoFit();
                correspondenciaExport.Visible = true;

            }

        }

        private void exportarAudiencias()
        {
            if (Datagrid_audiencia.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application audienciasExport = new
                    Microsoft.Office.Interop.Excel.Application();

                audienciasExport.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < Datagrid_audiencia.Columns.Count; i++)
                {
                    //llamadasExport.Cells[1, i] = llamadas_datagrid.Columns[i - 1].HeaderText;
                    audienciasExport.Cells[1, 1] = "ID audiencia";
                    audienciasExport.Cells[1, 2] = "Rubro audiencia";
                    audienciasExport.Cells[1, 3] = "Fecha audiencia";
                    audienciasExport.Cells[1, 4] = "Nombre Beneficiario";
                    audienciasExport.Cells[1, 5] = "Teléfono";
                    audienciasExport.Cells[1, 6] = "Audiencia con:";
                    audienciasExport.Cells[1, 7] = "Observaciones";
                    audienciasExport.Cells[1, 8] = "Hora de Audiencia";

                }

                for (int j = 0; j < Datagrid_audiencia.Rows.Count; j++)
                {
                    for (int k = 0; k < Datagrid_audiencia.Columns.Count; k++)
                    {

                        audienciasExport.Cells[j + 2, k + 1] = Datagrid_audiencia.Rows[j].Cells[k].Value.ToString();

                    }

                }

                audienciasExport.Columns.AutoFit();
                audienciasExport.Visible = true;

            }

        }

        private void exportar_correspondencia_Click(object sender, EventArgs e)
        {
            exportarCorrespondencia();
        }

        private void exportar_audiencias_Click(object sender, EventArgs e)
        {
            exportarAudiencias();
        }

        private void atencion_tab_Click(object sender, EventArgs e)
        {
            
        }

        private void guardar_atencion_Click(object sender, EventArgs e)
        {
            guardarAtencion();
        }

        private void rb_proveedor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void exportar_antencion_Click(object sender, EventArgs e)
        {
            exportarAtencion();
        }

       
    }
 }


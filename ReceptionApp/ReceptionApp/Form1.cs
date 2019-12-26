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
            String Categoria=categoria_combo.Text;
            int Identificador=0;

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


            TAsave.InsertQ(combo_rubro.Text,FechaHora,Identificador,categoria_combo.Text,notas_txtbox.Text);

            Refresh();
            LimpiarLlamada();

        }

        private void datetime_Click(object sender, EventArgs e)
        {


            DateTime now = DateTime.Now;
            Console.WriteLine("NOW: " + now);
            Console.WriteLine(categoria_combo.Text);
           Console.WriteLine( combo_rubro.Text);

        }

        private void Refresh1()
        {
            dsFOPROLYDTableAdapters.llamadasTableAdapter tableAddapt =
                new dsFOPROLYDTableAdapters.llamadasTableAdapter();
            dsFOPROLYD.llamadasDataTable TablasdeDatos = tableAddapt.GetData();

            llamadas_datagrid.DataSource = TablasdeDatos;

        }
        private void RefreshC()
        {
            dsFOPROLYDTableAdapters.correspondenciasTableAdapter TAC =
                new dsFOPROLYDTableAdapters.correspondenciasTableAdapter();
            dsFOPROLYD.correspondenciasDataTable TDC = TAC.GetDataC();

            dataGridView1.DataSource = TDC; 

        }
        private void RefreshA()
        {
            dsFOPROLYDTableAdapters.audienciasTableAdapter TAA =
                new dsFOPROLYDTableAdapters.audienciasTableAdapter();
            dsFOPROLYD.audienciasDataTable TDA = TAA.GetDataA();

            Datagrid_audiencia.DataSource = TDA;

        }
        private void LimpiarLlamada()
        {
            combo_rubro.SelectedIndex = -1;
            categoria_combo.SelectedIndex = -1;
            notas_txtbox.Clear();


        }
        private void LimpiarC()
        {
            comboRubroC.SelectedIndex= -1;
            NotasC.Clear();
        }
        private void LimpiarA() {
            audiencia_combo.SelectedIndex = -1;
            txt_horaA.Clear();
            txt_beneficiarioName.Clear();
            txt_beneficiarioTel.Clear();
            txt_audienciaCon.Clear();
            txt_notasA.Clear();
            DT_audiencias.Refresh();
            

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

            TAsaveC.InsertQC(comboRubroC.Text, FechaHoraC, IdentificadorC,NotasC.Text);

            RefreshC();
            LimpiarC();
        }

        private void Refrescar_btn_Click_1(object sender, EventArgs e)
        {
            Refresh();
            RefreshC();
        }

        private void btn_fechaA_Click(object sender, EventArgs e)
        {

            dsFOPROLYDTableAdapters.audienciasTableAdapter TAsaveA = new
                dsFOPROLYDTableAdapters.audienciasTableAdapter();
            String IdentificadorA = audiencia_combo.Text;
            int IdentificadorAu=0;

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
            } else if (IdentificadorA == "Subgerencia")
            {
                IdentificadorAu = 1;
            }

            TAsaveA.InsertQA(IdentificadorA,horasistema,HoraA,txt_beneficiarioName.Text,txt_beneficiarioTel.Text,
                txt_audienciaCon.Text,txt_notasA.Text,IdentificadorAu);

            RefreshA();
            LimpiarA();




        }

        private void DT_audiencias_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

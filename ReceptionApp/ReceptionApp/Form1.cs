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
            Refresh();
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

        }

        private void datetime_Click(object sender, EventArgs e)
        {


            DateTime now = DateTime.Now;
            Console.WriteLine("NOW: " + now);
            Console.WriteLine(categoria_combo.Text);
           Console.WriteLine( combo_rubro.Text);

        }

        private void Refresh()
        {
            dsFOPROLYDTableAdapters.llamadasTableAdapter tableAddapt =
                new dsFOPROLYDTableAdapters.llamadasTableAdapter();
            dsFOPROLYD.llamadasDataTable TablasdeDatos = tableAddapt.GetData();

            llamadas_datagrid.DataSource = TablasdeDatos;

        }
    }
}

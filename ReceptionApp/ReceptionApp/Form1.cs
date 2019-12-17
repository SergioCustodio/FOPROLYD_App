using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceptionApp
{
    public partial class recepcion_form : Form
    {
        public recepcion_form()
        {
            InitializeComponent();
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
    }
}

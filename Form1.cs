using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Salvaqua
{
    public partial class Janela1 : Form
    {
        private SqlConnection cn;
        public Janela1()
        {
            InitializeComponent();
        }

        private void Janela1_Load(object sender, EventArgs e)
        {

        }
        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("Data Source=(localdb)\\RUPIXDB;integrated security=true;initial catalog=Salvaqua;");
        }
        private bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection()) { return; }

            horario.Columns.Clear();
            horario.Rows.Clear();

            // Adicionar coluna para os horários (manhã e tarde)
            horario.Columns.Add("Turno", "M/T");
            horario.Columns.Add("Seg", "Segunda Feira");
            horario.Columns.Add("Ter", "Terça Feira");
            horario.Columns.Add("Qua", "Quarta Feira");
            horario.Columns.Add("Qui", "Quinta Feira");
            horario.Columns.Add("Sex", "Sexta Feira");
            horario.Columns.Add("Sab", "Sabado");
            horario.Columns.Add("Dom", "Domingo");

            horario.Rows.Add("M");
            horario.Rows.Add("T");
        }
    }
}

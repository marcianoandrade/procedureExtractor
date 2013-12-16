using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace procedureExtractor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnExport.Text == "Done!")
            {
                btnExport.Text = "Start Export";
            }
            else
            {
                btnExport.Text = "...";
                btnExport.Enabled = false;
                Task t = Task.Factory.StartNew(() => doExport());
                t.Wait();
                btnExport.Text = "Done!";
                btnExport.Enabled = true;
                btnExport.Focus();
            }
        }

        private void doExport()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexao = new SqlConnection(tbConnectionString.Text))
            {
                string command = "SELECT OBJECT_NAME(object_id), 'DROP PROCEDURE '+OBJECT_NAME(object_id)+'\nGO\n' + OBJECT_DEFINITION(object_id) + 'GO' FROM sys.procedures WHERE OBJECT_NAME(object_id) NOT LIKE 'sp_%' order by OBJECT_NAME(object_id)";
                using (SqlCommand comando = new SqlCommand(command, conexao) { CommandType = CommandType.Text })
                {
                    if (conexao.State != ConnectionState.Open)
                        conexao.Open();

                    dt.Load(comando.ExecuteReader());
                }
            }
            foreach (DataRow item in dt.Rows)
            {
                File.WriteAllText(tbDirectory.Text + "\\" + item[0].ToString() + ".sql", item[1].ToString(), Encoding.UTF8);
            }
        }
    }
}

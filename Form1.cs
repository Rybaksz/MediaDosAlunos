using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MediaAlunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            // Conexão com o banco de dados
            string connectionString = "Data Source=OSA0625246W10-1;Initial Catalog=MediaAlunos;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            // Comando SQL para calcular a média das notas
            string sql = "SELECT IdAluno, Português, Matemática, Geografia, História, Inglês, Ciência, Educação_Física, Artes, AVG(Português+Matemática+Geografia+História+Inglês+Ciência+Educação_Física+Artes)/8 AS MediaGeral FROM NotaAlunos GROUP BY IdAluno, Português, Matemática, Geografia, História, Inglês, Ciência, Educação_Física, Artes";

            // Comando para executar o SQL e preencher o DataTable com os resultados
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Limpa a listbox de alunos
            lstAlunos.Items.Clear();

            // Adiciona os dados à listbox de alunos
            foreach (DataRow row in dataTable.Rows)
            {
                lstAlunos.Items.Add(row["IdAluno"]);
                lstPortugues.Items.Add(row["Português"].ToString());
                lstMatematica.Items.Add(row["Matemática"].ToString());
                lstGeografia.Items.Add(row["Geografia"].ToString());
                lstHistoria.Items.Add(row["História"].ToString());
                lstIngles.Items.Add(row["Inglês"].ToString());
                lstCiencia.Items.Add(row["Ciência"].ToString());
                lstEducacaoFisica.Items.Add(row["Educação_Física"].ToString());
                lstArtes.Items.Add(row["Artes"].ToString());
                lstMediaGeral.Items.Add(row["MediaGeral"].ToString());

            }

        }

        private void lstAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                lstAlunos.SelectedIndex = l.SelectedIndex;
                lstPortugues.SelectedIndex = l.SelectedIndex;
                lstMatematica.SelectedIndex = l.SelectedIndex;
                lstGeografia.SelectedIndex = l.SelectedIndex;
                lstHistoria.SelectedIndex = l.SelectedIndex;
                lstIngles.SelectedIndex = l.SelectedIndex;
                lstCiencia.SelectedIndex = l.SelectedIndex;
                lstEducacaoFisica.SelectedIndex = l.SelectedIndex;
                lstArtes.SelectedIndex = l.SelectedIndex;
                lstMediaGeral.SelectedIndex = l.SelectedIndex;



            }
        }

        private void lstPortugues_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                lstAlunos.SelectedIndex = l.SelectedIndex;
                lstPortugues.SelectedIndex = l.SelectedIndex;
                lstMatematica.SelectedIndex = l.SelectedIndex;
                lstGeografia.SelectedIndex = l.SelectedIndex;
                lstHistoria.SelectedIndex = l.SelectedIndex;
                lstIngles.SelectedIndex = l.SelectedIndex;
                lstCiencia.SelectedIndex = l.SelectedIndex;
                lstEducacaoFisica.SelectedIndex = l.SelectedIndex;
                lstArtes.SelectedIndex = l.SelectedIndex;
                lstMediaGeral.SelectedIndex = l.SelectedIndex;



            }
        }

        private void lstMatematica_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                lstAlunos.SelectedIndex = l.SelectedIndex;
                lstPortugues.SelectedIndex = l.SelectedIndex;
                lstMatematica.SelectedIndex = l.SelectedIndex;
                lstGeografia.SelectedIndex = l.SelectedIndex;
                lstHistoria.SelectedIndex = l.SelectedIndex;
                lstIngles.SelectedIndex = l.SelectedIndex;
                lstCiencia.SelectedIndex = l.SelectedIndex;
                lstEducacaoFisica.SelectedIndex = l.SelectedIndex;
                lstArtes.SelectedIndex = l.SelectedIndex;
                lstMediaGeral.SelectedIndex = l.SelectedIndex;



            }
        }

        private void lstGeografia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                lstAlunos.SelectedIndex = l.SelectedIndex;
                lstPortugues.SelectedIndex = l.SelectedIndex;
                lstMatematica.SelectedIndex = l.SelectedIndex;
                lstGeografia.SelectedIndex = l.SelectedIndex;
                lstHistoria.SelectedIndex = l.SelectedIndex;
                lstIngles.SelectedIndex = l.SelectedIndex;
                lstCiencia.SelectedIndex = l.SelectedIndex;
                lstEducacaoFisica.SelectedIndex = l.SelectedIndex;
                lstArtes.SelectedIndex = l.SelectedIndex;
                lstMediaGeral.SelectedIndex = l.SelectedIndex;



            }
        }

        private void lstHistoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                lstAlunos.SelectedIndex = l.SelectedIndex;
                lstPortugues.SelectedIndex = l.SelectedIndex;
                lstMatematica.SelectedIndex = l.SelectedIndex;
                lstGeografia.SelectedIndex = l.SelectedIndex;
                lstHistoria.SelectedIndex = l.SelectedIndex;
                lstIngles.SelectedIndex = l.SelectedIndex;
                lstCiencia.SelectedIndex = l.SelectedIndex;
                lstEducacaoFisica.SelectedIndex = l.SelectedIndex;
                lstArtes.SelectedIndex = l.SelectedIndex;
                lstMediaGeral.SelectedIndex = l.SelectedIndex;



            }
        }

        private void lstIngles_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                lstAlunos.SelectedIndex = l.SelectedIndex;
                lstPortugues.SelectedIndex = l.SelectedIndex;
                lstMatematica.SelectedIndex = l.SelectedIndex;
                lstGeografia.SelectedIndex = l.SelectedIndex;
                lstHistoria.SelectedIndex = l.SelectedIndex;
                lstIngles.SelectedIndex = l.SelectedIndex;
                lstCiencia.SelectedIndex = l.SelectedIndex;
                lstEducacaoFisica.SelectedIndex = l.SelectedIndex;
                lstArtes.SelectedIndex = l.SelectedIndex;
                lstMediaGeral.SelectedIndex = l.SelectedIndex;



            }
        }

        private void lstCiencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                lstAlunos.SelectedIndex = l.SelectedIndex;
                lstPortugues.SelectedIndex = l.SelectedIndex;
                lstMatematica.SelectedIndex = l.SelectedIndex;
                lstGeografia.SelectedIndex = l.SelectedIndex;
                lstHistoria.SelectedIndex = l.SelectedIndex;
                lstIngles.SelectedIndex = l.SelectedIndex;
                lstCiencia.SelectedIndex = l.SelectedIndex;
                lstEducacaoFisica.SelectedIndex = l.SelectedIndex;
                lstArtes.SelectedIndex = l.SelectedIndex;
                lstMediaGeral.SelectedIndex = l.SelectedIndex;



            }
        }

        private void lstEducacaoFisica_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                lstAlunos.SelectedIndex = l.SelectedIndex;
                lstPortugues.SelectedIndex = l.SelectedIndex;
                lstMatematica.SelectedIndex = l.SelectedIndex;
                lstGeografia.SelectedIndex = l.SelectedIndex;
                lstHistoria.SelectedIndex = l.SelectedIndex;
                lstIngles.SelectedIndex = l.SelectedIndex;
                lstCiencia.SelectedIndex = l.SelectedIndex;
                lstEducacaoFisica.SelectedIndex = l.SelectedIndex;
                lstArtes.SelectedIndex = l.SelectedIndex;
                lstMediaGeral.SelectedIndex = l.SelectedIndex;



            }
        }

        private void lstArtes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                lstAlunos.SelectedIndex = l.SelectedIndex;
                lstPortugues.SelectedIndex = l.SelectedIndex;
                lstMatematica.SelectedIndex = l.SelectedIndex;
                lstGeografia.SelectedIndex = l.SelectedIndex;
                lstHistoria.SelectedIndex = l.SelectedIndex;
                lstIngles.SelectedIndex = l.SelectedIndex;
                lstCiencia.SelectedIndex = l.SelectedIndex;
                lstEducacaoFisica.SelectedIndex = l.SelectedIndex;
                lstArtes.SelectedIndex = l.SelectedIndex;
                lstMediaGeral.SelectedIndex = l.SelectedIndex;



            }
        }

        private void lstMediaGeral_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                lstAlunos.SelectedIndex = l.SelectedIndex;
                lstPortugues.SelectedIndex = l.SelectedIndex;
                lstMatematica.SelectedIndex = l.SelectedIndex;
                lstGeografia.SelectedIndex = l.SelectedIndex;
                lstHistoria.SelectedIndex = l.SelectedIndex;
                lstIngles.SelectedIndex = l.SelectedIndex;
                lstCiencia.SelectedIndex = l.SelectedIndex;
                lstEducacaoFisica.SelectedIndex = l.SelectedIndex;
                lstArtes.SelectedIndex = l.SelectedIndex;
                lstMediaGeral.SelectedIndex = l.SelectedIndex;



            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

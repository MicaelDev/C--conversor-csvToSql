using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ConverterCSVtoSQL
{
    public partial class Form1 : Form
    {
        private string linha;
        private string coordX;
        private string coordY;
        private string diretorioSaida;
        StringBuilder sb = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();

            tbCSV.Text = openFileDialog1.FileName;

            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                StreamReader reader = new(openFileDialog1.FileName, Encoding.UTF8, true);

                while (true)
                {
                    linha = reader.ReadLine();
                    if (linha == null) break;

                    int firstStringPositionX = linha.IndexOf("(-");
                    int firstStringPositionY = linha.IndexOf(" -");

                    coordX = linha.Substring(firstStringPositionY, 18).Remove(0, 1);
                    coordY = linha.Substring(firstStringPositionX, 18).Remove(0, 1);

                    sb.AppendFormat(@"INSERT INTO imob_poste (DESCRICAO, COORDX, COORDY, ANGULO, IDPONTONOTAVEL, " +
                    "IDTPPROP, IDALTURA, IDFORMATO, IDESFORCO, IDMATERIAL, PESO, CARGA, BASE, TOPO, ENERGIZADO) " +
                    "VALUES('Imported on {0}', {1}, {2}, '0', '1', 'C', '11', '1', '81', '2', '0', '0', '0', '0', '0'); \n", DateTime.UtcNow.Date.ToString().Remove(10), coordX, coordY);
                }
            }
        }

        private void btnSQL_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new();
            folderBrowserDialog1.ShowDialog();

            if (!string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
            {
                string fileName = string.Format(@"Pontos importados em {0}.sql", DateTime.UtcNow.Date.ToString().Remove(10).Replace(@"/", ""));

                diretorioSaida = @folderBrowserDialog1.SelectedPath + fileName;
                tbSQL.Text = diretorioSaida;
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbCSV.Text) && !string.IsNullOrWhiteSpace(tbSQL.Text))
            {
                saveFile();
            }
        }

        public void saveFile()
        {
            try
            {
                FileStream fParameter = new FileStream(diretorioSaida, FileMode.Create, FileAccess.ReadWrite);
                StreamWriter m_WriterParameter = new StreamWriter(fParameter);
                m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
                m_WriterParameter.Write(sb.Replace("{", "").Replace("}", ""));
                m_WriterParameter.Flush();
                m_WriterParameter.Close();

                MessageBox.Show("Conversão de dados concluída com sucesso!");

            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro na tentativa de conversão de dados!\n" + e);
            }
        }
    }
}

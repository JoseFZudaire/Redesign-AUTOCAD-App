using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace AUTOCAD_Redesign
{
    public partial class Form1 : Form
    {
        //string explode = "(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")(command\"_explode\"\"all\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"layer\"\"0\"\"\")(command\"_change\"\"all\"\"\"\"properties\"\"Color\"\"Truecolor\"\"255,255,255\"\"\")";
        string explode = "(while (setq sset (ssget \"X\" \'((0 . \"INSERT\")))) (sssetfirst nil sset) (C:Burst)) (princ) (command\"_-purge\"\"B\"\"*\"\"N\")";

        public Form1()
        {
            InitializeComponent();
            InitializeOpenFileDialog();
            saveRoute.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";

                //"C:\\Users\\JZ4874\\Desktop\\";
        }

        private void InitializeOpenFileDialog()
        {
            // Set the file dialog to filter for graphics files.
            this.openFileDialog1.Filter =
                "AUTOCAD files (*.dwg)|*.dwg|" +
                "All files (*.*)|*.*";

            //  Allow the user to select multiple images.
            this.openFileDialog1.Multiselect = true;
            //                   ^  ^  ^  ^  ^  ^  ^

            this.openFileDialog1.Title = "Buscar CADs";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreComando = command.Text;

            int xCoordinate = 0;
            int yCoordinate = 0;

            string[] archivos = nameCADs.Text.Split(';');

            string nroProyecto = ((archivos[0]).Split('\\').Last()).Split('-')[0];
            MessageBox.Show("El nro del proyecto es: " + nroProyecto);

            string comando = "";

            for (int i = 0; i < (archivos.Length - 1); i++)
            {
                string file = archivos[i];

                MessageBox.Show("File archivos name: " + file);

                if (file.Substring(file.Length - 3) == "dwg")
                {
                    string filename = file;
                    string filenameReplaced = filename;
                    char[] caracteresAReemplazar = { 'á', 'é', 'í', 'ó', 'ú', 'Á', 'É', 'Í', 'Ó', 'Ú' };
                    char[] caracteresNuevos = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

                    for (var c = 0; c < caracteresAReemplazar.Length; c++)
                    {
                        filenameReplaced = filenameReplaced.Replace(caracteresAReemplazar[c], caracteresNuevos[c]);
                    }

                    MessageBox.Show("Name of replaced filename: " + filenameReplaced);

                    System.IO.File.Move(filename, filenameReplaced);

                    comando += "(command\"_insert\"\"" + filename + "\"\"scale\"\"1\"\"rotate\"\"0\" \"" + xCoordinate + ',' + yCoordinate + "\" \"1\"\"1\"\"1\"\"0\")";

                    //command += '(command"_insert""' + filename + '""scale""1""rotate""0" "' + xCoordinate + ',' + yCoordinate + ''" "1""1""1""0")';

                    MessageBox.Show("Command is: " + comando);

                    //console.log("Command is: ", command)
                    xCoordinate += 500;
                    if (xCoordinate == 5000) {
                        xCoordinate = 0;
                        yCoordinate -= 380;
                    }

                    comando += explode;
                }
            }

            string commandLine = "(defun c:" + nombreComando + "() " + comando + " )";

            crearArchivoLSP(commandLine, nroProyecto);

            MessageBox.Show("Se ha creado el archivo .lsp en la ruta indicada", "Alerta",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

            Process.Start(saveRoute.Text);
        }

        private void crearArchivoLSP(string commandLine, string nroProyecto) {

            string filePath = saveRoute.Text + nroProyecto + ".lsp";
            File.WriteAllText(filePath, commandLine);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Read the files
                foreach (String file in openFileDialog1.FileNames)
                {
                    nameCADs.Text += file + "; ";
                    MessageBox.Show("Filename: " + file);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Directory.Exists(saveRoute.Text))
            {                
                File.Copy(System.IO.Path.GetFullPath(@"..\..\") + "archivos\\reemplazoCaracteres.bat", saveRoute.Text + "reemplazoCaracteres.bat", true);

                MessageBox.Show("Se ha guardado el archivo en la ruta definida.", "Alerta",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                Process.Start(saveRoute.Text);
            }
            else
            {
                MessageBox.Show("El directorio para guardar los archivos no es válido.", "Alerta",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dummyFileName = "Save Here";

            SaveFileDialog sf = new SaveFileDialog();
            sf.CheckFileExists = false;
            sf.FileName = dummyFileName;
            sf.Filter = "Directory | directory";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                string savePath = Path.GetDirectoryName(sf.FileName);
                saveRoute.Text = savePath + '\\';
            }

            

            //System.Windows.Forms.SaveFileDialog saveFileDialog1;
            //saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            //DialogResult dr = saveFileDialog1.ShowDialog();
            //if (dr == DialogResult.OK)
            //{
            //    string filename = saveFileDialog1.FileName;
            //    //save file using stream.
            //}
        }
    }
}

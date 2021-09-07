
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CreadorDeCarpetas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            labelTitle.Text = "Creador de Carpetas por Franco Mato (Franco28) v" + Application.ProductVersion;
        }

        private string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        private IniFile MyIni = new IniFile();

        #region Engine
        public void consoleA(string message)
        {
            this.Invoke((Action)delegate
            {
                console.Clear();
                console.AppendText("\n " + message);
                console.ScrollToCaret();
            });
        }

        // Creo el archivo de config .ini
        private void CreateINI()
        {
            if (!File.Exists(exePath + @"\CreadorDeCarpetas.ini"))
            {
                consoleA("<CreadorDeCarpetas.ini> creado!");
                MyIni.Write("FolderPath", exePath);
                MyIni.Write("Incluir0", "true");
            }
            else
            {
                if (!MyIni.KeyExists("FolderPath"))
                {
                    consoleA("<CreadorDeCarpetas.ini> creado!");
                    MyIni.Write("FolderPath", exePath);
                    MyIni.Write("Incluir0", "true");
                }
            }
        }

        public void CreateFileWatcher()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = exePath;
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "*.ini";

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            if (e.ChangeType.ToString() == "Changed")
                consoleA("Archivo: {" + e.FullPath + "}  {Actualizado}\n");            

            if (e.ChangeType.ToString() == "Deleted")
            {
                consoleA("Archivo: {" + e.FullPath + "}  {Eliminado}\n");
                CreateINI();
            }
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            consoleA("El archivo: {" + e.OldFullPath + "} se renombro a {" + e.FullPath + "}\n");
        }

        // Creo las carpetas
        private void CreateFolders()
        {
            int cantidadCarpetas;
            string nombreCarpetas;

            try
            {
                cantidadCarpetas = int.Parse(textBoxCantidad.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Solo se admiten numeros enteros!", "Error al leer el numero ingresado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cantidadCarpetas > 20)
            {
                DialogResult dialogResult = MessageBox.Show("Ingreso un total de: " + cantidadCarpetas + " carpetas y esto puede ser MUY PELIGROSO si su PC tiene poca memoria RAM y memoria ROM. Desea continuar?", "CUIDADO! PELIGRO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.No)
                    return;
            }

            consoleA("Parchando textos y numeros...");

            nombreCarpetas = textBoxNombre.Text;
            cantidadCarpetas = int.Parse(textBoxCantidad.Text) + 1;

            consoleA("Parchando textos y numeros... {OK}");

            progressBar.Show();
            progressBar.Maximum = cantidadCarpetas;

            if (rdbNO.Checked == true)
            {
                for (var i = 1; i < cantidadCarpetas; i++)
                {
                    progressBar.Value = i;
                    consoleA("\nCreando carpeta: {" + nombreCarpetas + "}");
                    EvaluatePath(nombreCarpetas + i.ToString());
                    progressBar.Hide();
                }
            }
            else if (rdbSI.Checked == true)
            {
                for (var i = 0; i < cantidadCarpetas; i++)
                {
                    progressBar.Value = i;
                    consoleA("Creando carpeta: {" + nombreCarpetas + "}");
                    EvaluatePath(nombreCarpetas + i.ToString());
                    progressBar.Hide();
                }
            }

            consoleA("Se crearon {" + cantidadCarpetas + "} carpetas con exito en {" + MyIni.Read("FolderPath") + "}");
        }

        // Evaluo la ruta y creo la carpeta
        private String EvaluatePath(String path)
        {
            try
            {
                String folder = Path.GetDirectoryName(path);

                if (!Directory.Exists(folder))
                {
                    DirectoryInfo di = Directory.CreateDirectory(MyIni.Read("FolderPath") + @"\" + path);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("ERROR: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
            return path;
        }
        #endregion Engine

        private void MainForm_Load(object sender, EventArgs e)
        {
            progressBar.Hide();

            CreateINI();

            if (rdbNO.Checked == true)
                MyIni.Write("Incluir0", "false");
            else
                MyIni.Write("Incluir0", "true");

            labelDIR.Text = MyIni.Read("FolderPath");

            CreateFileWatcher();
        }

        private void buttonCrearCarpetas_ClickAsync(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "")
            {
                MessageBox.Show("El casillero Nombre De Las Carpetas no puede estar vacio!", "Casillero Nombre De Las Carpetas vacio!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxCantidad.Text == "")
            {
                MessageBox.Show("El casillero Cantidad De Las Carpetas no puede estar vacio!", "Casillero Cantidad De Las Carpetas vacio!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create folders
            CreateFolders();
        }      

        private void buttonCambiarCarpeta_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                folderDlg.ShowNewFolderButton = true;

                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MyIni.Write("FolderPath", folderDlg.SelectedPath);
                    consoleA("Directorio Actual: " + MyIni.Read("FolderPath"));
                } 
                else
                {
                    MyIni.Write("FolderPath", exePath);
                    return;
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("ERROR: " + ex, "Error al abrir directorio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;         
        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCantidad.Text == "")
            {
                return;
            }
            else
            {
                int cantidadCarpetas = int.Parse(textBoxCantidad.Text);
                if (cantidadCarpetas > 20)
                    textBoxCantidad.BackColor = Color.Red;
                else
                    textBoxCantidad.BackColor = Color.Black;
            }
        }

        private void rdbSI_CheckedChanged(object sender, EventArgs e)
        {
            MyIni.Write("Incluir0", "true");
        }

        private void rdbNO_CheckedChanged(object sender, EventArgs e)
        {
            MyIni.Write("Incluir0", "false");
        }

        private void buttonGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Franco28");
        }

        private void buttonTelegram_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/francom28");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            console.Clear();
        }

        private void buttonOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(MyIni.Read("FolderPath"));
        }
    }
}
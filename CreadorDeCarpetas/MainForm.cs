
using System;
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
        }

        private string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        public void consoleA(string message)
        {
            this.Invoke((Action)delegate
            {
                console.AppendText("\n" + message);
                console.ScrollToCaret();
            });
        }

        private IniFile MyIni = new IniFile();

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
            consoleA("\nEl archivo: {" + e.FullPath + "}  {" + e.ChangeType + "}\n");

            if (e.ChangeType.ToString() == "Deleted")
            {
                CreateINI();
            }
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            consoleA("\nEl archivo: {" + e.OldFullPath + "} se renombro a {"+ e.FullPath + "}\n");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            progressBar.Hide();

            CreateINI();
            CreateFileWatcher();

            if (rdbNO.Checked == true)
                MyIni.Write("Incluir0", "false");
            else
                MyIni.Write("Incluir0", "true");

            consoleA("\nDirectorio Actual: " + MyIni.Read("FolderPath") + "\n");
        }

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

            console.Clear();

            consoleA("\nParchando textos y numeros...");

            nombreCarpetas = textBoxNombre.Text;
            cantidadCarpetas = int.Parse(textBoxCantidad.Text) + 1;

            consoleA("\nParchando textos y numeros... {OK}");

            progressBar.Show();
            progressBar.Maximum = cantidadCarpetas;

            if (rdbNO.Checked == true)
            {
                for (var i = 1; i < cantidadCarpetas; i++)
                {
                    progressBar.Value = i;
                    consoleA("\nCreando carpeta: {" + nombreCarpetas + "}");
                    EvaluatePath(nombreCarpetas + i.ToString());
                    console.Clear();
                    progressBar.Hide();
                }
            }
            else if (rdbSI.Checked == true)
            {
                for (var i = 0; i < cantidadCarpetas; i++)
                {
                    progressBar.Value = i;
                    consoleA("\nCreando carpeta: {" + nombreCarpetas + "}");
                    EvaluatePath(nombreCarpetas + i.ToString());
                    console.Clear();
                    progressBar.Hide();
                }
            }

            consoleA("\nSe crearon {" + cantidadCarpetas + "} carpetas con exito en {" + MyIni.Read("FolderPath") + "}");
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
                    console.Clear();
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
            console.Clear();
        }

        private void rdbNO_CheckedChanged(object sender, EventArgs e)
        {
            MyIni.Write("Incluir0", "false");
            console.Clear();
        }
    }
}
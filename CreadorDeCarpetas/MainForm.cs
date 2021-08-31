
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
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            consoleA("\nEl archivo: {" + e.OldFullPath + "} se renombro a {"+ e.FullPath + "}\n");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            progressBar.Hide();
            CreateFileWatcher();
            var MyIni = new IniFile();
            MyIni.Write("FolderPath", exePath);
            consoleA("\nDirectorio Actual: " + MyIni.Read("FolderPath") + "\n");
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

            for (var i = 0; i < cantidadCarpetas; i++)
            {
                progressBar.Value = i;
                consoleA("\nCreando carpeta: {" + nombreCarpetas + "}");
                EvaluatePath(nombreCarpetas + i.ToString());
                console.Clear();
                progressBar.Hide();
            }

            var MyIni = new IniFile();
            consoleA("\nSe crearon {" + cantidadCarpetas + "} carpetas con exito en {" + MyIni.Read("FolderPath") + "}");
        }

        private String EvaluatePath(String path)
        {
            try
            {
                var MyIni = new IniFile();
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
                    var MyIni = new IniFile();
                    MyIni.Write("FolderPath", folderDlg.SelectedPath);
                    console.Clear();
                    consoleA("Directorio Actual: " + MyIni.Read("FolderPath"));
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
    }
}
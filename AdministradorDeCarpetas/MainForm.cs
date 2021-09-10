
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AdministradorDeCarpetas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            labelTitle.Text = "Administrador De Carpetas por Franco Mato (Franco28) v" + Application.ProductVersion;
        }

        private string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        // Ajustes .ini
        private IniFile MyIni = new IniFile("Ajustes.ini");

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
            if (!File.Exists(exePath + @"\Ajustes.ini"))
            {
                consoleA("<Ajustes.ini>: {Creado}");
                MyIni.Write("FolderPath", exePath);
                MyIni.Write("Incluir0", "true");
                MyIni.Write("CRandom", "false");
                MyIni.Write("Cifrado", "false");
            }
            else
            {
                if (!MyIni.KeyExists("FolderPath") || !MyIni.KeyExists("Incluir0") || !MyIni.KeyExists("CRandom"))
                {
                    consoleA("<Ajustes.ini>: {Actualizado}");
                    MyIni.Write("FolderPath", exePath);
                    MyIni.Write("Incluir0", "true");
                    MyIni.Write("CRandom", "false");
                    MyIni.Write("Cifrado", "false");
                }
            }
        }

        public void CreateFileWatcher()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = exePath;
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "Ajustes.ini";

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

            cantidadCarpetas = int.Parse(textBoxCantidad.Text);
            nombreCarpetas = NormalizeDirName(textBoxNombre.Text);

            consoleA("Parchando textos y numeros... {OK}");

            progressBar.Show();
            progressBar.Maximum = cantidadCarpetas;

            Random rnd = new Random();

            if (rdbNO.Checked == true)
            {
                for (var i = 1; i < cantidadCarpetas; i++)
                {
                    progressBar.Value = i;
                    consoleA("\nCreando carpeta: {" + nombreCarpetas + "}");

                    if (rdbRandomSI.Checked == true)
                        EvaluatePath(GenerateName(rnd, i));
                    else
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

                    if (rdbRandomSI.Checked == true)
                        EvaluatePath(GenerateName(rnd, i));
                    else
                        EvaluatePath(nombreCarpetas + i.ToString());

                    progressBar.Hide();
                }
            }

            consoleA("Se crearon {" + cantidadCarpetas + "} carpetas con exito en {" + MyIni.Read("FolderPath") + "}");
        }

        // Carpetas con nombres random
        private string GenerateName(Random random, int length)
        {
            const string ValidChars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = ValidChars[random.Next(ValidChars.Length)];
            }
            return new string(chars);
        }

        // Evaluo la ruta y creo la carpeta
        private string EvaluatePath(String path)
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

        // Arreglo el nombre de las carpetas
        private string NormalizeDirName(string dirName)
        {
            try
            {
                string invalidChars = Regex.Escape(new string(Path.GetInvalidPathChars()));
                string invalidRegStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);

                return Regex.Replace(dirName, invalidRegStr, "_");
            }
            catch (Exception er)
            {
                consoleA("\nCreando carpeta: { ERROR }");
                MessageBox.Show("Error al parchar el nombre de la carpeta: " + er.ToString(), "Error al parchar carpeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return er.ToString();
            }
        }
        #endregion Engine

        private void MainForm_Load(object sender, EventArgs e)
        {
            // https://www.iconfinder.com/search?q=cryptography&price=free
            progressBar.Hide();

            CreateINI();

            if (MyIni.KeyExists("CCifrada"))
                txtBoxPassword.Text = MyIni.Read("CCifrada");

            if (MyIni.Read("Incluir0") == "true")
                rdbSI.Checked = true;
            else
                rdbNO.Checked = true;

            if (MyIni.Read("CRandom") == "true")
                rdbRandomSI.Checked = true;
            else
                rdbRandomNO.Checked = true;

            if (MyIni.Read("Cifrar") == "true")
                rdbCifrarSI.Checked = true;
            else
                rdbCifrarNO.Checked = true;

            if (rdbNO.Checked == true)
                MyIni.Write("Incluir0", "false");
            else
                MyIni.Write("Incluir0", "true");

            if (rdbRandomNO.Checked == true)
                MyIni.Write("CRandom", "false");
            else
                MyIni.Write("CRandom", "true");

            if (rdbCifrarNO.Checked == true)
                MyIni.Write("Cifrado", "false");
            else
                MyIni.Write("Cifrado", "true");

            labelDIR.Text = MyIni.Read("FolderPath");

            CreateFileWatcher();
        }

        private void buttonCrearCarpetas_ClickAsync(object sender, EventArgs e)
        {
            if (rdbRandomNO.Checked == true)
            {
                if (textBoxNombre.Text == "")
                {
                    MessageBox.Show("El casillero Nombre De Las Carpetas no puede estar vacio!", "Casillero Nombre De Las Carpetas vacio!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
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

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "")
            {
                labelCharError.Text = "";
                textBoxNombre.BackColor = Color.Black;
                return;
            } 
            else
            {
                if (textBoxNombre.Text.Contains("<") || textBoxNombre.Text.Contains(">") || textBoxNombre.Text.Contains(@"\") || textBoxNombre.Text.Contains("/") || textBoxNombre.Text.Contains(":") || textBoxNombre.Text.Contains("*") || textBoxNombre.Text.Contains("?") || textBoxNombre.Text.Contains("|") || textBoxNombre.Text.Contains('"'))
                {
                    labelCharError.Text = @"El nombre de la carpeta no puede incluir \ / : * ? < > |";
                    textBoxNombre.BackColor = Color.Red;
                }
                else
                {
                    labelCharError.Text = "";
                    textBoxNombre.BackColor = Color.Black;
                }
            }
        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCantidad.Text == "")
            {
                textBoxNombre.BackColor = Color.Black;
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

        private void rdbRandomSI_CheckedChanged(object sender, EventArgs e)
        {
            MyIni.Write("CRandom", "true");
        }

        private void rdbRandomNO_CheckedChanged(object sender, EventArgs e)
        {
            MyIni.Write("CRandom", "false");
        }

        private void rdbCifrarSI_CheckedChanged(object sender, EventArgs e)
        {
            MyIni.Write("Cifrado", "true");
        }

        private void rdbCifrarNO_CheckedChanged(object sender, EventArgs e)
        {
            MyIni.Write("Cifrado", "false");
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Process.GetCurrentProcess().Kill();
                Application.Exit();
            } 
            catch (Exception er)
            {
                MessageBox.Show("Error al cerrar el programa: " + er.ToString(), "Error al cerrar el programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private string RandomPwd(Random random, int length)
        {
            const string ValidChars = "0123456789AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz?!¿*´{.-_<>%&/#";
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = ValidChars[random.Next(ValidChars.Length)];
            }
            return new string(chars);
        }

        private void buttonGenerarRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            txtBoxPassword.Text = RandomPwd(rnd, 15);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (txtBoxPassword.Text == string.Empty)
                return;

            if (txtBoxPWSCifradro.Text == string.Empty)
            {
                MessageBox.Show("Ingrese una contraseña para el cifrado!");
                return;
            }

            MyIni.Write("CCifrada", EncryptString.StringCipher.Encrypt(txtBoxPassword.Text, txtBoxPWSCifradro.Text));

            txtBoxPWSCifradro.Text = "";
            txtBoxPassword.Text = "";
        }

        private void buttonDescifrar_Click(object sender, EventArgs e)
        {
            if (txtBoxPWSCifradro.Text == string.Empty)
            {
                MessageBox.Show("Ingrese la contraseña que uso para el cifrado!");
                return;
            }

            string decryptedstring = EncryptString.StringCipher.Decrypt(txtBoxPassword.Text, txtBoxPWSCifradro.Text);

            txtBoxPassword.Text = decryptedstring;
        }
    }
}

namespace CreadorDeCarpetas
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonCrearCarpetas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.console = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox0 = new System.Windows.Forms.GroupBox();
            this.rdbNO = new System.Windows.Forms.RadioButton();
            this.rdbSI = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDIR = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonGitHub = new System.Windows.Forms.Button();
            this.buttonTelegram = new System.Windows.Forms.Button();
            this.buttonCambiarCarpeta = new System.Windows.Forms.Button();
            this.labelIcon = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbRandomNO = new System.Windows.Forms.RadioButton();
            this.rdbRandomSI = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelCharError = new System.Windows.Forms.Label();
            this.groupBox0.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBoxNombre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.Color.White;
            this.textBoxNombre.Location = new System.Drawing.Point(11, 431);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNombre.MaxLength = 20;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(377, 30);
            this.textBoxNombre.TabIndex = 0;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // buttonCrearCarpetas
            // 
            this.buttonCrearCarpetas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrearCarpetas.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonCrearCarpetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearCarpetas.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearCarpetas.Location = new System.Drawing.Point(13, 566);
            this.buttonCrearCarpetas.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCrearCarpetas.Name = "buttonCrearCarpetas";
            this.buttonCrearCarpetas.Size = new System.Drawing.Size(375, 46);
            this.buttonCrearCarpetas.TabIndex = 2;
            this.buttonCrearCarpetas.Text = "Crear Carpetas";
            this.buttonCrearCarpetas.UseVisualStyleBackColor = true;
            this.buttonCrearCarpetas.Click += new System.EventHandler(this.buttonCrearCarpetas_ClickAsync);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 389);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese el nombre de las carpetas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 474);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(379, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ingrese la cantidad de carpetas a crear";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBoxCantidad.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.ForeColor = System.Drawing.Color.White;
            this.textBoxCantidad.Location = new System.Drawing.Point(13, 508);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCantidad.MaxLength = 2;
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(375, 30);
            this.textBoxCantidad.TabIndex = 1;
            this.textBoxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCantidad.TextChanged += new System.EventHandler(this.textBoxCantidad_TextChanged);
            this.textBoxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantidad_KeyPress);
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.Color.Black;
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.console.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.ForeColor = System.Drawing.Color.Yellow;
            this.console.Location = new System.Drawing.Point(85, 218);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(560, 94);
            this.console.TabIndex = 10;
            this.console.Text = "";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Black;
            this.progressBar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar.Location = new System.Drawing.Point(13, 548);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(375, 10);
            this.progressBar.TabIndex = 11;
            // 
            // groupBox0
            // 
            this.groupBox0.Controls.Add(this.rdbNO);
            this.groupBox0.Controls.Add(this.rdbSI);
            this.groupBox0.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox0.ForeColor = System.Drawing.Color.White;
            this.groupBox0.Location = new System.Drawing.Point(446, 387);
            this.groupBox0.Name = "groupBox0";
            this.groupBox0.Size = new System.Drawing.Size(197, 39);
            this.groupBox0.TabIndex = 12;
            this.groupBox0.TabStop = false;
            this.groupBox0.Text = "Incluir 0?";
            // 
            // rdbNO
            // 
            this.rdbNO.AutoSize = true;
            this.rdbNO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbNO.Location = new System.Drawing.Point(46, 14);
            this.rdbNO.Name = "rdbNO";
            this.rdbNO.Size = new System.Drawing.Size(47, 20);
            this.rdbNO.TabIndex = 1;
            this.rdbNO.Text = "NO";
            this.rdbNO.UseVisualStyleBackColor = true;
            this.rdbNO.CheckedChanged += new System.EventHandler(this.rdbNO_CheckedChanged);
            // 
            // rdbSI
            // 
            this.rdbSI.AutoSize = true;
            this.rdbSI.Checked = true;
            this.rdbSI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbSI.Location = new System.Drawing.Point(6, 14);
            this.rdbSI.Name = "rdbSI";
            this.rdbSI.Size = new System.Drawing.Size(37, 20);
            this.rdbSI.TabIndex = 0;
            this.rdbSI.TabStop = true;
            this.rdbSI.Text = "SI";
            this.rdbSI.UseVisualStyleBackColor = true;
            this.rdbSI.CheckedChanged += new System.EventHandler(this.rdbSI_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(443, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cambiar Directorio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(468, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Configuraciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(38, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Carpetas a crear";
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(92, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(553, 54);
            this.labelTitle.TabIndex = 19;
            this.labelTitle.Text = "---";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(93, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Informacion";
            // 
            // labelDIR
            // 
            this.labelDIR.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDIR.Location = new System.Drawing.Point(97, 121);
            this.labelDIR.Name = "labelDIR";
            this.labelDIR.Size = new System.Drawing.Size(497, 77);
            this.labelDIR.TabIndex = 21;
            this.labelDIR.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(94, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Directorio Actual: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(81, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Consola";
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFolder.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonOpenFolder.FlatAppearance.BorderSize = 0;
            this.buttonOpenFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.buttonOpenFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.buttonOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFolder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFolder.Image")));
            this.buttonOpenFolder.Location = new System.Drawing.Point(598, 125);
            this.buttonOpenFolder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(47, 73);
            this.buttonOpenFolder.TabIndex = 24;
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            this.buttonOpenFolder.Click += new System.EventHandler(this.buttonOpenFolder_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Image = global::CreadorDeCarpetas.Properties.Resources.clean;
            this.buttonClear.Location = new System.Drawing.Point(11, 218);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(69, 94);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonGitHub
            // 
            this.buttonGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGitHub.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonGitHub.FlatAppearance.BorderSize = 0;
            this.buttonGitHub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.buttonGitHub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.buttonGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGitHub.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGitHub.Image = global::CreadorDeCarpetas.Properties.Resources.git;
            this.buttonGitHub.Location = new System.Drawing.Point(11, 125);
            this.buttonGitHub.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGitHub.Name = "buttonGitHub";
            this.buttonGitHub.Size = new System.Drawing.Size(69, 55);
            this.buttonGitHub.TabIndex = 15;
            this.buttonGitHub.UseVisualStyleBackColor = true;
            this.buttonGitHub.Click += new System.EventHandler(this.buttonGitHub_Click);
            // 
            // buttonTelegram
            // 
            this.buttonTelegram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTelegram.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonTelegram.FlatAppearance.BorderSize = 0;
            this.buttonTelegram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.buttonTelegram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.buttonTelegram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTelegram.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTelegram.Image = global::CreadorDeCarpetas.Properties.Resources.telegram;
            this.buttonTelegram.Location = new System.Drawing.Point(11, 66);
            this.buttonTelegram.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTelegram.Name = "buttonTelegram";
            this.buttonTelegram.Size = new System.Drawing.Size(69, 55);
            this.buttonTelegram.TabIndex = 14;
            this.buttonTelegram.UseVisualStyleBackColor = true;
            this.buttonTelegram.Click += new System.EventHandler(this.buttonTelegram_Click);
            // 
            // buttonCambiarCarpeta
            // 
            this.buttonCambiarCarpeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCambiarCarpeta.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonCambiarCarpeta.FlatAppearance.BorderSize = 0;
            this.buttonCambiarCarpeta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.buttonCambiarCarpeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.buttonCambiarCarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCambiarCarpeta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCambiarCarpeta.Image = ((System.Drawing.Image)(resources.GetObject("buttonCambiarCarpeta.Image")));
            this.buttonCambiarCarpeta.Location = new System.Drawing.Point(472, 548);
            this.buttonCambiarCarpeta.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCambiarCarpeta.Name = "buttonCambiarCarpeta";
            this.buttonCambiarCarpeta.Size = new System.Drawing.Size(59, 51);
            this.buttonCambiarCarpeta.TabIndex = 9;
            this.buttonCambiarCarpeta.UseVisualStyleBackColor = true;
            this.buttonCambiarCarpeta.Click += new System.EventHandler(this.buttonCambiarCarpeta_Click);
            // 
            // labelIcon
            // 
            this.labelIcon.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIcon.Image = global::CreadorDeCarpetas.Properties.Resources.iconFolder;
            this.labelIcon.Location = new System.Drawing.Point(6, 9);
            this.labelIcon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIcon.Name = "labelIcon";
            this.labelIcon.Size = new System.Drawing.Size(81, 55);
            this.labelIcon.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(441, 312);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 26);
            this.label9.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbRandomNO);
            this.groupBox1.Controls.Add(this.rdbRandomSI);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(446, 473);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 39);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear nombres RANDOM?";
            // 
            // rdbRandomNO
            // 
            this.rdbRandomNO.AutoSize = true;
            this.rdbRandomNO.Checked = true;
            this.rdbRandomNO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbRandomNO.Location = new System.Drawing.Point(46, 14);
            this.rdbRandomNO.Name = "rdbRandomNO";
            this.rdbRandomNO.Size = new System.Drawing.Size(47, 20);
            this.rdbRandomNO.TabIndex = 1;
            this.rdbRandomNO.TabStop = true;
            this.rdbRandomNO.Text = "NO";
            this.rdbRandomNO.UseVisualStyleBackColor = true;
            this.rdbRandomNO.CheckedChanged += new System.EventHandler(this.rdbRandomNO_CheckedChanged);
            // 
            // rdbRandomSI
            // 
            this.rdbRandomSI.AutoSize = true;
            this.rdbRandomSI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbRandomSI.Location = new System.Drawing.Point(6, 14);
            this.rdbRandomSI.Name = "rdbRandomSI";
            this.rdbRandomSI.Size = new System.Drawing.Size(37, 20);
            this.rdbRandomSI.TabIndex = 0;
            this.rdbRandomSI.Text = "SI";
            this.rdbRandomSI.UseVisualStyleBackColor = true;
            this.rdbRandomSI.CheckedChanged += new System.EventHandler(this.rdbRandomSI_CheckedChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(446, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 37);
            this.label10.TabIndex = 27;
            this.label10.Text = "* Incluye el numero 0 a las carpetas es decir, 0,1,2....";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(11, 354);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 26);
            this.label11.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(446, 431);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 39);
            this.label12.TabIndex = 29;
            this.label12.Text = "* Crea carpetas con nombres RANDOM";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelCharError
            // 
            this.labelCharError.AutoSize = true;
            this.labelCharError.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharError.ForeColor = System.Drawing.Color.Red;
            this.labelCharError.Location = new System.Drawing.Point(15, 413);
            this.labelCharError.Name = "labelCharError";
            this.labelCharError.Size = new System.Drawing.Size(0, 15);
            this.labelCharError.TabIndex = 30;
            this.labelCharError.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(650, 620);
            this.Controls.Add(this.labelCharError);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonOpenFolder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelDIR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonGitHub);
            this.Controls.Add(this.buttonTelegram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox0);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.console);
            this.Controls.Add(this.buttonCambiarCarpeta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelIcon);
            this.Controls.Add(this.buttonCrearCarpetas);
            this.Controls.Add(this.textBoxNombre);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creador de Carpetas Por Franco Mato (Franco28)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox0.ResumeLayout(false);
            this.groupBox0.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonCrearCarpetas;
        private System.Windows.Forms.Label labelIcon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Button buttonCambiarCarpeta;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox0;
        private System.Windows.Forms.RadioButton rdbNO;
        private System.Windows.Forms.RadioButton rdbSI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTelegram;
        private System.Windows.Forms.Button buttonGitHub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDIR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbRandomNO;
        private System.Windows.Forms.RadioButton rdbRandomSI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelCharError;
    }
}


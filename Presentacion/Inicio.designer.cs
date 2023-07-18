
namespace Presentacion
{
    partial class form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form2));
            this.PanelMenu = new Guna.UI.WinForms.GunaPanel();
            this.btnPartidos = new FontAwesome.Sharp.IconButton();
            this.btnEntrenador = new FontAwesome.Sharp.IconButton();
            this.btnFinanzas = new FontAwesome.Sharp.IconButton();
            this.btnJugadores = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new Guna.UI.WinForms.GunaPanel();
            this.btnInicio = new Guna.UI.WinForms.GunaPictureBox();
            this.PanelTitulo = new Guna.UI.WinForms.GunaPanel();
            this.lblTituloForms = new System.Windows.Forms.Label();
            this.btnAtras2 = new FontAwesome.Sharp.IconButton();
            this.IconoFormTitulo = new FontAwesome.Sharp.IconPictureBox();
            this.GrupoListaJugadores = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.list_Jugadores = new System.Windows.Forms.ListBox();
            this.GrupoAgregarJugador = new Guna.UI.WinForms.GunaGroupBox();
            this.btnBorrar = new Guna.UI.WinForms.GunaButton();
            this.btnAgregar = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtNacionalidad = new Guna.UI.WinForms.GunaTextBox();
            this.txtPosicion = new Guna.UI.WinForms.GunaComboBox();
            this.FechaNacimiento = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txtApellido = new Guna.UI.WinForms.GunaTextBox();
            this.txtNombre = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.labelNombre = new Guna.UI.WinForms.GunaLabel();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.PanelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoFormTitulo)).BeginInit();
            this.GrupoListaJugadores.SuspendLayout();
            this.GrupoAgregarJugador.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(105)))), ((int)(((byte)(153)))));
            this.PanelMenu.Controls.Add(this.btnSalir);
            this.PanelMenu.Controls.Add(this.btnPartidos);
            this.PanelMenu.Controls.Add(this.btnEntrenador);
            this.PanelMenu.Controls.Add(this.btnFinanzas);
            this.PanelMenu.Controls.Add(this.btnJugadores);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(205, 611);
            this.PanelMenu.TabIndex = 0;
            // 
            // btnPartidos
            // 
            this.btnPartidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPartidos.FlatAppearance.BorderSize = 0;
            this.btnPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartidos.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartidos.ForeColor = System.Drawing.Color.White;
            this.btnPartidos.IconChar = FontAwesome.Sharp.IconChar.SoccerBall;
            this.btnPartidos.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnPartidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPartidos.IconSize = 40;
            this.btnPartidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPartidos.Location = new System.Drawing.Point(0, 234);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPartidos.Size = new System.Drawing.Size(205, 53);
            this.btnPartidos.TabIndex = 3;
            this.btnPartidos.Text = "Partidos";
            this.btnPartidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPartidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPartidos.UseVisualStyleBackColor = true;
            // 
            // btnEntrenador
            // 
            this.btnEntrenador.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntrenador.FlatAppearance.BorderSize = 0;
            this.btnEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrenador.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrenador.ForeColor = System.Drawing.Color.White;
            this.btnEntrenador.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnEntrenador.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnEntrenador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEntrenador.IconSize = 40;
            this.btnEntrenador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrenador.Location = new System.Drawing.Point(0, 181);
            this.btnEntrenador.Name = "btnEntrenador";
            this.btnEntrenador.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEntrenador.Size = new System.Drawing.Size(205, 53);
            this.btnEntrenador.TabIndex = 2;
            this.btnEntrenador.Text = "Entrenadores";
            this.btnEntrenador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrenador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntrenador.UseVisualStyleBackColor = true;
            // 
            // btnFinanzas
            // 
            this.btnFinanzas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinanzas.FlatAppearance.BorderSize = 0;
            this.btnFinanzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanzas.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanzas.ForeColor = System.Drawing.Color.White;
            this.btnFinanzas.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btnFinanzas.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnFinanzas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFinanzas.IconSize = 40;
            this.btnFinanzas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanzas.Location = new System.Drawing.Point(0, 128);
            this.btnFinanzas.Name = "btnFinanzas";
            this.btnFinanzas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFinanzas.Size = new System.Drawing.Size(205, 53);
            this.btnFinanzas.TabIndex = 1;
            this.btnFinanzas.Text = "Finanzas";
            this.btnFinanzas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanzas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinanzas.UseVisualStyleBackColor = true;
            // 
            // btnJugadores
            // 
            this.btnJugadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJugadores.FlatAppearance.BorderSize = 0;
            this.btnJugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugadores.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugadores.ForeColor = System.Drawing.Color.White;
            this.btnJugadores.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnJugadores.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnJugadores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnJugadores.IconSize = 40;
            this.btnJugadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJugadores.Location = new System.Drawing.Point(0, 75);
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnJugadores.Size = new System.Drawing.Size(205, 53);
            this.btnJugadores.TabIndex = 0;
            this.btnJugadores.Text = "Jugadores";
            this.btnJugadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJugadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJugadores.UseVisualStyleBackColor = true;
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.btnInicio);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(205, 75);
            this.PanelLogo.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.BaseColor = System.Drawing.Color.White;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(189, 75);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(105)))), ((int)(((byte)(153)))));
            this.PanelTitulo.Controls.Add(this.lblTituloForms);
            this.PanelTitulo.Controls.Add(this.btnAtras2);
            this.PanelTitulo.Controls.Add(this.IconoFormTitulo);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(205, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(1179, 75);
            this.PanelTitulo.TabIndex = 1;
            // 
            // lblTituloForms
            // 
            this.lblTituloForms.AutoSize = true;
            this.lblTituloForms.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForms.ForeColor = System.Drawing.Color.White;
            this.lblTituloForms.Location = new System.Drawing.Point(45, 9);
            this.lblTituloForms.Name = "lblTituloForms";
            this.lblTituloForms.Size = new System.Drawing.Size(59, 23);
            this.lblTituloForms.TabIndex = 7;
            this.lblTituloForms.Text = "Home";
            // 
            // btnAtras2
            // 
            this.btnAtras2.FlatAppearance.BorderSize = 0;
            this.btnAtras2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras2.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAtras2.IconChar = FontAwesome.Sharp.IconChar.CircleChevronLeft;
            this.btnAtras2.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnAtras2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAtras2.IconSize = 20;
            this.btnAtras2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras2.Location = new System.Drawing.Point(0, 45);
            this.btnAtras2.Name = "btnAtras2";
            this.btnAtras2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAtras2.Size = new System.Drawing.Size(68, 27);
            this.btnAtras2.TabIndex = 6;
            this.btnAtras2.Text = "Atrás";
            this.btnAtras2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtras2.UseVisualStyleBackColor = true;
            // 
            // IconoFormTitulo
            // 
            this.IconoFormTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(105)))), ((int)(((byte)(153)))));
            this.IconoFormTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IconoFormTitulo.IconChar = FontAwesome.Sharp.IconChar.House;
            this.IconoFormTitulo.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.IconoFormTitulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconoFormTitulo.IconSize = 33;
            this.IconoFormTitulo.Location = new System.Drawing.Point(6, 3);
            this.IconoFormTitulo.Name = "IconoFormTitulo";
            this.IconoFormTitulo.Size = new System.Drawing.Size(33, 36);
            this.IconoFormTitulo.TabIndex = 0;
            this.IconoFormTitulo.TabStop = false;
            // 
            // GrupoListaJugadores
            // 
            this.GrupoListaJugadores.BackColor = System.Drawing.Color.White;
            this.GrupoListaJugadores.BaseColor = System.Drawing.Color.White;
            this.GrupoListaJugadores.BorderColor = System.Drawing.Color.White;
            this.GrupoListaJugadores.Controls.Add(this.gunaLabel6);
            this.GrupoListaJugadores.Controls.Add(this.list_Jugadores);
            this.GrupoListaJugadores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GrupoListaJugadores.LineColor = System.Drawing.Color.Transparent;
            this.GrupoListaJugadores.Location = new System.Drawing.Point(213, 79);
            this.GrupoListaJugadores.Name = "GrupoListaJugadores";
            this.GrupoListaJugadores.Size = new System.Drawing.Size(590, 473);
            this.GrupoListaJugadores.TabIndex = 2;
            this.GrupoListaJugadores.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(3, 7);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(140, 23);
            this.gunaLabel6.TabIndex = 13;
            this.gunaLabel6.Text = "Lista Jugadores:";
            // 
            // list_Jugadores
            // 
            this.list_Jugadores.ForeColor = System.Drawing.Color.White;
            this.list_Jugadores.FormattingEnabled = true;
            this.list_Jugadores.Location = new System.Drawing.Point(0, 33);
            this.list_Jugadores.Name = "list_Jugadores";
            this.list_Jugadores.Size = new System.Drawing.Size(587, 433);
            this.list_Jugadores.TabIndex = 0;
            // 
            // GrupoAgregarJugador
            // 
            this.GrupoAgregarJugador.AutoScroll = true;
            this.GrupoAgregarJugador.BackColor = System.Drawing.Color.Transparent;
            this.GrupoAgregarJugador.BaseColor = System.Drawing.Color.White;
            this.GrupoAgregarJugador.BorderColor = System.Drawing.Color.Black;
            this.GrupoAgregarJugador.BorderSize = 1;
            this.GrupoAgregarJugador.Controls.Add(this.btnBorrar);
            this.GrupoAgregarJugador.Controls.Add(this.btnAgregar);
            this.GrupoAgregarJugador.Controls.Add(this.gunaLabel4);
            this.GrupoAgregarJugador.Controls.Add(this.txtNacionalidad);
            this.GrupoAgregarJugador.Controls.Add(this.txtPosicion);
            this.GrupoAgregarJugador.Controls.Add(this.FechaNacimiento);
            this.GrupoAgregarJugador.Controls.Add(this.txtApellido);
            this.GrupoAgregarJugador.Controls.Add(this.txtNombre);
            this.GrupoAgregarJugador.Controls.Add(this.gunaLabel5);
            this.GrupoAgregarJugador.Controls.Add(this.gunaLabel3);
            this.GrupoAgregarJugador.Controls.Add(this.gunaLabel2);
            this.GrupoAgregarJugador.Controls.Add(this.gunaLabel1);
            this.GrupoAgregarJugador.Controls.Add(this.labelNombre);
            this.GrupoAgregarJugador.LineBottom = 1;
            this.GrupoAgregarJugador.LineColor = System.Drawing.Color.Transparent;
            this.GrupoAgregarJugador.LineLeft = 1;
            this.GrupoAgregarJugador.Location = new System.Drawing.Point(961, 81);
            this.GrupoAgregarJugador.Name = "GrupoAgregarJugador";
            this.GrupoAgregarJugador.Size = new System.Drawing.Size(392, 473);
            this.GrupoAgregarJugador.TabIndex = 3;
            this.GrupoAgregarJugador.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btnBorrar
            // 
            this.btnBorrar.AnimationHoverSpeed = 0.07F;
            this.btnBorrar.AnimationSpeed = 0.03F;
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(105)))), ((int)(((byte)(153)))));
            this.btnBorrar.BorderColor = System.Drawing.Color.Black;
            this.btnBorrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBorrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnBorrar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Image = null;
            this.btnBorrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBorrar.Location = new System.Drawing.Point(196, 423);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(105)))), ((int)(((byte)(153)))));
            this.btnBorrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBorrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBorrar.OnHoverImage = null;
            this.btnBorrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnBorrar.Radius = 2;
            this.btnBorrar.Size = new System.Drawing.Size(117, 32);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBorrar.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AnimationHoverSpeed = 0.07F;
            this.btnAgregar.AnimationSpeed = 0.03F;
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(105)))), ((int)(((byte)(153)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregar.FocusedColor = System.Drawing.Color.Empty;
            this.btnAgregar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = null;
            this.btnAgregar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAgregar.Location = new System.Drawing.Point(26, 423);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(105)))), ((int)(((byte)(153)))));
            this.btnAgregar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgregar.OnHoverImage = null;
            this.btnAgregar.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgregar.Radius = 2;
            this.btnAgregar.Size = new System.Drawing.Size(117, 32);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(25, 24);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(206, 23);
            this.gunaLabel4.TabIndex = 11;
            this.gunaLabel4.Text = "Agregar Nuevo Jugador:";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.BaseColor = System.Drawing.Color.White;
            this.txtNacionalidad.BorderColor = System.Drawing.Color.Silver;
            this.txtNacionalidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNacionalidad.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNacionalidad.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(105)))), ((int)(((byte)(153)))));
            this.txtNacionalidad.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNacionalidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNacionalidad.Location = new System.Drawing.Point(26, 373);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.PasswordChar = '\0';
            this.txtNacionalidad.Size = new System.Drawing.Size(287, 30);
            this.txtNacionalidad.TabIndex = 10;
            // 
            // txtPosicion
            // 
            this.txtPosicion.BackColor = System.Drawing.Color.Transparent;
            this.txtPosicion.BaseColor = System.Drawing.Color.White;
            this.txtPosicion.BorderColor = System.Drawing.Color.Silver;
            this.txtPosicion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtPosicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPosicion.FocusedColor = System.Drawing.Color.Empty;
            this.txtPosicion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPosicion.ForeColor = System.Drawing.Color.Black;
            this.txtPosicion.FormattingEnabled = true;
            this.txtPosicion.Items.AddRange(new object[] {
            "Arquero",
            "Defensor",
            "Mediocampista",
            "Delantero"});
            this.txtPosicion.Location = new System.Drawing.Point(26, 297);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(105)))), ((int)(((byte)(153)))));
            this.txtPosicion.OnHoverItemForeColor = System.Drawing.Color.White;
            this.txtPosicion.Size = new System.Drawing.Size(287, 26);
            this.txtPosicion.TabIndex = 9;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.BaseColor = System.Drawing.Color.White;
            this.FechaNacimiento.BorderColor = System.Drawing.Color.Silver;
            this.FechaNacimiento.CustomFormat = null;
            this.FechaNacimiento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.FechaNacimiento.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(105)))), ((int)(((byte)(153)))));
            this.FechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FechaNacimiento.ForeColor = System.Drawing.Color.Black;
            this.FechaNacimiento.Location = new System.Drawing.Point(28, 229);
            this.FechaNacimiento.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.FechaNacimiento.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.OnHoverBaseColor = System.Drawing.Color.White;
            this.FechaNacimiento.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.FechaNacimiento.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.FechaNacimiento.OnPressedColor = System.Drawing.Color.Black;
            this.FechaNacimiento.Size = new System.Drawing.Size(285, 30);
            this.FechaNacimiento.TabIndex = 8;
            this.FechaNacimiento.Text = "jueves, 21 de diciembre de 2000";
            this.FechaNacimiento.Value = new System.DateTime(2000, 12, 21, 0, 0, 0, 0);
            // 
            // txtApellido
            // 
            this.txtApellido.BaseColor = System.Drawing.Color.White;
            this.txtApellido.BorderColor = System.Drawing.Color.Silver;
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.FocusedBaseColor = System.Drawing.Color.White;
            this.txtApellido.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(105)))), ((int)(((byte)(153)))));
            this.txtApellido.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApellido.Location = new System.Drawing.Point(28, 156);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.Size = new System.Drawing.Size(285, 30);
            this.txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.BaseColor = System.Drawing.Color.White;
            this.txtNombre.BorderColor = System.Drawing.Color.Silver;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(105)))), ((int)(((byte)(153)))));
            this.txtNombre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Location = new System.Drawing.Point(29, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.Size = new System.Drawing.Size(284, 30);
            this.txtNombre.TabIndex = 6;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(26, 135);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(58, 18);
            this.gunaLabel5.TabIndex = 5;
            this.gunaLabel5.Text = "Apellido";
            this.gunaLabel5.Click += new System.EventHandler(this.gunaLabel5_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(26, 349);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(87, 18);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Nacionalidad";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(25, 276);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(59, 18);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Posicion";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(25, 206);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(138, 18);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Fecha de Nacimiento";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(26, 66);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(59, 18);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnSalir.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 40;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 558);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSalir.Size = new System.Drawing.Size(205, 53);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1384, 611);
            this.Controls.Add(this.GrupoAgregarJugador);
            this.Controls.Add(this.GrupoListaJugadores);
            this.Controls.Add(this.PanelTitulo);
            this.Controls.Add(this.PanelMenu);
            this.Name = "form2";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoFormTitulo)).EndInit();
            this.GrupoListaJugadores.ResumeLayout(false);
            this.GrupoListaJugadores.PerformLayout();
            this.GrupoAgregarJugador.ResumeLayout(false);
            this.GrupoAgregarJugador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel PanelMenu;
        private FontAwesome.Sharp.IconButton btnJugadores;
        private Guna.UI.WinForms.GunaPanel PanelLogo;
        private Guna.UI.WinForms.GunaPanel PanelTitulo;
        private FontAwesome.Sharp.IconButton btnPartidos;
        private FontAwesome.Sharp.IconButton btnEntrenador;
        private FontAwesome.Sharp.IconButton btnFinanzas;
        private FontAwesome.Sharp.IconPictureBox IconoFormTitulo;
        private FontAwesome.Sharp.IconButton btnAtras2;
        private System.Windows.Forms.Label lblTituloForms;
        private Guna.UI.WinForms.GunaPictureBox btnInicio;
        private Guna.UI.WinForms.GunaGroupBox GrupoListaJugadores;
        private Guna.UI.WinForms.GunaGroupBox GrupoAgregarJugador;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel labelNombre;
        private Guna.UI.WinForms.GunaTextBox txtNombre;
        private Guna.UI.WinForms.GunaDateTimePicker FechaNacimiento;
        private Guna.UI.WinForms.GunaTextBox txtApellido;
        private Guna.UI.WinForms.GunaComboBox txtPosicion;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtNacionalidad;
        private Guna.UI.WinForms.GunaButton btnAgregar;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private System.Windows.Forms.ListBox list_Jugadores;
        private Guna.UI.WinForms.GunaButton btnBorrar;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}
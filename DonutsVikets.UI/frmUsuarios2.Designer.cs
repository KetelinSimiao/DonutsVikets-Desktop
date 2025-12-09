namespace DonutsVikets.UI
{
    partial class frmUsuarios2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios2));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            txtNome1 = new TextBox();
            txtEmail1 = new TextBox();
            txtSenha1 = new TextBox();
            btnFechar = new Guna.UI2.WinForms.Guna2CircleButton();
            txtNome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtSenha = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnCadastrar = new Guna.UI2.WinForms.Guna2Button();
            cmbTipoUsuario = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(671, 489);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtNome1
            // 
            txtNome1.Location = new Point(12, 89);
            txtNome1.Name = "txtNome1";
            txtNome1.Size = new Size(179, 23);
            txtNome1.TabIndex = 7;
            txtNome1.TextChanged += textBox1_TextChanged;
            // 
            // txtEmail1
            // 
            txtEmail1.Location = new Point(12, 189);
            txtEmail1.Name = "txtEmail1";
            txtEmail1.Size = new Size(179, 23);
            txtEmail1.TabIndex = 8;
            // 
            // txtSenha1
            // 
            txtSenha1.Location = new Point(12, 283);
            txtSenha1.Name = "txtSenha1";
            txtSenha1.ScrollBars = ScrollBars.Horizontal;
            txtSenha1.Size = new Size(179, 23);
            txtSenha1.TabIndex = 9;
            txtSenha1.TextChanged += textBox3_TextChanged;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(250, 181, 211);
            btnFechar.BorderColor = Color.FromArgb(250, 181, 211);
            btnFechar.DisabledState.BorderColor = Color.DarkGray;
            btnFechar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFechar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFechar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFechar.FillColor = Color.Red;
            btnFechar.Font = new Font("Segoe UI", 9F);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(616, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnFechar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnFechar.Size = new Size(38, 40);
            btnFechar.TabIndex = 10;
            btnFechar.Text = "x";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(250, 181, 211);
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(12, 60);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(46, 23);
            txtNome.TabIndex = 12;
            txtNome.Text = "Nome";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(250, 181, 211);
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(12, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(41, 23);
            txtEmail.TabIndex = 12;
            txtEmail.Text = "Email";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(250, 181, 211);
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(25, 254);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(46, 23);
            txtSenha.TabIndex = 12;
            txtSenha.Text = "Senha";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(250, 181, 211);
            btnCadastrar.BorderRadius = 20;
            btnCadastrar.CustomizableEdges = customizableEdges2;
            btnCadastrar.DisabledState.BorderColor = Color.DarkGray;
            btnCadastrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCadastrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCadastrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCadastrar.FillColor = Color.Salmon;
            btnCadastrar.Font = new Font("Segoe UI", 9F);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(12, 415);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnCadastrar.Size = new Size(180, 45);
            btnCadastrar.TabIndex = 13;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.BackColor = Color.Transparent;
            cmbTipoUsuario.CustomizableEdges = customizableEdges4;
            cmbTipoUsuario.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoUsuario.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbTipoUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbTipoUsuario.Font = new Font("Segoe UI", 10F);
            cmbTipoUsuario.ForeColor = Color.FromArgb(68, 88, 112);
            cmbTipoUsuario.ItemHeight = 30;
            cmbTipoUsuario.Location = new Point(12, 338);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.ShadowDecoration.CustomizableEdges = customizableEdges5;
            cmbTipoUsuario.Size = new Size(180, 36);
            cmbTipoUsuario.TabIndex = 14;
            // 
            // frmUsuarios2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 472);
            Controls.Add(cmbTipoUsuario);
            Controls.Add(btnCadastrar);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(btnFechar);
            Controls.Add(txtSenha1);
            Controls.Add(txtEmail1);
            Controls.Add(txtNome1);
            Controls.Add(pictureBox1);
            Name = "frmUsuarios2";
            Text = "frmUsuarios2";
            Load += frmUsuarios2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnAtualizar;
        private PictureBox pictureBox1;
        private TextBox txtNome1;
        private TextBox txtEmail1;
        private TextBox txtSenha1;
        private Guna.UI2.WinForms.Guna2CircleButton btnFechar;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtNome;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtSenha;
        private Guna.UI2.WinForms.Guna2Button btnCadastrar;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTipoUsuario;
    }
}
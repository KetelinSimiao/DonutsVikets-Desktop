namespace DonutsVikets.UI
{
    partial class frmPedidos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            txtDataPedido = new DateTimePicker();
            dgPedidos = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtStatus = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgPedidos).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pink_Aesthetic_Linktree_Background__4_;
            pictureBox1.Location = new Point(-4, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(817, 459);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtDataPedido
            // 
            txtDataPedido.Location = new Point(515, 47);
            txtDataPedido.Name = "txtDataPedido";
            txtDataPedido.Size = new Size(200, 23);
            txtDataPedido.TabIndex = 1;
            // 
            // dgPedidos
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgPedidos.ColumnHeadersHeight = 4;
            dgPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgPedidos.DefaultCellStyle = dataGridViewCellStyle3;
            dgPedidos.GridColor = Color.FromArgb(231, 229, 255);
            dgPedidos.Location = new Point(10, 61);
            dgPedidos.Name = "dgPedidos";
            dgPedidos.RowHeadersVisible = false;
            dgPedidos.Size = new Size(411, 301);
            dgPedidos.TabIndex = 2;
            dgPedidos.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgPedidos.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgPedidos.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgPedidos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgPedidos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgPedidos.ThemeStyle.BackColor = Color.White;
            dgPedidos.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgPedidos.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgPedidos.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgPedidos.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgPedidos.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgPedidos.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgPedidos.ThemeStyle.HeaderStyle.Height = 4;
            dgPedidos.ThemeStyle.ReadOnly = false;
            dgPedidos.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgPedidos.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgPedidos.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgPedidos.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgPedidos.ThemeStyle.RowsStyle.Height = 25;
            dgPedidos.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgPedidos.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgPedidos.CellClick += dgPedidos_CellClick;
            dgPedidos.CellContentClick += dgPedidos_CellContentClick;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.FromArgb(255, 188, 217);
            guna2HtmlLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(516, 18);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(83, 23);
            guna2HtmlLabel1.TabIndex = 3;
            guna2HtmlLabel1.Text = "DataPedido";
            // 
            // txtStatus
            // 
            txtStatus.CustomizableEdges = customizableEdges1;
            txtStatus.DefaultText = "";
            txtStatus.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtStatus.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtStatus.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtStatus.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtStatus.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtStatus.Font = new Font("Segoe UI", 9F);
            txtStatus.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtStatus.Location = new Point(515, 132);
            txtStatus.Name = "txtStatus";
            txtStatus.PlaceholderText = "";
            txtStatus.SelectedText = "";
            txtStatus.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtStatus.Size = new Size(200, 36);
            txtStatus.TabIndex = 4;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.FromArgb(255, 188, 217);
            guna2HtmlLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.Location = new Point(516, 103);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(53, 23);
            guna2HtmlLabel2.TabIndex = 3;
            guna2HtmlLabel2.Text = "Status :";
            // 
            // frmPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtStatus);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(dgPedidos);
            Controls.Add(txtDataPedido);
            Controls.Add(pictureBox1);
            Name = "frmPedidos";
            Text = "frmPedidos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DateTimePicker txtDataPedido;
        private Guna.UI2.WinForms.Guna2DataGridView dgPedidos;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}
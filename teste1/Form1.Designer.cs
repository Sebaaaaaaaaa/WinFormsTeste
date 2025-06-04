namespace teste1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            aRQUIVOToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            eDITARToolStripMenuItem1 = new ToolStripMenuItem();
            dataGridViewCarros = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Placa = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            Automatico = new DataGridViewTextBoxColumn();
            Ano = new DataGridViewTextBoxColumn();
            textBoxMarca = new TextBox();
            textBoxModelo = new TextBox();
            comboBoxAutomatico = new ComboBox();
            maskedTextBoxAno = new MaskedTextBox();
            label7 = new Label();
            label6 = new Label();
            textBoxPlaca = new TextBox();
            buttonAdicionarCarro = new Button();
            label5 = new Label();
            labelAviso = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarros).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aRQUIVOToolStripMenuItem, eDITARToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(782, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // aRQUIVOToolStripMenuItem
            // 
            aRQUIVOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editarToolStripMenuItem, salvarToolStripMenuItem });
            aRQUIVOToolStripMenuItem.Name = "aRQUIVOToolStripMenuItem";
            aRQUIVOToolStripMenuItem.Size = new Size(70, 20);
            aRQUIVOToolStripMenuItem.Text = "ARQUIVO";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(105, 22);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.Size = new Size(105, 22);
            salvarToolStripMenuItem.Text = "Salvar";
            // 
            // eDITARToolStripMenuItem1
            // 
            eDITARToolStripMenuItem1.Name = "eDITARToolStripMenuItem1";
            eDITARToolStripMenuItem1.Size = new Size(57, 20);
            eDITARToolStripMenuItem1.Text = "EDITAR";
            // 
            // dataGridViewCarros
            // 
            dataGridViewCarros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarros.Columns.AddRange(new DataGridViewColumn[] { Id, Placa, Marca, Modelo, Automatico, Ano });
            dataGridViewCarros.Location = new Point(86, 161);
            dataGridViewCarros.Name = "dataGridViewCarros";
            dataGridViewCarros.ReadOnly = true;
            dataGridViewCarros.Size = new Size(585, 167);
            dataGridViewCarros.TabIndex = 24;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 30;
            // 
            // Placa
            // 
            Placa.HeaderText = "Placa";
            Placa.Name = "Placa";
            Placa.ReadOnly = true;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.Name = "Modelo";
            Modelo.ReadOnly = true;
            // 
            // Automatico
            // 
            Automatico.HeaderText = "E Automatico?";
            Automatico.Name = "Automatico";
            Automatico.ReadOnly = true;
            Automatico.Width = 110;
            // 
            // Ano
            // 
            Ano.HeaderText = "Ano";
            Ano.Name = "Ano";
            Ano.ReadOnly = true;
            // 
            // textBoxMarca
            // 
            textBoxMarca.Font = new Font("Segoe UI", 11F);
            textBoxMarca.ForeColor = Color.FromArgb(64, 64, 64);
            textBoxMarca.Location = new Point(192, 96);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.PlaceholderText = "Marca";
            textBoxMarca.Size = new Size(100, 27);
            textBoxMarca.TabIndex = 29;
            // 
            // textBoxModelo
            // 
            textBoxModelo.Font = new Font("Segoe UI", 11F);
            textBoxModelo.ForeColor = Color.FromArgb(64, 64, 64);
            textBoxModelo.Location = new Point(298, 96);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.PlaceholderText = "Modelo";
            textBoxModelo.Size = new Size(100, 27);
            textBoxModelo.TabIndex = 30;
            // 
            // comboBoxAutomatico
            // 
            comboBoxAutomatico.FormattingEnabled = true;
            comboBoxAutomatico.Items.AddRange(new object[] { "Sim", "Nao", "Semiautomatico" });
            comboBoxAutomatico.Location = new Point(404, 96);
            comboBoxAutomatico.Name = "comboBoxAutomatico";
            comboBoxAutomatico.Size = new Size(105, 23);
            comboBoxAutomatico.TabIndex = 32;
            // 
            // maskedTextBoxAno
            // 
            maskedTextBoxAno.Location = new Point(515, 96);
            maskedTextBoxAno.Mask = "0000";
            maskedTextBoxAno.Name = "maskedTextBoxAno";
            maskedTextBoxAno.Size = new Size(100, 23);
            maskedTextBoxAno.TabIndex = 34;
            maskedTextBoxAno.ValidatingType = typeof(int);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(515, 78);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 35;
            label7.Text = "Ano";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(86, 68);
            label6.Name = "label6";
            label6.Size = new Size(149, 25);
            label6.TabIndex = 37;
            label6.Text = "INPUT CARROS";
            // 
            // textBoxPlaca
            // 
            textBoxPlaca.Font = new Font("Segoe UI", 11F);
            textBoxPlaca.ForeColor = Color.FromArgb(64, 64, 64);
            textBoxPlaca.Location = new Point(86, 96);
            textBoxPlaca.Name = "textBoxPlaca";
            textBoxPlaca.PlaceholderText = "Placa";
            textBoxPlaca.Size = new Size(100, 27);
            textBoxPlaca.TabIndex = 38;
            // 
            // buttonAdicionarCarro
            // 
            buttonAdicionarCarro.Location = new Point(621, 96);
            buttonAdicionarCarro.Name = "buttonAdicionarCarro";
            buttonAdicionarCarro.Size = new Size(81, 43);
            buttonAdicionarCarro.TabIndex = 40;
            buttonAdicionarCarro.Text = "ADICIONAR CARRO";
            buttonAdicionarCarro.UseVisualStyleBackColor = true;
            buttonAdicionarCarro.Click += buttonAdicionarCarro_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(404, 78);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 42;
            label5.Text = "E automatico?";
            // 
            // labelAviso
            // 
            labelAviso.AutoSize = true;
            labelAviso.Location = new Point(86, 126);
            labelAviso.Name = "labelAviso";
            labelAviso.Size = new Size(10, 15);
            labelAviso.TabIndex = 44;
            labelAviso.Text = ".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(782, 603);
            Controls.Add(labelAviso);
            Controls.Add(label5);
            Controls.Add(buttonAdicionarCarro);
            Controls.Add(textBoxPlaca);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(maskedTextBoxAno);
            Controls.Add(comboBoxAutomatico);
            Controls.Add(textBoxModelo);
            Controls.Add(textBoxMarca);
            Controls.Add(dataGridViewCarros);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aRQUIVOToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem eDITARToolStripMenuItem1;
        private ListView listView1;

        private DataGridView dataGridViewCarros;
        private TextBox textBoxMarca;
        private TextBox textBoxModelo;
        private ComboBox comboBoxAutomatico;
        private MaskedTextBox maskedTextBoxAno;
        private Label label7;
        private Label label6;
        private TextBox textBoxPlaca;
        private Button buttonAdicionarCarro;
        private Label label5;
        private Label labelAviso;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Placa;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Automatico;
        private DataGridViewTextBoxColumn Ano;

        private int indexDataGridView = 0;
        private int id = 1;

        //private List<Carro> carros = new List<Carro>();
    }
}

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
            textBoxId = new TextBox();
            textBoxPreco = new TextBox();
            textBoxTotal = new TextBox();
            labelAviso = new Label();
            buttonCalcular = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            aRQUIVOToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            eDITARToolStripMenuItem1 = new ToolStripMenuItem();
            textBoxQuantidade = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonAdicionar = new Button();
            listBox1 = new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxId
            // 
            textBoxId.BorderStyle = BorderStyle.FixedSingle;
            textBoxId.Font = new Font("Segoe UI", 11F);
            textBoxId.ForeColor = Color.FromArgb(64, 64, 64);
            textBoxId.Location = new Point(101, 140);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(76, 27);
            textBoxId.TabIndex = 1;
            textBoxId.Tag = "";
            // 
            // textBoxPreco
            // 
            textBoxPreco.BorderStyle = BorderStyle.FixedSingle;
            textBoxPreco.Font = new Font("Segoe UI", 11F);
            textBoxPreco.ForeColor = Color.FromArgb(64, 64, 64);
            textBoxPreco.Location = new Point(237, 140);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(104, 27);
            textBoxPreco.TabIndex = 2;
            // 
            // textBoxTotal
            // 
            textBoxTotal.BorderStyle = BorderStyle.FixedSingle;
            textBoxTotal.Font = new Font("Segoe UI", 11F);
            textBoxTotal.ForeColor = Color.FromArgb(64, 64, 64);
            textBoxTotal.Location = new Point(183, 228);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(158, 27);
            textBoxTotal.TabIndex = 3;
            // 
            // labelAviso
            // 
            labelAviso.AutoSize = true;
            labelAviso.ForeColor = Color.FromArgb(64, 64, 64);
            labelAviso.Location = new Point(100, 294);
            labelAviso.Name = "labelAviso";
            labelAviso.Size = new Size(50, 15);
            labelAviso.TabIndex = 4;
            labelAviso.Text = "Avisos...";
            // 
            // buttonCalcular
            // 
            buttonCalcular.BackColor = SystemColors.Control;
            buttonCalcular.Location = new Point(100, 216);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(76, 39);
            buttonCalcular.TabIndex = 5;
            buttonCalcular.Text = "FECHAR COMPRA";
            buttonCalcular.UseVisualStyleBackColor = false;
            buttonCalcular.Click += buttonCalcular_Click;
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
            menuStrip1.Size = new Size(1884, 24);
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
            // textBoxQuantidade
            // 
            textBoxQuantidade.AcceptsTab = true;
            textBoxQuantidade.BorderStyle = BorderStyle.FixedSingle;
            textBoxQuantidade.Font = new Font("Segoe UI", 11F);
            textBoxQuantidade.ForeColor = Color.FromArgb(64, 64, 64);
            textBoxQuantidade.Location = new Point(183, 140);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(48, 27);
            textBoxQuantidade.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 210);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 11;
            label1.Text = "Valor a pagar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 122);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 13;
            label2.Text = "ID PRODUTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 122);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 14;
            label3.Text = "QUANT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(297, 122);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 15;
            label4.Text = "PREÇO";
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Location = new Point(260, 173);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(81, 29);
            buttonAdicionar.TabIndex = 17;
            buttonAdicionar.Text = "ADICIONAR";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(390, 131);
            listBox1.MultiColumn = true;
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(507, 94);
            listBox1.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1884, 961);
            Controls.Add(listBox1);
            Controls.Add(buttonAdicionar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxQuantidade);
            Controls.Add(menuStrip1);
            Controls.Add(buttonCalcular);
            Controls.Add(labelAviso);
            Controls.Add(textBoxTotal);
            Controls.Add(textBoxPreco);
            Controls.Add(textBoxId);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxId;
        private TextBox textBoxPreco;
        private TextBox textBoxTotal;
        private Label labelAviso;
        private Button buttonCalcular;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aRQUIVOToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem eDITARToolStripMenuItem1;
        private TextBox textBoxQuantidade;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonAdicionar;
        private ListView listView1;
        private ListBox listBox1;
    }
}

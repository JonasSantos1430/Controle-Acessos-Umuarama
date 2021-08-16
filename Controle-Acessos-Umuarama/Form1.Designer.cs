
namespace Controle_Acessos_Umuarama
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Placa = new System.Windows.Forms.TextBox();
            this.Txt_Modelo = new System.Windows.Forms.TextBox();
            this.Txt_Cor = new System.Windows.Forms.TextBox();
            this.dadosVeiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAD_VEICULODataSet = new Controle_Acessos_Umuarama.CAD_VEICULODataSet();
            this.Btn_NovoV = new System.Windows.Forms.Button();
            this.Btn_EditarV = new System.Windows.Forms.Button();
            this.Btn_ConsultV = new System.Windows.Forms.Button();
            this.Btn_ExcluirV = new System.Windows.Forms.Button();
            this.dados_VeiculoTableAdapter = new Controle_Acessos_Umuarama.CAD_VEICULODataSetTableAdapters.Dados_VeiculoTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idVeiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEICDataSet = new Controle_Acessos_Umuarama.VEICDataSet();
            this.tabVTableAdapter = new Controle_Acessos_Umuarama.VEICDataSetTableAdapters.TabVTableAdapter();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPÇÕESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarResidênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cadastrarMotoristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dadosVeiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_VEICULODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(489, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(500, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(483, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo";
            // 
            // Txt_Placa
            // 
            this.Txt_Placa.Location = new System.Drawing.Point(529, 26);
            this.Txt_Placa.Name = "Txt_Placa";
            this.Txt_Placa.Size = new System.Drawing.Size(127, 20);
            this.Txt_Placa.TabIndex = 3;
            // 
            // Txt_Modelo
            // 
            this.Txt_Modelo.Location = new System.Drawing.Point(529, 52);
            this.Txt_Modelo.Name = "Txt_Modelo";
            this.Txt_Modelo.Size = new System.Drawing.Size(127, 20);
            this.Txt_Modelo.TabIndex = 4;
            // 
            // Txt_Cor
            // 
            this.Txt_Cor.Location = new System.Drawing.Point(529, 78);
            this.Txt_Cor.Name = "Txt_Cor";
            this.Txt_Cor.Size = new System.Drawing.Size(127, 20);
            this.Txt_Cor.TabIndex = 5;
            // 
            // dadosVeiculoBindingSource
            // 
            this.dadosVeiculoBindingSource.DataMember = "Dados-Veiculo";
            this.dadosVeiculoBindingSource.DataSource = this.cAD_VEICULODataSet;
            // 
            // cAD_VEICULODataSet
            // 
            this.cAD_VEICULODataSet.DataSetName = "CAD_VEICULODataSet";
            this.cAD_VEICULODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Btn_NovoV
            // 
            this.Btn_NovoV.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NovoV.Location = new System.Drawing.Point(448, 233);
            this.Btn_NovoV.Name = "Btn_NovoV";
            this.Btn_NovoV.Size = new System.Drawing.Size(75, 23);
            this.Btn_NovoV.TabIndex = 7;
            this.Btn_NovoV.Text = "Novo";
            this.Btn_NovoV.UseVisualStyleBackColor = true;
            this.Btn_NovoV.Click += new System.EventHandler(this.Btn_NovoV_Click);
            // 
            // Btn_EditarV
            // 
            this.Btn_EditarV.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EditarV.Location = new System.Drawing.Point(529, 233);
            this.Btn_EditarV.Name = "Btn_EditarV";
            this.Btn_EditarV.Size = new System.Drawing.Size(75, 23);
            this.Btn_EditarV.TabIndex = 8;
            this.Btn_EditarV.Text = "Editar";
            this.Btn_EditarV.UseVisualStyleBackColor = true;
            this.Btn_EditarV.Click += new System.EventHandler(this.Btn_EditarV_Click);
            // 
            // Btn_ConsultV
            // 
            this.Btn_ConsultV.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ConsultV.Location = new System.Drawing.Point(691, 233);
            this.Btn_ConsultV.Name = "Btn_ConsultV";
            this.Btn_ConsultV.Size = new System.Drawing.Size(75, 23);
            this.Btn_ConsultV.TabIndex = 9;
            this.Btn_ConsultV.Text = "Consultar";
            this.Btn_ConsultV.UseVisualStyleBackColor = true;
            this.Btn_ConsultV.Click += new System.EventHandler(this.Btn_ConsultV_Click);
            // 
            // Btn_ExcluirV
            // 
            this.Btn_ExcluirV.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExcluirV.Location = new System.Drawing.Point(610, 233);
            this.Btn_ExcluirV.Name = "Btn_ExcluirV";
            this.Btn_ExcluirV.Size = new System.Drawing.Size(75, 23);
            this.Btn_ExcluirV.TabIndex = 10;
            this.Btn_ExcluirV.Text = "Excluir";
            this.Btn_ExcluirV.UseVisualStyleBackColor = true;
            this.Btn_ExcluirV.Click += new System.EventHandler(this.Btn_ExcluirV_Click);
            // 
            // dados_VeiculoTableAdapter
            // 
            this.dados_VeiculoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVeiculoDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabVBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 229);
            this.dataGridView1.TabIndex = 11;
            // 
            // idVeiculoDataGridViewTextBoxColumn
            // 
            this.idVeiculoDataGridViewTextBoxColumn.DataPropertyName = "Id_Veiculo";
            this.idVeiculoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idVeiculoDataGridViewTextBoxColumn.Name = "idVeiculoDataGridViewTextBoxColumn";
            this.idVeiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "PLACA";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "MODELO";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            // 
            // corDataGridViewTextBoxColumn
            // 
            this.corDataGridViewTextBoxColumn.DataPropertyName = "Cor";
            this.corDataGridViewTextBoxColumn.HeaderText = "COR";
            this.corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
            // 
            // tabVBindingSource
            // 
            this.tabVBindingSource.DataMember = "TabV";
            this.tabVBindingSource.DataSource = this.vEICDataSet;
            // 
            // vEICDataSet
            // 
            this.vEICDataSet.DataSetName = "VEICDataSet";
            this.vEICDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabVTableAdapter
            // 
            this.tabVTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_Id
            // 
            this.Txt_Id.Location = new System.Drawing.Point(772, 236);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(28, 20);
            this.Txt_Id.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(782, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Id ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPÇÕESToolStripMenuItem,
            this.cadastrarResidênciaToolStripMenuItem,
            this.registrarAcessoToolStripMenuItem,
            this.cadastrarMotoristaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPÇÕESToolStripMenuItem
            // 
            this.oPÇÕESToolStripMenuItem.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oPÇÕESToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.oPÇÕESToolStripMenuItem.Name = "oPÇÕESToolStripMenuItem";
            this.oPÇÕESToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.oPÇÕESToolStripMenuItem.Text = "Motorista";
            this.oPÇÕESToolStripMenuItem.Click += new System.EventHandler(this.oPÇÕESToolStripMenuItem_Click);
            // 
            // cadastrarResidênciaToolStripMenuItem
            // 
            this.cadastrarResidênciaToolStripMenuItem.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarResidênciaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cadastrarResidênciaToolStripMenuItem.Name = "cadastrarResidênciaToolStripMenuItem";
            this.cadastrarResidênciaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.cadastrarResidênciaToolStripMenuItem.Text = " Residência";
            this.cadastrarResidênciaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarResidênciaToolStripMenuItem_Click);
            // 
            // registrarAcessoToolStripMenuItem
            // 
            this.registrarAcessoToolStripMenuItem.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarAcessoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registrarAcessoToolStripMenuItem.Name = "registrarAcessoToolStripMenuItem";
            this.registrarAcessoToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.registrarAcessoToolStripMenuItem.Text = "Registrar Acesso";
            this.registrarAcessoToolStripMenuItem.Click += new System.EventHandler(this.registrarAcessoToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Controle_Acessos_Umuarama.Properties.Resources.download_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(529, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // cadastrarMotoristaToolStripMenuItem
            // 
            this.cadastrarMotoristaToolStripMenuItem.Name = "cadastrarMotoristaToolStripMenuItem";
            this.cadastrarMotoristaToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.cadastrarMotoristaToolStripMenuItem.Text = "Cadastrar Motorista";
            this.cadastrarMotoristaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarMotoristaToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(819, 284);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_ExcluirV);
            this.Controls.Add(this.Btn_ConsultV);
            this.Controls.Add(this.Btn_EditarV);
            this.Controls.Add(this.Btn_NovoV);
            this.Controls.Add(this.Txt_Cor);
            this.Controls.Add(this.Txt_Modelo);
            this.Controls.Add(this.Txt_Placa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Veículo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosVeiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_VEICULODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Placa;
        private System.Windows.Forms.TextBox Txt_Modelo;
        private System.Windows.Forms.TextBox Txt_Cor;
        private System.Windows.Forms.Button Btn_NovoV;
        private System.Windows.Forms.Button Btn_EditarV;
        private System.Windows.Forms.Button Btn_ConsultV;
        private System.Windows.Forms.Button Btn_ExcluirV;
        private CAD_VEICULODataSet cAD_VEICULODataSet;
        private System.Windows.Forms.BindingSource dadosVeiculoBindingSource;
        private CAD_VEICULODataSetTableAdapters.Dados_VeiculoTableAdapter dados_VeiculoTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VEICDataSet vEICDataSet;
        private System.Windows.Forms.BindingSource tabVBindingSource;
        private VEICDataSetTableAdapters.TabVTableAdapter tabVTableAdapter;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPÇÕESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarResidênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAcessoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVeiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMotoristaToolStripMenuItem;
    }
}


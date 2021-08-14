
namespace Controle_Acessos_Umuarama
{
    partial class Cadastro_Motorista
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Motorista));
            this.Dgv_Motorista = new System.Windows.Forms.DataGridView();
            this.tabMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEICDataSet2 = new Controle_Acessos_Umuarama.VEICDataSet2();
            this.Txt_Motorista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_NovoM = new System.Windows.Forms.Button();
            this.Btn_EditarM = new System.Windows.Forms.Button();
            this.Btn_ExcluirM = new System.Windows.Forms.Button();
            this.Btn_ConsultarM = new System.Windows.Forms.Button();
            this.Txt_IdM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vEICDataSet = new Controle_Acessos_Umuarama.VEICDataSet();
            this.vEICDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabMTableAdapter = new Controle_Acessos_Umuarama.VEICDataSet2TableAdapters.TabMTableAdapter();
            this.Msk_Rg = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idMotoristaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Motorista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Motorista
            // 
            this.Dgv_Motorista.AllowUserToOrderColumns = true;
            this.Dgv_Motorista.AutoGenerateColumns = false;
            this.Dgv_Motorista.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Motorista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Motorista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Motorista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMotoristaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn});
            this.Dgv_Motorista.DataSource = this.tabMBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Motorista.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Motorista.Location = new System.Drawing.Point(12, 25);
            this.Dgv_Motorista.Name = "Dgv_Motorista";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Motorista.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Motorista.Size = new System.Drawing.Size(401, 263);
            this.Dgv_Motorista.TabIndex = 0;
            // 
            // tabMBindingSource
            // 
            this.tabMBindingSource.DataMember = "TabM";
            this.tabMBindingSource.DataSource = this.vEICDataSet2;
            // 
            // vEICDataSet2
            // 
            this.vEICDataSet2.DataSetName = "VEICDataSet2";
            this.vEICDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Txt_Motorista
            // 
            this.Txt_Motorista.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_Motorista.Location = new System.Drawing.Point(509, 63);
            this.Txt_Motorista.Name = "Txt_Motorista";
            this.Txt_Motorista.Size = new System.Drawing.Size(129, 20);
            this.Txt_Motorista.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(416, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(481, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "RG";
            // 
            // Btn_NovoM
            // 
            this.Btn_NovoM.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NovoM.Location = new System.Drawing.Point(419, 265);
            this.Btn_NovoM.Name = "Btn_NovoM";
            this.Btn_NovoM.Size = new System.Drawing.Size(75, 23);
            this.Btn_NovoM.TabIndex = 5;
            this.Btn_NovoM.Text = "Novo";
            this.Btn_NovoM.UseVisualStyleBackColor = true;
            this.Btn_NovoM.Click += new System.EventHandler(this.Btn_NovoM_Click);
            // 
            // Btn_EditarM
            // 
            this.Btn_EditarM.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EditarM.Location = new System.Drawing.Point(500, 265);
            this.Btn_EditarM.Name = "Btn_EditarM";
            this.Btn_EditarM.Size = new System.Drawing.Size(75, 23);
            this.Btn_EditarM.TabIndex = 6;
            this.Btn_EditarM.Text = "Editar";
            this.Btn_EditarM.UseVisualStyleBackColor = true;
            this.Btn_EditarM.Click += new System.EventHandler(this.Btn_EditarM_Click);
            // 
            // Btn_ExcluirM
            // 
            this.Btn_ExcluirM.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExcluirM.Location = new System.Drawing.Point(581, 265);
            this.Btn_ExcluirM.Name = "Btn_ExcluirM";
            this.Btn_ExcluirM.Size = new System.Drawing.Size(75, 23);
            this.Btn_ExcluirM.TabIndex = 7;
            this.Btn_ExcluirM.Text = "Excluir";
            this.Btn_ExcluirM.UseVisualStyleBackColor = true;
            this.Btn_ExcluirM.Click += new System.EventHandler(this.Btn_ExcluirM_Click);
            // 
            // Btn_ConsultarM
            // 
            this.Btn_ConsultarM.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ConsultarM.Location = new System.Drawing.Point(659, 265);
            this.Btn_ConsultarM.Name = "Btn_ConsultarM";
            this.Btn_ConsultarM.Size = new System.Drawing.Size(75, 23);
            this.Btn_ConsultarM.TabIndex = 8;
            this.Btn_ConsultarM.Text = "Consultar";
            this.Btn_ConsultarM.UseVisualStyleBackColor = true;
            this.Btn_ConsultarM.Click += new System.EventHandler(this.Btn_ConsultarM_Click);
            // 
            // Txt_IdM
            // 
            this.Txt_IdM.Location = new System.Drawing.Point(740, 268);
            this.Txt_IdM.Name = "Txt_IdM";
            this.Txt_IdM.Size = new System.Drawing.Size(34, 20);
            this.Txt_IdM.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(755, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Id";
            // 
            // vEICDataSet
            // 
            this.vEICDataSet.DataSetName = "VEICDataSet";
            this.vEICDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vEICDataSetBindingSource
            // 
            this.vEICDataSetBindingSource.DataSource = this.vEICDataSet;
            this.vEICDataSetBindingSource.Position = 0;
            // 
            // tabMTableAdapter
            // 
            this.tabMTableAdapter.ClearBeforeFill = true;
            // 
            // Msk_Rg
            // 
            this.Msk_Rg.Location = new System.Drawing.Point(509, 99);
            this.Msk_Rg.Mask = "00,000,000-00";
            this.Msk_Rg.Name = "Msk_Rg";
            this.Msk_Rg.Size = new System.Drawing.Size(110, 20);
            this.Msk_Rg.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Controle_Acessos_Umuarama.Properties.Resources.Motorista;
            this.pictureBox1.Location = new System.Drawing.Point(644, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // idMotoristaDataGridViewTextBoxColumn
            // 
            this.idMotoristaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idMotoristaDataGridViewTextBoxColumn.DataPropertyName = "Id_Motorista";
            this.idMotoristaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idMotoristaDataGridViewTextBoxColumn.Name = "idMotoristaDataGridViewTextBoxColumn";
            this.idMotoristaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "NOME ";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "Rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            // 
            // Cadastro_Motorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 306);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Msk_Rg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_IdM);
            this.Controls.Add(this.Btn_ConsultarM);
            this.Controls.Add(this.Btn_ExcluirM);
            this.Controls.Add(this.Btn_EditarM);
            this.Controls.Add(this.Btn_NovoM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Motorista);
            this.Controls.Add(this.Dgv_Motorista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cadastro_Motorista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Motorista";
            this.Load += new System.EventHandler(this.Cadastro_Motorista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Motorista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Motorista;
        private System.Windows.Forms.TextBox Txt_Motorista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_NovoM;
        private System.Windows.Forms.Button Btn_EditarM;
        private System.Windows.Forms.Button Btn_ExcluirM;
        private System.Windows.Forms.Button Btn_ConsultarM;
        private System.Windows.Forms.TextBox Txt_IdM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource vEICDataSetBindingSource;
        private VEICDataSet vEICDataSet;
        private VEICDataSet2 vEICDataSet2;
        private System.Windows.Forms.BindingSource tabMBindingSource;
        private VEICDataSet2TableAdapters.TabMTableAdapter tabMTableAdapter;
        private System.Windows.Forms.MaskedTextBox Msk_Rg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMotoristaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
    }
}

namespace Controle_Acessos_Umuarama
{
    partial class Cad_Residencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cad_Residencia));
            this.Dgv_Resid = new System.Windows.Forms.DataGridView();
            this.idResidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeResidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerResiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabResidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEICDataSet3 = new Controle_Acessos_Umuarama.VEICDataSet3();
            this.Txt_NomeResid = new System.Windows.Forms.TextBox();
            this.Txt_Num_Resid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabResidTableAdapter = new Controle_Acessos_Umuarama.VEICDataSet3TableAdapters.TabResidTableAdapter();
            this.Btn_Novo_Resid = new System.Windows.Forms.Button();
            this.Btn_Edit_Resid = new System.Windows.Forms.Button();
            this.Btn_Excluir_Resid = new System.Windows.Forms.Button();
            this.Btn_ConsultResid = new System.Windows.Forms.Button();
            this.Txt_ConsultResid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Resid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabResidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Resid
            // 
            this.Dgv_Resid.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Resid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Resid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Resid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idResidDataGridViewTextBoxColumn,
            this.nomeResidDataGridViewTextBoxColumn,
            this.numerResiDataGridViewTextBoxColumn});
            this.Dgv_Resid.DataSource = this.tabResidBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Resid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Resid.Location = new System.Drawing.Point(12, 12);
            this.Dgv_Resid.Name = "Dgv_Resid";
            this.Dgv_Resid.Size = new System.Drawing.Size(416, 258);
            this.Dgv_Resid.TabIndex = 0;
            // 
            // idResidDataGridViewTextBoxColumn
            // 
            this.idResidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idResidDataGridViewTextBoxColumn.DataPropertyName = "Id_Resid";
            this.idResidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idResidDataGridViewTextBoxColumn.Name = "idResidDataGridViewTextBoxColumn";
            this.idResidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeResidDataGridViewTextBoxColumn
            // 
            this.nomeResidDataGridViewTextBoxColumn.DataPropertyName = "Nome_Resid";
            this.nomeResidDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nomeResidDataGridViewTextBoxColumn.Name = "nomeResidDataGridViewTextBoxColumn";
            // 
            // numerResiDataGridViewTextBoxColumn
            // 
            this.numerResiDataGridViewTextBoxColumn.DataPropertyName = "Numer_Resi";
            this.numerResiDataGridViewTextBoxColumn.HeaderText = "NÚMERO";
            this.numerResiDataGridViewTextBoxColumn.Name = "numerResiDataGridViewTextBoxColumn";
            // 
            // tabResidBindingSource
            // 
            this.tabResidBindingSource.DataMember = "TabResid";
            this.tabResidBindingSource.DataSource = this.vEICDataSet3;
            // 
            // vEICDataSet3
            // 
            this.vEICDataSet3.DataSetName = "VEICDataSet3";
            this.vEICDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Txt_NomeResid
            // 
            this.Txt_NomeResid.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeResid.Location = new System.Drawing.Point(539, 40);
            this.Txt_NomeResid.Name = "Txt_NomeResid";
            this.Txt_NomeResid.Size = new System.Drawing.Size(174, 23);
            this.Txt_NomeResid.TabIndex = 1;
            this.Txt_NomeResid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Txt_Num_Resid
            // 
            this.Txt_Num_Resid.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Num_Resid.Location = new System.Drawing.Point(539, 76);
            this.Txt_Num_Resid.Name = "Txt_Num_Resid";
            this.Txt_Num_Resid.Size = new System.Drawing.Size(63, 23);
            this.Txt_Num_Resid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(434, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Residência";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(486, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número";
            // 
            // tabResidTableAdapter
            // 
            this.tabResidTableAdapter.ClearBeforeFill = true;
            // 
            // Btn_Novo_Resid
            // 
            this.Btn_Novo_Resid.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Novo_Resid.Location = new System.Drawing.Point(437, 247);
            this.Btn_Novo_Resid.Name = "Btn_Novo_Resid";
            this.Btn_Novo_Resid.Size = new System.Drawing.Size(75, 23);
            this.Btn_Novo_Resid.TabIndex = 5;
            this.Btn_Novo_Resid.Text = "Novo";
            this.Btn_Novo_Resid.UseVisualStyleBackColor = true;
            this.Btn_Novo_Resid.Click += new System.EventHandler(this.Btn_Novo_Resid_Click);
            // 
            // Btn_Edit_Resid
            // 
            this.Btn_Edit_Resid.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Edit_Resid.Location = new System.Drawing.Point(518, 247);
            this.Btn_Edit_Resid.Name = "Btn_Edit_Resid";
            this.Btn_Edit_Resid.Size = new System.Drawing.Size(75, 23);
            this.Btn_Edit_Resid.TabIndex = 6;
            this.Btn_Edit_Resid.Text = "Editar";
            this.Btn_Edit_Resid.UseVisualStyleBackColor = true;
            this.Btn_Edit_Resid.Click += new System.EventHandler(this.Btn_Edit_Resid_Click);
            // 
            // Btn_Excluir_Resid
            // 
            this.Btn_Excluir_Resid.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Excluir_Resid.Location = new System.Drawing.Point(599, 247);
            this.Btn_Excluir_Resid.Name = "Btn_Excluir_Resid";
            this.Btn_Excluir_Resid.Size = new System.Drawing.Size(75, 23);
            this.Btn_Excluir_Resid.TabIndex = 7;
            this.Btn_Excluir_Resid.Text = "Excluir";
            this.Btn_Excluir_Resid.UseVisualStyleBackColor = true;
            this.Btn_Excluir_Resid.Click += new System.EventHandler(this.Btn_Excluir_Resid_Click);
            // 
            // Btn_ConsultResid
            // 
            this.Btn_ConsultResid.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ConsultResid.Location = new System.Drawing.Point(680, 247);
            this.Btn_ConsultResid.Name = "Btn_ConsultResid";
            this.Btn_ConsultResid.Size = new System.Drawing.Size(75, 23);
            this.Btn_ConsultResid.TabIndex = 8;
            this.Btn_ConsultResid.Text = "Consultar";
            this.Btn_ConsultResid.UseVisualStyleBackColor = true;
            this.Btn_ConsultResid.Click += new System.EventHandler(this.Btn_ConsultResid_Click);
            // 
            // Txt_ConsultResid
            // 
            this.Txt_ConsultResid.Location = new System.Drawing.Point(761, 249);
            this.Txt_ConsultResid.Name = "Txt_ConsultResid";
            this.Txt_ConsultResid.Size = new System.Drawing.Size(34, 20);
            this.Txt_ConsultResid.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(776, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Id";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Controle_Acessos_Umuarama.Properties.Resources.Casa;
            this.pictureBox1.Location = new System.Drawing.Point(518, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Cad_Residencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(807, 285);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Txt_ConsultResid);
            this.Controls.Add(this.Btn_ConsultResid);
            this.Controls.Add(this.Btn_Excluir_Resid);
            this.Controls.Add(this.Btn_Edit_Resid);
            this.Controls.Add(this.Btn_Novo_Resid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Num_Resid);
            this.Controls.Add(this.Txt_NomeResid);
            this.Controls.Add(this.Dgv_Resid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cad_Residencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Residência";
            this.Load += new System.EventHandler(this.Cad_Residencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Resid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabResidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Resid;
        private System.Windows.Forms.TextBox Txt_NomeResid;
        private System.Windows.Forms.TextBox Txt_Num_Resid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private VEICDataSet3 vEICDataSet3;
        private System.Windows.Forms.BindingSource tabResidBindingSource;
        private VEICDataSet3TableAdapters.TabResidTableAdapter tabResidTableAdapter;
        private System.Windows.Forms.Button Btn_Novo_Resid;
        private System.Windows.Forms.Button Btn_Edit_Resid;
        private System.Windows.Forms.Button Btn_Excluir_Resid;
        private System.Windows.Forms.Button Btn_ConsultResid;
        private System.Windows.Forms.TextBox Txt_ConsultResid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idResidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeResidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerResiDataGridViewTextBoxColumn;
    }
}
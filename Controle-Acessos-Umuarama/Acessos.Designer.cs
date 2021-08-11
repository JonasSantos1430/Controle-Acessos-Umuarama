
namespace Controle_Acessos_Umuarama
{
    partial class Acessos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.acessosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEICDataSet7 = new Controle_Acessos_Umuarama.VEICDataSet7();
            this.acessosTableAdapter = new Controle_Acessos_Umuarama.VEICDataSet7TableAdapters.AcessosTableAdapter();
            this.idRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motoristaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horárioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRegistroDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn,
            this.motoristaDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn,
            this.tipoRegistroDataGridViewTextBoxColumn,
            this.horárioDataGridViewTextBoxColumn,
            this.casaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.acessosBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1002, 325);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // acessosBindingSource
            // 
            this.acessosBindingSource.DataMember = "Acessos";
            this.acessosBindingSource.DataSource = this.vEICDataSet7;
            // 
            // vEICDataSet7
            // 
            this.vEICDataSet7.DataSetName = "VEICDataSet7";
            this.vEICDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acessosTableAdapter
            // 
            this.acessosTableAdapter.ClearBeforeFill = true;
            // 
            // idRegistroDataGridViewTextBoxColumn
            // 
            this.idRegistroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idRegistroDataGridViewTextBoxColumn.DataPropertyName = "Id_Registro";
            this.idRegistroDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idRegistroDataGridViewTextBoxColumn.Name = "idRegistroDataGridViewTextBoxColumn";
            this.idRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            // 
            // corDataGridViewTextBoxColumn
            // 
            this.corDataGridViewTextBoxColumn.DataPropertyName = "Cor";
            this.corDataGridViewTextBoxColumn.HeaderText = "Cor";
            this.corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
            // 
            // motoristaDataGridViewTextBoxColumn
            // 
            this.motoristaDataGridViewTextBoxColumn.DataPropertyName = "Motorista";
            this.motoristaDataGridViewTextBoxColumn.HeaderText = "Motorista";
            this.motoristaDataGridViewTextBoxColumn.Name = "motoristaDataGridViewTextBoxColumn";
            // 
            // rGDataGridViewTextBoxColumn
            // 
            this.rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
            this.rGDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
            // 
            // tipoRegistroDataGridViewTextBoxColumn
            // 
            this.tipoRegistroDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Registro";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            this.tipoRegistroDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.tipoRegistroDataGridViewTextBoxColumn.HeaderText = "Tipo Registro";
            this.tipoRegistroDataGridViewTextBoxColumn.Name = "tipoRegistroDataGridViewTextBoxColumn";
            // 
            // horárioDataGridViewTextBoxColumn
            // 
            this.horárioDataGridViewTextBoxColumn.DataPropertyName = "Horário";
            this.horárioDataGridViewTextBoxColumn.HeaderText = "Data e Horário";
            this.horárioDataGridViewTextBoxColumn.Name = "horárioDataGridViewTextBoxColumn";
            // 
            // casaDataGridViewTextBoxColumn
            // 
            this.casaDataGridViewTextBoxColumn.DataPropertyName = "Casa";
            this.casaDataGridViewTextBoxColumn.HeaderText = "Casa";
            this.casaDataGridViewTextBoxColumn.Name = "casaDataGridViewTextBoxColumn";
            // 
            // Acessos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Acessos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acessos";
            this.Load += new System.EventHandler(this.Acessos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private VEICDataSet7 vEICDataSet7;
        private System.Windows.Forms.BindingSource acessosBindingSource;
        private VEICDataSet7TableAdapters.AcessosTableAdapter acessosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motoristaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horárioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn casaDataGridViewTextBoxColumn;
    }
}
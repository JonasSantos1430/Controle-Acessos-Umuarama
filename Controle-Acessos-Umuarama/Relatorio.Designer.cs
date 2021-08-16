
namespace Controle_Acessos_Umuarama
{
    partial class Relatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_Placa = new System.Windows.Forms.ComboBox();
            this.cb_Modelo = new System.Windows.Forms.ComboBox();
            this.cb_Cor = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_Residencia = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_TipoReg = new System.Windows.Forms.ComboBox();
            this.vEICDataSet8 = new Controle_Acessos_Umuarama.VEICDataSet8();
            this.acessosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.acessosTableAdapter = new Controle_Acessos_Umuarama.VEICDataSet8TableAdapters.AcessosTableAdapter();
            this.vEICDataSet9 = new Controle_Acessos_Umuarama.VEICDataSet9();
            this.tabResidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabResidTableAdapter = new Controle_Acessos_Umuarama.VEICDataSet9TableAdapters.TabResidTableAdapter();
            this.vEICDataSet10 = new Controle_Acessos_Umuarama.VEICDataSet10();
            this.tabVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabVTableAdapter = new Controle_Acessos_Umuarama.VEICDataSet10TableAdapters.TabVTableAdapter();
            this.vEICDataSet11 = new Controle_Acessos_Umuarama.VEICDataSet11();
            this.tabVBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabVTableAdapter1 = new Controle_Acessos_Umuarama.VEICDataSet11TableAdapters.TabVTableAdapter();
            this.vEICDataSet12 = new Controle_Acessos_Umuarama.VEICDataSet12();
            this.tabVBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tabVTableAdapter2 = new Controle_Acessos_Umuarama.VEICDataSet12TableAdapters.TabVTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Relatorio = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabResidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabVBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabVBindingSource2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(6, 22);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "DATA  INICIAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(284, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "DATA  FINAL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.cb_Cor);
            this.groupBox2.Controls.Add(this.cb_Modelo);
            this.groupBox2.Controls.Add(this.cb_Placa);
            this.groupBox2.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(539, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 122);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Veiculo";
            // 
            // cb_Placa
            // 
            this.cb_Placa.DataSource = this.tabVBindingSource;
            this.cb_Placa.DisplayMember = "Placa";
            this.cb_Placa.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Placa.FormattingEnabled = true;
            this.cb_Placa.Location = new System.Drawing.Point(6, 28);
            this.cb_Placa.Name = "cb_Placa";
            this.cb_Placa.Size = new System.Drawing.Size(121, 25);
            this.cb_Placa.TabIndex = 0;
            this.cb_Placa.ValueMember = "Placa";
            // 
            // cb_Modelo
            // 
            this.cb_Modelo.DataSource = this.tabVBindingSource1;
            this.cb_Modelo.DisplayMember = "Modelo";
            this.cb_Modelo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Modelo.FormattingEnabled = true;
            this.cb_Modelo.Location = new System.Drawing.Point(6, 59);
            this.cb_Modelo.Name = "cb_Modelo";
            this.cb_Modelo.Size = new System.Drawing.Size(121, 25);
            this.cb_Modelo.TabIndex = 1;
            this.cb_Modelo.ValueMember = "Modelo";
            // 
            // cb_Cor
            // 
            this.cb_Cor.DataSource = this.tabVBindingSource2;
            this.cb_Cor.DisplayMember = "Cor";
            this.cb_Cor.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Cor.FormattingEnabled = true;
            this.cb_Cor.Location = new System.Drawing.Point(6, 91);
            this.cb_Cor.Name = "cb_Cor";
            this.cb_Cor.Size = new System.Drawing.Size(121, 25);
            this.cb_Cor.TabIndex = 2;
            this.cb_Cor.ValueMember = "Cor";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_Residencia);
            this.groupBox3.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(767, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Residências";
            // 
            // cb_Residencia
            // 
            this.cb_Residencia.DataSource = this.tabResidBindingSource;
            this.cb_Residencia.DisplayMember = "Nome_Resid";
            this.cb_Residencia.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Residencia.FormattingEnabled = true;
            this.cb_Residencia.Location = new System.Drawing.Point(6, 19);
            this.cb_Residencia.Name = "cb_Residencia";
            this.cb_Residencia.Size = new System.Drawing.Size(188, 25);
            this.cb_Residencia.TabIndex = 0;
            this.cb_Residencia.ValueMember = "Nome_Resid";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_TipoReg);
            this.groupBox4.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Location = new System.Drawing.Point(539, 42);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo de Registro";
            // 
            // cb_TipoReg
            // 
            this.cb_TipoReg.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TipoReg.FormattingEnabled = true;
            this.cb_TipoReg.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.cb_TipoReg.Location = new System.Drawing.Point(6, 19);
            this.cb_TipoReg.Name = "cb_TipoReg";
            this.cb_TipoReg.Size = new System.Drawing.Size(188, 25);
            this.cb_TipoReg.TabIndex = 0;
            // 
            // vEICDataSet8
            // 
            this.vEICDataSet8.DataSetName = "VEICDataSet8";
            this.vEICDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acessosBindingSource
            // 
            this.acessosBindingSource.DataMember = "Acessos";
            this.acessosBindingSource.DataSource = this.vEICDataSet8;
            // 
            // acessosTableAdapter
            // 
            this.acessosTableAdapter.ClearBeforeFill = true;
            // 
            // vEICDataSet9
            // 
            this.vEICDataSet9.DataSetName = "VEICDataSet9";
            this.vEICDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabResidBindingSource
            // 
            this.tabResidBindingSource.DataMember = "TabResid";
            this.tabResidBindingSource.DataSource = this.vEICDataSet9;
            // 
            // tabResidTableAdapter
            // 
            this.tabResidTableAdapter.ClearBeforeFill = true;
            // 
            // vEICDataSet10
            // 
            this.vEICDataSet10.DataSetName = "VEICDataSet10";
            this.vEICDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabVBindingSource
            // 
            this.tabVBindingSource.DataMember = "TabV";
            this.tabVBindingSource.DataSource = this.vEICDataSet10;
            // 
            // tabVTableAdapter
            // 
            this.tabVTableAdapter.ClearBeforeFill = true;
            // 
            // vEICDataSet11
            // 
            this.vEICDataSet11.DataSetName = "VEICDataSet11";
            this.vEICDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabVBindingSource1
            // 
            this.tabVBindingSource1.DataMember = "TabV";
            this.tabVBindingSource1.DataSource = this.vEICDataSet11;
            // 
            // tabVTableAdapter1
            // 
            this.tabVTableAdapter1.ClearBeforeFill = true;
            // 
            // vEICDataSet12
            // 
            this.vEICDataSet12.DataSetName = "VEICDataSet12";
            this.vEICDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabVBindingSource2
            // 
            this.tabVBindingSource2.DataMember = "TabV";
            this.tabVBindingSource2.DataSource = this.vEICDataSet12;
            // 
            // tabVTableAdapter2
            // 
            this.tabVTableAdapter2.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(859, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Relatorio
            // 
            this.btn_Relatorio.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Relatorio.Location = new System.Drawing.Point(767, 233);
            this.btn_Relatorio.Name = "btn_Relatorio";
            this.btn_Relatorio.Size = new System.Drawing.Size(86, 46);
            this.btn_Relatorio.TabIndex = 8;
            this.btn_Relatorio.Text = "GERAR RELATÓRIO";
            this.btn_Relatorio.UseVisualStyleBackColor = true;
            this.btn_Relatorio.Click += new System.EventHandler(this.btn_Relatorio_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(179, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(179, 70);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(179, 102);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Click += new System.EventHandler(this.checkBox3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 202);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(7, 22);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.monthCalendar2);
            this.groupBox5.Location = new System.Drawing.Point(271, 39);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(241, 202);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(979, 297);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Relatorio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio";
            this.Load += new System.EventHandler(this.Relatorio_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabResidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabVBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabVBindingSource2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_Cor;
        private System.Windows.Forms.ComboBox cb_Modelo;
        private System.Windows.Forms.ComboBox cb_Placa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb_Residencia;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cb_TipoReg;
        private VEICDataSet8 vEICDataSet8;
        private System.Windows.Forms.BindingSource acessosBindingSource;
        private VEICDataSet8TableAdapters.AcessosTableAdapter acessosTableAdapter;
        private VEICDataSet9 vEICDataSet9;
        private System.Windows.Forms.BindingSource tabResidBindingSource;
        private VEICDataSet9TableAdapters.TabResidTableAdapter tabResidTableAdapter;
        private VEICDataSet10 vEICDataSet10;
        private System.Windows.Forms.BindingSource tabVBindingSource;
        private VEICDataSet10TableAdapters.TabVTableAdapter tabVTableAdapter;
        private VEICDataSet11 vEICDataSet11;
        private System.Windows.Forms.BindingSource tabVBindingSource1;
        private VEICDataSet11TableAdapters.TabVTableAdapter tabVTableAdapter1;
        private VEICDataSet12 vEICDataSet12;
        private System.Windows.Forms.BindingSource tabVBindingSource2;
        private VEICDataSet12TableAdapters.TabVTableAdapter tabVTableAdapter2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Relatorio;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

namespace Controle_Acessos_Umuarama
{
    partial class Registros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registros));
            this.CB_Placa = new System.Windows.Forms.ComboBox();
            this.tabVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEICDataSet4 = new Controle_Acessos_Umuarama.VEICDataSet4();
            this.tabVTableAdapter = new Controle_Acessos_Umuarama.VEICDataSet4TableAdapters.TabVTableAdapter();
            this.CB_Modelo = new System.Windows.Forms.ComboBox();
            this.CB_Cor = new System.Windows.Forms.ComboBox();
            this.CB_Motorista = new System.Windows.Forms.ComboBox();
            this.tabMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEICDataSet5 = new Controle_Acessos_Umuarama.VEICDataSet5();
            this.tabMTableAdapter = new Controle_Acessos_Umuarama.VEICDataSet5TableAdapters.TabMTableAdapter();
            this.CB_RG = new System.Windows.Forms.ComboBox();
            this.CB_Resid = new System.Windows.Forms.ComboBox();
            this.tabResidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEICDataSet6 = new Controle_Acessos_Umuarama.VEICDataSet6();
            this.tabResidTableAdapter = new Controle_Acessos_Umuarama.VEICDataSet6TableAdapters.TabResidTableAdapter();
            this.Rb_Entrada = new System.Windows.Forms.RadioButton();
            this.Rb_Saida = new System.Windows.Forms.RadioButton();
            this.Btn_SalvarReg = new System.Windows.Forms.Button();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Txt_Data = new System.Windows.Forms.TextBox();
            this.Txt_Tipo_Reg = new System.Windows.Forms.TextBox();
            this.Txt_Horas = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LblHora = new System.Windows.Forms.Label();
            this.Horas = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabResidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_Placa
            // 
            this.CB_Placa.DataSource = this.tabVBindingSource;
            this.CB_Placa.DisplayMember = "Placa";
            this.CB_Placa.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Placa.FormattingEnabled = true;
            this.CB_Placa.Location = new System.Drawing.Point(32, 74);
            this.CB_Placa.Name = "CB_Placa";
            this.CB_Placa.Size = new System.Drawing.Size(121, 23);
            this.CB_Placa.TabIndex = 11;
            this.CB_Placa.ValueMember = "Placa";
            // 
            // tabVBindingSource
            // 
            this.tabVBindingSource.DataMember = "TabV";
            this.tabVBindingSource.DataSource = this.vEICDataSet4;
            // 
            // vEICDataSet4
            // 
            this.vEICDataSet4.DataSetName = "VEICDataSet4";
            this.vEICDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabVTableAdapter
            // 
            this.tabVTableAdapter.ClearBeforeFill = true;
            // 
            // CB_Modelo
            // 
            this.CB_Modelo.DataSource = this.tabVBindingSource;
            this.CB_Modelo.DisplayMember = "Modelo";
            this.CB_Modelo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Modelo.FormattingEnabled = true;
            this.CB_Modelo.Location = new System.Drawing.Point(159, 74);
            this.CB_Modelo.Name = "CB_Modelo";
            this.CB_Modelo.Size = new System.Drawing.Size(121, 23);
            this.CB_Modelo.TabIndex = 12;
            this.CB_Modelo.ValueMember = "Modelo";
            // 
            // CB_Cor
            // 
            this.CB_Cor.DataSource = this.tabVBindingSource;
            this.CB_Cor.DisplayMember = "Cor";
            this.CB_Cor.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Cor.FormattingEnabled = true;
            this.CB_Cor.Location = new System.Drawing.Point(286, 74);
            this.CB_Cor.Name = "CB_Cor";
            this.CB_Cor.Size = new System.Drawing.Size(121, 23);
            this.CB_Cor.TabIndex = 13;
            this.CB_Cor.ValueMember = "Cor";
            // 
            // CB_Motorista
            // 
            this.CB_Motorista.DataSource = this.tabMBindingSource;
            this.CB_Motorista.DisplayMember = "Nome";
            this.CB_Motorista.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Motorista.FormattingEnabled = true;
            this.CB_Motorista.Location = new System.Drawing.Point(413, 74);
            this.CB_Motorista.Name = "CB_Motorista";
            this.CB_Motorista.Size = new System.Drawing.Size(121, 23);
            this.CB_Motorista.TabIndex = 14;
            this.CB_Motorista.ValueMember = "Nome";
            // 
            // tabMBindingSource
            // 
            this.tabMBindingSource.DataMember = "TabM";
            this.tabMBindingSource.DataSource = this.vEICDataSet5;
            // 
            // vEICDataSet5
            // 
            this.vEICDataSet5.DataSetName = "VEICDataSet5";
            this.vEICDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabMTableAdapter
            // 
            this.tabMTableAdapter.ClearBeforeFill = true;
            // 
            // CB_RG
            // 
            this.CB_RG.DataSource = this.tabMBindingSource;
            this.CB_RG.DisplayMember = "Rg";
            this.CB_RG.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_RG.FormattingEnabled = true;
            this.CB_RG.Location = new System.Drawing.Point(540, 74);
            this.CB_RG.Name = "CB_RG";
            this.CB_RG.Size = new System.Drawing.Size(121, 23);
            this.CB_RG.TabIndex = 15;
            this.CB_RG.ValueMember = "Rg";
            // 
            // CB_Resid
            // 
            this.CB_Resid.DataSource = this.tabResidBindingSource;
            this.CB_Resid.DisplayMember = "Nome_Resid";
            this.CB_Resid.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Resid.FormattingEnabled = true;
            this.CB_Resid.Location = new System.Drawing.Point(667, 74);
            this.CB_Resid.Name = "CB_Resid";
            this.CB_Resid.Size = new System.Drawing.Size(121, 23);
            this.CB_Resid.TabIndex = 16;
            this.CB_Resid.ValueMember = "Nome_Resid";
            // 
            // tabResidBindingSource
            // 
            this.tabResidBindingSource.DataMember = "TabResid";
            this.tabResidBindingSource.DataSource = this.vEICDataSet6;
            // 
            // vEICDataSet6
            // 
            this.vEICDataSet6.DataSetName = "VEICDataSet6";
            this.vEICDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabResidTableAdapter
            // 
            this.tabResidTableAdapter.ClearBeforeFill = true;
            // 
            // Rb_Entrada
            // 
            this.Rb_Entrada.AutoSize = true;
            this.Rb_Entrada.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_Entrada.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Rb_Entrada.Location = new System.Drawing.Point(341, 117);
            this.Rb_Entrada.Name = "Rb_Entrada";
            this.Rb_Entrada.Size = new System.Drawing.Size(72, 21);
            this.Rb_Entrada.TabIndex = 17;
            this.Rb_Entrada.TabStop = true;
            this.Rb_Entrada.Text = "ENTRADA";
            this.Rb_Entrada.UseVisualStyleBackColor = true;
            // 
            // Rb_Saida
            // 
            this.Rb_Saida.AutoSize = true;
            this.Rb_Saida.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_Saida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Rb_Saida.Location = new System.Drawing.Point(448, 117);
            this.Rb_Saida.Name = "Rb_Saida";
            this.Rb_Saida.Size = new System.Drawing.Size(58, 21);
            this.Rb_Saida.TabIndex = 18;
            this.Rb_Saida.TabStop = true;
            this.Rb_Saida.Text = "SAÍDA";
            this.Rb_Saida.UseVisualStyleBackColor = true;
            // 
            // Btn_SalvarReg
            // 
            this.Btn_SalvarReg.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarReg.Location = new System.Drawing.Point(336, 190);
            this.Btn_SalvarReg.Name = "Btn_SalvarReg";
            this.Btn_SalvarReg.Size = new System.Drawing.Size(96, 35);
            this.Btn_SalvarReg.TabIndex = 20;
            this.Btn_SalvarReg.Text = "SALVAR";
            this.Btn_SalvarReg.UseVisualStyleBackColor = true;
            this.Btn_SalvarReg.Click += new System.EventHandler(this.Btn_SalvarReg_Click);
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fechar.Location = new System.Drawing.Point(444, 190);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(90, 35);
            this.Btn_Fechar.TabIndex = 21;
            this.Btn_Fechar.Text = "FECHAR";
            this.Btn_Fechar.UseVisualStyleBackColor = true;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(29, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "PLACA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(159, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "MODELO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(283, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "COR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(410, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "MOTORISTA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(540, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "RG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(667, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "RESIDÊNCIA";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 21);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // Txt_Data
            // 
            this.Txt_Data.Location = new System.Drawing.Point(12, 248);
            this.Txt_Data.Name = "Txt_Data";
            this.Txt_Data.Size = new System.Drawing.Size(159, 20);
            this.Txt_Data.TabIndex = 29;
            this.Txt_Data.Visible = false;
            this.Txt_Data.TextChanged += new System.EventHandler(this.Txt_Data_TextChanged);
            // 
            // Txt_Tipo_Reg
            // 
            this.Txt_Tipo_Reg.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Tipo_Reg.Location = new System.Drawing.Point(381, 140);
            this.Txt_Tipo_Reg.Name = "Txt_Tipo_Reg";
            this.Txt_Tipo_Reg.Size = new System.Drawing.Size(100, 23);
            this.Txt_Tipo_Reg.TabIndex = 31;
            this.Txt_Tipo_Reg.TextChanged += new System.EventHandler(this.Txt_Tipo_Reg_TextChanged);
            // 
            // Txt_Horas
            // 
            this.Txt_Horas.Location = new System.Drawing.Point(180, 248);
            this.Txt_Horas.Name = "Txt_Horas";
            this.Txt_Horas.Size = new System.Drawing.Size(100, 20);
            this.Txt_Horas.TabIndex = 32;
            this.Txt_Horas.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(649, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 35);
            this.button1.TabIndex = 33;
            this.button1.Text = "CONSULTAR  ACESSOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LblHora.Location = new System.Drawing.Point(689, 9);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(60, 23);
            this.LblHora.TabIndex = 35;
            this.LblHora.Text = "label9";
            // 
            // Horas
            // 
            this.Horas.Enabled = true;
            this.Horas.Tick += new System.EventHandler(this.Horas_Tick);
            // 
            // Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(802, 285);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt_Horas);
            this.Controls.Add(this.Txt_Tipo_Reg);
            this.Controls.Add(this.Txt_Data);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Fechar);
            this.Controls.Add(this.Btn_SalvarReg);
            this.Controls.Add(this.Rb_Saida);
            this.Controls.Add(this.Rb_Entrada);
            this.Controls.Add(this.CB_Resid);
            this.Controls.Add(this.CB_RG);
            this.Controls.Add(this.CB_Motorista);
            this.Controls.Add(this.CB_Cor);
            this.Controls.Add(this.CB_Modelo);
            this.Controls.Add(this.CB_Placa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Registros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Acesso";
            this.Load += new System.EventHandler(this.Registros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabResidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEICDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CB_Placa;
        private VEICDataSet4 vEICDataSet4;
        private System.Windows.Forms.BindingSource tabVBindingSource;
        private VEICDataSet4TableAdapters.TabVTableAdapter tabVTableAdapter;
        private System.Windows.Forms.ComboBox CB_Modelo;
        private System.Windows.Forms.ComboBox CB_Cor;
        private System.Windows.Forms.ComboBox CB_Motorista;
        private VEICDataSet5 vEICDataSet5;
        private System.Windows.Forms.BindingSource tabMBindingSource;
        private VEICDataSet5TableAdapters.TabMTableAdapter tabMTableAdapter;
        private System.Windows.Forms.ComboBox CB_RG;
        private System.Windows.Forms.ComboBox CB_Resid;
        private VEICDataSet6 vEICDataSet6;
        private System.Windows.Forms.BindingSource tabResidBindingSource;
        private VEICDataSet6TableAdapters.TabResidTableAdapter tabResidTableAdapter;
        private System.Windows.Forms.RadioButton Rb_Entrada;
        private System.Windows.Forms.RadioButton Rb_Saida;
        private System.Windows.Forms.Button Btn_SalvarReg;
        private System.Windows.Forms.Button Btn_Fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox Txt_Data;
        private System.Windows.Forms.TextBox Txt_Tipo_Reg;
        private System.Windows.Forms.TextBox Txt_Horas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Timer Horas;
    }
}

namespace Painel_de_controle_do_mugen
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
            this.button1 = new System.Windows.Forms.Button();
            this.procurarmugen = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.aleatoriobt = new System.Windows.Forms.RadioButton();
            this.exebitionbt = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button8 = new System.Windows.Forms.Button();
            this.loop_check = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button9 = new System.Windows.Forms.Button();
            this.dataSet1 = new Painel_de_controle_do_mugen.DataSet1();
            this.reg_de_lutasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reg_de_lutasTableAdapter = new Painel_de_controle_do_mugen.DataSet1TableAdapters.Reg_de_lutasTableAdapter();
            this.tableAdapterManager = new Painel_de_controle_do_mugen.DataSet1TableAdapters.TableAdapterManager();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.reg_de_lutasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_de_lutasBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reg_de_lutasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "local do mugen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bt_local_mugen);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "mugen -h";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.bt_testar_mugen);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(226, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 24);
            this.button3.TabIndex = 2;
            this.button3.Text = "personagens habilitados";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(226, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 24);
            this.button4.TabIndex = 3;
            this.button4.Text = "todos os personagens";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(226, 130);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 24);
            this.button5.TabIndex = 4;
            this.button5.Text = "atualizar mapas";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.aleatoriobt);
            this.groupBox1.Controls.Add(this.exebitionbt);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 90);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "modo de jogo";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(76, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Pre-partida";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // aleatoriobt
            // 
            this.aleatoriobt.AutoSize = true;
            this.aleatoriobt.Checked = true;
            this.aleatoriobt.Location = new System.Drawing.Point(6, 42);
            this.aleatoriobt.Name = "aleatoriobt";
            this.aleatoriobt.Size = new System.Drawing.Size(66, 17);
            this.aleatoriobt.TabIndex = 1;
            this.aleatoriobt.TabStop = true;
            this.aleatoriobt.Text = "Aleatorio";
            this.aleatoriobt.UseVisualStyleBackColor = true;
            this.aleatoriobt.CheckedChanged += new System.EventHandler(this.aleatoriobt_CheckedChanged);
            // 
            // exebitionbt
            // 
            this.exebitionbt.AutoSize = true;
            this.exebitionbt.Location = new System.Drawing.Point(6, 19);
            this.exebitionbt.Name = "exebitionbt";
            this.exebitionbt.Size = new System.Drawing.Size(65, 17);
            this.exebitionbt.TabIndex = 0;
            this.exebitionbt.Text = "Exibição";
            this.exebitionbt.UseVisualStyleBackColor = true;
            this.exebitionbt.CheckedChanged += new System.EventHandler(this.exebition_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 103);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "controle de exibição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "MAPA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "P2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "P1";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(42, 73);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(42, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(42, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(134, 70);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 24);
            this.button6.TabIndex = 13;
            this.button6.Text = "testar mugen";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.bt_testar_mugen2);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(226, 160);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 23);
            this.button8.TabIndex = 14;
            this.button8.Text = "rodar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // loop_check
            // 
            this.loop_check.AutoSize = true;
            this.loop_check.Location = new System.Drawing.Point(226, 189);
            this.loop_check.Name = "loop_check";
            this.loop_check.Size = new System.Drawing.Size(46, 17);
            this.loop_check.TabIndex = 15;
            this.loop_check.Text = "loop";
            this.loop_check.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(290, 189);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 17);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "pre-partida";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(226, 216);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(140, 23);
            this.button9.TabIndex = 17;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reg_de_lutasBindingSource
            // 
            this.reg_de_lutasBindingSource.DataMember = "Reg_de_lutas";
            this.reg_de_lutasBindingSource.DataSource = this.dataSet1;
            // 
            // reg_de_lutasTableAdapter
            // 
            this.reg_de_lutasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Reg_de_lutasTableAdapter = this.reg_de_lutasTableAdapter;
            this.tableAdapterManager.UpdateOrder = Painel_de_controle_do_mugen.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataTableToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(382, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataTableToolStripMenuItem
            // 
            this.dataTableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem,
            this.importarToolStripMenuItem});
            this.dataTableToolStripMenuItem.Name = "dataTableToolStripMenuItem";
            this.dataTableToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.dataTableToolStripMenuItem.Text = "DataTable";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xmlToolStripMenuItem,
            this.csvToolStripMenuItem});
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.exportarToolStripMenuItem.Text = "exportar";
            // 
            // xmlToolStripMenuItem
            // 
            this.xmlToolStripMenuItem.Name = "xmlToolStripMenuItem";
            this.xmlToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.xmlToolStripMenuItem.Text = ".xml";
            this.xmlToolStripMenuItem.Click += new System.EventHandler(this.xmlToolStripMenuItem_Click);
            // 
            // csvToolStripMenuItem
            // 
            this.csvToolStripMenuItem.Name = "csvToolStripMenuItem";
            this.csvToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.csvToolStripMenuItem.Text = ".csv";
            this.csvToolStripMenuItem.Click += new System.EventHandler(this.csvToolStripMenuItem_Click);
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.importarToolStripMenuItem.Text = "importar";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // reg_de_lutasDataGridView
            // 
            this.reg_de_lutasDataGridView.AutoGenerateColumns = false;
            this.reg_de_lutasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reg_de_lutasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.reg_de_lutasDataGridView.DataSource = this.reg_de_lutasBindingSource;
            this.reg_de_lutasDataGridView.Location = new System.Drawing.Point(12, 278);
            this.reg_de_lutasDataGridView.Name = "reg_de_lutasDataGridView";
            this.reg_de_lutasDataGridView.Size = new System.Drawing.Size(355, 220);
            this.reg_de_lutasDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Personagem";
            this.dataGridViewTextBoxColumn2.HeaderText = "Personagem";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Partidas";
            this.dataGridViewTextBoxColumn3.HeaderText = "Partidas";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Vitorias";
            this.dataGridViewTextBoxColumn4.HeaderText = "Vitorias";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "vitpercnt";
            this.dataGridViewTextBoxColumn5.HeaderText = "vitpercnt";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "tier";
            this.dataGridViewTextBoxColumn6.HeaderText = "tier";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Pasta";
            this.dataGridViewTextBoxColumn7.HeaderText = "Pasta";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(254, 245);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 512);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.reg_de_lutasDataGridView);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.loop_check);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Painel de controle mugen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_de_lutasBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reg_de_lutasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog procurarmugen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton exebitionbt;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton aleatoriobt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.CheckBox loop_check;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.BindingSource reg_de_lutasBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.Reg_de_lutasTableAdapter reg_de_lutasTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csvToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView reg_de_lutasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button7;
    }
}


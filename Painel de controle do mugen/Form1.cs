using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painel_de_controle_do_mugen
{
    public partial class Form1 : Form
    {
        //variaveis gerais 

        string caminho_pasta;
        Process mugen = new Process();
        string argumentos;
        string[] Chars;
        string[] Mapas;
        SecureString psw = new NetworkCredential("", "cacho").SecurePassword;
        Form2 bg = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        //funçoes 

        int trick()
        {
            FormCollection fc = Application.OpenForms;
            int i = 0;
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "Form2")
                {
                    i++;
                }
            }
            return i;
        }

        string Getname(int p)
        {
            string[] line = File.ReadAllLines(caminho_pasta + @"\chars\" + Chars[p] + @"\" + Chars[p] + ".def");
            string name = "";
            string[] a = { "" };
            foreach(string s in line)
            {
                if (s.Contains("name") || s.Contains("Name"))
                {
                    name = s;
                    break;
                }
            }
            a = name.Split('"');
            return a[1];
        }

        void aviso(int i)
        {
            switch (i)
            {
                case 1:
                    MessageBox.Show("caminho da pasta não especificado", "fez cagada");
                    break;
                case 2:
                    MessageBox.Show("Sem pesonagens", "Funcionou");
                    break;
                case 3:
                    MessageBox.Show("Sem mapas", "fez cagada");
                    break;
                case 4:
                    MessageBox.Show("mugen não encontrado", "fez cagada");
                    break;
                case 5:
                    MessageBox.Show("exportado com sucesso", "fez cagada");
                    break;
                case 6:
                    MessageBox.Show("importado com sucesso", "fez cagada");
                    break;
            }
        }
        bool check_mugen()
        {
            try
            {
                mugen.Start();
                mugen.Kill();
                return true;
            }
            catch
            {
                return false;
            }
        }
        bool checagem()
        {
            if(caminho_pasta == null)
            {
                aviso(1);
                return false;
            }
            else if(Chars == null)
            {
                aviso(2);
                return false;
            }
            else if(Mapas == null)
            {
                aviso(3);
                return false;
            }
            else if(check_mugen() == false)
            {
                aviso(4);
                return false;
            }
            else
            {
                return true;
            }
        }
        void registrar_luta(string[] log,int[] pa)
        {
            string[] p = { log[9].Replace("p1.name = ", ""), log[12].Replace("p2.name = ", "") };
            int part;
            int[] V = { 0, 0 };

            if (log.Length < 27) { part = 2; }
            else { part = 3; }
            if (int.Parse(log[7].Replace("winningteam = ", "")) == 1) { V[0]++; } else { V[1]++; }
            if (int.Parse(log[17].Replace("winningteam = ", "")) == 1) { V[0]++; } else { V[1]++; }
            if(part == 3) { if (int.Parse(log[27].Replace("winningteam = ", "")) == 1) { V[0]++; } else { V[1]++; } }
            if (p[0] == p[1]) { }
            else
            {

                for (int i = 0; i < 2; i++)
                {
                    if (dataSet1.Reg_de_lutas.AsEnumerable().Any(row => p[i] == row.Field<String>("Personagem")) == true)
                    {
                        DataRow[] teste = dataSet1.Reg_de_lutas.Select("Personagem = '" + p[i] + "'");
                        int auxp = (int)teste[0]["Partidas"] + part;
                        int auxv = (int)teste[0]["Partidas"] + V[i];
                        teste[0]["Partidas"] = auxp;
                        teste[0]["Vitorias"] = auxv;
                        teste[0]["vitpercnt"] = (int)(0.5f + ((100f * auxv) / auxp));
                    }
                    else
                    {
                        DataRow reg = dataSet1.Reg_de_lutas.NewReg_de_lutasRow();
                        reg["Pasta"] = Chars[pa[i]];
                        reg["Personagem"] = p[i];
                        reg["Partidas"] = part;
                        reg["Vitorias"] = V[i];
                        reg["vitpercnt"] = (int)(0.5f + ((100f * V[i]) / part));
                        reg["tier"] = '?';
                        dataSet1.Reg_de_lutas.Rows.Add(reg);
                    }
                }
            }
        }
        void randombt()
        {
            Random rnd = new Random(DateTime.Now.Millisecond * DateTime.Now.Minute * DateTime.Now.Second);
            int[] p = { rnd.Next(Chars.Length), rnd.Next(Chars.Length)};
            int mp = rnd.Next(Mapas.Length);
            string[] log;
            bg.
            if (checkBox2.Checked)
            {
                argumentos = Chars[p[0]] + " " + Chars[p[1]] + " -s " + Mapas[mp] + " -rounds 1 -r mugen2  -log h.log";
                mugen.StartInfo.Arguments = argumentos;
                mugen.Start();
                mugen.WaitForExit();
            }
            argumentos = Chars[p[0]] + " " + Chars[p[1]] + " -s " + Mapas[mp] + " -p1.ai 8 -p2.ai 8  -rounds 2  -log battle.log";
            mugen.StartInfo.Arguments = argumentos;
            mugen.Start();
            mugen.WaitForExit();
            System.Threading.Thread.Sleep(1000);
            log = File.ReadAllLines(Path.Combine(caminho_pasta, "battle.log"));
            registrar_luta(log,p);
            dataSet1.Reg_de_lutas.WriteXml(Path.Combine(caminho_pasta, "autoRegistro.xml"));
            if (loop_check.Checked)
            {
                timer1.Enabled = true;
                timer1.Stop();
                timer1.Start();
            }
        }
        void exibitionbt()
        {
            if (checkBox2.Checked)
            {
                argumentos = comboBox1.SelectedItem.ToString() + " " + comboBox2.SelectedItem.ToString() + " -s " + comboBox3.SelectedItem.ToString() + " -rounds 1 -r mugen2  -log h.log";
                mugen.StartInfo.Arguments = argumentos;
                mugen.Start();
                while (mugen.HasExited == false) { }
            }
            argumentos = comboBox1.SelectedItem.ToString() + " " + comboBox2.SelectedItem.ToString() + " -s " + comboBox3.SelectedItem.ToString() + " -p1.ai 8 -p2.ai 8  -rounds 2  -log battle.log";
            mugen.StartInfo.Arguments = argumentos;
            mugen.Start();
            while (mugen.HasExited == false) { }
        }
        void refresh()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox1.Items.AddRange(Chars);
            comboBox2.Items.AddRange(Chars);
        }

        //funções do forms

        private void bt_local_mugen(object sender, EventArgs e)
        {
            if (procurarmugen.ShowDialog() == DialogResult.OK)
            {
                caminho_pasta = procurarmugen.SelectedPath;

                string caminho_mugen = Path.Combine(caminho_pasta, "mugen");
                mugen.StartInfo.FileName = caminho_mugen;
                mugen.StartInfo.Arguments = argumentos;
                mugen.StartInfo.UseShellExecute = false;
                mugen.StartInfo.Domain = null;
                mugen.StartInfo.UserName = "Nicolas";
                mugen.StartInfo.Password = psw;
                mugen.StartInfo.WorkingDirectory = caminho_pasta;
            }
        }
        private void bt_testar_mugen(object sender, EventArgs e)
        {
            if(checagem() == false ) {}
            else
            {
                mugen.StartInfo.Arguments = "-h";
                mugen.Start();
                mugen.StartInfo.Arguments = argumentos;
            }
            
        }
        private void bt_testar_mugen2(object sender, EventArgs e)
        {
            if(caminho_pasta == null)
            {
                aviso(1);
            }
            else
            {
                
                mugen.StartInfo.Arguments = "kfm kfm -s kfm -p1.ai 8 -p2.ai 8  -rounds 1  -log teste.log";
                mugen.Start();
                mugen.StartInfo.Arguments = argumentos;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                Chars = File.ReadAllLines(path);
                refresh();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (checagem() == false){}
            else
            {
                if (exebitionbt.Checked) 
                {
                    exibitionbt();
                }
                else if (aleatoriobt.Checked) 
                {
                    randombt();
                }
                else if (radioButton3.Checked) 
                { 
                    argumentos = " kfm kfm -s kfm -r mugen2  -rounds 1  -log h.log";
                    mugen.StartInfo.Arguments = argumentos;
                    mugen.Start();
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if(caminho_pasta == null)
            {
                aviso(1);
            }
            else
            {
                Mapas = Directory.GetFiles(Path.Combine(caminho_pasta, "stages"), "*.def").Select(fileName => Path.GetFileNameWithoutExtension(fileName)).ToArray();
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(Mapas);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (loop_check.Checked)
            {
                randombt();
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (trick() > 0)
            {
            }
            else
            {
                bg.Show();
            }
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Chars = Directory.GetDirectories(Path.Combine(caminho_pasta, "chars")).Select(Path.GetFileName).ToArray();
            refresh();
        }
        private void reg_de_lutasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reg_de_lutasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }
        private void xmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(caminho_pasta == null)
            {
                aviso(1);
            }
            else
            {
                dataSet1.Reg_de_lutas.WriteXml(Path.Combine(caminho_pasta, "Registro.xml"));
            }
        }
        private void csvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (caminho_pasta == null)
            {
                aviso(1);
            }
            else
            {
                var lines = new List<string>();

                string[] columnNames = dataSet1.Reg_de_lutas.Columns
                    .Cast<DataColumn>()
                    .Select(column => column.ColumnName)
                    .ToArray();

                var header = string.Join(",", columnNames.Select(name => $"\"{name}\""));
                lines.Add(header);

                var valueLines = dataSet1.Reg_de_lutas.AsEnumerable()
                    .Select(row => string.Join(",", row.ItemArray.Select(val => $"\"{val}\"")));

                lines.AddRange(valueLines);

                File.WriteAllLines(caminho_pasta + "\\Registro.csv", lines);
            }
        }
        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dataSet1.Reg_de_lutas.ReadXml(openFileDialog1.FileName);
                aviso(6);
            }
        }
        private void exebition_CheckedChanged(object sender, EventArgs e)
        {
            if (exebitionbt.Checked)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }
        private void aleatoriobt_CheckedChanged(object sender, EventArgs e)
        {
            if (aleatoriobt.Checked)
            {
                loop_check.Enabled = true;
            }
            else
            {
                loop_check.Enabled = false; 
                loop_check.Checked = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}

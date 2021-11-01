using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painel_de_controle_do_mugen
{
    public partial class Form3 : Form
    {
        string caminho_pasta;
        Process mugen = new Process();
        SecureString psw = new NetworkCredential("", "cacho").SecurePassword;
        
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                caminho_pasta = folderBrowserDialog1.SelectedPath;

                string caminho_mugen = Path.Combine(caminho_pasta, "mugen");
                mugen.StartInfo.FileName = caminho_mugen;
                mugen.StartInfo.UseShellExecute = false;
                mugen.StartInfo.Domain = null;
                mugen.StartInfo.UserName = "Nicolas";
                mugen.StartInfo.Password = psw;
                mugen.StartInfo.RedirectStandardError = true;
                mugen.StartInfo.RedirectStandardOutput = true;
                mugen.StartInfo.WorkingDirectory = caminho_pasta;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Chars;
            Chars = Directory.GetDirectories(Path.Combine(caminho_pasta, "chars")).Select(Path.GetFileName).ToArray();
            foreach(string C in Chars)
            {
                mugen.StartInfo.Arguments = C + " " + C +" -s kfm -rounds 1";
                mugen.Start();
                if (!mugen.WaitForExit(10000))
                {
                    mugen.Kill();
                    richTextBox1.AppendText(C);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] Mapas;
            Mapas = Directory.GetFiles(Path.Combine(caminho_pasta, "stages"), "*.def").Select(fileName => Path.GetFileNameWithoutExtension(fileName)).ToArray();
            foreach (string M in Mapas)
            {
                mugen.StartInfo.Arguments = " kfm kfm -s " + M + " -rounds 1";
                mugen.Start();
                if (!mugen.WaitForExit(4000))
                {
                    mugen.Kill();
                    richTextBox1.AppendText(M);
                }
            }
        }
    }
}

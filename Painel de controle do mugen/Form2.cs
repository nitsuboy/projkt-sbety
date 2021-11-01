using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painel_de_controle_do_mugen
{
    public partial class Form2 : Form
    {

        Bitmap bg = new Bitmap(Properties.Resources.wallpaper);
        public Form2()
        {
            InitializeComponent();    
        }
        public void anunciar(string VS,string MP)
        {
            Graphics formGraphics = this.CreateGraphics();
            Font drawFont = new Font("Impact", 40);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            float y = 260;
            StringFormat drawFormat = new StringFormat();
            formGraphics.DrawString(VS, drawFont, drawBrush, 640 - (TextRenderer.MeasureText(VS, drawFont).Width / 2), y, drawFormat);
            formGraphics.DrawString("em", drawFont, drawBrush, 640 - (TextRenderer.MeasureText("em", drawFont).Width / 2), y+50, drawFormat);
            formGraphics.DrawString(MP, drawFont, drawBrush, 640 - (TextRenderer.MeasureText(MP, drawFont).Width / 2), y+100, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
            formGraphics.Dispose();
        }
        public void reiniciar()
        {
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawImage(bg,0,0,1280,720);
            formGraphics.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConversorCores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btRGBtoHSV_Click(object sender, EventArgs e)
        {

            // pega ops valores  de R, G e B 
            int red = (int)numericUpDownRed.Value;
            int green = (int)numericUpDownGreen.Value;
            int blue = (int)numericUpDownBlue.Value;


            //valida se os valores estão entre 0 e 255
            if (red < 0 || red > 255 || green < 0 || green > 255 || blue < 0 || blue > 255)
            {
                MessageBox.Show("Os valores de R, G, B devem estar entre 0 e 255.");
                return;
            }

            // Converte RGB para HSV
            double[] hsv = RGBToHSV(red, green, blue);

            string hsvString = string.Format(" H={0:F2}%\r\n S={1:F2}\r\n V={2:F2}\r\n", hsv[0], hsv[1], hsv[2]);
            txResultadoRGB.Text = hsvString;
        }

        // Função RGB para HSV
        private double[] RGBToHSV(int red, int green, int blue)
        {
            double min, max, delta;
            double h = 0, s, v;

            double r = red / 255.0;
            double g = green / 255.0;
            double b = blue / 255.0;

            min = Math.Min(Math.Min(r, g), b);
            max = Math.Max(Math.Max(r, g), b);
            v = max;                // V = max RGB

            delta = max - min;

            if (max != 0)
            {
                s = delta / max;    // Saturação é o delta em relação a V
            }
            else
            {
                //se todos forem 0, indica uma imagem cinza
                s = 0;
                h = -1;             // H indefinido
                return new double[] { h, s, v };
            }

            if (r == max)
                h = (g - b) / delta;        // entre amarelo e magenta
            else if (g == max)
                h = 2 + (b - r) / delta;    // entre ciano e amarelo
            else
                h = 4 + (r - g) / delta;    // entre magenta e ciano

            h *= 60;                        // converter para graus
            if (h < 0)
                h += 360;

            return new double[] { h, s, v };
        }
        private void btRGBtoCMYK_Click(object sender, EventArgs e)
        {
            // pega ops valores  de R, G e B 
            int red = (int)numericUpDownRed.Value;
            int green = (int)numericUpDownGreen.Value;
            int blue = (int)numericUpDownBlue.Value;


            //valida se os valores estão entre 0 e 255
            if (red < 0 || red > 255 || green < 0 || green > 255 || blue < 0 || blue > 255)
            {
                MessageBox.Show("Os valores de R, G, B devem estar entre 0 e 255.");
                return;
            }

            // Calcula os valores de R, G e B normalizados
            double r = red / 255.0;
            double g = green / 255.0;
            double b = blue / 255.0;

            // Calcula o valor de K
            double k = 1 - Math.Max(r, Math.Max(g, b));

            // Verifica se os valores são NaN e define como 0
            if (double.IsNaN(k)) k = 0;

            // Calcula os valores de C, M e Y
            double c = 0, m = 0, y = 0;
            if (k < 1)
            {
                c = (1 - r - k) / (1 - k);
                m = (1 - g - k) / (1 - k);
                y = (1 - b - k) / (1 - k);
            }

            // Arredonda os valores com duas casas decimais
            c = Math.Round(c, 2);
            m = Math.Round(m, 2);
            y = Math.Round(y, 2);
            k = Math.Round(k, 2);

            // Exibe o resultado
            string cmykResult = string.Format(" C: {0:F2}\r\n M: {1:F2}\r\n Y: {2:F2}\r\n K: {3:F2}\r\n", c, m, y, k);
            txResultadoRGB.Text = cmykResult;

        }

        private void btRGBtoGrayScale_Click(object sender, EventArgs e)
        {
            // pega ops valores  de R, G e B 
            int red = (int)numericUpDownRed.Value;
            int green = (int)numericUpDownGreen.Value;
            int blue = (int)numericUpDownBlue.Value;


            //valida se os valores estão entre 0 e 255
            if (red < 0 || red > 255 || green < 0 || green > 255 || blue < 0 || blue > 255)
            {
                MessageBox.Show("Os valores de R, G, B devem estar entre 0 e 255.");
                return;
            }
         
            int grayScale = RGBToGrayScale(red, green, blue);

           
            txResultadoRGB.Text = grayScale.ToString();
        }

        // Função RGB para escala de cinza
        private int RGBToGrayScale(int red, int green, int blue)
        {
            // Aplica a média ponderada dos componentes RGB
            int gray = (int)(0.3 * red + 0.59 * green + 0.11 * blue);

            return gray;
        }

        private void btRGBtoNORMALIZE_Click(object sender, EventArgs e)
        {
            // Pega os valores de R, G e B 
            int red = (int)numericUpDownRed.Value;
            int green = (int)numericUpDownGreen.Value;
            int blue = (int)numericUpDownBlue.Value;

            // Verifica se os campos de input estão preenchidos corretamente
            if (red < 0 || red > 255 || green < 0 || green > 255 || blue < 0 || blue > 255)
            {
                MessageBox.Show("Os valores de R, G, B devem estar entre 0 e 255.");
                return;
            }

            double soma = red + green + blue;

            // Normaliza os valores dividindo pelo total
            double rNorm = red / soma;
            double gNorm = green / soma;
            double bNorm = blue / soma;

            // Verifica se os valores são NaN e define-os como 0, se necessário
            if (double.IsNaN(soma)) soma = 0;
            if (double.IsNaN(rNorm)) rNorm = 0;
            if (double.IsNaN(gNorm)) gNorm = 0;
            if (double.IsNaN(bNorm)) bNorm = 0;

            // Arredonda os valores com duas casas decimais
            rNorm = Math.Round(rNorm, 2);
            gNorm = Math.Round(gNorm, 2);
            bNorm = Math.Round(bNorm, 2);

            txResultadoRGB.Text = string.Format(" R: {0}\r\n G: {1}\r\n B: {2}", rNorm, gNorm, bNorm);
        }

        private void HSVtoRGB_Click(object sender, EventArgs e)
        {
            // Pega os valores de H, S e V 
            double hue = (double)numericUpDownMatriz.Value;
            double saturation = (double)numericUpDownSaturation.Value;
            double value = (double)numericUpDownShine.Value;

            // Verifica se os campos de input estão preenchidos corretamente
            if (hue < 0 || hue > 360 || saturation < 0 || saturation > 100 || value < 0 || value > 100)
            {
                MessageBox.Show("Os valores de H, S, V devem estar dentro dos seguintes intervalos: H (0-360), S (0-100), V (0-100).");
                return;
            }

            // Converte S e V para o intervalo [0, 1]
            double s = saturation / 100.0;
            double v = value / 100.0;

            // Calcula c, x e m
            double c = v * s;
            double x = c * (1 - Math.Abs((hue / 60) % 2 - 1));
            double m = v - c;

            // Calcula os valores RGB prime
            double[] rgbPrime;
            if (hue >= 0 && hue < 60)
            {
                rgbPrime = new double[] { c, x, 0 };
            }
            else if (hue >= 60 && hue < 120)
            {
                rgbPrime = new double[] { x, c, 0 };
            }
            else if (hue >= 120 && hue < 180)
            {
                rgbPrime = new double[] { 0, c, x };
            }
            else if (hue >= 180 && hue < 240)
            {
                rgbPrime = new double[] { 0, x, c };
            }
            else if (hue >= 240 && hue < 300)
            {
                rgbPrime = new double[] { x, 0, c };
            }
            else 
            {
                rgbPrime = new double[] { c, 0, x };
            }

            // Calcula os valores finais de R, G e B
            int r = (int)((rgbPrime[0] + m) * 255);
            int g = (int)((rgbPrime[1] + m) * 255);
            int b = (int)((rgbPrime[2] + m) * 255);

            txResultadoHSV.Text = string.Format("R: {0}\r\nG: {1}\r\nB: {2}", r, g, b);
        }

        private void CMYKtoRGB_Click(object sender, EventArgs e)
        {
            // Pega os valores de C, M, Y e K e já os trata
            double cyan = (double)numericUpDownCyan.Value / 100;
            double magenta = (double)numericUpDownMagenta.Value / 100;
            double yellow = (double)numericUpDownYellow.Value / 100;
            double black = (double)numericUpDownBlack.Value / 100;

            // Verifica se os campos de input estão preenchidos corretamente
            if (cyan < 0 || cyan > 1 || magenta < 0 || magenta > 1 || yellow < 0 || yellow > 1 || black < 0 || black > 1)
            {
                MessageBox.Show("Os valores de CMYK devem estar entre 0 e 100.");
                return;
            }

            // Calcula os valores de RGB
            int red = (int)(255 * (1 - cyan) * (1 - black));
            int green = (int)(255 * (1 - magenta) * (1 - black));
            int blue = (int)(255 * (1 - yellow) * (1 - black));

            string rgbString = string.Format(" R: {0}\r\n G: {1}\r\n B: {2}\r\n", red, green, blue);
            txResultadoCMYK.Text = rgbString;
        }

    }

    }
    


    

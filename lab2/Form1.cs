using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ZedGraph;
using System.Linq;


namespace lab2
{
    public partial class Form1 : Form
    {
        EX excel = new EX();
        PointPairList cos = new PointPairList();
        double tmin = 0;
        double tmax = 30;
        double a = 1;
        double w = 1;

        double m = 0;
        double d = 0;
        public Form1()
        {
            InitializeComponent();

            textBox_A.Text = "1";
            textBox_w.Text = "1";
            textBox_mint.Text = "0";
            textBox_maxt.Text = "30";

            string s = textBox_A.Text;
            a = Convert.ToDouble(s);

            s = textBox_w.Text;
            w = Convert.ToDouble(s);

            s = textBox_mint.Text;
            tmin = Convert.ToDouble(s);

            s = textBox_maxt.Text;
            tmax = Convert.ToDouble(s);

            GraphPane pane = zedGraph.GraphPane;
            pane.CurveList.Clear();

            M();
            D();
            // Создадим список точек
            double z = excel.PIrand();
            // Заполняем список точек
            for (double x = tmin; x <= tmax; x += 0.01)
            {
                cos.Add(x, Program.cos(a, w, x, z));
            }

            // Создадим кривую с названием "Process"          

            LineItem myCurve1 = pane.AddCurve("Process", cos, Color.Red, SymbolType.None);
            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            // В противном случае на рисунке будет показана только часть графика,
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double z = excel.PIrand();
            cos.Clear();

            string s = textBox_A.Text;
            a = Convert.ToDouble(s);

            s = textBox_w.Text;
            w = Convert.ToDouble(s);

            s = textBox_mint.Text;
            tmin = Convert.ToDouble(s);

            s = textBox_maxt.Text;
            tmax = Convert.ToDouble(s);

            for (double x = tmin; x <= tmax; x += 0.01)
            {
                cos.Add(x, Program.cos(a,w,x,z));
            }

            GraphPane pane = zedGraph.GraphPane;
            pane.CurveList.Clear();
            zedGraph.AxisChange();
            zedGraph.Invalidate();
            LineItem myCurve1 = pane.AddCurve("Process", cos, Color.Red, SymbolType.None);
            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

        private void M()
        {        
                m = 0;

                for (int i = 0; i < 10000; i++)
                {
                    m = m + excel.Cos_rand();
                }
                m = m / 10000;

            double s = 0;
            for (int i = 0; i < 10000; i++)
            {
                s = s + excel.Sin_rand();
            }
            s = s / 10000;

            double mp = 0;
            int z = 0;
            mp = (a * Math.Cos(w * 1) * m + a * Math.Sin(w * 1) * s);
            for (double x = tmin; x <= tmax; x += 0.01)
            {
                mp =mp + (a * Math.Cos(w * x) * m + a * Math.Sin(w * x) * s);
                z++;
            }

            mp = mp / z;

            textBox_MX.Text = mp.ToString();
            //double result = a * Math.Cos(w * 1) * Math.Cos(m) + a * Math.Sin(w * 1) * Math.Sin(m);
            //double c = 0;
            //for (int i = 0; i < 10000; i++)
            //{
            //    c = c + excel.Cos_rand();
            //}
            //c = c / 10000;

        }

        private void D()
        {
            d = 0;

            for (int i = 0; i < 10000; i++)
            {
                d =d+(Math.Pow(excel.Cos_rand()-0.00056,2))/9999;
            }
            d = a * Math.Cos(w * 1) * Math.Cos(d) + a * Math.Sin(w * 1) * Math.Sin(d);

            textBox_DX.Text = d.ToString();
            textBox_SKO.Text = Math.Sqrt(d).ToString();
        }

    }
}

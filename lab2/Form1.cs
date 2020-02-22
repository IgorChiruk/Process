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
        PointPairList mx_list = new PointPairList();
        double tmin = 0;
        double tmax = 30;
        double a = 1;
        double w = 1;

        double mx = 0;
        double dx = 0;
        double sko = 0;
        double rx = 0;

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

            Mx();
            Dx();
            Rx();

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

            Mx();
            Dx();
            Rx();
        }
        // МАт ожидание
        private void Mx()
        {
            mx = 0;
            mx_list.Clear();
            for (int i = 0; i < 10000; i++)
            {
                double z = excel.PIrand();
                mx_list.Add(i, Program.cos(a, w, 1, z));
            }

            foreach(ZedGraph.PointPair i in mx_list)
            {
                mx += i.Y;
            }

            mx /= 10000;

            textBox_MX.Text = mx.ToString();
           
        }
        //Дисперсия и СКО
        private void Dx()
        {
            dx = 0;

            for (int i = 0; i < 10000; i++)
            {
                double z = excel.PIrand();
                double temp = (Program.cos(a, w, 1, z))-mx;
                dx += Math.Pow(temp,2)/ 10000;
            }


            textBox_DX.Text = dx.ToString();

            sko = Math.Sqrt(dx);
            textBox_SKO.Text = sko.ToString();

            //2-й вариант

            //for (int i = 0; i < 10000; i++)
            //{
            //    d =d+(Math.Pow(excel.Cos_rand()-0.00056,2))/9999;
            //}
            //d = a * Math.Cos(w * 1) * Math.Cos(d) + a * Math.Sin(w * 1) * Math.Sin(d);

            //textBox_DX.Text = d.ToString();


        }

        //Корреляционная функция

        private void Rx()
        {
            rx = 0;

            for (int i = 0; i < 10000; i++)
            {
                double z = excel.PIrand();
                double temp1 = (Program.cos(a, w, 1, z)) - mx;
                double temp2 = (Program.cos(a, w, 2, z)) - mx;
                rx += (temp1 * temp2) / 10000;
            }

            textBox_rx.Text = rx.ToString();
        }

    }
}

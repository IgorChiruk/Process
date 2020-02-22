namespace lab2
{
    partial class Form1
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
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_SKO = new System.Windows.Forms.TextBox();
            this.textBox_DX = new System.Windows.Forms.TextBox();
            this.textBox_MX = new System.Windows.Forms.TextBox();
            this.label_SKO = new System.Windows.Forms.Label();
            this.label_DX = new System.Windows.Forms.Label();
            this.label_MX = new System.Windows.Forms.Label();
            this.textBox_mint = new System.Windows.Forms.TextBox();
            this.textBox_maxt = new System.Windows.Forms.TextBox();
            this.textBox_w = new System.Windows.Forms.TextBox();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_rx = new System.Windows.Forms.Label();
            this.textBox_rx = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraph
            // 
            this.zedGraph.IsEnableHPan = false;
            this.zedGraph.IsEnableHZoom = false;
            this.zedGraph.IsEnableVPan = false;
            this.zedGraph.IsEnableVZoom = false;
            this.zedGraph.IsShowContextMenu = false;
            this.zedGraph.Location = new System.Drawing.Point(21, 12);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(809, 480);
            this.zedGraph.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(19, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "Генерировать процесс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_rx);
            this.groupBox1.Controls.Add(this.label_rx);
            this.groupBox1.Controls.Add(this.textBox_SKO);
            this.groupBox1.Controls.Add(this.textBox_DX);
            this.groupBox1.Controls.Add(this.textBox_MX);
            this.groupBox1.Controls.Add(this.label_SKO);
            this.groupBox1.Controls.Add(this.label_DX);
            this.groupBox1.Controls.Add(this.label_MX);
            this.groupBox1.Controls.Add(this.textBox_mint);
            this.groupBox1.Controls.Add(this.textBox_maxt);
            this.groupBox1.Controls.Add(this.textBox_w);
            this.groupBox1.Controls.Add(this.textBox_A);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(855, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 361);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // textBox_SKO
            // 
            this.textBox_SKO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SKO.Location = new System.Drawing.Point(63, 256);
            this.textBox_SKO.Name = "textBox_SKO";
            this.textBox_SKO.ReadOnly = true;
            this.textBox_SKO.Size = new System.Drawing.Size(225, 26);
            this.textBox_SKO.TabIndex = 33;
            // 
            // textBox_DX
            // 
            this.textBox_DX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_DX.Location = new System.Drawing.Point(63, 224);
            this.textBox_DX.Name = "textBox_DX";
            this.textBox_DX.ReadOnly = true;
            this.textBox_DX.Size = new System.Drawing.Size(225, 26);
            this.textBox_DX.TabIndex = 32;
            // 
            // textBox_MX
            // 
            this.textBox_MX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_MX.Location = new System.Drawing.Point(63, 192);
            this.textBox_MX.Name = "textBox_MX";
            this.textBox_MX.ReadOnly = true;
            this.textBox_MX.Size = new System.Drawing.Size(225, 26);
            this.textBox_MX.TabIndex = 31;
            // 
            // label_SKO
            // 
            this.label_SKO.AutoSize = true;
            this.label_SKO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_SKO.Location = new System.Drawing.Point(6, 260);
            this.label_SKO.Name = "label_SKO";
            this.label_SKO.Size = new System.Drawing.Size(51, 20);
            this.label_SKO.TabIndex = 30;
            this.label_SKO.Text = "SKO=";
            // 
            // label_DX
            // 
            this.label_DX.AutoSize = true;
            this.label_DX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_DX.Location = new System.Drawing.Point(20, 227);
            this.label_DX.Name = "label_DX";
            this.label_DX.Size = new System.Drawing.Size(37, 20);
            this.label_DX.TabIndex = 29;
            this.label_DX.Text = "Dx=";
            // 
            // label_MX
            // 
            this.label_MX.AutoSize = true;
            this.label_MX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_MX.Location = new System.Drawing.Point(19, 198);
            this.label_MX.Name = "label_MX";
            this.label_MX.Size = new System.Drawing.Size(38, 20);
            this.label_MX.TabIndex = 28;
            this.label_MX.Text = "Mx=";
            // 
            // textBox_mint
            // 
            this.textBox_mint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_mint.Location = new System.Drawing.Point(19, 129);
            this.textBox_mint.Name = "textBox_mint";
            this.textBox_mint.Size = new System.Drawing.Size(53, 26);
            this.textBox_mint.TabIndex = 27;
            // 
            // textBox_maxt
            // 
            this.textBox_maxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_maxt.Location = new System.Drawing.Point(116, 129);
            this.textBox_maxt.Name = "textBox_maxt";
            this.textBox_maxt.Size = new System.Drawing.Size(52, 26);
            this.textBox_maxt.TabIndex = 26;
            // 
            // textBox_w
            // 
            this.textBox_w.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_w.Location = new System.Drawing.Point(47, 97);
            this.textBox_w.Name = "textBox_w";
            this.textBox_w.Size = new System.Drawing.Size(100, 26);
            this.textBox_w.TabIndex = 25;
            // 
            // textBox_A
            // 
            this.textBox_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_A.Location = new System.Drawing.Point(47, 65);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(100, 26);
            this.textBox_A.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(78, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "<t<";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "w=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "A=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "A*Cos(w*t+Fi); -Pi<Fi<Pi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Случайный процесс";
            // 
            // label_rx
            // 
            this.label_rx.AutoSize = true;
            this.label_rx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rx.Location = new System.Drawing.Point(20, 292);
            this.label_rx.Name = "label_rx";
            this.label_rx.Size = new System.Drawing.Size(37, 20);
            this.label_rx.TabIndex = 34;
            this.label_rx.Text = "Rx=";
            // 
            // textBox_rx
            // 
            this.textBox_rx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_rx.Location = new System.Drawing.Point(64, 291);
            this.textBox_rx.Name = "textBox_rx";
            this.textBox_rx.ReadOnly = true;
            this.textBox_rx.Size = new System.Drawing.Size(224, 26);
            this.textBox_rx.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zedGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Лабораторная работа №2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_mint;
        private System.Windows.Forms.TextBox textBox_maxt;
        private System.Windows.Forms.TextBox textBox_w;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_SKO;
        private System.Windows.Forms.TextBox textBox_DX;
        private System.Windows.Forms.TextBox textBox_MX;
        private System.Windows.Forms.Label label_SKO;
        private System.Windows.Forms.Label label_DX;
        private System.Windows.Forms.Label label_MX;
        private System.Windows.Forms.TextBox textBox_rx;
        private System.Windows.Forms.Label label_rx;
    }
}


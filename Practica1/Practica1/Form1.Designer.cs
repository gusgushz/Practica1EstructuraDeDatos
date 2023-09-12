namespace Practica1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox7 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            labelResultado = new Label();
            labelResultadoC = new Label();
            labelResultadoCirc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 61);
            label1.Name = "label1";
            label1.Size = new Size(235, 20);
            label1.TabIndex = 3;
            label1.Text = "Calculadora de áreas y perimetros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 109);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 4;
            label2.Text = "Triangulo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 109);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 5;
            label3.Text = "Cuadrangulo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(576, 109);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 6;
            label4.Text = "Circulo";
            // 
            // button1
            // 
            button1.Location = new Point(204, 318);
            button1.Name = "button1";
            button1.Size = new Size(187, 29);
            button1.TabIndex = 7;
            button1.Text = "Calcular área";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(413, 318);
            button2.Name = "button2";
            button2.Size = new Size(210, 29);
            button2.TabIndex = 8;
            button2.Text = "Calcular Perimetro";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 9;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 10;
            textBox2.TextAlign = HorizontalAlignment.Right;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(125, 265);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 11;
            textBox3.TextAlign = HorizontalAlignment.Right;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(341, 164);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 12;
            textBox4.TextAlign = HorizontalAlignment.Right;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(341, 214);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 13;
            textBox5.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(552, 164);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 15;
            textBox7.TextAlign = HorizontalAlignment.Right;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 141);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 16;
            label5.Text = "Lado1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(125, 194);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 17;
            label6.Text = "Lado2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(124, 244);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 18;
            label7.Text = "Lado3";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(344, 141);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 19;
            label8.Text = "Alto/Lado1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(341, 191);
            label9.Name = "label9";
            label9.Size = new Size(98, 20);
            label9.TabIndex = 20;
            label9.Text = "Ancho/Lado2";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(552, 141);
            label10.Name = "label10";
            label10.Size = new Size(48, 20);
            label10.TabIndex = 21;
            label10.Text = "Radio";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(109, 369);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(141, 20);
            labelResultado.TabIndex = 23;
            labelResultado.Text = "Resultado Triangulo";
            labelResultado.Click += labelResultado_Click;
            // 
            // labelResultadoC
            // 
            labelResultadoC.AutoSize = true;
            labelResultadoC.Location = new Point(325, 369);
            labelResultadoC.Name = "labelResultadoC";
            labelResultadoC.Size = new Size(164, 20);
            labelResultadoC.TabIndex = 24;
            labelResultadoC.Text = "Resultado Cuadrangulo";
            // 
            // labelResultadoCirc
            // 
            labelResultadoCirc.AutoSize = true;
            labelResultadoCirc.Location = new Point(552, 369);
            labelResultadoCirc.Name = "labelResultadoCirc";
            labelResultadoCirc.Size = new Size(125, 20);
            labelResultadoCirc.TabIndex = 25;
            labelResultadoCirc.Text = "Resultado Circulo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 434);
            Controls.Add(labelResultadoCirc);
            Controls.Add(labelResultadoC);
            Controls.Add(labelResultado);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Click += button1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label labelResultado;
        private Label labelResultadoC;
        private Label labelResultadoCirc;
        public TextBox textBox7;
    }
}
namespace CalculadoraWinForms
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
            txtPantalla = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDividir = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMultiplicar = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnRestar = new Button();
            btnLimpiar = new Button();
            btn0 = new Button();
            btnIgual = new Button();
            btnSumar = new Button();
            btnDecimal = new Button();
            btnRetroceso = new Button();
            SuspendLayout();
            // 
            // txtPantalla
            // 
            txtPantalla.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPantalla.Location = new Point(10, 3);
            txtPantalla.Name = "txtPantalla";
            txtPantalla.ReadOnly = true;
            txtPantalla.Size = new Size(323, 43);
            txtPantalla.TabIndex = 0;
            txtPantalla.Text = "0";
            txtPantalla.TextAlign = HorizontalAlignment.Right;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ControlDark;
            btn7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(10, 130);
            btn7.Name = "btn7";
            btn7.Size = new Size(61, 43);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ControlDark;
            btn8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(95, 130);
            btn8.Name = "btn8";
            btn8.Size = new Size(61, 43);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ControlDark;
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(177, 130);
            btn9.Name = "btn9";
            btn9.Size = new Size(61, 43);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btnDividir
            // 
            btnDividir.BackColor = Color.Coral;
            btnDividir.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDividir.Location = new Point(258, 62);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(61, 43);
            btnDividir.TabIndex = 4;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = false;
            btnDividir.Click += btnDividir_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ControlDark;
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(10, 209);
            btn4.Name = "btn4";
            btn4.Size = new Size(61, 43);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ControlDark;
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(95, 209);
            btn5.Name = "btn5";
            btn5.Size = new Size(61, 43);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ControlDark;
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(177, 209);
            btn6.Name = "btn6";
            btn6.Size = new Size(61, 43);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.BackColor = Color.Coral;
            btnMultiplicar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiplicar.Location = new Point(258, 130);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(61, 43);
            btnMultiplicar.TabIndex = 8;
            btnMultiplicar.Text = "X";
            btnMultiplicar.UseVisualStyleBackColor = false;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ControlDark;
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(10, 286);
            btn1.Name = "btn1";
            btn1.Size = new Size(61, 43);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ControlDark;
            btn2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(95, 286);
            btn2.Name = "btn2";
            btn2.Size = new Size(61, 43);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ControlDark;
            btn3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(177, 286);
            btn3.Name = "btn3";
            btn3.Size = new Size(61, 43);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btnRestar
            // 
            btnRestar.BackColor = Color.Coral;
            btnRestar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestar.Location = new Point(258, 209);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(61, 43);
            btnRestar.TabIndex = 12;
            btnRestar.Text = "-";
            btnRestar.UseVisualStyleBackColor = false;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Coral;
            btnLimpiar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(10, 362);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(61, 43);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "C";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ControlDark;
            btn0.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.Location = new Point(95, 362);
            btn0.Name = "btn0";
            btn0.Size = new Size(61, 43);
            btn0.TabIndex = 14;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.Coral;
            btnIgual.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIgual.Location = new Point(258, 362);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(61, 43);
            btnIgual.TabIndex = 15;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnSumar
            // 
            btnSumar.BackColor = Color.Coral;
            btnSumar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSumar.Location = new Point(258, 286);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(61, 43);
            btnSumar.TabIndex = 16;
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = false;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.Coral;
            btnDecimal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDecimal.Location = new Point(177, 362);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(61, 43);
            btnDecimal.TabIndex = 17;
            btnDecimal.Text = ",";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnRetroceso
            // 
            btnRetroceso.BackColor = Color.Coral;
            btnRetroceso.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRetroceso.Location = new Point(179, 62);
            btnRetroceso.Name = "btnRetroceso";
            btnRetroceso.Size = new Size(59, 43);
            btnRetroceso.TabIndex = 18;
            btnRetroceso.Text = "⌫";
            btnRetroceso.UseVisualStyleBackColor = false;
            btnRetroceso.Click += btnRetroceso_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.texture_military_camouflage_seamless_illustration_pattern_background_vector;
            ClientSize = new Size(344, 461);
            Controls.Add(btnRetroceso);
            Controls.Add(btnDecimal);
            Controls.Add(btnSumar);
            Controls.Add(btnIgual);
            Controls.Add(btn0);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRestar);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMultiplicar);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnDividir);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtPantalla);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mi Primera Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPantalla;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnDividir;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMultiplicar;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnRestar;
        private Button btnLimpiar;
        private Button btn0;
        private Button btnIgual;
        private Button btnSumar;
        private Button btnDecimal;
        private Button btnRetroceso;
    }
}

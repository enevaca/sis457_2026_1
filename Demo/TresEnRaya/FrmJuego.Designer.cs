namespace TresEnRaya
{
    partial class FrmJuego
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            lblTitulo = new Label();
            label2 = new Label();
            label3 = new Label();
            lblVictoriasX = new Label();
            lblVictoriasO = new Label();
            btnReiniciar = new Button();
            label6 = new Label();
            lblEmpates = new Label();
            lblTurno = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(31, 38);
            btn1.Margin = new Padding(2);
            btn1.Name = "btn1";
            btn1.Size = new Size(84, 72);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += marcar_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(119, 38);
            btn2.Margin = new Padding(2);
            btn2.Name = "btn2";
            btn2.Size = new Size(84, 72);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += marcar_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.ForeColor = Color.Red;
            btn3.Location = new Point(207, 38);
            btn3.Margin = new Padding(2);
            btn3.Name = "btn3";
            btn3.Size = new Size(84, 72);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += marcar_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(31, 114);
            btn4.Margin = new Padding(2);
            btn4.Name = "btn4";
            btn4.Size = new Size(84, 72);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += marcar_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(119, 114);
            btn5.Margin = new Padding(2);
            btn5.Name = "btn5";
            btn5.Size = new Size(84, 72);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += marcar_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(207, 114);
            btn6.Margin = new Padding(2);
            btn6.Name = "btn6";
            btn6.Size = new Size(84, 72);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += marcar_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(31, 190);
            btn7.Margin = new Padding(2);
            btn7.Name = "btn7";
            btn7.Size = new Size(84, 72);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += marcar_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(119, 190);
            btn8.Margin = new Padding(2);
            btn8.Name = "btn8";
            btn8.Size = new Size(84, 72);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += marcar_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(207, 190);
            btn9.Margin = new Padding(2);
            btn9.Name = "btn9";
            btn9.Size = new Size(84, 72);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += marcar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(85, 5);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(157, 32);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "Tres en Raya";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 284);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 10;
            label2.Text = "Jugador X:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 302);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 11;
            label3.Text = "Jugador O:";
            // 
            // lblVictoriasX
            // 
            lblVictoriasX.AutoSize = true;
            lblVictoriasX.Location = new Point(90, 284);
            lblVictoriasX.Margin = new Padding(2, 0, 2, 0);
            lblVictoriasX.Name = "lblVictoriasX";
            lblVictoriasX.Size = new Size(13, 15);
            lblVictoriasX.TabIndex = 12;
            lblVictoriasX.Text = "0";
            // 
            // lblVictoriasO
            // 
            lblVictoriasO.AutoSize = true;
            lblVictoriasO.Location = new Point(90, 302);
            lblVictoriasO.Margin = new Padding(2, 0, 2, 0);
            lblVictoriasO.Name = "lblVictoriasO";
            lblVictoriasO.Size = new Size(13, 15);
            lblVictoriasO.TabIndex = 13;
            lblVictoriasO.Text = "0";
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(122, 265);
            btnReiniciar.Margin = new Padding(2);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(78, 20);
            btnReiniciar.TabIndex = 14;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(204, 284);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 15;
            label6.Text = "Empates:";
            // 
            // lblEmpates
            // 
            lblEmpates.AutoSize = true;
            lblEmpates.Location = new Point(269, 284);
            lblEmpates.Margin = new Padding(2, 0, 2, 0);
            lblEmpates.Name = "lblEmpates";
            lblEmpates.Size = new Size(13, 15);
            lblEmpates.TabIndex = 16;
            lblEmpates.Text = "0";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(8, 17);
            lblTurno.Margin = new Padding(2, 0, 2, 0);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(55, 15);
            lblTurno.TabIndex = 17;
            lblTurno.Text = "Turno: --";
            // 
            // FrmJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 323);
            Controls.Add(lblTurno);
            Controls.Add(lblEmpates);
            Controls.Add(label6);
            Controls.Add(btnReiniciar);
            Controls.Add(lblVictoriasO);
            Controls.Add(lblVictoriasX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTitulo);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "FrmJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "::: Juego Tres en Raya :::";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Label lblTitulo;
        private Label label2;
        private Label label3;
        private Label lblVictoriasX;
        private Label lblVictoriasO;
        private Button btnReiniciar;
        private Label label6;
        private Label lblEmpates;
        private Label lblTurno;
    }
}

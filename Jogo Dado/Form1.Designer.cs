namespace Jogo_Dado
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
            this.txtRodada = new System.Windows.Forms.TextBox();
            this.lblRodada = new System.Windows.Forms.Label();
            this.btJogador2 = new System.Windows.Forms.Button();
            this.btJogador1 = new System.Windows.Forms.Button();
            this.txtPlacarJ2 = new System.Windows.Forms.TextBox();
            this.txtPlacarJ1 = new System.Windows.Forms.TextBox();
            this.lblPlacarJ2 = new System.Windows.Forms.Label();
            this.lblPlacarJ1 = new System.Windows.Forms.Label();
            this.lblPlacar = new System.Windows.Forms.Label();
            this.txtJogador2 = new System.Windows.Forms.TextBox();
            this.txtJogador1 = new System.Windows.Forms.TextBox();
            this.lblJogador2 = new System.Windows.Forms.Label();
            this.lblJogador1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRodada
            // 
            this.txtRodada.Location = new System.Drawing.Point(117, 138);
            this.txtRodada.Margin = new System.Windows.Forms.Padding(2);
            this.txtRodada.Name = "txtRodada";
            this.txtRodada.Size = new System.Drawing.Size(42, 20);
            this.txtRodada.TabIndex = 25;
            this.txtRodada.Text = "0";
            // 
            // lblRodada
            // 
            this.lblRodada.AutoSize = true;
            this.lblRodada.Location = new System.Drawing.Point(58, 142);
            this.lblRodada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRodada.Name = "lblRodada";
            this.lblRodada.Size = new System.Drawing.Size(48, 13);
            this.lblRodada.TabIndex = 24;
            this.lblRodada.Text = "Rodada:";
            // 
            // btJogador2
            // 
            this.btJogador2.Location = new System.Drawing.Point(188, 86);
            this.btJogador2.Margin = new System.Windows.Forms.Padding(2);
            this.btJogador2.Name = "btJogador2";
            this.btJogador2.Size = new System.Drawing.Size(56, 19);
            this.btJogador2.TabIndex = 23;
            this.btJogador2.Text = "JOGAR 1";
            this.btJogador2.UseVisualStyleBackColor = true;
            this.btJogador2.Click += new System.EventHandler(this.btPlayer2_Click_1);
            // 
            // btJogador1
            // 
            this.btJogador1.Location = new System.Drawing.Point(50, 86);
            this.btJogador1.Margin = new System.Windows.Forms.Padding(2);
            this.btJogador1.Name = "btJogador1";
            this.btJogador1.Size = new System.Drawing.Size(56, 19);
            this.btJogador1.TabIndex = 22;
            this.btJogador1.Text = "JOGAR 1";
            this.btJogador1.UseVisualStyleBackColor = true;
            this.btJogador1.Click += new System.EventHandler(this.btJogador1_Click_1);
            // 
            // txtPlacarJ2
            // 
            this.txtPlacarJ2.Location = new System.Drawing.Point(156, 220);
            this.txtPlacarJ2.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlacarJ2.Name = "txtPlacarJ2";
            this.txtPlacarJ2.Size = new System.Drawing.Size(27, 20);
            this.txtPlacarJ2.TabIndex = 21;
            this.txtPlacarJ2.Text = "0";
            // 
            // txtPlacarJ1
            // 
            this.txtPlacarJ1.Location = new System.Drawing.Point(89, 220);
            this.txtPlacarJ1.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlacarJ1.Name = "txtPlacarJ1";
            this.txtPlacarJ1.Size = new System.Drawing.Size(27, 20);
            this.txtPlacarJ1.TabIndex = 20;
            this.txtPlacarJ1.Text = "0";
            // 
            // lblPlacarJ2
            // 
            this.lblPlacarJ2.AutoSize = true;
            this.lblPlacarJ2.Location = new System.Drawing.Point(187, 223);
            this.lblPlacarJ2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlacarJ2.Name = "lblPlacarJ2";
            this.lblPlacarJ2.Size = new System.Drawing.Size(54, 13);
            this.lblPlacarJ2.TabIndex = 19;
            this.lblPlacarJ2.Text = "Jogador 2";
            // 
            // lblPlacarJ1
            // 
            this.lblPlacarJ1.AutoSize = true;
            this.lblPlacarJ1.Location = new System.Drawing.Point(31, 223);
            this.lblPlacarJ1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlacarJ1.Name = "lblPlacarJ1";
            this.lblPlacarJ1.Size = new System.Drawing.Size(54, 13);
            this.lblPlacarJ1.TabIndex = 18;
            this.lblPlacarJ1.Text = "Jogador 1";
            // 
            // lblPlacar
            // 
            this.lblPlacar.AutoSize = true;
            this.lblPlacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacar.Location = new System.Drawing.Point(29, 182);
            this.lblPlacar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlacar.Name = "lblPlacar";
            this.lblPlacar.Size = new System.Drawing.Size(215, 25);
            this.lblPlacar.TabIndex = 17;
            this.lblPlacar.Text = "PLACAR DA RODADA";
            // 
            // txtJogador2
            // 
            this.txtJogador2.Location = new System.Drawing.Point(188, 45);
            this.txtJogador2.Margin = new System.Windows.Forms.Padding(2);
            this.txtJogador2.Name = "txtJogador2";
            this.txtJogador2.Size = new System.Drawing.Size(42, 20);
            this.txtJogador2.TabIndex = 16;
            this.txtJogador2.Text = "0";
            // 
            // txtJogador1
            // 
            this.txtJogador1.Location = new System.Drawing.Point(52, 45);
            this.txtJogador1.Margin = new System.Windows.Forms.Padding(2);
            this.txtJogador1.Name = "txtJogador1";
            this.txtJogador1.Size = new System.Drawing.Size(42, 20);
            this.txtJogador1.TabIndex = 15;
            this.txtJogador1.Text = "0";
            // 
            // lblJogador2
            // 
            this.lblJogador2.AutoSize = true;
            this.lblJogador2.Location = new System.Drawing.Point(185, 20);
            this.lblJogador2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJogador2.Name = "lblJogador2";
            this.lblJogador2.Size = new System.Drawing.Size(57, 13);
            this.lblJogador2.TabIndex = 14;
            this.lblJogador2.Text = "Jogador 2:";
            // 
            // lblJogador1
            // 
            this.lblJogador1.AutoSize = true;
            this.lblJogador1.Location = new System.Drawing.Point(49, 20);
            this.lblJogador1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJogador1.Name = "lblJogador1";
            this.lblJogador1.Size = new System.Drawing.Size(57, 13);
            this.lblJogador1.TabIndex = 13;
            this.lblJogador1.Text = "Jogador 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRodada);
            this.Controls.Add(this.lblRodada);
            this.Controls.Add(this.btJogador2);
            this.Controls.Add(this.btJogador1);
            this.Controls.Add(this.txtPlacarJ2);
            this.Controls.Add(this.txtPlacarJ1);
            this.Controls.Add(this.lblPlacarJ2);
            this.Controls.Add(this.lblPlacarJ1);
            this.Controls.Add(this.lblPlacar);
            this.Controls.Add(this.txtJogador2);
            this.Controls.Add(this.txtJogador1);
            this.Controls.Add(this.lblJogador2);
            this.Controls.Add(this.lblJogador1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRodada;
        private System.Windows.Forms.Label lblRodada;
        private System.Windows.Forms.Button btJogador2;
        private System.Windows.Forms.Button btJogador1;
        private System.Windows.Forms.TextBox txtPlacarJ2;
        private System.Windows.Forms.TextBox txtPlacarJ1;
        private System.Windows.Forms.Label lblPlacarJ2;
        private System.Windows.Forms.Label lblPlacarJ1;
        private System.Windows.Forms.Label lblPlacar;
        private System.Windows.Forms.TextBox txtJogador2;
        private System.Windows.Forms.TextBox txtJogador1;
        private System.Windows.Forms.Label lblJogador2;
        private System.Windows.Forms.Label lblJogador1;
        private System.Windows.Forms.Label label1;
    }
}


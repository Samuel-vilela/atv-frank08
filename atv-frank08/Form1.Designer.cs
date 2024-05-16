namespace atv_frank08
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_validar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(321, 113);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(135, 20);
            this.textBoxIdade.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // btn_validar
            // 
            this.btn_validar.BackColor = System.Drawing.Color.White;
            this.btn_validar.Location = new System.Drawing.Point(321, 139);
            this.btn_validar.Name = "btn_validar";
            this.btn_validar.Size = new System.Drawing.Size(135, 23);
            this.btn_validar.TabIndex = 3;
            this.btn_validar.Text = "Teste";
            this.btn_validar.UseVisualStyleBackColor = false;
            this.btn_validar.Click += new System.EventHandler(this.btn_validar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sistema de aprovação de Cnh";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.BackColor = System.Drawing.Color.White;
            this.labelResultado.Location = new System.Drawing.Point(318, 165);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 13);
            this.labelResultado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::atv_frank08.Properties.Resources.auto__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_validar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIdade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_validar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResultado;
    }
}


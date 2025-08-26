namespace GerenciadorDeOVNI
{
    partial class Gerenciador
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
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnLigar = new System.Windows.Forms.Button();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.grbTripulantes = new System.Windows.Forms.GroupBox();
            this.btnRemoverTripulantes = new System.Windows.Forms.Button();
            this.btnAddTripulantes = new System.Windows.Forms.Button();
            this.grbAbduzidos = new System.Windows.Forms.GroupBox();
            this.btnRemoverAbduzidos = new System.Windows.Forms.Button();
            this.btnAddAbduzidos = new System.Windows.Forms.Button();
            this.grbPlaneta = new System.Windows.Forms.GroupBox();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnMudarPlaneta = new System.Windows.Forms.Button();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pibTerra = new System.Windows.Forms.PictureBox();
            this.grbInformacoes.SuspendLayout();
            this.grbTripulantes.SuspendLayout();
            this.grbAbduzidos.SuspendLayout();
            this.grbPlaneta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibTerra)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.lblPlaneta);
            this.grbInformacoes.Controls.Add(this.btnDesligar);
            this.grbInformacoes.Controls.Add(this.btnLigar);
            this.grbInformacoes.Controls.Add(this.lblAbduzidos);
            this.grbInformacoes.Controls.Add(this.lblTripulantes);
            this.grbInformacoes.Controls.Add(this.lblSituacao);
            this.grbInformacoes.Location = new System.Drawing.Point(68, 49);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(217, 242);
            this.grbInformacoes.TabIndex = 0;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(7, 113);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(73, 13);
            this.lblPlaneta.TabIndex = 5;
            this.lblPlaneta.Text = "Planeta Atual:";
            // 
            // btnDesligar
            // 
            this.btnDesligar.Location = new System.Drawing.Point(12, 186);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(199, 36);
            this.btnDesligar.TabIndex = 4;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnLigar
            // 
            this.btnLigar.Location = new System.Drawing.Point(12, 142);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(199, 38);
            this.btnLigar.TabIndex = 3;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(7, 90);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(59, 13);
            this.lblAbduzidos.TabIndex = 2;
            this.lblAbduzidos.Text = "Abduzidos:";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(7, 63);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(62, 13);
            this.lblTripulantes.TabIndex = 1;
            this.lblTripulantes.Text = "Tripulantes:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(6, 33);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(52, 13);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação:";
            // 
            // grbTripulantes
            // 
            this.grbTripulantes.Controls.Add(this.btnRemoverTripulantes);
            this.grbTripulantes.Controls.Add(this.btnAddTripulantes);
            this.grbTripulantes.Location = new System.Drawing.Point(68, 340);
            this.grbTripulantes.Name = "grbTripulantes";
            this.grbTripulantes.Size = new System.Drawing.Size(217, 198);
            this.grbTripulantes.TabIndex = 1;
            this.grbTripulantes.TabStop = false;
            this.grbTripulantes.Text = "Tripulantes";
            // 
            // btnRemoverTripulantes
            // 
            this.btnRemoverTripulantes.Location = new System.Drawing.Point(10, 113);
            this.btnRemoverTripulantes.Name = "btnRemoverTripulantes";
            this.btnRemoverTripulantes.Size = new System.Drawing.Size(199, 47);
            this.btnRemoverTripulantes.TabIndex = 1;
            this.btnRemoverTripulantes.Text = "Remover";
            this.btnRemoverTripulantes.UseVisualStyleBackColor = true;
            this.btnRemoverTripulantes.Click += new System.EventHandler(this.btnRemoverTripulantes_Click);
            // 
            // btnAddTripulantes
            // 
            this.btnAddTripulantes.Location = new System.Drawing.Point(10, 48);
            this.btnAddTripulantes.Name = "btnAddTripulantes";
            this.btnAddTripulantes.Size = new System.Drawing.Size(199, 45);
            this.btnAddTripulantes.TabIndex = 0;
            this.btnAddTripulantes.Text = "Adicionar";
            this.btnAddTripulantes.UseVisualStyleBackColor = true;
            this.btnAddTripulantes.Click += new System.EventHandler(this.btnAddTripulantes_Click);
            // 
            // grbAbduzidos
            // 
            this.grbAbduzidos.Controls.Add(this.btnRemoverAbduzidos);
            this.grbAbduzidos.Controls.Add(this.btnAddAbduzidos);
            this.grbAbduzidos.Location = new System.Drawing.Point(330, 49);
            this.grbAbduzidos.Name = "grbAbduzidos";
            this.grbAbduzidos.Size = new System.Drawing.Size(217, 198);
            this.grbAbduzidos.TabIndex = 2;
            this.grbAbduzidos.TabStop = false;
            this.grbAbduzidos.Text = "Abduzidos";
            // 
            // btnRemoverAbduzidos
            // 
            this.btnRemoverAbduzidos.Location = new System.Drawing.Point(10, 113);
            this.btnRemoverAbduzidos.Name = "btnRemoverAbduzidos";
            this.btnRemoverAbduzidos.Size = new System.Drawing.Size(199, 47);
            this.btnRemoverAbduzidos.TabIndex = 1;
            this.btnRemoverAbduzidos.Text = "Remover";
            this.btnRemoverAbduzidos.UseVisualStyleBackColor = true;
            this.btnRemoverAbduzidos.Click += new System.EventHandler(this.btnRemoverAbduzidos_Click);
            // 
            // btnAddAbduzidos
            // 
            this.btnAddAbduzidos.Location = new System.Drawing.Point(10, 48);
            this.btnAddAbduzidos.Name = "btnAddAbduzidos";
            this.btnAddAbduzidos.Size = new System.Drawing.Size(199, 45);
            this.btnAddAbduzidos.TabIndex = 0;
            this.btnAddAbduzidos.Text = "Adicionar";
            this.btnAddAbduzidos.UseVisualStyleBackColor = true;
            this.btnAddAbduzidos.Click += new System.EventHandler(this.btnAddAbduzidos_Click);
            // 
            // grbPlaneta
            // 
            this.grbPlaneta.Controls.Add(this.btnRetornar);
            this.grbPlaneta.Controls.Add(this.btnMudarPlaneta);
            this.grbPlaneta.Controls.Add(this.cmbPlanetas);
            this.grbPlaneta.Location = new System.Drawing.Point(340, 286);
            this.grbPlaneta.Name = "grbPlaneta";
            this.grbPlaneta.Size = new System.Drawing.Size(207, 252);
            this.grbPlaneta.TabIndex = 3;
            this.grbPlaneta.TabStop = false;
            this.grbPlaneta.Text = "Planeta";
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(20, 158);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(168, 67);
            this.btnRetornar.TabIndex = 2;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnMudarPlaneta
            // 
            this.btnMudarPlaneta.Location = new System.Drawing.Point(20, 67);
            this.btnMudarPlaneta.Name = "btnMudarPlaneta";
            this.btnMudarPlaneta.Size = new System.Drawing.Size(179, 69);
            this.btnMudarPlaneta.TabIndex = 1;
            this.btnMudarPlaneta.Text = "Mudar de Planeta";
            this.btnMudarPlaneta.UseVisualStyleBackColor = true;
            this.btnMudarPlaneta.Click += new System.EventHandler(this.btnMudarPlaneta_Click);
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(5, 29);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(194, 21);
            this.cmbPlanetas.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GerenciadorDeOVNI.Properties.Resources.nave;
            this.pictureBox1.Location = new System.Drawing.Point(612, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pibTerra
            // 
            this.pibTerra.Image = global::GerenciadorDeOVNI.Properties.Resources.pictureBoxTerra;
            this.pibTerra.Location = new System.Drawing.Point(612, 286);
            this.pibTerra.Name = "pibTerra";
            this.pibTerra.Size = new System.Drawing.Size(283, 225);
            this.pibTerra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibTerra.TabIndex = 3;
            this.pibTerra.TabStop = false;
            // 
            // Gerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 549);
            this.Controls.Add(this.pibTerra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbPlaneta);
            this.Controls.Add(this.grbAbduzidos);
            this.Controls.Add(this.grbTripulantes);
            this.Controls.Add(this.grbInformacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Gerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador";
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.grbTripulantes.ResumeLayout(false);
            this.grbAbduzidos.ResumeLayout(false);
            this.grbPlaneta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibTerra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.GroupBox grbTripulantes;
        private System.Windows.Forms.Button btnRemoverTripulantes;
        private System.Windows.Forms.Button btnAddTripulantes;
        private System.Windows.Forms.GroupBox grbAbduzidos;
        private System.Windows.Forms.Button btnRemoverAbduzidos;
        private System.Windows.Forms.Button btnAddAbduzidos;
        private System.Windows.Forms.GroupBox grbPlaneta;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnMudarPlaneta;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.PictureBox pibTerra;
    }
}
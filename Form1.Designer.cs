namespace TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pibTicTiac = new System.Windows.Forms.PictureBox();
            this.pibVelha = new System.Windows.Forms.PictureBox();
            this.picFechar = new System.Windows.Forms.PictureBox();
            this.pibReset = new System.Windows.Forms.PictureBox();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.btn33 = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibTicTiac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibVelha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibReset)).BeginInit();
            this.SuspendLayout();
            // 
            // pibTicTiac
            // 
            this.pibTicTiac.Image = ((System.Drawing.Image)(resources.GetObject("pibTicTiac.Image")));
            this.pibTicTiac.Location = new System.Drawing.Point(12, 22);
            this.pibTicTiac.Name = "pibTicTiac";
            this.pibTicTiac.Size = new System.Drawing.Size(451, 85);
            this.pibTicTiac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibTicTiac.TabIndex = 0;
            this.pibTicTiac.TabStop = false;
            // 
            // pibVelha
            // 
            this.pibVelha.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pibVelha.Image = ((System.Drawing.Image)(resources.GetObject("pibVelha.Image")));
            this.pibVelha.Location = new System.Drawing.Point(12, 113);
            this.pibVelha.Name = "pibVelha";
            this.pibVelha.Size = new System.Drawing.Size(451, 324);
            this.pibVelha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibVelha.TabIndex = 1;
            this.pibVelha.TabStop = false;
            // 
            // picFechar
            // 
            this.picFechar.Image = ((System.Drawing.Image)(resources.GetObject("picFechar.Image")));
            this.picFechar.Location = new System.Drawing.Point(379, 22);
            this.picFechar.Name = "picFechar";
            this.picFechar.Size = new System.Drawing.Size(84, 85);
            this.picFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFechar.TabIndex = 2;
            this.picFechar.TabStop = false;
            this.picFechar.Click += new System.EventHandler(this.picFechar_Click);
            // 
            // pibReset
            // 
            this.pibReset.Image = ((System.Drawing.Image)(resources.GetObject("pibReset.Image")));
            this.pibReset.Location = new System.Drawing.Point(12, 443);
            this.pibReset.Name = "pibReset";
            this.pibReset.Size = new System.Drawing.Size(73, 79);
            this.pibReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibReset.TabIndex = 3;
            this.pibReset.TabStop = false;
            this.pibReset.Click += new System.EventHandler(this.pibReset_Click);
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11.Location = new System.Drawing.Point(98, 150);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(75, 60);
            this.btn11.TabIndex = 4;
            this.btn11.UseVisualStyleBackColor = false;
            this.btn11.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn12
            // 
            this.btn12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12.Location = new System.Drawing.Point(197, 150);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(75, 60);
            this.btn12.TabIndex = 5;
            this.btn12.UseVisualStyleBackColor = false;
            this.btn12.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn13
            // 
            this.btn13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn13.Location = new System.Drawing.Point(305, 150);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(75, 60);
            this.btn13.TabIndex = 6;
            this.btn13.UseVisualStyleBackColor = false;
            this.btn13.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn21
            // 
            this.btn21.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn21.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn21.Location = new System.Drawing.Point(98, 249);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(75, 65);
            this.btn21.TabIndex = 7;
            this.btn21.UseVisualStyleBackColor = false;
            this.btn21.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn22
            // 
            this.btn22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn22.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn22.Location = new System.Drawing.Point(197, 249);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(75, 65);
            this.btn22.TabIndex = 8;
            this.btn22.UseVisualStyleBackColor = false;
            this.btn22.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn23
            // 
            this.btn23.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn23.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn23.Location = new System.Drawing.Point(305, 249);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(75, 65);
            this.btn23.TabIndex = 9;
            this.btn23.UseVisualStyleBackColor = false;
            this.btn23.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn31
            // 
            this.btn31.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn31.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn31.Location = new System.Drawing.Point(98, 345);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(75, 65);
            this.btn31.TabIndex = 10;
            this.btn31.UseVisualStyleBackColor = false;
            this.btn31.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn32
            // 
            this.btn32.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn32.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn32.Location = new System.Drawing.Point(197, 345);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(75, 65);
            this.btn32.TabIndex = 11;
            this.btn32.UseVisualStyleBackColor = false;
            this.btn32.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn33
            // 
            this.btn33.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn33.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn33.Location = new System.Drawing.Point(305, 345);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(75, 65);
            this.btn33.TabIndex = 12;
            this.btn33.UseVisualStyleBackColor = false;
            this.btn33.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Comic Sans MS", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(91, 443);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(372, 74);
            this.lblInfo.TabIndex = 13;
            this.lblInfo.Text = "É a vez do X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 523);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btn33);
            this.Controls.Add(this.btn32);
            this.Controls.Add(this.btn31);
            this.Controls.Add(this.btn23);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.pibReset);
            this.Controls.Add(this.picFechar);
            this.Controls.Add(this.pibVelha);
            this.Controls.Add(this.pibTicTiac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da velha";
            ((System.ComponentModel.ISupportInitialize)(this.pibTicTiac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibVelha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibReset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibTicTiac;
        private System.Windows.Forms.PictureBox pibVelha;
        private System.Windows.Forms.PictureBox picFechar;
        private System.Windows.Forms.PictureBox pibReset;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn33;
        private System.Windows.Forms.Label lblInfo;
    }
}


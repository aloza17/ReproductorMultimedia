namespace ReproductorMultimedia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mpMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbListaArchivos = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mpMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // mpMediaPlayer
            // 
            this.mpMediaPlayer.Enabled = true;
            this.mpMediaPlayer.Location = new System.Drawing.Point(-2, 0);
            this.mpMediaPlayer.Name = "mpMediaPlayer";
            this.mpMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mpMediaPlayer.OcxState")));
            this.mpMediaPlayer.Size = new System.Drawing.Size(387, 548);
            this.mpMediaPlayer.TabIndex = 0;
            // 
            // lbListaArchivos
            // 
            this.lbListaArchivos.FormattingEnabled = true;
            this.lbListaArchivos.ItemHeight = 16;
            this.lbListaArchivos.Location = new System.Drawing.Point(480, 12);
            this.lbListaArchivos.Name = "lbListaArchivos";
            this.lbListaArchivos.Size = new System.Drawing.Size(279, 468);
            this.lbListaArchivos.TabIndex = 1;
            this.lbListaArchivos.SelectedIndexChanged += new System.EventHandler(this.lbListaArchivos_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Abrir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbListaArchivos);
            this.Controls.Add(this.mpMediaPlayer);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproductor Multimedia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mpMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mpMediaPlayer;
        private System.Windows.Forms.ListBox lbListaArchivos;
        private System.Windows.Forms.Button button1;
    }
}


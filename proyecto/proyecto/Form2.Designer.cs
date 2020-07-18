namespace proyecto
{
    partial class principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ventas = new System.Windows.Forms.Button();
            this.compras = new System.Windows.Forms.Button();
            this.mante = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU PRINCIPAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::proyecto.Properties.Resources.imagen;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(25, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 193);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // ventas
            // 
            this.ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ventas.Location = new System.Drawing.Point(286, 58);
            this.ventas.Name = "ventas";
            this.ventas.Size = new System.Drawing.Size(250, 70);
            this.ventas.TabIndex = 2;
            this.ventas.Text = "VENTAS";
            this.ventas.UseVisualStyleBackColor = true;
            this.ventas.Click += new System.EventHandler(this.Ventas_Click);
            // 
            // compras
            // 
            this.compras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compras.Location = new System.Drawing.Point(286, 150);
            this.compras.Name = "compras";
            this.compras.Size = new System.Drawing.Size(250, 70);
            this.compras.TabIndex = 3;
            this.compras.Text = "COMPRAS";
            this.compras.UseVisualStyleBackColor = true;
            this.compras.Click += new System.EventHandler(this.Compras_Click);
            // 
            // mante
            // 
            this.mante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mante.Location = new System.Drawing.Point(286, 251);
            this.mante.Name = "mante";
            this.mante.Size = new System.Drawing.Size(250, 70);
            this.mante.TabIndex = 4;
            this.mante.Text = "MANTENIMIENTO";
            this.mante.UseVisualStyleBackColor = true;
            this.mante.Click += new System.EventHandler(this.Button3_Click);
            // 
            // info
            // 
            this.info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info.Location = new System.Drawing.Point(286, 351);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(250, 70);
            this.info.TabIndex = 5;
            this.info.Text = "INFORMES";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.Info_Click);
            // 
            // salir
            // 
            this.salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(595, 262);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(137, 48);
            this.salir.TabIndex = 6;
            this.salir.Text = "SALIR";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.Button5_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.info);
            this.Controls.Add(this.mante);
            this.Controls.Add(this.compras);
            this.Controls.Add(this.ventas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "principal";
            this.Text = "KIOSKO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ventas;
        private System.Windows.Forms.Button compras;
        private System.Windows.Forms.Button mante;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button salir;
    }
}
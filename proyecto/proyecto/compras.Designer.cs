namespace proyecto
{
    partial class compras
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.costo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.precio_venta = new System.Windows.Forms.TextBox();
            this.descuento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.agregar = new System.Windows.Forms.Button();
            this.listacom = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.tot = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.factura = new System.Windows.Forms.TextBox();
            this.canti = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMPRAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proveedor";
            // 
            // pro
            // 
            this.pro.FormattingEnabled = true;
            this.pro.Location = new System.Drawing.Point(291, 62);
            this.pro.Name = "pro";
            this.pro.Size = new System.Drawing.Size(121, 21);
            this.pro.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codigo Producto";
            // 
            // cod
            // 
            this.cod.FormattingEnabled = true;
            this.cod.Location = new System.Drawing.Point(291, 86);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(121, 21);
            this.cod.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Costo Bruto";
            // 
            // costo
            // 
            this.costo.Location = new System.Drawing.Point(291, 111);
            this.costo.Name = "costo";
            this.costo.Size = new System.Drawing.Size(121, 20);
            this.costo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Precio Venta";
            // 
            // precio_venta
            // 
            this.precio_venta.Location = new System.Drawing.Point(291, 137);
            this.precio_venta.Name = "precio_venta";
            this.precio_venta.Size = new System.Drawing.Size(121, 20);
            this.precio_venta.TabIndex = 8;
            // 
            // descuento
            // 
            this.descuento.Location = new System.Drawing.Point(485, 137);
            this.descuento.Name = "descuento";
            this.descuento.Size = new System.Drawing.Size(100, 20);
            this.descuento.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Margen %";
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(291, 169);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(121, 23);
            this.agregar.TabIndex = 11;
            this.agregar.Text = "Agregar Compra";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listacom
            // 
            this.listacom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listacom.HideSelection = false;
            this.listacom.Location = new System.Drawing.Point(12, 198);
            this.listacom.Name = "listacom";
            this.listacom.Size = new System.Drawing.Size(762, 174);
            this.listacom.TabIndex = 12;
            this.listacom.UseCompatibleStateImageBehavior = false;
            this.listacom.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N°";
            this.columnHeader1.Width = 24;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Codigo";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Producto";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 289;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Costo";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 96;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cantida";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 73;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Descuento";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 83;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Sub Total";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 91;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(525, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "TOTAL";
            // 
            // tot
            // 
            this.tot.Location = new System.Drawing.Point(586, 378);
            this.tot.Name = "tot";
            this.tot.Size = new System.Drawing.Size(100, 20);
            this.tot.TabIndex = 14;
            this.tot.TextChanged += new System.EventHandler(this.Tot_TextChanged);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(188, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(442, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Guardar Compra";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Factura";
            // 
            // factura
            // 
            this.factura.Location = new System.Drawing.Point(128, 172);
            this.factura.Name = "factura";
            this.factura.Size = new System.Drawing.Size(100, 20);
            this.factura.TabIndex = 18;
            // 
            // canti
            // 
            this.canti.Location = new System.Drawing.Point(485, 111);
            this.canti.Name = "canti";
            this.canti.Size = new System.Drawing.Size(100, 20);
            this.canti.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(429, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cantidad";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listacom);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.descuento);
            this.Controls.Add(this.precio_venta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.costo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canti);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.factura);
            this.Controls.Add(this.label8);
            this.MaximizeBox = false;
            this.Name = "compras";
            this.Text = "compras";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Compras_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox costo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox precio_venta;
        private System.Windows.Forms.TextBox descuento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.ListView listacom;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tot;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox factura;
        private System.Windows.Forms.TextBox canti;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
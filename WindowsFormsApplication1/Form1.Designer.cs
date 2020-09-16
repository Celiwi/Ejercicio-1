namespace WindowsFormsApplication1
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
            this.BtnAleatorio = new System.Windows.Forms.Button();
            this.ListaAleatorio = new System.Windows.Forms.ListBox();
            this.BtnMayor = new System.Windows.Forms.Button();
            this.ListaMaxYMin = new System.Windows.Forms.ListBox();
            this.BtnPosiciones = new System.Windows.Forms.Button();
            this.ListaPosicion = new System.Windows.Forms.ListBox();
            this.btnAritmetica = new System.Windows.Forms.Button();
            this.ListaAritmetica = new System.Windows.Forms.ListBox();
            this.btnOrden = new System.Windows.Forms.Button();
            this.ListaOrden = new System.Windows.Forms.ListBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.ListaBuscar = new System.Windows.Forms.ListBox();
            this.TextoEscribir = new System.Windows.Forms.TextBox();
            this.btnInvertir = new System.Windows.Forms.Button();
            this.ListaInvertir = new System.Windows.Forms.ListBox();
            this.btnReemplazar = new System.Windows.Forms.Button();
            this.ListaReemplazar = new System.Windows.Forms.ListBox();
            this.btnAleatorioRepeticiones = new System.Windows.Forms.Button();
            this.ListaNoRepeticiones = new System.Windows.Forms.ListBox();
            this.btnContar = new System.Windows.Forms.Button();
            this.ListaContar = new System.Windows.Forms.ListBox();
            this.btnOrden2 = new System.Windows.Forms.Button();
            this.ListaOrden2 = new System.Windows.Forms.ListBox();
            this.btnBuscarReemplazar = new System.Windows.Forms.Button();
            this.TextoEscribir2 = new System.Windows.Forms.TextBox();
            this.ListaBuscarReemplazar = new System.Windows.Forms.ListBox();
            this.btnBuscarContar = new System.Windows.Forms.Button();
            this.TextoEscribir3 = new System.Windows.Forms.TextBox();
            this.ListaBuscarContar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnAleatorio
            // 
            this.BtnAleatorio.Location = new System.Drawing.Point(35, 24);
            this.BtnAleatorio.Name = "BtnAleatorio";
            this.BtnAleatorio.Size = new System.Drawing.Size(75, 23);
            this.BtnAleatorio.TabIndex = 0;
            this.BtnAleatorio.Text = "Botón1";
            this.BtnAleatorio.UseVisualStyleBackColor = true;
            this.BtnAleatorio.Click += new System.EventHandler(this.BtnAleatorio_Click);
            // 
            // ListaAleatorio
            // 
            this.ListaAleatorio.FormattingEnabled = true;
            this.ListaAleatorio.Location = new System.Drawing.Point(35, 76);
            this.ListaAleatorio.Name = "ListaAleatorio";
            this.ListaAleatorio.Size = new System.Drawing.Size(120, 95);
            this.ListaAleatorio.TabIndex = 1;
            // 
            // BtnMayor
            // 
            this.BtnMayor.Location = new System.Drawing.Point(182, 24);
            this.BtnMayor.Name = "BtnMayor";
            this.BtnMayor.Size = new System.Drawing.Size(75, 23);
            this.BtnMayor.TabIndex = 2;
            this.BtnMayor.Text = "Botón2";
            this.BtnMayor.UseVisualStyleBackColor = true;
            this.BtnMayor.Click += new System.EventHandler(this.BtnMayor_Click);
            // 
            // ListaMaxYMin
            // 
            this.ListaMaxYMin.FormattingEnabled = true;
            this.ListaMaxYMin.Location = new System.Drawing.Point(182, 76);
            this.ListaMaxYMin.Name = "ListaMaxYMin";
            this.ListaMaxYMin.Size = new System.Drawing.Size(120, 95);
            this.ListaMaxYMin.TabIndex = 3;
            this.ListaMaxYMin.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // BtnPosiciones
            // 
            this.BtnPosiciones.Location = new System.Drawing.Point(331, 24);
            this.BtnPosiciones.Name = "BtnPosiciones";
            this.BtnPosiciones.Size = new System.Drawing.Size(75, 23);
            this.BtnPosiciones.TabIndex = 4;
            this.BtnPosiciones.Text = "Botón3";
            this.BtnPosiciones.UseVisualStyleBackColor = true;
            this.BtnPosiciones.Click += new System.EventHandler(this.BtnPosiciones_Click);
            // 
            // ListaPosicion
            // 
            this.ListaPosicion.FormattingEnabled = true;
            this.ListaPosicion.Location = new System.Drawing.Point(331, 76);
            this.ListaPosicion.Name = "ListaPosicion";
            this.ListaPosicion.Size = new System.Drawing.Size(120, 95);
            this.ListaPosicion.TabIndex = 5;
            // 
            // btnAritmetica
            // 
            this.btnAritmetica.Location = new System.Drawing.Point(473, 24);
            this.btnAritmetica.Name = "btnAritmetica";
            this.btnAritmetica.Size = new System.Drawing.Size(75, 23);
            this.btnAritmetica.TabIndex = 6;
            this.btnAritmetica.Text = "Botón4";
            this.btnAritmetica.UseVisualStyleBackColor = true;
            this.btnAritmetica.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListaAritmetica
            // 
            this.ListaAritmetica.FormattingEnabled = true;
            this.ListaAritmetica.Location = new System.Drawing.Point(473, 76);
            this.ListaAritmetica.Name = "ListaAritmetica";
            this.ListaAritmetica.Size = new System.Drawing.Size(145, 95);
            this.ListaAritmetica.TabIndex = 7;
            // 
            // btnOrden
            // 
            this.btnOrden.Location = new System.Drawing.Point(624, 23);
            this.btnOrden.Name = "btnOrden";
            this.btnOrden.Size = new System.Drawing.Size(75, 23);
            this.btnOrden.TabIndex = 8;
            this.btnOrden.Text = "Botón5";
            this.btnOrden.UseVisualStyleBackColor = true;
            this.btnOrden.Click += new System.EventHandler(this.BotónOrdenar_Click);
            // 
            // ListaOrden
            // 
            this.ListaOrden.FormattingEnabled = true;
            this.ListaOrden.Location = new System.Drawing.Point(624, 76);
            this.ListaOrden.Name = "ListaOrden";
            this.ListaOrden.Size = new System.Drawing.Size(120, 95);
            this.ListaOrden.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(35, 203);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Botón 6";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BotónBuscar_Click);
            // 
            // ListaBuscar
            // 
            this.ListaBuscar.FormattingEnabled = true;
            this.ListaBuscar.Location = new System.Drawing.Point(35, 270);
            this.ListaBuscar.Name = "ListaBuscar";
            this.ListaBuscar.Size = new System.Drawing.Size(120, 95);
            this.ListaBuscar.TabIndex = 11;
            // 
            // TextoEscribir
            // 
            this.TextoEscribir.Location = new System.Drawing.Point(35, 233);
            this.TextoEscribir.Name = "TextoEscribir";
            this.TextoEscribir.Size = new System.Drawing.Size(100, 20);
            this.TextoEscribir.TabIndex = 12;
            // 
            // btnInvertir
            // 
            this.btnInvertir.Location = new System.Drawing.Point(182, 203);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(75, 23);
            this.btnInvertir.TabIndex = 13;
            this.btnInvertir.Text = "Botón 7";
            this.btnInvertir.UseVisualStyleBackColor = true;
            this.btnInvertir.Click += new System.EventHandler(this.BotonInvertir_Click);
            // 
            // ListaInvertir
            // 
            this.ListaInvertir.FormattingEnabled = true;
            this.ListaInvertir.Location = new System.Drawing.Point(182, 270);
            this.ListaInvertir.Name = "ListaInvertir";
            this.ListaInvertir.Size = new System.Drawing.Size(120, 95);
            this.ListaInvertir.TabIndex = 14;
            // 
            // btnReemplazar
            // 
            this.btnReemplazar.Location = new System.Drawing.Point(331, 203);
            this.btnReemplazar.Name = "btnReemplazar";
            this.btnReemplazar.Size = new System.Drawing.Size(75, 23);
            this.btnReemplazar.TabIndex = 15;
            this.btnReemplazar.Text = "Botón 8";
            this.btnReemplazar.UseVisualStyleBackColor = true;
            this.btnReemplazar.Click += new System.EventHandler(this.btnReemplazar_Click);
            // 
            // ListaReemplazar
            // 
            this.ListaReemplazar.FormattingEnabled = true;
            this.ListaReemplazar.Location = new System.Drawing.Point(331, 270);
            this.ListaReemplazar.Name = "ListaReemplazar";
            this.ListaReemplazar.Size = new System.Drawing.Size(120, 95);
            this.ListaReemplazar.TabIndex = 16;
            // 
            // btnAleatorioRepeticiones
            // 
            this.btnAleatorioRepeticiones.Location = new System.Drawing.Point(473, 202);
            this.btnAleatorioRepeticiones.Name = "btnAleatorioRepeticiones";
            this.btnAleatorioRepeticiones.Size = new System.Drawing.Size(75, 23);
            this.btnAleatorioRepeticiones.TabIndex = 17;
            this.btnAleatorioRepeticiones.Text = "Botón 9";
            this.btnAleatorioRepeticiones.UseVisualStyleBackColor = true;
            this.btnAleatorioRepeticiones.Click += new System.EventHandler(this.btnAleatorioRepeticiones_Click);
            // 
            // ListaNoRepeticiones
            // 
            this.ListaNoRepeticiones.FormattingEnabled = true;
            this.ListaNoRepeticiones.Location = new System.Drawing.Point(473, 270);
            this.ListaNoRepeticiones.Name = "ListaNoRepeticiones";
            this.ListaNoRepeticiones.Size = new System.Drawing.Size(120, 95);
            this.ListaNoRepeticiones.TabIndex = 18;
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(624, 202);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(75, 23);
            this.btnContar.TabIndex = 19;
            this.btnContar.Text = "Botón 10";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // ListaContar
            // 
            this.ListaContar.FormattingEnabled = true;
            this.ListaContar.Location = new System.Drawing.Point(624, 270);
            this.ListaContar.Name = "ListaContar";
            this.ListaContar.Size = new System.Drawing.Size(171, 95);
            this.ListaContar.TabIndex = 20;
            // 
            // btnOrden2
            // 
            this.btnOrden2.Location = new System.Drawing.Point(35, 391);
            this.btnOrden2.Name = "btnOrden2";
            this.btnOrden2.Size = new System.Drawing.Size(75, 23);
            this.btnOrden2.TabIndex = 21;
            this.btnOrden2.Text = "Botón 11";
            this.btnOrden2.UseVisualStyleBackColor = true;
            this.btnOrden2.Click += new System.EventHandler(this.btnOrdenar2_Click);
            // 
            // ListaOrden2
            // 
            this.ListaOrden2.FormattingEnabled = true;
            this.ListaOrden2.Location = new System.Drawing.Point(35, 439);
            this.ListaOrden2.Name = "ListaOrden2";
            this.ListaOrden2.Size = new System.Drawing.Size(120, 95);
            this.ListaOrden2.TabIndex = 22;
            // 
            // btnBuscarReemplazar
            // 
            this.btnBuscarReemplazar.Location = new System.Drawing.Point(182, 391);
            this.btnBuscarReemplazar.Name = "btnBuscarReemplazar";
            this.btnBuscarReemplazar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarReemplazar.TabIndex = 23;
            this.btnBuscarReemplazar.Text = "Botón 12";
            this.btnBuscarReemplazar.UseVisualStyleBackColor = true;
            this.btnBuscarReemplazar.Click += new System.EventHandler(this.btnBuscarReemplazar_Click);
            // 
            // TextoEscribir2
            // 
            this.TextoEscribir2.Location = new System.Drawing.Point(182, 421);
            this.TextoEscribir2.Name = "TextoEscribir2";
            this.TextoEscribir2.Size = new System.Drawing.Size(100, 20);
            this.TextoEscribir2.TabIndex = 24;
            // 
            // ListaBuscarReemplazar
            // 
            this.ListaBuscarReemplazar.FormattingEnabled = true;
            this.ListaBuscarReemplazar.Location = new System.Drawing.Point(182, 448);
            this.ListaBuscarReemplazar.Name = "ListaBuscarReemplazar";
            this.ListaBuscarReemplazar.Size = new System.Drawing.Size(120, 82);
            this.ListaBuscarReemplazar.TabIndex = 25;
            // 
            // btnBuscarContar
            // 
            this.btnBuscarContar.Location = new System.Drawing.Point(331, 390);
            this.btnBuscarContar.Name = "btnBuscarContar";
            this.btnBuscarContar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarContar.TabIndex = 26;
            this.btnBuscarContar.Text = "Botón 13";
            this.btnBuscarContar.UseVisualStyleBackColor = true;
            this.btnBuscarContar.Click += new System.EventHandler(this.btnBuscarContar_Click);
            // 
            // TextoEscribir3
            // 
            this.TextoEscribir3.Location = new System.Drawing.Point(331, 420);
            this.TextoEscribir3.Name = "TextoEscribir3";
            this.TextoEscribir3.Size = new System.Drawing.Size(100, 20);
            this.TextoEscribir3.TabIndex = 27;
            // 
            // ListaBuscarContar
            // 
            this.ListaBuscarContar.FormattingEnabled = true;
            this.ListaBuscarContar.Location = new System.Drawing.Point(331, 448);
            this.ListaBuscarContar.Name = "ListaBuscarContar";
            this.ListaBuscarContar.Size = new System.Drawing.Size(169, 82);
            this.ListaBuscarContar.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 559);
            this.Controls.Add(this.ListaBuscarContar);
            this.Controls.Add(this.TextoEscribir3);
            this.Controls.Add(this.btnBuscarContar);
            this.Controls.Add(this.ListaBuscarReemplazar);
            this.Controls.Add(this.TextoEscribir2);
            this.Controls.Add(this.btnBuscarReemplazar);
            this.Controls.Add(this.ListaOrden2);
            this.Controls.Add(this.btnOrden2);
            this.Controls.Add(this.ListaContar);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.ListaNoRepeticiones);
            this.Controls.Add(this.btnAleatorioRepeticiones);
            this.Controls.Add(this.ListaReemplazar);
            this.Controls.Add(this.btnReemplazar);
            this.Controls.Add(this.ListaInvertir);
            this.Controls.Add(this.btnInvertir);
            this.Controls.Add(this.TextoEscribir);
            this.Controls.Add(this.ListaBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.ListaOrden);
            this.Controls.Add(this.btnOrden);
            this.Controls.Add(this.ListaAritmetica);
            this.Controls.Add(this.btnAritmetica);
            this.Controls.Add(this.ListaPosicion);
            this.Controls.Add(this.BtnPosiciones);
            this.Controls.Add(this.ListaMaxYMin);
            this.Controls.Add(this.BtnMayor);
            this.Controls.Add(this.ListaAleatorio);
            this.Controls.Add(this.BtnAleatorio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAleatorio;
        private System.Windows.Forms.ListBox ListaAleatorio;
        private System.Windows.Forms.Button BtnMayor;
        private System.Windows.Forms.ListBox ListaMaxYMin;
        private System.Windows.Forms.Button BtnPosiciones;
        private System.Windows.Forms.ListBox ListaPosicion;
        private System.Windows.Forms.Button btnAritmetica;
        private System.Windows.Forms.ListBox ListaAritmetica;
        private System.Windows.Forms.Button btnOrden;
        private System.Windows.Forms.ListBox ListaOrden;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox ListaBuscar;
        private System.Windows.Forms.TextBox TextoEscribir;
        private System.Windows.Forms.Button btnInvertir;
        private System.Windows.Forms.ListBox ListaInvertir;
        private System.Windows.Forms.Button btnReemplazar;
        private System.Windows.Forms.ListBox ListaReemplazar;
        private System.Windows.Forms.Button btnAleatorioRepeticiones;
        private System.Windows.Forms.ListBox ListaNoRepeticiones;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.ListBox ListaContar;
        private System.Windows.Forms.Button btnOrden2;
        private System.Windows.Forms.ListBox ListaOrden2;
        private System.Windows.Forms.Button btnBuscarReemplazar;
        private System.Windows.Forms.TextBox TextoEscribir2;
        private System.Windows.Forms.ListBox ListaBuscarReemplazar;
        private System.Windows.Forms.Button btnBuscarContar;
        private System.Windows.Forms.TextBox TextoEscribir3;
        private System.Windows.Forms.ListBox ListaBuscarContar;
    }
}


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
            this.button1 = new System.Windows.Forms.Button();
            this.ListaAritmetica = new System.Windows.Forms.ListBox();
            this.BotónOrdenar = new System.Windows.Forms.Button();
            this.ListaOrden = new System.Windows.Forms.ListBox();
            this.BotónBuscar = new System.Windows.Forms.Button();
            this.ListaBuscar = new System.Windows.Forms.ListBox();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Botón4";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListaAritmetica
            // 
            this.ListaAritmetica.FormattingEnabled = true;
            this.ListaAritmetica.Location = new System.Drawing.Point(473, 76);
            this.ListaAritmetica.Name = "ListaAritmetica";
            this.ListaAritmetica.Size = new System.Drawing.Size(145, 95);
            this.ListaAritmetica.TabIndex = 7;
            // 
            // BotónOrdenar
            // 
            this.BotónOrdenar.Location = new System.Drawing.Point(624, 23);
            this.BotónOrdenar.Name = "BotónOrdenar";
            this.BotónOrdenar.Size = new System.Drawing.Size(75, 23);
            this.BotónOrdenar.TabIndex = 8;
            this.BotónOrdenar.Text = "Botón5";
            this.BotónOrdenar.UseVisualStyleBackColor = true;
            this.BotónOrdenar.Click += new System.EventHandler(this.BotónOrdenar_Click);
            // 
            // ListaOrden
            // 
            this.ListaOrden.FormattingEnabled = true;
            this.ListaOrden.Location = new System.Drawing.Point(624, 76);
            this.ListaOrden.Name = "ListaOrden";
            this.ListaOrden.Size = new System.Drawing.Size(120, 95);
            this.ListaOrden.TabIndex = 9;
            // 
            // BotónBuscar
            // 
            this.BotónBuscar.Location = new System.Drawing.Point(771, 23);
            this.BotónBuscar.Name = "BotónBuscar";
            this.BotónBuscar.Size = new System.Drawing.Size(75, 23);
            this.BotónBuscar.TabIndex = 10;
            this.BotónBuscar.Text = "Botón 6";
            this.BotónBuscar.UseVisualStyleBackColor = true;
            // 
            // ListaBuscar
            // 
            this.ListaBuscar.FormattingEnabled = true;
            this.ListaBuscar.Location = new System.Drawing.Point(771, 76);
            this.ListaBuscar.Name = "ListaBuscar";
            this.ListaBuscar.Size = new System.Drawing.Size(120, 95);
            this.ListaBuscar.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 336);
            this.Controls.Add(this.ListaBuscar);
            this.Controls.Add(this.BotónBuscar);
            this.Controls.Add(this.ListaOrden);
            this.Controls.Add(this.BotónOrdenar);
            this.Controls.Add(this.ListaAritmetica);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListaPosicion);
            this.Controls.Add(this.BtnPosiciones);
            this.Controls.Add(this.ListaMaxYMin);
            this.Controls.Add(this.BtnMayor);
            this.Controls.Add(this.ListaAleatorio);
            this.Controls.Add(this.BtnAleatorio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAleatorio;
        private System.Windows.Forms.ListBox ListaAleatorio;
        private System.Windows.Forms.Button BtnMayor;
        private System.Windows.Forms.ListBox ListaMaxYMin;
        private System.Windows.Forms.Button BtnPosiciones;
        private System.Windows.Forms.ListBox ListaPosicion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ListaAritmetica;
        private System.Windows.Forms.Button BotónOrdenar;
        private System.Windows.Forms.ListBox ListaOrden;
        private System.Windows.Forms.Button BotónBuscar;
        private System.Windows.Forms.ListBox ListaBuscar;
    }
}


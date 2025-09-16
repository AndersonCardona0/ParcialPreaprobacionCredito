namespace CapaPresentacion
{
    partial class Form1
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
            tbNumeroDocumento = new TextBox();
            tbIngresosTotales = new TextBox();
            tbEgresosTotales = new TextBox();
            tbMontoSolicitado = new TextBox();
            tbPlazoSolicitado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnConsultar = new Button();
            label6 = new Label();
            cbTipoDocumento = new ComboBox();
            SuspendLayout();
            // 
            // tbNumeroDocumento
            // 
            tbNumeroDocumento.Location = new Point(318, 129);
            tbNumeroDocumento.Name = "tbNumeroDocumento";
            tbNumeroDocumento.Size = new Size(100, 23);
            tbNumeroDocumento.TabIndex = 1;
            // 
            // tbIngresosTotales
            // 
            tbIngresosTotales.Location = new Point(318, 170);
            tbIngresosTotales.Name = "tbIngresosTotales";
            tbIngresosTotales.Size = new Size(100, 23);
            tbIngresosTotales.TabIndex = 2;
            // 
            // tbEgresosTotales
            // 
            tbEgresosTotales.Location = new Point(318, 209);
            tbEgresosTotales.Name = "tbEgresosTotales";
            tbEgresosTotales.Size = new Size(100, 23);
            tbEgresosTotales.TabIndex = 3;
            // 
            // tbMontoSolicitado
            // 
            tbMontoSolicitado.Location = new Point(318, 249);
            tbMontoSolicitado.Name = "tbMontoSolicitado";
            tbMontoSolicitado.Size = new Size(100, 23);
            tbMontoSolicitado.TabIndex = 4;
            // 
            // tbPlazoSolicitado
            // 
            tbPlazoSolicitado.Location = new Point(318, 292);
            tbPlazoSolicitado.Name = "tbPlazoSolicitado";
            tbPlazoSolicitado.Size = new Size(100, 23);
            tbPlazoSolicitado.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 93);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 6;
            label1.Text = "Tipo de Documento";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 132);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 7;
            label2.Text = "Número de Documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 173);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 8;
            label3.Text = "Ingresos Totales";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 212);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 9;
            label4.Text = "Egresos Totales";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(214, 252);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 10;
            label5.Text = "Monto Solicitado";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(318, 343);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(95, 33);
            btnConsultar.TabIndex = 11;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(178, 295);
            label6.Name = "label6";
            label6.Size = new Size(134, 15);
            label6.TabIndex = 12;
            label6.Text = "Plazo Solicitado (Meses)";
            // 
            // cbTipoDocumento
            // 
            cbTipoDocumento.FormattingEnabled = true;
            cbTipoDocumento.Items.AddRange(new object[] { "Cedula", "Tarjeta de Identidad" });
            cbTipoDocumento.Location = new Point(318, 90);
            cbTipoDocumento.Name = "cbTipoDocumento";
            cbTipoDocumento.Size = new Size(121, 23);
            cbTipoDocumento.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 430);
            Controls.Add(cbTipoDocumento);
            Controls.Add(label6);
            Controls.Add(btnConsultar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPlazoSolicitado);
            Controls.Add(tbMontoSolicitado);
            Controls.Add(tbEgresosTotales);
            Controls.Add(tbIngresosTotales);
            Controls.Add(tbNumeroDocumento);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbNumeroDocumento;
        private TextBox tbIngresosTotales;
        private TextBox tbEgresosTotales;
        private TextBox tbMontoSolicitado;
        private TextBox tbPlazoSolicitado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnConsultar;
        private Label label6;
        private ComboBox cbTipoDocumento;
    }
}

﻿namespace LewisVentas.View.VentasForm
{
    partial class VentasLista
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
            this.buttonVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Lista De Ventas";
            // 
            // buttonVenta
            // 
            this.buttonVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(34)))));
            this.buttonVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVenta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVenta.ForeColor = System.Drawing.Color.White;
            this.buttonVenta.Image = global::LewisVentas.Properties.Resources.cash_register__2_;
            this.buttonVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVenta.Location = new System.Drawing.Point(549, 377);
            this.buttonVenta.Name = "buttonVenta";
            this.buttonVenta.Size = new System.Drawing.Size(137, 37);
            this.buttonVenta.TabIndex = 30;
            this.buttonVenta.Text = "Hacer Venta";
            this.buttonVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonVenta.UseVisualStyleBackColor = false;
            this.buttonVenta.Click += new System.EventHandler(this.buttonVenta_Click);
            // 
            // VentasLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 483);
            this.Controls.Add(this.buttonVenta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentasLista";
            this.Text = "VentasLista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVenta;
    }
}
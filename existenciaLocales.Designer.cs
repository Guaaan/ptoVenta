
namespace ptoVenta
{
    partial class existenciaLocales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(existenciaLocales));
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalirIngreso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(210, 13);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(316, 36);
            this.txtPrecio.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 39);
            this.label2.TabIndex = 34;
            this.label2.Text = "Consultar:";
            // 
            // btnSalirIngreso
            // 
            this.btnSalirIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnSalirIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalirIngreso.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalirIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirIngreso.ForeColor = System.Drawing.Color.White;
            this.btnSalirIngreso.Location = new System.Drawing.Point(1275, 617);
            this.btnSalirIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalirIngreso.Name = "btnSalirIngreso";
            this.btnSalirIngreso.Size = new System.Drawing.Size(107, 44);
            this.btnSalirIngreso.TabIndex = 35;
            this.btnSalirIngreso.Text = "Atrás";
            this.btnSalirIngreso.UseVisualStyleBackColor = false;
            this.btnSalirIngreso.Click += new System.EventHandler(this.btnSalirIngreso_Click);
            // 
            // existenciaLocales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 674);
            this.Controls.Add(this.btnSalirIngreso);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "existenciaLocales";
            this.Text = "existenciaLocales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalirIngreso;
    }
}
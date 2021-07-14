
namespace ptoVenta
{
    partial class FormFactura
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
            this.btn_Cobrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cobrar
            // 
            this.btn_Cobrar.Location = new System.Drawing.Point(44, 92);
            this.btn_Cobrar.Name = "btn_Cobrar";
            this.btn_Cobrar.Size = new System.Drawing.Size(127, 71);
            this.btn_Cobrar.TabIndex = 0;
            this.btn_Cobrar.Text = "imprimir";
            this.btn_Cobrar.UseVisualStyleBackColor = true;
            this.btn_Cobrar.Click += new System.EventHandler(this.btn_Cobrar_Click);
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cobrar);
            this.Name = "FormFactura";
            this.Text = "FormFactura";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cobrar;
    }
}
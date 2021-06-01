
namespace ptoVenta
{
    partial class ticketsEmitidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ticketsEmitidos));
            this.label1 = new System.Windows.Forms.Label();
            this.btnFecha1 = new System.Windows.Forms.Button();
            this.dgvLista1 = new System.Windows.Forms.DataGridView();
            this.dgvLista2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tickets Emitidos";
            // 
            // btnFecha1
            // 
            this.btnFecha1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnFecha1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFecha1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFecha1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecha1.ForeColor = System.Drawing.Color.White;
            this.btnFecha1.Location = new System.Drawing.Point(1292, 19);
            this.btnFecha1.Margin = new System.Windows.Forms.Padding(4);
            this.btnFecha1.Name = "btnFecha1";
            this.btnFecha1.Size = new System.Drawing.Size(168, 60);
            this.btnFecha1.TabIndex = 3;
            this.btnFecha1.Text = "Fecha";
            this.btnFecha1.UseVisualStyleBackColor = false;
            // 
            // dgvLista1
            // 
            this.dgvLista1.BackgroundColor = System.Drawing.Color.White;
            this.dgvLista1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista1.Location = new System.Drawing.Point(13, 96);
            this.dgvLista1.Name = "dgvLista1";
            this.dgvLista1.RowHeadersWidth = 51;
            this.dgvLista1.RowTemplate.Height = 24;
            this.dgvLista1.Size = new System.Drawing.Size(1448, 356);
            this.dgvLista1.TabIndex = 19;
            // 
            // dgvLista2
            // 
            this.dgvLista2.BackgroundColor = System.Drawing.Color.White;
            this.dgvLista2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista2.Location = new System.Drawing.Point(62, 458);
            this.dgvLista2.Name = "dgvLista2";
            this.dgvLista2.RowHeadersWidth = 51;
            this.dgvLista2.RowTemplate.Height = 24;
            this.dgvLista2.Size = new System.Drawing.Size(1340, 333);
            this.dgvLista2.TabIndex = 20;
            // 
            // ticketsEmitidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1473, 812);
            this.Controls.Add(this.dgvLista2);
            this.Controls.Add(this.dgvLista1);
            this.Controls.Add(this.btnFecha1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ticketsEmitidos";
            this.Text = "ticketsEmitidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFecha1;
        private System.Windows.Forms.DataGridView dgvLista1;
        private System.Windows.Forms.DataGridView dgvLista2;
    }
}
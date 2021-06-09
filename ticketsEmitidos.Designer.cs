
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
            this.dgvLista1 = new System.Windows.Forms.DataGridView();
            this.dgvLista2 = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
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
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.panel12.Location = new System.Drawing.Point(1308, 73);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(153, 9);
            this.panel12.TabIndex = 101;
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.BackColor = System.Drawing.Color.Transparent;
            this.iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 50;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(1308, 12);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(153, 65);
            this.iconButton3.TabIndex = 100;
            this.iconButton3.TabStop = false;
            this.iconButton3.Text = "Fecha";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // ticketsEmitidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1473, 812);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.dgvLista2);
            this.Controls.Add(this.dgvLista1);
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
        private System.Windows.Forms.DataGridView dgvLista1;
        private System.Windows.Forms.DataGridView dgvLista2;
        private System.Windows.Forms.Panel panel12;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}
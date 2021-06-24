
namespace ptoVenta
{
    partial class AgregarFoto
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
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnExaminar = new FontAwesome.Sharp.IconButton();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.dgvFoto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel14
            // 
            this.panel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.panel14.Location = new System.Drawing.Point(196, 376);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(151, 9);
            this.panel14.TabIndex = 92;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExaminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExaminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExaminar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.btnExaminar.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnExaminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.btnExaminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExaminar.IconSize = 50;
            this.btnExaminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExaminar.Location = new System.Drawing.Point(196, 315);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(151, 65);
            this.btnExaminar.TabIndex = 91;
            this.btnExaminar.TabStop = false;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExaminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExaminar.UseVisualStyleBackColor = false;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // panel16
            // 
            this.panel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel16.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel16.Location = new System.Drawing.Point(27, 376);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(145, 9);
            this.panel16.TabIndex = 94;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.btnGuardar.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 50;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(27, 315);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(145, 65);
            this.btnGuardar.TabIndex = 93;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ptbImagen
            // 
            this.ptbImagen.Location = new System.Drawing.Point(12, 16);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(347, 283);
            this.ptbImagen.TabIndex = 96;
            this.ptbImagen.TabStop = false;
            // 
            // dgvFoto
            // 
            this.dgvFoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoto.Location = new System.Drawing.Point(381, 16);
            this.dgvFoto.Name = "dgvFoto";
            this.dgvFoto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvFoto.RowHeadersWidth = 51;
            this.dgvFoto.RowTemplate.Height = 24;
            this.dgvFoto.Size = new System.Drawing.Size(478, 283);
            this.dgvFoto.TabIndex = 97;
            // 
            // AgregarFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 553);
            this.Controls.Add(this.dgvFoto);
            this.Controls.Add(this.ptbImagen);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.btnExaminar);
            this.Name = "AgregarFoto";
            this.Text = "AgregarFoto";
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel14;
        private FontAwesome.Sharp.IconButton btnExaminar;
        private System.Windows.Forms.Panel panel16;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.PictureBox ptbImagen;
        private System.Windows.Forms.DataGridView dgvFoto;
    }
}
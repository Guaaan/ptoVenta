
namespace ptoVenta
{
    partial class aggImagen
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
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.cbListaFotos = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 80);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(63, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista fotos";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(320, 104);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(42, 23);
            this.btnAddFile.TabIndex = 4;
            this.btnAddFile.Text = "...";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog";
            // 
            // cbListaFotos
            // 
            this.cbListaFotos.FormattingEnabled = true;
            this.cbListaFotos.Items.AddRange(new object[] {
            "Fabian",
            "Hugo",
            "Alejandro"});
            this.cbListaFotos.Location = new System.Drawing.Point(81, 106);
            this.cbListaFotos.Name = "cbListaFotos";
            this.cbListaFotos.Size = new System.Drawing.Size(233, 21);
            this.cbListaFotos.TabIndex = 6;
            this.cbListaFotos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 133);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(379, 207);
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(239, 70);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // aggImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 352);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cbListaFotos);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Name = "aggImagen";
            this.Text = "aggImagen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ComboBox cbListaFotos;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnAgregar;
    }
}
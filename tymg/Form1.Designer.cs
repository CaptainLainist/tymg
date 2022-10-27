
namespace tymg
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.txtbox_ruta = new System.Windows.Forms.TextBox();
            this.txtbox_output = new System.Windows.Forms.TextBox();
            this.btn_img2text = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_dark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "tymg";
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_load.Location = new System.Drawing.Point(33, 103);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(134, 33);
            this.btn_load.TabIndex = 1;
            this.btn_load.Text = "Load image";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // txtbox_ruta
            // 
            this.txtbox_ruta.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbox_ruta.Location = new System.Drawing.Point(33, 142);
            this.txtbox_ruta.Name = "txtbox_ruta";
            this.txtbox_ruta.Size = new System.Drawing.Size(297, 20);
            this.txtbox_ruta.TabIndex = 2;
            // 
            // txtbox_output
            // 
            this.txtbox_output.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbox_output.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_output.Location = new System.Drawing.Point(429, 115);
            this.txtbox_output.Multiline = true;
            this.txtbox_output.Name = "txtbox_output";
            this.txtbox_output.ReadOnly = true;
            this.txtbox_output.Size = new System.Drawing.Size(359, 323);
            this.txtbox_output.TabIndex = 3;
            // 
            // btn_img2text
            // 
            this.btn_img2text.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_img2text.Location = new System.Drawing.Point(235, 407);
            this.btn_img2text.Name = "btn_img2text";
            this.btn_img2text.Size = new System.Drawing.Size(188, 31);
            this.btn_img2text.TabIndex = 4;
            this.btn_img2text.Text = "img 2 text";
            this.btn_img2text.UseVisualStyleBackColor = false;
            this.btn_img2text.Click += new System.EventHandler(this.btn_img2text_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txt_dark
            // 
            this.txt_dark.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_dark.Location = new System.Drawing.Point(33, 407);
            this.txt_dark.Name = "txt_dark";
            this.txt_dark.Size = new System.Drawing.Size(100, 20);
            this.txt_dark.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Level of Darkness";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_dark);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_img2text);
            this.Controls.Add(this.txtbox_output);
            this.Controls.Add(this.txtbox_ruta);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "tymg";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TextBox txtbox_ruta;
        private System.Windows.Forms.TextBox txtbox_output;
        private System.Windows.Forms.Button btn_img2text;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_dark;
        private System.Windows.Forms.Label label2;
    }
}


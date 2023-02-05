
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.txtbox_ruta = new System.Windows.Forms.TextBox();
            this.txtbox_output = new System.Windows.Forms.TextBox();
            this.btn_img2text = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_dark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ascii_chkbox = new System.Windows.Forms.CheckBox();
            this.txtbox_iheight = new System.Windows.Forms.TextBox();
            this.txtbox_iwidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_ctcb = new System.Windows.Forms.Button();
            this.timer_copied = new System.Windows.Forms.Timer(this.components);
            this.label_cptcb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "tymg";
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_load.Location = new System.Drawing.Point(44, 127);
            this.btn_load.Margin = new System.Windows.Forms.Padding(4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(179, 41);
            this.btn_load.TabIndex = 1;
            this.btn_load.Text = "Load image";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // txtbox_ruta
            // 
            this.txtbox_ruta.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbox_ruta.Location = new System.Drawing.Point(44, 175);
            this.txtbox_ruta.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_ruta.Name = "txtbox_ruta";
            this.txtbox_ruta.Size = new System.Drawing.Size(395, 22);
            this.txtbox_ruta.TabIndex = 2;
            // 
            // txtbox_output
            // 
            this.txtbox_output.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbox_output.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_output.Location = new System.Drawing.Point(572, 142);
            this.txtbox_output.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_output.Multiline = true;
            this.txtbox_output.Name = "txtbox_output";
            this.txtbox_output.ReadOnly = true;
            this.txtbox_output.Size = new System.Drawing.Size(477, 397);
            this.txtbox_output.TabIndex = 3;
            // 
            // btn_img2text
            // 
            this.btn_img2text.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_img2text.Location = new System.Drawing.Point(313, 501);
            this.btn_img2text.Margin = new System.Windows.Forms.Padding(4);
            this.btn_img2text.Name = "btn_img2text";
            this.btn_img2text.Size = new System.Drawing.Size(251, 38);
            this.btn_img2text.TabIndex = 4;
            this.btn_img2text.Text = "img 2 text";
            this.btn_img2text.UseVisualStyleBackColor = false;
            this.btn_img2text.Click += new System.EventHandler(this.btn_img2text_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(44, 222);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txt_dark
            // 
            this.txt_dark.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_dark.Location = new System.Drawing.Point(44, 501);
            this.txt_dark.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dark.Name = "txt_dark";
            this.txt_dark.Size = new System.Drawing.Size(132, 22);
            this.txt_dark.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 478);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Level of Darkness";
            // 
            // ascii_chkbox
            // 
            this.ascii_chkbox.AutoSize = true;
            this.ascii_chkbox.Location = new System.Drawing.Point(43, 409);
            this.ascii_chkbox.Name = "ascii_chkbox";
            this.ascii_chkbox.Size = new System.Drawing.Size(66, 21);
            this.ascii_chkbox.TabIndex = 8;
            this.ascii_chkbox.Text = "ascii?";
            this.ascii_chkbox.UseVisualStyleBackColor = true;
            // 
            // txtbox_iheight
            // 
            this.txtbox_iheight.Location = new System.Drawing.Point(313, 245);
            this.txtbox_iheight.Name = "txtbox_iheight";
            this.txtbox_iheight.Size = new System.Drawing.Size(189, 22);
            this.txtbox_iheight.TabIndex = 9;
            this.txtbox_iheight.Text = "50";
            // 
            // txtbox_iwidth
            // 
            this.txtbox_iwidth.Location = new System.Drawing.Point(313, 292);
            this.txtbox_iwidth.Name = "txtbox_iwidth";
            this.txtbox_iwidth.Size = new System.Drawing.Size(189, 22);
            this.txtbox_iwidth.TabIndex = 10;
            this.txtbox_iwidth.Text = "50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "image height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "image width";
            // 
            // button_ctcb
            // 
            this.button_ctcb.BackColor = System.Drawing.Color.SlateBlue;
            this.button_ctcb.Location = new System.Drawing.Point(572, 79);
            this.button_ctcb.Margin = new System.Windows.Forms.Padding(4);
            this.button_ctcb.Name = "button_ctcb";
            this.button_ctcb.Size = new System.Drawing.Size(179, 41);
            this.button_ctcb.TabIndex = 13;
            this.button_ctcb.Text = "Copy to clipboard";
            this.button_ctcb.UseVisualStyleBackColor = false;
            this.button_ctcb.Click += new System.EventHandler(this.button_ctcb_Click);
            // 
            // timer_copied
            // 
            this.timer_copied.Interval = 3000;
            this.timer_copied.Tick += new System.EventHandler(this.timer_copied_Tick);
            // 
            // label_cptcb
            // 
            this.label_cptcb.AutoSize = true;
            this.label_cptcb.ForeColor = System.Drawing.Color.Lime;
            this.label_cptcb.Location = new System.Drawing.Point(769, 102);
            this.label_cptcb.Name = "label_cptcb";
            this.label_cptcb.Size = new System.Drawing.Size(12, 17);
            this.label_cptcb.TabIndex = 14;
            this.label_cptcb.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label_cptcb);
            this.Controls.Add(this.button_ctcb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_iwidth);
            this.Controls.Add(this.txtbox_iheight);
            this.Controls.Add(this.ascii_chkbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_dark);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_img2text);
            this.Controls.Add(this.txtbox_output);
            this.Controls.Add(this.txtbox_ruta);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.CheckBox ascii_chkbox;
        private System.Windows.Forms.TextBox txtbox_iheight;
        private System.Windows.Forms.TextBox txtbox_iwidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_ctcb;
        private System.Windows.Forms.Timer timer_copied;
        private System.Windows.Forms.Label label_cptcb;
    }
}


namespace calculator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnlaske = new System.Windows.Forms.Button();
            this.textTulos = new System.Windows.Forms.TextBox();
            this.lbl_nykyinenOperaatio = new System.Windows.Forms.Label();
            this.nappi7 = new System.Windows.Forms.Button();
            this.nappi8 = new System.Windows.Forms.Button();
            this.nappi9 = new System.Windows.Forms.Button();
            this.nappi4 = new System.Windows.Forms.Button();
            this.nappi5 = new System.Windows.Forms.Button();
            this.nappi6 = new System.Windows.Forms.Button();
            this.nappi1 = new System.Windows.Forms.Button();
            this.nappi2 = new System.Windows.Forms.Button();
            this.nappi3 = new System.Windows.Forms.Button();
            this.nappi0 = new System.Windows.Forms.Button();
            this.buttonJako = new System.Windows.Forms.Button();
            this.btnKerto = new System.Windows.Forms.Button();
            this.btnMiinus = new System.Windows.Forms.Button();
            this.btnPlussa = new System.Windows.Forms.Button();
            this.btnTakaisin = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pilkku = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlaske
            // 
            this.btnlaske.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnlaske.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlaske.Location = new System.Drawing.Point(286, 180);
            this.btnlaske.Name = "btnlaske";
            this.btnlaske.Size = new System.Drawing.Size(78, 124);
            this.btnlaske.TabIndex = 0;
            this.btnlaske.Text = "=";
            this.btnlaske.UseVisualStyleBackColor = false;
            this.btnlaske.Click += new System.EventHandler(this.onYhteensa_click);
            // 
            // textTulos
            // 
            this.textTulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTulos.Location = new System.Drawing.Point(26, 47);
            this.textTulos.Name = "textTulos";
            this.textTulos.Size = new System.Drawing.Size(338, 41);
            this.textTulos.TabIndex = 2;
            this.textTulos.Text = "0";
            this.textTulos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_nykyinenOperaatio
            // 
            this.lbl_nykyinenOperaatio.AutoSize = true;
            this.lbl_nykyinenOperaatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nykyinenOperaatio.ForeColor = System.Drawing.Color.Gray;
            this.lbl_nykyinenOperaatio.Location = new System.Drawing.Point(21, 9);
            this.lbl_nykyinenOperaatio.Name = "lbl_nykyinenOperaatio";
            this.lbl_nykyinenOperaatio.Size = new System.Drawing.Size(0, 25);
            this.lbl_nykyinenOperaatio.TabIndex = 3;
            this.lbl_nykyinenOperaatio.Tag = "";
            // 
            // nappi7
            // 
            this.nappi7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nappi7.Location = new System.Drawing.Point(26, 94);
            this.nappi7.Name = "nappi7";
            this.nappi7.Size = new System.Drawing.Size(55, 48);
            this.nappi7.TabIndex = 4;
            this.nappi7.Text = "7";
            this.nappi7.UseVisualStyleBackColor = true;
            this.nappi7.Click += new System.EventHandler(this.button_click);
            // 
            // nappi8
            // 
            this.nappi8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nappi8.Location = new System.Drawing.Point(84, 94);
            this.nappi8.Name = "nappi8";
            this.nappi8.Size = new System.Drawing.Size(55, 48);
            this.nappi8.TabIndex = 5;
            this.nappi8.Text = "8";
            this.nappi8.UseVisualStyleBackColor = true;
            this.nappi8.Click += new System.EventHandler(this.button_click);
            // 
            // nappi9
            // 
            this.nappi9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nappi9.Location = new System.Drawing.Point(142, 94);
            this.nappi9.Name = "nappi9";
            this.nappi9.Size = new System.Drawing.Size(55, 48);
            this.nappi9.TabIndex = 6;
            this.nappi9.Text = "9";
            this.nappi9.UseVisualStyleBackColor = true;
            this.nappi9.Click += new System.EventHandler(this.button_click);
            // 
            // nappi4
            // 
            this.nappi4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nappi4.Location = new System.Drawing.Point(26, 148);
            this.nappi4.Name = "nappi4";
            this.nappi4.Size = new System.Drawing.Size(55, 48);
            this.nappi4.TabIndex = 7;
            this.nappi4.Text = "4";
            this.nappi4.UseVisualStyleBackColor = true;
            this.nappi4.Click += new System.EventHandler(this.button_click);
            // 
            // nappi5
            // 
            this.nappi5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nappi5.Location = new System.Drawing.Point(84, 148);
            this.nappi5.Name = "nappi5";
            this.nappi5.Size = new System.Drawing.Size(55, 48);
            this.nappi5.TabIndex = 8;
            this.nappi5.Text = "5";
            this.nappi5.UseVisualStyleBackColor = true;
            this.nappi5.Click += new System.EventHandler(this.button_click);
            // 
            // nappi6
            // 
            this.nappi6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nappi6.Location = new System.Drawing.Point(142, 148);
            this.nappi6.Name = "nappi6";
            this.nappi6.Size = new System.Drawing.Size(55, 48);
            this.nappi6.TabIndex = 9;
            this.nappi6.Text = "6";
            this.nappi6.UseVisualStyleBackColor = true;
            this.nappi6.Click += new System.EventHandler(this.button_click);
            // 
            // nappi1
            // 
            this.nappi1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nappi1.Location = new System.Drawing.Point(26, 202);
            this.nappi1.Name = "nappi1";
            this.nappi1.Size = new System.Drawing.Size(55, 48);
            this.nappi1.TabIndex = 10;
            this.nappi1.Text = "1";
            this.nappi1.UseVisualStyleBackColor = true;
            this.nappi1.Click += new System.EventHandler(this.button_click);
            // 
            // nappi2
            // 
            this.nappi2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nappi2.Location = new System.Drawing.Point(84, 202);
            this.nappi2.Name = "nappi2";
            this.nappi2.Size = new System.Drawing.Size(55, 48);
            this.nappi2.TabIndex = 11;
            this.nappi2.Text = "2";
            this.nappi2.UseVisualStyleBackColor = true;
            this.nappi2.Click += new System.EventHandler(this.button_click);
            // 
            // nappi3
            // 
            this.nappi3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nappi3.Location = new System.Drawing.Point(142, 202);
            this.nappi3.Name = "nappi3";
            this.nappi3.Size = new System.Drawing.Size(55, 48);
            this.nappi3.TabIndex = 12;
            this.nappi3.Text = "3";
            this.nappi3.UseVisualStyleBackColor = true;
            this.nappi3.Click += new System.EventHandler(this.button_click);
            // 
            // nappi0
            // 
            this.nappi0.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nappi0.Location = new System.Drawing.Point(26, 256);
            this.nappi0.Name = "nappi0";
            this.nappi0.Size = new System.Drawing.Size(113, 48);
            this.nappi0.TabIndex = 13;
            this.nappi0.Text = "0";
            this.nappi0.UseVisualStyleBackColor = true;
            this.nappi0.Click += new System.EventHandler(this.button_click);
            // 
            // buttonJako
            // 
            this.buttonJako.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonJako.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJako.Location = new System.Drawing.Point(200, 94);
            this.buttonJako.Name = "buttonJako";
            this.buttonJako.Size = new System.Drawing.Size(77, 48);
            this.buttonJako.TabIndex = 14;
            this.buttonJako.Text = "/";
            this.buttonJako.UseVisualStyleBackColor = false;
            this.buttonJako.Click += new System.EventHandler(this.lasku_click);
            // 
            // btnKerto
            // 
            this.btnKerto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKerto.Location = new System.Drawing.Point(200, 148);
            this.btnKerto.Name = "btnKerto";
            this.btnKerto.Size = new System.Drawing.Size(77, 48);
            this.btnKerto.TabIndex = 15;
            this.btnKerto.Text = "*";
            this.btnKerto.UseVisualStyleBackColor = false;
            this.btnKerto.Click += new System.EventHandler(this.lasku_click);
            // 
            // btnMiinus
            // 
            this.btnMiinus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMiinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiinus.Location = new System.Drawing.Point(200, 202);
            this.btnMiinus.Name = "btnMiinus";
            this.btnMiinus.Size = new System.Drawing.Size(77, 48);
            this.btnMiinus.TabIndex = 16;
            this.btnMiinus.Text = "-";
            this.btnMiinus.UseVisualStyleBackColor = false;
            this.btnMiinus.Click += new System.EventHandler(this.lasku_click);
            // 
            // btnPlussa
            // 
            this.btnPlussa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlussa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlussa.Location = new System.Drawing.Point(199, 256);
            this.btnPlussa.Name = "btnPlussa";
            this.btnPlussa.Size = new System.Drawing.Size(77, 48);
            this.btnPlussa.TabIndex = 17;
            this.btnPlussa.Text = "+";
            this.btnPlussa.UseVisualStyleBackColor = false;
            this.btnPlussa.Click += new System.EventHandler(this.lasku_click);
            // 
            // btnTakaisin
            // 
            this.btnTakaisin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTakaisin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakaisin.Location = new System.Drawing.Point(285, 136);
            this.btnTakaisin.Name = "btnTakaisin";
            this.btnTakaisin.Size = new System.Drawing.Size(78, 38);
            this.btnTakaisin.TabIndex = 18;
            this.btnTakaisin.Text = "<=";
            this.btnTakaisin.UseVisualStyleBackColor = false;
            this.btnTakaisin.Click += new System.EventHandler(this.takaisin_click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pilkku
            // 
            this.pilkku.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilkku.Location = new System.Drawing.Point(142, 256);
            this.pilkku.Name = "pilkku";
            this.pilkku.Size = new System.Drawing.Size(55, 48);
            this.pilkku.TabIndex = 20;
            this.pilkku.Text = ",";
            this.pilkku.UseVisualStyleBackColor = true;
            this.pilkku.Click += new System.EventHandler(this.button_click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(286, 92);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 38);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.clear_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 320);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pilkku);
            this.Controls.Add(this.btnTakaisin);
            this.Controls.Add(this.btnPlussa);
            this.Controls.Add(this.btnMiinus);
            this.Controls.Add(this.btnKerto);
            this.Controls.Add(this.buttonJako);
            this.Controls.Add(this.nappi0);
            this.Controls.Add(this.nappi3);
            this.Controls.Add(this.nappi2);
            this.Controls.Add(this.nappi1);
            this.Controls.Add(this.nappi6);
            this.Controls.Add(this.nappi5);
            this.Controls.Add(this.nappi4);
            this.Controls.Add(this.nappi9);
            this.Controls.Add(this.nappi8);
            this.Controls.Add(this.nappi7);
            this.Controls.Add(this.lbl_nykyinenOperaatio);
            this.Controls.Add(this.textTulos);
            this.Controls.Add(this.btnlaske);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlaske;
        private System.Windows.Forms.TextBox textTulos;
        private System.Windows.Forms.Label lbl_nykyinenOperaatio;
        private System.Windows.Forms.Button nappi7;
        private System.Windows.Forms.Button nappi8;
        private System.Windows.Forms.Button nappi9;
        private System.Windows.Forms.Button nappi4;
        private System.Windows.Forms.Button nappi5;
        private System.Windows.Forms.Button nappi6;
        private System.Windows.Forms.Button nappi1;
        private System.Windows.Forms.Button nappi2;
        private System.Windows.Forms.Button nappi3;
        private System.Windows.Forms.Button nappi0;
        private System.Windows.Forms.Button buttonJako;
        private System.Windows.Forms.Button btnKerto;
        private System.Windows.Forms.Button btnMiinus;
        private System.Windows.Forms.Button btnPlussa;
        private System.Windows.Forms.Button btnTakaisin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button pilkku;
        private System.Windows.Forms.Button btnClear;
    }
}


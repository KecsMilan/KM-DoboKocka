namespace KM_dobokocka
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
            this.idozito = new System.Windows.Forms.Timer(this.components);
            this.jatekos = new System.Windows.Forms.Label();
            this.gep = new System.Windows.Forms.Label();
            this.indit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.jatekos_gyozelmei = new System.Windows.Forms.Label();
            this.jatekos_6osDobasok = new System.Windows.Forms.Label();
            this.gep_gyozelmei = new System.Windows.Forms.Label();
            this.gep_6osDobasok = new System.Windows.Forms.Label();
            this.jatekos_szeria = new System.Windows.Forms.Label();
            this.gep_szeria = new System.Windows.Forms.Label();
            this.jatekos_lista = new System.Windows.Forms.Label();
            this.gep_lista = new System.Windows.Forms.Label();
            this.jatekos_sum = new System.Windows.Forms.Label();
            this.gep_sum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idozito
            // 
            this.idozito.Interval = 1000;
            this.idozito.Tick += new System.EventHandler(this.idozito_Tick);
            // 
            // jatekos
            // 
            this.jatekos.AutoSize = true;
            this.jatekos.Location = new System.Drawing.Point(39, 25);
            this.jatekos.Name = "jatekos";
            this.jatekos.Size = new System.Drawing.Size(79, 13);
            this.jatekos.TabIndex = 4;
            this.jatekos.Text = "jatekos_szamai";
            // 
            // gep
            // 
            this.gep.AutoSize = true;
            this.gep.Location = new System.Drawing.Point(39, 374);
            this.gep.Name = "gep";
            this.gep.Size = new System.Drawing.Size(63, 13);
            this.gep.TabIndex = 5;
            this.gep.Text = "gep_szamai";
            // 
            // indit
            // 
            this.indit.Location = new System.Drawing.Point(356, 216);
            this.indit.Name = "indit";
            this.indit.Size = new System.Drawing.Size(75, 23);
            this.indit.TabIndex = 6;
            this.indit.Text = "Start";
            this.indit.UseVisualStyleBackColor = true;
            this.indit.Click += new System.EventHandler(this.indit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "A győzelmeinek a száma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "6-os dobások száma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nyerő szériája:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "A győzelmeinek a száma:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "6-os dobások száma:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(631, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nyerő szériája:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 13;
            // 
            // jatekos_gyozelmei
            // 
            this.jatekos_gyozelmei.AutoSize = true;
            this.jatekos_gyozelmei.Location = new System.Drawing.Point(171, 87);
            this.jatekos_gyozelmei.Name = "jatekos_gyozelmei";
            this.jatekos_gyozelmei.Size = new System.Drawing.Size(13, 13);
            this.jatekos_gyozelmei.TabIndex = 14;
            this.jatekos_gyozelmei.Text = "0";
            this.jatekos_gyozelmei.Click += new System.EventHandler(this.jatekos_gyozelmei_Click);
            // 
            // jatekos_6osDobasok
            // 
            this.jatekos_6osDobasok.AutoSize = true;
            this.jatekos_6osDobasok.Location = new System.Drawing.Point(171, 109);
            this.jatekos_6osDobasok.Name = "jatekos_6osDobasok";
            this.jatekos_6osDobasok.Size = new System.Drawing.Size(13, 13);
            this.jatekos_6osDobasok.TabIndex = 15;
            this.jatekos_6osDobasok.Text = "0";
            // 
            // gep_gyozelmei
            // 
            this.gep_gyozelmei.AutoSize = true;
            this.gep_gyozelmei.Location = new System.Drawing.Point(713, 309);
            this.gep_gyozelmei.Name = "gep_gyozelmei";
            this.gep_gyozelmei.Size = new System.Drawing.Size(13, 13);
            this.gep_gyozelmei.TabIndex = 16;
            this.gep_gyozelmei.Text = "0";
            // 
            // gep_6osDobasok
            // 
            this.gep_6osDobasok.AutoSize = true;
            this.gep_6osDobasok.Location = new System.Drawing.Point(713, 333);
            this.gep_6osDobasok.Name = "gep_6osDobasok";
            this.gep_6osDobasok.Size = new System.Drawing.Size(13, 13);
            this.gep_6osDobasok.TabIndex = 17;
            this.gep_6osDobasok.Text = "0";
            // 
            // jatekos_szeria
            // 
            this.jatekos_szeria.AutoSize = true;
            this.jatekos_szeria.Location = new System.Drawing.Point(168, 131);
            this.jatekos_szeria.Name = "jatekos_szeria";
            this.jatekos_szeria.Size = new System.Drawing.Size(52, 13);
            this.jatekos_szeria.TabIndex = 18;
            this.jatekos_szeria.Text = "Nem volt.";
            // 
            // gep_szeria
            // 
            this.gep_szeria.AutoSize = true;
            this.gep_szeria.Location = new System.Drawing.Point(705, 355);
            this.gep_szeria.Name = "gep_szeria";
            this.gep_szeria.Size = new System.Drawing.Size(52, 13);
            this.gep_szeria.TabIndex = 19;
            this.gep_szeria.Text = "Nem volt.";
            // 
            // jatekos_lista
            // 
            this.jatekos_lista.AutoSize = true;
            this.jatekos_lista.Location = new System.Drawing.Point(41, 50);
            this.jatekos_lista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.jatekos_lista.Name = "jatekos_lista";
            this.jatekos_lista.Size = new System.Drawing.Size(35, 13);
            this.jatekos_lista.TabIndex = 20;
            this.jatekos_lista.Text = "label8";
            // 
            // gep_lista
            // 
            this.gep_lista.AutoSize = true;
            this.gep_lista.Location = new System.Drawing.Point(39, 400);
            this.gep_lista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gep_lista.Name = "gep_lista";
            this.gep_lista.Size = new System.Drawing.Size(35, 13);
            this.gep_lista.TabIndex = 21;
            this.gep_lista.Text = "label8";
            // 
            // jatekos_sum
            // 
            this.jatekos_sum.AutoSize = true;
            this.jatekos_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.jatekos_sum.Location = new System.Drawing.Point(368, 159);
            this.jatekos_sum.Name = "jatekos_sum";
            this.jatekos_sum.Size = new System.Drawing.Size(103, 38);
            this.jatekos_sum.TabIndex = 23;
            this.jatekos_sum.Text = "label8";
            // 
            // gep_sum
            // 
            this.gep_sum.AutoSize = true;
            this.gep_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.gep_sum.Location = new System.Drawing.Point(368, 260);
            this.gep_sum.Name = "gep_sum";
            this.gep_sum.Size = new System.Drawing.Size(103, 38);
            this.gep_sum.TabIndex = 24;
            this.gep_sum.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gep_sum);
            this.Controls.Add(this.jatekos_sum);
            this.Controls.Add(this.gep_lista);
            this.Controls.Add(this.jatekos_lista);
            this.Controls.Add(this.gep_szeria);
            this.Controls.Add(this.jatekos_szeria);
            this.Controls.Add(this.gep_6osDobasok);
            this.Controls.Add(this.gep_gyozelmei);
            this.Controls.Add(this.jatekos_6osDobasok);
            this.Controls.Add(this.jatekos_gyozelmei);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.indit);
            this.Controls.Add(this.gep);
            this.Controls.Add(this.jatekos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer idozito;
        private System.Windows.Forms.Label jatekos;
        private System.Windows.Forms.Label gep;
        private System.Windows.Forms.Button indit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label jatekos_gyozelmei;
        private System.Windows.Forms.Label jatekos_6osDobasok;
        private System.Windows.Forms.Label gep_gyozelmei;
        private System.Windows.Forms.Label gep_6osDobasok;
        private System.Windows.Forms.Label jatekos_szeria;
        private System.Windows.Forms.Label gep_szeria;
        private System.Windows.Forms.Label jatekos_lista;
        private System.Windows.Forms.Label gep_lista;
        private System.Windows.Forms.Label jatekos_sum;
        private System.Windows.Forms.Label gep_sum;
    }
}


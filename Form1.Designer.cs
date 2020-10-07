namespace PracticaControlesDeFormulario
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
            this.txtboxclient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxtelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxaddress = new System.Windows.Forms.TextBox();
            this.txtboxcp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCEUX = new System.Windows.Forms.RadioButton();
            this.rbCEU = new System.Windows.Forms.RadioButton();
            this.rbAMDR9 = new System.Windows.Forms.RadioButton();
            this.rbAMDR7 = new System.Windows.Forms.RadioButton();
            this.rbICi9 = new System.Windows.Forms.RadioButton();
            this.rbICi7 = new System.Windows.Forms.RadioButton();
            this.cboxOS = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb4gb = new System.Windows.Forms.RadioButton();
            this.rb8gb = new System.Windows.Forms.RadioButton();
            this.rb16gb = new System.Windows.Forms.RadioButton();
            this.rb32gb = new System.Windows.Forms.RadioButton();
            this.rb64gb = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboxADATA = new System.Windows.Forms.CheckBox();
            this.cboxWD = new System.Windows.Forms.CheckBox();
            this.cboxToshiba = new System.Windows.Forms.CheckBox();
            this.cboxSeagate = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cboxRadeon = new System.Windows.Forms.CheckBox();
            this.cboxGeForce = new System.Windows.Forms.CheckBox();
            this.cboxOmegaS = new System.Windows.Forms.CheckBox();
            this.cboxAorus = new System.Windows.Forms.CheckBox();
            this.cboxCase = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtboxclient
            // 
            this.txtboxclient.AcceptsReturn = true;
            this.txtboxclient.Location = new System.Drawing.Point(99, 24);
            this.txtboxclient.MaxLength = 60;
            this.txtboxclient.Name = "txtboxclient";
            this.txtboxclient.Size = new System.Drawing.Size(325, 20);
            this.txtboxclient.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Guardar información";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(452, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de teléfono:";
            // 
            // txtboxtelefono
            // 
            this.txtboxtelefono.AcceptsReturn = true;
            this.txtboxtelefono.Location = new System.Drawing.Point(590, 24);
            this.txtboxtelefono.MaxLength = 20;
            this.txtboxtelefono.Name = "txtboxtelefono";
            this.txtboxtelefono.Size = new System.Drawing.Size(181, 20);
            this.txtboxtelefono.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dirección:";
            // 
            // txtboxaddress
            // 
            this.txtboxaddress.AcceptsReturn = true;
            this.txtboxaddress.Location = new System.Drawing.Point(99, 63);
            this.txtboxaddress.MaxLength = 150;
            this.txtboxaddress.Name = "txtboxaddress";
            this.txtboxaddress.Size = new System.Drawing.Size(325, 20);
            this.txtboxaddress.TabIndex = 5;
            // 
            // txtboxcp
            // 
            this.txtboxcp.AcceptsReturn = true;
            this.txtboxcp.Location = new System.Drawing.Point(590, 63);
            this.txtboxcp.MaxLength = 5;
            this.txtboxcp.Name = "txtboxcp";
            this.txtboxcp.Size = new System.Drawing.Size(181, 20);
            this.txtboxcp.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(487, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Código postal:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCEUX);
            this.groupBox1.Controls.Add(this.rbCEU);
            this.groupBox1.Controls.Add(this.rbAMDR9);
            this.groupBox1.Controls.Add(this.rbAMDR7);
            this.groupBox1.Controls.Add(this.rbICi9);
            this.groupBox1.Controls.Add(this.rbICi7);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(28, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 173);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione su procesador:";
            // 
            // rbCEUX
            // 
            this.rbCEUX.AutoSize = true;
            this.rbCEUX.Location = new System.Drawing.Point(7, 140);
            this.rbCEUX.Name = "rbCEUX";
            this.rbCEUX.Size = new System.Drawing.Size(199, 24);
            this.rbCEUX.TabIndex = 5;
            this.rbCEUX.Text = "Cybertron\'s Energon 2015UX";
            this.rbCEUX.UseVisualStyleBackColor = true;
            // 
            // rbCEU
            // 
            this.rbCEU.AutoSize = true;
            this.rbCEU.Location = new System.Drawing.Point(7, 116);
            this.rbCEU.Name = "rbCEU";
            this.rbCEU.Size = new System.Drawing.Size(191, 24);
            this.rbCEU.TabIndex = 4;
            this.rbCEU.Text = "Cybertron\'s Energon 2005U";
            this.rbCEU.UseVisualStyleBackColor = true;
            // 
            // rbAMDR9
            // 
            this.rbAMDR9.AutoSize = true;
            this.rbAMDR9.Location = new System.Drawing.Point(7, 92);
            this.rbAMDR9.Name = "rbAMDR9";
            this.rbAMDR9.Size = new System.Drawing.Size(149, 24);
            this.rbAMDR9.TabIndex = 3;
            this.rbAMDR9.Text = "AMD Ryzen 9 3950X";
            this.rbAMDR9.UseVisualStyleBackColor = true;
            // 
            // rbAMDR7
            // 
            this.rbAMDR7.AutoSize = true;
            this.rbAMDR7.Location = new System.Drawing.Point(7, 68);
            this.rbAMDR7.Name = "rbAMDR7";
            this.rbAMDR7.Size = new System.Drawing.Size(149, 24);
            this.rbAMDR7.TabIndex = 2;
            this.rbAMDR7.Text = "AMD Ryzen 7 3800X";
            this.rbAMDR7.UseVisualStyleBackColor = true;
            // 
            // rbICi9
            // 
            this.rbICi9.AutoSize = true;
            this.rbICi9.Location = new System.Drawing.Point(7, 44);
            this.rbICi9.Name = "rbICi9";
            this.rbICi9.Size = new System.Drawing.Size(146, 24);
            this.rbICi9.TabIndex = 1;
            this.rbICi9.Text = "Intel Core i9-10980K";
            this.rbICi9.UseVisualStyleBackColor = true;
            // 
            // rbICi7
            // 
            this.rbICi7.AutoSize = true;
            this.rbICi7.Checked = true;
            this.rbICi7.Location = new System.Drawing.Point(7, 20);
            this.rbICi7.Name = "rbICi7";
            this.rbICi7.Size = new System.Drawing.Size(139, 24);
            this.rbICi7.TabIndex = 0;
            this.rbICi7.TabStop = true;
            this.rbICi7.Text = "Intel Core i7-9700K";
            this.rbICi7.UseVisualStyleBackColor = true;
            // 
            // cboxOS
            // 
            this.cboxOS.FormattingEnabled = true;
            this.cboxOS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboxOS.Items.AddRange(new object[] {
            "Windows 7 Professional",
            "Windows 10 Pro",
            "macOS Mojave",
            "macOS Catalina",
            "ENCOM OS 11",
            "ENCOM OS 12"});
            this.cboxOS.Location = new System.Drawing.Point(491, 112);
            this.cboxOS.Name = "cboxOS";
            this.cboxOS.Size = new System.Drawing.Size(280, 21);
            this.cboxOS.TabIndex = 10;
            this.cboxOS.Text = "Seleccione su sistema operativo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb64gb);
            this.groupBox2.Controls.Add(this.rb32gb);
            this.groupBox2.Controls.Add(this.rb16gb);
            this.groupBox2.Controls.Add(this.rb8gb);
            this.groupBox2.Controls.Add(this.rb4gb);
            this.groupBox2.Location = new System.Drawing.Point(277, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 173);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione la cantidad de RAM:";
            // 
            // rb4gb
            // 
            this.rb4gb.AutoSize = true;
            this.rb4gb.Checked = true;
            this.rb4gb.Location = new System.Drawing.Point(7, 26);
            this.rb4gb.Name = "rb4gb";
            this.rb4gb.Size = new System.Drawing.Size(49, 17);
            this.rb4gb.TabIndex = 0;
            this.rb4gb.TabStop = true;
            this.rb4gb.Text = "4 GB";
            this.rb4gb.UseVisualStyleBackColor = true;
            // 
            // rb8gb
            // 
            this.rb8gb.AutoSize = true;
            this.rb8gb.Location = new System.Drawing.Point(7, 51);
            this.rb8gb.Name = "rb8gb";
            this.rb8gb.Size = new System.Drawing.Size(49, 17);
            this.rb8gb.TabIndex = 1;
            this.rb8gb.Text = "8 GB";
            this.rb8gb.UseVisualStyleBackColor = true;
            // 
            // rb16gb
            // 
            this.rb16gb.AutoSize = true;
            this.rb16gb.Location = new System.Drawing.Point(7, 75);
            this.rb16gb.Name = "rb16gb";
            this.rb16gb.Size = new System.Drawing.Size(55, 17);
            this.rb16gb.TabIndex = 2;
            this.rb16gb.Text = "16 GB";
            this.rb16gb.UseVisualStyleBackColor = true;
            // 
            // rb32gb
            // 
            this.rb32gb.AutoSize = true;
            this.rb32gb.Location = new System.Drawing.Point(7, 99);
            this.rb32gb.Name = "rb32gb";
            this.rb32gb.Size = new System.Drawing.Size(55, 17);
            this.rb32gb.TabIndex = 3;
            this.rb32gb.Text = "32 GB";
            this.rb32gb.UseVisualStyleBackColor = true;
            // 
            // rb64gb
            // 
            this.rb64gb.AutoSize = true;
            this.rb64gb.Location = new System.Drawing.Point(7, 122);
            this.rb64gb.Name = "rb64gb";
            this.rb64gb.Size = new System.Drawing.Size(55, 17);
            this.rb64gb.TabIndex = 4;
            this.rb64gb.Text = "64 GB";
            this.rb64gb.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboxSeagate);
            this.groupBox3.Controls.Add(this.cboxToshiba);
            this.groupBox3.Controls.Add(this.cboxWD);
            this.groupBox3.Controls.Add(this.cboxADATA);
            this.groupBox3.Location = new System.Drawing.Point(491, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 122);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccione su(s) disco(s) duro(s):";
            // 
            // cboxADATA
            // 
            this.cboxADATA.AutoSize = true;
            this.cboxADATA.Location = new System.Drawing.Point(7, 23);
            this.cboxADATA.Name = "cboxADATA";
            this.cboxADATA.Size = new System.Drawing.Size(146, 17);
            this.cboxADATA.TabIndex = 0;
            this.cboxADATA.Text = "ADATA SSD SU800 1TB";
            this.cboxADATA.UseVisualStyleBackColor = true;
            // 
            // cboxWD
            // 
            this.cboxWD.AutoSize = true;
            this.cboxWD.Location = new System.Drawing.Point(7, 47);
            this.cboxWD.Name = "cboxWD";
            this.cboxWD.Size = new System.Drawing.Size(177, 17);
            this.cboxWD.TabIndex = 1;
            this.cboxWD.Text = "Western Digital SATA SSD 1TB";
            this.cboxWD.UseVisualStyleBackColor = true;
            // 
            // cboxToshiba
            // 
            this.cboxToshiba.AutoSize = true;
            this.cboxToshiba.Location = new System.Drawing.Point(7, 71);
            this.cboxToshiba.Name = "cboxToshiba";
            this.cboxToshiba.Size = new System.Drawing.Size(141, 17);
            this.cboxToshiba.TabIndex = 2;
            this.cboxToshiba.Text = "Toshiba HDD L200 1TB";
            this.cboxToshiba.UseVisualStyleBackColor = true;
            // 
            // cboxSeagate
            // 
            this.cboxSeagate.AutoSize = true;
            this.cboxSeagate.Location = new System.Drawing.Point(7, 95);
            this.cboxSeagate.Name = "cboxSeagate";
            this.cboxSeagate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboxSeagate.Size = new System.Drawing.Size(168, 17);
            this.cboxSeagate.TabIndex = 3;
            this.cboxSeagate.Text = "Seagate Barracuda HDD 4TB";
            this.cboxSeagate.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboxCase);
            this.groupBox4.Controls.Add(this.cboxAorus);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(28, 306);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(433, 132);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Componentes extra:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cboxOmegaS);
            this.groupBox5.Controls.Add(this.cboxGeForce);
            this.groupBox5.Controls.Add(this.cboxRadeon);
            this.groupBox5.Location = new System.Drawing.Point(11, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(209, 100);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tarjetas gráficas:";
            // 
            // cboxRadeon
            // 
            this.cboxRadeon.AutoSize = true;
            this.cboxRadeon.Location = new System.Drawing.Point(7, 20);
            this.cboxRadeon.Name = "cboxRadeon";
            this.cboxRadeon.Size = new System.Drawing.Size(136, 17);
            this.cboxRadeon.TabIndex = 0;
            this.cboxRadeon.Text = "AMD Radeon RX 5700";
            this.cboxRadeon.UseVisualStyleBackColor = true;
            // 
            // cboxGeForce
            // 
            this.cboxGeForce.AutoSize = true;
            this.cboxGeForce.Location = new System.Drawing.Point(7, 44);
            this.cboxGeForce.Name = "cboxGeForce";
            this.cboxGeForce.Size = new System.Drawing.Size(152, 17);
            this.cboxGeForce.TabIndex = 1;
            this.cboxGeForce.Text = "Nvidia GeForce RTX 2060";
            this.cboxGeForce.UseVisualStyleBackColor = true;
            // 
            // cboxOmegaS
            // 
            this.cboxOmegaS.AutoSize = true;
            this.cboxOmegaS.Location = new System.Drawing.Point(7, 68);
            this.cboxOmegaS.Name = "cboxOmegaS";
            this.cboxOmegaS.Size = new System.Drawing.Size(187, 17);
            this.cboxOmegaS.TabIndex = 2;
            this.cboxOmegaS.Text = "Cybertron\'s Omega Supreme 3000";
            this.cboxOmegaS.UseVisualStyleBackColor = true;
            // 
            // cboxAorus
            // 
            this.cboxAorus.AutoSize = true;
            this.cboxAorus.Location = new System.Drawing.Point(236, 39);
            this.cboxAorus.Name = "cboxAorus";
            this.cboxAorus.Size = new System.Drawing.Size(138, 17);
            this.cboxAorus.TabIndex = 1;
            this.cboxAorus.Text = "Aorus Liquid Cooler 360";
            this.cboxAorus.UseVisualStyleBackColor = true;
            // 
            // cboxCase
            // 
            this.cboxCase.AutoSize = true;
            this.cboxCase.Location = new System.Drawing.Point(236, 87);
            this.cboxCase.Name = "cboxCase";
            this.cboxCase.Size = new System.Drawing.Size(179, 17);
            this.cboxCase.TabIndex = 2;
            this.cboxCase.Text = "Cooler Master MasterCase H500";
            this.cboxCase.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cboxOS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtboxcp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxaddress);
            this.Controls.Add(this.txtboxtelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxclient);
            this.Name = "Form1";
            this.Text = "Practica Controles de Formulario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxclient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxtelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxaddress;
        private System.Windows.Forms.TextBox txtboxcp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCEUX;
        private System.Windows.Forms.RadioButton rbCEU;
        private System.Windows.Forms.RadioButton rbAMDR9;
        private System.Windows.Forms.RadioButton rbAMDR7;
        private System.Windows.Forms.RadioButton rbICi9;
        private System.Windows.Forms.RadioButton rbICi7;
        private System.Windows.Forms.ComboBox cboxOS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb64gb;
        private System.Windows.Forms.RadioButton rb32gb;
        private System.Windows.Forms.RadioButton rb16gb;
        private System.Windows.Forms.RadioButton rb8gb;
        private System.Windows.Forms.RadioButton rb4gb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cboxSeagate;
        private System.Windows.Forms.CheckBox cboxToshiba;
        private System.Windows.Forms.CheckBox cboxWD;
        private System.Windows.Forms.CheckBox cboxADATA;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cboxCase;
        private System.Windows.Forms.CheckBox cboxAorus;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cboxOmegaS;
        private System.Windows.Forms.CheckBox cboxGeForce;
        private System.Windows.Forms.CheckBox cboxRadeon;
    }
}


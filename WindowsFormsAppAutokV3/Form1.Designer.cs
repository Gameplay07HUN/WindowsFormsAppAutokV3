namespace WindowsFormsAppAutokV3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewAutok = new System.Windows.Forms.DataGridView();
            this.labelSzin = new System.Windows.Forms.Label();
            this.labelUzembehelyezve = new System.Windows.Forms.Label();
            this.textBoxMotor = new System.Windows.Forms.TextBox();
            this.labelMotor = new System.Windows.Forms.Label();
            this.labelNev = new System.Windows.Forms.Label();
            this.labelMarka = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.buttonModosit = new System.Windows.Forms.Button();
            this.buttonUj = new System.Windows.Forms.Button();
            this.numericUpDownUzembehelyezve = new System.Windows.Forms.NumericUpDown();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.groupBoxAuto = new System.Windows.Forms.GroupBox();
            this.textBoxSzin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUzembehelyezve)).BeginInit();
            this.groupBoxAuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAutok
            // 
            this.dataGridViewAutok.AllowUserToDeleteRows = false;
            this.dataGridViewAutok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAutok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewAutok.Location = new System.Drawing.Point(0, 103);
            this.dataGridViewAutok.Name = "dataGridViewAutok";
            this.dataGridViewAutok.ReadOnly = true;
            this.dataGridViewAutok.Size = new System.Drawing.Size(803, 347);
            this.dataGridViewAutok.TabIndex = 4;
            this.dataGridViewAutok.SelectionChanged += new System.EventHandler(this.dataGridViewAutok_SelectionChanged);
            // 
            // labelSzin
            // 
            this.labelSzin.AutoSize = true;
            this.labelSzin.Location = new System.Drawing.Point(710, 24);
            this.labelSzin.Name = "labelSzin";
            this.labelSzin.Size = new System.Drawing.Size(29, 13);
            this.labelSzin.TabIndex = 15;
            this.labelSzin.Text = "Szín";
            // 
            // labelUzembehelyezve
            // 
            this.labelUzembehelyezve.AutoSize = true;
            this.labelUzembehelyezve.Location = new System.Drawing.Point(549, 24);
            this.labelUzembehelyezve.Name = "labelUzembehelyezve";
            this.labelUzembehelyezve.Size = new System.Drawing.Size(88, 13);
            this.labelUzembehelyezve.TabIndex = 14;
            this.labelUzembehelyezve.Text = "Üzembehelyezve";
            // 
            // textBoxMotor
            // 
            this.textBoxMotor.Location = new System.Drawing.Point(405, 39);
            this.textBoxMotor.Name = "textBoxMotor";
            this.textBoxMotor.Size = new System.Drawing.Size(126, 20);
            this.textBoxMotor.TabIndex = 13;
            // 
            // labelMotor
            // 
            this.labelMotor.AutoSize = true;
            this.labelMotor.Location = new System.Drawing.Point(459, 23);
            this.labelMotor.Name = "labelMotor";
            this.labelMotor.Size = new System.Drawing.Size(34, 13);
            this.labelMotor.TabIndex = 12;
            this.labelMotor.Text = "Motor";
            // 
            // labelNev
            // 
            this.labelNev.AutoSize = true;
            this.labelNev.Location = new System.Drawing.Point(315, 23);
            this.labelNev.Name = "labelNev";
            this.labelNev.Size = new System.Drawing.Size(27, 13);
            this.labelNev.TabIndex = 11;
            this.labelNev.Text = "Név";
            // 
            // labelMarka
            // 
            this.labelMarka.AutoSize = true;
            this.labelMarka.Location = new System.Drawing.Point(155, 23);
            this.labelMarka.Name = "labelMarka";
            this.labelMarka.Size = new System.Drawing.Size(37, 13);
            this.labelMarka.TabIndex = 10;
            this.labelMarka.Text = "Márka";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(39, 23);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 9;
            this.labelId.Text = "Id";
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(254, 39);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(146, 20);
            this.textBoxNev.TabIndex = 7;
            // 
            // buttonTorles
            // 
            this.buttonTorles.Location = new System.Drawing.Point(433, 74);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(75, 23);
            this.buttonTorles.TabIndex = 6;
            this.buttonTorles.Text = "Törlés";
            this.buttonTorles.UseVisualStyleBackColor = true;
            this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click);
            // 
            // buttonModosit
            // 
            this.buttonModosit.Location = new System.Drawing.Point(267, 74);
            this.buttonModosit.Name = "buttonModosit";
            this.buttonModosit.Size = new System.Drawing.Size(75, 23);
            this.buttonModosit.TabIndex = 5;
            this.buttonModosit.Text = "Módosít";
            this.buttonModosit.UseVisualStyleBackColor = true;
            this.buttonModosit.Click += new System.EventHandler(this.buttonModosit_Click);
            // 
            // buttonUj
            // 
            this.buttonUj.Location = new System.Drawing.Point(80, 74);
            this.buttonUj.Name = "buttonUj";
            this.buttonUj.Size = new System.Drawing.Size(75, 23);
            this.buttonUj.TabIndex = 4;
            this.buttonUj.Text = "Új autó";
            this.buttonUj.UseVisualStyleBackColor = true;
            this.buttonUj.Click += new System.EventHandler(this.buttonUj_Click);
            // 
            // numericUpDownUzembehelyezve
            // 
            this.numericUpDownUzembehelyezve.Location = new System.Drawing.Point(537, 40);
            this.numericUpDownUzembehelyezve.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownUzembehelyezve.Name = "numericUpDownUzembehelyezve";
            this.numericUpDownUzembehelyezve.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownUzembehelyezve.TabIndex = 2;
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(105, 39);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(143, 20);
            this.textBoxMarka.TabIndex = 1;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(12, 39);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(87, 20);
            this.textBoxId.TabIndex = 0;
            // 
            // groupBoxAuto
            // 
            this.groupBoxAuto.Controls.Add(this.labelSzin);
            this.groupBoxAuto.Controls.Add(this.labelUzembehelyezve);
            this.groupBoxAuto.Controls.Add(this.textBoxMotor);
            this.groupBoxAuto.Controls.Add(this.labelMotor);
            this.groupBoxAuto.Controls.Add(this.labelNev);
            this.groupBoxAuto.Controls.Add(this.labelMarka);
            this.groupBoxAuto.Controls.Add(this.labelId);
            this.groupBoxAuto.Controls.Add(this.textBoxSzin);
            this.groupBoxAuto.Controls.Add(this.textBoxNev);
            this.groupBoxAuto.Controls.Add(this.buttonTorles);
            this.groupBoxAuto.Controls.Add(this.buttonModosit);
            this.groupBoxAuto.Controls.Add(this.buttonUj);
            this.groupBoxAuto.Controls.Add(this.numericUpDownUzembehelyezve);
            this.groupBoxAuto.Controls.Add(this.textBoxMarka);
            this.groupBoxAuto.Controls.Add(this.textBoxId);
            this.groupBoxAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAuto.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAuto.Name = "groupBoxAuto";
            this.groupBoxAuto.Size = new System.Drawing.Size(803, 450);
            this.groupBoxAuto.TabIndex = 5;
            this.groupBoxAuto.TabStop = false;
            this.groupBoxAuto.Text = "Kiválasztott auto adatai";
            // 
            // textBoxSzin
            // 
            this.textBoxSzin.Location = new System.Drawing.Point(665, 39);
            this.textBoxSzin.Name = "textBoxSzin";
            this.textBoxSzin.Size = new System.Drawing.Size(123, 20);
            this.textBoxSzin.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.dataGridViewAutok);
            this.Controls.Add(this.groupBoxAuto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUzembehelyezve)).EndInit();
            this.groupBoxAuto.ResumeLayout(false);
            this.groupBoxAuto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAutok;
        private System.Windows.Forms.Label labelSzin;
        private System.Windows.Forms.Label labelUzembehelyezve;
        private System.Windows.Forms.TextBox textBoxMotor;
        private System.Windows.Forms.Label labelMotor;
        private System.Windows.Forms.Label labelNev;
        private System.Windows.Forms.Label labelMarka;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.Button buttonTorles;
        private System.Windows.Forms.Button buttonModosit;
        private System.Windows.Forms.Button buttonUj;
        private System.Windows.Forms.NumericUpDown numericUpDownUzembehelyezve;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.GroupBox groupBoxAuto;
        private System.Windows.Forms.TextBox textBoxSzin;
    }
}


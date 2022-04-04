namespace WinLeesZaal
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
            this.lstReaders = new System.Windows.Forms.ListBox();
            this.lblPersoon = new System.Windows.Forms.Label();
            this.lblLeeftijd = new System.Windows.Forms.Label();
            this.lblHoofdDeksel = new System.Windows.Forms.Label();
            this.lblTijdSchrift = new System.Windows.Forms.Label();
            this.lblKleur = new System.Windows.Forms.Label();
            this.lblSelectReader = new System.Windows.Forms.Label();
            this.lblCounts = new System.Windows.Forms.Label();
            this.lblHoofdDeksel2 = new System.Windows.Forms.Label();
            this.lblKleurTijdschrift = new System.Windows.Forms.Label();
            this.cmbHoofdDeksel = new System.Windows.Forms.ComboBox();
            this.cmbkleurTijdSchrift = new System.Windows.Forms.ComboBox();
            this.lblAddReaders = new System.Windows.Forms.Label();
            this.lblLezerTovogen = new System.Windows.Forms.Label();
            this.lblBeide = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLezerToevoegen = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.lblHatCount = new System.Windows.Forms.Label();
            this.lblMagazineColorCount = new System.Windows.Forms.Label();
            this.lblBothCount = new System.Windows.Forms.Label();
            this.lblMagColor = new System.Windows.Forms.Label();
            this.lblHat = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstReaders
            // 
            this.lstReaders.FormattingEnabled = true;
            this.lstReaders.Location = new System.Drawing.Point(38, 52);
            this.lstReaders.Name = "lstReaders";
            this.lstReaders.Size = new System.Drawing.Size(117, 147);
            this.lstReaders.TabIndex = 0;
            this.lstReaders.SelectedIndexChanged += new System.EventHandler(this.lstReaders_SelectedIndexChanged);
            // 
            // lblPersoon
            // 
            this.lblPersoon.AutoSize = true;
            this.lblPersoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersoon.Location = new System.Drawing.Point(165, 52);
            this.lblPersoon.Name = "lblPersoon";
            this.lblPersoon.Size = new System.Drawing.Size(67, 16);
            this.lblPersoon.TabIndex = 2;
            this.lblPersoon.Text = "Persoon : ";
            // 
            // lblLeeftijd
            // 
            this.lblLeeftijd.AutoSize = true;
            this.lblLeeftijd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeeftijd.Location = new System.Drawing.Point(165, 85);
            this.lblLeeftijd.Name = "lblLeeftijd";
            this.lblLeeftijd.Size = new System.Drawing.Size(50, 16);
            this.lblLeeftijd.TabIndex = 3;
            this.lblLeeftijd.Text = "Leeftijd";
            // 
            // lblHoofdDeksel
            // 
            this.lblHoofdDeksel.AutoSize = true;
            this.lblHoofdDeksel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoofdDeksel.Location = new System.Drawing.Point(165, 117);
            this.lblHoofdDeksel.Name = "lblHoofdDeksel";
            this.lblHoofdDeksel.Size = new System.Drawing.Size(87, 16);
            this.lblHoofdDeksel.TabIndex = 4;
            this.lblHoofdDeksel.Text = "HoofdDeksel";
            // 
            // lblTijdSchrift
            // 
            this.lblTijdSchrift.AutoSize = true;
            this.lblTijdSchrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTijdSchrift.Location = new System.Drawing.Point(165, 151);
            this.lblTijdSchrift.Name = "lblTijdSchrift";
            this.lblTijdSchrift.Size = new System.Drawing.Size(66, 16);
            this.lblTijdSchrift.TabIndex = 5;
            this.lblTijdSchrift.Text = "TijdSchrift";
            // 
            // lblKleur
            // 
            this.lblKleur.AutoSize = true;
            this.lblKleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKleur.Location = new System.Drawing.Point(165, 183);
            this.lblKleur.Name = "lblKleur";
            this.lblKleur.Size = new System.Drawing.Size(37, 16);
            this.lblKleur.TabIndex = 6;
            this.lblKleur.Text = "Kleur";
            // 
            // lblSelectReader
            // 
            this.lblSelectReader.AutoSize = true;
            this.lblSelectReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectReader.Location = new System.Drawing.Point(35, 33);
            this.lblSelectReader.Name = "lblSelectReader";
            this.lblSelectReader.Size = new System.Drawing.Size(94, 16);
            this.lblSelectReader.TabIndex = 7;
            this.lblSelectReader.Text = "Select Reader";
            // 
            // lblCounts
            // 
            this.lblCounts.AutoSize = true;
            this.lblCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounts.Location = new System.Drawing.Point(41, 238);
            this.lblCounts.Name = "lblCounts";
            this.lblCounts.Size = new System.Drawing.Size(48, 16);
            this.lblCounts.TabIndex = 8;
            this.lblCounts.Text = "Counts";
            // 
            // lblHoofdDeksel2
            // 
            this.lblHoofdDeksel2.AutoSize = true;
            this.lblHoofdDeksel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoofdDeksel2.Location = new System.Drawing.Point(41, 266);
            this.lblHoofdDeksel2.Name = "lblHoofdDeksel2";
            this.lblHoofdDeksel2.Size = new System.Drawing.Size(87, 16);
            this.lblHoofdDeksel2.TabIndex = 9;
            this.lblHoofdDeksel2.Text = "HoofdDeksel";
            // 
            // lblKleurTijdschrift
            // 
            this.lblKleurTijdschrift.AutoSize = true;
            this.lblKleurTijdschrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKleurTijdschrift.Location = new System.Drawing.Point(41, 297);
            this.lblKleurTijdschrift.Name = "lblKleurTijdschrift";
            this.lblKleurTijdschrift.Size = new System.Drawing.Size(97, 16);
            this.lblKleurTijdschrift.TabIndex = 10;
            this.lblKleurTijdschrift.Text = "Kleur Tijdschrift";
            // 
            // cmbHoofdDeksel
            // 
            this.cmbHoofdDeksel.FormattingEnabled = true;
            this.cmbHoofdDeksel.Location = new System.Drawing.Point(207, 266);
            this.cmbHoofdDeksel.Name = "cmbHoofdDeksel";
            this.cmbHoofdDeksel.Size = new System.Drawing.Size(121, 21);
            this.cmbHoofdDeksel.TabIndex = 11;
            this.cmbHoofdDeksel.SelectedIndexChanged += new System.EventHandler(this.cmbHoofdDeksel_SelectedIndexChanged);
            // 
            // cmbkleurTijdSchrift
            // 
            this.cmbkleurTijdSchrift.FormattingEnabled = true;
            this.cmbkleurTijdSchrift.Location = new System.Drawing.Point(207, 297);
            this.cmbkleurTijdSchrift.Name = "cmbkleurTijdSchrift";
            this.cmbkleurTijdSchrift.Size = new System.Drawing.Size(121, 21);
            this.cmbkleurTijdSchrift.TabIndex = 12;
            this.cmbkleurTijdSchrift.SelectedIndexChanged += new System.EventHandler(this.cmbkleurTijdSchrift_SelectedIndexChanged);
            // 
            // lblAddReaders
            // 
            this.lblAddReaders.AutoSize = true;
            this.lblAddReaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddReaders.Location = new System.Drawing.Point(39, 373);
            this.lblAddReaders.Name = "lblAddReaders";
            this.lblAddReaders.Size = new System.Drawing.Size(96, 16);
            this.lblAddReaders.TabIndex = 13;
            this.lblAddReaders.Text = "Add Reader(s)";
            // 
            // lblLezerTovogen
            // 
            this.lblLezerTovogen.AutoSize = true;
            this.lblLezerTovogen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLezerTovogen.Location = new System.Drawing.Point(41, 402);
            this.lblLezerTovogen.Name = "lblLezerTovogen";
            this.lblLezerTovogen.Size = new System.Drawing.Size(114, 16);
            this.lblLezerTovogen.TabIndex = 14;
            this.lblLezerTovogen.Text = "Lezer Toevoegen";
            // 
            // lblBeide
            // 
            this.lblBeide.AutoSize = true;
            this.lblBeide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeide.Location = new System.Drawing.Point(204, 333);
            this.lblBeide.Name = "lblBeide";
            this.lblBeide.Size = new System.Drawing.Size(52, 16);
            this.lblBeide.TabIndex = 15;
            this.lblBeide.Text = "Beide : ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(383, 402);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLezerToevoegen
            // 
            this.txtLezerToevoegen.Location = new System.Drawing.Point(207, 402);
            this.txtLezerToevoegen.Name = "txtLezerToevoegen";
            this.txtLezerToevoegen.Size = new System.Drawing.Size(100, 20);
            this.txtLezerToevoegen.TabIndex = 17;
            // 
            // lblHatCount
            // 
            this.lblHatCount.AutoSize = true;
            this.lblHatCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHatCount.Location = new System.Drawing.Point(519, 273);
            this.lblHatCount.Name = "lblHatCount";
            this.lblHatCount.Size = new System.Drawing.Size(26, 15);
            this.lblHatCount.TabIndex = 18;
            this.lblHatCount.Text = "Hat";
            // 
            // lblMagazineColorCount
            // 
            this.lblMagazineColorCount.AutoSize = true;
            this.lblMagazineColorCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagazineColorCount.Location = new System.Drawing.Point(519, 305);
            this.lblMagazineColorCount.Name = "lblMagazineColorCount";
            this.lblMagazineColorCount.Size = new System.Drawing.Size(32, 15);
            this.lblMagazineColorCount.TabIndex = 19;
            this.lblMagazineColorCount.Text = "Mag";
            // 
            // lblBothCount
            // 
            this.lblBothCount.AutoSize = true;
            this.lblBothCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBothCount.Location = new System.Drawing.Point(518, 333);
            this.lblBothCount.Name = "lblBothCount";
            this.lblBothCount.Size = new System.Drawing.Size(32, 15);
            this.lblBothCount.TabIndex = 20;
            this.lblBothCount.Text = "Both";
            // 
            // lblMagColor
            // 
            this.lblMagColor.AutoSize = true;
            this.lblMagColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagColor.ForeColor = System.Drawing.Color.Green;
            this.lblMagColor.Location = new System.Drawing.Point(292, 185);
            this.lblMagColor.Name = "lblMagColor";
            this.lblMagColor.Size = new System.Drawing.Size(39, 16);
            this.lblMagColor.TabIndex = 21;
            this.lblMagColor.Text = "Color";
            // 
            // lblHat
            // 
            this.lblHat.AutoSize = true;
            this.lblHat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHat.ForeColor = System.Drawing.Color.Green;
            this.lblHat.Location = new System.Drawing.Point(292, 117);
            this.lblHat.Name = "lblHat";
            this.lblHat.Size = new System.Drawing.Size(28, 16);
            this.lblHat.TabIndex = 22;
            this.lblHat.Text = "Hat";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblAge.Location = new System.Drawing.Point(292, 85);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 16);
            this.lblAge.TabIndex = 23;
            this.lblAge.Text = "Age";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblHat);
            this.Controls.Add(this.lblMagColor);
            this.Controls.Add(this.lblBothCount);
            this.Controls.Add(this.lblMagazineColorCount);
            this.Controls.Add(this.lblHatCount);
            this.Controls.Add(this.txtLezerToevoegen);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblBeide);
            this.Controls.Add(this.lblLezerTovogen);
            this.Controls.Add(this.lblAddReaders);
            this.Controls.Add(this.cmbkleurTijdSchrift);
            this.Controls.Add(this.cmbHoofdDeksel);
            this.Controls.Add(this.lblKleurTijdschrift);
            this.Controls.Add(this.lblHoofdDeksel2);
            this.Controls.Add(this.lblCounts);
            this.Controls.Add(this.lblSelectReader);
            this.Controls.Add(this.lblKleur);
            this.Controls.Add(this.lblTijdSchrift);
            this.Controls.Add(this.lblHoofdDeksel);
            this.Controls.Add(this.lblLeeftijd);
            this.Controls.Add(this.lblPersoon);
            this.Controls.Add(this.lstReaders);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstReaders;
        private System.Windows.Forms.Label lblPersoon;
        private System.Windows.Forms.Label lblLeeftijd;
        private System.Windows.Forms.Label lblHoofdDeksel;
        private System.Windows.Forms.Label lblTijdSchrift;
        private System.Windows.Forms.Label lblKleur;
        private System.Windows.Forms.Label lblSelectReader;
        private System.Windows.Forms.Label lblCounts;
        private System.Windows.Forms.Label lblHoofdDeksel2;
        private System.Windows.Forms.Label lblKleurTijdschrift;
        private System.Windows.Forms.ComboBox cmbHoofdDeksel;
        private System.Windows.Forms.ComboBox cmbkleurTijdSchrift;
        private System.Windows.Forms.Label lblAddReaders;
        private System.Windows.Forms.Label lblLezerTovogen;
        private System.Windows.Forms.Label lblBeide;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtLezerToevoegen;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Label lblHatCount;
        private System.Windows.Forms.Label lblMagazineColorCount;
        private System.Windows.Forms.Label lblBothCount;
        private System.Windows.Forms.Label lblMagColor;
        private System.Windows.Forms.Label lblHat;
        private System.Windows.Forms.Label lblAge;
    }
}


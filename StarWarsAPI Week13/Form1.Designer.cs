namespace StarWarsAPI_Week13
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
            this.btnGetPlanet = new System.Windows.Forms.Button();
            this.txtPlanetId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRotationPeriod = new System.Windows.Forms.Label();
            this.lblOrbitalPeriod = new System.Windows.Forms.Label();
            this.lbldiameter = new System.Windows.Forms.Label();
            this.lblclimate = new System.Windows.Forms.Label();
            this.lblgravity = new System.Windows.Forms.Label();
            this.lblterrain = new System.Windows.Forms.Label();
            this.lblsurfacewater = new System.Windows.Forms.Label();
            this.lblpopulation = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbPersonID = new System.Windows.Forms.TextBox();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblMass = new System.Windows.Forms.Label();
            this.lblHairColor = new System.Windows.Forms.Label();
            this.lblSkinColor = new System.Windows.Forms.Label();
            this.lblEyeColor = new System.Windows.Forms.Label();
            this.lblBirthYear = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblHomeworld = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxSpecies = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetPlanet
            // 
            this.btnGetPlanet.Location = new System.Drawing.Point(6, 29);
            this.btnGetPlanet.Name = "btnGetPlanet";
            this.btnGetPlanet.Size = new System.Drawing.Size(144, 23);
            this.btnGetPlanet.TabIndex = 0;
            this.btnGetPlanet.Text = "Get Planet from ID:";
            this.btnGetPlanet.UseVisualStyleBackColor = true;
            this.btnGetPlanet.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPlanetId
            // 
            this.txtPlanetId.Location = new System.Drawing.Point(6, 68);
            this.txtPlanetId.Name = "txtPlanetId";
            this.txtPlanetId.Size = new System.Drawing.Size(144, 20);
            this.txtPlanetId.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 112);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "label1";
            // 
            // lblRotationPeriod
            // 
            this.lblRotationPeriod.AutoSize = true;
            this.lblRotationPeriod.Location = new System.Drawing.Point(6, 146);
            this.lblRotationPeriod.Name = "lblRotationPeriod";
            this.lblRotationPeriod.Size = new System.Drawing.Size(35, 13);
            this.lblRotationPeriod.TabIndex = 3;
            this.lblRotationPeriod.Text = "label2";
            // 
            // lblOrbitalPeriod
            // 
            this.lblOrbitalPeriod.AutoSize = true;
            this.lblOrbitalPeriod.Location = new System.Drawing.Point(6, 180);
            this.lblOrbitalPeriod.Name = "lblOrbitalPeriod";
            this.lblOrbitalPeriod.Size = new System.Drawing.Size(35, 13);
            this.lblOrbitalPeriod.TabIndex = 4;
            this.lblOrbitalPeriod.Text = "label3";
            // 
            // lbldiameter
            // 
            this.lbldiameter.AutoSize = true;
            this.lbldiameter.Location = new System.Drawing.Point(6, 213);
            this.lbldiameter.Name = "lbldiameter";
            this.lbldiameter.Size = new System.Drawing.Size(35, 13);
            this.lbldiameter.TabIndex = 5;
            this.lbldiameter.Text = "label4";
            // 
            // lblclimate
            // 
            this.lblclimate.AutoSize = true;
            this.lblclimate.Location = new System.Drawing.Point(6, 247);
            this.lblclimate.Name = "lblclimate";
            this.lblclimate.Size = new System.Drawing.Size(35, 13);
            this.lblclimate.TabIndex = 6;
            this.lblclimate.Text = "label5";
            // 
            // lblgravity
            // 
            this.lblgravity.AutoSize = true;
            this.lblgravity.Location = new System.Drawing.Point(6, 282);
            this.lblgravity.Name = "lblgravity";
            this.lblgravity.Size = new System.Drawing.Size(35, 13);
            this.lblgravity.TabIndex = 7;
            this.lblgravity.Text = "label6";
            // 
            // lblterrain
            // 
            this.lblterrain.AutoSize = true;
            this.lblterrain.Location = new System.Drawing.Point(6, 317);
            this.lblterrain.Name = "lblterrain";
            this.lblterrain.Size = new System.Drawing.Size(35, 13);
            this.lblterrain.TabIndex = 8;
            this.lblterrain.Text = "label7";
            // 
            // lblsurfacewater
            // 
            this.lblsurfacewater.AutoSize = true;
            this.lblsurfacewater.Location = new System.Drawing.Point(6, 350);
            this.lblsurfacewater.Name = "lblsurfacewater";
            this.lblsurfacewater.Size = new System.Drawing.Size(35, 13);
            this.lblsurfacewater.TabIndex = 9;
            this.lblsurfacewater.Text = "label8";
            // 
            // lblpopulation
            // 
            this.lblpopulation.AutoSize = true;
            this.lblpopulation.Location = new System.Drawing.Point(6, 384);
            this.lblpopulation.Name = "lblpopulation";
            this.lblpopulation.Size = new System.Drawing.Size(35, 13);
            this.lblpopulation.TabIndex = 10;
            this.lblpopulation.Text = "label9";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblpopulation);
            this.groupBox1.Controls.Add(this.lblsurfacewater);
            this.groupBox1.Controls.Add(this.lblterrain);
            this.groupBox1.Controls.Add(this.lblgravity);
            this.groupBox1.Controls.Add(this.lblclimate);
            this.groupBox1.Controls.Add(this.lbldiameter);
            this.groupBox1.Controls.Add(this.lblOrbitalPeriod);
            this.groupBox1.Controls.Add(this.lblRotationPeriod);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtPlanetId);
            this.groupBox1.Controls.Add(this.btnGetPlanet);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 426);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planet Information:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblHomeworld);
            this.groupBox2.Controls.Add(this.lblGender);
            this.groupBox2.Controls.Add(this.lblBirthYear);
            this.groupBox2.Controls.Add(this.lblEyeColor);
            this.groupBox2.Controls.Add(this.lblSkinColor);
            this.groupBox2.Controls.Add(this.lblHairColor);
            this.groupBox2.Controls.Add(this.lblMass);
            this.groupBox2.Controls.Add(this.lblHeight);
            this.groupBox2.Controls.Add(this.lblPersonName);
            this.groupBox2.Controls.Add(this.txbPersonID);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(184, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 426);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Person Information:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Person from ID:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txbPersonID
            // 
            this.txbPersonID.Location = new System.Drawing.Point(6, 68);
            this.txbPersonID.Name = "txbPersonID";
            this.txbPersonID.Size = new System.Drawing.Size(245, 20);
            this.txbPersonID.TabIndex = 1;
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Location = new System.Drawing.Point(6, 112);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(35, 13);
            this.lblPersonName.TabIndex = 2;
            this.lblPersonName.Text = "label1";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(6, 146);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(35, 13);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "label2";
            // 
            // lblMass
            // 
            this.lblMass.AutoSize = true;
            this.lblMass.Location = new System.Drawing.Point(6, 180);
            this.lblMass.Name = "lblMass";
            this.lblMass.Size = new System.Drawing.Size(35, 13);
            this.lblMass.TabIndex = 4;
            this.lblMass.Text = "label3";
            // 
            // lblHairColor
            // 
            this.lblHairColor.AutoSize = true;
            this.lblHairColor.Location = new System.Drawing.Point(6, 213);
            this.lblHairColor.Name = "lblHairColor";
            this.lblHairColor.Size = new System.Drawing.Size(35, 13);
            this.lblHairColor.TabIndex = 5;
            this.lblHairColor.Text = "label4";
            // 
            // lblSkinColor
            // 
            this.lblSkinColor.AutoSize = true;
            this.lblSkinColor.Location = new System.Drawing.Point(6, 247);
            this.lblSkinColor.Name = "lblSkinColor";
            this.lblSkinColor.Size = new System.Drawing.Size(35, 13);
            this.lblSkinColor.TabIndex = 6;
            this.lblSkinColor.Text = "label5";
            // 
            // lblEyeColor
            // 
            this.lblEyeColor.AutoSize = true;
            this.lblEyeColor.Location = new System.Drawing.Point(6, 282);
            this.lblEyeColor.Name = "lblEyeColor";
            this.lblEyeColor.Size = new System.Drawing.Size(35, 13);
            this.lblEyeColor.TabIndex = 7;
            this.lblEyeColor.Text = "label6";
            // 
            // lblBirthYear
            // 
            this.lblBirthYear.AutoSize = true;
            this.lblBirthYear.Location = new System.Drawing.Point(6, 317);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(35, 13);
            this.lblBirthYear.TabIndex = 8;
            this.lblBirthYear.Text = "label7";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(6, 350);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(35, 13);
            this.lblGender.TabIndex = 9;
            this.lblGender.Text = "label8";
            // 
            // lblHomeworld
            // 
            this.lblHomeworld.AutoSize = true;
            this.lblHomeworld.Location = new System.Drawing.Point(6, 384);
            this.lblHomeworld.Name = "lblHomeworld";
            this.lblHomeworld.Size = new System.Drawing.Size(35, 13);
            this.lblHomeworld.TabIndex = 10;
            this.lblHomeworld.Text = "label9";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.listBoxSpecies);
            this.groupBox3.Location = new System.Drawing.Point(450, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 426);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "All Species Info:";
            // 
            // listBoxSpecies
            // 
            this.listBoxSpecies.FormattingEnabled = true;
            this.listBoxSpecies.Location = new System.Drawing.Point(9, 68);
            this.listBoxSpecies.Name = "listBoxSpecies";
            this.listBoxSpecies.Size = new System.Drawing.Size(323, 342);
            this.listBoxSpecies.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "Display All Species:";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetPlanet;
        private System.Windows.Forms.TextBox txtPlanetId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRotationPeriod;
        private System.Windows.Forms.Label lblOrbitalPeriod;
        private System.Windows.Forms.Label lbldiameter;
        private System.Windows.Forms.Label lblclimate;
        private System.Windows.Forms.Label lblgravity;
        private System.Windows.Forms.Label lblterrain;
        private System.Windows.Forms.Label lblsurfacewater;
        private System.Windows.Forms.Label lblpopulation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbPersonID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHomeworld;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBirthYear;
        private System.Windows.Forms.Label lblEyeColor;
        private System.Windows.Forms.Label lblSkinColor;
        private System.Windows.Forms.Label lblHairColor;
        private System.Windows.Forms.Label lblMass;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxSpecies;
    }
}



namespace ProjectPRN_ManagerSoccer
{
    partial class FrmUpdatePlayer
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
            this.tbAddURL = new System.Windows.Forms.TextBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.picbImage = new System.Windows.Forms.PictureBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numDefeding = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.numAttacking = new System.Windows.Forms.NumericUpDown();
            this.numPhysical = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefeding)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttacking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhysical)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAddURL
            // 
            this.tbAddURL.Location = new System.Drawing.Point(839, 233);
            this.tbAddURL.Name = "tbAddURL";
            this.tbAddURL.ReadOnly = true;
            this.tbAddURL.Size = new System.Drawing.Size(168, 22);
            this.tbAddURL.TabIndex = 37;
            this.tbAddURL.Visible = false;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.White;
            this.btnChooseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImage.Location = new System.Drawing.Point(839, 187);
            this.btnChooseImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(127, 39);
            this.btnChooseImage.TabIndex = 36;
            this.btnChooseImage.Text = "Choose image";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // picbImage
            // 
            this.picbImage.BackColor = System.Drawing.Color.White;
            this.picbImage.Location = new System.Drawing.Point(601, 52);
            this.picbImage.Margin = new System.Windows.Forms.Padding(4);
            this.picbImage.Name = "picbImage";
            this.picbImage.Size = new System.Drawing.Size(230, 203);
            this.picbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbImage.TabIndex = 35;
            this.picbImage.TabStop = false;
            // 
            // cbPosition
            // 
            this.cbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "gk",
            "df",
            "mf",
            "fw"});
            this.cbPosition.Location = new System.Drawing.Point(222, 363);
            this.cbPosition.Margin = new System.Windows.Forms.Padding(4);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(160, 28);
            this.cbPosition.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(71, 370);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "Position :";
            // 
            // dtDateOfBirth
            // 
            this.dtDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateOfBirth.Location = new System.Drawing.Point(222, 209);
            this.dtDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtDateOfBirth.Name = "dtDateOfBirth";
            this.dtDateOfBirth.Size = new System.Drawing.Size(280, 27);
            this.dtDateOfBirth.TabIndex = 32;
            // 
            // cbCountry
            // 
            this.cbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Austrian Empire",
            "Azerbaijan",
            "Baden*",
            "Bahamas, The",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Bavaria*",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin (Dahomey)",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Brunswick and Lüneburg",
            "Bulgaria",
            "Burkina Faso (Upper Volta)",
            "Burma",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cayman Islands, The",
            "Central African Republic",
            "Central American Federation*",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo Free State, The",
            "Costa Rica",
            "Cote d’Ivoire (Ivory Coast)",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czechia",
            "Czechoslovakia",
            "Democratic Republic of the Congo",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Duchy of Parma, The*",
            "East Germany (German Democratic Republic)*",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "Federal Government of Germany (1848-49)*",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia, The",
            "Georgia",
            "Germany",
            "Ghana",
            "Grand Duchy of Tuscany, The*",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Hanover*",
            "Hanseatic Republics*",
            "Hawaii*",
            "Hesse*",
            "Holy See",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kingdom of Serbia/Yugoslavia*",
            "Kiribati",
            "Korea",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Lew Chew (Loochoo)*",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mecklenburg-Schwerin*",
            "Mecklenburg-Strelitz*",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Namibia",
            "Nassau*",
            "Nauru",
            "Nepal",
            "Netherlands, The",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North German Confederation*",
            "North German Union*",
            "North Macedonia",
            "Norway",
            "Oldenburg*",
            "Oman",
            "Orange Free State*",
            "Pakistan",
            "Palau",
            "Panama",
            "Papal States*",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Piedmont-Sardinia*",
            "Poland",
            "Portugal",
            "Qatar",
            "Republic of Genoa*",
            "Republic of Korea (South Korea)",
            "Republic of the Congo",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Schaumburg-Lippe*",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands, The",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "Tajikistan",
            "Tanzania",
            "Texas*",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Two Sicilies*",
            "Uganda",
            "Ukraine",
            "Union of Soviet Socialist Republics*",
            "United Arab Emirates, The",
            "United Kingdom, The",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Württemberg*",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.cbCountry.Location = new System.Drawing.Point(222, 302);
            this.cbCountry.Margin = new System.Windows.Forms.Padding(4);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(160, 28);
            this.cbCountry.TabIndex = 31;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(222, 157);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 27);
            this.txtName.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 309);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Country :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Date Of Birth :";
            // 
            // numDefeding
            // 
            this.numDefeding.Location = new System.Drawing.Point(383, 124);
            this.numDefeding.Margin = new System.Windows.Forms.Padding(4);
            this.numDefeding.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDefeding.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDefeding.Name = "numDefeding";
            this.numDefeding.Size = new System.Drawing.Size(75, 22);
            this.numDefeding.TabIndex = 10;
            this.numDefeding.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.numDefeding);
            this.groupBox1.Controls.Add(this.numSpeed);
            this.groupBox1.Controls.Add(this.numAttacking);
            this.groupBox1.Controls.Add(this.numPhysical);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(508, 280);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(488, 215);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attributes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 170);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Maximum Value is 10";
            // 
            // numSpeed
            // 
            this.numSpeed.Location = new System.Drawing.Point(383, 50);
            this.numSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.numSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Size = new System.Drawing.Size(75, 22);
            this.numSpeed.TabIndex = 9;
            this.numSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numAttacking
            // 
            this.numAttacking.Location = new System.Drawing.Point(145, 118);
            this.numAttacking.Margin = new System.Windows.Forms.Padding(4);
            this.numAttacking.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAttacking.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAttacking.Name = "numAttacking";
            this.numAttacking.Size = new System.Drawing.Size(75, 22);
            this.numAttacking.TabIndex = 8;
            this.numAttacking.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPhysical
            // 
            this.numPhysical.Location = new System.Drawing.Point(145, 53);
            this.numPhysical.Margin = new System.Windows.Forms.Padding(4);
            this.numPhysical.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPhysical.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPhysical.Name = "numPhysical";
            this.numPhysical.Size = new System.Drawing.Size(75, 22);
            this.numPhysical.TabIndex = 6;
            this.numPhysical.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(285, 127);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Defending :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(285, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Speed :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 121);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Attacking :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Physical :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Player Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 39);
            this.label1.TabIndex = 25;
            this.label1.Text = "Update Player";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(49, 43);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 39);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(278, 450);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 45);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmUpdatePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbAddURL);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.picbImage);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtDateOfBirth);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUpdatePlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUpdatePlayer";
            this.Load += new System.EventHandler(this.FrmUpdatePlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefeding)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttacking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhysical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAddURL;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.PictureBox picbImage;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtDateOfBirth;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDefeding;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.NumericUpDown numAttacking;
        private System.Windows.Forms.NumericUpDown numPhysical;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
    }
}
namespace Pizza_Project
{
    partial class Page1
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
            this.Mainlabel = new System.Windows.Forms.Label();
            this.GBsize = new System.Windows.Forms.GroupBox();
            this.RBlarge = new System.Windows.Forms.RadioButton();
            this.RBmedium = new System.Windows.Forms.RadioButton();
            this.RBsmall = new System.Windows.Forms.RadioButton();
            this.GBCrust = new System.Windows.Forms.GroupBox();
            this.Rbthincrust = new System.Windows.Forms.RadioButton();
            this.RBthikcrust = new System.Windows.Forms.RadioButton();
            this.RBstuffed = new System.Windows.Forms.RadioButton();
            this.GBtoppins = new System.Windows.Forms.GroupBox();
            this.chkBoxoliv = new System.Windows.Forms.CheckBox();
            this.chkBoxonin = new System.Windows.Forms.CheckBox();
            this.chkBoxMush = new System.Windows.Forms.CheckBox();
            this.chkBoxPeps = new System.Windows.Forms.CheckBox();
            this.chkBoxtomato = new System.Windows.Forms.CheckBox();
            this.chkBoxcheese = new System.Windows.Forms.CheckBox();
            this.GBwheretoeat = new System.Windows.Forms.GroupBox();
            this.RBtakeaway = new System.Windows.Forms.RadioButton();
            this.RBEatin = new System.Windows.Forms.RadioButton();
            this.GBordersum = new System.Windows.Forms.GroupBox();
            this.WhereToEatValue = new System.Windows.Forms.Label();
            this.WhereToEatLable = new System.Windows.Forms.Label();
            this.CrustTypeValue = new System.Windows.Forms.Label();
            this.CrusttypeLable = new System.Windows.Forms.Label();
            this.ToppingsLable = new System.Windows.Forms.Label();
            this.SizeValueLable = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.ToppingsValuelabel = new System.Windows.Forms.Label();
            this.GBtotalPrice = new System.Windows.Forms.GroupBox();
            this.TotalpriceValue = new System.Windows.Forms.Label();
            this.Orderbtn = new System.Windows.Forms.Button();
            this.Restbtn = new System.Windows.Forms.Button();
            this.GBsize.SuspendLayout();
            this.GBCrust.SuspendLayout();
            this.GBtoppins.SuspendLayout();
            this.GBwheretoeat.SuspendLayout();
            this.GBordersum.SuspendLayout();
            this.GBtotalPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mainlabel
            // 
            this.Mainlabel.AutoSize = true;
            this.Mainlabel.Font = new System.Drawing.Font("Ravie", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainlabel.ForeColor = System.Drawing.Color.DarkRed;
            this.Mainlabel.Location = new System.Drawing.Point(152, 35);
            this.Mainlabel.Name = "Mainlabel";
            this.Mainlabel.Size = new System.Drawing.Size(647, 63);
            this.Mainlabel.TabIndex = 0;
            this.Mainlabel.Text = "MAKE YOUR PIZZA";
            // 
            // GBsize
            // 
            this.GBsize.Controls.Add(this.RBlarge);
            this.GBsize.Controls.Add(this.RBmedium);
            this.GBsize.Controls.Add(this.RBsmall);
            this.GBsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBsize.Location = new System.Drawing.Point(40, 128);
            this.GBsize.Name = "GBsize";
            this.GBsize.Size = new System.Drawing.Size(158, 183);
            this.GBsize.TabIndex = 1;
            this.GBsize.TabStop = false;
            this.GBsize.Text = "Size";
            // 
            // RBlarge
            // 
            this.RBlarge.AutoSize = true;
            this.RBlarge.Location = new System.Drawing.Point(11, 136);
            this.RBlarge.Name = "RBlarge";
            this.RBlarge.Size = new System.Drawing.Size(87, 29);
            this.RBlarge.TabIndex = 2;
            this.RBlarge.TabStop = true;
            this.RBlarge.Tag = "40";
            this.RBlarge.Text = "Large";
            this.RBlarge.UseVisualStyleBackColor = true;
            this.RBlarge.CheckedChanged += new System.EventHandler(this.RBlarge_CheckedChanged);
            // 
            // RBmedium
            // 
            this.RBmedium.AutoSize = true;
            this.RBmedium.Location = new System.Drawing.Point(11, 91);
            this.RBmedium.Name = "RBmedium";
            this.RBmedium.Size = new System.Drawing.Size(107, 29);
            this.RBmedium.TabIndex = 0;
            this.RBmedium.TabStop = true;
            this.RBmedium.Tag = "30";
            this.RBmedium.Text = "Meduim";
            this.RBmedium.UseVisualStyleBackColor = true;
            this.RBmedium.CheckedChanged += new System.EventHandler(this.RBmedium_CheckedChanged);
            // 
            // RBsmall
            // 
            this.RBsmall.AutoSize = true;
            this.RBsmall.Location = new System.Drawing.Point(11, 45);
            this.RBsmall.Name = "RBsmall";
            this.RBsmall.Size = new System.Drawing.Size(86, 29);
            this.RBsmall.TabIndex = 1;
            this.RBsmall.TabStop = true;
            this.RBsmall.Tag = "20";
            this.RBsmall.Text = "Small";
            this.RBsmall.UseVisualStyleBackColor = true;
            this.RBsmall.CheckedChanged += new System.EventHandler(this.RBsmall_CheckedChanged);
            // 
            // GBCrust
            // 
            this.GBCrust.Controls.Add(this.Rbthincrust);
            this.GBCrust.Controls.Add(this.RBthikcrust);
            this.GBCrust.Controls.Add(this.RBstuffed);
            this.GBCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBCrust.Location = new System.Drawing.Point(40, 357);
            this.GBCrust.Name = "GBCrust";
            this.GBCrust.Size = new System.Drawing.Size(189, 192);
            this.GBCrust.TabIndex = 2;
            this.GBCrust.TabStop = false;
            this.GBCrust.Text = "CrustType";
            // 
            // Rbthincrust
            // 
            this.Rbthincrust.AutoSize = true;
            this.Rbthincrust.Location = new System.Drawing.Point(5, 137);
            this.Rbthincrust.Name = "Rbthincrust";
            this.Rbthincrust.Size = new System.Drawing.Size(128, 29);
            this.Rbthincrust.TabIndex = 2;
            this.Rbthincrust.TabStop = true;
            this.Rbthincrust.Tag = "0";
            this.Rbthincrust.Text = "Thin Crust";
            this.Rbthincrust.UseVisualStyleBackColor = true;
            this.Rbthincrust.CheckedChanged += new System.EventHandler(this.Rbthincrust_CheckedChanged);
            // 
            // RBthikcrust
            // 
            this.RBthikcrust.AutoSize = true;
            this.RBthikcrust.Location = new System.Drawing.Point(5, 85);
            this.RBthikcrust.Name = "RBthikcrust";
            this.RBthikcrust.Size = new System.Drawing.Size(127, 29);
            this.RBthikcrust.TabIndex = 0;
            this.RBthikcrust.TabStop = true;
            this.RBthikcrust.Tag = "10";
            this.RBthikcrust.Text = "Thik Crust";
            this.RBthikcrust.UseVisualStyleBackColor = true;
            this.RBthikcrust.CheckedChanged += new System.EventHandler(this.RBthikcrust_CheckedChanged);
            // 
            // RBstuffed
            // 
            this.RBstuffed.AutoSize = true;
            this.RBstuffed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBstuffed.Location = new System.Drawing.Point(5, 41);
            this.RBstuffed.Name = "RBstuffed";
            this.RBstuffed.Size = new System.Drawing.Size(151, 29);
            this.RBstuffed.TabIndex = 1;
            this.RBstuffed.TabStop = true;
            this.RBstuffed.Tag = 15;
            this.RBstuffed.Text = "Stuffed Crust";
            this.RBstuffed.UseVisualStyleBackColor = true;
            this.RBstuffed.CheckedChanged += new System.EventHandler(this.RBstuffed_CheckedChanged);
            // 
            // GBtoppins
            // 
            this.GBtoppins.Controls.Add(this.chkBoxoliv);
            this.GBtoppins.Controls.Add(this.chkBoxonin);
            this.GBtoppins.Controls.Add(this.chkBoxMush);
            this.GBtoppins.Controls.Add(this.chkBoxPeps);
            this.GBtoppins.Controls.Add(this.chkBoxtomato);
            this.GBtoppins.Controls.Add(this.chkBoxcheese);
            this.GBtoppins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtoppins.Location = new System.Drawing.Point(306, 128);
            this.GBtoppins.Name = "GBtoppins";
            this.GBtoppins.Size = new System.Drawing.Size(305, 165);
            this.GBtoppins.TabIndex = 3;
            this.GBtoppins.TabStop = false;
            this.GBtoppins.Text = "Toppings";
            // 
            // chkBoxoliv
            // 
            this.chkBoxoliv.AutoSize = true;
            this.chkBoxoliv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxoliv.Location = new System.Drawing.Point(148, 114);
            this.chkBoxoliv.Name = "chkBoxoliv";
            this.chkBoxoliv.Size = new System.Drawing.Size(86, 26);
            this.chkBoxoliv.TabIndex = 5;
            this.chkBoxoliv.Tag = 5;
            this.chkBoxoliv.Text = "Olives";
            this.chkBoxoliv.UseVisualStyleBackColor = true;
            this.chkBoxoliv.CheckedChanged += new System.EventHandler(this.chkBoxoliv_CheckedChanged);
            // 
            // chkBoxonin
            // 
            this.chkBoxonin.AutoSize = true;
            this.chkBoxonin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxonin.Location = new System.Drawing.Point(148, 71);
            this.chkBoxonin.Name = "chkBoxonin";
            this.chkBoxonin.Size = new System.Drawing.Size(93, 26);
            this.chkBoxonin.TabIndex = 4;
            this.chkBoxonin.Tag = 5;
            this.chkBoxonin.Text = "Onions";
            this.chkBoxonin.UseVisualStyleBackColor = true;
            this.chkBoxonin.CheckedChanged += new System.EventHandler(this.chkBoxonin_CheckedChanged);
            // 
            // chkBoxMush
            // 
            this.chkBoxMush.AutoSize = true;
            this.chkBoxMush.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxMush.Location = new System.Drawing.Point(148, 29);
            this.chkBoxMush.Name = "chkBoxMush";
            this.chkBoxMush.Size = new System.Drawing.Size(128, 26);
            this.chkBoxMush.TabIndex = 3;
            this.chkBoxMush.Tag = 5;
            this.chkBoxMush.Text = "Mushrooms";
            this.chkBoxMush.UseVisualStyleBackColor = true;
            this.chkBoxMush.CheckedChanged += new System.EventHandler(this.chkBoxMush_CheckedChanged);
            // 
            // chkBoxPeps
            // 
            this.chkBoxPeps.AutoSize = true;
            this.chkBoxPeps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxPeps.Location = new System.Drawing.Point(7, 114);
            this.chkBoxPeps.Name = "chkBoxPeps";
            this.chkBoxPeps.Size = new System.Drawing.Size(103, 26);
            this.chkBoxPeps.TabIndex = 2;
            this.chkBoxPeps.Tag = 5;
            this.chkBoxPeps.Text = "Peppers";
            this.chkBoxPeps.UseVisualStyleBackColor = true;
            this.chkBoxPeps.CheckedChanged += new System.EventHandler(this.chkBoxPeps_CheckedChanged);
            // 
            // chkBoxtomato
            // 
            this.chkBoxtomato.AutoSize = true;
            this.chkBoxtomato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxtomato.Location = new System.Drawing.Point(7, 71);
            this.chkBoxtomato.Name = "chkBoxtomato";
            this.chkBoxtomato.Size = new System.Drawing.Size(116, 26);
            this.chkBoxtomato.TabIndex = 1;
            this.chkBoxtomato.Tag = "5";
            this.chkBoxtomato.Text = "Tomatoes";
            this.chkBoxtomato.UseVisualStyleBackColor = true;
            this.chkBoxtomato.CheckedChanged += new System.EventHandler(this.chkBoxtomato_CheckedChanged);
            // 
            // chkBoxcheese
            // 
            this.chkBoxcheese.AutoSize = true;
            this.chkBoxcheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxcheese.Location = new System.Drawing.Point(7, 29);
            this.chkBoxcheese.Name = "chkBoxcheese";
            this.chkBoxcheese.Size = new System.Drawing.Size(145, 26);
            this.chkBoxcheese.TabIndex = 0;
            this.chkBoxcheese.Tag = "5";
            this.chkBoxcheese.Text = "Extra Cheese";
            this.chkBoxcheese.UseVisualStyleBackColor = true;
            this.chkBoxcheese.CheckedChanged += new System.EventHandler(this.chkBoxcheese_CheckedChanged);
            // 
            // GBwheretoeat
            // 
            this.GBwheretoeat.Controls.Add(this.RBtakeaway);
            this.GBwheretoeat.Controls.Add(this.RBEatin);
            this.GBwheretoeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBwheretoeat.Location = new System.Drawing.Point(290, 398);
            this.GBwheretoeat.Name = "GBwheretoeat";
            this.GBwheretoeat.Size = new System.Drawing.Size(292, 100);
            this.GBwheretoeat.TabIndex = 4;
            this.GBwheretoeat.TabStop = false;
            this.GBwheretoeat.Text = "Where To Eat";
            // 
            // RBtakeaway
            // 
            this.RBtakeaway.AutoSize = true;
            this.RBtakeaway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtakeaway.Location = new System.Drawing.Point(148, 44);
            this.RBtakeaway.Name = "RBtakeaway";
            this.RBtakeaway.Size = new System.Drawing.Size(123, 26);
            this.RBtakeaway.TabIndex = 1;
            this.RBtakeaway.TabStop = true;
            this.RBtakeaway.Text = "Take away";
            this.RBtakeaway.UseVisualStyleBackColor = true;
            this.RBtakeaway.CheckedChanged += new System.EventHandler(this.RBtakeaway_CheckedChanged);
            // 
            // RBEatin
            // 
            this.RBEatin.AutoSize = true;
            this.RBEatin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBEatin.Location = new System.Drawing.Point(29, 44);
            this.RBEatin.Name = "RBEatin";
            this.RBEatin.Size = new System.Drawing.Size(81, 26);
            this.RBEatin.TabIndex = 0;
            this.RBEatin.TabStop = true;
            this.RBEatin.Text = "Eat In";
            this.RBEatin.UseVisualStyleBackColor = true;
            this.RBEatin.CheckedChanged += new System.EventHandler(this.RBEatin_CheckedChanged);
            // 
            // GBordersum
            // 
            this.GBordersum.Controls.Add(this.WhereToEatValue);
            this.GBordersum.Controls.Add(this.WhereToEatLable);
            this.GBordersum.Controls.Add(this.CrustTypeValue);
            this.GBordersum.Controls.Add(this.CrusttypeLable);
            this.GBordersum.Controls.Add(this.ToppingsLable);
            this.GBordersum.Controls.Add(this.SizeValueLable);
            this.GBordersum.Controls.Add(this.SizeLabel);
            this.GBordersum.Controls.Add(this.ToppingsValuelabel);
            this.GBordersum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBordersum.Location = new System.Drawing.Point(653, 128);
            this.GBordersum.Name = "GBordersum";
            this.GBordersum.Size = new System.Drawing.Size(261, 330);
            this.GBordersum.TabIndex = 5;
            this.GBordersum.TabStop = false;
            this.GBordersum.Text = "Order summary";
            // 
            // WhereToEatValue
            // 
            this.WhereToEatValue.AutoSize = true;
            this.WhereToEatValue.Location = new System.Drawing.Point(57, 291);
            this.WhereToEatValue.Name = "WhereToEatValue";
            this.WhereToEatValue.Size = new System.Drawing.Size(0, 25);
            this.WhereToEatValue.TabIndex = 7;
            // 
            // WhereToEatLable
            // 
            this.WhereToEatLable.AutoSize = true;
            this.WhereToEatLable.Location = new System.Drawing.Point(26, 257);
            this.WhereToEatLable.Name = "WhereToEatLable";
            this.WhereToEatLable.Size = new System.Drawing.Size(130, 25);
            this.WhereToEatLable.TabIndex = 6;
            this.WhereToEatLable.Text = "WhereToEat:";
            // 
            // CrustTypeValue
            // 
            this.CrustTypeValue.AutoSize = true;
            this.CrustTypeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrustTypeValue.Location = new System.Drawing.Point(148, 216);
            this.CrustTypeValue.Name = "CrustTypeValue";
            this.CrustTypeValue.Size = new System.Drawing.Size(0, 20);
            this.CrustTypeValue.TabIndex = 5;
            // 
            // CrusttypeLable
            // 
            this.CrusttypeLable.AutoSize = true;
            this.CrusttypeLable.Location = new System.Drawing.Point(26, 216);
            this.CrusttypeLable.Name = "CrusttypeLable";
            this.CrusttypeLable.Size = new System.Drawing.Size(115, 25);
            this.CrusttypeLable.TabIndex = 4;
            this.CrusttypeLable.Text = "Crust Type:";
            // 
            // ToppingsLable
            // 
            this.ToppingsLable.AutoSize = true;
            this.ToppingsLable.Location = new System.Drawing.Point(21, 78);
            this.ToppingsLable.Name = "ToppingsLable";
            this.ToppingsLable.Size = new System.Drawing.Size(100, 25);
            this.ToppingsLable.TabIndex = 2;
            this.ToppingsLable.Text = "Toppings:";
            // 
            // SizeValueLable
            // 
            this.SizeValueLable.AutoSize = true;
            this.SizeValueLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeValueLable.Location = new System.Drawing.Point(74, 42);
            this.SizeValueLable.Name = "SizeValueLable";
            this.SizeValueLable.Size = new System.Drawing.Size(0, 20);
            this.SizeValueLable.TabIndex = 1;
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(21, 38);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(57, 25);
            this.SizeLabel.TabIndex = 0;
            this.SizeLabel.Text = "Size:";
            // 
            // ToppingsValuelabel
            // 
            this.ToppingsValuelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToppingsValuelabel.Location = new System.Drawing.Point(45, 114);
            this.ToppingsValuelabel.Name = "ToppingsValuelabel";
            this.ToppingsValuelabel.Size = new System.Drawing.Size(210, 69);
            this.ToppingsValuelabel.TabIndex = 3;
            this.ToppingsValuelabel.Text = "No Toppings";
            // 
            // GBtotalPrice
            // 
            this.GBtotalPrice.Controls.Add(this.TotalpriceValue);
            this.GBtotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtotalPrice.Location = new System.Drawing.Point(653, 494);
            this.GBtotalPrice.Name = "GBtotalPrice";
            this.GBtotalPrice.Size = new System.Drawing.Size(202, 114);
            this.GBtotalPrice.TabIndex = 6;
            this.GBtotalPrice.TabStop = false;
            this.GBtotalPrice.Text = "TotalPrice:";
            // 
            // TotalpriceValue
            // 
            this.TotalpriceValue.AutoSize = true;
            this.TotalpriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalpriceValue.ForeColor = System.Drawing.Color.ForestGreen;
            this.TotalpriceValue.Location = new System.Drawing.Point(78, 43);
            this.TotalpriceValue.Name = "TotalpriceValue";
            this.TotalpriceValue.Size = new System.Drawing.Size(70, 52);
            this.TotalpriceValue.TabIndex = 0;
            this.TotalpriceValue.Text = "$0";
            // 
            // Orderbtn
            // 
            this.Orderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orderbtn.Location = new System.Drawing.Point(250, 549);
            this.Orderbtn.Name = "Orderbtn";
            this.Orderbtn.Size = new System.Drawing.Size(130, 46);
            this.Orderbtn.TabIndex = 7;
            this.Orderbtn.Text = "order Pizza";
            this.Orderbtn.UseVisualStyleBackColor = true;
            this.Orderbtn.Click += new System.EventHandler(this.Orderbtn_Click);
            // 
            // Restbtn
            // 
            this.Restbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restbtn.Location = new System.Drawing.Point(468, 549);
            this.Restbtn.Name = "Restbtn";
            this.Restbtn.Size = new System.Drawing.Size(130, 46);
            this.Restbtn.TabIndex = 8;
            this.Restbtn.Text = "Reset Form";
            this.Restbtn.UseVisualStyleBackColor = true;
            this.Restbtn.Click += new System.EventHandler(this.Restbtn_Click);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(926, 633);
            this.Controls.Add(this.Restbtn);
            this.Controls.Add(this.Orderbtn);
            this.Controls.Add(this.GBtotalPrice);
            this.Controls.Add(this.GBwheretoeat);
            this.Controls.Add(this.GBtoppins);
            this.Controls.Add(this.GBCrust);
            this.Controls.Add(this.GBsize);
            this.Controls.Add(this.Mainlabel);
            this.Controls.Add(this.GBordersum);
            this.Name = "Page1";
            this.Text = "PizzaOrder";
            this.Load += new System.EventHandler(this.Page1_Load);
            this.GBsize.ResumeLayout(false);
            this.GBsize.PerformLayout();
            this.GBCrust.ResumeLayout(false);
            this.GBCrust.PerformLayout();
            this.GBtoppins.ResumeLayout(false);
            this.GBtoppins.PerformLayout();
            this.GBwheretoeat.ResumeLayout(false);
            this.GBwheretoeat.PerformLayout();
            this.GBordersum.ResumeLayout(false);
            this.GBordersum.PerformLayout();
            this.GBtotalPrice.ResumeLayout(false);
            this.GBtotalPrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mainlabel;
        private System.Windows.Forms.GroupBox GBsize;
        private System.Windows.Forms.RadioButton RBlarge;
        private System.Windows.Forms.RadioButton RBmedium;
        private System.Windows.Forms.RadioButton RBsmall;
        private System.Windows.Forms.GroupBox GBCrust;
        private System.Windows.Forms.RadioButton Rbthincrust;
        private System.Windows.Forms.RadioButton RBthikcrust;
        private System.Windows.Forms.RadioButton RBstuffed;
        private System.Windows.Forms.GroupBox GBtoppins;
        private System.Windows.Forms.CheckBox chkBoxoliv;
        private System.Windows.Forms.CheckBox chkBoxonin;
        private System.Windows.Forms.CheckBox chkBoxMush;
        private System.Windows.Forms.CheckBox chkBoxPeps;
        private System.Windows.Forms.CheckBox chkBoxtomato;
        private System.Windows.Forms.CheckBox chkBoxcheese;
        private System.Windows.Forms.GroupBox GBwheretoeat;
        private System.Windows.Forms.RadioButton RBtakeaway;
        private System.Windows.Forms.RadioButton RBEatin;
        private System.Windows.Forms.GroupBox GBordersum;
        private System.Windows.Forms.GroupBox GBtotalPrice;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Button Orderbtn;
        private System.Windows.Forms.Button Restbtn;
        private System.Windows.Forms.Label SizeValueLable;
        private System.Windows.Forms.Label CrusttypeLable;
        private System.Windows.Forms.Label ToppingsValuelabel;
        private System.Windows.Forms.Label ToppingsLable;
        private System.Windows.Forms.Label WhereToEatValue;
        private System.Windows.Forms.Label WhereToEatLable;
        private System.Windows.Forms.Label CrustTypeValue;
        private System.Windows.Forms.Label TotalpriceValue;
    }
}


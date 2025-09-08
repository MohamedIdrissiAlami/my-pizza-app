namespace MyPizza
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
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomato = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbTotalPrice = new System.Windows.Forms.GroupBox();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.gbOrderSummary.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbTotalPrice.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.YellowGreen;
            this.lblTotalPrice.Font = new System.Drawing.Font("Arial Black", 33F);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPrice.Location = new System.Drawing.Point(49, 29);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(144, 78);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "$50";
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnResetForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetForm.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnResetForm.FlatAppearance.BorderSize = 3;
            this.btnResetForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnResetForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.ForeColor = System.Drawing.Color.Green;
            this.btnResetForm.Location = new System.Drawing.Point(514, 546);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(178, 61);
            this.btnResetForm.TabIndex = 16;
            this.btnResetForm.Text = "RESET FORM";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOrderPizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderPizza.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnOrderPizza.FlatAppearance.BorderSize = 3;
            this.btnOrderPizza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnOrderPizza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnOrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.ForeColor = System.Drawing.Color.Green;
            this.btnOrderPizza.Location = new System.Drawing.Point(306, 546);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(178, 61);
            this.btnOrderPizza.TabIndex = 15;
            this.btnOrderPizza.Text = "ORDER PIZZA";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            // 
            // lblToppings
            // 
            this.lblToppings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToppings.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(39, 122);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(227, 83);
            this.lblToppings.TabIndex = 18;
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.Location = new System.Drawing.Point(161, 289);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(0, 23);
            this.lblWhereToEat.TabIndex = 17;
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.Location = new System.Drawing.Point(161, 220);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(0, 23);
            this.lblCrustType.TabIndex = 16;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(99, 54);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(0, 23);
            this.lblSize.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(20, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Crust type : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(20, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Toppings : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Size :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(20, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Where To eat : ";
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(229)))), ((int)(((byte)(197)))));
            this.gbOrderSummary.Controls.Add(this.lblToppings);
            this.gbOrderSummary.Controls.Add(this.lblWhereToEat);
            this.gbOrderSummary.Controls.Add(this.lblCrustType);
            this.gbOrderSummary.Controls.Add(this.lblSize);
            this.gbOrderSummary.Controls.Add(this.label7);
            this.gbOrderSummary.Controls.Add(this.label9);
            this.gbOrderSummary.Controls.Add(this.label2);
            this.gbOrderSummary.Controls.Add(this.label4);
            this.gbOrderSummary.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.gbOrderSummary.Location = new System.Drawing.Point(780, 124);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(272, 330);
            this.gbOrderSummary.TabIndex = 14;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order  Summary";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkGreenPeppers.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.chkGreenPeppers.Location = new System.Drawing.Point(232, 123);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(141, 24);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Tag = "2";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOnion.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.chkOnion.Location = new System.Drawing.Point(232, 33);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(75, 24);
            this.chkOnion.TabIndex = 4;
            this.chkOnion.Tag = "2";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            // 
            // chkTomato
            // 
            this.chkTomato.AutoSize = true;
            this.chkTomato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkTomato.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.chkTomato.Location = new System.Drawing.Point(27, 124);
            this.chkTomato.Name = "chkTomato";
            this.chkTomato.Size = new System.Drawing.Size(91, 24);
            this.chkTomato.TabIndex = 3;
            this.chkTomato.Tag = "2";
            this.chkTomato.Text = "Tomato";
            this.chkTomato.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkMushrooms.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.chkMushrooms.Location = new System.Drawing.Point(27, 79);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(117, 24);
            this.chkMushrooms.TabIndex = 2;
            this.chkMushrooms.Tag = "2";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOlives.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.chkOlives.Location = new System.Drawing.Point(232, 78);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(76, 24);
            this.chkOlives.TabIndex = 1;
            this.chkOlives.Tag = "2";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkExtraCheese.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.chkExtraCheese.Location = new System.Drawing.Point(27, 34);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(131, 24);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Tag = "2";
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(229)))), ((int)(((byte)(197)))));
            this.gbToppings.Controls.Add(this.chkGreenPeppers);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomato);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkExtraCheese);
            this.gbToppings.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.gbToppings.Location = new System.Drawing.Point(306, 114);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(386, 150);
            this.gbToppings.TabIndex = 13;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Checked = true;
            this.rbEatIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEatIn.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.rbEatIn.Location = new System.Drawing.Point(27, 35);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(79, 24);
            this.rbEatIn.TabIndex = 2;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Tag = "5";
            this.rbEatIn.Text = "Eat in";
            this.rbEatIn.UseVisualStyleBackColor = true;
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTakeOut.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.rbTakeOut.Location = new System.Drawing.Point(232, 34);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(103, 24);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Tag = "0";
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(229)))), ((int)(((byte)(197)))));
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.gbWhereToEat.Location = new System.Drawing.Point(306, 378);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(386, 76);
            this.gbWhereToEat.TabIndex = 12;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 85);
            this.label1.TabIndex = 11;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbThickCrust.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.rbThickCrust.Location = new System.Drawing.Point(17, 107);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(120, 24);
            this.rbThickCrust.TabIndex = 2;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Tag = "10";
            this.rbThickCrust.Text = "Thick Crust";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Checked = true;
            this.rbThinCrust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbThinCrust.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.rbThinCrust.Location = new System.Drawing.Point(17, 53);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(114, 24);
            this.rbThinCrust.TabIndex = 1;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "7";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            // 
            // gbCrustType
            // 
            this.gbCrustType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(229)))), ((int)(((byte)(197)))));
            this.gbCrustType.Controls.Add(this.rbThickCrust);
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.gbCrustType.Location = new System.Drawing.Point(23, 378);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(195, 150);
            this.gbCrustType.TabIndex = 9;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbLarge.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.rbLarge.Location = new System.Drawing.Point(17, 123);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(71, 24);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "20";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMedium.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.rbMedium.Location = new System.Drawing.Point(17, 78);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(90, 24);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "15";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Checked = true;
            this.rbSmall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSmall.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.rbSmall.Location = new System.Drawing.Point(17, 33);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(72, 24);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "10";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // gbTotalPrice
            // 
            this.gbTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(229)))), ((int)(((byte)(197)))));
            this.gbTotalPrice.Controls.Add(this.lblTotalPrice);
            this.gbTotalPrice.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.gbTotalPrice.Location = new System.Drawing.Point(781, 500);
            this.gbTotalPrice.Name = "gbTotalPrice";
            this.gbTotalPrice.Size = new System.Drawing.Size(272, 119);
            this.gbTotalPrice.TabIndex = 10;
            this.gbTotalPrice.TabStop = false;
            this.gbTotalPrice.Text = "TotalPrice";
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(229)))), ((int)(((byte)(197)))));
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.gbSize.Location = new System.Drawing.Point(23, 114);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(195, 150);
            this.gbSize.TabIndex = 8;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1080, 634);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbTotalPrice);
            this.Controls.Add(this.gbSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbTotalPrice.ResumeLayout(false);
            this.gbTotalPrice.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomato;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbTotalPrice;
        private System.Windows.Forms.GroupBox gbSize;
    }
}


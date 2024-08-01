namespace Pizza_Project
{
    partial class frmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarg = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSamll = new System.Windows.Forms.RadioButton();
            this.gbcrusttype = new System.Windows.Forms.GroupBox();
            this.rbThink = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.gbTopping = new System.Windows.Forms.GroupBox();
            this.cbGrrenPepper = new System.Windows.Forms.CheckBox();
            this.cbOlives = new System.Windows.Forms.CheckBox();
            this.cbOinion = new System.Windows.Forms.CheckBox();
            this.cbTomatoes = new System.Windows.Forms.CheckBox();
            this.cbMushrooms = new System.Windows.Forms.CheckBox();
            this.cbExtraChees = new System.Windows.Forms.CheckBox();
            this.gbwhrertoeat = new System.Windows.Forms.GroupBox();
            this.rbeatout = new System.Windows.Forms.RadioButton();
            this.rbeaten = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbordersummary = new System.Windows.Forms.GroupBox();
            this.lbtotalprice2 = new System.Windows.Forms.Label();
            this.lbWhrertoeat2 = new System.Windows.Forms.Label();
            this.lbCurstType2 = new System.Windows.Forms.Label();
            this.lbToppings2 = new System.Windows.Forms.Label();
            this.lbSize2 = new System.Windows.Forms.Label();
            this.lbtotalprice = new System.Windows.Forms.Label();
            this.lbwheretoeat = new System.Windows.Forms.Label();
            this.lbcrusttype = new System.Windows.Forms.Label();
            this.lbToppings = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.btnorderpizza = new System.Windows.Forms.Button();
            this.btnresetform = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbcrusttype.SuspendLayout();
            this.gbTopping.SuspendLayout();
            this.gbwhrertoeat.SuspendLayout();
            this.gbordersummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbSize.BackgroundImage")));
            this.gbSize.Controls.Add(this.rbLarg);
            this.gbSize.Controls.Add(this.rbMeduim);
            this.gbSize.Controls.Add(this.rbSamll);
            this.gbSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbSize.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.ForeColor = System.Drawing.Color.Blue;
            this.gbSize.Location = new System.Drawing.Point(28, 148);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(200, 100);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarg
            // 
            this.rbLarg.AutoSize = true;
            this.rbLarg.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarg.Location = new System.Drawing.Point(28, 65);
            this.rbLarg.Name = "rbLarg";
            this.rbLarg.Size = new System.Drawing.Size(60, 24);
            this.rbLarg.TabIndex = 2;
            this.rbLarg.TabStop = true;
            this.rbLarg.Tag = "40";
            this.rbLarg.Text = "Larg";
            this.rbLarg.UseVisualStyleBackColor = true;
            this.rbLarg.CheckedChanged += new System.EventHandler(this.rbLarg_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMeduim.Location = new System.Drawing.Point(28, 42);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(87, 24);
            this.rbMeduim.TabIndex = 1;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Tag = "30";
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbSamll
            // 
            this.rbSamll.AutoSize = true;
            this.rbSamll.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSamll.Location = new System.Drawing.Point(28, 20);
            this.rbSamll.Name = "rbSamll";
            this.rbSamll.Size = new System.Drawing.Size(69, 24);
            this.rbSamll.TabIndex = 0;
            this.rbSamll.TabStop = true;
            this.rbSamll.Tag = "20";
            this.rbSamll.Text = "Small";
            this.rbSamll.UseVisualStyleBackColor = true;
            this.rbSamll.CheckedChanged += new System.EventHandler(this.rbSamll_CheckedChanged);
            // 
            // gbcrusttype
            // 
            this.gbcrusttype.BackColor = System.Drawing.Color.Transparent;
            this.gbcrusttype.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbcrusttype.BackgroundImage")));
            this.gbcrusttype.Controls.Add(this.rbThink);
            this.gbcrusttype.Controls.Add(this.rbThin);
            this.gbcrusttype.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbcrusttype.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbcrusttype.ForeColor = System.Drawing.Color.Blue;
            this.gbcrusttype.Location = new System.Drawing.Point(28, 278);
            this.gbcrusttype.Name = "gbcrusttype";
            this.gbcrusttype.Size = new System.Drawing.Size(200, 100);
            this.gbcrusttype.TabIndex = 1;
            this.gbcrusttype.TabStop = false;
            this.gbcrusttype.Text = "Crust Type";
            // 
            // rbThink
            // 
            this.rbThink.AutoSize = true;
            this.rbThink.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThink.Location = new System.Drawing.Point(23, 65);
            this.rbThink.Name = "rbThink";
            this.rbThink.Size = new System.Drawing.Size(119, 24);
            this.rbThink.TabIndex = 2;
            this.rbThink.TabStop = true;
            this.rbThink.Tag = "10";
            this.rbThink.Text = "Think Curst";
            this.rbThink.UseVisualStyleBackColor = true;
            this.rbThink.CheckedChanged += new System.EventHandler(this.rbThink_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThin.Location = new System.Drawing.Point(23, 28);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(111, 24);
            this.rbThin.TabIndex = 1;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin Curst";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // gbTopping
            // 
            this.gbTopping.BackColor = System.Drawing.Color.Transparent;
            this.gbTopping.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbTopping.BackgroundImage")));
            this.gbTopping.Controls.Add(this.cbGrrenPepper);
            this.gbTopping.Controls.Add(this.cbOlives);
            this.gbTopping.Controls.Add(this.cbOinion);
            this.gbTopping.Controls.Add(this.cbTomatoes);
            this.gbTopping.Controls.Add(this.cbMushrooms);
            this.gbTopping.Controls.Add(this.cbExtraChees);
            this.gbTopping.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbTopping.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTopping.ForeColor = System.Drawing.Color.Blue;
            this.gbTopping.Location = new System.Drawing.Point(294, 112);
            this.gbTopping.Name = "gbTopping";
            this.gbTopping.Size = new System.Drawing.Size(230, 125);
            this.gbTopping.TabIndex = 2;
            this.gbTopping.TabStop = false;
            this.gbTopping.Text = "Toppings";
            // 
            // cbGrrenPepper
            // 
            this.cbGrrenPepper.AutoSize = true;
            this.cbGrrenPepper.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrrenPepper.Location = new System.Drawing.Point(104, 82);
            this.cbGrrenPepper.Name = "cbGrrenPepper";
            this.cbGrrenPepper.Size = new System.Drawing.Size(130, 24);
            this.cbGrrenPepper.TabIndex = 5;
            this.cbGrrenPepper.Tag = "5";
            this.cbGrrenPepper.Text = "Grren Pepper";
            this.cbGrrenPepper.UseVisualStyleBackColor = true;
            this.cbGrrenPepper.CheckedChanged += new System.EventHandler(this.cbGrrenPepper_CheckedChanged);
            // 
            // cbOlives
            // 
            this.cbOlives.AutoSize = true;
            this.cbOlives.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOlives.Location = new System.Drawing.Point(104, 56);
            this.cbOlives.Name = "cbOlives";
            this.cbOlives.Size = new System.Drawing.Size(73, 24);
            this.cbOlives.TabIndex = 4;
            this.cbOlives.Tag = "5";
            this.cbOlives.Text = "Olives";
            this.cbOlives.UseVisualStyleBackColor = true;
            this.cbOlives.CheckedChanged += new System.EventHandler(this.cbOlives_CheckedChanged);
            // 
            // cbOinion
            // 
            this.cbOinion.AutoSize = true;
            this.cbOinion.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOinion.Location = new System.Drawing.Point(104, 33);
            this.cbOinion.Name = "cbOinion";
            this.cbOinion.Size = new System.Drawing.Size(72, 24);
            this.cbOinion.TabIndex = 3;
            this.cbOinion.Tag = "5";
            this.cbOinion.Text = "Onion";
            this.cbOinion.UseVisualStyleBackColor = true;
            this.cbOinion.CheckedChanged += new System.EventHandler(this.cbOinion_CheckedChanged);
            // 
            // cbTomatoes
            // 
            this.cbTomatoes.AutoSize = true;
            this.cbTomatoes.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTomatoes.Location = new System.Drawing.Point(6, 82);
            this.cbTomatoes.Name = "cbTomatoes";
            this.cbTomatoes.Size = new System.Drawing.Size(103, 24);
            this.cbTomatoes.TabIndex = 2;
            this.cbTomatoes.Tag = "5";
            this.cbTomatoes.Text = "Tomatoes";
            this.cbTomatoes.UseVisualStyleBackColor = true;
            this.cbTomatoes.CheckedChanged += new System.EventHandler(this.cbTomatoes_CheckedChanged);
            // 
            // cbMushrooms
            // 
            this.cbMushrooms.AutoSize = true;
            this.cbMushrooms.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMushrooms.Location = new System.Drawing.Point(6, 59);
            this.cbMushrooms.Name = "cbMushrooms";
            this.cbMushrooms.Size = new System.Drawing.Size(103, 21);
            this.cbMushrooms.TabIndex = 1;
            this.cbMushrooms.Tag = "5";
            this.cbMushrooms.Text = "Mushrooms";
            this.cbMushrooms.UseVisualStyleBackColor = true;
            this.cbMushrooms.CheckedChanged += new System.EventHandler(this.chMushrooms_CheckedChanged);
            // 
            // cbExtraChees
            // 
            this.cbExtraChees.AutoSize = true;
            this.cbExtraChees.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExtraChees.Location = new System.Drawing.Point(6, 33);
            this.cbExtraChees.Name = "cbExtraChees";
            this.cbExtraChees.Size = new System.Drawing.Size(112, 24);
            this.cbExtraChees.TabIndex = 0;
            this.cbExtraChees.Tag = "5";
            this.cbExtraChees.Text = "ExtraChees";
            this.cbExtraChees.UseVisualStyleBackColor = true;
            this.cbExtraChees.CheckedChanged += new System.EventHandler(this.cbExtraChees_CheckedChanged);
            // 
            // gbwhrertoeat
            // 
            this.gbwhrertoeat.BackColor = System.Drawing.Color.Transparent;
            this.gbwhrertoeat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbwhrertoeat.BackgroundImage")));
            this.gbwhrertoeat.Controls.Add(this.rbeatout);
            this.gbwhrertoeat.Controls.Add(this.rbeaten);
            this.gbwhrertoeat.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbwhrertoeat.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbwhrertoeat.ForeColor = System.Drawing.Color.Blue;
            this.gbwhrertoeat.Location = new System.Drawing.Point(300, 259);
            this.gbwhrertoeat.Name = "gbwhrertoeat";
            this.gbwhrertoeat.Size = new System.Drawing.Size(200, 83);
            this.gbwhrertoeat.TabIndex = 3;
            this.gbwhrertoeat.TabStop = false;
            this.gbwhrertoeat.Text = "Where To Eat";
            // 
            // rbeatout
            // 
            this.rbeatout.AutoSize = true;
            this.rbeatout.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbeatout.Location = new System.Drawing.Point(109, 48);
            this.rbeatout.Name = "rbeatout";
            this.rbeatout.Size = new System.Drawing.Size(92, 24);
            this.rbeatout.TabIndex = 1;
            this.rbeatout.TabStop = true;
            this.rbeatout.Tag = "5";
            this.rbeatout.Text = "Eat Out";
            this.rbeatout.UseVisualStyleBackColor = true;
            this.rbeatout.CheckedChanged += new System.EventHandler(this.rbeatout_CheckedChanged);
            // 
            // rbeaten
            // 
            this.rbeaten.AutoSize = true;
            this.rbeaten.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbeaten.Location = new System.Drawing.Point(6, 48);
            this.rbeaten.Name = "rbeaten";
            this.rbeaten.Size = new System.Drawing.Size(76, 24);
            this.rbeaten.TabIndex = 0;
            this.rbeaten.TabStop = true;
            this.rbeaten.Tag = "0";
            this.rbeaten.Text = "Eat In";
            this.rbeaten.UseVisualStyleBackColor = true;
            this.rbeaten.CheckedChanged += new System.EventHandler(this.rbeaten_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(262, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // gbordersummary
            // 
            this.gbordersummary.BackColor = System.Drawing.Color.Transparent;
            this.gbordersummary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbordersummary.BackgroundImage")));
            this.gbordersummary.Controls.Add(this.lbtotalprice2);
            this.gbordersummary.Controls.Add(this.lbWhrertoeat2);
            this.gbordersummary.Controls.Add(this.lbCurstType2);
            this.gbordersummary.Controls.Add(this.lbToppings2);
            this.gbordersummary.Controls.Add(this.lbSize2);
            this.gbordersummary.Controls.Add(this.lbtotalprice);
            this.gbordersummary.Controls.Add(this.lbwheretoeat);
            this.gbordersummary.Controls.Add(this.lbcrusttype);
            this.gbordersummary.Controls.Add(this.lbToppings);
            this.gbordersummary.Controls.Add(this.lbSize);
            this.gbordersummary.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbordersummary.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbordersummary.ForeColor = System.Drawing.Color.Blue;
            this.gbordersummary.Location = new System.Drawing.Point(569, 128);
            this.gbordersummary.Name = "gbordersummary";
            this.gbordersummary.Size = new System.Drawing.Size(241, 266);
            this.gbordersummary.TabIndex = 5;
            this.gbordersummary.TabStop = false;
            this.gbordersummary.Text = "Order Summary";
            // 
            // lbtotalprice2
            // 
            this.lbtotalprice2.AutoSize = true;
            this.lbtotalprice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotalprice2.ForeColor = System.Drawing.Color.Lime;
            this.lbtotalprice2.Location = new System.Drawing.Point(134, 207);
            this.lbtotalprice2.Name = "lbtotalprice2";
            this.lbtotalprice2.Size = new System.Drawing.Size(0, 31);
            this.lbtotalprice2.TabIndex = 9;
            this.lbtotalprice2.Tag = "0";
            // 
            // lbWhrertoeat2
            // 
            this.lbWhrertoeat2.AutoSize = true;
            this.lbWhrertoeat2.ForeColor = System.Drawing.Color.Lime;
            this.lbWhrertoeat2.Location = new System.Drawing.Point(88, 172);
            this.lbWhrertoeat2.Name = "lbWhrertoeat2";
            this.lbWhrertoeat2.Size = new System.Drawing.Size(0, 25);
            this.lbWhrertoeat2.TabIndex = 8;
            // 
            // lbCurstType2
            // 
            this.lbCurstType2.AutoSize = true;
            this.lbCurstType2.ForeColor = System.Drawing.Color.Lime;
            this.lbCurstType2.Location = new System.Drawing.Point(111, 129);
            this.lbCurstType2.Name = "lbCurstType2";
            this.lbCurstType2.Size = new System.Drawing.Size(0, 25);
            this.lbCurstType2.TabIndex = 7;
            // 
            // lbToppings2
            // 
            this.lbToppings2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbToppings2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppings2.ForeColor = System.Drawing.Color.Lime;
            this.lbToppings2.Location = new System.Drawing.Point(29, 74);
            this.lbToppings2.Name = "lbToppings2";
            this.lbToppings2.Size = new System.Drawing.Size(212, 57);
            this.lbToppings2.TabIndex = 6;
            // 
            // lbSize2
            // 
            this.lbSize2.AutoSize = true;
            this.lbSize2.ForeColor = System.Drawing.Color.Lime;
            this.lbSize2.Location = new System.Drawing.Point(71, 22);
            this.lbSize2.Name = "lbSize2";
            this.lbSize2.Size = new System.Drawing.Size(0, 25);
            this.lbSize2.TabIndex = 5;
            // 
            // lbtotalprice
            // 
            this.lbtotalprice.AutoSize = true;
            this.lbtotalprice.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotalprice.Location = new System.Drawing.Point(19, 197);
            this.lbtotalprice.Name = "lbtotalprice";
            this.lbtotalprice.Size = new System.Drawing.Size(111, 21);
            this.lbtotalprice.TabIndex = 4;
            this.lbtotalprice.Text = "Total Price:";
            // 
            // lbwheretoeat
            // 
            this.lbwheretoeat.AutoSize = true;
            this.lbwheretoeat.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbwheretoeat.Location = new System.Drawing.Point(19, 150);
            this.lbwheretoeat.Name = "lbwheretoeat";
            this.lbwheretoeat.Size = new System.Drawing.Size(136, 21);
            this.lbwheretoeat.TabIndex = 3;
            this.lbwheretoeat.Text = "Where To Eat:";
            // 
            // lbcrusttype
            // 
            this.lbcrusttype.AutoSize = true;
            this.lbcrusttype.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcrusttype.Location = new System.Drawing.Point(19, 129);
            this.lbcrusttype.Name = "lbcrusttype";
            this.lbcrusttype.Size = new System.Drawing.Size(111, 21);
            this.lbcrusttype.TabIndex = 2;
            this.lbcrusttype.Text = "Curst Type:";
            // 
            // lbToppings
            // 
            this.lbToppings.AutoSize = true;
            this.lbToppings.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppings.Location = new System.Drawing.Point(19, 53);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(89, 21);
            this.lbToppings.TabIndex = 1;
            this.lbToppings.Text = "Toppings:";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.Color.Blue;
            this.lbSize.Location = new System.Drawing.Point(19, 25);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(51, 21);
            this.lbSize.TabIndex = 0;
            this.lbSize.Text = "Size:";
            // 
            // btnorderpizza
            // 
            this.btnorderpizza.BackColor = System.Drawing.Color.Black;
            this.btnorderpizza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnorderpizza.BackgroundImage")));
            this.btnorderpizza.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnorderpizza.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorderpizza.ForeColor = System.Drawing.Color.Blue;
            this.btnorderpizza.Location = new System.Drawing.Point(270, 390);
            this.btnorderpizza.Name = "btnorderpizza";
            this.btnorderpizza.Size = new System.Drawing.Size(130, 48);
            this.btnorderpizza.TabIndex = 6;
            this.btnorderpizza.Text = "Order Pizza";
            this.btnorderpizza.UseVisualStyleBackColor = false;
            this.btnorderpizza.Click += new System.EventHandler(this.btnorderpizza_Click);
            // 
            // btnresetform
            // 
            this.btnresetform.BackColor = System.Drawing.Color.Black;
            this.btnresetform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnresetform.BackgroundImage")));
            this.btnresetform.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnresetform.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetform.ForeColor = System.Drawing.Color.Blue;
            this.btnresetform.Location = new System.Drawing.Point(420, 390);
            this.btnresetform.Name = "btnresetform";
            this.btnresetform.Size = new System.Drawing.Size(130, 48);
            this.btnresetform.TabIndex = 7;
            this.btnresetform.Text = "Reset Form";
            this.btnresetform.UseVisualStyleBackColor = false;
            this.btnresetform.Click += new System.EventHandler(this.btnresetform_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(599, 418);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(598, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number Of Pizza";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnresetform);
            this.Controls.Add(this.btnorderpizza);
            this.Controls.Add(this.gbordersummary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbwhrertoeat);
            this.Controls.Add(this.gbTopping);
            this.Controls.Add(this.gbcrusttype);
            this.Controls.Add(this.gbSize);
            this.Name = "frmOrder";
            this.Text = "Form Order";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbcrusttype.ResumeLayout(false);
            this.gbcrusttype.PerformLayout();
            this.gbTopping.ResumeLayout(false);
            this.gbTopping.PerformLayout();
            this.gbwhrertoeat.ResumeLayout(false);
            this.gbwhrertoeat.PerformLayout();
            this.gbordersummary.ResumeLayout(false);
            this.gbordersummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarg;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbSamll;
        private System.Windows.Forms.GroupBox gbcrusttype;
        private System.Windows.Forms.RadioButton rbThink;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.GroupBox gbTopping;
        private System.Windows.Forms.CheckBox cbGrrenPepper;
        private System.Windows.Forms.CheckBox cbOlives;
        private System.Windows.Forms.CheckBox cbOinion;
        private System.Windows.Forms.CheckBox cbTomatoes;
        private System.Windows.Forms.CheckBox cbMushrooms;
        private System.Windows.Forms.CheckBox cbExtraChees;
        private System.Windows.Forms.GroupBox gbwhrertoeat;
        private System.Windows.Forms.RadioButton rbeatout;
        private System.Windows.Forms.RadioButton rbeaten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbordersummary;
        private System.Windows.Forms.Label lbtotalprice;
        private System.Windows.Forms.Label lbwheretoeat;
        private System.Windows.Forms.Label lbcrusttype;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Button btnorderpizza;
        private System.Windows.Forms.Button btnresetform;
        private System.Windows.Forms.Label lbtotalprice2;
        private System.Windows.Forms.Label lbWhrertoeat2;
        private System.Windows.Forms.Label lbCurstType2;
        private System.Windows.Forms.Label lbToppings2;
        private System.Windows.Forms.Label lbSize2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
    }
}


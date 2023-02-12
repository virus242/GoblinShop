namespace GoblinShop
{
    partial class GoblinShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoblinShop));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameGood = new System.Windows.Forms.TextBox();
            this.DamageGood = new System.Windows.Forms.TextBox();
            this.PublishButton = new System.Windows.Forms.Button();
            this.showGoodButton = new System.Windows.Forms.Button();
            this.BuyButton = new System.Windows.Forms.Button();
            this.ProtectionGood = new System.Windows.Forms.TextBox();
            this.DistancGood = new System.Windows.Forms.ComboBox();
            this.ClassGood = new System.Windows.Forms.ComboBox();
            this.IDShow = new System.Windows.Forms.TextBox();
            this.NameShow = new System.Windows.Forms.TextBox();
            this.ProtectionShow = new System.Windows.Forms.TextBox();
            this.ClassGoodShow = new System.Windows.Forms.ComboBox();
            this.DamageShow = new System.Windows.Forms.TextBox();
            this.DistancGoodShow = new System.Windows.Forms.ComboBox();
            this.IDBuy = new System.Windows.Forms.TextBox();
            this.Coins = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Picture = new System.Windows.Forms.Button();
            this.AddCoins = new System.Windows.Forms.Button();
            this.countCoins = new System.Windows.Forms.TextBox();
            this.ShowWhatCanBuy = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(873, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // NameGood
            // 
            this.NameGood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.NameGood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameGood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.NameGood.Location = new System.Drawing.Point(189, 16);
            this.NameGood.Name = "NameGood";
            this.NameGood.Size = new System.Drawing.Size(100, 20);
            this.NameGood.TabIndex = 1;
            this.NameGood.Text = "Name";
            // 
            // DamageGood
            // 
            this.DamageGood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.DamageGood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DamageGood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.DamageGood.Location = new System.Drawing.Point(189, 68);
            this.DamageGood.Name = "DamageGood";
            this.DamageGood.Size = new System.Drawing.Size(100, 20);
            this.DamageGood.TabIndex = 2;
            this.DamageGood.Text = "Damage";
            // 
            // PublishButton
            // 
            this.PublishButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.PublishButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(130)))));
            this.PublishButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PublishButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.PublishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PublishButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.PublishButton.Location = new System.Drawing.Point(340, 99);
            this.PublishButton.Name = "PublishButton";
            this.PublishButton.Size = new System.Drawing.Size(75, 23);
            this.PublishButton.TabIndex = 5;
            this.PublishButton.Text = "Publish";
            this.PublishButton.UseVisualStyleBackColor = false;
            this.PublishButton.Click += new System.EventHandler(this.PublishButton_Click);
            // 
            // showGoodButton
            // 
            this.showGoodButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.showGoodButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(130)))));
            this.showGoodButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.showGoodButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.showGoodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showGoodButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.showGoodButton.Location = new System.Drawing.Point(617, 99);
            this.showGoodButton.Name = "showGoodButton";
            this.showGoodButton.Size = new System.Drawing.Size(75, 23);
            this.showGoodButton.TabIndex = 6;
            this.showGoodButton.Text = "Show";
            this.showGoodButton.UseVisualStyleBackColor = false;
            this.showGoodButton.Click += new System.EventHandler(this.showGoodButton_Click);
            // 
            // BuyButton
            // 
            this.BuyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.BuyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(130)))));
            this.BuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.BuyButton.Location = new System.Drawing.Point(762, 99);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(75, 23);
            this.BuyButton.TabIndex = 7;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = false;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // ProtectionGood
            // 
            this.ProtectionGood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.ProtectionGood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProtectionGood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.ProtectionGood.Location = new System.Drawing.Point(189, 42);
            this.ProtectionGood.Name = "ProtectionGood";
            this.ProtectionGood.Size = new System.Drawing.Size(100, 20);
            this.ProtectionGood.TabIndex = 8;
            this.ProtectionGood.Text = "Protection";
            // 
            // DistancGood
            // 
            this.DistancGood.AutoCompleteCustomSource.AddRange(new string[] {
            "far",
            "middle",
            "near"});
            this.DistancGood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.DistancGood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DistancGood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.DistancGood.FormattingEnabled = true;
            this.DistancGood.Items.AddRange(new object[] {
            "far",
            "middle",
            "near"});
            this.DistancGood.Location = new System.Drawing.Point(294, 16);
            this.DistancGood.Name = "DistancGood";
            this.DistancGood.Size = new System.Drawing.Size(121, 21);
            this.DistancGood.TabIndex = 9;
            this.DistancGood.Text = "DistancGood";
            this.DistancGood.UseWaitCursor = true;
            // 
            // ClassGood
            // 
            this.ClassGood.AutoCompleteCustomSource.AddRange(new string[] {
            "potion",
            "weapon",
            "armor",
            "decoration",
            "different"});
            this.ClassGood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.ClassGood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassGood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.ClassGood.FormattingEnabled = true;
            this.ClassGood.Items.AddRange(new object[] {
            "potion",
            "weapon",
            "armor",
            "decoration",
            "different"});
            this.ClassGood.Location = new System.Drawing.Point(294, 41);
            this.ClassGood.Name = "ClassGood";
            this.ClassGood.Size = new System.Drawing.Size(121, 21);
            this.ClassGood.TabIndex = 10;
            this.ClassGood.Text = "ClassGood";
            this.ClassGood.UseWaitCursor = true;
            // 
            // IDShow
            // 
            this.IDShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.IDShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.IDShow.Location = new System.Drawing.Point(465, 17);
            this.IDShow.Name = "IDShow";
            this.IDShow.Size = new System.Drawing.Size(100, 20);
            this.IDShow.TabIndex = 12;
            this.IDShow.Text = "ID";
            // 
            // NameShow
            // 
            this.NameShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.NameShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.NameShow.Location = new System.Drawing.Point(571, 16);
            this.NameShow.Name = "NameShow";
            this.NameShow.Size = new System.Drawing.Size(100, 20);
            this.NameShow.TabIndex = 11;
            this.NameShow.Text = "Name";
            // 
            // ProtectionShow
            // 
            this.ProtectionShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.ProtectionShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProtectionShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.ProtectionShow.Location = new System.Drawing.Point(465, 41);
            this.ProtectionShow.Name = "ProtectionShow";
            this.ProtectionShow.Size = new System.Drawing.Size(100, 20);
            this.ProtectionShow.TabIndex = 13;
            this.ProtectionShow.Text = "Protection";
            // 
            // ClassGoodShow
            // 
            this.ClassGoodShow.AutoCompleteCustomSource.AddRange(new string[] {
            "potion",
            "weapon",
            "armor",
            "decoration",
            "different"});
            this.ClassGoodShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.ClassGoodShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassGoodShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.ClassGoodShow.FormattingEnabled = true;
            this.ClassGoodShow.Items.AddRange(new object[] {
            "potion",
            "weapon",
            "armor",
            "decoration",
            "different"});
            this.ClassGoodShow.Location = new System.Drawing.Point(571, 41);
            this.ClassGoodShow.Name = "ClassGoodShow";
            this.ClassGoodShow.Size = new System.Drawing.Size(121, 21);
            this.ClassGoodShow.TabIndex = 14;
            this.ClassGoodShow.Text = "ClassGood";
            // 
            // DamageShow
            // 
            this.DamageShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.DamageShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DamageShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.DamageShow.Location = new System.Drawing.Point(465, 68);
            this.DamageShow.Name = "DamageShow";
            this.DamageShow.Size = new System.Drawing.Size(100, 20);
            this.DamageShow.TabIndex = 15;
            this.DamageShow.Text = "Damage";
            // 
            // DistancGoodShow
            // 
            this.DistancGoodShow.AutoCompleteCustomSource.AddRange(new string[] {
            "far",
            "middle",
            "near"});
            this.DistancGoodShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.DistancGoodShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DistancGoodShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.DistancGoodShow.FormattingEnabled = true;
            this.DistancGoodShow.Items.AddRange(new object[] {
            "far",
            "middle",
            "near"});
            this.DistancGoodShow.Location = new System.Drawing.Point(571, 67);
            this.DistancGoodShow.Name = "DistancGoodShow";
            this.DistancGoodShow.Size = new System.Drawing.Size(121, 21);
            this.DistancGoodShow.TabIndex = 16;
            this.DistancGoodShow.Text = "DistancGood";
            // 
            // IDBuy
            // 
            this.IDBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.IDBuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.IDBuy.Location = new System.Drawing.Point(737, 68);
            this.IDBuy.Name = "IDBuy";
            this.IDBuy.Size = new System.Drawing.Size(100, 20);
            this.IDBuy.TabIndex = 17;
            this.IDBuy.Text = "ID";
            // 
            // Coins
            // 
            this.Coins.AutoSize = true;
            this.Coins.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Coins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.Coins.Location = new System.Drawing.Point(182, 119);
            this.Coins.Name = "Coins";
            this.Coins.Size = new System.Drawing.Size(104, 40);
            this.Coins.TabIndex = 18;
            this.Coins.Text = "Coins:";
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.Price.Location = new System.Drawing.Point(295, 68);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(120, 20);
            this.Price.TabIndex = 19;
            this.Price.Text = "Price";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.NameLabel.Location = new System.Drawing.Point(42, 69);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(41, 16);
            this.NameLabel.TabIndex = 20;
            this.NameLabel.Text = "name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.Picture.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(130)))));
            this.Picture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Picture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.Picture.Location = new System.Drawing.Point(11, 88);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(105, 23);
            this.Picture.TabIndex = 22;
            this.Picture.Text = "choose a picture";
            this.Picture.UseVisualStyleBackColor = false;
            this.Picture.Click += new System.EventHandler(this.Picture_Click);
            // 
            // AddCoins
            // 
            this.AddCoins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(77)))), ((int)(((byte)(148)))));
            this.AddCoins.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(130)))));
            this.AddCoins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCoins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.AddCoins.Location = new System.Drawing.Point(592, 135);
            this.AddCoins.Name = "AddCoins";
            this.AddCoins.Size = new System.Drawing.Size(100, 23);
            this.AddCoins.TabIndex = 23;
            this.AddCoins.Text = "Add Coins";
            this.AddCoins.UseVisualStyleBackColor = false;
            this.AddCoins.Click += new System.EventHandler(this.AddCoins_Click);
            // 
            // countCoins
            // 
            this.countCoins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.countCoins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countCoins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.countCoins.Location = new System.Drawing.Point(465, 135);
            this.countCoins.Name = "countCoins";
            this.countCoins.Size = new System.Drawing.Size(100, 20);
            this.countCoins.TabIndex = 24;
            // 
            // ShowWhatCanBuy
            // 
            this.ShowWhatCanBuy.AutoSize = true;
            this.ShowWhatCanBuy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.ShowWhatCanBuy.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(130)))));
            this.ShowWhatCanBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowWhatCanBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(170)))));
            this.ShowWhatCanBuy.Location = new System.Drawing.Point(465, 102);
            this.ShowWhatCanBuy.Name = "ShowWhatCanBuy";
            this.ShowWhatCanBuy.Size = new System.Drawing.Size(128, 17);
            this.ShowWhatCanBuy.TabIndex = 25;
            this.ShowWhatCanBuy.Text = "Show you what to buy";
            this.ShowWhatCanBuy.UseVisualStyleBackColor = false;
            // 
            // GoblinShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(100)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(841, 547);
            this.Controls.Add(this.ShowWhatCanBuy);
            this.Controls.Add(this.countCoins);
            this.Controls.Add(this.AddCoins);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Coins);
            this.Controls.Add(this.IDBuy);
            this.Controls.Add(this.DistancGoodShow);
            this.Controls.Add(this.DamageShow);
            this.Controls.Add(this.ClassGoodShow);
            this.Controls.Add(this.ProtectionShow);
            this.Controls.Add(this.IDShow);
            this.Controls.Add(this.NameShow);
            this.Controls.Add(this.ClassGood);
            this.Controls.Add(this.DistancGood);
            this.Controls.Add(this.ProtectionGood);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.showGoodButton);
            this.Controls.Add(this.PublishButton);
            this.Controls.Add(this.DamageGood);
            this.Controls.Add(this.NameGood);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GoblinShop";
            this.Text = "GoblinShop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GoblinShop_FormClosing);
            this.Load += new System.EventHandler(this.GoblinShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox NameGood;
        private System.Windows.Forms.TextBox DamageGood;
        private System.Windows.Forms.Button PublishButton;
        private System.Windows.Forms.Button showGoodButton;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.TextBox ProtectionGood;
        private System.Windows.Forms.ComboBox DistancGood;
        private System.Windows.Forms.ComboBox ClassGood;
        private System.Windows.Forms.TextBox IDShow;
        private System.Windows.Forms.TextBox NameShow;
        private System.Windows.Forms.TextBox ProtectionShow;
        private System.Windows.Forms.ComboBox ClassGoodShow;
        private System.Windows.Forms.TextBox DamageShow;
        private System.Windows.Forms.ComboBox DistancGoodShow;
        private System.Windows.Forms.TextBox IDBuy;
        private System.Windows.Forms.Label Coins;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Picture;
        private System.Windows.Forms.Button AddCoins;
        private System.Windows.Forms.TextBox countCoins;
        private System.Windows.Forms.CheckBox ShowWhatCanBuy;
    }
}
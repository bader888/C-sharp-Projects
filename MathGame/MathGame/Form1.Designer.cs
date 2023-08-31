namespace MathGame
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageStartGame = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownRoundNumber = new System.Windows.Forms.NumericUpDown();
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.tabPagePlayGame = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnFinalResult = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.btnOption1 = new System.Windows.Forms.Button();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxEnterYouAnswer = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblOperation = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNumberTwo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNumberOne = new System.Windows.Forms.Label();
            this.lblRoundNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageFinalResult = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblFinalResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblWrongAnswer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanelResults = new System.Windows.Forms.FlowLayoutPanel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownQTime = new System.Windows.Forms.NumericUpDown();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblChoseOperation = new System.Windows.Forms.Label();
            this.lblChoseLevel = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageStartGame.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoundNumber)).BeginInit();
            this.tabPagePlayGame.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPageFinalResult.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQTime)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageStartGame);
            this.tabControlMain.Controls.Add(this.tabPagePlayGame);
            this.tabControlMain.Controls.Add(this.tabPageFinalResult);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(559, 523);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageStartGame
            // 
            this.tabPageStartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(71)))));
            this.tabPageStartGame.Controls.Add(this.groupBox4);
            this.tabPageStartGame.Controls.Add(this.label1);
            this.tabPageStartGame.Controls.Add(this.btnStartGame);
            this.tabPageStartGame.ForeColor = System.Drawing.Color.White;
            this.tabPageStartGame.Location = new System.Drawing.Point(4, 22);
            this.tabPageStartGame.Name = "tabPageStartGame";
            this.tabPageStartGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStartGame.Size = new System.Drawing.Size(551, 497);
            this.tabPageStartGame.TabIndex = 0;
            this.tabPageStartGame.Text = "StartGame";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.numericUpDownQTime);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.numericUpDownRoundNumber);
            this.groupBox4.Controls.Add(this.comboBoxOperation);
            this.groupBox4.Controls.Add(this.comboBoxLevel);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(133, 80);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(309, 331);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Game Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rounds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Game Operation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Game Level";
            // 
            // numericUpDownRoundNumber
            // 
            this.numericUpDownRoundNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRoundNumber.Location = new System.Drawing.Point(17, 202);
            this.numericUpDownRoundNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRoundNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRoundNumber.Name = "numericUpDownRoundNumber";
            this.numericUpDownRoundNumber.Size = new System.Drawing.Size(279, 29);
            this.numericUpDownRoundNumber.TabIndex = 10;
            this.numericUpDownRoundNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownRoundNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "Mix"});
            this.comboBoxOperation.Location = new System.Drawing.Point(17, 129);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(279, 32);
            this.comboBoxOperation.TabIndex = 9;
            this.comboBoxOperation.Text = "+";
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.ItemHeight = 24;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "Easy",
            "Mid",
            "Hard",
            "Mix"});
            this.comboBoxLevel.Location = new System.Drawing.Point(17, 55);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(279, 32);
            this.comboBoxLevel.TabIndex = 8;
            this.comboBoxLevel.Text = "Easy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "MATH GAME";
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(141)))), ((int)(((byte)(152)))));
            this.btnStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(181, 433);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(188, 56);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // tabPagePlayGame
            // 
            this.tabPagePlayGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(71)))));
            this.tabPagePlayGame.Controls.Add(this.label6);
            this.tabPagePlayGame.Controls.Add(this.btnNextQuestion);
            this.tabPagePlayGame.Controls.Add(this.btnFinalResult);
            this.tabPagePlayGame.Controls.Add(this.progressBar);
            this.tabPagePlayGame.Controls.Add(this.groupBoxOptions);
            this.tabPagePlayGame.Controls.Add(this.panel1);
            this.tabPagePlayGame.Controls.Add(this.lblRoundNumber);
            this.tabPagePlayGame.Controls.Add(this.label5);
            this.tabPagePlayGame.ForeColor = System.Drawing.Color.White;
            this.tabPagePlayGame.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlayGame.Name = "tabPagePlayGame";
            this.tabPagePlayGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlayGame.Size = new System.Drawing.Size(551, 497);
            this.tabPagePlayGame.TabIndex = 1;
            this.tabPagePlayGame.Text = "playGame";
             // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(181, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 33);
            this.label6.TabIndex = 29;
            this.label6.Text = "MATH GAME";
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(141)))), ((int)(((byte)(152)))));
            this.btnNextQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextQuestion.Enabled = false;
            this.btnNextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuestion.Location = new System.Drawing.Point(129, 429);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(300, 49);
            this.btnNextQuestion.TabIndex = 1;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.UseVisualStyleBackColor = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // btnFinalResult
            // 
            this.btnFinalResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(141)))), ((int)(((byte)(152)))));
            this.btnFinalResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalResult.Location = new System.Drawing.Point(127, 429);
            this.btnFinalResult.Name = "btnFinalResult";
            this.btnFinalResult.Size = new System.Drawing.Size(296, 49);
            this.btnFinalResult.TabIndex = 2;
            this.btnFinalResult.Text = "Final Result";
            this.btnFinalResult.UseVisualStyleBackColor = false;
            this.btnFinalResult.Visible = false;
            this.btnFinalResult.Click += new System.EventHandler(this.btnFinalResult_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(129, 108);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(294, 12);
            this.progressBar.TabIndex = 28;
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.btnOption1);
            this.groupBoxOptions.Controls.Add(this.btnOption4);
            this.groupBoxOptions.Controls.Add(this.btnOption3);
            this.groupBoxOptions.Controls.Add(this.btnOption2);
            this.groupBoxOptions.ForeColor = System.Drawing.Color.White;
            this.groupBoxOptions.Location = new System.Drawing.Point(129, 311);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(300, 112);
            this.groupBoxOptions.TabIndex = 24;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // btnOption1
            // 
            this.btnOption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(141)))), ((int)(((byte)(152)))));
            this.btnOption1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOption1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption1.Location = new System.Drawing.Point(158, 16);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(106, 36);
            this.btnOption1.TabIndex = 25;
            this.btnOption1.Text = "button1";
            this.btnOption1.UseVisualStyleBackColor = false;
            this.btnOption1.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnOption4
            // 
            this.btnOption4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(141)))), ((int)(((byte)(152)))));
            this.btnOption4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOption4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption4.Location = new System.Drawing.Point(40, 60);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(106, 36);
            this.btnOption4.TabIndex = 2;
            this.btnOption4.Text = "button4";
            this.btnOption4.UseVisualStyleBackColor = false;
            this.btnOption4.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnOption3
            // 
            this.btnOption3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(141)))), ((int)(((byte)(152)))));
            this.btnOption3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOption3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption3.Location = new System.Drawing.Point(158, 58);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(106, 36);
            this.btnOption3.TabIndex = 1;
            this.btnOption3.Text = "button3";
            this.btnOption3.UseVisualStyleBackColor = false;
            this.btnOption3.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnOption2
            // 
            this.btnOption2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(141)))), ((int)(((byte)(152)))));
            this.btnOption2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOption2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption2.Location = new System.Drawing.Point(40, 18);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(106, 36);
            this.btnOption2.TabIndex = 0;
            this.btnOption2.Text = "button2";
            this.btnOption2.UseVisualStyleBackColor = false;
            this.btnOption2.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.lblChoseOperation);
            this.panel1.Controls.Add(this.lblChoseLevel);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.textBoxEnterYouAnswer);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 185);
            this.panel1.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(102)))), ((int)(((byte)(117)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label11);
            this.panel7.Location = new System.Drawing.Point(129, 129);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(97, 44);
            this.panel7.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(33, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 31);
            this.label11.TabIndex = 0;
            this.label11.Text = "=";
            // 
            // textBoxEnterYouAnswer
            // 
            this.textBoxEnterYouAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(102)))), ((int)(((byte)(117)))));
            this.textBoxEnterYouAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnterYouAnswer.ForeColor = System.Drawing.Color.White;
            this.textBoxEnterYouAnswer.Location = new System.Drawing.Point(232, 129);
            this.textBoxEnterYouAnswer.Multiline = true;
            this.textBoxEnterYouAnswer.Name = "textBoxEnterYouAnswer";
            this.textBoxEnterYouAnswer.ReadOnly = true;
            this.textBoxEnterYouAnswer.Size = new System.Drawing.Size(197, 44);
            this.textBoxEnterYouAnswer.TabIndex = 4;
            this.textBoxEnterYouAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(129, 121);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 2);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(102)))), ((int)(((byte)(117)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblOperation);
            this.panel4.Location = new System.Drawing.Point(232, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(97, 44);
            this.panel4.TabIndex = 2;
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.ForeColor = System.Drawing.Color.Transparent;
            this.lblOperation.Location = new System.Drawing.Point(34, 7);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(31, 31);
            this.lblOperation.TabIndex = 0;
            this.lblOperation.Text = "+";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(102)))), ((int)(((byte)(117)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblNumberTwo);
            this.panel3.Location = new System.Drawing.Point(129, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(97, 44);
            this.panel3.TabIndex = 1;
            // 
            // lblNumberTwo
            // 
            this.lblNumberTwo.AutoSize = true;
            this.lblNumberTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberTwo.ForeColor = System.Drawing.Color.Transparent;
            this.lblNumberTwo.Location = new System.Drawing.Point(27, 7);
            this.lblNumberTwo.Name = "lblNumberTwo";
            this.lblNumberTwo.Size = new System.Drawing.Size(46, 31);
            this.lblNumberTwo.TabIndex = 0;
            this.lblNumberTwo.Text = "20";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(102)))), ((int)(((byte)(117)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblNumberOne);
            this.panel2.Location = new System.Drawing.Point(129, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 44);
            this.panel2.TabIndex = 0;
            // 
            // lblNumberOne
            // 
            this.lblNumberOne.AutoSize = true;
            this.lblNumberOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOne.ForeColor = System.Drawing.Color.Transparent;
            this.lblNumberOne.Location = new System.Drawing.Point(24, 7);
            this.lblNumberOne.Name = "lblNumberOne";
            this.lblNumberOne.Size = new System.Drawing.Size(46, 31);
            this.lblNumberOne.TabIndex = 0;
            this.lblNumberOne.Text = "20";
            // 
            // lblRoundNumber
            // 
            this.lblRoundNumber.AutoSize = true;
            this.lblRoundNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundNumber.Location = new System.Drawing.Point(252, 78);
            this.lblRoundNumber.Name = "lblRoundNumber";
            this.lblRoundNumber.Size = new System.Drawing.Size(41, 20);
            this.lblRoundNumber.TabIndex = 10;
            this.lblRoundNumber.Text = "(1/1)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "ROUND";
            // 
            // tabPageFinalResult
            // 
            this.tabPageFinalResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(93)))), ((int)(((byte)(1)))));
            this.tabPageFinalResult.Controls.Add(this.groupBox3);
            this.tabPageFinalResult.Controls.Add(this.groupBox1);
            this.tabPageFinalResult.Controls.Add(this.PlayAgain);
            this.tabPageFinalResult.Controls.Add(this.groupBox2);
            this.tabPageFinalResult.Controls.Add(this.label7);
            this.tabPageFinalResult.Controls.Add(this.flowLayoutPanelResults);
            this.tabPageFinalResult.ForeColor = System.Drawing.Color.White;
            this.tabPageFinalResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageFinalResult.Name = "tabPageFinalResult";
            this.tabPageFinalResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFinalResult.Size = new System.Drawing.Size(551, 497);
            this.tabPageFinalResult.TabIndex = 2;
            this.tabPageFinalResult.Text = "Final Result";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblFinalResult);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(328, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 75);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Final Result";
            // 
            // lblFinalResult
            // 
            this.lblFinalResult.AutoSize = true;
            this.lblFinalResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalResult.Location = new System.Drawing.Point(57, 22);
            this.lblFinalResult.Name = "lblFinalResult";
            this.lblFinalResult.Size = new System.Drawing.Size(98, 31);
            this.lblFinalResult.TabIndex = 49;
            this.lblFinalResult.Text = "( fInal )";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblCorrectAnswer);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(328, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 75);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Correct Answer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 31);
            this.label8.TabIndex = 48;
            this.label8.Text = "100";
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswer.Location = new System.Drawing.Point(77, 22);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(59, 31);
            this.lblCorrectAnswer.TabIndex = 47;
            this.lblCorrectAnswer.Text = "100";
            // 
            // PlayAgain
            // 
            this.PlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(141)))), ((int)(((byte)(152)))));
            this.PlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgain.ForeColor = System.Drawing.Color.White;
            this.PlayAgain.Location = new System.Drawing.Point(328, 364);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(213, 51);
            this.PlayAgain.TabIndex = 50;
            this.PlayAgain.Text = "Play Again";
            this.PlayAgain.UseVisualStyleBackColor = false;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblWrongAnswer);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(328, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 75);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wrong Answer";
            // 
            // lblWrongAnswer
            // 
            this.lblWrongAnswer.AutoSize = true;
            this.lblWrongAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongAnswer.Location = new System.Drawing.Point(77, 22);
            this.lblWrongAnswer.Name = "lblWrongAnswer";
            this.lblWrongAnswer.Size = new System.Drawing.Size(59, 31);
            this.lblWrongAnswer.TabIndex = 48;
            this.lblWrongAnswer.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 33);
            this.label7.TabIndex = 43;
            this.label7.Text = "Math Game";
            // 
            // flowLayoutPanelResults
            // 
            this.flowLayoutPanelResults.AllowDrop = true;
            this.flowLayoutPanelResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(71)))));
            this.flowLayoutPanelResults.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelResults.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelResults.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelResults.Name = "flowLayoutPanelResults";
            this.flowLayoutPanelResults.Size = new System.Drawing.Size(313, 491);
            this.flowLayoutPanelResults.TabIndex = 33;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Question Time";
            // 
            // numericUpDownQTime
            // 
            this.numericUpDownQTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQTime.Location = new System.Drawing.Point(17, 270);
            this.numericUpDownQTime.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownQTime.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownQTime.Name = "numericUpDownQTime";
            this.numericUpDownQTime.Size = new System.Drawing.Size(279, 29);
            this.numericUpDownQTime.TabIndex = 14;
            this.numericUpDownQTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownQTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(60, 97);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(45, 13);
            this.lblTimer.TabIndex = 31;
            this.lblTimer.Text = "( 10 )  ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(50, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 24);
            this.label15.TabIndex = 30;
            this.label15.Text = "Timer";
            // 
            // lblChoseOperation
            // 
            this.lblChoseOperation.AutoSize = true;
            this.lblChoseOperation.Location = new System.Drawing.Point(64, 40);
            this.lblChoseOperation.Name = "lblChoseOperation";
            this.lblChoseOperation.Size = new System.Drawing.Size(29, 13);
            this.lblChoseOperation.TabIndex = 29;
            this.lblChoseOperation.Text = "easy";
            // 
            // lblChoseLevel
            // 
            this.lblChoseLevel.AutoSize = true;
            this.lblChoseLevel.Location = new System.Drawing.Point(64, 21);
            this.lblChoseLevel.Name = "lblChoseLevel";
            this.lblChoseLevel.Size = new System.Drawing.Size(29, 13);
            this.lblChoseLevel.TabIndex = 28;
            this.lblChoseLevel.Text = "easy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 523);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageStartGame.ResumeLayout(false);
            this.tabPageStartGame.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoundNumber)).EndInit();
            this.tabPagePlayGame.ResumeLayout(false);
            this.tabPagePlayGame.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPageFinalResult.ResumeLayout(false);
            this.tabPageFinalResult.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageStartGame;
        private System.Windows.Forms.TabPage tabPagePlayGame;
        private System.Windows.Forms.TabPage tabPageFinalResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNumberTwo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNumberOne;
        private System.Windows.Forms.TextBox textBoxEnterYouAnswer;
        private System.Windows.Forms.Label lblRoundNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnFinalResult;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelResults;
        private System.Windows.Forms.Label lblFinalResult;
        private System.Windows.Forms.Label lblWrongAnswer;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.Button btnOption4;
        private System.Windows.Forms.Button btnOption3;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownRoundNumber;
        private System.Windows.Forms.ComboBox comboBoxOperation;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownQTime;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblChoseOperation;
        private System.Windows.Forms.Label lblChoseLevel;
    }
}


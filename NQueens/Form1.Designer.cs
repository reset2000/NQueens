
namespace NQueens {
    partial class nQueens {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbTestMulti = new System.Windows.Forms.CheckBox();
            this.nudNValue = new System.Windows.Forms.NumericUpDown();
            this.lbNValue = new System.Windows.Forms.Label();
            this.tpBestFirstSearch = new System.Windows.Forms.TabPage();
            this.lbHeuristic = new System.Windows.Forms.Label();
            this.cbHeuristic = new System.Windows.Forms.ComboBox();
            this.rtbResultBestFirstSearch = new System.Windows.Forms.RichTextBox();
            this.txbDurationBestFirstSearch = new System.Windows.Forms.TextBox();
            this.txbSearchedStatesBestFirstSearch = new System.Windows.Forms.TextBox();
            this.txbCreatedStatesBestFirstSearch = new System.Windows.Forms.TextBox();
            this.btnNormalBestFirstSearch = new System.Windows.Forms.Button();
            this.btnCutBranchesBestFirstSearch = new System.Windows.Forms.Button();
            this.lbCreatedStatesBestFirstSearch = new System.Windows.Forms.Label();
            this.lbSearchedStatesBestFirstSearch = new System.Windows.Forms.Label();
            this.lbDurationBestFirstSearch = new System.Windows.Forms.Label();
            this.tpDFT = new System.Windows.Forms.TabPage();
            this.rtbResultDFS = new System.Windows.Forms.RichTextBox();
            this.txbDurationDFS = new System.Windows.Forms.TextBox();
            this.txbSearchedStatesDFS = new System.Windows.Forms.TextBox();
            this.txbCreatedStatesDFS = new System.Windows.Forms.TextBox();
            this.btnNormalDFS = new System.Windows.Forms.Button();
            this.btnCutBranchesDFS = new System.Windows.Forms.Button();
            this.lbCreatedStatesDFS = new System.Windows.Forms.Label();
            this.lbSearchedStatesDFS = new System.Windows.Forms.Label();
            this.lbDurationDFS = new System.Windows.Forms.Label();
            this.tpBFT = new System.Windows.Forms.TabPage();
            this.rtbResultBFS = new System.Windows.Forms.RichTextBox();
            this.txbDurationBFS = new System.Windows.Forms.TextBox();
            this.txbSearchedStatesBFS = new System.Windows.Forms.TextBox();
            this.txbCreatedStatesBFS = new System.Windows.Forms.TextBox();
            this.btnNormalBFS = new System.Windows.Forms.Button();
            this.btnCutBranchesBFS = new System.Windows.Forms.Button();
            this.lbCreatedStatesBFS = new System.Windows.Forms.Label();
            this.lbSearchedStatesBFS = new System.Windows.Forms.Label();
            this.lbDurationBFS = new System.Windows.Forms.Label();
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.tpGenetic = new System.Windows.Forms.TabPage();
            this.nudCrossover = new System.Windows.Forms.NumericUpDown();
            this.nudMutation = new System.Windows.Forms.NumericUpDown();
            this.nudGen = new System.Windows.Forms.NumericUpDown();
            this.nudPop = new System.Windows.Forms.NumericUpDown();
            this.genLbMutation = new System.Windows.Forms.Label();
            this.genLbCrossover = new System.Windows.Forms.Label();
            this.genLbGenerations = new System.Windows.Forms.Label();
            this.genLbPop = new System.Windows.Forms.Label();
            this.txbBestValue = new System.Windows.Forms.TextBox();
            this.genLbBestValue = new System.Windows.Forms.Label();
            this.txbBest = new System.Windows.Forms.TextBox();
            this.txbGen = new System.Windows.Forms.TextBox();
            this.genLbCnt = new System.Windows.Forms.Label();
            this.genLbBest = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNValue)).BeginInit();
            this.tpBestFirstSearch.SuspendLayout();
            this.tpDFT.SuspendLayout();
            this.tpBFT.SuspendLayout();
            this.tcTabs.SuspendLayout();
            this.tpGenetic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCrossover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPop)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTestMulti
            // 
            this.cbTestMulti.AutoSize = true;
            this.cbTestMulti.Location = new System.Drawing.Point(307, 269);
            this.cbTestMulti.Name = "cbTestMulti";
            this.cbTestMulti.Size = new System.Drawing.Size(92, 34);
            this.cbTestMulti.TabIndex = 18;
            this.cbTestMulti.Text = "wykonaj test\r\ndla wielu n";
            this.cbTestMulti.UseVisualStyleBackColor = true;
            // 
            // nudNValue
            // 
            this.nudNValue.Location = new System.Drawing.Point(46, 276);
            this.nudNValue.Name = "nudNValue";
            this.nudNValue.Size = new System.Drawing.Size(245, 23);
            this.nudNValue.TabIndex = 17;
            // 
            // lbNValue
            // 
            this.lbNValue.AutoSize = true;
            this.lbNValue.Location = new System.Drawing.Point(22, 278);
            this.lbNValue.Name = "lbNValue";
            this.lbNValue.Size = new System.Drawing.Size(17, 15);
            this.lbNValue.TabIndex = 16;
            this.lbNValue.Text = "n:";
            // 
            // tpBestFirstSearch
            // 
            this.tpBestFirstSearch.BackColor = System.Drawing.SystemColors.Control;
            this.tpBestFirstSearch.Controls.Add(this.lbHeuristic);
            this.tpBestFirstSearch.Controls.Add(this.cbHeuristic);
            this.tpBestFirstSearch.Controls.Add(this.rtbResultBestFirstSearch);
            this.tpBestFirstSearch.Controls.Add(this.txbDurationBestFirstSearch);
            this.tpBestFirstSearch.Controls.Add(this.txbSearchedStatesBestFirstSearch);
            this.tpBestFirstSearch.Controls.Add(this.txbCreatedStatesBestFirstSearch);
            this.tpBestFirstSearch.Controls.Add(this.btnNormalBestFirstSearch);
            this.tpBestFirstSearch.Controls.Add(this.btnCutBranchesBestFirstSearch);
            this.tpBestFirstSearch.Controls.Add(this.lbCreatedStatesBestFirstSearch);
            this.tpBestFirstSearch.Controls.Add(this.lbSearchedStatesBestFirstSearch);
            this.tpBestFirstSearch.Controls.Add(this.lbDurationBestFirstSearch);
            this.tpBestFirstSearch.Location = new System.Drawing.Point(4, 24);
            this.tpBestFirstSearch.Name = "tpBestFirstSearch";
            this.tpBestFirstSearch.Size = new System.Drawing.Size(393, 230);
            this.tpBestFirstSearch.TabIndex = 2;
            this.tpBestFirstSearch.Text = "Best First Search";
            // 
            // lbHeuristic
            // 
            this.lbHeuristic.AutoSize = true;
            this.lbHeuristic.Location = new System.Drawing.Point(316, 183);
            this.lbHeuristic.Name = "lbHeuristic";
            this.lbHeuristic.Size = new System.Drawing.Size(69, 15);
            this.lbHeuristic.TabIndex = 23;
            this.lbHeuristic.Text = "Heurystyka:";
            // 
            // cbHeuristic
            // 
            this.cbHeuristic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHeuristic.FormattingEnabled = true;
            this.cbHeuristic.Items.AddRange(new object[] {
            "H1",
            "H2",
            "H3"});
            this.cbHeuristic.Location = new System.Drawing.Point(281, 201);
            this.cbHeuristic.Name = "cbHeuristic";
            this.cbHeuristic.Size = new System.Drawing.Size(105, 23);
            this.cbHeuristic.TabIndex = 22;
            // 
            // rtbResultBestFirstSearch
            // 
            this.rtbResultBestFirstSearch.Location = new System.Drawing.Point(6, 6);
            this.rtbResultBestFirstSearch.Name = "rtbResultBestFirstSearch";
            this.rtbResultBestFirstSearch.Size = new System.Drawing.Size(269, 156);
            this.rtbResultBestFirstSearch.TabIndex = 14;
            this.rtbResultBestFirstSearch.Text = "";
            // 
            // txbDurationBestFirstSearch
            // 
            this.txbDurationBestFirstSearch.Location = new System.Drawing.Point(281, 27);
            this.txbDurationBestFirstSearch.Name = "txbDurationBestFirstSearch";
            this.txbDurationBestFirstSearch.ReadOnly = true;
            this.txbDurationBestFirstSearch.Size = new System.Drawing.Size(104, 23);
            this.txbDurationBestFirstSearch.TabIndex = 16;
            // 
            // txbSearchedStatesBestFirstSearch
            // 
            this.txbSearchedStatesBestFirstSearch.Location = new System.Drawing.Point(281, 83);
            this.txbSearchedStatesBestFirstSearch.Name = "txbSearchedStatesBestFirstSearch";
            this.txbSearchedStatesBestFirstSearch.ReadOnly = true;
            this.txbSearchedStatesBestFirstSearch.Size = new System.Drawing.Size(104, 23);
            this.txbSearchedStatesBestFirstSearch.TabIndex = 17;
            // 
            // txbCreatedStatesBestFirstSearch
            // 
            this.txbCreatedStatesBestFirstSearch.Location = new System.Drawing.Point(281, 139);
            this.txbCreatedStatesBestFirstSearch.Name = "txbCreatedStatesBestFirstSearch";
            this.txbCreatedStatesBestFirstSearch.ReadOnly = true;
            this.txbCreatedStatesBestFirstSearch.Size = new System.Drawing.Size(104, 23);
            this.txbCreatedStatesBestFirstSearch.TabIndex = 18;
            // 
            // btnNormalBestFirstSearch
            // 
            this.btnNormalBestFirstSearch.Location = new System.Drawing.Point(6, 168);
            this.btnNormalBestFirstSearch.Name = "btnNormalBestFirstSearch";
            this.btnNormalBestFirstSearch.Size = new System.Drawing.Size(121, 56);
            this.btnNormalBestFirstSearch.TabIndex = 13;
            this.btnNormalBestFirstSearch.Text = "Normaly";
            this.btnNormalBestFirstSearch.UseVisualStyleBackColor = true;
            this.btnNormalBestFirstSearch.Click += new System.EventHandler(this.btnNormalBestFirstSearch_Click);
            // 
            // btnCutBranchesBestFirstSearch
            // 
            this.btnCutBranchesBestFirstSearch.Location = new System.Drawing.Point(154, 168);
            this.btnCutBranchesBestFirstSearch.Name = "btnCutBranchesBestFirstSearch";
            this.btnCutBranchesBestFirstSearch.Size = new System.Drawing.Size(121, 56);
            this.btnCutBranchesBestFirstSearch.TabIndex = 15;
            this.btnCutBranchesBestFirstSearch.Text = "Odcinanie gałęzi";
            this.btnCutBranchesBestFirstSearch.UseVisualStyleBackColor = true;
            this.btnCutBranchesBestFirstSearch.Click += new System.EventHandler(this.btnCutBranchesBestFirstSearch_Click);
            // 
            // lbCreatedStatesBestFirstSearch
            // 
            this.lbCreatedStatesBestFirstSearch.AutoSize = true;
            this.lbCreatedStatesBestFirstSearch.Location = new System.Drawing.Point(291, 121);
            this.lbCreatedStatesBestFirstSearch.Name = "lbCreatedStatesBestFirstSearch";
            this.lbCreatedStatesBestFirstSearch.Size = new System.Drawing.Size(98, 15);
            this.lbCreatedStatesBestFirstSearch.TabIndex = 21;
            this.lbCreatedStatesBestFirstSearch.Text = "Utworzone stany:";
            // 
            // lbSearchedStatesBestFirstSearch
            // 
            this.lbSearchedStatesBestFirstSearch.AutoSize = true;
            this.lbSearchedStatesBestFirstSearch.Location = new System.Drawing.Point(280, 65);
            this.lbSearchedStatesBestFirstSearch.Name = "lbSearchedStatesBestFirstSearch";
            this.lbSearchedStatesBestFirstSearch.Size = new System.Drawing.Size(105, 15);
            this.lbSearchedStatesBestFirstSearch.TabIndex = 20;
            this.lbSearchedStatesBestFirstSearch.Text = "Przeszukane stany:";
            // 
            // lbDurationBestFirstSearch
            // 
            this.lbDurationBestFirstSearch.AutoSize = true;
            this.lbDurationBestFirstSearch.Location = new System.Drawing.Point(291, 9);
            this.lbDurationBestFirstSearch.Name = "lbDurationBestFirstSearch";
            this.lbDurationBestFirstSearch.Size = new System.Drawing.Size(94, 15);
            this.lbDurationBestFirstSearch.TabIndex = 19;
            this.lbDurationBestFirstSearch.Text = "Czas wykonania:";
            // 
            // tpDFT
            // 
            this.tpDFT.BackColor = System.Drawing.SystemColors.Control;
            this.tpDFT.Controls.Add(this.rtbResultDFS);
            this.tpDFT.Controls.Add(this.txbDurationDFS);
            this.tpDFT.Controls.Add(this.txbSearchedStatesDFS);
            this.tpDFT.Controls.Add(this.txbCreatedStatesDFS);
            this.tpDFT.Controls.Add(this.btnNormalDFS);
            this.tpDFT.Controls.Add(this.btnCutBranchesDFS);
            this.tpDFT.Controls.Add(this.lbCreatedStatesDFS);
            this.tpDFT.Controls.Add(this.lbSearchedStatesDFS);
            this.tpDFT.Controls.Add(this.lbDurationDFS);
            this.tpDFT.Location = new System.Drawing.Point(4, 24);
            this.tpDFT.Name = "tpDFT";
            this.tpDFT.Padding = new System.Windows.Forms.Padding(3);
            this.tpDFT.Size = new System.Drawing.Size(393, 230);
            this.tpDFT.TabIndex = 1;
            this.tpDFT.Text = "DFS";
            // 
            // rtbResultDFS
            // 
            this.rtbResultDFS.Location = new System.Drawing.Point(6, 6);
            this.rtbResultDFS.Name = "rtbResultDFS";
            this.rtbResultDFS.Size = new System.Drawing.Size(269, 156);
            this.rtbResultDFS.TabIndex = 16;
            this.rtbResultDFS.Text = "";
            // 
            // txbDurationDFS
            // 
            this.txbDurationDFS.Location = new System.Drawing.Point(281, 27);
            this.txbDurationDFS.Name = "txbDurationDFS";
            this.txbDurationDFS.ReadOnly = true;
            this.txbDurationDFS.Size = new System.Drawing.Size(104, 23);
            this.txbDurationDFS.TabIndex = 19;
            // 
            // txbSearchedStatesDFS
            // 
            this.txbSearchedStatesDFS.Location = new System.Drawing.Point(281, 83);
            this.txbSearchedStatesDFS.Name = "txbSearchedStatesDFS";
            this.txbSearchedStatesDFS.ReadOnly = true;
            this.txbSearchedStatesDFS.Size = new System.Drawing.Size(104, 23);
            this.txbSearchedStatesDFS.TabIndex = 20;
            // 
            // txbCreatedStatesDFS
            // 
            this.txbCreatedStatesDFS.Location = new System.Drawing.Point(281, 139);
            this.txbCreatedStatesDFS.Name = "txbCreatedStatesDFS";
            this.txbCreatedStatesDFS.ReadOnly = true;
            this.txbCreatedStatesDFS.Size = new System.Drawing.Size(104, 23);
            this.txbCreatedStatesDFS.TabIndex = 21;
            // 
            // btnNormalDFS
            // 
            this.btnNormalDFS.Location = new System.Drawing.Point(6, 168);
            this.btnNormalDFS.Name = "btnNormalDFS";
            this.btnNormalDFS.Size = new System.Drawing.Size(121, 56);
            this.btnNormalDFS.TabIndex = 15;
            this.btnNormalDFS.Text = "Normaly";
            this.btnNormalDFS.UseVisualStyleBackColor = true;
            this.btnNormalDFS.Click += new System.EventHandler(this.btnNormalDFS_Click);
            // 
            // btnCutBranchesDFS
            // 
            this.btnCutBranchesDFS.Location = new System.Drawing.Point(154, 168);
            this.btnCutBranchesDFS.Name = "btnCutBranchesDFS";
            this.btnCutBranchesDFS.Size = new System.Drawing.Size(121, 56);
            this.btnCutBranchesDFS.TabIndex = 17;
            this.btnCutBranchesDFS.Text = "Odcinanie gałęzi";
            this.btnCutBranchesDFS.UseVisualStyleBackColor = true;
            this.btnCutBranchesDFS.Click += new System.EventHandler(this.btnCutBranchesDFS_Click);
            // 
            // lbCreatedStatesDFS
            // 
            this.lbCreatedStatesDFS.AutoSize = true;
            this.lbCreatedStatesDFS.Location = new System.Drawing.Point(291, 121);
            this.lbCreatedStatesDFS.Name = "lbCreatedStatesDFS";
            this.lbCreatedStatesDFS.Size = new System.Drawing.Size(98, 15);
            this.lbCreatedStatesDFS.TabIndex = 24;
            this.lbCreatedStatesDFS.Text = "Utworzone stany:";
            // 
            // lbSearchedStatesDFS
            // 
            this.lbSearchedStatesDFS.AutoSize = true;
            this.lbSearchedStatesDFS.Location = new System.Drawing.Point(280, 65);
            this.lbSearchedStatesDFS.Name = "lbSearchedStatesDFS";
            this.lbSearchedStatesDFS.Size = new System.Drawing.Size(105, 15);
            this.lbSearchedStatesDFS.TabIndex = 23;
            this.lbSearchedStatesDFS.Text = "Przeszukane stany:";
            // 
            // lbDurationDFS
            // 
            this.lbDurationDFS.AutoSize = true;
            this.lbDurationDFS.Location = new System.Drawing.Point(291, 9);
            this.lbDurationDFS.Name = "lbDurationDFS";
            this.lbDurationDFS.Size = new System.Drawing.Size(94, 15);
            this.lbDurationDFS.TabIndex = 22;
            this.lbDurationDFS.Text = "Czas wykonania:";
            // 
            // tpBFT
            // 
            this.tpBFT.BackColor = System.Drawing.SystemColors.Control;
            this.tpBFT.Controls.Add(this.rtbResultBFS);
            this.tpBFT.Controls.Add(this.txbDurationBFS);
            this.tpBFT.Controls.Add(this.txbSearchedStatesBFS);
            this.tpBFT.Controls.Add(this.txbCreatedStatesBFS);
            this.tpBFT.Controls.Add(this.btnNormalBFS);
            this.tpBFT.Controls.Add(this.btnCutBranchesBFS);
            this.tpBFT.Controls.Add(this.lbCreatedStatesBFS);
            this.tpBFT.Controls.Add(this.lbSearchedStatesBFS);
            this.tpBFT.Controls.Add(this.lbDurationBFS);
            this.tpBFT.Location = new System.Drawing.Point(4, 24);
            this.tpBFT.Name = "tpBFT";
            this.tpBFT.Padding = new System.Windows.Forms.Padding(3);
            this.tpBFT.Size = new System.Drawing.Size(393, 230);
            this.tpBFT.TabIndex = 0;
            this.tpBFT.Text = "BFS";
            // 
            // rtbResultBFS
            // 
            this.rtbResultBFS.Location = new System.Drawing.Point(6, 6);
            this.rtbResultBFS.Name = "rtbResultBFS";
            this.rtbResultBFS.Size = new System.Drawing.Size(269, 156);
            this.rtbResultBFS.TabIndex = 2;
            this.rtbResultBFS.Text = "";
            // 
            // txbDurationBFS
            // 
            this.txbDurationBFS.Location = new System.Drawing.Point(281, 27);
            this.txbDurationBFS.Name = "txbDurationBFS";
            this.txbDurationBFS.ReadOnly = true;
            this.txbDurationBFS.Size = new System.Drawing.Size(104, 23);
            this.txbDurationBFS.TabIndex = 7;
            // 
            // txbSearchedStatesBFS
            // 
            this.txbSearchedStatesBFS.Location = new System.Drawing.Point(281, 83);
            this.txbSearchedStatesBFS.Name = "txbSearchedStatesBFS";
            this.txbSearchedStatesBFS.ReadOnly = true;
            this.txbSearchedStatesBFS.Size = new System.Drawing.Size(104, 23);
            this.txbSearchedStatesBFS.TabIndex = 8;
            // 
            // txbCreatedStatesBFS
            // 
            this.txbCreatedStatesBFS.Location = new System.Drawing.Point(281, 139);
            this.txbCreatedStatesBFS.Name = "txbCreatedStatesBFS";
            this.txbCreatedStatesBFS.ReadOnly = true;
            this.txbCreatedStatesBFS.Size = new System.Drawing.Size(104, 23);
            this.txbCreatedStatesBFS.TabIndex = 9;
            // 
            // btnNormalBFS
            // 
            this.btnNormalBFS.Location = new System.Drawing.Point(6, 168);
            this.btnNormalBFS.Name = "btnNormalBFS";
            this.btnNormalBFS.Size = new System.Drawing.Size(121, 56);
            this.btnNormalBFS.TabIndex = 1;
            this.btnNormalBFS.Text = "Normaly";
            this.btnNormalBFS.UseVisualStyleBackColor = true;
            this.btnNormalBFS.Click += new System.EventHandler(this.btnNormalBFS_Click);
            // 
            // btnCutBranchesBFS
            // 
            this.btnCutBranchesBFS.Location = new System.Drawing.Point(154, 168);
            this.btnCutBranchesBFS.Name = "btnCutBranchesBFS";
            this.btnCutBranchesBFS.Size = new System.Drawing.Size(121, 56);
            this.btnCutBranchesBFS.TabIndex = 3;
            this.btnCutBranchesBFS.Text = "Odcinanie gałęzi";
            this.btnCutBranchesBFS.UseVisualStyleBackColor = true;
            this.btnCutBranchesBFS.Click += new System.EventHandler(this.btnCutBranchesBFS_Click);
            // 
            // lbCreatedStatesBFS
            // 
            this.lbCreatedStatesBFS.AutoSize = true;
            this.lbCreatedStatesBFS.Location = new System.Drawing.Point(291, 121);
            this.lbCreatedStatesBFS.Name = "lbCreatedStatesBFS";
            this.lbCreatedStatesBFS.Size = new System.Drawing.Size(98, 15);
            this.lbCreatedStatesBFS.TabIndex = 12;
            this.lbCreatedStatesBFS.Text = "Utworzone stany:";
            // 
            // lbSearchedStatesBFS
            // 
            this.lbSearchedStatesBFS.AutoSize = true;
            this.lbSearchedStatesBFS.Location = new System.Drawing.Point(280, 65);
            this.lbSearchedStatesBFS.Name = "lbSearchedStatesBFS";
            this.lbSearchedStatesBFS.Size = new System.Drawing.Size(105, 15);
            this.lbSearchedStatesBFS.TabIndex = 11;
            this.lbSearchedStatesBFS.Text = "Przeszukane stany:";
            // 
            // lbDurationBFS
            // 
            this.lbDurationBFS.AutoSize = true;
            this.lbDurationBFS.Location = new System.Drawing.Point(291, 9);
            this.lbDurationBFS.Name = "lbDurationBFS";
            this.lbDurationBFS.Size = new System.Drawing.Size(94, 15);
            this.lbDurationBFS.TabIndex = 10;
            this.lbDurationBFS.Text = "Czas wykonania:";
            // 
            // tcTabs
            // 
            this.tcTabs.Controls.Add(this.tpBFT);
            this.tcTabs.Controls.Add(this.tpDFT);
            this.tcTabs.Controls.Add(this.tpBestFirstSearch);
            this.tcTabs.Controls.Add(this.tpGenetic);
            this.tcTabs.Location = new System.Drawing.Point(12, 12);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(401, 258);
            this.tcTabs.TabIndex = 15;
            // 
            // tpGenetic
            // 
            this.tpGenetic.BackColor = System.Drawing.SystemColors.Control;
            this.tpGenetic.Controls.Add(this.nudCrossover);
            this.tpGenetic.Controls.Add(this.nudMutation);
            this.tpGenetic.Controls.Add(this.nudGen);
            this.tpGenetic.Controls.Add(this.nudPop);
            this.tpGenetic.Controls.Add(this.genLbMutation);
            this.tpGenetic.Controls.Add(this.genLbCrossover);
            this.tpGenetic.Controls.Add(this.genLbGenerations);
            this.tpGenetic.Controls.Add(this.genLbPop);
            this.tpGenetic.Controls.Add(this.txbBestValue);
            this.tpGenetic.Controls.Add(this.genLbBestValue);
            this.tpGenetic.Controls.Add(this.txbBest);
            this.tpGenetic.Controls.Add(this.txbGen);
            this.tpGenetic.Controls.Add(this.genLbCnt);
            this.tpGenetic.Controls.Add(this.genLbBest);
            this.tpGenetic.Controls.Add(this.btnGen);
            this.tpGenetic.Location = new System.Drawing.Point(4, 24);
            this.tpGenetic.Name = "tpGenetic";
            this.tpGenetic.Size = new System.Drawing.Size(393, 230);
            this.tpGenetic.TabIndex = 3;
            this.tpGenetic.Text = "Genetic";
            // 
            // nudCrossover
            // 
            this.nudCrossover.DecimalPlaces = 2;
            this.nudCrossover.Location = new System.Drawing.Point(263, 15);
            this.nudCrossover.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCrossover.Name = "nudCrossover";
            this.nudCrossover.Size = new System.Drawing.Size(63, 23);
            this.nudCrossover.TabIndex = 37;
            // 
            // nudMutation
            // 
            this.nudMutation.DecimalPlaces = 2;
            this.nudMutation.Location = new System.Drawing.Point(263, 63);
            this.nudMutation.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMutation.Name = "nudMutation";
            this.nudMutation.Size = new System.Drawing.Size(63, 23);
            this.nudMutation.TabIndex = 36;
            // 
            // nudGen
            // 
            this.nudGen.Location = new System.Drawing.Point(88, 61);
            this.nudGen.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudGen.Name = "nudGen";
            this.nudGen.Size = new System.Drawing.Size(63, 23);
            this.nudGen.TabIndex = 34;
            // 
            // nudPop
            // 
            this.nudPop.Location = new System.Drawing.Point(88, 13);
            this.nudPop.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPop.Name = "nudPop";
            this.nudPop.Size = new System.Drawing.Size(63, 23);
            this.nudPop.TabIndex = 33;
            // 
            // genLbMutation
            // 
            this.genLbMutation.AutoSize = true;
            this.genLbMutation.Location = new System.Drawing.Point(198, 56);
            this.genLbMutation.Name = "genLbMutation";
            this.genLbMutation.Size = new System.Drawing.Size(56, 30);
            this.genLbMutation.TabIndex = 26;
            this.genLbMutation.Text = "Mutation\r\nfactor:";
            // 
            // genLbCrossover
            // 
            this.genLbCrossover.AutoSize = true;
            this.genLbCrossover.Location = new System.Drawing.Point(198, 8);
            this.genLbCrossover.Name = "genLbCrossover";
            this.genLbCrossover.Size = new System.Drawing.Size(59, 30);
            this.genLbCrossover.TabIndex = 25;
            this.genLbCrossover.Text = "Crossover\r\nfactor:";
            // 
            // genLbGenerations
            // 
            this.genLbGenerations.AutoSize = true;
            this.genLbGenerations.Location = new System.Drawing.Point(9, 63);
            this.genLbGenerations.Name = "genLbGenerations";
            this.genLbGenerations.Size = new System.Drawing.Size(73, 15);
            this.genLbGenerations.TabIndex = 22;
            this.genLbGenerations.Text = "Generations:";
            // 
            // genLbPop
            // 
            this.genLbPop.AutoSize = true;
            this.genLbPop.Location = new System.Drawing.Point(14, 17);
            this.genLbPop.Name = "genLbPop";
            this.genLbPop.Size = new System.Drawing.Size(68, 15);
            this.genLbPop.TabIndex = 21;
            this.genLbPop.Text = "Population:";
            // 
            // txbBestValue
            // 
            this.txbBestValue.Location = new System.Drawing.Point(279, 97);
            this.txbBestValue.Name = "txbBestValue";
            this.txbBestValue.ReadOnly = true;
            this.txbBestValue.Size = new System.Drawing.Size(104, 23);
            this.txbBestValue.TabIndex = 20;
            // 
            // genLbBestValue
            // 
            this.genLbBestValue.AutoSize = true;
            this.genLbBestValue.Location = new System.Drawing.Point(198, 100);
            this.genLbBestValue.Name = "genLbBestValue";
            this.genLbBestValue.Size = new System.Drawing.Size(77, 15);
            this.genLbBestValue.TabIndex = 19;
            this.genLbBestValue.Text = "Value of best:";
            // 
            // txbBest
            // 
            this.txbBest.Location = new System.Drawing.Point(88, 97);
            this.txbBest.Multiline = true;
            this.txbBest.Name = "txbBest";
            this.txbBest.ReadOnly = true;
            this.txbBest.Size = new System.Drawing.Size(104, 65);
            this.txbBest.TabIndex = 18;
            // 
            // txbGen
            // 
            this.txbGen.Location = new System.Drawing.Point(279, 139);
            this.txbGen.Name = "txbGen";
            this.txbGen.ReadOnly = true;
            this.txbGen.Size = new System.Drawing.Size(104, 23);
            this.txbGen.TabIndex = 17;
            // 
            // genLbCnt
            // 
            this.genLbCnt.AutoSize = true;
            this.genLbCnt.Location = new System.Drawing.Point(205, 132);
            this.genLbCnt.Name = "genLbCnt";
            this.genLbCnt.Size = new System.Drawing.Size(72, 30);
            this.genLbCnt.TabIndex = 16;
            this.genLbCnt.Text = "Number of\r\ngenerations:\r\n";
            // 
            // genLbBest
            // 
            this.genLbBest.AutoSize = true;
            this.genLbBest.Location = new System.Drawing.Point(50, 100);
            this.genLbBest.Name = "genLbBest";
            this.genLbBest.Size = new System.Drawing.Size(32, 15);
            this.genLbBest.TabIndex = 15;
            this.genLbBest.Text = "Best:";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(6, 168);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(377, 56);
            this.btnGen.TabIndex = 14;
            this.btnGen.Text = "Start";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // nQueens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 316);
            this.Controls.Add(this.cbTestMulti);
            this.Controls.Add(this.nudNValue);
            this.Controls.Add(this.lbNValue);
            this.Controls.Add(this.tcTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "nQueens";
            this.Text = "n-hetmanów";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNValue)).EndInit();
            this.tpBestFirstSearch.ResumeLayout(false);
            this.tpBestFirstSearch.PerformLayout();
            this.tpDFT.ResumeLayout(false);
            this.tpDFT.PerformLayout();
            this.tpBFT.ResumeLayout(false);
            this.tpBFT.PerformLayout();
            this.tcTabs.ResumeLayout(false);
            this.tpGenetic.ResumeLayout(false);
            this.tpGenetic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCrossover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.CheckBox cbTestMulti;
        private System.Windows.Forms.NumericUpDown nudNValue;
        private System.Windows.Forms.Label lbNValue;
        private System.Windows.Forms.TabPage tpBestFirstSearch;
        private System.Windows.Forms.Label lbHeuristic;
        private System.Windows.Forms.ComboBox cbHeuristic;
        private System.Windows.Forms.RichTextBox rtbResultBestFirstSearch;
        private System.Windows.Forms.TextBox txbDurationBestFirstSearch;
        private System.Windows.Forms.TextBox txbSearchedStatesBestFirstSearch;
        private System.Windows.Forms.TextBox txbCreatedStatesBestFirstSearch;
        private System.Windows.Forms.Button btnNormalBestFirstSearch;
        private System.Windows.Forms.Button btnCutBranchesBestFirstSearch;
        private System.Windows.Forms.Label lbCreatedStatesBestFirstSearch;
        private System.Windows.Forms.Label lbSearchedStatesBestFirstSearch;
        private System.Windows.Forms.Label lbDurationBestFirstSearch;
        private System.Windows.Forms.TabPage tpDFT;
        private System.Windows.Forms.RichTextBox rtbResultDFS;
        private System.Windows.Forms.TextBox txbDurationDFS;
        private System.Windows.Forms.TextBox txbSearchedStatesDFS;
        private System.Windows.Forms.TextBox txbCreatedStatesDFS;
        private System.Windows.Forms.Button btnNormalDFS;
        private System.Windows.Forms.Button btnCutBranchesDFS;
        private System.Windows.Forms.Label lbCreatedStatesDFS;
        private System.Windows.Forms.Label lbSearchedStatesDFS;
        private System.Windows.Forms.Label lbDurationDFS;
        private System.Windows.Forms.TabPage tpBFT;
        private System.Windows.Forms.RichTextBox rtbResultBFS;
        private System.Windows.Forms.TextBox txbDurationBFS;
        private System.Windows.Forms.TextBox txbSearchedStatesBFS;
        private System.Windows.Forms.TextBox txbCreatedStatesBFS;
        private System.Windows.Forms.Button btnNormalBFS;
        private System.Windows.Forms.Button btnCutBranchesBFS;
        private System.Windows.Forms.Label lbCreatedStatesBFS;
        private System.Windows.Forms.Label lbSearchedStatesBFS;
        private System.Windows.Forms.Label lbDurationBFS;
        private System.Windows.Forms.TabControl tcTabs;
        private System.Windows.Forms.TabPage tpGenetic;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Label genLbBest;
        private System.Windows.Forms.Label genLbCnt;
        private System.Windows.Forms.TextBox txbBest;
        private System.Windows.Forms.TextBox txbGen;
        private System.Windows.Forms.TextBox txbBestValue;
        private System.Windows.Forms.Label genLbBestValue;
        private System.Windows.Forms.Label genLbMutation;
        private System.Windows.Forms.Label genLbCrossover;
        private System.Windows.Forms.Label genLbGenerations;
        private System.Windows.Forms.Label genLbPop;
        private System.Windows.Forms.NumericUpDown nudPop;
        private System.Windows.Forms.NumericUpDown nudCrossover;
        private System.Windows.Forms.NumericUpDown nudMutation;
        private System.Windows.Forms.NumericUpDown nudGen;
    }
}


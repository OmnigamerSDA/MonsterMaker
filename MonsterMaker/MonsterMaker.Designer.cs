namespace MonsterMaker
{
    partial class MakerForm
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
            this.fileBox = new System.Windows.Forms.TextBox();
            this.browserButton = new System.Windows.Forms.Button();
            this.statsView = new System.Windows.Forms.DataGridView();
            this.StatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seed1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seed2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type1Box = new System.Windows.Forms.ComboBox();
            this.seed1Box = new System.Windows.Forms.NumericUpDown();
            this.seed2Box = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.subtypeLabel = new System.Windows.Forms.Label();
            this.makeButton = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.statsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed1Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed2Box)).BeginInit();
            this.SuspendLayout();
            // 
            // fileBox
            // 
            this.fileBox.Location = new System.Drawing.Point(45, 39);
            this.fileBox.Name = "fileBox";
            this.fileBox.Size = new System.Drawing.Size(174, 20);
            this.fileBox.TabIndex = 0;
            // 
            // browserButton
            // 
            this.browserButton.Location = new System.Drawing.Point(225, 37);
            this.browserButton.Name = "browserButton";
            this.browserButton.Size = new System.Drawing.Size(75, 23);
            this.browserButton.TabIndex = 1;
            this.browserButton.Text = "Browse...";
            this.browserButton.UseVisualStyleBackColor = true;
            this.browserButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // statsView
            // 
            this.statsView.AllowUserToAddRows = false;
            this.statsView.AllowUserToDeleteRows = false;
            this.statsView.AllowUserToResizeColumns = false;
            this.statsView.AllowUserToResizeRows = false;
            this.statsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StatColumn,
            this.BaseColumn,
            this.Seed1Column,
            this.Seed2Column,
            this.FinalColumn});
            this.statsView.Location = new System.Drawing.Point(12, 192);
            this.statsView.Name = "statsView";
            this.statsView.ReadOnly = true;
            this.statsView.RowHeadersVisible = false;
            this.statsView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.statsView.Size = new System.Drawing.Size(506, 205);
            this.statsView.TabIndex = 2;
            // 
            // StatColumn
            // 
            this.StatColumn.HeaderText = "Stat";
            this.StatColumn.Name = "StatColumn";
            this.StatColumn.ReadOnly = true;
            // 
            // BaseColumn
            // 
            this.BaseColumn.HeaderText = "Base";
            this.BaseColumn.Name = "BaseColumn";
            this.BaseColumn.ReadOnly = true;
            // 
            // Seed1Column
            // 
            this.Seed1Column.HeaderText = "Seed 1";
            this.Seed1Column.Name = "Seed1Column";
            this.Seed1Column.ReadOnly = true;
            // 
            // Seed2Column
            // 
            this.Seed2Column.HeaderText = "Seed 2";
            this.Seed2Column.Name = "Seed2Column";
            this.Seed2Column.ReadOnly = true;
            // 
            // FinalColumn
            // 
            this.FinalColumn.HeaderText = "Final";
            this.FinalColumn.Name = "FinalColumn";
            this.FinalColumn.ReadOnly = true;
            // 
            // type1Box
            // 
            this.type1Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type1Box.FormattingEnabled = true;
            this.type1Box.Location = new System.Drawing.Point(45, 97);
            this.type1Box.Name = "type1Box";
            this.type1Box.Size = new System.Drawing.Size(174, 28);
            this.type1Box.TabIndex = 3;
            this.type1Box.SelectedIndexChanged += new System.EventHandler(this.type1Box_SelectedIndexChanged);
            // 
            // seed1Box
            // 
            this.seed1Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seed1Box.Location = new System.Drawing.Point(45, 154);
            this.seed1Box.Maximum = new decimal(new int[] {
            39,
            0,
            0,
            0});
            this.seed1Box.Name = "seed1Box";
            this.seed1Box.Size = new System.Drawing.Size(174, 26);
            this.seed1Box.TabIndex = 4;
            this.seed1Box.ValueChanged += new System.EventHandler(this.seed1Box_ValueChanged);
            // 
            // seed2Box
            // 
            this.seed2Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seed2Box.Location = new System.Drawing.Point(278, 154);
            this.seed2Box.Maximum = new decimal(new int[] {
            39,
            0,
            0,
            0});
            this.seed2Box.Name = "seed2Box";
            this.seed2Box.Size = new System.Drawing.Size(174, 26);
            this.seed2Box.TabIndex = 5;
            this.seed2Box.ValueChanged += new System.EventHandler(this.seed2Box_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Primary Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stat Seed 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stat Seed 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Subtype";
            // 
            // subtypeLabel
            // 
            this.subtypeLabel.AutoSize = true;
            this.subtypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtypeLabel.Location = new System.Drawing.Point(277, 100);
            this.subtypeLabel.Name = "subtypeLabel";
            this.subtypeLabel.Size = new System.Drawing.Size(46, 20);
            this.subtypeLabel.TabIndex = 12;
            this.subtypeLabel.Text = "Dino";
            // 
            // makeButton
            // 
            this.makeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeButton.Location = new System.Drawing.Point(362, 22);
            this.makeButton.Name = "makeButton";
            this.makeButton.Size = new System.Drawing.Size(155, 50);
            this.makeButton.TabIndex = 13;
            this.makeButton.Text = "Make Monster!";
            this.makeButton.UseVisualStyleBackColor = true;
            this.makeButton.Click += new System.EventHandler(this.makeButton_Click);
            // 
            // MakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 406);
            this.Controls.Add(this.makeButton);
            this.Controls.Add(this.subtypeLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seed2Box);
            this.Controls.Add(this.seed1Box);
            this.Controls.Add(this.type1Box);
            this.Controls.Add(this.statsView);
            this.Controls.Add(this.browserButton);
            this.Controls.Add(this.fileBox);
            this.Name = "MakerForm";
            this.Text = "MonsterMaker";
            ((System.ComponentModel.ISupportInitialize)(this.statsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed1Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seed2Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileBox;
        private System.Windows.Forms.Button browserButton;
        private System.Windows.Forms.DataGridView statsView;
        private System.Windows.Forms.ComboBox type1Box;
        private System.Windows.Forms.NumericUpDown seed1Box;
        private System.Windows.Forms.NumericUpDown seed2Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label subtypeLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seed1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seed2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalColumn;
        private System.Windows.Forms.Button makeButton;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}



namespace WeAreTheChampions
{
    partial class New_Match
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
            this.cboHomeTeams = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblHomeTeams = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudHomeTeamScore = new System.Windows.Forms.NumericUpDown();
            this.nudAwayTeamScore = new System.Windows.Forms.NumericUpDown();
            this.btnMatchAdd = new System.Windows.Forms.Button();
            this.cboAwayTeams = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHomeTeamScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAwayTeamScore)).BeginInit();
            this.SuspendLayout();
            // 
            // cboHomeTeams
            // 
            this.cboHomeTeams.DisplayMember = "TeamName";
            this.cboHomeTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHomeTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboHomeTeams.FormattingEnabled = true;
            this.cboHomeTeams.Location = new System.Drawing.Point(13, 67);
            this.cboHomeTeams.Margin = new System.Windows.Forms.Padding(2);
            this.cboHomeTeams.Name = "cboHomeTeams";
            this.cboHomeTeams.Size = new System.Drawing.Size(171, 28);
            this.cboHomeTeams.TabIndex = 0;
            this.cboHomeTeams.ValueMember = "Id";
            this.cboHomeTeams.SelectedIndexChanged += new System.EventHandler(this.cboHomeTeams_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "ddMMMMyyyy | HH:mm";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(200, 66);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(205, 26);
            this.dtpDate.TabIndex = 2;
            // 
            // lblHomeTeams
            // 
            this.lblHomeTeams.AutoSize = true;
            this.lblHomeTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHomeTeams.Location = new System.Drawing.Point(9, 45);
            this.lblHomeTeams.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomeTeams.Name = "lblHomeTeams";
            this.lblHomeTeams.Size = new System.Drawing.Size(96, 20);
            this.lblHomeTeams.TabIndex = 3;
            this.lblHomeTeams.Text = "Home Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(217, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Match Day and Hours";
            // 
            // nudHomeTeamScore
            // 
            this.nudHomeTeamScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudHomeTeamScore.Location = new System.Drawing.Point(134, 132);
            this.nudHomeTeamScore.Margin = new System.Windows.Forms.Padding(2);
            this.nudHomeTeamScore.Name = "nudHomeTeamScore";
            this.nudHomeTeamScore.Size = new System.Drawing.Size(56, 26);
            this.nudHomeTeamScore.TabIndex = 6;
            // 
            // nudAwayTeamScore
            // 
            this.nudAwayTeamScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudAwayTeamScore.Location = new System.Drawing.Point(398, 132);
            this.nudAwayTeamScore.Margin = new System.Windows.Forms.Padding(2);
            this.nudAwayTeamScore.Name = "nudAwayTeamScore";
            this.nudAwayTeamScore.Size = new System.Drawing.Size(56, 26);
            this.nudAwayTeamScore.TabIndex = 7;
            // 
            // btnMatchAdd
            // 
            this.btnMatchAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMatchAdd.Location = new System.Drawing.Point(221, 219);
            this.btnMatchAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnMatchAdd.Name = "btnMatchAdd";
            this.btnMatchAdd.Size = new System.Drawing.Size(168, 41);
            this.btnMatchAdd.TabIndex = 8;
            this.btnMatchAdd.Text = "Match Add";
            this.btnMatchAdd.UseVisualStyleBackColor = true;
            this.btnMatchAdd.Click += new System.EventHandler(this.btnMatchAdd_Click);
            // 
            // cboAwayTeams
            // 
            this.cboAwayTeams.DisplayMember = "TeamName";
            this.cboAwayTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAwayTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboAwayTeams.FormattingEnabled = true;
            this.cboAwayTeams.Location = new System.Drawing.Point(421, 66);
            this.cboAwayTeams.Margin = new System.Windows.Forms.Padding(2);
            this.cboAwayTeams.Name = "cboAwayTeams";
            this.cboAwayTeams.Size = new System.Drawing.Size(171, 28);
            this.cboAwayTeams.TabIndex = 9;
            this.cboAwayTeams.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(417, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Away Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(242, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Match Score";
            // 
            // New_Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboAwayTeams);
            this.Controls.Add(this.btnMatchAdd);
            this.Controls.Add(this.nudAwayTeamScore);
            this.Controls.Add(this.nudHomeTeamScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHomeTeams);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cboHomeTeams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_Match";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New_Match";
            ((System.ComponentModel.ISupportInitialize)(this.nudHomeTeamScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAwayTeamScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboHomeTeams;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblHomeTeams;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudHomeTeamScore;
        private System.Windows.Forms.NumericUpDown nudAwayTeamScore;
        private System.Windows.Forms.Button btnMatchAdd;
        private System.Windows.Forms.ComboBox cboAwayTeams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
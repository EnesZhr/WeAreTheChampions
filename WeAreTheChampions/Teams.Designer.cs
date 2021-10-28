
namespace WeAreTheChampions
{
    partial class Teams
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblColors2 = new System.Windows.Forms.Label();
            this.lblColors1 = new System.Windows.Forms.Label();
            this.dgvColors = new System.Windows.Forms.DataGridView();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.btnTeamAdd = new System.Windows.Forms.Button();
            this.dgvTeams = new System.Windows.Forms.DataGridView();
            this.btnTeamDelete = new System.Windows.Forms.Button();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblColors2);
            this.groupBox1.Controls.Add(this.lblColors1);
            this.groupBox1.Controls.Add(this.dgvColors);
            this.groupBox1.Controls.Add(this.txtTeamName);
            this.groupBox1.Controls.Add(this.btnTeamAdd);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(582, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teams Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Team Name:";
            // 
            // lblColors2
            // 
            this.lblColors2.BackColor = System.Drawing.Color.White;
            this.lblColors2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColors2.Location = new System.Drawing.Point(520, 34);
            this.lblColors2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColors2.Name = "lblColors2";
            this.lblColors2.Size = new System.Drawing.Size(52, 113);
            this.lblColors2.TabIndex = 8;
            this.lblColors2.Click += new System.EventHandler(this.lblColors2_Click);
            // 
            // lblColors1
            // 
            this.lblColors1.BackColor = System.Drawing.Color.White;
            this.lblColors1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColors1.Location = new System.Drawing.Point(464, 34);
            this.lblColors1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColors1.Name = "lblColors1";
            this.lblColors1.Size = new System.Drawing.Size(52, 113);
            this.lblColors1.TabIndex = 7;
            this.lblColors1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblColors1_MouseClick);
            // 
            // dgvColors
            // 
            this.dgvColors.AllowUserToAddRows = false;
            this.dgvColors.AllowUserToDeleteRows = false;
            this.dgvColors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvColors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5});
            this.dgvColors.Location = new System.Drawing.Point(230, 34);
            this.dgvColors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvColors.Name = "dgvColors";
            this.dgvColors.ReadOnly = true;
            this.dgvColors.RowHeadersWidth = 51;
            this.dgvColors.RowTemplate.Height = 24;
            this.dgvColors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColors.Size = new System.Drawing.Size(232, 162);
            this.dgvColors.TabIndex = 6;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTeamName.Location = new System.Drawing.Point(4, 57);
            this.txtTeamName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(204, 26);
            this.txtTeamName.TabIndex = 5;
            // 
            // btnTeamAdd
            // 
            this.btnTeamAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTeamAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeamAdd.Location = new System.Drawing.Point(466, 153);
            this.btnTeamAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTeamAdd.Name = "btnTeamAdd";
            this.btnTeamAdd.Size = new System.Drawing.Size(111, 43);
            this.btnTeamAdd.TabIndex = 3;
            this.btnTeamAdd.Text = "Team Add";
            this.btnTeamAdd.UseVisualStyleBackColor = true;
            this.btnTeamAdd.Click += new System.EventHandler(this.btnTeamAdd_Click);
            // 
            // dgvTeams
            // 
            this.dgvTeams.AllowUserToAddRows = false;
            this.dgvTeams.AllowUserToDeleteRows = false;
            this.dgvTeams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeams.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dgvTeams.Location = new System.Drawing.Point(9, 215);
            this.dgvTeams.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTeams.Name = "dgvTeams";
            this.dgvTeams.ReadOnly = true;
            this.dgvTeams.RowHeadersWidth = 51;
            this.dgvTeams.RowTemplate.Height = 24;
            this.dgvTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeams.Size = new System.Drawing.Size(582, 187);
            this.dgvTeams.TabIndex = 1;
            // 
            // btnTeamDelete
            // 
            this.btnTeamDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTeamDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeamDelete.Location = new System.Drawing.Point(480, 407);
            this.btnTeamDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTeamDelete.Name = "btnTeamDelete";
            this.btnTeamDelete.Size = new System.Drawing.Size(111, 43);
            this.btnTeamDelete.TabIndex = 2;
            this.btnTeamDelete.Text = "Team Delete";
            this.btnTeamDelete.UseVisualStyleBackColor = true;
            this.btnTeamDelete.Click += new System.EventHandler(this.btnTeamDelete_Click);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ColorName";
            this.Column5.HeaderText = "Renk Adı";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TeamName";
            this.Column2.HeaderText = "Teams Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 460);
            this.Controls.Add(this.btnTeamDelete);
            this.Controls.Add(this.dgvTeams);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Teams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Teams";
            this.Load += new System.EventHandler(this.Teams_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblColors1;
        private System.Windows.Forms.DataGridView dgvColors;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Button btnTeamAdd;
        private System.Windows.Forms.DataGridView dgvTeams;
        private System.Windows.Forms.Button btnTeamDelete;
        private System.Windows.Forms.Label lblColors2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
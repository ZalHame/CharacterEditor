namespace CharacterEditor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_FirstTeam = new System.Windows.Forms.ListBox();
            this.lb_AllChar = new System.Windows.Forms.ListBox();
            this.lb_SecondTeam = new System.Windows.Forms.ListBox();
            this.button_Autodistribution = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(105, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "First Team";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(475, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "All Characters";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(880, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 38);
            this.label3.TabIndex = 11;
            this.label3.Text = "Second Team";
            // 
            // lb_FirstTeam
            // 
            this.lb_FirstTeam.FormattingEnabled = true;
            this.lb_FirstTeam.ItemHeight = 16;
            this.lb_FirstTeam.Location = new System.Drawing.Point(68, 132);
            this.lb_FirstTeam.Name = "lb_FirstTeam";
            this.lb_FirstTeam.Size = new System.Drawing.Size(263, 292);
            this.lb_FirstTeam.TabIndex = 12;
            // 
            // lb_AllChar
            // 
            this.lb_AllChar.FormattingEnabled = true;
            this.lb_AllChar.ItemHeight = 16;
            this.lb_AllChar.Location = new System.Drawing.Point(461, 132);
            this.lb_AllChar.Name = "lb_AllChar";
            this.lb_AllChar.Size = new System.Drawing.Size(263, 292);
            this.lb_AllChar.TabIndex = 13;
            // 
            // lb_SecondTeam
            // 
            this.lb_SecondTeam.FormattingEnabled = true;
            this.lb_SecondTeam.ItemHeight = 16;
            this.lb_SecondTeam.Location = new System.Drawing.Point(867, 132);
            this.lb_SecondTeam.Name = "lb_SecondTeam";
            this.lb_SecondTeam.Size = new System.Drawing.Size(263, 292);
            this.lb_SecondTeam.TabIndex = 14;
            // 
            // button_Autodistribution
            // 
            this.button_Autodistribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Autodistribution.Location = new System.Drawing.Point(482, 461);
            this.button_Autodistribution.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Autodistribution.Name = "button_Autodistribution";
            this.button_Autodistribution.Size = new System.Drawing.Size(230, 46);
            this.button_Autodistribution.TabIndex = 60;
            this.button_Autodistribution.Text = "Autodistribution";
            this.button_Autodistribution.UseVisualStyleBackColor = true;
            this.button_Autodistribution.Click += new System.EventHandler(this.button_Autodistribution_Click);
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1206, 534);
            this.Controls.Add(this.button_Autodistribution);
            this.Controls.Add(this.lb_SecondTeam);
            this.Controls.Add(this.lb_AllChar);
            this.Controls.Add(this.lb_FirstTeam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Teams";
            this.Text = "Teams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb_FirstTeam;
        private System.Windows.Forms.ListBox lb_AllChar;
        private System.Windows.Forms.ListBox lb_SecondTeam;
        private System.Windows.Forms.Button button_Autodistribution;
    }
}
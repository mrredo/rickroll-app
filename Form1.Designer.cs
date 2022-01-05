namespace Windows_Helper
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
            this.ContinueButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RulesButton = new System.Windows.Forms.Button();
            this.RulesLabel = new System.Windows.Forms.Label();
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.enterSecretCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CodeTextBoxMenu = new System.Windows.Forms.ToolStripTextBox();
            this.CodeLabelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContinueButton
            // 
            this.ContinueButton.AutoSize = true;
            this.ContinueButton.BackColor = System.Drawing.SystemColors.Control;
            this.ContinueButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ContinueButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ContinueButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContinueButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ContinueButton.Location = new System.Drawing.Point(885, 587);
            this.ContinueButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(194, 82);
            this.ContinueButton.TabIndex = 1;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = false;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(826, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(350, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 186);
            this.label1.TabIndex = 2;
            this.label1.Text = "Let\'s play a game!\r\nTry to exit the app without getting rickrolled :)\r\nalso break" +
    "ing rules doesnt count\r\n\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 1013);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RulesButton
            // 
            this.RulesButton.BackColor = System.Drawing.SystemColors.Control;
            this.RulesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(255)))));
            this.RulesButton.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RulesButton.Location = new System.Drawing.Point(1548, 251);
            this.RulesButton.Name = "RulesButton";
            this.RulesButton.Size = new System.Drawing.Size(125, 52);
            this.RulesButton.TabIndex = 4;
            this.RulesButton.Text = "Rules";
            this.RulesButton.UseVisualStyleBackColor = false;
            this.RulesButton.Click += new System.EventHandler(this.RulesButton_Click);
            // 
            // RulesLabel
            // 
            this.RulesLabel.AutoSize = true;
            this.RulesLabel.BackColor = System.Drawing.Color.White;
            this.RulesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RulesLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RulesLabel.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RulesLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RulesLabel.Location = new System.Drawing.Point(1414, 333);
            this.RulesLabel.Name = "RulesLabel";
            this.RulesLabel.Size = new System.Drawing.Size(412, 46);
            this.RulesLabel.TabIndex = 5;
            this.RulesLabel.Text = "1. Power and restart buttons are not allowed\r\n2. U have to enjoy the rickroll";
            this.RulesLabel.DoubleClick += new System.EventHandler(this.RulesLabel_DoubleClick);
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Location = new System.Drawing.Point(107, 312);
            this.CodeTextBox.MaxLength = 9;
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(126, 23);
            this.CodeTextBox.TabIndex = 6;
            this.CodeTextBox.Visible = false;
            this.CodeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodeTextBox_KeyDown);
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodeLabel.Location = new System.Drawing.Point(47, 141);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(92, 25);
            this.CodeLabel.TabIndex = 7;
            this.CodeLabel.Text = "Click me :)";
            this.CodeLabel.DoubleClick += new System.EventHandler(this.CodeLabel_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterSecretCodeToolStripMenuItem,
            this.githubToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // enterSecretCodeToolStripMenuItem
            // 
            this.enterSecretCodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CodeTextBoxMenu,
            this.CodeLabelMenu});
            this.enterSecretCodeToolStripMenuItem.Name = "enterSecretCodeToolStripMenuItem";
            this.enterSecretCodeToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.enterSecretCodeToolStripMenuItem.Text = "Enter secret code :)";
            this.enterSecretCodeToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // CodeTextBoxMenu
            // 
            this.CodeTextBoxMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CodeTextBoxMenu.MaxLength = 9;
            this.CodeTextBoxMenu.Name = "CodeTextBoxMenu";
            this.CodeTextBoxMenu.Size = new System.Drawing.Size(130, 23);
            this.CodeTextBoxMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            // 
            // CodeLabelMenu
            // 
            this.CodeLabelMenu.Name = "CodeLabelMenu";
            this.CodeLabelMenu.Size = new System.Drawing.Size(274, 22);
            this.CodeLabelMenu.Text = "Enter secret code to not get rickrolled.";
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.githubToolStripMenuItem.Text = "Github";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.ControlBox = false;
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.CodeTextBox);
            this.Controls.Add(this.RulesLabel);
            this.Controls.Add(this.RulesButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "LMAO kid get good btw this is virus";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Button RulesButton;
        private Label RulesLabel;
        private TextBox CodeTextBox;
        private Label CodeLabel;
        private ToolTip toolTip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem enterSecretCodeToolStripMenuItem;
        private ToolStripTextBox CodeTextBoxMenu;
        private ToolStripMenuItem CodeLabelMenu;
        private ToolStripMenuItem githubToolStripMenuItem;
    }
}

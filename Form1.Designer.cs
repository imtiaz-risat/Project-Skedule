namespace Skedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.menuButtonSettings = new System.Windows.Forms.Button();
            this.menuButtonAnalysis = new System.Windows.Forms.Button();
            this.menuButtonQuiz = new System.Windows.Forms.Button();
            this.menuButtonAssignment = new System.Windows.Forms.Button();
            this.menuButtonRoutine = new System.Windows.Forms.Button();
            this.menuButtonHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxSkeduleLogo = new System.Windows.Forms.PictureBox();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.labelFormTitle = new System.Windows.Forms.Label();
            this.formHeaderPanel = new System.Windows.Forms.Panel();
            this.labelUsernameID = new System.Windows.Forms.Label();
            this.pictureBoxUserIcon = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkeduleLogo)).BeginInit();
            this.formHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.menuPanel.Controls.Add(this.menuButtonSettings);
            this.menuPanel.Controls.Add(this.menuButtonAnalysis);
            this.menuPanel.Controls.Add(this.menuButtonQuiz);
            this.menuPanel.Controls.Add(this.menuButtonAssignment);
            this.menuPanel.Controls.Add(this.menuButtonRoutine);
            this.menuPanel.Controls.Add(this.menuButtonHome);
            this.menuPanel.Controls.Add(this.panel2);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(82, 577);
            this.menuPanel.TabIndex = 1;
            // 
            // menuButtonSettings
            // 
            this.menuButtonSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuButtonSettings.FlatAppearance.BorderSize = 0;
            this.menuButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButtonSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuButtonSettings.Image = global::Skedule.Properties.Resources.settings_white_32x32;
            this.menuButtonSettings.Location = new System.Drawing.Point(0, 500);
            this.menuButtonSettings.Name = "menuButtonSettings";
            this.menuButtonSettings.Size = new System.Drawing.Size(82, 77);
            this.menuButtonSettings.TabIndex = 0;
            this.menuButtonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuButtonSettings.UseVisualStyleBackColor = true;
            // 
            // menuButtonAnalysis
            // 
            this.menuButtonAnalysis.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButtonAnalysis.FlatAppearance.BorderSize = 0;
            this.menuButtonAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButtonAnalysis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuButtonAnalysis.Image = global::Skedule.Properties.Resources.analysis_white_40x40;
            this.menuButtonAnalysis.Location = new System.Drawing.Point(0, 393);
            this.menuButtonAnalysis.Name = "menuButtonAnalysis";
            this.menuButtonAnalysis.Size = new System.Drawing.Size(82, 77);
            this.menuButtonAnalysis.TabIndex = 0;
            this.menuButtonAnalysis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuButtonAnalysis.UseVisualStyleBackColor = true;
            // 
            // menuButtonQuiz
            // 
            this.menuButtonQuiz.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButtonQuiz.FlatAppearance.BorderSize = 0;
            this.menuButtonQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButtonQuiz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuButtonQuiz.Image = global::Skedule.Properties.Resources.assignment_white_42x42;
            this.menuButtonQuiz.Location = new System.Drawing.Point(0, 316);
            this.menuButtonQuiz.Name = "menuButtonQuiz";
            this.menuButtonQuiz.Size = new System.Drawing.Size(82, 77);
            this.menuButtonQuiz.TabIndex = 0;
            this.menuButtonQuiz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuButtonQuiz.UseVisualStyleBackColor = true;
            // 
            // menuButtonAssignment
            // 
            this.menuButtonAssignment.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButtonAssignment.FlatAppearance.BorderSize = 0;
            this.menuButtonAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButtonAssignment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuButtonAssignment.Image = global::Skedule.Properties.Resources.annoucement_white_42x42;
            this.menuButtonAssignment.Location = new System.Drawing.Point(0, 239);
            this.menuButtonAssignment.Name = "menuButtonAssignment";
            this.menuButtonAssignment.Size = new System.Drawing.Size(82, 77);
            this.menuButtonAssignment.TabIndex = 0;
            this.menuButtonAssignment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuButtonAssignment.UseVisualStyleBackColor = true;
            // 
            // menuButtonRoutine
            // 
            this.menuButtonRoutine.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButtonRoutine.FlatAppearance.BorderSize = 0;
            this.menuButtonRoutine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButtonRoutine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuButtonRoutine.Image = global::Skedule.Properties.Resources.calendar_white_36x36;
            this.menuButtonRoutine.Location = new System.Drawing.Point(0, 162);
            this.menuButtonRoutine.Name = "menuButtonRoutine";
            this.menuButtonRoutine.Size = new System.Drawing.Size(82, 77);
            this.menuButtonRoutine.TabIndex = 0;
            this.menuButtonRoutine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuButtonRoutine.UseVisualStyleBackColor = true;
            this.menuButtonRoutine.Click += new System.EventHandler(this.menuButtonRoutine_Click);
            // 
            // menuButtonHome
            // 
            this.menuButtonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButtonHome.FlatAppearance.BorderSize = 0;
            this.menuButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButtonHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuButtonHome.Image = global::Skedule.Properties.Resources.home_white_45x45;
            this.menuButtonHome.Location = new System.Drawing.Point(0, 85);
            this.menuButtonHome.Name = "menuButtonHome";
            this.menuButtonHome.Size = new System.Drawing.Size(82, 77);
            this.menuButtonHome.TabIndex = 0;
            this.menuButtonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuButtonHome.UseVisualStyleBackColor = true;
            this.menuButtonHome.Click += new System.EventHandler(this.menuButtonHome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBoxSkeduleLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(82, 85);
            this.panel2.TabIndex = 0;
            // 
            // pictureBoxSkeduleLogo
            // 
            this.pictureBoxSkeduleLogo.Image = global::Skedule.Properties.Resources.skeduleShortLogo;
            this.pictureBoxSkeduleLogo.Location = new System.Drawing.Point(20, 15);
            this.pictureBoxSkeduleLogo.Name = "pictureBoxSkeduleLogo";
            this.pictureBoxSkeduleLogo.Size = new System.Drawing.Size(43, 50);
            this.pictureBoxSkeduleLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSkeduleLogo.TabIndex = 0;
            this.pictureBoxSkeduleLogo.TabStop = false;
            // 
            // childFormPanel
            // 
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(82, 61);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(869, 516);
            this.childFormPanel.TabIndex = 4;
            // 
            // labelFormTitle
            // 
            this.labelFormTitle.AutoSize = true;
            this.labelFormTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelFormTitle.Font = new System.Drawing.Font("Dubai", 28.55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFormTitle.Location = new System.Drawing.Point(0, 0);
            this.labelFormTitle.Name = "labelFormTitle";
            this.labelFormTitle.Size = new System.Drawing.Size(181, 66);
            this.labelFormTitle.TabIndex = 0;
            this.labelFormTitle.Text = "Welcome";
            // 
            // formHeaderPanel
            // 
            this.formHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.formHeaderPanel.Controls.Add(this.labelUsernameID);
            this.formHeaderPanel.Controls.Add(this.pictureBoxUserIcon);
            this.formHeaderPanel.Controls.Add(this.labelFormTitle);
            this.formHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formHeaderPanel.Location = new System.Drawing.Point(82, 0);
            this.formHeaderPanel.Name = "formHeaderPanel";
            this.formHeaderPanel.Size = new System.Drawing.Size(869, 61);
            this.formHeaderPanel.TabIndex = 3;
            // 
            // labelUsernameID
            // 
            this.labelUsernameID.AutoSize = true;
            this.labelUsernameID.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameID.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUsernameID.Location = new System.Drawing.Point(718, 14);
            this.labelUsernameID.Name = "labelUsernameID";
            this.labelUsernameID.Size = new System.Drawing.Size(92, 34);
            this.labelUsernameID.TabIndex = 2;
            this.labelUsernameID.Text = "Login/Signup\r\nID: ********";
            // 
            // pictureBoxUserIcon
            // 
            this.pictureBoxUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUserIcon.Image")));
            this.pictureBoxUserIcon.Location = new System.Drawing.Point(667, 8);
            this.pictureBoxUserIcon.Name = "pictureBoxUserIcon";
            this.pictureBoxUserIcon.Size = new System.Drawing.Size(48, 46);
            this.pictureBoxUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUserIcon.TabIndex = 1;
            this.pictureBoxUserIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.formHeaderPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkeduleLogo)).EndInit();
            this.formHeaderPanel.ResumeLayout(false);
            this.formHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button menuButtonSettings;
        private System.Windows.Forms.Button menuButtonAnalysis;
        private System.Windows.Forms.Button menuButtonQuiz;
        private System.Windows.Forms.Button menuButtonAssignment;
        private System.Windows.Forms.Button menuButtonRoutine;
        private System.Windows.Forms.Button menuButtonHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxSkeduleLogo;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.Label labelFormTitle;
        private System.Windows.Forms.Panel formHeaderPanel;
        private System.Windows.Forms.Label labelUsernameID;
        private System.Windows.Forms.PictureBox pictureBoxUserIcon;
    }
}


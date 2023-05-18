namespace Skedule
{
    partial class QuizChildForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewRoutine = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddClass = new System.Windows.Forms.Button();
            this.buttonEditClass = new System.Windows.Forms.Button();
            this.buttonDeleteClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewRoutine
            // 
            this.listViewRoutine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewRoutine.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewRoutine.HideSelection = false;
            this.listViewRoutine.Location = new System.Drawing.Point(34, 70);
            this.listViewRoutine.Margin = new System.Windows.Forms.Padding(4);
            this.listViewRoutine.Name = "listViewRoutine";
            this.listViewRoutine.Size = new System.Drawing.Size(1091, 526);
            this.listViewRoutine.TabIndex = 13;
            this.listViewRoutine.UseCompatibleStateImageBehavior = false;
            this.listViewRoutine.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Date";
            this.columnHeader0.Width = 220;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 225;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Subject/Course";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Syllabus";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 300;
            // 
            // buttonAddClass
            // 
            this.buttonAddClass.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddClass.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAddClass.FlatAppearance.BorderSize = 0;
            this.buttonAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddClass.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddClass.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonAddClass.Image = global::Skedule.Properties.Resources.add_green_32x32;
            this.buttonAddClass.Location = new System.Drawing.Point(961, 12);
            this.buttonAddClass.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddClass.Name = "buttonAddClass";
            this.buttonAddClass.Size = new System.Drawing.Size(47, 50);
            this.buttonAddClass.TabIndex = 14;
            this.buttonAddClass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddClass.UseVisualStyleBackColor = false;
            // 
            // buttonEditClass
            // 
            this.buttonEditClass.BackColor = System.Drawing.Color.Transparent;
            this.buttonEditClass.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonEditClass.FlatAppearance.BorderSize = 0;
            this.buttonEditClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditClass.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditClass.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonEditClass.Image = global::Skedule.Properties.Resources.edit_yellow_32x32;
            this.buttonEditClass.Location = new System.Drawing.Point(1016, 12);
            this.buttonEditClass.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditClass.Name = "buttonEditClass";
            this.buttonEditClass.Size = new System.Drawing.Size(47, 50);
            this.buttonEditClass.TabIndex = 15;
            this.buttonEditClass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEditClass.UseVisualStyleBackColor = false;
            this.buttonEditClass.Click += new System.EventHandler(this.buttonEditClass_Click);
            // 
            // buttonDeleteClass
            // 
            this.buttonDeleteClass.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteClass.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonDeleteClass.FlatAppearance.BorderSize = 0;
            this.buttonDeleteClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteClass.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteClass.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonDeleteClass.Image = global::Skedule.Properties.Resources.delete_red_32x32;
            this.buttonDeleteClass.Location = new System.Drawing.Point(1071, 12);
            this.buttonDeleteClass.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteClass.Name = "buttonDeleteClass";
            this.buttonDeleteClass.Size = new System.Drawing.Size(47, 50);
            this.buttonDeleteClass.TabIndex = 16;
            this.buttonDeleteClass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDeleteClass.UseVisualStyleBackColor = false;
            // 
            // QuizChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.buttonDeleteClass);
            this.Controls.Add(this.buttonEditClass);
            this.Controls.Add(this.buttonAddClass);
            this.Controls.Add(this.listViewRoutine);
            this.Name = "QuizChildForm";
            this.Size = new System.Drawing.Size(1159, 635);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewRoutine;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonAddClass;
        private System.Windows.Forms.Button buttonEditClass;
        private System.Windows.Forms.Button buttonDeleteClass;
    }
}

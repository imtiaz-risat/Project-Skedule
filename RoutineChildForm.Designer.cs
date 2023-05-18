namespace Skedule
{
    partial class RoutineChildForm
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
            this.buttonSatDay = new System.Windows.Forms.Button();
            this.buttonFriDay = new System.Windows.Forms.Button();
            this.buttonThuDay = new System.Windows.Forms.Button();
            this.buttonWedDay = new System.Windows.Forms.Button();
            this.buttonTueDay = new System.Windows.Forms.Button();
            this.buttonMonDay = new System.Windows.Forms.Button();
            this.buttonSunDay = new System.Windows.Forms.Button();
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
            this.listViewRoutine.Location = new System.Drawing.Point(33, 84);
            this.listViewRoutine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewRoutine.Name = "listViewRoutine";
            this.listViewRoutine.Size = new System.Drawing.Size(1091, 526);
            this.listViewRoutine.TabIndex = 12;
            this.listViewRoutine.UseCompatibleStateImageBehavior = false;
            this.listViewRoutine.View = System.Windows.Forms.View.Details;
            this.listViewRoutine.SelectedIndexChanged += new System.EventHandler(this.listViewRoutine_SelectedIndexChanged);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Time";
            this.columnHeader0.Width = 160;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Course/Subject";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 225;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Teacher";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 230;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Room No";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // buttonSatDay
            // 
            this.buttonSatDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.buttonSatDay.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSatDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSatDay.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSatDay.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonSatDay.Location = new System.Drawing.Point(497, 37);
            this.buttonSatDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSatDay.Name = "buttonSatDay";
            this.buttonSatDay.Size = new System.Drawing.Size(73, 38);
            this.buttonSatDay.TabIndex = 2;
            this.buttonSatDay.Text = "Sat";
            this.buttonSatDay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSatDay.UseVisualStyleBackColor = false;
            // 
            // buttonFriDay
            // 
            this.buttonFriDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.buttonFriDay.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonFriDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFriDay.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFriDay.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonFriDay.Location = new System.Drawing.Point(420, 37);
            this.buttonFriDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFriDay.Name = "buttonFriDay";
            this.buttonFriDay.Size = new System.Drawing.Size(73, 38);
            this.buttonFriDay.TabIndex = 3;
            this.buttonFriDay.Text = "Fri";
            this.buttonFriDay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFriDay.UseVisualStyleBackColor = false;
            // 
            // buttonThuDay
            // 
            this.buttonThuDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.buttonThuDay.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonThuDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThuDay.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThuDay.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonThuDay.Location = new System.Drawing.Point(343, 37);
            this.buttonThuDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonThuDay.Name = "buttonThuDay";
            this.buttonThuDay.Size = new System.Drawing.Size(73, 38);
            this.buttonThuDay.TabIndex = 4;
            this.buttonThuDay.Text = "Thu";
            this.buttonThuDay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonThuDay.UseVisualStyleBackColor = false;
            // 
            // buttonWedDay
            // 
            this.buttonWedDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.buttonWedDay.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonWedDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWedDay.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWedDay.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonWedDay.Location = new System.Drawing.Point(265, 37);
            this.buttonWedDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonWedDay.Name = "buttonWedDay";
            this.buttonWedDay.Size = new System.Drawing.Size(73, 38);
            this.buttonWedDay.TabIndex = 5;
            this.buttonWedDay.Text = "Wed";
            this.buttonWedDay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonWedDay.UseVisualStyleBackColor = false;
            // 
            // buttonTueDay
            // 
            this.buttonTueDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.buttonTueDay.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonTueDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTueDay.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTueDay.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonTueDay.Location = new System.Drawing.Point(188, 37);
            this.buttonTueDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTueDay.Name = "buttonTueDay";
            this.buttonTueDay.Size = new System.Drawing.Size(73, 38);
            this.buttonTueDay.TabIndex = 6;
            this.buttonTueDay.Text = "Tue";
            this.buttonTueDay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTueDay.UseVisualStyleBackColor = false;
            // 
            // buttonMonDay
            // 
            this.buttonMonDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.buttonMonDay.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonMonDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMonDay.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMonDay.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonMonDay.Location = new System.Drawing.Point(111, 37);
            this.buttonMonDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMonDay.Name = "buttonMonDay";
            this.buttonMonDay.Size = new System.Drawing.Size(73, 38);
            this.buttonMonDay.TabIndex = 7;
            this.buttonMonDay.Text = "Mon";
            this.buttonMonDay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMonDay.UseVisualStyleBackColor = false;
            // 
            // buttonSunDay
            // 
            this.buttonSunDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.buttonSunDay.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSunDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSunDay.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSunDay.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonSunDay.Location = new System.Drawing.Point(33, 37);
            this.buttonSunDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSunDay.Name = "buttonSunDay";
            this.buttonSunDay.Size = new System.Drawing.Size(73, 38);
            this.buttonSunDay.TabIndex = 8;
            this.buttonSunDay.Text = "Sun";
            this.buttonSunDay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSunDay.UseVisualStyleBackColor = false;
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
            this.buttonAddClass.Location = new System.Drawing.Point(956, 26);
            this.buttonAddClass.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddClass.Name = "buttonAddClass";
            this.buttonAddClass.Size = new System.Drawing.Size(47, 50);
            this.buttonAddClass.TabIndex = 9;
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
            this.buttonEditClass.Location = new System.Drawing.Point(1015, 26);
            this.buttonEditClass.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditClass.Name = "buttonEditClass";
            this.buttonEditClass.Size = new System.Drawing.Size(47, 50);
            this.buttonEditClass.TabIndex = 10;
            this.buttonEditClass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEditClass.UseVisualStyleBackColor = false;
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
            this.buttonDeleteClass.Location = new System.Drawing.Point(1069, 26);
            this.buttonDeleteClass.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteClass.Name = "buttonDeleteClass";
            this.buttonDeleteClass.Size = new System.Drawing.Size(47, 50);
            this.buttonDeleteClass.TabIndex = 11;
            this.buttonDeleteClass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDeleteClass.UseVisualStyleBackColor = false;
            // 
            // RoutineChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.listViewRoutine);
            this.Controls.Add(this.buttonSatDay);
            this.Controls.Add(this.buttonFriDay);
            this.Controls.Add(this.buttonThuDay);
            this.Controls.Add(this.buttonWedDay);
            this.Controls.Add(this.buttonTueDay);
            this.Controls.Add(this.buttonMonDay);
            this.Controls.Add(this.buttonSunDay);
            this.Controls.Add(this.buttonAddClass);
            this.Controls.Add(this.buttonEditClass);
            this.Controls.Add(this.buttonDeleteClass);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RoutineChildForm";
            this.Size = new System.Drawing.Size(1159, 635);
            this.Load += new System.EventHandler(this.RoutineChildForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewRoutine;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonSatDay;
        private System.Windows.Forms.Button buttonFriDay;
        private System.Windows.Forms.Button buttonThuDay;
        private System.Windows.Forms.Button buttonWedDay;
        private System.Windows.Forms.Button buttonTueDay;
        private System.Windows.Forms.Button buttonMonDay;
        private System.Windows.Forms.Button buttonSunDay;
        private System.Windows.Forms.Button buttonAddClass;
        private System.Windows.Forms.Button buttonEditClass;
        private System.Windows.Forms.Button buttonDeleteClass;
    }
}

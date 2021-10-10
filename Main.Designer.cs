using BindsManagerUltimate.Utils;

namespace BindsManagerUltimate
{
    partial class Main
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
            this.Exit = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.BindsLabel = new System.Windows.Forms.Label();
            this.AdminCommand = new BindsManagerUltimate.Utils.CustomRadioButton();
            this.Reset = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.OpenSaved = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CommandBox = new System.Windows.Forms.RichTextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Keys = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Image = global::BindsManagerUltimate.Properties.Resources.smallX;
            this.Exit.Location = new System.Drawing.Point(718, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(70, 46);
            this.Exit.TabIndex = 0;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Minimize
            // 
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Image = global::BindsManagerUltimate.Properties.Resources.smallMinimize;
            this.Minimize.Location = new System.Drawing.Point(642, 12);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(70, 46);
            this.Minimize.TabIndex = 1;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // BindsLabel
            // 
            this.BindsLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.BindsLabel.ForeColor = System.Drawing.Color.Silver;
            this.BindsLabel.Location = new System.Drawing.Point(12, 77);
            this.BindsLabel.Name = "BindsLabel";
            this.BindsLabel.Size = new System.Drawing.Size(740, 246);
            this.BindsLabel.TabIndex = 2;
            this.BindsLabel.Text = "Commands that are binded will show up here.\n";
            // 
            // AdminCommand
            // 
            this.AdminCommand.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.AdminCommand.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.AdminCommand.Location = new System.Drawing.Point(647, 398);
            this.AdminCommand.Name = "AdminCommand";
            this.AdminCommand.Size = new System.Drawing.Size(141, 35);
            this.AdminCommand.TabIndex = 4;
            this.AdminCommand.Text = "Admin Command";
            this.AdminCommand.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.FlatAppearance.BorderSize = 0;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.Reset.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Reset.Location = new System.Drawing.Point(12, 390);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(145, 48);
            this.Reset.TabIndex = 5;
            this.Reset.Text = "Reset your binds";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Import
            // 
            this.Import.FlatAppearance.BorderSize = 0;
            this.Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Import.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.Import.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Import.Location = new System.Drawing.Point(15, 357);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(66, 31);
            this.Import.TabIndex = 6;
            this.Import.Text = "Open";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Export
            // 
            this.Export.FlatAppearance.BorderSize = 0;
            this.Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.Export.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Export.Location = new System.Drawing.Point(87, 357);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(66, 31);
            this.Export.TabIndex = 7;
            this.Export.Text = "Save";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // OpenSaved
            // 
            this.OpenSaved.FlatAppearance.BorderSize = 0;
            this.OpenSaved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenSaved.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.OpenSaved.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.OpenSaved.Location = new System.Drawing.Point(163, 400);
            this.OpenSaved.Name = "OpenSaved";
            this.OpenSaved.Size = new System.Drawing.Size(98, 31);
            this.OpenSaved.TabIndex = 8;
            this.OpenSaved.Text = "Open Saved";
            this.OpenSaved.UseVisualStyleBackColor = true;
            this.OpenSaved.Click += new System.EventHandler(this.OpenSaved_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Binds Manager Ultimate";
            // 
            // CommandBox
            // 
            this.CommandBox.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.CommandBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommandBox.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.CommandBox.ForeColor = System.Drawing.Color.Silver;
            this.CommandBox.Location = new System.Drawing.Point(478, 400);
            this.CommandBox.Name = "CommandBox";
            this.CommandBox.Size = new System.Drawing.Size(147, 34);
            this.CommandBox.TabIndex = 12;
            this.CommandBox.Text = "Command";
            // 
            // Add
            // 
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.Add.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Add.Location = new System.Drawing.Point(339, 363);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(110, 66);
            this.Add.TabIndex = 13;
            this.Add.Text = "Add Command";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 7F);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "By The Ulti One";
            // 
            // Keys
            // 
            this.Keys.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.Keys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Keys.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Keys.ForeColor = System.Drawing.Color.Silver;
            this.Keys.FormattingEnabled = true;
            this.Keys.Location = new System.Drawing.Point(478, 366);
            this.Keys.Name = "Keys";
            this.Keys.Size = new System.Drawing.Size(147, 28);
            this.Keys.TabIndex = 14;
            this.Keys.Text = "Keys";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Keys);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.CommandBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenSaved);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.AdminCommand);
            this.Controls.Add(this.BindsLabel);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Exit);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox Keys;

        private System.Windows.Forms.RichTextBox CommandBox;
        

        private System.Windows.Forms.Button Add;
        
        private System.Windows.Forms.Button Export;

        private System.Windows.Forms.Button OpenSaved;
        private System.Windows.Forms.Button Import;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button Reset;

        private BindsManagerUltimate.Utils.CustomRadioButton AdminCommand;

        private System.Windows.Forms.Label BindsLabel;

        private System.Windows.Forms.Button Minimize;

        private System.Windows.Forms.Button Exit;


        #endregion
    }
}
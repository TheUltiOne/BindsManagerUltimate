using System.ComponentModel;

namespace BindsManagerUltimate.Utils.CustomExtraForms
{
    partial class ButtonBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.Caption = new System.Windows.Forms.Label();
            this.Option1 = new System.Windows.Forms.Button();
            this.Option2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Image = global::BindsManagerUltimate.Properties.Resources.smallX;
            this.Exit.Location = new System.Drawing.Point(432, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(39, 36);
            this.Exit.TabIndex = 2;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Caption
            // 
            this.Caption.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.Caption.ForeColor = System.Drawing.Color.Silver;
            this.Caption.Location = new System.Drawing.Point(12, 12);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(403, 65);
            this.Caption.TabIndex = 5;
            this.Caption.Text = "Caption";
            // 
            // Option1
            // 
            this.Option1.FlatAppearance.BorderSize = 0;
            this.Option1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Option1.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.Option1.ForeColor = System.Drawing.Color.Silver;
            this.Option1.Location = new System.Drawing.Point(12, 98);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(212, 47);
            this.Option1.TabIndex = 7;
            this.Option1.Text = "Option 1";
            this.Option1.UseVisualStyleBackColor = true;
            // 
            // Option2
            // 
            this.Option2.FlatAppearance.BorderSize = 0;
            this.Option2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Option2.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.Option2.ForeColor = System.Drawing.Color.Silver;
            this.Option2.Location = new System.Drawing.Point(261, 98);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(209, 47);
            this.Option2.TabIndex = 8;
            this.Option2.Text = "Option 2";
            this.Option2.UseVisualStyleBackColor = true;
            // 
            // ButtonBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (32)))), ((int) (((byte) (32)))), ((int) (((byte) (32)))));
            this.ClientSize = new System.Drawing.Size(483, 168);
            this.Controls.Add(this.Option1);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Caption);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ButtonBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ButtonBox";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button Option1;
        private System.Windows.Forms.Button Option2;

        private System.Windows.Forms.Label Caption;

        private System.Windows.Forms.Button Exit;

        #endregion
    }
}
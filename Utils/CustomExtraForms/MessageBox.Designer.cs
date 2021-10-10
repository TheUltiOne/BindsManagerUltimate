using System.ComponentModel;

namespace BindsManagerUltimate.Utils.CustomExtraForms
{
    partial class MessageBox
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
            this.Contents = new System.Windows.Forms.Label();
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
            this.Caption.Font = new System.Drawing.Font("Segoe UI Semilight", 10.25F);
            this.Caption.ForeColor = System.Drawing.Color.Silver;
            this.Caption.Location = new System.Drawing.Point(12, 20);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(343, 23);
            this.Caption.TabIndex = 5;
            this.Caption.Text = "Caption";
            // 
            // Contents
            // 
            this.Contents.Font = new System.Drawing.Font("Segoe UI Semilight", 10.25F);
            this.Contents.ForeColor = System.Drawing.Color.Silver;
            this.Contents.Location = new System.Drawing.Point(12, 68);
            this.Contents.Name = "Contents";
            this.Contents.Size = new System.Drawing.Size(459, 75);
            this.Contents.TabIndex = 6;
            this.Contents.Text = "Contents";
            // 
            // MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (32)))), ((int) (((byte) (32)))), ((int) (((byte) (32)))));
            this.ClientSize = new System.Drawing.Size(483, 168);
            this.Controls.Add(this.Contents);
            this.Controls.Add(this.Caption);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBox";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label Contents;

        private System.Windows.Forms.Label Caption;

        private System.Windows.Forms.Button Exit;

        #endregion
    }
}
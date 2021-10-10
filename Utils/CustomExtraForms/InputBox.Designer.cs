using System.ComponentModel;
using System.Windows.Forms;

namespace BindsManagerUltimate.Utils.CustomExtraForms
{
    partial class InputBox
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
            this.Minimize = new System.Windows.Forms.Button();
            this.Caption = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
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
            this.Exit.TabIndex = 1;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Minimize
            // 
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Location = new System.Drawing.Point(642, 12);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(70, 46);
            this.Minimize.TabIndex = 2;
            this.Minimize.UseVisualStyleBackColor = true;
            // 
            // Caption
            // 
            this.Caption.Font = new System.Drawing.Font("Segoe UI Semilight", 10.25F);
            this.Caption.ForeColor = System.Drawing.Color.Silver;
            this.Caption.Location = new System.Drawing.Point(12, 20);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(343, 23);
            this.Caption.TabIndex = 4;
            this.Caption.Text = "Caption";
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (32)))), ((int) (((byte) (32)))), ((int) (((byte) (32)))));
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Input.Font = new System.Drawing.Font("Segoe UI Semilight", 10.25F);
            this.Input.ForeColor = System.Drawing.Color.Silver;
            this.Input.Location = new System.Drawing.Point(12, 73);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(377, 65);
            this.Input.TabIndex = 5;
            this.Input.Text = "Write input here...";
            this.Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // Enter
            // 
            this.Enter.FlatAppearance.BorderSize = 0;
            this.Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.Enter.ForeColor = System.Drawing.Color.Silver;
            this.Enter.Location = new System.Drawing.Point(395, 73);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(76, 65);
            this.Enter.TabIndex = 6;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (32)))), ((int) (((byte) (32)))), ((int) (((byte) (32)))));
            this.ClientSize = new System.Drawing.Size(483, 168);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Caption);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputBox";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button Enter;
        
        private System.Windows.Forms.Label Caption;
        private System.Windows.Forms.TextBox Input;
        
        private System.Windows.Forms.Button Minimize;

        private System.Windows.Forms.Button Exit;

        #endregion
    }
}
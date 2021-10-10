using System;
using System.Windows.Forms;

namespace BindsManagerUltimate.Utils.CustomExtraForms
{
    public partial class InputBox : Form
    {
        public InputBox()
        {
            InitializeComponent();
            Enter.DialogResult = DialogResult.OK;
            Exit.DialogResult = DialogResult.Abort;
        }

        public static string AskInput(string caption = "Caption")
        {
            var box = new InputBox();

            box.Caption.Text = caption;
            box.Enter.Click += (sender, e) => { box.Close(); };
            box.Exit.Click += (sender, e) => { box.Close(); };

            box.AcceptButton = box.Enter;
            box.CancelButton = box.Exit;
            var showdialog = box.ShowDialog();
            switch (showdialog)
            {
                default:
                    return string.Empty;
                case DialogResult.OK:
                    return box.Input.Text;
                case DialogResult.Abort:
                    return null;
            }
        }

        private void Enter_Click(object sender, EventArgs e)
            => this.Close();

        private void Exit_Click(object sender, EventArgs e)
            => this.Close();

        private void Input_KeyDown(object sender, EventArgs e)
        {
            if (Input.Text == "Write input here...")
                Input.Text = string.Empty;
        }
    }
}
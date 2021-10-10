using System;
using System.Windows.Forms;

namespace BindsManagerUltimate.Utils.CustomExtraForms
{
    public partial class ButtonBox : Form
    {
        public ButtonBox()
        {
            InitializeComponent();
            Option1.DialogResult = DialogResult.Cancel;
            Option2.DialogResult = DialogResult.OK;
            Exit.DialogResult = DialogResult.Abort;
        }

        public static bool AskResult(string caption = "Caption", string option1 = "Cancel", string option2 = "Accept")
        {
            var box = new ButtonBox();

            box.Caption.Text = caption;
            box.Option1.Text = option1;
            box.Option2.Text = option2;
            
            box.Option1.Click += (sender, e) => { box.Close(); };
            box.Option2.Click += (sender, e) => { box.Close(); };

            box.AcceptButton = box.Option1;
            box.CancelButton = box.Option2;
            var showdialog = box.ShowDialog();
            switch (showdialog)
            {
                default:
                    return false;
                case DialogResult.OK:
                    return true;
                case DialogResult.Cancel:
                    return false;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
            => this.Close();
        
    }
}
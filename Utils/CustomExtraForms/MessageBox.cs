using System;
using System.Runtime.ExceptionServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BindsManagerUltimate.Utils.CustomExtraForms
{
    public partial class MessageBox : Form
    {
        public MessageBox()
        {
            InitializeComponent();
        }

        public static void Show(string caption, string contents)
        {
            var box = new MessageBox();

            box.Caption.Text = caption;
            box.Contents.Text = contents;
            box.CancelButton = box.Exit;
            box.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
            => this.Close();
    }
}
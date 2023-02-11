
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dlg
{
    public partial class DialogWindow : Form
    {
        private Label cimke = null ;

        public DialogWindow(Modality mode)
        {
            InitializeComponent();

            cimke = new Label() ;
            this.Controls.Add(cimke);

            if (mode == Modality.Modal)
                cimke.Text = "Modal";
            else
                cimke.Text = "Modeless" ;

            cimke.Location = new Point(
                this.ClientRectangle.Width / 3,
                this.ClientRectangle.Height / 3) ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogWindow myForm = new DialogWindow(Modality.Modal);
            DialogResult res = myForm.ShowDialog();
            MessageBox.Show(res.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogWindow myForm = new DialogWindow(Modality.Modeless);
            myForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
            this.Close();
        }

        private void DialogWindow_Resize(object sender, EventArgs e)
        {
            cimke.Location = new Point(
                this.ClientRectangle.Width / 3,
                this.ClientRectangle.Height / 3);
        }
    }
}
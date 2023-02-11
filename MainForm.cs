using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dlg
{
    public enum Modality { Modal, Modeless } ;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            listBox1.Items.Add("Sárga") ;
            listBox1.Items.Add("Zöld") ;
            listBox1.Items.Add("Kék") ;
            listBox1.Items.Add("Piros") ;
            listBox1.Items.Add("Barna") ;

            comboBox1.Items.Add("Sárga") ;
            comboBox1.Items.Add("Zöld") ;
            comboBox1.Items.Add("Kék") ;
            comboBox1.Items.Add("Piros") ;
            comboBox1.Items.Add("Barna") ;
            comboBox1.SelectedIndex = 0 ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogWindow myForm = new DialogWindow(Modality.Modal) ;
            myForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogWindow myForm = new DialogWindow(Modality.Modeless);
            myForm.Show();
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Brush myBrush = Brushes.Black;

            string str = listBox1.Items[e.Index] as string ;
            if (str == "Sárga")
                myBrush = Brushes.Yellow;
            if (str == "Zöld")
                myBrush = Brushes.Green;
            if (str == "Kék")
                myBrush = Brushes.Blue;
            if (str == "Piros")
                myBrush = Brushes.Red;
            if (str == "Barna")
                myBrush = Brushes.Brown;
            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, 
                myBrush,e.Bounds,StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = listBox1.SelectedItem as string ;

            if (str == "Sárga")
                this.BackColor = Color.Yellow;
            if (str == "Zöld")
                this.BackColor = Color.Green;
            if (str == "Kék")
                this.BackColor = Color.Blue;
            if (str == "Piros")
                this.BackColor = Color.Red;
            if (str == "Barna")
                this.BackColor = Color.Brown;
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Brush myBrush = Brushes.Black;

            string str = comboBox1.Items[e.Index] as string;
            if (str == "Sárga")
                myBrush = Brushes.Yellow;
            if (str == "Zöld")
                myBrush = Brushes.Green;
            if (str == "Kék")
                myBrush = Brushes.Blue;
            if (str == "Piros")
                myBrush = Brushes.Red;
            if (str == "Barna")
                myBrush = Brushes.Brown;
            e.Graphics.DrawString(comboBox1.Items[e.Index].ToString(), e.Font,
                myBrush, e.Bounds, StringFormat.GenericDefault) ;
            e.DrawFocusRectangle();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedItem as string ;

            if (str == "Sárga")
                this.BackColor = Color.Yellow;
            if (str == "Zöld")
                this.BackColor = Color.Green;
            if (str == "Kék")
                this.BackColor = Color.Blue;
            if (str == "Piros")
                this.BackColor = Color.Red;
            if (str == "Barna")
                this.BackColor = Color.Brown;
        }
    }
}
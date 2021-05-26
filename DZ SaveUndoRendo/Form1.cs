using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_SaveUndoRendo
{
    public partial class Form1 : Form
    {
        Originator originator = new Originator();        
        Caretaker caretaker = new Caretaker();

        public Form1()
        {
            InitializeComponent();
            originator._state = "";
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            originator._state = textBox1.Text;
            caretaker.momento = originator.CreateMomento();
        }

        private void btUndo_Click(object sender, EventArgs e)
        {
            originator.SetMomento(caretaker.momento);
            textBox1.Text = originator._state;            
        }

        private void btRedo_Click(object sender, EventArgs e)
        {
            textBox1.Text += originator._state;
        }
    }
}

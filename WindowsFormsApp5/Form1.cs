using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Surname;
            int selfEsteem;
            int otherEsteem;
            Surname = textBox1.Text;
            int.TryParse(textBox2.Text, out selfEsteem);
            int.TryParse(textBox3.Text, out otherEsteem);
            head headObj = new head(Surname, selfEsteem, otherEsteem);
            MessageBox.Show(headObj.ToString() + "\n" + "Q: " + headObj.Q());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Surname;
            int selfEsteem;
            int otherEsteem;
            int P;
            Surname = textBox1.Text;
            int.TryParse(textBox2.Text, out selfEsteem);
            int.TryParse(textBox3.Text, out otherEsteem);
            int.TryParse(textBox4.Text, out P);
            ext extObj = new ext(Surname, selfEsteem, otherEsteem, P);
            MessageBox.Show(extObj.ToString() + "\n" + "P: " + extObj.Q());
        }
    }
    class head
    {
        public string Surname { get; set; }
        public int selfEsteem { get; set; }
        public int otherEsteem { get; set; }

        public double Q()
        {
            return (double)otherEsteem / selfEsteem;
        }

        public head(string Surname, int selfEsteem, int otherEsteem)
        {
            this.Surname = Surname;
            this.selfEsteem = selfEsteem;
            this.otherEsteem = otherEsteem;
        }
        public override string ToString()
        {
            return "Фамилия: " + Surname + "\n" + "Самооценка: " + selfEsteem + "\n" + "Оценка другими: " + otherEsteem;
        }
    }


    class ext : head
    {
        public int P { get; set; }
        public ext(string Surname, int selfEsteem, int otherEsteem, int P) : base(Surname, selfEsteem, otherEsteem)
        {
            this.P = P;
        }
        public new double Q()
        {
            return 0.3*base.Q() + 0.7*P;
        }
    }
}

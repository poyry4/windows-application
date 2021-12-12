using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Register(human form)
        {
            if (form.Age >= 18)
            {
                Db db1 = new Db();
                db1.humen.Add(form);
                db1.SaveChanges();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Register(new human { Name = textBox1.Text, Family = textBox2.Text, Age = byte.Parse(textBox3.Text) });
        }
    }
}

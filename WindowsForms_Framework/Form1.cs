using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddButton();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AddButton()
        {
            Button button = new Button
            {
                Name = "myButton",
                Text = "Click me",
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(100, 30)
            };
            button.Click += Button_Click;
            Controls.Add(button);
        }
        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked!");
        }
    }
}

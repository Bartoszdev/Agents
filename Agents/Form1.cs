using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SecretAgent agent = new SecretAgent();

        private void button1_Click(object sender, EventArgs e)
        {
            agent.AgentGreeting(textBox1.Text);
        }
    }
}

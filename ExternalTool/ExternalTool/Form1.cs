using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExternalTool
{
    public partial class ExternalTool : Form
    {

        int intelligence;
        int money;
        int strength;
        int charm;

        public ExternalTool()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            //clear all stat textboxes
            charmTb.Clear();
            moneyTb.Clear();
            strTb.Clear();
            intelTb.Clear();
        }

        private void charmTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            //Saves stats from textbox and parses into an int
            intelligence = int.Parse(intelTb.Text);
            money = int.Parse(moneyTb.Text);
            charm = int.Parse(charmTb.Text);
            strength = int.Parse(strTb.Text);

            //creation of a streamwriter which will write into external text document
            StreamWriter writer = new StreamWriter("D:/Profiles/wtd4240/source/repos/ExternalTool/Stats.txt");

            //writes each individual stat the user enters in the textbox into the text document
            writer.WriteLine(money);
            writer.WriteLine(strength);
            writer.WriteLine(intelligence);
            writer.WriteLine(charm);

            writer.Close();
        }
    }
}

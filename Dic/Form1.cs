using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Dic
{
    public partial class Form1 : Form
    {
        List<Tuple<string,string>> Words = new List<Tuple<string, string>>();
        public Form1()
        {
            Words.Where(x => x.Item1 == "cat").Select(y => y.Item2).ToList();
            Words.Select(x => x.Item1).Distinct().ToList();
            InitializeComponent();
            comboBoxEn.DataSource = Words.Select(x => x.Item1).Distinct().ToList(); 
            comboBoxRus.DataSource = Words.Select(x => x.Item2).Distinct().ToList();         
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Words.Add(new Tuple<string, string>(textBoxAddEn.Text, textBoxAddRus.Text));
            
            comboBoxEn.DataSource = Words.Select(x => x.Item1).Distinct().ToList();
            comboBoxRus.DataSource = Words.Select(x => x.Item2).Distinct().ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxEn_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxRus.DataSource= Words.Where(x => x.Item1 == comboBoxEn.Text).Select(y => y.Item2).ToList();         
        }

        private void comboBoxRus_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxEn.DataSource = Words.Where(x => x.Item2 == comboBoxRus.Text).Select(y => y.Item1).ToList();
        }
        private void buttonRemoveRus_Click(object sender, EventArgs e)
        {
            Words.Remove(Words.Find(x => x.Item2 == listBoxRus.SelectedItem as string));
            listBoxRus.DataSource = Words.Where(x => x.Item1 == comboBoxEn.Text).Select(y => y.Item2).ToList();
            listBoxEn.DataSource = Words.Where(x => x.Item2 == comboBoxRus.Text).Select(y => y.Item1).ToList();
            comboBoxRus.DataSource = Words.Select(x => x.Item2).Distinct().ToList();
            comboBoxEn.DataSource = Words.Select(x => x.Item1).Distinct().ToList();
        }
        private void buttonRemoveEn_Click(object sender, EventArgs e)
        {
            Words.Remove(Words.Find(x => x.Item1== listBoxEn.SelectedItem as string));
            listBoxEn.DataSource = Words.Where(x => x.Item2 == comboBoxRus.Text).Select(y => y.Item1).ToList();
            listBoxRus.DataSource = Words.Where(x => x.Item1 == comboBoxEn.Text).Select(y => y.Item2).ToList();
            comboBoxRus.DataSource = Words.Select(x => x.Item2).Distinct().ToList();
            comboBoxEn.DataSource = Words.Select(x => x.Item1).Distinct().ToList();
        }


    }

}

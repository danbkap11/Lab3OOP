using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mined_Out;

namespace Lab3
{
    
    public partial class Form1 : Form
    {
        private string[] choices =
        {
            "Mine",
            "Coin",
            "Trap",
            "WinCell",
            "Wall",
            "Player",
            "AddPts",
            "AntiPts",
            "AddLife",
            "AntiLife",
            "Teleport",
            "EmptyCell"
        };
        Map map = new Map();
        public Form1()
        {
            this.Paint += this.Form1_Paint;
            InitializeComponent();
            this.Text = "Lab 3";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedItem = comboBox1.Items[0];
        }
        
        private void Form1_Paint (object sender, PaintEventArgs e)
        { 
            Graphics g = e.Graphics;
            map.print(g);

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            (int, int) result = map.Find(choices[comboBox1.SelectedIndex]);
            label2.Text = $"Координаты: ({result.Item1}, {result.Item2})";
            label2.Visible = true;
        }
    }
}

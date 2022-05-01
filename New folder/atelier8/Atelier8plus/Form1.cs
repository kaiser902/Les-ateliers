﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atelier8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ResttextBox()
        {
            Action<Control.ControlCollection> func = null;
            func=(controls)=>
            {
                foreach (Control control in controls)
                if (control is TextBox)                    
                        (control as TextBox).Text = "0";
                    
                    else
                        func(control.Controls);
                };
            func(Controls);
            }
        private void RestchekBox()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;

                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("confirmé", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();

            }
            
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResttextBox();
        }
    }
    
}

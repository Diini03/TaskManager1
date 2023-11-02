using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTaskStatus.Items.Add("Finished");
            cbTaskStatus.Items.Add("Pending");
            cbTaskStatus.Items.Add("Not Started");
            cbTaskStatus.Items.Add("Select Status");
            cbTaskStatus.SelectedItem = "Select Status";

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtBoxTaskName.Text;
            string comboBox = cbTaskStatus.SelectedItem.ToString();

            if (name == "")
            {
                MessageBox.Show("Fill the Task Name , to add your tasks Manager");
                return;
            }

            else if(comboBox == "Finished")
            {

                if (listBoxFinished.Items.Contains(name))
                {
                  
                    return;
                }



                if (listBoxNotStarted.Items.Contains(name))
                {
                    listBoxNotStarted.Items.Remove(name);
                }
                else if (listBoxPending.Items.Contains(name))
                {
                    listBoxPending.Items.Remove(name);
                }

                listBoxFinished.Items.Add(name);
            }
            else if (comboBox == "Pending")
            {

                if (listBoxPending.Items.Contains(name))
                {
                    return;
                }



                if (listBoxNotStarted.Items.Contains(name))
                {
                    listBoxNotStarted.Items.Remove(name);
                }
                else if (listBoxFinished.Items.Contains(name))
                {
                    listBoxFinished.Items.Remove(name);
                }

                listBoxPending.Items.Add(name);
            }
            else if (comboBox == "Not Started")
            {
                if (listBoxNotStarted.Items.Contains(name))
                {
                    return;
                }



                if (listBoxFinished.Items.Contains(name))
                {
                    listBoxFinished.Items.Remove(name);
                }
                else if (listBoxPending.Items.Contains(name))
                {
                    listBoxPending.Items.Remove(name);
                }

                listBoxNotStarted.Items.Add(name);
            }
            else
            {
                MessageBox.Show("Choose One Of The Items !");
            }
        }
    }
}

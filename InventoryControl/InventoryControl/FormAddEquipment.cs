using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryControl
{
    public partial class FormAddEquipment : Form
    {
        public FormAddEquipment()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSerialNumber_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

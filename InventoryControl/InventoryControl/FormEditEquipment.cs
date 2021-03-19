using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using InventoryControlModel;

namespace InventoryControl
{
    public partial class FormEditEquipment : Form
    {
        public FormEditEquipment(Equipment equip)
        {
            InitializeComponent();

            textBoxEquipmentName.Text = equip.EquipmentName;
            textBoxAcquisitionPrice.Text = equip.AcquisitionPrice.ToString();
            textBoxSerialNumber.Text = equip.SerialNumber;
            dateTimePickerManufacturingDate.Value = equip.ManufacturingDate;
            textBoxManufacterName.Text = equip.ManufacturerName;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAcquisitionPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

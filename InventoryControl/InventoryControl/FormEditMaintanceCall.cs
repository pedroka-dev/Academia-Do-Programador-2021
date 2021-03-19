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
    public partial class FormEditMaintanceCall : Form
    {
        public FormEditMaintanceCall(MaintenanceCall maintenance)
        {
            InitializeComponent();

            textBoxTitleName.Text = maintenance.TitleName;
            textBoxDescriptionName.Text = maintenance.DescriptioName;
            //Equipment equipment = (Equipment)comboBoxEquipment.SelectedItem;
            dateTimePickerOpeningDate.Value = maintenance.OpeningDate;
        }

        public void PopulateComboBox(List<Equipment> ListEquip)
        {
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = ListEquip;

            comboBoxEquipment.DataSource = bindingSource1.DataSource;

            comboBoxEquipment.DisplayMember = "equipmentName";
            comboBoxEquipment.ValueMember = "equipmentName";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}

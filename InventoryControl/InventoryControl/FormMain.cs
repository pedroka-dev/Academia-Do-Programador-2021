using System.Collections.Generic;
using System.Windows.Forms;
using InventoryControlModel;

namespace InventoryControl
{
    public partial class FormMain : Form
    {
        public List<Equipment> ListEquipment = new List<Equipment>();

        public FormMain()
        {
            InitializeComponent();
        }

        public void AddEquipment(Equipment equipment)
        {
            ListEquipment.Add(equipment);
            UpdateGridEquipment();
            //MessageBox.Show("Equipment=" + equipment.EquipmentName);        //debug
        }

        public void AddMaintenanceCall(MaintenanceCall maintenanceCall)
        {
            MessageBox.Show("MaintenanceCall=" + maintenanceCall.TitleName);        //debug
        }

        public void UpdateGridEquipment()
        {
            dataGridViewEquipment.Rows.Clear();
            foreach (Equipment equip in ListEquipment)
            {
                dataGridViewEquipment.Rows.Add(equip.EquipmentName, equip.SerialNumber, equip.ManufacturerName);
            }
        }

        private void buttonAddEquipment_Click(object sender, System.EventArgs e)
        {
            FormAddEquipment screenAddEquipment = new FormAddEquipment
            {
                Owner = this
            };
            screenAddEquipment.Show();
        }

        private void buttonEditEquipment_Click(object sender, System.EventArgs e)
        {
            FormEditEquipment screenEditEquipment = new FormEditEquipment
            {
                Owner = this
            };
            screenEditEquipment.Show();
        }

        private void buttonDeleteEquipment_Click(object sender, System.EventArgs e)
        {

        }

        private void buttonAddMaintanceCall_Click(object sender, System.EventArgs e)
        {
            FormAddMaintanceCall screenAddMaintanceCall = new FormAddMaintanceCall
            {
                Owner = this
            };
            screenAddMaintanceCall.Show();
        }

        private void buttonEditMaintanceCall_Click(object sender, System.EventArgs e)
        {
            FormEditMaintanceCall screenEditMaintanceCall = new FormEditMaintanceCall
            {
                Owner = this
            };
            screenEditMaintanceCall.Show();
        }

        private void buttonDeleteMaintanceCall_Click(object sender, System.EventArgs e)
        {

        }
    }
}

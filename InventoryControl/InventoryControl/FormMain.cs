using System.Windows.Forms;

namespace InventoryControl
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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

        private void dataGridViewEquipment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

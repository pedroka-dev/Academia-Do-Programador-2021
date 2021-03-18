using System;
using System.Windows.Forms;
using InventoryControlModel;

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
            if (!string.IsNullOrEmpty(textBoxEquipmentName.Text) && !string.IsNullOrEmpty(textBoxAcquisitionPrice.Text) && !string.IsNullOrEmpty(textBoxSerialNumber.Text) && !string.IsNullOrEmpty(textBoxManufacterName.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja adicionar um novo Equipamento?", "Confirmação necessária.", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string equipmentName = textBoxEquipmentName.Text;
                        float acquisitionPrice = float.Parse(textBoxAcquisitionPrice.Text);
                        string serialNumber = textBoxSerialNumber.Text;
                        DateTime manufacturingDate = dateTimePickerManufacturingDate.Value;
                        string manufacterName = textBoxManufacterName.Text;

                        Equipment newEquipment = new Equipment(equipmentName, acquisitionPrice, serialNumber, manufacturingDate, manufacterName);

                        FormMain parentForm = (FormMain)this.Owner;
                        parentForm.AddEquipment(newEquipment);
                        this.Dispose();
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show("Argumentos inválidos: \n" + ex.Message, "Exceção ArgumentException Capturada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos antes de adicionar novo Equipamento.", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBoxSerialNumber_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

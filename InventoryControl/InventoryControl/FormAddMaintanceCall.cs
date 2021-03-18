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
    public partial class FormAddMaintanceCall : Form
    {
        public FormAddMaintanceCall()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTitleName.Text) && !string.IsNullOrEmpty(textBoxDescriptionName.Text))
            {
                if (comboBoxEquipment.SelectedValue != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja adicionar um novo Chamado de Manutenção?", "Confirmação necessária.", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            string titleName = textBoxTitleName.Text;
                            string descriptionName = textBoxDescriptionName.Text;
                            Equipment equipment = (Equipment)comboBoxEquipment.SelectedValue;
                            DateTime openingDate = dateTimePickerOpeningDate.Value;

                            MaintenanceCall newMainanceCall = new MaintenanceCall(titleName, descriptionName, equipment, openingDate);

                            FormMain parentForm = (FormMain)this.Owner;
                            parentForm.AddMaintenanceCall(newMainanceCall);
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
                    MessageBox.Show("Selecione ao menos um Equipamento antes de adicionar novo Chamado de Manutenção.\nCaso não exista nenhum, adicione um Equipamento novo primeiro.", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos antes de adicionar novo Chamado de Manutenção.", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

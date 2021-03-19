using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InventoryControlModel;

namespace InventoryControl
{
    public partial class FormMain : Form
    {
        public List<Equipment> ListEquipment = new List<Equipment>();
        public List<MaintenanceCall> ListMaintenanceCall = new List<MaintenanceCall>();


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
            ListMaintenanceCall.Add(maintenanceCall);
            UpdateGridMaintenanceCall();
            //MessageBox.Show("MaintenanceCall=" + maintenanceCall.TitleName);        //debug
        }

        public void UpdateGridEquipment()
        {
            dataGridViewEquipment.Rows.Clear();
            foreach (Equipment equip in ListEquipment)
            {
                dataGridViewEquipment.Rows.Add(equip.EquipmentName, equip.SerialNumber, equip.ManufacturerName);
            }
        }

        public void UpdateGridMaintenanceCall()
        {
            dataGridViewMaintanceCall.Rows.Clear();
            foreach (MaintenanceCall maintenance in ListMaintenanceCall)
            {
                string daysOpen = (DateTime.Now - maintenance.OpeningDate).Days.ToString();
                dataGridViewMaintanceCall.Rows.Add(maintenance.TitleName, maintenance.Equipment.EquipmentName, maintenance.OpeningDate.ToString(), daysOpen);
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
            if (dataGridViewEquipment.CurrentCell != null)
            {
                int listIndex = dataGridViewEquipment.CurrentCell.RowIndex;
                FormEditEquipment screenEditEquipment = new FormEditEquipment(ListEquipment[listIndex])
                {
                    Owner = this
                };
                screenEditEquipment.Show();
            }
            else
            {
                MessageBox.Show("Selecione ao menos um Equipamento antes de tentar editar um item.", "Operação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDeleteEquipment_Click(object sender, System.EventArgs e)
        {
            if (dataGridViewEquipment.CurrentCell != null)
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que quer excluir o Equipamento selecionado?", "Confirmação Necessária", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int listIndex = dataGridViewEquipment.CurrentCell.RowIndex;
                    ListEquipment.RemoveAt(listIndex);
                    UpdateGridEquipment();
                }
            }
            else
            {
                MessageBox.Show("Selecione ao menos um Equipamento antes de tentar excluir um item.", "Operação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAddMaintanceCall_Click(object sender, System.EventArgs e)
        {
            FormAddMaintanceCall screenAddMaintanceCall = new FormAddMaintanceCall
            {
                Owner = this
            };
            screenAddMaintanceCall.Show();
            screenAddMaintanceCall.PopulateComboBox(ListEquipment);
        }

        private void buttonEditMaintanceCall_Click(object sender, System.EventArgs e)
        {
            if (dataGridViewMaintanceCall.CurrentCell != null)
            {
                int listIndex = dataGridViewMaintanceCall.CurrentCell.RowIndex;
                FormEditMaintanceCall screenEditMaintanceCall = new FormEditMaintanceCall(ListMaintenanceCall[listIndex])
                {
                    Owner = this
                };
                screenEditMaintanceCall.Show();
                screenEditMaintanceCall.PopulateComboBox(ListEquipment);
            }
            else
            {
                MessageBox.Show("Selecione ao menos um Chamado de Manutenção antes de tentar editar um item.", "Operação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDeleteMaintanceCall_Click(object sender, System.EventArgs e)
        {
            if (dataGridViewMaintanceCall.CurrentCell != null)
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que quer excluir o Chamado de Manutenção selecionado?", "Confirmação Necessária", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int listIndex = dataGridViewMaintanceCall.CurrentCell.RowIndex;
                    ListMaintenanceCall.RemoveAt(listIndex);
                    UpdateGridMaintenanceCall();
                }
            }
            else
            {
                MessageBox.Show("Selecione ao menos um Chamado de Manutenção antes de tentar excluir um item.", "Operação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

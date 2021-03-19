using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using InventoryControlModel;
using Newtonsoft.Json;

namespace InventoryControl
{
    public partial class FormMain : Form
    {
        private List<Equipment> ListEquipment;
        private List<MaintenanceCall> ListMaintenanceCall;

        public FormMain()
        {
            InitializeComponent();

            ListEquipment = DeserializeJson<Equipment>("ListEquipment");
            ListMaintenanceCall = DeserializeJson<MaintenanceCall>("ListMaintenanceCall");

            UpdateGridEquipment();
            UpdateGridMaintenanceCall();
        }

        public void AddEquipment(Equipment equipment, int? optionalIndex = null)
        {
            if (optionalIndex == null)
            {
                ListEquipment.Add(equipment);
            }
            else
            {
                ListEquipment[optionalIndex.GetValueOrDefault()] = equipment;
            }
            UpdateGridEquipment();
        }

        public void AddMaintenanceCall(MaintenanceCall maintenanceCall, int? optionalIndex = null)
        {
            if (optionalIndex == null)
            {
                ListMaintenanceCall.Add(maintenanceCall);
            }
            else
            {
                ListMaintenanceCall[optionalIndex.GetValueOrDefault()] = maintenanceCall;
            }
            UpdateGridMaintenanceCall();
        }

        public void UpdateGridEquipment()
        {
            if (ListEquipment != null)
            {
                SerializeJson(ListEquipment, "ListEquipment");
                dataGridViewEquipment.Rows.Clear();
                foreach (Equipment equip in ListEquipment)
                {
                    dataGridViewEquipment.Rows.Add(equip.EquipmentName, equip.SerialNumber, equip.ManufacturerName);
                }
            }
        }

        public void UpdateGridMaintenanceCall()
        {
            if (ListMaintenanceCall != null)
            {
                SerializeJson(ListMaintenanceCall, "ListMaintenanceCall");
                dataGridViewMaintanceCall.Rows.Clear();
                foreach (MaintenanceCall maintenance in ListMaintenanceCall)
                {
                    string daysOpen = (DateTime.Now - maintenance.OpeningDate).Days.ToString();
                    dataGridViewMaintanceCall.Rows.Add(maintenance.TitleName, maintenance.Equipment.EquipmentName, maintenance.OpeningDate.ToString(), daysOpen);
                }
            }
        }

        public void SerializeJson<T>(List<T> listGeneric, string fileName)
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(listGeneric);
                File.WriteAllText(fileName + ".json", jsonString);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Erro na operação de Serialização de arquivo JSON: \n" + ex.Message+"\nCaso este erro persista, abra o aplicativo em modo Administrador.", "Exceção IOException Capturada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<T> DeserializeJson<T>(string fileName)
        {
            try
            {
                if (File.Exists(fileName + ".json"))
                {
                    string jsonString = File.ReadAllText(fileName + ".json");
                    return JsonConvert.DeserializeObject<List<T>>(jsonString);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Erro na operação de Deserialização de arquivo JSON: \n" + ex.Message+ "\nCaso este erro persista, abra o aplicativo em modo Administrador.", "Exceção IOException Capturada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return new List<T>();
        }

        private void buttonAddEquipment_Click(object sender, System.EventArgs e)
        {
            FormAddEquipment screenAddEquipment = new FormAddEquipment
            {
                Owner = this
            };
            screenAddEquipment.ShowDialog();
        }

        private void buttonEditEquipment_Click(object sender, System.EventArgs e)
        {
            if (dataGridViewEquipment.CurrentCell != null)
            {
                int listIndex = dataGridViewEquipment.CurrentCell.RowIndex;
                FormEditEquipment screenEditEquipment = new FormEditEquipment(ListEquipment[listIndex], listIndex)
                {
                    Owner = this
                };
                screenEditEquipment.ShowDialog();
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
            screenAddMaintanceCall.PopulateComboBox(ListEquipment);
            screenAddMaintanceCall.ShowDialog();
        }

        private void buttonEditMaintanceCall_Click(object sender, System.EventArgs e)
        {
            if (dataGridViewMaintanceCall.CurrentCell != null)
            {
                int listIndex = dataGridViewMaintanceCall.CurrentCell.RowIndex;
                FormEditMaintanceCall screenEditMaintanceCall = new FormEditMaintanceCall(ListMaintenanceCall[listIndex], listIndex)
                {
                    Owner = this
                };
                screenEditMaintanceCall.PopulateComboBox(ListEquipment);
                screenEditMaintanceCall.ShowDialog();
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

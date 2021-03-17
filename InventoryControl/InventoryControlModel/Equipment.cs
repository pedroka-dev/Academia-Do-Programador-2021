using System;

namespace InventoryControlModel
{
    public class Equipment
    {
        private string equipmentName;
        private float acquisitionPrice;
        private string serialNumber;
        private DateTime manufacturingDate;
        private string manufacturerName;

        public string EquipmentName {
            get { return equipmentName; }
            set {
                if (value.Length < 6)
                    throw new ArgumentException("EquipmentName property has a minimun lenght of 6.");
                equipmentName = value;
            }
        }
        public float AcquisitionPrice { get => acquisitionPrice; set => acquisitionPrice = value; }
        public string SerialNumber { get => serialNumber; set => serialNumber = value; }
        public DateTime ManufacturingDate { get => manufacturingDate; set => manufacturingDate = value; }
        public string ManufacturerName { get => manufacturerName; set => manufacturerName = value; }
    }
}

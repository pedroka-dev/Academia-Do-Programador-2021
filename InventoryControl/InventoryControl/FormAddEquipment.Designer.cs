
namespace InventoryControl
{
    partial class FormAddEquipment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxAddEquipment = new System.Windows.Forms.GroupBox();
            this.textBoxManufacterName = new System.Windows.Forms.TextBox();
            this.dateTimePickerManufacturingDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.textBoxAcquisitionPrice = new System.Windows.Forms.TextBox();
            this.textBoxEquipmentName = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAddEquipment.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAddEquipment
            // 
            this.groupBoxAddEquipment.Controls.Add(this.textBoxManufacterName);
            this.groupBoxAddEquipment.Controls.Add(this.dateTimePickerManufacturingDate);
            this.groupBoxAddEquipment.Controls.Add(this.textBoxSerialNumber);
            this.groupBoxAddEquipment.Controls.Add(this.textBoxAcquisitionPrice);
            this.groupBoxAddEquipment.Controls.Add(this.textBoxEquipmentName);
            this.groupBoxAddEquipment.Controls.Add(this.buttonConfirm);
            this.groupBoxAddEquipment.Controls.Add(this.buttonCancel);
            this.groupBoxAddEquipment.Controls.Add(this.label5);
            this.groupBoxAddEquipment.Controls.Add(this.label4);
            this.groupBoxAddEquipment.Controls.Add(this.label3);
            this.groupBoxAddEquipment.Controls.Add(this.label2);
            this.groupBoxAddEquipment.Controls.Add(this.label1);
            this.groupBoxAddEquipment.Location = new System.Drawing.Point(7, 6);
            this.groupBoxAddEquipment.Name = "groupBoxAddEquipment";
            this.groupBoxAddEquipment.Size = new System.Drawing.Size(262, 335);
            this.groupBoxAddEquipment.TabIndex = 0;
            this.groupBoxAddEquipment.TabStop = false;
            this.groupBoxAddEquipment.Text = "Detalhes do Equipamento";
            // 
            // textBoxManufacterName
            // 
            this.textBoxManufacterName.Location = new System.Drawing.Point(15, 258);
            this.textBoxManufacterName.Name = "textBoxManufacterName";
            this.textBoxManufacterName.Size = new System.Drawing.Size(234, 27);
            this.textBoxManufacterName.TabIndex = 9;
            // 
            // dateTimePickerManufacturingDate
            // 
            this.dateTimePickerManufacturingDate.Location = new System.Drawing.Point(15, 205);
            this.dateTimePickerManufacturingDate.Name = "dateTimePickerManufacturingDate";
            this.dateTimePickerManufacturingDate.Size = new System.Drawing.Size(234, 27);
            this.dateTimePickerManufacturingDate.TabIndex = 11;
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(15, 152);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(234, 27);
            this.textBoxSerialNumber.TabIndex = 7;
            this.textBoxSerialNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSerialNumber_KeyPress);
            // 
            // textBoxAcquisitionPrice
            // 
            this.textBoxAcquisitionPrice.Location = new System.Drawing.Point(15, 99);
            this.textBoxAcquisitionPrice.Name = "textBoxAcquisitionPrice";
            this.textBoxAcquisitionPrice.Size = new System.Drawing.Size(234, 27);
            this.textBoxAcquisitionPrice.TabIndex = 5;
            // 
            // textBoxEquipmentName
            // 
            this.textBoxEquipmentName.Location = new System.Drawing.Point(15, 46);
            this.textBoxEquipmentName.Name = "textBoxEquipmentName";
            this.textBoxEquipmentName.Size = new System.Drawing.Size(234, 27);
            this.textBoxEquipmentName.TabIndex = 1;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(15, 296);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(94, 29);
            this.buttonConfirm.TabIndex = 13;
            this.buttonConfirm.Text = "Confirmar";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(155, 296);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 29);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de Fabricação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome do Fabricante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Número de Serial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preço de Aquisição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // FormAddEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 356);
            this.Controls.Add(this.groupBoxAddEquipment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormAddEquipment";
            this.Text = "Adicionar Equipamento";
            this.groupBoxAddEquipment.ResumeLayout(false);
            this.groupBoxAddEquipment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddEquipment;
        private System.Windows.Forms.TextBox textBoxEquipmentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAcquisitionPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxManufacterName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerManufacturingDate;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
    }
}
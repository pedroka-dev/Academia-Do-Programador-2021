
namespace InventoryControl
{
    partial class FormAddMaintanceCall
    {
        /// <summary>asfsasaf
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
            this.groupBoxAddMaintanceCall = new System.Windows.Forms.GroupBox();
            this.dateTimePickerOpeningDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxDescriptionName = new System.Windows.Forms.TextBox();
            this.textBoxTitleName = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEquipment = new System.Windows.Forms.ComboBox();
            this.groupBoxAddMaintanceCall.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAddMaintanceCall
            // 
            this.groupBoxAddMaintanceCall.Controls.Add(this.comboBoxEquipment);
            this.groupBoxAddMaintanceCall.Controls.Add(this.dateTimePickerOpeningDate);
            this.groupBoxAddMaintanceCall.Controls.Add(this.textBoxDescriptionName);
            this.groupBoxAddMaintanceCall.Controls.Add(this.textBoxTitleName);
            this.groupBoxAddMaintanceCall.Controls.Add(this.buttonConfirm);
            this.groupBoxAddMaintanceCall.Controls.Add(this.buttonCancel);
            this.groupBoxAddMaintanceCall.Controls.Add(this.label5);
            this.groupBoxAddMaintanceCall.Controls.Add(this.label3);
            this.groupBoxAddMaintanceCall.Controls.Add(this.label2);
            this.groupBoxAddMaintanceCall.Controls.Add(this.label1);
            this.groupBoxAddMaintanceCall.Location = new System.Drawing.Point(7, 6);
            this.groupBoxAddMaintanceCall.Name = "groupBoxAddMaintanceCall";
            this.groupBoxAddMaintanceCall.Size = new System.Drawing.Size(262, 284);
            this.groupBoxAddMaintanceCall.TabIndex = 0;
            this.groupBoxAddMaintanceCall.TabStop = false;
            this.groupBoxAddMaintanceCall.Text = "Detalhes do Chamado";
            // 
            // dateTimePickerOpeningDate
            // 
            this.dateTimePickerOpeningDate.Location = new System.Drawing.Point(15, 205);
            this.dateTimePickerOpeningDate.Name = "dateTimePickerOpeningDate";
            this.dateTimePickerOpeningDate.Size = new System.Drawing.Size(234, 27);
            this.dateTimePickerOpeningDate.TabIndex = 11;
            // 
            // textBoxDescriptionName
            // 
            this.textBoxDescriptionName.Location = new System.Drawing.Point(15, 99);
            this.textBoxDescriptionName.Name = "textBoxDescriptionName";
            this.textBoxDescriptionName.Size = new System.Drawing.Size(234, 27);
            this.textBoxDescriptionName.TabIndex = 5;
            // 
            // textBoxTitleName
            // 
            this.textBoxTitleName.Location = new System.Drawing.Point(15, 46);
            this.textBoxTitleName.Name = "textBoxTitleName";
            this.textBoxTitleName.Size = new System.Drawing.Size(234, 27);
            this.textBoxTitleName.TabIndex = 1;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(14, 243);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(94, 29);
            this.buttonConfirm.TabIndex = 13;
            this.buttonConfirm.Text = "Confirmar";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(158, 243);
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
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de Abertura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Equipamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição do chamado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título do chamado:";
            // 
            // comboBoxEquipment
            // 
            this.comboBoxEquipment.FormattingEnabled = true;
            this.comboBoxEquipment.Location = new System.Drawing.Point(14, 153);
            this.comboBoxEquipment.Name = "comboBoxEquipment";
            this.comboBoxEquipment.Size = new System.Drawing.Size(234, 28);
            this.comboBoxEquipment.TabIndex = 14;
            // 
            // FormAddMaintanceCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 297);
            this.Controls.Add(this.groupBoxAddMaintanceCall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAddMaintanceCall";
            this.Text = "Adicionar Manutenção";
            this.groupBoxAddMaintanceCall.ResumeLayout(false);
            this.groupBoxAddMaintanceCall.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddMaintanceCall;
        private System.Windows.Forms.TextBox textBoxTitleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescriptionName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerOpeningDate;
        private System.Windows.Forms.TextBox textBoxerialNumber;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxEquipment;
    }
}
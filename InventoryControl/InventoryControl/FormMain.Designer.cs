
namespace InventoryControl
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageEquipment = new System.Windows.Forms.TabPage();
            this.groupBoxEquipment = new System.Windows.Forms.GroupBox();
            this.buttonEditEquipment = new System.Windows.Forms.Button();
            this.buttonDeleteEquipment = new System.Windows.Forms.Button();
            this.buttonAddEquipment = new System.Windows.Forms.Button();
            this.dataGridViewEquipment = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnManufacturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageMaintance = new System.Windows.Forms.TabPage();
            this.groupBoxMaintanceCall = new System.Windows.Forms.GroupBox();
            this.buttonEditMaintanceCall = new System.Windows.Forms.Button();
            this.buttonDeleteMaintanceCall = new System.Windows.Forms.Button();
            this.buttonAddMaintanceCall = new System.Windows.Forms.Button();
            this.dataGridViewMaintanceCall = new System.Windows.Forms.DataGridView();
            this.ColumnTitleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEquipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOpeningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDaysOpen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPageEquipment.SuspendLayout();
            this.groupBoxEquipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipment)).BeginInit();
            this.tabPageMaintance.SuspendLayout();
            this.groupBoxMaintanceCall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaintanceCall)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageEquipment);
            this.tabControl.Controls.Add(this.tabPageMaintance);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(721, 470);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageEquipment
            // 
            this.tabPageEquipment.Controls.Add(this.groupBoxEquipment);
            this.tabPageEquipment.Location = new System.Drawing.Point(4, 29);
            this.tabPageEquipment.Name = "tabPageEquipment";
            this.tabPageEquipment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEquipment.Size = new System.Drawing.Size(713, 437);
            this.tabPageEquipment.TabIndex = 0;
            this.tabPageEquipment.Text = "Equipamentos";
            this.tabPageEquipment.UseVisualStyleBackColor = true;
            // 
            // groupBoxEquipment
            // 
            this.groupBoxEquipment.Controls.Add(this.buttonEditEquipment);
            this.groupBoxEquipment.Controls.Add(this.buttonDeleteEquipment);
            this.groupBoxEquipment.Controls.Add(this.buttonAddEquipment);
            this.groupBoxEquipment.Controls.Add(this.dataGridViewEquipment);
            this.groupBoxEquipment.Location = new System.Drawing.Point(3, 3);
            this.groupBoxEquipment.Name = "groupBoxEquipment";
            this.groupBoxEquipment.Size = new System.Drawing.Size(705, 431);
            this.groupBoxEquipment.TabIndex = 1;
            this.groupBoxEquipment.TabStop = false;
            this.groupBoxEquipment.Text = "Equipamentos Cadastrados";
            // 
            // buttonEditEquipment
            // 
            this.buttonEditEquipment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditEquipment.Location = new System.Drawing.Point(288, 376);
            this.buttonEditEquipment.Name = "buttonEditEquipment";
            this.buttonEditEquipment.Size = new System.Drawing.Size(152, 45);
            this.buttonEditEquipment.TabIndex = 4;
            this.buttonEditEquipment.Text = "Editar";
            this.buttonEditEquipment.UseVisualStyleBackColor = true;
            this.buttonEditEquipment.Click += new System.EventHandler(this.buttonEditEquipment_Click);
            // 
            // buttonDeleteEquipment
            // 
            this.buttonDeleteEquipment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteEquipment.Location = new System.Drawing.Point(542, 376);
            this.buttonDeleteEquipment.Name = "buttonDeleteEquipment";
            this.buttonDeleteEquipment.Size = new System.Drawing.Size(152, 45);
            this.buttonDeleteEquipment.TabIndex = 3;
            this.buttonDeleteEquipment.Text = "Excluir";
            this.buttonDeleteEquipment.UseVisualStyleBackColor = true;
            this.buttonDeleteEquipment.Click += new System.EventHandler(this.buttonDeleteEquipment_Click);
            // 
            // buttonAddEquipment
            // 
            this.buttonAddEquipment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddEquipment.Location = new System.Drawing.Point(11, 376);
            this.buttonAddEquipment.Name = "buttonAddEquipment";
            this.buttonAddEquipment.Size = new System.Drawing.Size(152, 45);
            this.buttonAddEquipment.TabIndex = 2;
            this.buttonAddEquipment.Text = "Adicionar";
            this.buttonAddEquipment.UseVisualStyleBackColor = true;
            this.buttonAddEquipment.Click += new System.EventHandler(this.buttonAddEquipment_Click);
            // 
            // dataGridViewEquipment
            // 
            this.dataGridViewEquipment.AllowUserToAddRows = false;
            this.dataGridViewEquipment.AllowUserToDeleteRows = false;
            this.dataGridViewEquipment.AllowUserToResizeColumns = false;
            this.dataGridViewEquipment.AllowUserToResizeRows = false;
            this.dataGridViewEquipment.ColumnHeadersHeight = 29;
            this.dataGridViewEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewEquipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnSerialNumber,
            this.ColumnManufacturerName});
            this.dataGridViewEquipment.Location = new System.Drawing.Point(11, 26);
            this.dataGridViewEquipment.MultiSelect = false;
            this.dataGridViewEquipment.Name = "dataGridViewEquipment";
            this.dataGridViewEquipment.ReadOnly = true;
            this.dataGridViewEquipment.RowHeadersVisible = false;
            this.dataGridViewEquipment.RowHeadersWidth = 51;
            this.dataGridViewEquipment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewEquipment.RowTemplate.Height = 29;
            this.dataGridViewEquipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEquipment.Size = new System.Drawing.Size(683, 339);
            this.dataGridViewEquipment.TabIndex = 1;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnName.HeaderText = "Nome";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnName.Width = 226;
            // 
            // ColumnSerialNumber
            // 
            this.ColumnSerialNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnSerialNumber.HeaderText = "Número de Serial";
            this.ColumnSerialNumber.MinimumWidth = 6;
            this.ColumnSerialNumber.Name = "ColumnSerialNumber";
            this.ColumnSerialNumber.ReadOnly = true;
            this.ColumnSerialNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnSerialNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnSerialNumber.Width = 226;
            // 
            // ColumnManufacturerName
            // 
            this.ColumnManufacturerName.HeaderText = "Nome do Fabricante";
            this.ColumnManufacturerName.MinimumWidth = 6;
            this.ColumnManufacturerName.Name = "ColumnManufacturerName";
            this.ColumnManufacturerName.ReadOnly = true;
            this.ColumnManufacturerName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnManufacturerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnManufacturerName.Width = 228;
            // 
            // tabPageMaintance
            // 
            this.tabPageMaintance.Controls.Add(this.groupBoxMaintanceCall);
            this.tabPageMaintance.Location = new System.Drawing.Point(4, 29);
            this.tabPageMaintance.Name = "tabPageMaintance";
            this.tabPageMaintance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMaintance.Size = new System.Drawing.Size(713, 437);
            this.tabPageMaintance.TabIndex = 1;
            this.tabPageMaintance.Text = "Manutenção";
            this.tabPageMaintance.UseVisualStyleBackColor = true;
            // 
            // groupBoxMaintanceCall
            // 
            this.groupBoxMaintanceCall.Controls.Add(this.buttonEditMaintanceCall);
            this.groupBoxMaintanceCall.Controls.Add(this.buttonDeleteMaintanceCall);
            this.groupBoxMaintanceCall.Controls.Add(this.buttonAddMaintanceCall);
            this.groupBoxMaintanceCall.Controls.Add(this.dataGridViewMaintanceCall);
            this.groupBoxMaintanceCall.Location = new System.Drawing.Point(3, 3);
            this.groupBoxMaintanceCall.Name = "groupBoxMaintanceCall";
            this.groupBoxMaintanceCall.Size = new System.Drawing.Size(705, 431);
            this.groupBoxMaintanceCall.TabIndex = 2;
            this.groupBoxMaintanceCall.TabStop = false;
            this.groupBoxMaintanceCall.Text = "Chamados de Manutenção Cadastradas";
            // 
            // buttonEditMaintanceCall
            // 
            this.buttonEditMaintanceCall.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditMaintanceCall.Location = new System.Drawing.Point(288, 376);
            this.buttonEditMaintanceCall.Name = "buttonEditMaintanceCall";
            this.buttonEditMaintanceCall.Size = new System.Drawing.Size(152, 45);
            this.buttonEditMaintanceCall.TabIndex = 4;
            this.buttonEditMaintanceCall.Text = "Editar";
            this.buttonEditMaintanceCall.UseVisualStyleBackColor = true;
            this.buttonEditMaintanceCall.Click += new System.EventHandler(this.buttonEditMaintanceCall_Click);
            // 
            // buttonDeleteMaintanceCall
            // 
            this.buttonDeleteMaintanceCall.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteMaintanceCall.Location = new System.Drawing.Point(542, 376);
            this.buttonDeleteMaintanceCall.Name = "buttonDeleteMaintanceCall";
            this.buttonDeleteMaintanceCall.Size = new System.Drawing.Size(152, 45);
            this.buttonDeleteMaintanceCall.TabIndex = 3;
            this.buttonDeleteMaintanceCall.Text = "Excluir";
            this.buttonDeleteMaintanceCall.UseVisualStyleBackColor = true;
            this.buttonDeleteMaintanceCall.Click += new System.EventHandler(this.buttonDeleteMaintanceCall_Click);
            // 
            // buttonAddMaintanceCall
            // 
            this.buttonAddMaintanceCall.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddMaintanceCall.Location = new System.Drawing.Point(11, 376);
            this.buttonAddMaintanceCall.Name = "buttonAddMaintanceCall";
            this.buttonAddMaintanceCall.Size = new System.Drawing.Size(152, 45);
            this.buttonAddMaintanceCall.TabIndex = 2;
            this.buttonAddMaintanceCall.Text = "Adicionar";
            this.buttonAddMaintanceCall.UseVisualStyleBackColor = true;
            this.buttonAddMaintanceCall.Click += new System.EventHandler(this.buttonAddMaintanceCall_Click);
            // 
            // dataGridViewMaintanceCall
            // 
            this.dataGridViewMaintanceCall.AllowUserToAddRows = false;
            this.dataGridViewMaintanceCall.AllowUserToDeleteRows = false;
            this.dataGridViewMaintanceCall.AllowUserToResizeColumns = false;
            this.dataGridViewMaintanceCall.AllowUserToResizeRows = false;
            this.dataGridViewMaintanceCall.ColumnHeadersHeight = 29;
            this.dataGridViewMaintanceCall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMaintanceCall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTitleName,
            this.ColumnEquipmentName,
            this.ColumnOpeningDate,
            this.ColumnDaysOpen});
            this.dataGridViewMaintanceCall.Location = new System.Drawing.Point(11, 26);
            this.dataGridViewMaintanceCall.MultiSelect = false;
            this.dataGridViewMaintanceCall.Name = "dataGridViewMaintanceCall";
            this.dataGridViewMaintanceCall.ReadOnly = true;
            this.dataGridViewMaintanceCall.RowHeadersVisible = false;
            this.dataGridViewMaintanceCall.RowHeadersWidth = 51;
            this.dataGridViewMaintanceCall.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMaintanceCall.RowTemplate.Height = 29;
            this.dataGridViewMaintanceCall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMaintanceCall.Size = new System.Drawing.Size(683, 339);
            this.dataGridViewMaintanceCall.TabIndex = 1;
            // 
            // ColumnTitleName
            // 
            this.ColumnTitleName.HeaderText = "Nome do Chamado";
            this.ColumnTitleName.MinimumWidth = 6;
            this.ColumnTitleName.Name = "ColumnTitleName";
            this.ColumnTitleName.ReadOnly = true;
            this.ColumnTitleName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnTitleName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnTitleName.Width = 175;
            // 
            // ColumnEquipmentName
            // 
            this.ColumnEquipmentName.HeaderText = "Nome do Equip.";
            this.ColumnEquipmentName.MinimumWidth = 6;
            this.ColumnEquipmentName.Name = "ColumnEquipmentName";
            this.ColumnEquipmentName.ReadOnly = true;
            this.ColumnEquipmentName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnEquipmentName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnEquipmentName.Width = 175;
            // 
            // ColumnOpeningDate
            // 
            this.ColumnOpeningDate.HeaderText = "Data de Abertura";
            this.ColumnOpeningDate.MinimumWidth = 6;
            this.ColumnOpeningDate.Name = "ColumnOpeningDate";
            this.ColumnOpeningDate.ReadOnly = true;
            this.ColumnOpeningDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnOpeningDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnOpeningDate.Width = 175;
            // 
            // ColumnDaysOpen
            // 
            this.ColumnDaysOpen.HeaderText = "Dias Aberto";
            this.ColumnDaysOpen.MinimumWidth = 6;
            this.ColumnDaysOpen.Name = "ColumnDaysOpen";
            this.ColumnDaysOpen.ReadOnly = true;
            this.ColumnDaysOpen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDaysOpen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnDaysOpen.Width = 155;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 495);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Controle de Invetário";
            this.tabControl.ResumeLayout(false);
            this.tabPageEquipment.ResumeLayout(false);
            this.groupBoxEquipment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipment)).EndInit();
            this.tabPageMaintance.ResumeLayout(false);
            this.groupBoxMaintanceCall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaintanceCall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageEquipment;
        private System.Windows.Forms.TabPage tabPageMaintance;
        private System.Windows.Forms.GroupBox groupBoxEquipment;
        private System.Windows.Forms.DataGridView dataGridViewEquipment;
        private System.Windows.Forms.Button buttonAddEquipment;
        private System.Windows.Forms.Button buttonDeleteEquipment;
        private System.Windows.Forms.Button buttonEditEquipment;
        private System.Windows.Forms.GroupBox groupBoxMaintanceCall;
        private System.Windows.Forms.Button buttonEditMaintanceCall;
        private System.Windows.Forms.Button buttonDeleteMaintanceCall;
        private System.Windows.Forms.Button buttonAddMaintanceCall;
        private System.Windows.Forms.DataGridView dataGridViewMaintanceCall;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnManufacturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEquipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOpeningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDaysOpen;
    }
}


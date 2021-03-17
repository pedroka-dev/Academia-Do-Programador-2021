
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
            this.buttonDelEquipment = new System.Windows.Forms.Button();
            this.buttonAddEquipment = new System.Windows.Forms.Button();
            this.dataGridViewEquipament = new System.Windows.Forms.DataGridView();
            this.tabPageMaintance = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPageEquipment.SuspendLayout();
            this.groupBoxEquipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipament)).BeginInit();
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
            this.groupBoxEquipment.Controls.Add(this.buttonDelEquipment);
            this.groupBoxEquipment.Controls.Add(this.buttonAddEquipment);
            this.groupBoxEquipment.Controls.Add(this.dataGridViewEquipament);
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
            // 
            // buttonDelEquipment
            // 
            this.buttonDelEquipment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelEquipment.Location = new System.Drawing.Point(542, 376);
            this.buttonDelEquipment.Name = "buttonDelEquipment";
            this.buttonDelEquipment.Size = new System.Drawing.Size(152, 45);
            this.buttonDelEquipment.TabIndex = 3;
            this.buttonDelEquipment.Text = "Excluir";
            this.buttonDelEquipment.UseVisualStyleBackColor = true;
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
            // 
            // dataGridViewEquipament
            // 
            this.dataGridViewEquipament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipament.Location = new System.Drawing.Point(11, 26);
            this.dataGridViewEquipament.Name = "dataGridViewEquipament";
            this.dataGridViewEquipament.RowHeadersWidth = 51;
            this.dataGridViewEquipament.RowTemplate.Height = 29;
            this.dataGridViewEquipament.Size = new System.Drawing.Size(683, 339);
            this.dataGridViewEquipament.TabIndex = 1;
            // 
            // tabPageMaintance
            // 
            this.tabPageMaintance.Location = new System.Drawing.Point(4, 29);
            this.tabPageMaintance.Name = "tabPageMaintance";
            this.tabPageMaintance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMaintance.Size = new System.Drawing.Size(713, 437);
            this.tabPageMaintance.TabIndex = 1;
            this.tabPageMaintance.Text = "Chamadas de Manutenção";
            this.tabPageMaintance.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 483);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Controle de Invetário";
            this.tabControl.ResumeLayout(false);
            this.tabPageEquipment.ResumeLayout(false);
            this.groupBoxEquipment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageEquipment;
        private System.Windows.Forms.TabPage tabPageMaintance;
        private System.Windows.Forms.GroupBox groupBoxEquipment;
        private System.Windows.Forms.DataGridView dataGridViewEquipament;
        private System.Windows.Forms.Button buttonAddEquipment;
        private System.Windows.Forms.Button buttonDelEquipment;
        private System.Windows.Forms.Button buttonEditEquipment;
    }
}


namespace ERPWindowsForms
{
    partial class ServiceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.addTicket = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ticketId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serialNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.goBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serialNumberInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.descInput = new System.Windows.Forms.TextBox();
            this.addTicketButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.editTicketButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(393, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service";
            // 
            // addTicket
            // 
            this.addTicket.BackColor = System.Drawing.Color.LightBlue;
            this.addTicket.FlatAppearance.BorderSize = 0;
            this.addTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTicket.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTicket.Location = new System.Drawing.Point(45, 96);
            this.addTicket.Name = "addTicket";
            this.addTicket.Size = new System.Drawing.Size(473, 70);
            this.addTicket.TabIndex = 1;
            this.addTicket.Text = "Add ticket";
            this.addTicket.UseVisualStyleBackColor = false;
            this.addTicket.Click += new System.EventHandler(this.AddTicket_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ticketId,
            this.serialNumber,
            this.name,
            this.description,
            this.status});
            this.listView1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(45, 209);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(875, 281);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ticketId
            // 
            this.ticketId.Tag = "Id";
            this.ticketId.Text = "Guid";
            this.ticketId.Width = 278;
            // 
            // serialNumber
            // 
            this.serialNumber.Text = "Serial Number";
            this.serialNumber.Width = 151;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 100;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 353;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 91;
            // 
            // goBack
            // 
            this.goBack.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.goBack.Location = new System.Drawing.Point(45, 12);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(75, 35);
            this.goBack.TabIndex = 5;
            this.goBack.Text = "Back";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Visible = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(119, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Serial Number";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(443, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(690, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description";
            this.label4.Visible = false;
            // 
            // serialNumberInput
            // 
            this.serialNumberInput.Location = new System.Drawing.Point(124, 160);
            this.serialNumberInput.Name = "serialNumberInput";
            this.serialNumberInput.Size = new System.Drawing.Size(201, 26);
            this.serialNumberInput.TabIndex = 9;
            this.serialNumberInput.Visible = false;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(448, 159);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(155, 26);
            this.nameInput.TabIndex = 10;
            this.nameInput.Visible = false;
            // 
            // descInput
            // 
            this.descInput.Location = new System.Drawing.Point(695, 159);
            this.descInput.Multiline = true;
            this.descInput.Name = "descInput";
            this.descInput.Size = new System.Drawing.Size(205, 173);
            this.descInput.TabIndex = 11;
            this.descInput.Visible = false;
            // 
            // addTicketButton
            // 
            this.addTicketButton.BackColor = System.Drawing.Color.LightBlue;
            this.addTicketButton.FlatAppearance.BorderSize = 0;
            this.addTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTicketButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTicketButton.Location = new System.Drawing.Point(329, 265);
            this.addTicketButton.Name = "addTicketButton";
            this.addTicketButton.Size = new System.Drawing.Size(120, 39);
            this.addTicketButton.TabIndex = 12;
            this.addTicketButton.Text = "Add ticket";
            this.addTicketButton.UseVisualStyleBackColor = false;
            this.addTicketButton.Visible = false;
            this.addTicketButton.Click += new System.EventHandler(this.addTicketButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.LightBlue;
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refreshButton.Location = new System.Drawing.Point(840, 83);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(80, 70);
            this.refreshButton.TabIndex = 13;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(329, 157);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(192, 28);
            this.statusComboBox.TabIndex = 14;
            this.statusComboBox.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(324, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Status";
            this.label5.Visible = false;
            // 
            // editTicketButton
            // 
            this.editTicketButton.BackColor = System.Drawing.Color.LightBlue;
            this.editTicketButton.FlatAppearance.BorderSize = 0;
            this.editTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTicketButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editTicketButton.Location = new System.Drawing.Point(401, 265);
            this.editTicketButton.Name = "editTicketButton";
            this.editTicketButton.Size = new System.Drawing.Size(120, 39);
            this.editTicketButton.TabIndex = 16;
            this.editTicketButton.Text = "Edit ticket";
            this.editTicketButton.UseVisualStyleBackColor = false;
            this.editTicketButton.Visible = false;
            this.editTicketButton.Click += new System.EventHandler(this.editTicketButton_Click);
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(962, 531);
            this.Controls.Add(this.editTicketButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.addTicketButton);
            this.Controls.Add(this.descInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.serialNumberInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.addTicket);
            this.Controls.Add(this.label1);
            this.Name = "ServiceForm";
            this.Text = "ServiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addTicket;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ticketId;
        private System.Windows.Forms.ColumnHeader serialNumber;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serialNumberInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox descInput;
        private System.Windows.Forms.Button addTicketButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button editTicketButton;
    }
}
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
            this.refreshButton = new System.Windows.Forms.Button();
            this.searchSerialNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBySerialNumber = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.doneRadioButton = new System.Windows.Forms.RadioButton();
            this.toVerifyRadioButton = new System.Windows.Forms.RadioButton();
            this.inRealizationRadioButton = new System.Windows.Forms.RadioButton();
            this.pendingRadioButton = new System.Windows.Forms.RadioButton();
            this.searchByStatus = new System.Windows.Forms.Button();
            this.generatePDF = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(262, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service";
            // 
            // addTicket
            // 
            this.addTicket.BackColor = System.Drawing.Color.LightBlue;
            this.addTicket.FlatAppearance.BorderSize = 0;
            this.addTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTicket.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTicket.Location = new System.Drawing.Point(30, 62);
            this.addTicket.Margin = new System.Windows.Forms.Padding(2);
            this.addTicket.Name = "addTicket";
            this.addTicket.Size = new System.Drawing.Size(315, 46);
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
            this.listView1.Location = new System.Drawing.Point(30, 136);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(585, 184);
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
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.LightBlue;
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refreshButton.Location = new System.Drawing.Point(366, 62);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(53, 46);
            this.refreshButton.TabIndex = 13;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // searchSerialNumber
            // 
            this.searchSerialNumber.Location = new System.Drawing.Point(441, 76);
            this.searchSerialNumber.Name = "searchSerialNumber";
            this.searchSerialNumber.Size = new System.Drawing.Size(174, 20);
            this.searchSerialNumber.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Search by Serial Number";
            // 
            // searchBySerialNumber
            // 
            this.searchBySerialNumber.BackColor = System.Drawing.Color.LightBlue;
            this.searchBySerialNumber.FlatAppearance.BorderSize = 0;
            this.searchBySerialNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBySerialNumber.Location = new System.Drawing.Point(489, 102);
            this.searchBySerialNumber.Name = "searchBySerialNumber";
            this.searchBySerialNumber.Size = new System.Drawing.Size(75, 23);
            this.searchBySerialNumber.TabIndex = 16;
            this.searchBySerialNumber.Text = "Search";
            this.searchBySerialNumber.UseVisualStyleBackColor = false;
            this.searchBySerialNumber.Click += new System.EventHandler(this.searchBySerialNumber_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.doneRadioButton);
            this.groupBox1.Controls.Add(this.toVerifyRadioButton);
            this.groupBox1.Controls.Add(this.inRealizationRadioButton);
            this.groupBox1.Controls.Add(this.pendingRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(664, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 184);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by Status";
            // 
            // doneRadioButton
            // 
            this.doneRadioButton.AutoSize = true;
            this.doneRadioButton.Location = new System.Drawing.Point(26, 138);
            this.doneRadioButton.Name = "doneRadioButton";
            this.doneRadioButton.Size = new System.Drawing.Size(56, 17);
            this.doneRadioButton.TabIndex = 3;
            this.doneRadioButton.TabStop = true;
            this.doneRadioButton.Text = "DONE";
            this.doneRadioButton.UseVisualStyleBackColor = true;
            // 
            // toVerifyRadioButton
            // 
            this.toVerifyRadioButton.AutoSize = true;
            this.toVerifyRadioButton.Location = new System.Drawing.Point(26, 100);
            this.toVerifyRadioButton.Name = "toVerifyRadioButton";
            this.toVerifyRadioButton.Size = new System.Drawing.Size(84, 17);
            this.toVerifyRadioButton.TabIndex = 2;
            this.toVerifyRadioButton.TabStop = true;
            this.toVerifyRadioButton.Text = "TO_VERIFY";
            this.toVerifyRadioButton.UseVisualStyleBackColor = true;
            // 
            // inRealizationRadioButton
            // 
            this.inRealizationRadioButton.AutoSize = true;
            this.inRealizationRadioButton.Location = new System.Drawing.Point(26, 66);
            this.inRealizationRadioButton.Name = "inRealizationRadioButton";
            this.inRealizationRadioButton.Size = new System.Drawing.Size(113, 17);
            this.inRealizationRadioButton.TabIndex = 1;
            this.inRealizationRadioButton.TabStop = true;
            this.inRealizationRadioButton.Text = "IN_REALIZATION";
            this.inRealizationRadioButton.UseVisualStyleBackColor = true;
            // 
            // pendingRadioButton
            // 
            this.pendingRadioButton.AutoSize = true;
            this.pendingRadioButton.Location = new System.Drawing.Point(26, 29);
            this.pendingRadioButton.Name = "pendingRadioButton";
            this.pendingRadioButton.Size = new System.Drawing.Size(74, 17);
            this.pendingRadioButton.TabIndex = 0;
            this.pendingRadioButton.TabStop = true;
            this.pendingRadioButton.Text = "PENDING";
            this.pendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchByStatus
            // 
            this.searchByStatus.BackColor = System.Drawing.Color.LightBlue;
            this.searchByStatus.FlatAppearance.BorderSize = 0;
            this.searchByStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchByStatus.Location = new System.Drawing.Point(699, 102);
            this.searchByStatus.Name = "searchByStatus";
            this.searchByStatus.Size = new System.Drawing.Size(75, 23);
            this.searchByStatus.TabIndex = 18;
            this.searchByStatus.Text = "Search";
            this.searchByStatus.UseVisualStyleBackColor = false;
            this.searchByStatus.Click += new System.EventHandler(this.searchByStatus_Click);
            // 
            // generatePDF
            // 
            this.generatePDF.BackColor = System.Drawing.Color.LightBlue;
            this.generatePDF.FlatAppearance.BorderSize = 0;
            this.generatePDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatePDF.Location = new System.Drawing.Point(704, 6);
            this.generatePDF.Name = "generatePDF";
            this.generatePDF.Size = new System.Drawing.Size(70, 70);
            this.generatePDF.TabIndex = 19;
            this.generatePDF.Text = "Generate PDF";
            this.generatePDF.UseVisualStyleBackColor = false;
            this.generatePDF.Click += new System.EventHandler(this.generatePDF_Click);
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(844, 341);
            this.Controls.Add(this.generatePDF);
            this.Controls.Add(this.searchByStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchBySerialNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchSerialNumber);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.addTicket);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ServiceForm";
            this.Text = "ServiceForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox searchSerialNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchBySerialNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton doneRadioButton;
        private System.Windows.Forms.RadioButton toVerifyRadioButton;
        private System.Windows.Forms.RadioButton inRealizationRadioButton;
        private System.Windows.Forms.RadioButton pendingRadioButton;
        private System.Windows.Forms.Button searchByStatus;
        private System.Windows.Forms.Button generatePDF;
    }
}
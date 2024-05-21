﻿namespace ERPWindowsForms
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.service_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.languageSelector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(237, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "What do you want to do?";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(58, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 73);
            this.button1.TabIndex = 2;
            this.button1.Text = "(Under construction)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(364, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 73);
            this.button2.TabIndex = 3;
            this.button2.Text = "(Under construction)";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // service_button
            // 
            this.service_button.Location = new System.Drawing.Point(684, 161);
            this.service_button.Name = "service_button";
            this.service_button.Size = new System.Drawing.Size(249, 73);
            this.service_button.TabIndex = 4;
            this.service_button.Text = "Service";
            this.service_button.UseVisualStyleBackColor = true;
            this.service_button.Click += new System.EventHandler(this.service_button_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(58, 311);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(238, 73);
            this.button4.TabIndex = 5;
            this.button4.Text = "(Under construction)";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(364, 311);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(245, 73);
            this.button5.TabIndex = 6;
            this.button5.Text = "(Under construction)";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(684, 311);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(249, 73);
            this.button6.TabIndex = 7;
            this.button6.Text = "(Under construction)";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // languageSelector
            // 
            this.languageSelector.FormattingEnabled = true;
            this.languageSelector.Items.AddRange(new object[] {
            "Polish",
            "English"});
            this.languageSelector.Location = new System.Drawing.Point(812, 36);
            this.languageSelector.Name = "languageSelector";
            this.languageSelector.Size = new System.Drawing.Size(121, 28);
            this.languageSelector.TabIndex = 8;
            this.languageSelector.SelectedIndexChanged += new System.EventHandler(this.languageSelector_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 510);
            this.Controls.Add(this.languageSelector);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.service_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ERP_Gr2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button service_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox languageSelector;
    }
}


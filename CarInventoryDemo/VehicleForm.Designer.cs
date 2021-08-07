
namespace CarInventoryDemo
{
    partial class VehicleForm
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
            this.tabNewVehicle = new System.Windows.Forms.TabControl();
            this.tabNewVehcile = new System.Windows.Forms.TabPage();
            this.lbLicense = new System.Windows.Forms.Label();
            this.tabpage2 = new System.Windows.Forms.TabPage();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.txtbVin = new System.Windows.Forms.TextBox();
            this.lblVin = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbResults = new System.Windows.Forms.TextBox();
            this.lbInventory = new System.Windows.Forms.ListBox();
            this.tbSummary = new System.Windows.Forms.TextBox();
            this.tabNewVehicle.SuspendLayout();
            this.tabNewVehcile.SuspendLayout();
            this.tabpage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabNewVehicle
            // 
            this.tabNewVehicle.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabNewVehicle.Controls.Add(this.tabNewVehcile);
            this.tabNewVehicle.Controls.Add(this.tabpage2);
            this.tabNewVehicle.Location = new System.Drawing.Point(-4, 12);
            this.tabNewVehicle.Multiline = true;
            this.tabNewVehicle.Name = "tabNewVehicle";
            this.tabNewVehicle.SelectedIndex = 0;
            this.tabNewVehicle.Size = new System.Drawing.Size(367, 420);
            this.tabNewVehicle.TabIndex = 0;
            this.tabNewVehicle.SelectedIndexChanged += new System.EventHandler(this.tabNewVehicle_SelectedIndexChanged);
            // 
            // tabNewVehcile
            // 
            this.tabNewVehcile.Controls.Add(this.tbResults);
            this.tabNewVehcile.Controls.Add(this.btnAdd);
            this.tabNewVehcile.Controls.Add(this.label1);
            this.tabNewVehcile.Controls.Add(this.cbType);
            this.tabNewVehcile.Controls.Add(this.lblVin);
            this.tabNewVehcile.Controls.Add(this.txtbVin);
            this.tabNewVehcile.Controls.Add(this.txtLicense);
            this.tabNewVehcile.Controls.Add(this.lbLicense);
            this.tabNewVehcile.Location = new System.Drawing.Point(4, 4);
            this.tabNewVehcile.Name = "tabNewVehcile";
            this.tabNewVehcile.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewVehcile.Size = new System.Drawing.Size(336, 412);
            this.tabNewVehcile.TabIndex = 0;
            this.tabNewVehcile.Text = "New Vehicle Form";
            this.tabNewVehcile.UseVisualStyleBackColor = true;
            this.tabNewVehcile.Click += new System.EventHandler(this.tabNewVehcile_Click);
            // 
            // lbLicense
            // 
            this.lbLicense.AutoSize = true;
            this.lbLicense.Location = new System.Drawing.Point(29, 24);
            this.lbLicense.Name = "lbLicense";
            this.lbLicense.Size = new System.Drawing.Size(46, 15);
            this.lbLicense.TabIndex = 0;
            this.lbLicense.Text = "License";
            this.lbLicense.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabpage2
            // 
            this.tabpage2.Controls.Add(this.tbSummary);
            this.tabpage2.Controls.Add(this.lbInventory);
            this.tabpage2.Location = new System.Drawing.Point(4, 4);
            this.tabpage2.Name = "tabpage2";
            this.tabpage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage2.Size = new System.Drawing.Size(336, 412);
            this.tabpage2.TabIndex = 1;
            this.tabpage2.Text = "Inventory list";
            this.tabpage2.UseVisualStyleBackColor = true;
            this.tabpage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // txtLicense
            // 
            this.txtLicense.Location = new System.Drawing.Point(81, 24);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(198, 23);
            this.txtLicense.TabIndex = 1;
            // 
            // txtbVin
            // 
            this.txtbVin.Location = new System.Drawing.Point(81, 72);
            this.txtbVin.Name = "txtbVin";
            this.txtbVin.Size = new System.Drawing.Size(198, 23);
            this.txtbVin.TabIndex = 2;
            // 
            // lblVin
            // 
            this.lblVin.AutoSize = true;
            this.lblVin.Location = new System.Drawing.Point(29, 79);
            this.lblVin.Name = "lblVin";
            this.lblVin.Size = new System.Drawing.Size(26, 15);
            this.lblVin.TabIndex = 3;
            this.lblVin.Text = "VIN";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Sedan",
            "Truck"});
            this.cbType.Location = new System.Drawing.Point(81, 126);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(198, 23);
            this.cbType.TabIndex = 4;
            this.cbType.Text = "Sedan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(204, 164);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbResults
            // 
            this.tbResults.Location = new System.Drawing.Point(29, 204);
            this.tbResults.Multiline = true;
            this.tbResults.Name = "tbResults";
            this.tbResults.ReadOnly = true;
            this.tbResults.Size = new System.Drawing.Size(250, 159);
            this.tbResults.TabIndex = 7;
            // 
            // lbInventory
            // 
            this.lbInventory.FormattingEnabled = true;
            this.lbInventory.ItemHeight = 15;
            this.lbInventory.Location = new System.Drawing.Point(12, 25);
            this.lbInventory.Name = "lbInventory";
            this.lbInventory.Size = new System.Drawing.Size(268, 184);
            this.lbInventory.TabIndex = 0;
            // 
            // tbSummary
            // 
            this.tbSummary.Location = new System.Drawing.Point(12, 212);
            this.tbSummary.Multiline = true;
            this.tbSummary.Name = "tbSummary";
            this.tbSummary.ReadOnly = true;
            this.tbSummary.Size = new System.Drawing.Size(268, 192);
            this.tbSummary.TabIndex = 8;
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 432);
            this.Controls.Add(this.tabNewVehicle);
            this.Name = "VehicleForm";
            this.Text = "Form1";
            this.tabNewVehicle.ResumeLayout(false);
            this.tabNewVehcile.ResumeLayout(false);
            this.tabNewVehcile.PerformLayout();
            this.tabpage2.ResumeLayout(false);
            this.tabpage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabNewVehicle;
        private System.Windows.Forms.TabPage tabNewVehcile;
        private System.Windows.Forms.TabPage tabpage2;
        private System.Windows.Forms.Label lbLicense;
        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblVin;
        private System.Windows.Forms.TextBox txtbVin;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.TextBox tbSummary;
        private System.Windows.Forms.ListBox lbInventory;
    }
}


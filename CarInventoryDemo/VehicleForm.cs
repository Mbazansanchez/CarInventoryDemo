using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarInventoryDemo
{
    public partial class VehicleForm : Form
    {
        private List<Vehicle> vehicles = new List<Vehicle>();



        public VehicleForm()
        {
            InitializeComponent();
            lbInventory.DataSource = vehicles;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabNewVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabNewVehcile_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbType.Text.Equals("Sedan"))
            {
                Sedan sedan = new Sedan();
                sedan.LicensePlate = txtLicense.Text;
                sedan.VIN = txtbVin.Text;
                tbResults.Text = "Successfully added Sedan";
                lbInventory.DataSource = null;
                lbInventory.DataSource = vehicles;
                vehicles.Add(sedan);
            }
            else if (cbType.Text.Equals("Truck"))
            {
                Truck truck = new Truck();
           
                truck.LicensePlate = txtLicense.Text;
                truck.VIN = txtbVin.Text;
                tbResults.Text = "Successfully added Truck";
                lbInventory.DataSource = null;
                lbInventory.DataSource = vehicles;
                vehicles.Add(truck);

            }
        }
    }

    
}

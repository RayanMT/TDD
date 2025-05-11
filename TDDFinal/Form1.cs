using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace TDDFinal
{
    public partial class Form1 : Form
    {
        private List<Vehicle> vehicles = new List<Vehicle>();
        private readonly string filePath = "Vehicles.xlsx";
        private readonly Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            cmbType.Items.AddRange(new string[] { "Bus", "Commercial", "Private", "Truck" });
            cmbMaintenanceStatus.Items.AddRange(new string[] { "OK", "Needs Service" });

            nudYear.Minimum = 2000;
            nudYear.Maximum = 2025;
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                string vehicleNumber = txtVehicleNumber.Text.Trim();
                string model = txtModel.Text.Trim();
                string manufacturer = txtManufacturer.Text.Trim();
                int year = (int)nudYear.Value;
                string type = cmbType.SelectedItem?.ToString() ?? "";
                string maintenanceStatus = cmbMaintenanceStatus.SelectedItem?.ToString() ?? "";

                if (string.IsNullOrEmpty(vehicleNumber) || string.IsNullOrEmpty(model) || string.IsNullOrEmpty(manufacturer)
                    || string.IsNullOrEmpty(type) || string.IsNullOrEmpty(maintenanceStatus))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                var newVehicle = new Vehicle(vehicleNumber, model, manufacturer, year, type, maintenanceStatus);
                vehicles.Add(newVehicle);

                SaveVehicleToExcel(newVehicle);

                MessageBox.Show("Vehicle added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SaveVehicleToExcel(Vehicle vehicle)
        {
            bool fileExists = File.Exists(filePath);
            using (var workbook = fileExists ? new XLWorkbook(filePath) : new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.FirstOrDefault(ws => ws.Name == "Vehicles") ?? workbook.AddWorksheet("Vehicles");

                if (!fileExists || worksheet.Cell(1, 1).IsEmpty())
                {
                    worksheet.Cell(1, 1).Value = "Vehicle Number";
                    worksheet.Cell(1, 2).Value = "Model";
                    worksheet.Cell(1, 3).Value = "Manufacturer";
                    worksheet.Cell(1, 4).Value = "Year";
                    worksheet.Cell(1, 5).Value = "Type";
                    worksheet.Cell(1, 6).Value = "Maintenance Status";
                }

                int lastRow = worksheet.LastRowUsed()?.RowNumber() ?? 1;
                worksheet.Cell(lastRow + 1, 1).Value = vehicle.VehicleNumber;
                worksheet.Cell(lastRow + 1, 2).Value = vehicle.Model;
                worksheet.Cell(lastRow + 1, 3).Value = vehicle.Manufacturer;
                worksheet.Cell(lastRow + 1, 4).Value = vehicle.Year;
                worksheet.Cell(lastRow + 1, 5).Value = vehicle.Type;
                worksheet.Cell(lastRow + 1, 6).Value = vehicle.MaintenanceStatus;

                workbook.SaveAs(filePath);
            }
        }

        private void SaveAllVehiclesToExcel()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.AddWorksheet("Vehicles");

                worksheet.Cell(1, 1).Value = "Vehicle Number";
                worksheet.Cell(1, 2).Value = "Model";
                worksheet.Cell(1, 3).Value = "Manufacturer";
                worksheet.Cell(1, 4).Value = "Year";
                worksheet.Cell(1, 5).Value = "Type";
                worksheet.Cell(1, 6).Value = "Maintenance Status";

                for (int i = 0; i < vehicles.Count; i++)
                {
                    var v = vehicles[i];
                    worksheet.Cell(i + 2, 1).Value = v.VehicleNumber;
                    worksheet.Cell(i + 2, 2).Value = v.Model;
                    worksheet.Cell(i + 2, 3).Value = v.Manufacturer;
                    worksheet.Cell(i + 2, 4).Value = v.Year;
                    worksheet.Cell(i + 2, 5).Value = v.Type;
                    worksheet.Cell(i + 2, 6).Value = v.MaintenanceStatus;
                }

                workbook.SaveAs(filePath);
            }
        }

        private void btnGenerateRandom_Click(object sender, EventArgs e)
        {
            var types = new string[] { "Bus", "Commercial", "Private", "Truck" };
            var statuses = new string[] { "OK", "Needs Service" };

            for (int i = 0; i < 10000; i++)
            {
                var vehicle = new Vehicle(
                    vehicleNumber: random.Next(100000, 999999).ToString(),
                    model: "Model " + random.Next(1, 100),
                    manufacturer: "Manufacturer " + random.Next(1, 50),
                    year: random.Next(2000, 2026),
                    type: types[random.Next(types.Length)],
                    maintenanceStatus: statuses[random.Next(statuses.Length)]
                );
                vehicles.Add(vehicle);
            }

            SaveAllVehiclesToExcel();
            MessageBox.Show("10,000 vehicles generated and saved!");
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("No vehicles to report.");
                return;
            }

            List<Vehicle> loadedVehicles;

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet("Vehicles");
                loadedVehicles = worksheet.RangeUsed()
                    .RowsUsed()
                    .Skip(1)
                    .Select(r => new Vehicle(
                        r.Cell(1).GetString(),
                        r.Cell(2).GetString(),
                        r.Cell(3).GetString(),
                        int.Parse(r.Cell(4).GetString()),
                        r.Cell(5).GetString(),
                        r.Cell(6).GetString()
                    )).ToList();
            }

            if (loadedVehicles.Count == 0)
            {
                MessageBox.Show("No vehicles to report.");
                return;
            }

            // Manual bubble sort
            var start = DateTime.Now;
            var sorted = SortHelper.BubbleSort(loadedVehicles);
            var duration = DateTime.Now - start;

            int totalVehicles = sorted.Count;
            double avgYear = AverageHelper.CalculateAverageYear(sorted);
            int needsServiceCount = MaintenanceHelper.CountNeedsService(sorted);

            string report = $"Total Vehicles: {totalVehicles}\n" +
                            $"Average Production Year: {avgYear:F2}\n" +
                            $"'Needs Service' Vehicles: {needsServiceCount}\n" +
                            $"Sorting Duration: {duration.TotalMilliseconds:F2} ms\n\n";

            report += "Top 20 vehicles sorted by year (descending):\n";
            foreach (var v in sorted)
            {
                report += $"{v.Year} - {v.Manufacturer} {v.Model} [{v.Type}] - Status: {v.MaintenanceStatus}\n";
            }
            MessageBox.Show(report, "Vehicle Report");
        }
    }
}
namespace TDDFinal
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblVehicleNumber = new System.Windows.Forms.Label();
            this.txtVehicleNumber = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblMaintenanceStatus = new System.Windows.Forms.Label();
            this.cmbMaintenanceStatus = new System.Windows.Forms.ComboBox();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnGenerateRandom = new System.Windows.Forms.Button();
            this.btnShowReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.SuspendLayout();
            // 
            // 🔥 Basic form styling
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245); // light gray
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClientSize = new System.Drawing.Size(550, 420);
            this.Text = "🚗 Vehicle Registration System";

            // 🔥 Labels styling (dark gray)
            System.Drawing.Color labelColor = System.Drawing.Color.FromArgb(50, 50, 50);

            // lblVehicleNumber
            this.lblVehicleNumber.AutoSize = true;
            this.lblVehicleNumber.ForeColor = labelColor;
            this.lblVehicleNumber.Location = new System.Drawing.Point(50, 30);
            this.lblVehicleNumber.Text = "Vehicle Number";

            // txtVehicleNumber
            this.txtVehicleNumber.Location = new System.Drawing.Point(220, 27);
            this.txtVehicleNumber.Size = new System.Drawing.Size(200, 30);

            // lblModel
            this.lblModel.AutoSize = true;
            this.lblModel.ForeColor = labelColor;
            this.lblModel.Location = new System.Drawing.Point(50, 75);
            this.lblModel.Text = "Model";

            // txtModel
            this.txtModel.Location = new System.Drawing.Point(220, 72);
            this.txtModel.Size = new System.Drawing.Size(200, 30);

            // lblManufacturer
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.ForeColor = labelColor;
            this.lblManufacturer.Location = new System.Drawing.Point(50, 120);
            this.lblManufacturer.Text = "Manufacturer";

            // txtManufacturer
            this.txtManufacturer.Location = new System.Drawing.Point(220, 117);
            this.txtManufacturer.Size = new System.Drawing.Size(200, 30);

            // lblYear
            this.lblYear.AutoSize = true;
            this.lblYear.ForeColor = labelColor;
            this.lblYear.Location = new System.Drawing.Point(50, 165);
            this.lblYear.Text = "Year";

            // nudYear
            this.nudYear.Location = new System.Drawing.Point(220, 162);
            this.nudYear.Size = new System.Drawing.Size(200, 30);

            // lblType
            this.lblType.AutoSize = true;
            this.lblType.ForeColor = labelColor;
            this.lblType.Location = new System.Drawing.Point(50, 210);
            this.lblType.Text = "Type";

            // cmbType
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Location = new System.Drawing.Point(220, 207);
            this.cmbType.Size = new System.Drawing.Size(200, 30);

            // lblMaintenanceStatus
            this.lblMaintenanceStatus.AutoSize = true;
            this.lblMaintenanceStatus.ForeColor = labelColor;
            this.lblMaintenanceStatus.Location = new System.Drawing.Point(50, 255);
            this.lblMaintenanceStatus.Text = "Maintenance Status";

            // cmbMaintenanceStatus
            this.cmbMaintenanceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaintenanceStatus.Location = new System.Drawing.Point(220, 252);
            this.cmbMaintenanceStatus.Size = new System.Drawing.Size(200, 30);

            // Button styles
            System.Drawing.Color buttonColor = System.Drawing.Color.MediumSlateBlue;
            System.Drawing.Color hoverColor = System.Drawing.Color.SlateBlue;
            System.Drawing.Color textColor = System.Drawing.Color.White;

            // btnAddVehicle
            this.btnAddVehicle.BackColor = buttonColor;
            this.btnAddVehicle.ForeColor = textColor;
            this.btnAddVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVehicle.FlatAppearance.BorderSize = 0;
            this.btnAddVehicle.Location = new System.Drawing.Point(50, 310);
            this.btnAddVehicle.Size = new System.Drawing.Size(150, 40);
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);

            // btnGenerateRandom
            this.btnGenerateRandom.BackColor = buttonColor;
            this.btnGenerateRandom.ForeColor = textColor;
            this.btnGenerateRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateRandom.FlatAppearance.BorderSize = 0;
            this.btnGenerateRandom.Location = new System.Drawing.Point(220, 310);
            this.btnGenerateRandom.Size = new System.Drawing.Size(200, 40);
            this.btnGenerateRandom.Text = "Generate 10,000 Vehicles";
            this.btnGenerateRandom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateRandom.Click += new System.EventHandler(this.btnGenerateRandom_Click);

            // btnShowReport
            this.btnShowReport.BackColor = buttonColor;
            this.btnShowReport.ForeColor = textColor;
            this.btnShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowReport.FlatAppearance.BorderSize = 0;
            this.btnShowReport.Location = new System.Drawing.Point(135, 360);
            this.btnShowReport.Size = new System.Drawing.Size(250, 40);
            this.btnShowReport.Text = "Show Report 📊";
            this.btnShowReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);

            // Hover effects
            this.btnAddVehicle.MouseEnter += (s, e) => btnAddVehicle.BackColor = hoverColor;
            this.btnAddVehicle.MouseLeave += (s, e) => btnAddVehicle.BackColor = buttonColor;
            this.btnGenerateRandom.MouseEnter += (s, e) => btnGenerateRandom.BackColor = hoverColor;
            this.btnGenerateRandom.MouseLeave += (s, e) => btnGenerateRandom.BackColor = buttonColor;
            this.btnShowReport.MouseEnter += (s, e) => btnShowReport.BackColor = hoverColor;
            this.btnShowReport.MouseLeave += (s, e) => btnShowReport.BackColor = buttonColor;

            // Add controls
            this.Controls.Add(this.lblVehicleNumber);
            this.Controls.Add(this.txtVehicleNumber);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblMaintenanceStatus);
            this.Controls.Add(this.cmbMaintenanceStatus);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.btnGenerateRandom);
            this.Controls.Add(this.btnShowReport);

            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblVehicleNumber;
        private System.Windows.Forms.TextBox txtVehicleNumber;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblMaintenanceStatus;
        private System.Windows.Forms.ComboBox cmbMaintenanceStatus;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnGenerateRandom;
        private System.Windows.Forms.Button btnShowReport;
    }
}

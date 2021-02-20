
namespace CustomerInformation
{
    partial class frmCustomerList
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
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.lblDetailsHeader = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCustomers
            // 
            this.lstCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 25;
            this.lstCustomers.Location = new System.Drawing.Point(39, 75);
            this.lstCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(399, 329);
            this.lstCustomers.TabIndex = 0;
           
            // 
            // lblDetailsHeader
            // 
            this.lblDetailsHeader.AutoSize = true;
            this.lblDetailsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsHeader.Location = new System.Drawing.Point(493, 50);
            this.lblDetailsHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailsHeader.Name = "lblDetailsHeader";
            this.lblDetailsHeader.Size = new System.Drawing.Size(85, 25);
            this.lblDetailsHeader.TabIndex = 1;
            this.lblDetailsHeader.Text = "Details:";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(499, 80);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(0, 25);
            this.lblDetails.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(39, 431);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(128, 65);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(196, 431);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 65);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.Location = new System.Drawing.Point(34, 50);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(116, 25);
            this.lblCustomers.TabIndex = 5;
            this.lblCustomers.Text = "Customers";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(735, 431);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(146, 65);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
        
            // 
            // frmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 506);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblDetailsHeader);
            this.Controls.Add(this.lstCustomers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomerList";
            this.Text = "Customer List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label lblDetailsHeader;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Button btnExit;
    }
}


namespace FurnitureManager.View
{
    partial class OrderForm
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
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.retrieveOrder = new System.Windows.Forms.Button();
            this.editOrder = new System.Windows.Forms.Button();
            this.addOrder = new System.Windows.Forms.Button();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(159, 168);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(140, 20);
            this.txtdate.TabIndex = 27;
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(150, 218);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(100, 20);
            this.txtstatus.TabIndex = 25;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(150, 120);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(100, 20);
            this.txtaddress.TabIndex = 24;
            // 
            // txtcustomer
            // 
            this.txtcustomer.Location = new System.Drawing.Point(150, 72);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(100, 20);
            this.txtcustomer.TabIndex = 23;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(150, 26);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Delivery Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID";
            // 
            // retrieveOrder
            // 
            this.retrieveOrder.Location = new System.Drawing.Point(605, 220);
            this.retrieveOrder.Name = "retrieveOrder";
            this.retrieveOrder.Size = new System.Drawing.Size(75, 23);
            this.retrieveOrder.TabIndex = 30;
            this.retrieveOrder.Text = "Retrieve";
            this.retrieveOrder.UseVisualStyleBackColor = true;
 
            // 
            // editOrder
            // 
            this.editOrder.Location = new System.Drawing.Point(461, 220);
            this.editOrder.Name = "editOrder";
            this.editOrder.Size = new System.Drawing.Size(75, 23);
            this.editOrder.TabIndex = 29;
            this.editOrder.Text = "Edit Order";
            this.editOrder.UseVisualStyleBackColor = true;
         
            // 
            // addOrder
            // 
            this.addOrder.Location = new System.Drawing.Point(329, 220);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(75, 23);
            this.addOrder.TabIndex = 28;
            this.addOrder.Text = "Add Order";
            this.addOrder.UseVisualStyleBackColor = true;
         
            // 
            // orderListBox
            // 
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.Location = new System.Drawing.Point(531, 45);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(444, 134);
            this.orderListBox.TabIndex = 32;
            
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 261);
            this.Controls.Add(this.orderListBox);
            this.Controls.Add(this.retrieveOrder);
            this.Controls.Add(this.editOrder);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtcustomer);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtcustomer;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button retrieveOrder;
        private System.Windows.Forms.Button editOrder;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.ListBox orderListBox;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}
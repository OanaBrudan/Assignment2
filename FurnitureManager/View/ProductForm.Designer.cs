namespace FurnitureManager.View
{
    partial class ProductForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.viewBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.textstock = new System.Windows.Forms.TextBox();
            this.textprice = new System.Windows.Forms.TextBox();
            this.textsize = new System.Windows.Forms.TextBox();
            this.textcolor = new System.Windows.Forms.TextBox();
            this.textdescription = new System.Windows.Forms.TextBox();
            this.texttitle = new System.Windows.Forms.TextBox();
            this.textid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.productListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-173, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-173, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-173, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Delivery Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-173, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-173, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID";
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(752, 256);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(75, 23);
            this.viewBtn.TabIndex = 41;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.view_clk);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(632, 256);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 40;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.delete_clk);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(506, 255);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 39;
            this.editBtn.Text = "Update";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.update_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(384, 255);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 38;
            this.addBtn.Text = "Create";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.create_clk);
            // 
            // textstock
            // 
            this.textstock.Location = new System.Drawing.Point(186, 258);
            this.textstock.Name = "textstock";
            this.textstock.Size = new System.Drawing.Size(100, 20);
            this.textstock.TabIndex = 36;
            // 
            // textprice
            // 
            this.textprice.Location = new System.Drawing.Point(186, 225);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(100, 20);
            this.textprice.TabIndex = 35;
            // 
            // textsize
            // 
            this.textsize.Location = new System.Drawing.Point(186, 192);
            this.textsize.Name = "textsize";
            this.textsize.Size = new System.Drawing.Size(100, 20);
            this.textsize.TabIndex = 34;
            // 
            // textcolor
            // 
            this.textcolor.Location = new System.Drawing.Point(186, 155);
            this.textcolor.Name = "textcolor";
            this.textcolor.Size = new System.Drawing.Size(100, 20);
            this.textcolor.TabIndex = 33;
            // 
            // textdescription
            // 
            this.textdescription.Location = new System.Drawing.Point(186, 121);
            this.textdescription.Name = "textdescription";
            this.textdescription.Size = new System.Drawing.Size(100, 20);
            this.textdescription.TabIndex = 32;
            // 
            // texttitle
            // 
            this.texttitle.Location = new System.Drawing.Point(186, 85);
            this.texttitle.Name = "texttitle";
            this.texttitle.Size = new System.Drawing.Size(100, 20);
            this.texttitle.TabIndex = 31;
            // 
            // textid
            // 
            this.textid.BackColor = System.Drawing.Color.White;
            this.textid.Location = new System.Drawing.Point(186, 50);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(100, 20);
            this.textid.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Color";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(86, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Description";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Title";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(86, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Id product";
            // 
            // productListBox
            // 
            this.productListBox.FormattingEnabled = true;
            this.productListBox.Location = new System.Drawing.Point(353, 50);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(521, 173);
            this.productListBox.TabIndex = 42;
            this.productListBox.SelectedIndexChanged += new System.EventHandler(this.productListBox_SelectedIndexChanged);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 325);
            this.Controls.Add(this.productListBox);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.textstock);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.textsize);
            this.Controls.Add(this.textcolor);
            this.Controls.Add(this.textdescription);
            this.Controls.Add(this.texttitle);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox textstock;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.TextBox textsize;
        private System.Windows.Forms.TextBox textcolor;
        private System.Windows.Forms.TextBox textdescription;
        private System.Windows.Forms.TextBox texttitle;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox productListBox;
    }
}
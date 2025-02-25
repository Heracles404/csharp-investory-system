﻿
namespace InventorySystem
{
    partial class orders
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
            this.backBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.TextBox();
            this.orderNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchOrder = new System.Windows.Forms.TextBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.recordList = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.orderStatus = new System.Windows.Forms.ComboBox();
            this.dateOfPurchase = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.recordList)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Tan;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Font = new System.Drawing.Font("Dutch801 Rm BT", 10F);
            this.backBtn.Location = new System.Drawing.Point(673, 262);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(97, 31);
            this.backBtn.TabIndex = 23;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Tan;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Font = new System.Drawing.Font("Dutch801 Rm BT", 10F);
            this.clearBtn.Location = new System.Drawing.Point(570, 262);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(97, 31);
            this.clearBtn.TabIndex = 22;
            this.clearBtn.Text = "Clear Search";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(129, 151);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(187, 20);
            this.price.TabIndex = 21;
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(129, 80);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(187, 20);
            this.customerName.TabIndex = 19;
            // 
            // orderNumber
            // 
            this.orderNumber.Location = new System.Drawing.Point(129, 45);
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.Size = new System.Drawing.Size(187, 20);
            this.orderNumber.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dutch801 Rm BT", 10F);
            this.label5.Location = new System.Drawing.Point(6, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Date of Purchase:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dutch801 Rm BT", 10F);
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Customer Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dutch801 Rm BT", 10F);
            this.label4.Location = new System.Drawing.Point(81, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dutch801 Rm BT", 10F);
            this.label2.Location = new System.Drawing.Point(27, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Oder Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dutch801 Rm BT", 10F);
            this.label1.Location = new System.Drawing.Point(324, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Order Number:";
            // 
            // searchOrder
            // 
            this.searchOrder.Location = new System.Drawing.Point(431, 18);
            this.searchOrder.Name = "searchOrder";
            this.searchOrder.Size = new System.Drawing.Size(176, 20);
            this.searchOrder.TabIndex = 12;
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.Tan;
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delBtn.Font = new System.Drawing.Font("Dutch801 Rm BT", 10F);
            this.delBtn.Location = new System.Drawing.Point(695, 16);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 10;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.BackColor = System.Drawing.Color.Tan;
            this.insertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insertBtn.Font = new System.Drawing.Font("Dutch801 Rm BT", 10F);
            this.insertBtn.Location = new System.Drawing.Point(219, 224);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(97, 31);
            this.insertBtn.TabIndex = 9;
            this.insertBtn.Text = "Add Order";
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Tan;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateBtn.Font = new System.Drawing.Font("Dutch801 Rm BT", 10F);
            this.updateBtn.Location = new System.Drawing.Point(219, 262);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(97, 31);
            this.updateBtn.TabIndex = 8;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Tan;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBtn.Font = new System.Drawing.Font("Dutch801 Rm BT", 10F);
            this.searchBtn.Location = new System.Drawing.Point(613, 16);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 11;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // recordList
            // 
            this.recordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordList.Location = new System.Drawing.Point(322, 46);
            this.recordList.Name = "recordList";
            this.recordList.Size = new System.Drawing.Size(448, 210);
            this.recordList.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dutch801 Rm BT", 10F);
            this.label6.Location = new System.Drawing.Point(33, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Order Status:";
            // 
            // orderStatus
            // 
            this.orderStatus.FormattingEnabled = true;
            this.orderStatus.Items.AddRange(new object[] {
            "Processing",
            "Fulfilled ",
            "Returned"});
            this.orderStatus.Location = new System.Drawing.Point(129, 187);
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.Size = new System.Drawing.Size(187, 21);
            this.orderStatus.TabIndex = 24;
            // 
            // dateOfPurchase
            // 
            this.dateOfPurchase.Location = new System.Drawing.Point(129, 116);
            this.dateOfPurchase.Name = "dateOfPurchase";
            this.dateOfPurchase.Size = new System.Drawing.Size(187, 20);
            this.dateOfPurchase.TabIndex = 25;
            // 
            // orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(782, 309);
            this.Controls.Add(this.dateOfPurchase);
            this.Controls.Add(this.orderStatus);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.price);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.orderNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchOrder);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.recordList);
            this.MaximizeBox = false;
            this.Name = "orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Record";
            this.Load += new System.EventHandler(this.orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recordList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.TextBox orderNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchOrder;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView recordList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox orderStatus;
        private System.Windows.Forms.DateTimePicker dateOfPurchase;
    }
}
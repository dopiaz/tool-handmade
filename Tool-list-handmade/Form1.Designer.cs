﻿namespace Tool_list_handmade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_asin_clone = new System.Windows.Forms.TextBox();
            this.tb_sku_clone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_create_profile = new System.Windows.Forms.Button();
            this.tb_market_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_other_images = new System.Windows.Forms.Label();
            this.lb_products = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_asin_clone
            // 
            this.tb_asin_clone.Location = new System.Drawing.Point(474, 91);
            this.tb_asin_clone.Name = "tb_asin_clone";
            this.tb_asin_clone.Size = new System.Drawing.Size(205, 26);
            this.tb_asin_clone.TabIndex = 18;
            // 
            // tb_sku_clone
            // 
            this.tb_sku_clone.Location = new System.Drawing.Point(474, 142);
            this.tb_sku_clone.Name = "tb_sku_clone";
            this.tb_sku_clone.Size = new System.Drawing.Size(205, 26);
            this.tb_sku_clone.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Asin clone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sku clone";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(35, 218);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(253, 83);
            this.btn_start.TabIndex = 22;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // btn_create_profile
            // 
            this.btn_create_profile.Location = new System.Drawing.Point(35, 28);
            this.btn_create_profile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_create_profile.Name = "btn_create_profile";
            this.btn_create_profile.Size = new System.Drawing.Size(135, 35);
            this.btn_create_profile.TabIndex = 23;
            this.btn_create_profile.Text = "Tạo mới profile";
            this.btn_create_profile.UseVisualStyleBackColor = true;
            this.btn_create_profile.Click += new System.EventHandler(this.Btn_create_profile_Click);
            // 
            // tb_market_id
            // 
            this.tb_market_id.Location = new System.Drawing.Point(474, 192);
            this.tb_market_id.Name = "tb_market_id";
            this.tb_market_id.Size = new System.Drawing.Size(205, 26);
            this.tb_market_id.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Market ID";
            // 
            // lb_other_images
            // 
            this.lb_other_images.AutoSize = true;
            this.lb_other_images.Location = new System.Drawing.Point(32, 88);
            this.lb_other_images.Name = "lb_other_images";
            this.lb_other_images.Size = new System.Drawing.Size(138, 20);
            this.lb_other_images.TabIndex = 27;
            this.lb_other_images.Text = "Có 0 hình ảnh phụ";
            // 
            // lb_products
            // 
            this.lb_products.AutoSize = true;
            this.lb_products.Location = new System.Drawing.Point(31, 142);
            this.lb_products.Name = "lb_products";
            this.lb_products.Size = new System.Drawing.Size(116, 20);
            this.lb_products.TabIndex = 28;
            this.lb_products.Text = "Có 0 sản phẩm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 354);
            this.Controls.Add(this.lb_products);
            this.Controls.Add(this.lb_other_images);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_market_id);
            this.Controls.Add(this.btn_create_profile);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_sku_clone);
            this.Controls.Add(this.tb_asin_clone);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tool list handemade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_asin_clone;
        private System.Windows.Forms.TextBox tb_sku_clone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_create_profile;
        private System.Windows.Forms.TextBox tb_market_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_other_images;
        private System.Windows.Forms.Label lb_products;
    }
}


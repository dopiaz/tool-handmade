namespace Tool_list_handmade
{
    partial class createProfile
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
            this.lb_profile_name = new System.Windows.Forms.Label();
            this.tb_profile_name = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_profile_name
            // 
            this.lb_profile_name.AutoSize = true;
            this.lb_profile_name.Location = new System.Drawing.Point(68, 66);
            this.lb_profile_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_profile_name.Name = "lb_profile_name";
            this.lb_profile_name.Size = new System.Drawing.Size(99, 20);
            this.lb_profile_name.TabIndex = 2;
            this.lb_profile_name.Text = "Profile Name";
            // 
            // tb_profile_name
            // 
            this.tb_profile_name.Location = new System.Drawing.Point(211, 60);
            this.tb_profile_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_profile_name.Name = "tb_profile_name";
            this.tb_profile_name.Size = new System.Drawing.Size(229, 26);
            this.tb_profile_name.TabIndex = 3;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(191, 174);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(112, 35);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // createProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 239);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tb_profile_name);
            this.Controls.Add(this.lb_profile_name);
            this.Name = "createProfile";
            this.Text = "createProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_profile_name;
        private System.Windows.Forms.TextBox tb_profile_name;
        private System.Windows.Forms.Button btn_ok;
    }
}
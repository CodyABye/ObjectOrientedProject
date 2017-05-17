namespace Group_Project
{
    partial class AddServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServerFirstName = new System.Windows.Forms.TextBox();
            this.txtServerLastName = new System.Windows.Forms.TextBox();
            this.btnServerAssign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // txtServerFirstName
            // 
            this.txtServerFirstName.Location = new System.Drawing.Point(207, 96);
            this.txtServerFirstName.Name = "txtServerFirstName";
            this.txtServerFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtServerFirstName.TabIndex = 3;
            // 
            // txtServerLastName
            // 
            this.txtServerLastName.Location = new System.Drawing.Point(207, 125);
            this.txtServerLastName.Name = "txtServerLastName";
            this.txtServerLastName.Size = new System.Drawing.Size(100, 20);
            this.txtServerLastName.TabIndex = 4;
            // 
            // btnServerAssign
            // 
            this.btnServerAssign.Location = new System.Drawing.Point(156, 172);
            this.btnServerAssign.Name = "btnServerAssign";
            this.btnServerAssign.Size = new System.Drawing.Size(75, 23);
            this.btnServerAssign.TabIndex = 5;
            this.btnServerAssign.Text = "Assign Server ";
            this.btnServerAssign.UseVisualStyleBackColor = true;
            this.btnServerAssign.Click += new System.EventHandler(this.btnServerAssign_Click);
            // 
            // AddServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 251);
            this.Controls.Add(this.btnServerAssign);
            this.Controls.Add(this.txtServerLastName);
            this.Controls.Add(this.txtServerFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddServer";
            this.Text = "AddServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServerFirstName;
        private System.Windows.Forms.TextBox txtServerLastName;
        private System.Windows.Forms.Button btnServerAssign;
    }
}
namespace Group_Project
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
            this.grpServers = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnServerAssign = new System.Windows.Forms.Button();
            this.btnServerAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpParties = new System.Windows.Forms.GroupBox();
            this.btnPartiesAssign = new System.Windows.Forms.Button();
            this.btnPartiesAdd = new System.Windows.Forms.Button();
            this.grpTables = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnServerRemove = new System.Windows.Forms.Button();
            this.btnPartyRemove = new System.Windows.Forms.Button();
            this.grpServers.SuspendLayout();
            this.grpParties.SuspendLayout();
            this.grpTables.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpServers
            // 
            this.grpServers.Controls.Add(this.btnServerRemove);
            this.grpServers.Controls.Add(this.listBox1);
            this.grpServers.Controls.Add(this.btnServerAssign);
            this.grpServers.Controls.Add(this.btnServerAdd);
            this.grpServers.Location = new System.Drawing.Point(764, 65);
            this.grpServers.Name = "grpServers";
            this.grpServers.Size = new System.Drawing.Size(270, 247);
            this.grpServers.TabIndex = 0;
            this.grpServers.TabStop = false;
            this.grpServers.Text = "Servers";
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(257, 186);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnServerAssign
            // 
            this.btnServerAssign.Location = new System.Drawing.Point(88, 218);
            this.btnServerAssign.Name = "btnServerAssign";
            this.btnServerAssign.Size = new System.Drawing.Size(75, 23);
            this.btnServerAssign.TabIndex = 1;
            this.btnServerAssign.Text = "Assign";
            this.btnServerAssign.UseVisualStyleBackColor = true;
            // 
            // btnServerAdd
            // 
            this.btnServerAdd.Location = new System.Drawing.Point(7, 218);
            this.btnServerAdd.Name = "btnServerAdd";
            this.btnServerAdd.Size = new System.Drawing.Size(75, 23);
            this.btnServerAdd.TabIndex = 0;
            this.btnServerAdd.Text = "Add";
            this.btnServerAdd.UseVisualStyleBackColor = true;
            this.btnServerAdd.Click += new System.EventHandler(this.BtnServerAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Restaurant Program";
            // 
            // grpParties
            // 
            this.grpParties.Controls.Add(this.btnPartyRemove);
            this.grpParties.Controls.Add(this.btnPartiesAssign);
            this.grpParties.Controls.Add(this.listBox2);
            this.grpParties.Controls.Add(this.btnPartiesAdd);
            this.grpParties.Location = new System.Drawing.Point(764, 312);
            this.grpParties.Name = "grpParties";
            this.grpParties.Size = new System.Drawing.Size(270, 247);
            this.grpParties.TabIndex = 2;
            this.grpParties.TabStop = false;
            this.grpParties.Text = "Parties";
            // 
            // btnPartiesAssign
            // 
            this.btnPartiesAssign.Location = new System.Drawing.Point(88, 218);
            this.btnPartiesAssign.Name = "btnPartiesAssign";
            this.btnPartiesAssign.Size = new System.Drawing.Size(75, 23);
            this.btnPartiesAssign.TabIndex = 1;
            this.btnPartiesAssign.Text = "Assign";
            this.btnPartiesAssign.UseVisualStyleBackColor = true;
            // 
            // btnPartiesAdd
            // 
            this.btnPartiesAdd.Location = new System.Drawing.Point(7, 218);
            this.btnPartiesAdd.Name = "btnPartiesAdd";
            this.btnPartiesAdd.Size = new System.Drawing.Size(75, 23);
            this.btnPartiesAdd.TabIndex = 0;
            this.btnPartiesAdd.Text = "Add";
            this.btnPartiesAdd.UseVisualStyleBackColor = true;
            this.btnPartiesAdd.Click += new System.EventHandler(this.BtnPartiesAdd_Click);
            // 
            // grpTables
            // 
            this.grpTables.Controls.Add(this.listBox3);
            this.grpTables.Location = new System.Drawing.Point(28, 65);
            this.grpTables.Name = "grpTables";
            this.grpTables.Size = new System.Drawing.Size(717, 494);
            this.grpTables.TabIndex = 3;
            this.grpTables.TabStop = false;
            this.grpTables.Text = "Tables";
            // 
            // listBox2
            // 
            this.listBox2.AllowDrop = true;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(7, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(257, 186);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.AllowDrop = true;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(208, 128);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(257, 186);
            this.listBox3.TabIndex = 2;
            // 
            // btnServerRemove
            // 
            this.btnServerRemove.Location = new System.Drawing.Point(169, 218);
            this.btnServerRemove.Name = "btnServerRemove";
            this.btnServerRemove.Size = new System.Drawing.Size(75, 23);
            this.btnServerRemove.TabIndex = 3;
            this.btnServerRemove.Text = "Remove";
            this.btnServerRemove.UseVisualStyleBackColor = true;
            // 
            // btnPartyRemove
            // 
            this.btnPartyRemove.Location = new System.Drawing.Point(169, 218);
            this.btnPartyRemove.Name = "btnPartyRemove";
            this.btnPartyRemove.Size = new System.Drawing.Size(75, 23);
            this.btnPartyRemove.TabIndex = 4;
            this.btnPartyRemove.Text = "Remove";
            this.btnPartyRemove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 584);
            this.Controls.Add(this.grpTables);
            this.Controls.Add(this.grpParties);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpServers);
            this.Name = "Form1";
            this.Text = "Restaurants";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpServers.ResumeLayout(false);
            this.grpParties.ResumeLayout(false);
            this.grpTables.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpServers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpParties;
        private System.Windows.Forms.Button btnServerAssign;
        private System.Windows.Forms.Button btnServerAdd;
        private System.Windows.Forms.Button btnPartiesAssign;
        private System.Windows.Forms.Button btnPartiesAdd;
        private System.Windows.Forms.GroupBox grpTables;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnServerRemove;
        private System.Windows.Forms.Button btnPartyRemove;
    }
}


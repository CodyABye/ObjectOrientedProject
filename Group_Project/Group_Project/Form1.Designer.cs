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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstWaitList = new System.Windows.Forms.ListBox();
            this.txtpSize = new System.Windows.Forms.TextBox();
            this.txtpName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPartiesAssign = new System.Windows.Forms.Button();
            this.btnPartiesAdd = new System.Windows.Forms.Button();
            this.grpTables = new System.Windows.Forms.GroupBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.grpServers.SuspendLayout();
            this.grpParties.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpTables.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpServers
            // 
            this.grpServers.Controls.Add(this.listBox1);
            this.grpServers.Controls.Add(this.btnServerAssign);
            this.grpServers.Controls.Add(this.btnServerAdd);
            this.grpServers.Location = new System.Drawing.Point(1019, 80);
            this.grpServers.Margin = new System.Windows.Forms.Padding(4);
            this.grpServers.Name = "grpServers";
            this.grpServers.Padding = new System.Windows.Forms.Padding(4);
            this.grpServers.Size = new System.Drawing.Size(360, 304);
            this.grpServers.TabIndex = 0;
            this.grpServers.TabStop = false;
            this.grpServers.Text = "Servers";
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(56, 48);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 116);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnServerAssign
            // 
            this.btnServerAssign.Location = new System.Drawing.Point(179, 268);
            this.btnServerAssign.Margin = new System.Windows.Forms.Padding(4);
            this.btnServerAssign.Name = "btnServerAssign";
            this.btnServerAssign.Size = new System.Drawing.Size(100, 28);
            this.btnServerAssign.TabIndex = 1;
            this.btnServerAssign.Text = "Assign";
            this.btnServerAssign.UseVisualStyleBackColor = true;
            // 
            // btnServerAdd
            // 
            this.btnServerAdd.Location = new System.Drawing.Point(69, 268);
            this.btnServerAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnServerAdd.Name = "btnServerAdd";
            this.btnServerAdd.Size = new System.Drawing.Size(100, 28);
            this.btnServerAdd.TabIndex = 0;
            this.btnServerAdd.Text = "Add";
            this.btnServerAdd.UseVisualStyleBackColor = true;
            this.btnServerAdd.Click += new System.EventHandler(this.BtnServerAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Restaurant Program";
            // 
            // grpParties
            // 
            this.grpParties.Controls.Add(this.groupBox1);
            this.grpParties.Controls.Add(this.txtpSize);
            this.grpParties.Controls.Add(this.txtpName);
            this.grpParties.Controls.Add(this.label3);
            this.grpParties.Controls.Add(this.label2);
            this.grpParties.Controls.Add(this.btnPartiesAssign);
            this.grpParties.Controls.Add(this.btnPartiesAdd);
            this.grpParties.Location = new System.Drawing.Point(1019, 384);
            this.grpParties.Margin = new System.Windows.Forms.Padding(4);
            this.grpParties.Name = "grpParties";
            this.grpParties.Padding = new System.Windows.Forms.Padding(4);
            this.grpParties.Size = new System.Drawing.Size(360, 304);
            this.grpParties.TabIndex = 2;
            this.grpParties.TabStop = false;
            this.grpParties.Text = "Parties";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstWaitList);
            this.groupBox1.Location = new System.Drawing.Point(25, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 163);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wait List";
            // 
            // lstWaitList
            // 
            this.lstWaitList.FormattingEnabled = true;
            this.lstWaitList.ItemHeight = 16;
            this.lstWaitList.Location = new System.Drawing.Point(19, 22);
            this.lstWaitList.Name = "lstWaitList";
            this.lstWaitList.Size = new System.Drawing.Size(203, 132);
            this.lstWaitList.TabIndex = 0;
            // 
            // txtpSize
            // 
            this.txtpSize.Location = new System.Drawing.Point(116, 50);
            this.txtpSize.Name = "txtpSize";
            this.txtpSize.Size = new System.Drawing.Size(100, 22);
            this.txtpSize.TabIndex = 5;
            // 
            // txtpName
            // 
            this.txtpName.Location = new System.Drawing.Point(116, 23);
            this.txtpName.Name = "txtpName";
            this.txtpName.Size = new System.Drawing.Size(100, 22);
            this.txtpName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Party Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Party Name";
            // 
            // btnPartiesAssign
            // 
            this.btnPartiesAssign.Location = new System.Drawing.Point(147, 79);
            this.btnPartiesAssign.Margin = new System.Windows.Forms.Padding(4);
            this.btnPartiesAssign.Name = "btnPartiesAssign";
            this.btnPartiesAssign.Size = new System.Drawing.Size(100, 28);
            this.btnPartiesAssign.TabIndex = 1;
            this.btnPartiesAssign.Text = "Assign";
            this.btnPartiesAssign.UseVisualStyleBackColor = true;
            // 
            // btnPartiesAdd
            // 
            this.btnPartiesAdd.Location = new System.Drawing.Point(14, 79);
            this.btnPartiesAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnPartiesAdd.Name = "btnPartiesAdd";
            this.btnPartiesAdd.Size = new System.Drawing.Size(100, 28);
            this.btnPartiesAdd.TabIndex = 0;
            this.btnPartiesAdd.Text = "Add Party";
            this.btnPartiesAdd.UseVisualStyleBackColor = true;
            this.btnPartiesAdd.Click += new System.EventHandler(this.BtnPartiesAdd_Click);
            // 
            // grpTables
            // 
            this.grpTables.Controls.Add(this.listBox4);
            this.grpTables.Controls.Add(this.listBox3);
            this.grpTables.Controls.Add(this.listBox2);
            this.grpTables.Location = new System.Drawing.Point(37, 86);
            this.grpTables.Margin = new System.Windows.Forms.Padding(4);
            this.grpTables.Name = "grpTables";
            this.grpTables.Padding = new System.Windows.Forms.Padding(4);
            this.grpTables.Size = new System.Drawing.Size(956, 608);
            this.grpTables.TabIndex = 3;
            this.grpTables.TabStop = false;
            this.grpTables.Text = "Tables";
            // 
            // listBox4
            // 
            this.listBox4.AllowDrop = true;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(8, 23);
            this.listBox4.Margin = new System.Windows.Forms.Padding(4);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(159, 116);
            this.listBox4.TabIndex = 2;
            // 
            // listBox3
            // 
            this.listBox3.AllowDrop = true;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(8, 148);
            this.listBox3.Margin = new System.Windows.Forms.Padding(4);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(159, 116);
            this.listBox3.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.AllowDrop = true;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(176, 23);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(159, 116);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 719);
            this.Controls.Add(this.grpTables);
            this.Controls.Add(this.grpParties);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpServers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Restaurants";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpServers.ResumeLayout(false);
            this.grpParties.ResumeLayout(false);
            this.grpParties.PerformLayout();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.TextBox txtpSize;
        private System.Windows.Forms.TextBox txtpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstWaitList;
    }
}


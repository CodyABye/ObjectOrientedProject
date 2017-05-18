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
            this.lstServers = new System.Windows.Forms.ListBox();
            this.btnServerAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpParties = new System.Windows.Forms.GroupBox();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpSize = new System.Windows.Forms.TextBox();
            this.txtpName = new System.Windows.Forms.TextBox();
            this.lstWaitList = new System.Windows.Forms.ListBox();
            this.btnPartiesAssign = new System.Windows.Forms.Button();
            this.btnPartiesAdd = new System.Windows.Forms.Button();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.pnlTables = new System.Windows.Forms.Panel();
            this.grpServers.SuspendLayout();
            this.grpParties.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpServers
            // 
            this.grpServers.Controls.Add(this.lstServers);
            this.grpServers.Controls.Add(this.btnServerAdd);
            this.grpServers.Location = new System.Drawing.Point(739, 65);
            this.grpServers.Name = "grpServers";
            this.grpServers.Size = new System.Drawing.Size(270, 197);
            this.grpServers.TabIndex = 0;
            this.grpServers.TabStop = false;
            this.grpServers.Text = "Servers";
            // 
            // lstServers
            // 
            this.lstServers.AllowDrop = true;
            this.lstServers.FormattingEnabled = true;
            this.lstServers.Location = new System.Drawing.Point(7, 19);
            this.lstServers.Name = "lstServers";
            this.lstServers.Size = new System.Drawing.Size(257, 134);
            this.lstServers.TabIndex = 2;
            this.lstServers.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnServerAdd
            // 
            this.btnServerAdd.Location = new System.Drawing.Point(6, 168);
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
            this.grpParties.Controls.Add(this.txtTable);
            this.grpParties.Controls.Add(this.label3);
            this.grpParties.Controls.Add(this.label2);
            this.grpParties.Controls.Add(this.txtpSize);
            this.grpParties.Controls.Add(this.txtpName);
            this.grpParties.Controls.Add(this.lstWaitList);
            this.grpParties.Controls.Add(this.btnPartiesAssign);
            this.grpParties.Controls.Add(this.btnPartiesAdd);
            this.grpParties.Location = new System.Drawing.Point(739, 268);
            this.grpParties.Name = "grpParties";
            this.grpParties.Size = new System.Drawing.Size(270, 291);
            this.grpParties.TabIndex = 2;
            this.grpParties.TabStop = false;
            this.grpParties.Text = "Wait List";
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(126, 250);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(20, 20);
            this.txtTable.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Party name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Party size";
            // 
            // txtpSize
            // 
            this.txtpSize.Location = new System.Drawing.Point(121, 186);
            this.txtpSize.Name = "txtpSize";
            this.txtpSize.Size = new System.Drawing.Size(143, 20);
            this.txtpSize.TabIndex = 4;
            // 
            // txtpName
            // 
            this.txtpName.Location = new System.Drawing.Point(121, 160);
            this.txtpName.Name = "txtpName";
            this.txtpName.Size = new System.Drawing.Size(143, 20);
            this.txtpName.TabIndex = 3;
            // 
            // lstWaitList
            // 
            this.lstWaitList.FormattingEnabled = true;
            this.lstWaitList.Location = new System.Drawing.Point(7, 18);
            this.lstWaitList.Margin = new System.Windows.Forms.Padding(2);
            this.lstWaitList.Name = "lstWaitList";
            this.lstWaitList.Size = new System.Drawing.Size(257, 134);
            this.lstWaitList.TabIndex = 2;
            // 
            // btnPartiesAssign
            // 
            this.btnPartiesAssign.Location = new System.Drawing.Point(9, 250);
            this.btnPartiesAssign.Name = "btnPartiesAssign";
            this.btnPartiesAssign.Size = new System.Drawing.Size(110, 23);
            this.btnPartiesAssign.TabIndex = 1;
            this.btnPartiesAssign.Text = "Assign to Table";
            this.btnPartiesAssign.UseVisualStyleBackColor = true;
            this.btnPartiesAssign.Click += new System.EventHandler(this.btnPartiesAssign_Click);
            // 
            // btnPartiesAdd
            // 
            this.btnPartiesAdd.Location = new System.Drawing.Point(9, 221);
            this.btnPartiesAdd.Name = "btnPartiesAdd";
            this.btnPartiesAdd.Size = new System.Drawing.Size(110, 23);
            this.btnPartiesAdd.TabIndex = 0;
            this.btnPartiesAdd.Text = "Add to wait list";
            this.btnPartiesAdd.UseVisualStyleBackColor = true;
            this.btnPartiesAdd.Click += new System.EventHandler(this.BtnPartiesAdd_Click);
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(1017, 536);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(102, 23);
            this.btnShowReport.TabIndex = 8;
            this.btnShowReport.Text = "Customer Report";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlTables
            // 
            this.pnlTables.Location = new System.Drawing.Point(25, 65);
            this.pnlTables.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTables.Name = "pnlTables";
            this.pnlTables.Size = new System.Drawing.Size(693, 494);
            this.pnlTables.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 583);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.pnlTables);
            this.Controls.Add(this.grpParties);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpServers);
            this.Name = "Form1";
            this.Text = "Restaurants";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpServers.ResumeLayout(false);
            this.grpParties.ResumeLayout(false);
            this.grpParties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpServers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpParties;
        private System.Windows.Forms.Button btnServerAdd;
        private System.Windows.Forms.Button btnPartiesAssign;
        private System.Windows.Forms.Button btnPartiesAdd;
        private System.Windows.Forms.ListBox lstServers;
        private System.Windows.Forms.Panel pnlTables;
        private System.Windows.Forms.ListBox lstWaitList;
        private System.Windows.Forms.TextBox txtpName;
        private System.Windows.Forms.TextBox txtpSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Button btnShowReport;
    }
}


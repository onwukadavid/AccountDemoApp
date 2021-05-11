namespace AccountApplicationDemoApp
{
    partial class AccountForm
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnDestroy = new System.Windows.Forms.Button();
            this.btnCleaar = new System.Windows.Forms.Button();
            this.btnGC = new System.Windows.Forms.Button();
            this.btnTemp = new System.Windows.Forms.Button();
            this.btnGetGeneration = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnSetMB = new System.Windows.Forms.Button();
            this.btnGetMB = new System.Windows.Forms.Button();
            this.txtMB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Balance";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(106, 22);
            this.txtId.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(230, 29);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 22);
            this.txtBalance.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 57);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(106, 29);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(124, 57);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(100, 29);
            this.btnSet.TabIndex = 7;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(230, 57);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(100, 29);
            this.btnGet.TabIndex = 8;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnDestroy
            // 
            this.btnDestroy.Location = new System.Drawing.Point(124, 92);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(100, 32);
            this.btnDestroy.TabIndex = 10;
            this.btnDestroy.Text = "Destroy";
            this.btnDestroy.UseVisualStyleBackColor = true;
            this.btnDestroy.Click += new System.EventHandler(this.btnDestroy_Click);
            // 
            // btnCleaar
            // 
            this.btnCleaar.Location = new System.Drawing.Point(12, 92);
            this.btnCleaar.Name = "btnCleaar";
            this.btnCleaar.Size = new System.Drawing.Size(106, 32);
            this.btnCleaar.TabIndex = 9;
            this.btnCleaar.Text = "Clear";
            this.btnCleaar.UseVisualStyleBackColor = true;
            this.btnCleaar.Click += new System.EventHandler(this.btnCleaar_Click);
            // 
            // btnGC
            // 
            this.btnGC.Location = new System.Drawing.Point(230, 92);
            this.btnGC.Name = "btnGC";
            this.btnGC.Size = new System.Drawing.Size(100, 32);
            this.btnGC.TabIndex = 11;
            this.btnGC.Text = "GC";
            this.btnGC.UseVisualStyleBackColor = true;
            this.btnGC.Click += new System.EventHandler(this.btnGC_Click);
            // 
            // btnTemp
            // 
            this.btnTemp.Location = new System.Drawing.Point(12, 130);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(106, 32);
            this.btnTemp.TabIndex = 12;
            this.btnTemp.Text = "Temp";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // btnGetGeneration
            // 
            this.btnGetGeneration.Location = new System.Drawing.Point(124, 130);
            this.btnGetGeneration.Name = "btnGetGeneration";
            this.btnGetGeneration.Size = new System.Drawing.Size(206, 32);
            this.btnGetGeneration.TabIndex = 13;
            this.btnGetGeneration.Text = "Get Generation";
            this.btnGetGeneration.UseVisualStyleBackColor = true;
            this.btnGetGeneration.Click += new System.EventHandler(this.btnGetGeneration_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(12, 168);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(106, 32);
            this.btnDeposit.TabIndex = 14;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(224, 168);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(106, 32);
            this.btnWithdraw.TabIndex = 15;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(124, 173);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(94, 22);
            this.txtAmount.TabIndex = 16;
            // 
            // btnSetMB
            // 
            this.btnSetMB.Location = new System.Drawing.Point(12, 206);
            this.btnSetMB.Name = "btnSetMB";
            this.btnSetMB.Size = new System.Drawing.Size(106, 31);
            this.btnSetMB.TabIndex = 17;
            this.btnSetMB.Text = "Set MB";
            this.btnSetMB.UseVisualStyleBackColor = true;
            this.btnSetMB.Click += new System.EventHandler(this.btnSetMB_Click);
            // 
            // btnGetMB
            // 
            this.btnGetMB.Location = new System.Drawing.Point(224, 206);
            this.btnGetMB.Name = "btnGetMB";
            this.btnGetMB.Size = new System.Drawing.Size(106, 31);
            this.btnGetMB.TabIndex = 18;
            this.btnGetMB.Text = "Get MB";
            this.btnGetMB.UseVisualStyleBackColor = true;
            this.btnGetMB.Click += new System.EventHandler(this.btnGetMB_Click);
            // 
            // txtMB
            // 
            this.txtMB.Location = new System.Drawing.Point(124, 206);
            this.txtMB.Name = "txtMB";
            this.txtMB.Size = new System.Drawing.Size(94, 22);
            this.txtMB.TabIndex = 19;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 268);
            this.Controls.Add(this.txtMB);
            this.Controls.Add(this.btnGetMB);
            this.Controls.Add(this.btnSetMB);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnGetGeneration);
            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.btnGC);
            this.Controls.Add(this.btnCleaar);
            this.Controls.Add(this.btnDestroy);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnDestroy;
        private System.Windows.Forms.Button btnCleaar;
        private System.Windows.Forms.Button btnGC;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.Button btnGetGeneration;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnSetMB;
        private System.Windows.Forms.Button btnGetMB;
        private System.Windows.Forms.TextBox txtMB;
    }
}


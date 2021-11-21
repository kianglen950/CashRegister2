namespace CashRegister2
{
    partial class crazyCookiesSuppliesForm
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
            this.newOrderButton = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.cuttingBoardInput = new System.Windows.Forms.TextBox();
            this.knivesInput = new System.Windows.Forms.TextBox();
            this.pansInput = new System.Windows.Forms.TextBox();
            this.cuttingBoardsLabel = new System.Windows.Forms.Label();
            this.knivesLabel = new System.Windows.Forms.Label();
            this.pansLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newOrderButton
            // 
            this.newOrderButton.Enabled = false;
            this.newOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(875, 596);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(222, 36);
            this.newOrderButton.TabIndex = 33;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // receiptLabel
            // 
            this.receiptLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.receiptLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.receiptLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(569, 9);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(528, 566);
            this.receiptLabel.TabIndex = 32;
            // 
            // receiptButton
            // 
            this.receiptButton.Enabled = false;
            this.receiptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.Location = new System.Drawing.Point(69, 585);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(222, 35);
            this.receiptButton.TabIndex = 31;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(65, 535);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(77, 24);
            this.changeLabel.TabIndex = 30;
            this.changeLabel.Text = "Change";
            // 
            // changeButton
            // 
            this.changeButton.Enabled = false;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(69, 467);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(222, 35);
            this.changeButton.TabIndex = 29;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(191, 419);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(100, 20);
            this.tenderedInput.TabIndex = 28;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(65, 414);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(94, 24);
            this.tenderedLabel.TabIndex = 27;
            this.tenderedLabel.Text = "Tendered";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(65, 312);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(42, 24);
            this.taxLabel.TabIndex = 26;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(65, 360);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(51, 24);
            this.totalLabel.TabIndex = 25;
            this.totalLabel.Text = "Total";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(65, 263);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(90, 24);
            this.subTotalLabel.TabIndex = 24;
            this.subTotalLabel.Text = "Sub Total";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(69, 199);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(222, 36);
            this.calculateButton.TabIndex = 23;
            this.calculateButton.Text = "Calculate Totals";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // cuttingBoardInput
            // 
            this.cuttingBoardInput.Location = new System.Drawing.Point(297, 147);
            this.cuttingBoardInput.Name = "cuttingBoardInput";
            this.cuttingBoardInput.Size = new System.Drawing.Size(42, 20);
            this.cuttingBoardInput.TabIndex = 22;
            this.cuttingBoardInput.Text = "0";
            // 
            // knivesInput
            // 
            this.knivesInput.Location = new System.Drawing.Point(261, 93);
            this.knivesInput.Name = "knivesInput";
            this.knivesInput.Size = new System.Drawing.Size(44, 20);
            this.knivesInput.TabIndex = 21;
            this.knivesInput.Text = "0";
            // 
            // pansInput
            // 
            this.pansInput.Location = new System.Drawing.Point(261, 33);
            this.pansInput.Name = "pansInput";
            this.pansInput.Size = new System.Drawing.Size(44, 20);
            this.pansInput.TabIndex = 20;
            this.pansInput.Text = "0";
            // 
            // cuttingBoardsLabel
            // 
            this.cuttingBoardsLabel.AutoSize = true;
            this.cuttingBoardsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuttingBoardsLabel.Location = new System.Drawing.Point(65, 143);
            this.cuttingBoardsLabel.Name = "cuttingBoardsLabel";
            this.cuttingBoardsLabel.Size = new System.Drawing.Size(226, 24);
            this.cuttingBoardsLabel.TabIndex = 19;
            this.cuttingBoardsLabel.Text = "Number of Cutting Boards";
            // 
            // knivesLabel
            // 
            this.knivesLabel.AutoSize = true;
            this.knivesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knivesLabel.Location = new System.Drawing.Point(65, 89);
            this.knivesLabel.Name = "knivesLabel";
            this.knivesLabel.Size = new System.Drawing.Size(160, 24);
            this.knivesLabel.TabIndex = 18;
            this.knivesLabel.Text = "Number of Knives";
            // 
            // pansLabel
            // 
            this.pansLabel.AutoSize = true;
            this.pansLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pansLabel.Location = new System.Drawing.Point(65, 33);
            this.pansLabel.Name = "pansLabel";
            this.pansLabel.Size = new System.Drawing.Size(146, 24);
            this.pansLabel.TabIndex = 17;
            this.pansLabel.Text = "Number of Pans";
            // 
            // crazyCookiesSuppliesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 668);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.cuttingBoardInput);
            this.Controls.Add(this.knivesInput);
            this.Controls.Add(this.pansInput);
            this.Controls.Add(this.cuttingBoardsLabel);
            this.Controls.Add(this.knivesLabel);
            this.Controls.Add(this.pansLabel);
            this.Name = "crazyCookiesSuppliesForm";
            this.Text = "Crazy Cooking Supplies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox cuttingBoardInput;
        private System.Windows.Forms.TextBox knivesInput;
        private System.Windows.Forms.TextBox pansInput;
        private System.Windows.Forms.Label cuttingBoardsLabel;
        private System.Windows.Forms.Label knivesLabel;
        private System.Windows.Forms.Label pansLabel;
    }
}


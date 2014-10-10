namespace RefrizeratorApp
{
    partial class RefrizeratorUI
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
            this.remainingWeightTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.currentWeightTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.weightPerUnitButton = new System.Windows.Forms.Button();
            this.weightPerUintTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.noOfItemsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maximumWeightTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // remainingWeightTextBox
            // 
            this.remainingWeightTextBox.Location = new System.Drawing.Point(314, 124);
            this.remainingWeightTextBox.Name = "remainingWeightTextBox";
            this.remainingWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.remainingWeightTextBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Remaing Weight";
            // 
            // currentWeightTextBox
            // 
            this.currentWeightTextBox.Location = new System.Drawing.Point(90, 124);
            this.currentWeightTextBox.Name = "currentWeightTextBox";
            this.currentWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.currentWeightTextBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Current Weight";
            // 
            // weightPerUnitButton
            // 
            this.weightPerUnitButton.Location = new System.Drawing.Point(339, 95);
            this.weightPerUnitButton.Name = "weightPerUnitButton";
            this.weightPerUnitButton.Size = new System.Drawing.Size(75, 23);
            this.weightPerUnitButton.TabIndex = 19;
            this.weightPerUnitButton.Text = "Enter";
            this.weightPerUnitButton.UseVisualStyleBackColor = true;
            this.weightPerUnitButton.Click += new System.EventHandler(this.weightPerUnitButton_Click);
            // 
            // weightPerUintTextBox
            // 
            this.weightPerUintTextBox.Location = new System.Drawing.Point(314, 73);
            this.weightPerUintTextBox.Name = "weightPerUintTextBox";
            this.weightPerUintTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightPerUintTextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Weight (kg)/Unit";
            // 
            // noOfItemsTextBox
            // 
            this.noOfItemsTextBox.Location = new System.Drawing.Point(80, 73);
            this.noOfItemsTextBox.Name = "noOfItemsTextBox";
            this.noOfItemsTextBox.Size = new System.Drawing.Size(100, 20);
            this.noOfItemsTextBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "No Of Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Maximum Weight it can take";
            // 
            // maximumWeightTextBox
            // 
            this.maximumWeightTextBox.Location = new System.Drawing.Point(184, 23);
            this.maximumWeightTextBox.Name = "maximumWeightTextBox";
            this.maximumWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.maximumWeightTextBox.TabIndex = 12;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(303, 23);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // RefrizeratorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 160);
            this.Controls.Add(this.remainingWeightTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.currentWeightTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.weightPerUnitButton);
            this.Controls.Add(this.weightPerUintTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.noOfItemsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maximumWeightTextBox);
            this.Controls.Add(this.saveButton);
            this.Name = "RefrizeratorUI";
            this.Text = "RefrizeratorUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox remainingWeightTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox currentWeightTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button weightPerUnitButton;
        private System.Windows.Forms.TextBox weightPerUintTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox noOfItemsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maximumWeightTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}


namespace MegaDeskVarner
{
    partial class AddQuote
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
            this.closeAddQuote = new System.Windows.Forms.Button();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depth = new System.Windows.Forms.TextBox();
            this.depthLabel = new System.Windows.Forms.Label();
            this.numOfDrawers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.material = new System.Windows.Forms.ListBox();
            this.materialLabel = new System.Windows.Forms.Label();
            this.rushDays = new System.Windows.Forms.ListBox();
            this.rushDaysLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeAddQuote
            // 
            this.closeAddQuote.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeAddQuote.Location = new System.Drawing.Point(228, 316);
            this.closeAddQuote.Name = "closeAddQuote";
            this.closeAddQuote.Size = new System.Drawing.Size(110, 41);
            this.closeAddQuote.TabIndex = 0;
            this.closeAddQuote.Text = "Close";
            this.closeAddQuote.UseVisualStyleBackColor = true;
            this.closeAddQuote.Click += new System.EventHandler(this.closeAddQuote_Click);
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(165, 33);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(145, 30);
            this.firstName.TabIndex = 1;
            this.firstName.Validating += new System.ComponentModel.CancelEventHandler(this.firstName_Validating);
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(165, 69);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(145, 30);
            this.lastName.TabIndex = 2;
            this.lastName.Validating += new System.ComponentModel.CancelEventHandler(this.lastName_Validating);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(53, 36);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(106, 25);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(53, 72);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(106, 25);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name";
            // 
            // width
            // 
            this.width.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width.Location = new System.Drawing.Point(165, 102);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(55, 30);
            this.width.TabIndex = 5;
            this.width.Validating += new System.ComponentModel.CancelEventHandler(this.width_Validating);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(96, 105);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(63, 25);
            this.widthLabel.TabIndex = 6;
            this.widthLabel.Text = "Width";
            // 
            // depth
            // 
            this.depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depth.Location = new System.Drawing.Point(165, 138);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(55, 30);
            this.depth.TabIndex = 7;
            this.depth.Validating += new System.ComponentModel.CancelEventHandler(this.depth_Validating);
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(96, 141);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(64, 25);
            this.depthLabel.TabIndex = 8;
            this.depthLabel.Text = "Depth";
            // 
            // numOfDrawers
            // 
            this.numOfDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfDrawers.Location = new System.Drawing.Point(165, 172);
            this.numOfDrawers.Name = "numOfDrawers";
            this.numOfDrawers.Size = new System.Drawing.Size(55, 30);
            this.numOfDrawers.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Drawers";
            // 
            // material
            // 
            this.material.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.material.FormattingEnabled = true;
            this.material.ItemHeight = 25;
            this.material.Items.AddRange(new object[] {
            "laminate",
            "oak",
            "rosewood",
            "veneer",
            "pine"});
            this.material.Location = new System.Drawing.Point(165, 209);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(131, 29);
            this.material.TabIndex = 11;
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel.Location = new System.Drawing.Point(79, 212);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(81, 25);
            this.materialLabel.TabIndex = 12;
            this.materialLabel.Text = "Material";
            // 
            // rushDays
            // 
            this.rushDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushDays.FormattingEnabled = true;
            this.rushDays.ItemHeight = 25;
            this.rushDays.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.rushDays.Location = new System.Drawing.Point(165, 244);
            this.rushDays.Name = "rushDays";
            this.rushDays.Size = new System.Drawing.Size(55, 29);
            this.rushDays.TabIndex = 13;
            // 
            // rushDaysLabel
            // 
            this.rushDaysLabel.AutoSize = true;
            this.rushDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushDaysLabel.Location = new System.Drawing.Point(53, 246);
            this.rushDaysLabel.Name = "rushDaysLabel";
            this.rushDaysLabel.Size = new System.Drawing.Size(107, 25);
            this.rushDaysLabel.TabIndex = 14;
            this.rushDaysLabel.Text = "Rush Days";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(101, 316);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(119, 41);
            this.submitButton.TabIndex = 15;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Validating += new System.ComponentModel.CancelEventHandler(this.submitButton_Validating);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeAddQuote;
            this.ClientSize = new System.Drawing.Size(350, 369);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.rushDaysLabel);
            this.Controls.Add(this.rushDays);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.material);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numOfDrawers);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.width);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.closeAddQuote);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeAddQuote;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.TextBox numOfDrawers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox material;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.ListBox rushDays;
        private System.Windows.Forms.Label rushDaysLabel;
        private System.Windows.Forms.Button submitButton;
    }
}
namespace MultiWindowsForm
{
    partial class NewCustomerForm
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
            gbCustomer = new GroupBox();
            btnClear = new Button();
            BtnSave = new Button();
            txtPhoneNumber = new TextBox();
            lblPhoneHeading = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtName = new TextBox();
            lblNameHeading = new Label();
            gbCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // gbCustomer
            // 
            gbCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbCustomer.AutoSize = true;
            gbCustomer.Controls.Add(btnClear);
            gbCustomer.Controls.Add(BtnSave);
            gbCustomer.Controls.Add(txtPhoneNumber);
            gbCustomer.Controls.Add(lblPhoneHeading);
            gbCustomer.Controls.Add(txtEmail);
            gbCustomer.Controls.Add(lblEmail);
            gbCustomer.Controls.Add(txtName);
            gbCustomer.Controls.Add(lblNameHeading);
            gbCustomer.Location = new Point(12, 12);
            gbCustomer.Name = "gbCustomer";
            gbCustomer.Size = new Size(380, 171);
            gbCustomer.TabIndex = 0;
            gbCustomer.TabStop = false;
            gbCustomer.Text = "New Customer";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(285, 126);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(6, 126);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 23);
            BtnSave.TabIndex = 6;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhoneNumber.Location = new Point(105, 92);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(269, 23);
            txtPhoneNumber.TabIndex = 5;
            // 
            // lblPhoneHeading
            // 
            lblPhoneHeading.AutoSize = true;
            lblPhoneHeading.Location = new Point(0, 95);
            lblPhoneHeading.Name = "lblPhoneHeading";
            lblPhoneHeading.Size = new Size(91, 15);
            lblPhoneHeading.TabIndex = 4;
            lblPhoneHeading.Text = "Phone Number:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(105, 63);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(269, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(0, 66);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(105, 34);
            txtName.Name = "txtName";
            txtName.Size = new Size(269, 23);
            txtName.TabIndex = 1;
            // 
            // lblNameHeading
            // 
            lblNameHeading.AutoSize = true;
            lblNameHeading.Location = new Point(0, 37);
            lblNameHeading.Name = "lblNameHeading";
            lblNameHeading.Size = new Size(42, 15);
            lblNameHeading.TabIndex = 0;
            lblNameHeading.Text = "Name:";
            // 
            // NewCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 185);
            Controls.Add(gbCustomer);
            Name = "NewCustomerForm";
            Text = "New Customer";
            gbCustomer.ResumeLayout(false);
            gbCustomer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbCustomer;
        private TextBox txtName;
        private Label lblNameHeading;
        private Button button1;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private Label lblPhoneHeading;
        private TextBox txtEmail;
        private Label lblEmail;
        private Button BtnSave;
        private Button btnClear;
    }
}
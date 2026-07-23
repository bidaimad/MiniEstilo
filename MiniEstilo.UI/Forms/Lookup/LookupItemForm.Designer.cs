namespace MiniEstilo.UI.Forms.Lookup
{
    partial class LookupItemForm
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
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            lblDescription = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(90, 146);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(73, 19);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add Item";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblName
            lblName.AutoSize = true;
            lblName.Location = new Point(24, 173);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(50, 191);
            txtName.Name = "txtName";
            txtName.Size = new Size(152, 23);
            txtName.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(50, 255);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(152, 43);
            txtDescription.TabIndex = 3;
            // 
            // label1
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(24, 237);
            lblDescription.Name = "label1";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(24, 331);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(105, 331);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // LookupItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 381);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LookupItemForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Brand";
            Load += LookupItemForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private TextBox txtDescription;
        private Label lblDescription;
        private Button btnSave;
        private Button btnCancel;
    }
}
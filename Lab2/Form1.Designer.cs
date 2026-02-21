namespace Lab2
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            btnAdd = new Button();
            btnContact = new Button();
            btnMerge = new Button();
            lstString = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(117, 29);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(117, 105);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Додати рядок";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnContact
            // 
            btnContact.Location = new Point(117, 169);
            btnContact.Name = "btnContact";
            btnContact.Size = new Size(75, 23);
            btnContact.TabIndex = 2;
            btnContact.Text = "Зчепити";
            btnContact.UseVisualStyleBackColor = true;
            btnContact.Click += btnAddSecond_Click;
            // 
            // btnMerge
            // 
            btnMerge.Location = new Point(117, 225);
            btnMerge.Name = "btnMerge";
            btnMerge.Size = new Size(75, 23);
            btnMerge.TabIndex = 3;
            btnMerge.Text = "Злиття";
            btnMerge.UseVisualStyleBackColor = true;
            btnMerge.Click += btnMerge_Click;
            // 
            // lstString
            // 
            lstString.FormattingEnabled = true;
            lstString.Location = new Point(327, 29);
            lstString.Name = "lstString";
            lstString.Size = new Size(304, 274);
            lstString.TabIndex = 4;
            lstString.SelectedIndexChanged += lstString_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 32);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 5;
            label1.Text = "Введіть дані:";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lstString);
            Controls.Add(btnMerge);
            Controls.Add(btnContact);
            Controls.Add(btnAdd);
            Controls.Add(txtInput);
            Name = "FrmMain";
            Text = "Lab2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnAdd;
        private Button btnContact;
        private Button btnMerge;
        private ListBox lstString;
        private Label label1;
    }
}

namespace BusInfo
{
    partial class Form1
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
            AddButton = new Button();
            ViewButton = new Button();
            DeleteButton = new Button();
            BoughtTicketsButton = new Button();
            addControl1 = new AddControl();
            boughtTicketsControl1 = new BoughtTicketsControl();
            editControl1 = new EditControl();
            viewControl1 = new ViewControl();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(23, 58);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(111, 43);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ViewButton
            // 
            ViewButton.Location = new Point(23, 134);
            ViewButton.Name = "ViewButton";
            ViewButton.Size = new Size(111, 43);
            ViewButton.TabIndex = 1;
            ViewButton.Text = "View";
            ViewButton.UseVisualStyleBackColor = true;
            ViewButton.Click += ViewButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(23, 207);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(111, 43);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Edit";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // BoughtTicketsButton
            // 
            BoughtTicketsButton.Location = new Point(23, 283);
            BoughtTicketsButton.Name = "BoughtTicketsButton";
            BoughtTicketsButton.Size = new Size(111, 43);
            BoughtTicketsButton.TabIndex = 3;
            BoughtTicketsButton.Text = "Bought tickets";
            BoughtTicketsButton.UseVisualStyleBackColor = true;
            BoughtTicketsButton.Click += BoughtTicketsButton_Click;
            // 
            // addControl1
            // 
            addControl1.Location = new Point(140, 12);
            addControl1.Name = "addControl1";
            addControl1.Size = new Size(795, 407);
            addControl1.TabIndex = 4;
            // 
            // boughtTicketsControl1
            // 
            boughtTicketsControl1.Location = new Point(140, 12);
            boughtTicketsControl1.Name = "boughtTicketsControl1";
            boughtTicketsControl1.Size = new Size(823, 407);
            boughtTicketsControl1.TabIndex = 5;
            // 
            // editControl1
            // 
            editControl1.Location = new Point(140, 12);
            editControl1.Name = "editControl1";
            editControl1.Size = new Size(823, 421);
            editControl1.TabIndex = 6;
            // 
            // viewControl1
            // 
            viewControl1.Location = new Point(140, 11);
            viewControl1.Name = "viewControl1";
            viewControl1.Size = new Size(823, 422);
            viewControl1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 450);
            Controls.Add(viewControl1);
            Controls.Add(editControl1);
            Controls.Add(boughtTicketsControl1);
            Controls.Add(addControl1);
            Controls.Add(BoughtTicketsButton);
            Controls.Add(DeleteButton);
            Controls.Add(ViewButton);
            Controls.Add(AddButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button AddButton;
        private Button ViewButton;
        private Button DeleteButton;
        private Button BoughtTicketsButton;
        private AddControl addControl1;
        private BoughtTicketsControl boughtTicketsControl1;
        private EditControl editControl1;
        private ViewControl viewControl1;
    }
}
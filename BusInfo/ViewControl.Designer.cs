namespace BusInfo
{
    partial class ViewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            SortByTimeButton = new Button();
            SortByPlaceButton = new Button();
            button1 = new Button();
            UpdateButton = new Button();
            BuyTicketButton = new Button();
            textBox1 = new TextBox();
            NearestDestinationTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(393, 12);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "View Screen";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(766, 226);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SortByTimeButton
            // 
            SortByTimeButton.Location = new Point(42, 377);
            SortByTimeButton.Name = "SortByTimeButton";
            SortByTimeButton.Size = new Size(94, 29);
            SortByTimeButton.TabIndex = 2;
            SortByTimeButton.Text = "SortByTime";
            SortByTimeButton.UseVisualStyleBackColor = true;
            SortByTimeButton.Click += SortByTimeButton_Click;
            // 
            // SortByPlaceButton
            // 
            SortByPlaceButton.Location = new Point(177, 377);
            SortByPlaceButton.Name = "SortByPlaceButton";
            SortByPlaceButton.Size = new Size(102, 29);
            SortByPlaceButton.TabIndex = 3;
            SortByPlaceButton.Text = "SortByPlace";
            SortByPlaceButton.UseVisualStyleBackColor = true;
            SortByPlaceButton.Click += SortByPlaceButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(338, 377);
            button1.Name = "button1";
            button1.Size = new Size(189, 29);
            button1.TabIndex = 4;
            button1.Text = "Find Nearest Destination";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(670, 377);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(122, 29);
            UpdateButton.TabIndex = 5;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // BuyTicketButton
            // 
            BuyTicketButton.Location = new Point(670, 333);
            BuyTicketButton.Name = "BuyTicketButton";
            BuyTicketButton.Size = new Size(122, 29);
            BuyTicketButton.TabIndex = 6;
            BuyTicketButton.Text = "BuyTicket";
            BuyTicketButton.UseVisualStyleBackColor = true;
            BuyTicketButton.Click += BuyTicketButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(670, 291);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // NearestDestinationTextBox
            // 
            NearestDestinationTextBox.Location = new Point(338, 323);
            NearestDestinationTextBox.Name = "NearestDestinationTextBox";
            NearestDestinationTextBox.Size = new Size(189, 27);
            NearestDestinationTextBox.TabIndex = 8;
            // 
            // ViewControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NearestDestinationTextBox);
            Controls.Add(textBox1);
            Controls.Add(BuyTicketButton);
            Controls.Add(UpdateButton);
            Controls.Add(button1);
            Controls.Add(SortByPlaceButton);
            Controls.Add(SortByTimeButton);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "ViewControl";
            Size = new Size(846, 433);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button SortByTimeButton;
        private Button SortByPlaceButton;
        private Button button1;
        private Button UpdateButton;
        private Button BuyTicketButton;
        private TextBox textBox1;
        private TextBox NearestDestinationTextBox;
    }
}

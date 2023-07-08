namespace BusInfo
{
    partial class EditControl
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
            EditButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            ClearButton = new Button();
            RouteNumberTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            StartRouteTextBox = new TextBox();
            label3 = new Label();
            DestinationTextBox = new TextBox();
            label4 = new Label();
            DepartureTimeTextBox = new TextBox();
            label5 = new Label();
            AvailableSeatsTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // EditButton
            // 
            EditButton.Location = new Point(119, 355);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(94, 29);
            EditButton.TabIndex = 0;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(258, 355);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(118, 29);
            UpdateButton.TabIndex = 1;
            UpdateButton.Text = "Update data";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(425, 358);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(583, 358);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 29);
            ClearButton.TabIndex = 3;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // RouteNumberTextBox
            // 
            RouteNumberTextBox.Location = new Point(119, 260);
            RouteNumberTextBox.Name = "RouteNumberTextBox";
            RouteNumberTextBox.Size = new Size(125, 27);
            RouteNumberTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 225);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 5;
            label1.Text = "Номер рейсу";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 225);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 7;
            label2.Text = "Пункт відправки";
            // 
            // StartRouteTextBox
            // 
            StartRouteTextBox.Location = new Point(325, 260);
            StartRouteTextBox.Name = "StartRouteTextBox";
            StartRouteTextBox.Size = new Size(125, 27);
            StartRouteTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(539, 225);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 9;
            label3.Text = "Призначення";
            // 
            // DestinationTextBox
            // 
            DestinationTextBox.Location = new Point(528, 260);
            DestinationTextBox.Name = "DestinationTextBox";
            DestinationTextBox.Size = new Size(125, 27);
            DestinationTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 290);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 11;
            label4.Text = "Час прибуття";
            // 
            // DepartureTimeTextBox
            // 
            DepartureTimeTextBox.Location = new Point(173, 325);
            DepartureTimeTextBox.Name = "DepartureTimeTextBox";
            DepartureTimeTextBox.Size = new Size(125, 27);
            DepartureTimeTextBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(441, 290);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 13;
            label5.Text = "Кількість місць";
            // 
            // AvailableSeatsTextBox
            // 
            AvailableSeatsTextBox.Location = new Point(430, 325);
            AvailableSeatsTextBox.Name = "AvailableSeatsTextBox";
            AvailableSeatsTextBox.Size = new Size(125, 27);
            AvailableSeatsTextBox.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(130, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(547, 188);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(373, 11);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 15;
            label6.Text = "Edit Screen";
            // 
            // EditControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(AvailableSeatsTextBox);
            Controls.Add(label4);
            Controls.Add(DepartureTimeTextBox);
            Controls.Add(label3);
            Controls.Add(DestinationTextBox);
            Controls.Add(label2);
            Controls.Add(StartRouteTextBox);
            Controls.Add(label1);
            Controls.Add(RouteNumberTextBox);
            Controls.Add(ClearButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(EditButton);
            Name = "EditControl";
            Size = new Size(780, 421);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EditButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button ClearButton;
        private TextBox RouteNumberTextBox;
        private Label label1;
        private Label label2;
        private TextBox StartRouteTextBox;
        private Label label3;
        private TextBox DestinationTextBox;
        private Label label4;
        private TextBox DepartureTimeTextBox;
        private Label label5;
        private TextBox AvailableSeatsTextBox;
        private DataGridView dataGridView1;
        private Label label6;
    }
}

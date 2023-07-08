namespace BusInfo
{
    partial class AddControl
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
            AddButton = new Button();
            RouteNumberTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            StartRouteTextBox = new TextBox();
            label4 = new Label();
            DestinationTextBox = new TextBox();
            label5 = new Label();
            DepartureTimeTextBox = new TextBox();
            label6 = new Label();
            AvailableSeatsTextBox = new TextBox();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(596, 340);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RouteNumberTextBox
            // 
            RouteNumberTextBox.Location = new Point(46, 96);
            RouteNumberTextBox.Name = "RouteNumberTextBox";
            RouteNumberTextBox.Size = new Size(125, 27);
            RouteNumberTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 63);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 2;
            label1.Text = "Номер рейсу";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 13);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 3;
            label2.Text = "Add Screen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 63);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 5;
            label3.Text = "Пункт відправки";
            // 
            // StartRouteTextBox
            // 
            StartRouteTextBox.Location = new Point(286, 96);
            StartRouteTextBox.Name = "StartRouteTextBox";
            StartRouteTextBox.Size = new Size(125, 27);
            StartRouteTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(589, 63);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 7;
            label4.Text = "Призначення";
            // 
            // DestinationTextBox
            // 
            DestinationTextBox.Location = new Point(576, 96);
            DestinationTextBox.Name = "DestinationTextBox";
            DestinationTextBox.Size = new Size(125, 27);
            DestinationTextBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(175, 171);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 9;
            label5.Text = "Час прибуття";
            // 
            // DepartureTimeTextBox
            // 
            DepartureTimeTextBox.Location = new Point(162, 204);
            DepartureTimeTextBox.Name = "DepartureTimeTextBox";
            DepartureTimeTextBox.Size = new Size(125, 27);
            DepartureTimeTextBox.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(433, 171);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 11;
            label6.Text = "Кількість місць";
            // 
            // AvailableSeatsTextBox
            // 
            AvailableSeatsTextBox.Location = new Point(433, 204);
            AvailableSeatsTextBox.Name = "AvailableSeatsTextBox";
            AvailableSeatsTextBox.Size = new Size(125, 27);
            AvailableSeatsTextBox.TabIndex = 10;
            // 
            // AddControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(AvailableSeatsTextBox);
            Controls.Add(label5);
            Controls.Add(DepartureTimeTextBox);
            Controls.Add(label4);
            Controls.Add(DestinationTextBox);
            Controls.Add(label3);
            Controls.Add(StartRouteTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RouteNumberTextBox);
            Controls.Add(AddButton);
            Name = "AddControl";
            Size = new Size(756, 409);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private TextBox RouteNumberTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox StartRouteTextBox;
        private Label label4;
        private TextBox DestinationTextBox;
        private Label label5;
        private TextBox DepartureTimeTextBox;
        private Label label6;
        private TextBox AvailableSeatsTextBox;
    }
}

namespace EventManagementUI
{
    partial class AddEventForm
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
            eventNameTextBox = new TextBox();
            eventLocationTextBox = new TextBox();
            eventGuestTextBox = new TextBox();
            eventNameLabel = new Label();
            eventDateLabel = new Label();
            eventHourLabel = new Label();
            eventLocationLabel = new Label();
            eventGustsLabel = new Label();
            addEventButton = new Button();
            eventTitleFormLabel = new Label();
            eventDateTimePicker = new DateTimePicker();
            eventTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // eventNameTextBox
            // 
            eventNameTextBox.Font = new Font("Segoe UI", 12F);
            eventNameTextBox.Location = new Point(33, 117);
            eventNameTextBox.Name = "eventNameTextBox";
            eventNameTextBox.Size = new Size(510, 34);
            eventNameTextBox.TabIndex = 0;
            // 
            // eventLocationTextBox
            // 
            eventLocationTextBox.Font = new Font("Segoe UI", 12F);
            eventLocationTextBox.Location = new Point(33, 361);
            eventLocationTextBox.Name = "eventLocationTextBox";
            eventLocationTextBox.Size = new Size(510, 34);
            eventLocationTextBox.TabIndex = 3;
            // 
            // eventGuestTextBox
            // 
            eventGuestTextBox.Font = new Font("Segoe UI", 12F);
            eventGuestTextBox.Location = new Point(33, 445);
            eventGuestTextBox.Name = "eventGuestTextBox";
            eventGuestTextBox.Size = new Size(510, 34);
            eventGuestTextBox.TabIndex = 4;
            // 
            // eventNameLabel
            // 
            eventNameLabel.AutoSize = true;
            eventNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            eventNameLabel.Location = new Point(33, 83);
            eventNameLabel.Name = "eventNameLabel";
            eventNameLabel.Size = new Size(190, 28);
            eventNameLabel.TabIndex = 5;
            eventNameLabel.Text = "Nombre del evento";
            // 
            // eventDateLabel
            // 
            eventDateLabel.AutoSize = true;
            eventDateLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            eventDateLabel.Location = new Point(33, 165);
            eventDateLabel.Name = "eventDateLabel";
            eventDateLabel.Size = new Size(167, 28);
            eventDateLabel.TabIndex = 6;
            eventDateLabel.Text = "Fecha del evento";
            // 
            // eventHourLabel
            // 
            eventHourLabel.AutoSize = true;
            eventHourLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            eventHourLabel.Location = new Point(33, 247);
            eventHourLabel.Name = "eventHourLabel";
            eventHourLabel.Size = new Size(159, 28);
            eventHourLabel.TabIndex = 7;
            eventHourLabel.Text = "Hora del evento";
            // 
            // eventLocationLabel
            // 
            eventLocationLabel.AutoSize = true;
            eventLocationLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            eventLocationLabel.Location = new Point(33, 327);
            eventLocationLabel.Name = "eventLocationLabel";
            eventLocationLabel.Size = new Size(203, 28);
            eventLocationLabel.TabIndex = 8;
            eventLocationLabel.Text = "Ubicacion del evento";
            // 
            // eventGustsLabel
            // 
            eventGustsLabel.AutoSize = true;
            eventGustsLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            eventGustsLabel.Location = new Point(33, 411);
            eventGustsLabel.Name = "eventGustsLabel";
            eventGustsLabel.Size = new Size(209, 28);
            eventGustsLabel.TabIndex = 9;
            eventGustsLabel.Text = "Cantidad de invitados";
            // 
            // addEventButton
            // 
            addEventButton.BackColor = Color.FromArgb(10, 133, 55);
            addEventButton.FlatStyle = FlatStyle.Flat;
            addEventButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addEventButton.ForeColor = Color.Transparent;
            addEventButton.Location = new Point(33, 519);
            addEventButton.Name = "addEventButton";
            addEventButton.Size = new Size(189, 52);
            addEventButton.TabIndex = 10;
            addEventButton.Text = "Agregar evento";
            addEventButton.UseVisualStyleBackColor = false;
            addEventButton.Click += addEventButton_Click;
            // 
            // eventTitleFormLabel
            // 
            eventTitleFormLabel.AutoSize = true;
            eventTitleFormLabel.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventTitleFormLabel.Location = new Point(87, 18);
            eventTitleFormLabel.Name = "eventTitleFormLabel";
            eventTitleFormLabel.Size = new Size(394, 46);
            eventTitleFormLabel.TabIndex = 11;
            eventTitleFormLabel.Text = "Agregar nuevo evento";
            // 
            // eventDateTimePicker
            // 
            eventDateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventDateTimePicker.Format = DateTimePickerFormat.Short;
            eventDateTimePicker.ImeMode = ImeMode.NoControl;
            eventDateTimePicker.Location = new Point(33, 199);
            eventDateTimePicker.Name = "eventDateTimePicker";
            eventDateTimePicker.Size = new Size(510, 34);
            eventDateTimePicker.TabIndex = 12;
            // 
            // eventTimePicker
            // 
            eventTimePicker.CustomFormat = "hh:mm tt";
            eventTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventTimePicker.Format = DateTimePickerFormat.Custom;
            eventTimePicker.ImeMode = ImeMode.NoControl;
            eventTimePicker.Location = new Point(32, 281);
            eventTimePicker.Name = "eventTimePicker";
            eventTimePicker.Size = new Size(510, 34);
            eventTimePicker.TabIndex = 13;
            // 
            // AddEventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 597);
            Controls.Add(eventTimePicker);
            Controls.Add(eventDateTimePicker);
            Controls.Add(eventTitleFormLabel);
            Controls.Add(addEventButton);
            Controls.Add(eventGustsLabel);
            Controls.Add(eventLocationLabel);
            Controls.Add(eventHourLabel);
            Controls.Add(eventDateLabel);
            Controls.Add(eventNameLabel);
            Controls.Add(eventGuestTextBox);
            Controls.Add(eventLocationTextBox);
            Controls.Add(eventNameTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddEventForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo evento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox eventNameTextBox;
        private TextBox eventLocationTextBox;
        private TextBox eventGuestTextBox;
        private Label eventNameLabel;
        private Label eventDateLabel;
        private Label eventHourLabel;
        private Label eventLocationLabel;
        private Label eventGustsLabel;
        private Button addEventButton;
        private Label eventTitleFormLabel;
        private DateTimePicker eventDateTimePicker;
        private DateTimePicker eventTimePicker;
    }
}
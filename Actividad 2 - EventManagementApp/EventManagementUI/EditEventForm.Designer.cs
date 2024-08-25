namespace EventManagementUI
{
    partial class EditEventForm
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
            eventTitleFormLabel = new Label();
            saveEventButton = new Button();
            eventGustsLabel = new Label();
            eventLocationLabel = new Label();
            eventHourLabel = new Label();
            eventDateLabel = new Label();
            eventNameLabel = new Label();
            eventGuestTextBox = new TextBox();
            eventLocationTextBox = new TextBox();
            eventNameTextBox = new TextBox();
            eventTimePicker = new DateTimePicker();
            eventDateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // eventTitleFormLabel
            // 
            eventTitleFormLabel.AutoSize = true;
            eventTitleFormLabel.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventTitleFormLabel.Location = new Point(178, 21);
            eventTitleFormLabel.Name = "eventTitleFormLabel";
            eventTitleFormLabel.Size = new Size(243, 46);
            eventTitleFormLabel.TabIndex = 23;
            eventTitleFormLabel.Text = "Editar evento";
            // 
            // saveEventButton
            // 
            saveEventButton.BackColor = Color.FromArgb(10, 133, 55);
            saveEventButton.FlatStyle = FlatStyle.Flat;
            saveEventButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveEventButton.ForeColor = Color.Transparent;
            saveEventButton.Location = new Point(49, 520);
            saveEventButton.Name = "saveEventButton";
            saveEventButton.Size = new Size(189, 52);
            saveEventButton.TabIndex = 22;
            saveEventButton.Text = "Actualizr evento";
            saveEventButton.UseVisualStyleBackColor = false;
            saveEventButton.Click += saveEventButton_Click;
            // 
            // eventGustsLabel
            // 
            eventGustsLabel.AutoSize = true;
            eventGustsLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            eventGustsLabel.Location = new Point(49, 412);
            eventGustsLabel.Name = "eventGustsLabel";
            eventGustsLabel.Size = new Size(209, 28);
            eventGustsLabel.TabIndex = 21;
            eventGustsLabel.Text = "Cantidad de invitados";
            // 
            // eventLocationLabel
            // 
            eventLocationLabel.AutoSize = true;
            eventLocationLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            eventLocationLabel.Location = new Point(49, 328);
            eventLocationLabel.Name = "eventLocationLabel";
            eventLocationLabel.Size = new Size(203, 28);
            eventLocationLabel.TabIndex = 20;
            eventLocationLabel.Text = "Ubicacion del evento";
            // 
            // eventHourLabel
            // 
            eventHourLabel.AutoSize = true;
            eventHourLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            eventHourLabel.Location = new Point(49, 248);
            eventHourLabel.Name = "eventHourLabel";
            eventHourLabel.Size = new Size(159, 28);
            eventHourLabel.TabIndex = 19;
            eventHourLabel.Text = "Hora del evento";
            // 
            // eventDateLabel
            // 
            eventDateLabel.AutoSize = true;
            eventDateLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            eventDateLabel.Location = new Point(49, 166);
            eventDateLabel.Name = "eventDateLabel";
            eventDateLabel.Size = new Size(167, 28);
            eventDateLabel.TabIndex = 18;
            eventDateLabel.Text = "Fecha del evento";
            // 
            // eventNameLabel
            // 
            eventNameLabel.AutoSize = true;
            eventNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            eventNameLabel.Location = new Point(49, 84);
            eventNameLabel.Name = "eventNameLabel";
            eventNameLabel.Size = new Size(190, 28);
            eventNameLabel.TabIndex = 17;
            eventNameLabel.Text = "Nombre del evento";
            // 
            // eventGuestTextBox
            // 
            eventGuestTextBox.Font = new Font("Segoe UI", 12F);
            eventGuestTextBox.Location = new Point(49, 446);
            eventGuestTextBox.Name = "eventGuestTextBox";
            eventGuestTextBox.Size = new Size(510, 34);
            eventGuestTextBox.TabIndex = 16;
            // 
            // eventLocationTextBox
            // 
            eventLocationTextBox.Font = new Font("Segoe UI", 12F);
            eventLocationTextBox.Location = new Point(49, 362);
            eventLocationTextBox.Name = "eventLocationTextBox";
            eventLocationTextBox.Size = new Size(510, 34);
            eventLocationTextBox.TabIndex = 15;
            // 
            // eventNameTextBox
            // 
            eventNameTextBox.Font = new Font("Segoe UI", 12F);
            eventNameTextBox.Location = new Point(49, 118);
            eventNameTextBox.Name = "eventNameTextBox";
            eventNameTextBox.Size = new Size(510, 34);
            eventNameTextBox.TabIndex = 12;
            // 
            // eventTimePicker
            // 
            eventTimePicker.CustomFormat = "hh:mm tt";
            eventTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventTimePicker.Format = DateTimePickerFormat.Custom;
            eventTimePicker.ImeMode = ImeMode.NoControl;
            eventTimePicker.Location = new Point(48, 282);
            eventTimePicker.Name = "eventTimePicker";
            eventTimePicker.Size = new Size(510, 34);
            eventTimePicker.TabIndex = 25;
            // 
            // eventDateTimePicker
            // 
            eventDateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventDateTimePicker.Format = DateTimePickerFormat.Short;
            eventDateTimePicker.ImeMode = ImeMode.NoControl;
            eventDateTimePicker.Location = new Point(49, 200);
            eventDateTimePicker.Name = "eventDateTimePicker";
            eventDateTimePicker.Size = new Size(510, 34);
            eventDateTimePicker.TabIndex = 24;
            // 
            // EditEventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 607);
            Controls.Add(eventTimePicker);
            Controls.Add(eventDateTimePicker);
            Controls.Add(eventTitleFormLabel);
            Controls.Add(saveEventButton);
            Controls.Add(eventGustsLabel);
            Controls.Add(eventLocationLabel);
            Controls.Add(eventHourLabel);
            Controls.Add(eventDateLabel);
            Controls.Add(eventNameLabel);
            Controls.Add(eventGuestTextBox);
            Controls.Add(eventLocationTextBox);
            Controls.Add(eventNameTextBox);
            Name = "EditEventForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar evento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label eventTitleFormLabel;
        private Button saveEventButton;
        private Label eventGustsLabel;
        private Label eventLocationLabel;
        private Label eventHourLabel;
        private Label eventDateLabel;
        private Label eventNameLabel;
        private TextBox eventGuestTextBox;
        private TextBox eventLocationTextBox;
        private TextBox eventTimeTextBox;
        private TextBox eventDateTextBox;
        private TextBox eventNameTextBox;
        private DateTimePicker eventTimePicker;
        private DateTimePicker eventDateTimePicker;
    }
}
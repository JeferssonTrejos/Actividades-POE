namespace EventManagementUI
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            removeAllButton = new Button();
            button1 = new Button();
            companyLogoPictureBox = new PictureBox();
            labelEventsPanel = new Panel();
            actionsEventLabel = new Label();
            GuestsEventLabel = new Label();
            locationEventLabel = new Label();
            hourEventLabel = new Label();
            dateEventLabel = new Label();
            nameEventLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            titleLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)companyLogoPictureBox).BeginInit();
            labelEventsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(removeAllButton);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(companyLogoPictureBox);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Microsoft Sans Serif", 7.8F);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 641);
            panel1.TabIndex = 0;
            // 
            // removeAllButton
            // 
            removeAllButton.BackColor = Color.Red;
            removeAllButton.FlatStyle = FlatStyle.Flat;
            removeAllButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeAllButton.ForeColor = Color.Transparent;
            removeAllButton.Location = new Point(9, 225);
            removeAllButton.Margin = new Padding(0);
            removeAllButton.Name = "deleteAllEventsButton";
            removeAllButton.Size = new Size(231, 58);
            removeAllButton.TabIndex = 3;
            removeAllButton.Text = "Remover todo";
            removeAllButton.UseVisualStyleBackColor = false;
            removeAllButton.Click += deleteAllEventsButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(10, 133, 55);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(9, 157);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(231, 58);
            button1.TabIndex = 2;
            button1.Text = "Agregar evento";
            button1.UseVisualStyleBackColor = false;
            button1.Click += addEventButton_Click;
            // 
            // companyLogoPictureBox
            // 
            companyLogoPictureBox.BackColor = Color.Transparent;
            companyLogoPictureBox.Image = Properties.Resources.heresEventsLogo;
            companyLogoPictureBox.Location = new Point(8, 27);
            companyLogoPictureBox.Name = "companyLogoPictureBox";
            companyLogoPictureBox.Size = new Size(231, 106);
            companyLogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            companyLogoPictureBox.TabIndex = 1;
            companyLogoPictureBox.TabStop = false;
            // 
            // labelEventsPanel
            // 
            labelEventsPanel.BackColor = SystemColors.AppWorkspace;
            labelEventsPanel.Controls.Add(actionsEventLabel);
            labelEventsPanel.Controls.Add(GuestsEventLabel);
            labelEventsPanel.Controls.Add(locationEventLabel);
            labelEventsPanel.Controls.Add(hourEventLabel);
            labelEventsPanel.Controls.Add(dateEventLabel);
            labelEventsPanel.Controls.Add(nameEventLabel);
            labelEventsPanel.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEventsPanel.Location = new Point(259, 57);
            labelEventsPanel.Name = "labelEventsPanel";
            labelEventsPanel.Size = new Size(992, 49);
            labelEventsPanel.TabIndex = 3;
            // 
            // actionsEventLabel
            // 
            actionsEventLabel.BackColor = Color.Transparent;
            actionsEventLabel.Dock = DockStyle.Left;
            actionsEventLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            actionsEventLabel.Location = new Point(772, 0);
            actionsEventLabel.Name = "actionsEventLabel";
            actionsEventLabel.RightToLeft = RightToLeft.No;
            actionsEventLabel.Size = new Size(223, 49);
            actionsEventLabel.TabIndex = 5;
            actionsEventLabel.Text = "Acciones";
            actionsEventLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GuestsEventLabel
            // 
            GuestsEventLabel.BackColor = Color.Transparent;
            GuestsEventLabel.Dock = DockStyle.Left;
            GuestsEventLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            GuestsEventLabel.Location = new Point(637, 0);
            GuestsEventLabel.Name = "GuestsEventLabel";
            GuestsEventLabel.RightToLeft = RightToLeft.No;
            GuestsEventLabel.Size = new Size(135, 49);
            GuestsEventLabel.TabIndex = 4;
            GuestsEventLabel.Text = "Invitados";
            GuestsEventLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // locationEventLabel
            // 
            locationEventLabel.BackColor = Color.Transparent;
            locationEventLabel.Dock = DockStyle.Left;
            locationEventLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            locationEventLabel.Location = new Point(437, 0);
            locationEventLabel.Name = "locationEventLabel";
            locationEventLabel.RightToLeft = RightToLeft.No;
            locationEventLabel.Size = new Size(200, 49);
            locationEventLabel.TabIndex = 3;
            locationEventLabel.Text = "Ubicacion";
            locationEventLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // hourEventLabel
            // 
            hourEventLabel.BackColor = Color.Transparent;
            hourEventLabel.Dock = DockStyle.Left;
            hourEventLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            hourEventLabel.Location = new Point(322, 0);
            hourEventLabel.Name = "hourEventLabel";
            hourEventLabel.RightToLeft = RightToLeft.No;
            hourEventLabel.Size = new Size(115, 49);
            hourEventLabel.TabIndex = 2;
            hourEventLabel.Text = "Hora";
            hourEventLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateEventLabel
            // 
            dateEventLabel.BackColor = Color.Transparent;
            dateEventLabel.Dock = DockStyle.Left;
            dateEventLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dateEventLabel.Location = new Point(182, 0);
            dateEventLabel.Name = "dateEventLabel";
            dateEventLabel.RightToLeft = RightToLeft.No;
            dateEventLabel.Size = new Size(140, 49);
            dateEventLabel.TabIndex = 1;
            dateEventLabel.Text = "Fecha";
            dateEventLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nameEventLabel
            // 
            nameEventLabel.BackColor = Color.Transparent;
            nameEventLabel.Dock = DockStyle.Left;
            nameEventLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            nameEventLabel.Location = new Point(0, 0);
            nameEventLabel.Name = "nameEventLabel";
            nameEventLabel.RightToLeft = RightToLeft.No;
            nameEventLabel.Size = new Size(182, 49);
            nameEventLabel.TabIndex = 0;
            nameEventLabel.Text = "Evento";
            nameEventLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel1.Location = new Point(259, 106);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1020, 535);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(259, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(224, 31);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Evento planificados";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 641);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(labelEventsPanel);
            Controls.Add(titleLabel);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "MainForm";
            RightToLeft = RightToLeft.No;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Heres Eventos";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)companyLogoPictureBox).EndInit();
            labelEventsPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
    private PictureBox companyLogoPictureBox;
    private Button button1;
    private Panel labelEventsPanel;
    private Label hourEventLabel;
    private Label dateEventLabel;
    private Label nameEventLabel;
    private Label GuestsEventLabel;
    private Label locationEventLabel;
    private Label actionsEventLabel;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button removeAllButton;
    private Label titleLabel;
    private ContextMenuStrip contextMenuStrip1;
    }
}

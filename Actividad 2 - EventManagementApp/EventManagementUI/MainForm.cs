using System.Windows.Forms;
using EventsLibrary;

namespace EventManagementUI
{
    public partial class MainForm : Form
    {
        private EventManager eventManager;
        public MainForm()
        {
            InitializeComponent();
            eventManager = new EventManager();

            eventManager.EventAdded += EventManager_EventAdded;
            eventManager.EventUpdated += EventManager_EventUpdated;


            //Agrega lista de eventos de prueba
            var eventsTest = new[]
            {
                new EventData{ eventName = "Cena de Gala", eventDate = "15/12/2024", eventTime= "7:00 p. m.", eventLocation = "Gran Salón F", eventGuest= "120" },
                new EventData{ eventName = "Reunión Corporativa", eventDate = "20/09/2024", eventTime= "9:00 a. m.", eventLocation= "Sala Ejecutiva G", eventGuest= "50" },
                new EventData{ eventName = "Exposición de Arte", eventDate= "03/11/2024", eventTime = "10:00 a. m.", eventLocation= "Galería H", eventGuest= "300" },
                new EventData{ eventName = "Taller de Fotografía", eventDate = "12/10/2024", eventTime = "2:00 p. m.", eventLocation = "Sala de Talleres B", eventGuest= "25" },
                new EventData{ eventName = "Conferencia de Tecnología", eventDate = "28/10/2024", eventTime = "9:30 a. m.", eventLocation = "Centro de Convenciones C", eventGuest= "500" },
                new EventData{ eventName = "Presentación de Libro", eventDate = "08/12/2024", eventTime = "5:00 p. m.", eventLocation = "Biblioteca Central", eventGuest= "70" },
                new EventData{ eventName = "Clase de Cocina", eventDate = "22/11/2024", eventTime= "6:00 p. m.", eventLocation = "Cocina Escuela I", eventGuest= "30" }
            };

            foreach (var evento in eventsTest)
            {
                eventManager.AddEvent(evento);
            }

            LoadList();
        }

        private void createEventPanel(EventData eventData)
        {
            //Crea panel principal 
            Panel eventPanel = new Panel();
            eventPanel.Size = new Size(995, 50);
            eventPanel.BackColor = SystemColors.ControlLight;
            eventPanel.BorderStyle = BorderStyle.None;
            eventPanel.Margin = new Padding(0, 0, 0, 8);

            //Crea y configura los label 
            Label nameLabel = new Label();
            nameLabel.Text = eventData.eventName;
            nameLabel.Dock = DockStyle.Left;
            nameLabel.Size = new Size(182, 40);
            nameLabel.TextAlign = ContentAlignment.MiddleLeft;

            Label dateLabel = new Label();
            dateLabel.Text = eventData.eventDate;
            dateLabel.Dock = DockStyle.Left;
            dateLabel.Size = new Size(140, 40);
            dateLabel.TextAlign = ContentAlignment.MiddleLeft;

            Label timeLabel = new Label();
            timeLabel.Text = eventData.eventTime;
            timeLabel.Dock = DockStyle.Left;
            timeLabel.Size = new Size(115, 40);
            timeLabel.TextAlign = ContentAlignment.MiddleLeft;

            Label locationLabel = new Label();
            locationLabel.Text = eventData.eventLocation;
            locationLabel.Dock = DockStyle.Left;
            locationLabel.Size = new Size(200, 40);
            locationLabel.TextAlign = ContentAlignment.MiddleLeft;

            Label guestLabel = new Label();
            guestLabel.Text = eventData.eventGuest;
            guestLabel.Dock = DockStyle.Left;
            guestLabel.Size = new Size(135, 40);
            guestLabel.TextAlign = ContentAlignment.MiddleLeft;

            //Crea y configura botones de editar y eliminar
            Button editEventButton = new Button();
            editEventButton.Text = "Editar";
            editEventButton.Dock = DockStyle.Left;
            editEventButton.Size = new Size(110, 42);
            editEventButton.FlatStyle = FlatStyle.Flat;
            editEventButton.FlatAppearance.BorderColor = Color.Gray;
            editEventButton.Click += (sender, e) => EditarEvento(eventData);

            Button deleteEeventButton = new Button();
            deleteEeventButton.Text = "Eliminar";
            deleteEeventButton.Dock = DockStyle.Left;
            deleteEeventButton.Size = new Size(110, 42);
            deleteEeventButton.BackColor = Color.FromArgb(220, 40, 40);
            deleteEeventButton.ForeColor = Color.Transparent;
            deleteEeventButton.FlatStyle = FlatStyle.Flat;
            deleteEeventButton.FlatAppearance.BorderSize = 0;
            deleteEeventButton.Click += (sender, e) => deleteEventButton_click(eventPanel, eventData);

            //Agrega cada label al panel
            eventPanel.Controls.Add(deleteEeventButton);
            eventPanel.Controls.Add(editEventButton);
            eventPanel.Controls.Add(guestLabel);
            eventPanel.Controls.Add(locationLabel);
            eventPanel.Controls.Add(timeLabel);
            eventPanel.Controls.Add(dateLabel);
            eventPanel.Controls.Add(nameLabel);

            //Agrega el panel al panel principal
            flowLayoutPanel1.Controls.Add(eventPanel);
        }

        //Funcion de eliminacion de evento
        private void deleteEventButton_click(Panel panel, EventData eventData)
        {
            // Mostrar un mensaje de confirmacian
            var confirmResult = MessageBox.Show(
                "¿Estas seguro de que deseas eliminar este evento?",
                "Confirmar Eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (confirmResult == DialogResult.Yes)
            {
                flowLayoutPanel1.Controls.Remove(panel);
                eventManager.RemoveEvent(eventData);
            }
        }

        //Eliminacion de todos los eventos
        private void deleteAllEventsButton_Click(object sender, EventArgs e)
        {
            ClearList();
        }

        //Cargar lista de eventos guardados
        private void LoadList()
        {
            ClearList();
            foreach (var evento in eventManager.GetAllEvents())
            {
                createEventPanel(evento);
            }
        }
        //Limpia el panel principal 
        private void ClearList()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        //Abre el form de agregar nuevo evento
        private void addEventButton_Click(object sender, EventArgs e)
        {
            AddEventForm addEventForm = new AddEventForm(eventManager);
            addEventForm.ShowDialog();
        }

        //Abre el form de editar un evento
        private void EditarEvento(EventData eventData)
        {
            EditEventForm editEventForm = new EditEventForm(eventManager, eventData);
            editEventForm.ShowDialog();
        }

        //Agrega el evento recien creado al panel principal
        private void EventManager_EventAdded(EventData eventData)
        {
            createEventPanel(eventData);
        }
        //Recarga la lista de eventos luego de editar uno
        private void EventManager_EventUpdated(EventData originalEvent, EventData updatedEvent)
        {
            LoadList();
        }
    }
}

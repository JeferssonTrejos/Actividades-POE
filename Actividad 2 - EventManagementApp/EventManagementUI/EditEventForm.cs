using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventsLibrary;

namespace EventManagementUI
{
    public partial class EditEventForm : Form
    {
        private EventManager eventManager;
        private EventData originalEventData;
        private EventData editedEventData;

        public EditEventForm(EventManager eventManager, EventData eventData)
        {
            InitializeComponent();
            this.eventManager = eventManager;
            this.originalEventData = eventData;

            //Copia los datos originales para luego editar
            editedEventData = new EventData
            {
                eventName = eventData.eventName,
                eventDate = eventData.eventDate,
                eventTime = eventData.eventTime,
                eventLocation = eventData.eventLocation,
                eventGuest  = eventData.eventGuest
            };

            //Rellena los campos con los datos originales
            eventNameTextBox.Text = editedEventData.eventName;
            eventDateTimePicker.Text = editedEventData.eventDate;
            eventTimePicker.Text = editedEventData.eventTime;
            eventLocationTextBox.Text = editedEventData.eventLocation;
            eventGuestTextBox.Text = editedEventData.eventGuest;
        }

        private void saveEventButton_Click(object sender, EventArgs e)
        {
            //Valida los inputs 
            if (!validateInputs())
            {
                MessageBox.Show("Por favor, completa todos los campos correctamente.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Actualiza los datos editados
            editedEventData.eventName = eventNameTextBox.Text;
            editedEventData.eventDate= eventDateTimePicker.Value.ToShortDateString();
            editedEventData.eventTime= eventTimePicker.Value.ToShortTimeString();
            editedEventData.eventLocation = eventLocationTextBox.Text;
            editedEventData.eventGuest = eventGuestTextBox.Text;


            //Actualiza el evento en el EventManager
            eventManager.UpdateEvent(originalEventData, editedEventData);

            //Cierra el formulario
            this.Close();
        }
        private bool validateInputs()
        {
            //Verifica que todos los campos esten llenos
            if (string.IsNullOrWhiteSpace(eventNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(eventLocationTextBox.Text) ||
                string.IsNullOrWhiteSpace(eventGuestTextBox.Text))
            {
                return false;
            }
            return true;
        }
    }
}

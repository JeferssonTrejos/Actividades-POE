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
    public partial class AddEventForm : Form
    {
        private EventManager eventManager;

        public AddEventForm(EventManager eventManager)
        {
            InitializeComponent();
            this.eventManager = eventManager;
        }

        private void addEventButton_Click(object sender, EventArgs e){
            // Validar inputs
            if (!validateInputs())
            {
                MessageBox.Show("Por favor, completa todos los campos correctamente.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Obtener los datos del formulario
            string eventName = eventNameTextBox.Text;
            string eventDate = eventDateTimePicker.Value.ToShortDateString();
            string eventTime = eventTimePicker.Value.ToShortTimeString();
            string eventLocation = eventLocationTextBox.Text;
            string eventGuest = eventGuestTextBox.Text;

            //Crea un nuevo objeto de evento
            EventData newEvent = new EventData
            {
                eventName = eventName,
                eventDate = eventDate,
                eventTime = eventTime,
                eventLocation = eventLocation,
                eventGuest = eventGuest
            };

            //Agregar el nuevo evento
            eventManager.AddEvent(newEvent);

            //Cerrar el formulario
            this.Close();
        }

        //Verificar que todos los campos esten llenos
        private bool validateInputs(){
            if (
                string.IsNullOrWhiteSpace(eventNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(eventLocationTextBox.Text) ||
                string.IsNullOrWhiteSpace(eventGuestTextBox.Text)
                )
            {
                return false;
            }

            return true;
        }
    }
}

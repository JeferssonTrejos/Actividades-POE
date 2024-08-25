using System;
using System.Collections.Generic;

namespace EventsLibrary
{
    public class EventManager
    {
        public delegate void EventAddedHandler(EventData eventData);
        public delegate void EventUpdatedHandler(EventData originalEvent, EventData updatedEvent);

        public event EventAddedHandler EventAdded;
        public event EventUpdatedHandler EventUpdated;

        private List<EventData> events;

        public EventManager()
        {
            events = new List<EventData>();
        }

        //Metodo para agregar un nuevo eventos
        public void AddEvent(EventData eventData)
        {
            events.Add(eventData);
            EventAdded?.Invoke(eventData);
        }

        //Metodo para actualizar un evento
        public void UpdateEvent(EventData originalEvent, EventData updatedEvent)
        {
            var index = events.IndexOf(originalEvent);
            if (index != -1)
            {
                events[index] = updatedEvent;
                EventUpdated?.Invoke(originalEvent, updatedEvent);
            }
        }

        //Metodo para eliminar un evento
        public void RemoveEvent(EventData eventData)
        {
            events.Remove(eventData);
        }

        //Metodo para obtener todos los eventos guardados
        public List<EventData> GetAllEvents()
        {
            return events;
        }
    }
}

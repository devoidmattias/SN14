using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Guestbook.Models
{
    public class GuestbookDb
    {
        // We are using the list and _fakeDatabaseID to represent what would
        // most likely be a database of some sort, with an auto-incrementing ID field:
        private List<Message> _messages = new List<Message>();
        private int _fakeDatabaseID = 1;


        public GuestbookDb()
        {
            // For the moment, we will load some sample data during initialization. 
            Add(new Message { Created = new DateTime(2013, 12, 01, 10, 32, 23), Header = "Lorem ipsum", Body = "Eam ne nemore splendide, mei cu facilis singulis.", Name = "Sara"});
            Add(new Message { Created = new DateTime(2014, 07, 27, 18, 01, 38), Header = "Nam case blandit an", Body = "Pri eu labitur constituam, id per illum putant concludaturque.", Name = "Mattias", Email = "mattias@devoid.se" });
            Add(new Message { Created = new DateTime(2013, 12, 01, 10, 32, 23), Header = "Postea appetere cum ex", Body = "Quo reque scribentur referrentur at, eos vocibus fastidii torquatos id, convenire dignissim est ad.", Name = "Kalle"});
        }

        public IEnumerable<Message> Messages
        {
            get { return _messages; }

        }

      
        public Message Get(int id)
        {
            return _messages.Find(p => p.Id == id);
        }

        public Message Add(Message message)
        {
            if (message == null)
            {
                throw new ArgumentNullException("message");
            }

            if (string.IsNullOrWhiteSpace(message.Header) ||
                string.IsNullOrWhiteSpace(message.Name))
            {
                throw new ValidationException("Validation failed for the entity.");
            }

            message.Id = _fakeDatabaseID++;
            _messages.Add(message);
            return message;
        }

        public void Remove(int id)
        {
            _messages.RemoveAll(p => p.Id == id);
        }

        public bool Update(Message message)
        {
            if (message == null)
            {
                throw new ArgumentNullException("message");
            }
            int index = _messages.FindIndex(m => m.Id == message.Id);
            if (index == -1)
            {
                return false;
            }
            _messages.RemoveAt(index);
            _messages.Add(message);
            return true;
        }
    }
}
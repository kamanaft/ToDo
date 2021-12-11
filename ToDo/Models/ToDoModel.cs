using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Models
{
    internal class ToDoModel: INotifyPropertyChanged
    {
        private bool _isDone;
        private string _text;

        [JsonProperty(PropertyName = "creationDate")]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        // event changing data
        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty(PropertyName = "isDone")]
        public bool IsDone
        {
            get { return _isDone; }
            set 
            { 
                if (_isDone == value)
                    return;
                _isDone = value;
                OnPropertyChanged("IsDone");
            }
        }
        [JsonProperty(PropertyName = "text")]
        public string Text
        {
            get { return _text; }
            set 
            { 
                if (_text == value)
                    return;
                _text = value;
                OnPropertyChanged("Text");
            }
        }   
       
        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

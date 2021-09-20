using System;
using System.Collections.Generic;
using System.Text;

namespace KSharpEditor.DTOs.Interface
{
    public interface IButton
    {
        public string Name { get; set; }
        public bool Visible { get; set; }
        void SetVisibility(bool IsVisible);
        public string icon { get; set; }

    }

    public abstract class Button : IButton 
    {
        public string Name { get; set; }
        public bool Visible { get; set; }
        public string icon { get; set; }
        public Button(string Name)
        {
            this.Name = Name;
        }

        public void SetVisibility(bool IsVisible) 
        {
            this.Visible = IsVisible;
        }

    }
}

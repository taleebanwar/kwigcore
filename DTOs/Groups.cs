using System;
using System.Collections.Generic;
using System.Text;
using KSharpEditor.DTOs.Interface;
using KSharpEditor.DTOs.Buttons;

namespace KSharpEditor.DTOs.Groups
{
    public class GenericGroup : IGroups
    {
        public List<IButton> buttons { get; set; }
        public string Name { get; set; }
        public GenericGroup(string name)
        {
            this.Name = name;
            buttons = new List<IButton>();
        }

        
    }

    //public class Headings: IGroups
    //{
    //    public IButton[] buttons { get; set; }
    //}
}

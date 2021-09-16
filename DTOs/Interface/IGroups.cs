using System;
using System.Collections.Generic;
using System.Text;

namespace KSharpEditor.DTOs.Interface
{
    public interface IGroups
    {
        public string Name { get; set; }
        public List<IButton> buttons { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using KSharpEditor.DTOs.Interface;
using KSharpEditor.DTOs.Buttons;

namespace KSharpEditor
{
    public class ButtonBuilder
    {
        IGroups _group;
        IButton _button;
        public ButtonBuilder(IGroups group)
        {
            _group = group;
            _button = new GenericButton($"{group.Name}_{_group.buttons.Count}");
        }

        public ButtonBuilder SetName(string name)
        {
            _button.Name = name;
            return this;
        }

        public ButtonBuilder SetVisibility(bool isVisible)
        {
            _button.Visible = isVisible;
            return this;
        }

        public ButtonBuilder SetIcon(string faIcon) 
        {
            _button.icon = faIcon;
            return this;
        }

        public IButton Build()
        {
            _group.buttons.Add(_button);
            return _button;
        }
    }
}

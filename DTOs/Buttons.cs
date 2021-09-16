using System;
using System.Collections.Generic;
using System.Text;
using KSharpEditor.DTOs.Interface;

namespace KSharpEditor.DTOs.Buttons
{
    public class GenericButton: Button
    {
        public GenericButton(string name): base(name)
        {
            base.SetVisibility(true);
        }
    }
}

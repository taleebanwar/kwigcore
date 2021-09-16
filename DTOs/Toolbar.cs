using System;
using System.Collections.Generic;
using System.Text;
using KSharpEditor.DTOs.Interface;
using KSharpEditor.DTOs.Groups;

namespace KSharpEditor.DTOs
{
    public class Toolbar
    {
        public List<IGroups> Groups { get; set; }
        public Toolbar()
        {
            Groups = new List<IGroups>();
        }

        public virtual void Modify() { }

        public sealed override string ToString()
        {
            StringBuilder response = new StringBuilder();
            foreach (var group in Groups)
            {
                response.Append($"[\"{group.Name}\", [");
                foreach (var button in group.buttons)
                {
                    if (button.Visible)
                    {
                        response.Append($",\"{button.Name}\"");
                    }
                }
                response.AppendLine("]],");
            }
            return $"[{response?.ToString().Replace("[,", "[").Trim(Environment.NewLine.ToCharArray()).Trim(' ', ',')}]";
        }
    }
}

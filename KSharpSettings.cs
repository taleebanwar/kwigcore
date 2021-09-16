using System;
using System.Collections.Generic;
using System.Text;
using KSharpEditor.DTOs;
using KSharpEditor.DTOs.Groups;
using KSharpEditor.DTOs.Buttons;
using KSharpEditor.DTOs.Interface;

namespace KSharpEditor
{
    internal class KSharpSettings
    {
        private Dictionary<string, string> initialToolbarItems = new Dictionary<string, string>
        {
            { "file", "openFile, save" },
            { "heading", "style" },
            { "style", "bold, italic, underline, clear" },
            { "font", "strikethrough, superscript, subscript, fontname, fontsize, color" },
            { "para", "ul, ol, paragraph, height" },
            { "misc", "table, hr, insertImage" },
            { "insert", "link, video" },
        };

        Toolbar _toolbar;
        public KSharpSettings(Toolbar toolbar)
        {
            _toolbar = toolbar;
        }

        public string GetToolbars()
        {
            _toolbar = new Toolbar();
            foreach (KeyValuePair<string, string> item in initialToolbarItems)
            {
                IGroups groups = new GenericGroup(item.Key.Trim());
                foreach (var itm in item.Value.Split(','))
                {
                    groups.buttons.Add(new GenericButton(itm.Trim()));
                }

                _toolbar.Groups.Add(groups);
            }

            _toolbar.Modify();
            
            return _toolbar.ToString();
        }
    }
}

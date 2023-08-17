using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maui_blazor_hybrid_project.Models;

public class NotePadModel
{
    public string Title { get; set; }
    public DateTime DateAndTime { get; set; } = DateTime.Now;
    public string Description { get; set; }
    public bool IsEditing { get; set; }

}

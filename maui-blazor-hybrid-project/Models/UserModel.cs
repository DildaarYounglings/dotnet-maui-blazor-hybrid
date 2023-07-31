using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maui_blazor_hybrid_project.Models;
public class UserModel
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public bool IsEditing { get; set; }
    public bool IsActive { get; set; }
}

using EFSQLite.Data;
using EFSQLite.Models;

namespace EFSQLite;

public partial class DetailPage : ContentPage
{
	public string Vystup { get; set; }
	MyContext _context;
	public DetailPage(int id, MyContext context)
	{
		_context = context;
        Student? s = _context.Students.FirstOrDefault(x => x.Id == id);
        if (s != null)
        {
            Vystup = $"Student s Id {s.Id} jménem {s.Name} a pøijmením {s.Surname} ";
        }
        InitializeComponent();
		BindingContext = this;

	
	}
}
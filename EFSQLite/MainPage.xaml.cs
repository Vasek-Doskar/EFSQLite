using EFSQLite.Data;
using EFSQLite.Models;
using System.Runtime.InteropServices.ObjectiveC;

namespace EFSQLite;

public partial class MainPage : ContentPage
{
	MyContext _context;

	public MainPage()
	{
		_context = new();
		InitializeComponent();
		lst.ItemsSource = _context.Students.ToList(); // připojení zdroje dat k ListView

	}

	private void SaveStudent(object sender, EventArgs e)
	{
		Student newStudent = new() 
		{
			Name = forName.Text,
			Surname = forSurname.Text 
		};

		_context.Add(newStudent); // přidá záznam do Data Setu
		_context.SaveChanges(); // Uloží data do databáze!!!
	}


}


namespace NotesJosueValencia.ViewModels;

internal class AboutJVViewModel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Version { get; set; }
    public string Author { get; set; }

    public AboutJVViewModel()
    {
        Title = "Notes Josue Valencia";
        Description = "Esta aplicación permite crear, editar y gestionar tus notas personales.";
        Version = "1.0.0";
        Author = "Josue Valencia";
    }

    public string GetAppInfo()
    {
        return $"{Title} - Versión {Version}\nDesarrollado por {Author}";
    }
}

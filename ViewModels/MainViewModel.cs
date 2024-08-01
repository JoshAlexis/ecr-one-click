using System.Collections.ObjectModel;

namespace EcrOneClick.ViewModels;

public class MainViewModel
{
    public ObservableCollection<string> Images { get; set; }

    public MainViewModel()
    {
        Images = new ObservableCollection<string>()
        {
            "Redis",
            "Mysql"
        };
    }
}
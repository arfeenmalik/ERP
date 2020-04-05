using Serenity.Navigation;
using Administration = ERP.Administration.Pages;
using MyPages = ERP.test.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]

[assembly: NavigationLink(2000, "MovieTutorial", typeof(MyPages.MovieController), icon: null)]
[assembly: NavigationLink(2100, "MovieTutorial/Movie", typeof(MyPages.MovieController), icon: null)]

[assembly: NavigationLink(2200, "MovieTutorial/Genre", typeof(MyPages.GenreController), icon: null)]
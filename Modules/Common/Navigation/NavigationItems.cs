﻿using Serenity.Navigation;
using MyPages = MovieDB.MovieData.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]

[assembly: NavigationMenu(2000, "Movie Data", icon: "fa-database")]
[assembly: NavigationLink(int.MaxValue, "Movie Data/Movie", typeof(MyPages.MovieController), icon: "fa-video-camera")]
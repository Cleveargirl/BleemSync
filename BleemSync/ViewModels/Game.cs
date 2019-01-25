﻿using BleemSync.Services.ViewModels;
using System;
using System.ComponentModel.DataAnnotations;

namespace BleemSync.ViewModels
{
    public class Game
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Sort Name")]
        public string SortName { get; set; }
        public string Description { get; set; }

        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        public int? Players { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public int ParentId { get; set; }

        public Game() { }

        public Game(CentralGame game)
        {
            Id = game.Id;
            Name = game.Title;
            SortName = game.CommonTitle;
            ReleaseDate = game.DateReleased;
            Players = game.Players;
            Developer = game.Developer;
            Publisher = game.Publisher;
        }
    }
}

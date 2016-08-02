#region Copyright

// Maxotek CONFIDENTIAL INFORMATION
// © 2007-2016 Maxotek Inc.
// All Rights Reserved
//                                                                   
// This program contains confidential and proprietary information   
// of the Maxotek, Inc.  Any reproduction, disclosure, or use       
// in whole or in part is expressly prohibited, except as may be    
// specifically authorized by prior written agreement.

#endregion

#region Imports

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using vidly_aspnet_learn.Models;

#endregion

namespace vidly_aspnet_learn.ViewModels
{
    public class MovieFormViewModel
    {
        public MovieFormViewModel(Movie movie)
        {
            Name = movie.Name;
            GenreId = movie.GenreId;
            NumberInStock = movie.NumberInStock;
            ReleaseDate = movie.ReleaseDate;
            Id = movie.Id;
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public int? GenreId { get; set; }

        [Required]
        [DisplayName("Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [DisplayName("Number in Stock")]
        [Range(1, 20)]
        public short? NumberInStock { get; set; }
    }
}
// <copyright file="HelpTabViewModel.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace Microsoft.Teams.Apps.AskHR.Configuration.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Help tab view model
    /// </summary>
    public class HelpTabViewModel
    {
        /// <summary>
        /// Gets or sets help tab message text box to be used in View
        /// </summary>
        [Required(ErrorMessage = "Enter help tab text.")]
        [StringLength(maximumLength: 3000, ErrorMessage = "Help tab text should contain less than 3000 characters.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Help tab text")]
        public string HelpTabText { get; set; }
    }
}
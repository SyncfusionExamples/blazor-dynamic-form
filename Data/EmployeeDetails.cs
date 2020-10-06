using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Syncfusion.Blazor.Inputs;

namespace FormBuilder.Data
{
    public class EmployeeDetails
    {
        [Required]
        [Display(Name ="First Name")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Display(Name = "PhoneNumber")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DOB { get; set; }
        [Required]
        [DataType(DataType.Duration)]
        [Display(Name = "Total Experience")]
        [Range(0, 20, ErrorMessage = "The Experience range should be 0 to 20")]
        public decimal? TotalExperience { get; set; }
        [Required]
        [Display(Name = "Select a Country")]
        [DataType("DropdownList")]
        public string Country { get; set; }
        [Required]
        [Display(Name = "Select a City")]
        [DataType("ComboBox")]
        public string City { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Address")]
        public string Address { get; set; }
    }

    public class Countries
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public List<Countries> GetCountries()
        {
            List<Countries> Country = new List<Countries>
            {
                new Countries() { Name = "Australia", Code = "AU" },
                new Countries() { Name = "United Kingdom", Code = "UK" },
                new Countries() { Name = "United States", Code = "US" },
            };
            return Country;
        }
    }
    public class Cities
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string CountryCode { get; set; }
        public List<Cities> GetCities()
        {
            List<Cities> CityName = new List<Cities>
            {
                new Cities() { Name = "New York", CountryCode = "US", Code="US-101" },
                new Cities() { Name = "Virginia", CountryCode = "US", Code="US-102" },
                new Cities() { Name = "Washington", CountryCode = "US", Code="US-103" },
                new Cities() { Name = "Victoria", CountryCode = "AU", Code="AU-101" },
                new Cities() { Name = "Tasmania", CountryCode = "AU", Code="AU-102" },
                new Cities() { Name = "Queensland", CountryCode = "AU", Code="AU-103" },
                new Cities() { Name = "London", CountryCode = "UK", Code="UK-101" },
                new Cities() { Name = "Manchester", CountryCode = "UK", Code="UK-102" },
                new Cities() { Name = "Ashford", CountryCode = "UK", Code="UK-103" }
            };
            return CityName;
        }
    }
}

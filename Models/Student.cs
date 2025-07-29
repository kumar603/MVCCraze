using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVCraze.Models
{
    /*****************************************************************************************************
           Writer       : Kiran Kumar J
           Description  :To ensure data entered by the user meets the expected format and rules before
                            processing or saving it in the database. This prevents invalid data 
                            from propagating into the system.
           Created Date : 29 - July - 2025
           Created By   : Kiran Kumar
           Changed Date : 29 - July - 2025
           Changed By   : Kiran Kumar
           JIRA ID      : https://kiranjuvvanapudi.atlassian.net/browse/AMAECR-4
     *****************************************************************************************************/
    /*
     * MVC supports model validation using built-in data annotations, which are attributes applied directly to model properties. These are part of System.ComponentModel.DataAnnotations namespace.
     * Common Data Annotations:
     * [Required] : Makes the field mandatory
     * [StringLength(n)] : Limits string length
     * [Range(min, max)] : Numeric range constraints
     * [EmailAddress] : Validates email format
     * [RegularExpression] : Validates with regex
     * [Compare("Other")] : Compares with another property
     * [DataType] : Format hint (e.g., Email, Date, Password)
     * [Display(Name="")] : Sets label text for UI
     * [Key] :Primary key indicator (mostly for EF)
     */
    public class Student
    {
        [Key] //Key
        public int StudentId { get; set; }

        [Required(ErrorMessage ="Student Name is Required")]  //Required , StringLength
        [StringLength(50,ErrorMessage = "Name Cannot be exceed 50 characters")]
        public string Name { get; set; }

        [Range(18, 60,ErrorMessage ="Age must be between 18 to 60")] //Range
        public int Age { get; set; }

        [EmailAddress(ErrorMessage ="Invalid Email Address")] //EmailAddress
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)] //DataType , Password
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match")] //Compare
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.Date)] //DataType Date
        public DateTime DOB { get; set; }


    }
}
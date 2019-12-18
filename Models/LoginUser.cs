using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace ActivityCenter.Models
{
    public class LoginUser
    {
    [EmailAddress]
    [Required]
    public string Email {get; set;}
    [Required]
    [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    }
}
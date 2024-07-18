/* This is a simple Model (object) that will represent the RSVP from an invitee 
 Models are the most important part of ASP.NET aka Domain. It is how users will interact with the larger program or domain. Models represent
the real-world objects, processes, and rules that define the application also called domain). It contains domain objects aka C# objects that
make up the universe of the application and the methods to manipulate them.
*/

using System.ComponentModel.DataAnnotations; //This is the libray/namespace that allows to access validation rules known as attributes that .NET uses to validate data during the Model Binding Process
namespace PartyInvites.Models {
    public class GuestResponse {

        [Required(ErrorMessage = "Please enter your name")]
        public string? Name { get; set; } //All properties are nullable -> ?
        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        public string? Email { get; set;}
        [Required(ErrorMessage ="Please enter valid phone number")]
        public string? Phone { get; set;}
        [Required(ErrorMessage ="Please specify if you will attend")]
        public bool? WillAttend {get; set;}
    }
}
/* This is a simple Model (object) that will represent the RSVP from an invitee 
 Models are the most important part of ASP.NET aka Domain. It is how users will interact with the larger program or domain. Models represent
the real-world objects, processes, and rules that define the application also called domain). It contains domain objects aka C# objects that
make up the universe of the application and the methods to manipulate them.
*/

namespace PartyInvites.Models {
    public class GuestResponse {
        public string? Name { get; set; } //All properties are nullable -> ?
        public string? Email { get; set;}
        public string? Phone { get; set;}
        public bool? WillAttend {get; set;}
    }
}
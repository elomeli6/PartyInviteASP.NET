using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
/*
Here we add define an action method to that can recieve requests from a form -> part of the RSVP form
*/

namespace PartyInvites.Controllers;

public class HomeController : Controller
{
    public IActionResult Index(){
        return View();
    }

    //this is responsible for the view displayed after 
    //cliking RsvpForm link AND we declared that this method should ONLY be used for GET requests
    //Razor will the use the name of the action method(RsvpForm)find the view with that name and render it
    [HttpGet] 
    public ViewResult RsvpForm(){
        return View();
    }

    //Overloaded RsvpForm() method to accept GuestResponse objects, applying [HttpPost]attribute
    //means that it will handle Post request
    [HttpPost]
    public ViewResult RsvpForm(GuestResponse guestResponse){
        Repository.AddResponse(guestResponse);
        return View("Thanks", guestResponse); //Need to create a Thanks.cshtml RazorView
    }
    
    public ViewResult ListResponses () {
        return View(Repository.Responses.Where(r => r.WillAttend == true));
    }
}

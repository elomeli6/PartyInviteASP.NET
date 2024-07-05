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
    public ViewResult RsvpForm() {   //Razor will the use the name of the action method(RsvpForm)find the view with that name and render it
        return View();
    }
}

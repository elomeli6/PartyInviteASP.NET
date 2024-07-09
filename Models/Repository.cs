// This is temp storage to store guest responses
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;


namespace PartyInvites.Controllers{
    public static class Repository {
        private static List<GuestResponse> responses = new();

        public static IEnumerable<GuestResponse> Responses => responses;

        public static void AddResponse (GuestResponse response) {
            Console.WriteLine (response);
            responses.Add (response);
        }
    }
}
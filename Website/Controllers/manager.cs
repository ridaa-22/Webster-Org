using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Website.Data;
using Website.Models;

namespace Website.Controllers
{
    public class manager : Controller
    {
        WebsiteContext bridge;

        public manager(WebsiteContext _bridge)
        {
            bridge = _bridge;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Manager")]
        public IActionResult managerdash()
        {
            return View();
        }
        public IActionResult Candidate()
        {

            return View();
        }
        public IActionResult Candidateuser(Candidate ct)
        {
            var candidate = new Candidate
            {
                Firstname = ct.Firstname,
                Lastname = ct.Lastname,
                Email = ct.Email,
                DOB = ct.DOB,
                Gender = ct.Gender,
                PhoneNumber = ct.PhoneNumber,
                Address = ct.Address,
                City = ct.City,
                Qualification = ct.Qualification,
                University = ct.University,
                ExperienceYear = ct.ExperienceYear,
                CNIC = ct.CNIC,
                Skills = ct.Skills,
                Status = ct.Status,
                Password = ct.Password
            };

            bridge.candidates.Add(candidate);
            bridge.SaveChanges();
            return View("Candidate");
        }
        public IActionResult FetchCandidate()
        {

            return View(bridge.candidates.ToList());
        }
    }
}

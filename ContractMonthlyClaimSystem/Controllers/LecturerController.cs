using Microsoft.AspNetCore.Mvc;
using ContractMonthlyClaimSystem.Data;
using ContractMonthlyClaimSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class LecturerController : Controller
    {
        private readonly AppDbContext _context;

        public LecturerController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Lecturer Dashboard
        public IActionResult Dashboard()
        {
            var userId = 1; // user ID from authentication
            var claims = _context.Claims
                                 .Where(c => c.UserID == userId)
                                 .Include(c => c.Documents)
                                 .OrderByDescending(c => c.SubmissionDate)
                                 .ToList();

            // Dashboard stats
            var totalClaims = claims.Count;
            var pending = claims.Count(c => c.ClaimStatus == "Pending");
            var approved = claims.Count(c => c.ClaimStatus == "Approved");
            var rejected = claims.Count(c => c.ClaimStatus == "Rejected");

            ViewBag.TotalClaims = totalClaims;
            ViewBag.PendingClaims = pending;
            ViewBag.ApprovedClaims = approved;
            ViewBag.RejectedClaims = rejected;

            return View(claims); // pass claims to the view
        }


        // GET: My Claims
        public IActionResult Claims()
        {
            var userId = 1; //user id
            var claims = _context.Claims
                                 .Where(c => c.UserID == userId)
                                 .Include(c => c.Documents)
                                 .OrderByDescending(c => c.SubmissionDate)
                                 .ToList();

            return View(claims);
        }

        // GET: AddClaim
        public IActionResult AddClaim()
        {
            return View();
        }

        // POST: AddClaim
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddClaim(Claim claim, List<IFormFile>? files)
        {
            Console.WriteLine("Form posted!");
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Invalid model");
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                Console.WriteLine(string.Join(", ", errors));


                // Debug: log errors
                //var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                //Console.WriteLine(string.Join(", ", errors));
                return View(claim);
            }

            // user ID
            claim.UserID = 1;
            claim.ClaimStatus = "Submitted";
            claim.SubmissionDate = DateTime.Now;

            // Add claim to DB
            _context.Claims.Add(claim);
            _context.SaveChanges();

            //Handle file uploads 
            if (files != null && files.Count > 0)
            {
                Console.WriteLine($"Files uploaded: {files.Count}");
                string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");

                if (!Directory.Exists(uploadPath))
                    Directory.CreateDirectory(uploadPath);

                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        string filePath = Path.Combine(uploadPath, file.FileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }

                        _context.Documents.Add(new Document
                        {
                            ClaimID = claim.ClaimID,
                            FileName = file.FileName,
                            UploadDate = DateTime.Now
                        });
                    }
                }

                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("⚠️ No files were uploaded!");
            }

            return RedirectToAction("Dashboard");
        }

        [HttpPost]
        public IActionResult TestRedirect()
        {
            return RedirectToAction("Dashboard");
        }

        // GET: View Claim Details
        public IActionResult ViewClaim(int id)
        {
            var claim = _context.Claims
                                .Include(c => c.Documents)
                                .FirstOrDefault(c => c.ClaimID == id);

            if (claim == null)
                return NotFound();

            return View(claim);
        }
    }
}

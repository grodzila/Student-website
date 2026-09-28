using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentWebsite.Models;

namespace StudentWebsite.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(CreateStudent());
    }

    public IActionResult Courses()
    {
        var courses = new List<Course>
        {
            new("SODV 3301", "Software Development Techniques", "Learn the techniques and best practices for developing high-quality software."),
            new("SODV 3201", "Web Programming Foundations", "Learn the fundamentals of web programming with HTML, CSS, and JavaScript."),
            new("DESN 3203", "Web Design and Development", "Learn the principles and practices of designing and developing effective web experiences."),
            new("MTH 3901", "Mathematics for Software Development", "Explore the mathematical concepts and techniques that underpin software development."),
            new("SODV 3302", "Systems Development and Object Oriented Design", "Learn how to design and implement software systems using object-oriented principles.")
        };
        return View(courses);
    }

    public IActionResult About()
    {
        return View(CreateStudent());
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    private static Student CreateStudent() => new()
    {
        Name = "Stephen Babatunde",
        Program = "Software Development PostDiploma",
        Year = "First-year student",
        Introduction = "I am a curious person and a problem-solver who enjoys turning ideas into something useful, welcoming digital experiences.",
        Background = "My interest in technology started wih dismantling gadjects and wanting to see what is inside the gadjet with a love of figuring out how things work. Today, I am building a strong foundation in programming, web development using HTML, CSS, and JavaScript and  Python Programming language.",
        Interests = new List<string> { "Building web applications", "User experience design", "Learning new technologies", "Hiking and photography" },
        CareerGoal = "After graduation, I hope to begin a career as a full-stack web developer and build software that makes everyday tasks simpler for people."
    };
}

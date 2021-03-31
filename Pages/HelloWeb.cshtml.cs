using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using net_on_the_web.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Win32.SafeHandles;

namespace net_on_the_web.Pages
{
    public class HelloWebModel : PageModel
    {
        public Student Laila;
        public Student Sarah;
        public Student Ahmed;
        public Student Alaa;
        
       
        public string Message { get; set; } = "In page model: ";
        public void OnGet()
        {
        Teacher Faisal = new Teacher(10, "Faisal");
        Teacher Sami = new Teacher(100, "Sami");
        Class lamarr = new Class(1, "lamarr", Faisal);
        Class Edison = new Class(2, "Edison", Sami);
        Laila = new Student(1,"Laila", lamarr);
        Sarah = new Student(2, "Sarah", Edison);
        Ahmed = new Student(3, "Ahmed", lamarr);
        Alaa = new Student(4, "Alaa", Edison);
        }
    }
}

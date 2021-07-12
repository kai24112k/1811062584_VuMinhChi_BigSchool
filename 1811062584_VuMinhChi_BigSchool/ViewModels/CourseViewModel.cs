using _1811062584_VuMinhChi_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _1811062584_VuMinhChi_BigSchool.ViewModels
{
    public class CourseViewModel
    {
        public int CourseId { get; set; }
        [Required(ErrorMessage = "Địa điểm không được trống")]
        public string Place { get; set; }

        [Required(ErrorMessage = "Ngày không được trống")]
        [FutureDate]
        public string Date { get; set; }

        [Required(ErrorMessage = "Thời gian không được trống")]
        [ValidTime]
        public string Time { get; set; }

        [Required(ErrorMessage = "Thể loại không được trống")]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
        public string Heading { get; set; }
        public string Action 
        {
            get { return (CourseId != 0) ? "Update" : "Create"; }
        }

    }
}
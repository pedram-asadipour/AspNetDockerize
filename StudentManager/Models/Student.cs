using System.ComponentModel.DataAnnotations;

namespace StudentManager.Models
{
    public class Student
    {
        public Student(string name, string family, int age, int gender)
        {
            Name = name;
            Family = family;
            Age = age;
            Gender = gender;
        }

        public Student()
        {

        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Family { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public int Gender { get; set; }
    }
}
